using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using HoDown.domain;
using HoDown;
using Newtonsoft.Json;
using aria2c;
using System.IO;
using System.Net;
using System.Threading;

namespace HoDown.utool
{
    class Fileclass
    {
        
        //加载文件封装对象
        public List<FileBd> LoadFile(string filePath="/")
        {

            string url = @"https://pan.baidu.com/api/list?order=time&desc=1&showempty=0&web=1&page=1&num=100&dir=";

            string postdata = HttpUtility.UrlEncode(filePath, System.Text.Encoding.UTF8);
            //请求数据
            string responS = HttpRequest.SendDataByGET(url + postdata, "", ref Common.cookies);
            //解析json数据
            FileRequeststate fileRequeststate = JsonConvert.DeserializeObject<FileRequeststate>(responS);
            if (!fileRequeststate.Errno.Equals("0"))
            {
                MessageBox.Show("数据获取失败,请登录");
            }
            return fileRequeststate.List;
        }
       
        //文件大小计算
        public String FormetFileSize(long fileS)
        {
            string bt=fileS.ToString();
            if (fileS < 1024)
            {
                bt = bt + "B";
            }
            else if (fileS < 1048576)
            {
                bt = Math.Round((double)(fileS / 1024)) + "K";
            }
            else if (fileS < 1073741824)
            {
                bt = Math.Round((double)fileS / 1048576) + "M";
            }
            else
            {
                bt = Math.Round((double)fileS / 1073741824) + "G";
            }
            return bt;
        }

        //将时间戳转时间
        public DateTime StampToDateTime(string timeStamp)
        {
            DateTime dateTimeStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dateTimeStart.Add(toNow);
        }

        //载解析文件地址
        public async Task ParseFilesAsync(FileBd files)
        {
            
            string temppath = new string(Common.filePath.ToArray());
            //异步处理防止堵塞界面卡死
            await GetParseFilesAsync(files, temppath);
            Common.filePath = temppath;

        }
        private FileDown fileDown = new FileDown();
        public async Task GetParseFilesAsync(FileBd files,string LISTpath)
        {

            bool status = await Aria2.ConnectServer("ws://127.0.0.1:6800/jsonrpc");
            if (!status)
            {
                MessageBox.Show("Aria2连接失,请启动/HoDown内 appLauncher.js or start.cmd");
                return;
            }
            //Form_Message form_Message = new Form_Message();
            FileBd file = files;
            Stack<FileBd> list = new Stack<FileBd>();
            list.Push(file);
            //form_Message.Show();
            while (list.Count > 0)
            {
                FileBd f = list.Pop();
                if ("0".Equals(f.Isdir))
                {
                    //form_Message.label1_message.Text = "加入下载队列:"+f.Server_filename;
                    //Common.fileDownList.Enqueue(f);
                    string url = "http://d.pcs.baidu.com/rest/2.0/pcs/file?app_id=778750&method=locatedownload&path="
                    + HttpUtility.UrlEncode(f.Path, System.Text.Encoding.UTF8);
                    string responS = HttpRequest.SendDataByGET(url, "", ref Common.cookies);
                    FilePares filePares = JsonConvert.DeserializeObject<FilePares>(responS);
                    fileDown.FileName = f.Server_filename;
                    fileDown.FileLink = "https://" + filePares.Server[0] + filePares.Path + "&filename=" + f.Server_filename;
                    fileDown.FileSave = f.Path.Replace(LISTpath+"/","");
                    Console.WriteLine("开始下载:"+fileDown.FileLink+ "\n"+ fileDown.FileSave);
                    string s =  await Aria2.AddUri(fileDown.FileLink, Common.SavePathStatic.Replace("\\","/") + fileDown.FileSave.Replace(fileDown.FileName,""));
                }
                else
                {
                    Console.WriteLine("文件夹："+f.Path);
                    Common.filePath = f.Path;
                    List<FileBd> files1 =  LoadFile(Common.filePath);
                    foreach (FileBd ff in files1)
                    {
                        list.Push(ff);
                    }
                }
            }

            //form_Message.Close();

            #region
            ////调试使用方便
            //foreach (FileBd ff in Common.fileDownList)
            //{
            //    Console.WriteLine(ff.ToString());
            //}
            #endregion 


            #region
            //if ("1".Equals(file.Isdir))
            //{
            //    Common.filePath = file.Path;
            //    Fileclass.LoadFile(true);



            //    //List<FileBd> filelist = new List<FileBd>();
            //    //foreach (FileBd fle in Common.filelist)
            //    //{
            //    //    filelist.Add(file.DeepCopy());
            //    //}



            //    //MessageBox.Show(filelist[0].Server_filename);
            //    //MessageBox.Show(filelist[1].Server_filename);


            //    //foreach (FileBd f in filelist)
            //    //{
            //    //    GetParseFiles(f);
            //    //}

            //}
            //else
            //{
            //    string url = "http://d.pcs.baidu.com/rest/2.0/pcs/file?app_id=778750&method=locatedownload&path=" 
            //        + HttpUtility.UrlEncode(file.Path, System.Text.Encoding.UTF8);
            //    string responS = HttpRequest.SendDataByGET(url, "", ref Common.cookies);
            //    FilePares filePares = JsonConvert.DeserializeObject<FilePares>(responS);

            //    fileDown.FileName = file.Server_filename;
            //    fileDown.FileLink = "https://" + filePares.Server[0] + filePares.Path + "&filename=" + file.Server_filename;
            //    fileDown.FileSave = file.Path;
            //    Console.WriteLine(fileDown.ToString());
            //    Common.fileDownList.Enqueue(fileDown);
            //}
            #endregion

        }



        /// <summary>
        /// 解析 cookies.dat文件得到Cookie,没有判断 path，只有 域的判断
        /// </summary>
        public string GetCookiesFromFile(string url)
        {
            StringBuilder sbCookie = new StringBuilder();
            if (File.Exists(Directory.GetCurrentDirectory() + "\\cookie\\cookies.dat"))
            {

                var uri = new Uri(url);
                var host = uri.Host;
                var allCookies = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\cookie\\cookies.dat");
                for (int i = 4; i < allCookies.Length; i++)
                {
                    host = uri.Host;
                    var listCookie = allCookies[i].Split('\t');
                    if (listCookie != null && listCookie.Length != 0 && listCookie.Length == 7)
                    {
                        var _cookie = listCookie[0];

                    Lable:
                        if (_cookie == host)
                        {
                            sbCookie.AppendFormat("{0}={1};", listCookie[5], listCookie[6]);
                        }
                        //httponly
                        var httpOnly = "#HttpOnly_" + host;
                        if (_cookie == httpOnly)
                        {
                            sbCookie.AppendFormat("{0}={1};", listCookie[5], listCookie[6]);
                        }
                        if (host.IndexOf('.') == 0)// . 开头
                        {
                            host = host.Substring(host.IndexOf('.') + 1);//. 开头 去掉 .
                            goto Lable;
                        }
                        else
                        {
                            if (host.TrimStart('.').Split('.').Length > 2)
                            {
                                host = host.Substring(host.IndexOf('.'));//带 . 
                                goto Lable;
                            }
                        }
                    }

                }
            }
            return sbCookie.ToString();
        }


        /// <summary>
        /// 将cookies字符串封装
        /// </summary>
        public void Setcookiesformstring(string cookiesstr)
        {
            Cookie cookie1 = new Cookie();
            string[] cookies = cookiesstr.Split(';');
            string s = null;
            for (int i = 0; i < cookies.Length - 1; i++)
            {
                s = cookies[i];
                //Console.WriteLine(s);
                string[] cookie = s.Split('=');
                
                cookie1.Name = cookie[0];
                cookie1.Value = cookie[1];

                if ("STOKEN".Equals(cookie[0]))
                {
                    cookie1.Domain = ".pan.baidu.com";
                    Common.cookies.Add(cookie1);

                }
                else if ("BDUSS".Equals(cookie[0]))
                {
                    cookie1.Domain = ".baidu.com";
                    Common.cookies.Add(cookie1);
                }
            }
        }


        public void DeleteFile()
        {
            //filelist=%5B%22%2FFilmImpact.net+Transition+Packs+V3.6.15+CE+%E8%BF%87%E6%B8%A1%E8%BD%AC%E5%9C%BA%E7%A7%8B%E6%9E%AB%E4%B8%AD%E6%96%87%E6%B1%89%E5%8C%96.rar%22%5D
        }
    }
}