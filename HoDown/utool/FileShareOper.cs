using HoDown.domain;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HoDown.utool
{
    class FileShareOper
    {
        private string url = null;
        private string password = null;
        private CookieContainer cookies = new CookieContainer();

        List<ShareFile> shareFilelist;
        List<ShareFile_2> shareFile_2s;
        private string ukstr;
        private string share_id;
        public FileShareOper(string url,string password) 
        {
            this.url = url;
            this.password = password;
        }

        //带密码提交获取页面
        public List<ShareFile> GetpageStart()
        {
            string rs = HttpRequest.SendDataByGET(url, "", ref Common.cookies);
            if (rs.Contains("你所访问的页面不存在了"))
            {
                return null;
            }

            //if (rs.Contains("请输入提取码"))
            //{
                #region    原始代码
                //string liststr = "";
                //string ukstr = "";
                //string share_id = "";

                ////获取页面
                ////string Rstr = fileShareOper.Getpage(url,password,ref cookies);
                //MessageBox.Show(Rstr);
                ////获取uk参数
                //ukstr = new Regex("uk=[0-9]+").Match(Rstr).Value.Substring(3);
                ////获取share_id
                //share_id = new Regex("yunData.SHARE_ID = \"[0-9]+").Match(Rstr).Value.Substring(20);
                ////获取列表
                //Regex regex_str = new Regex(@"yunData\.FILEINFO =.+;");
                //liststr = (regex_str.Match(Rstr).Value.Replace("yunData.FILEINFO =", "")).Replace(";","");
                //MessageBox.Show(liststr);


                //List<ShareFile>  shareFilelist = JsonConvert.DeserializeObject<List<ShareFile>>(liststr);


                //string json = HttpRequest.SendDataByGET(
                //    "https://pan.baidu.com/share/list?uk=" + ukstr + "&shareid=" + share_id + "&order=other&desc=1&showempty=0&web=1&page=1&num=100&dir=" + HttpRequest.tourl(shareFilelist[1].Path),
                //    "", ref cookies);
                //MessageBox.Show(json);

                ////json反序列哈
                //JObject jsonObj = (JObject)JsonConvert.DeserializeObject(json);
                //List<ShareFile_2> shareFile_2d = JsonConvert.DeserializeObject<List<ShareFile_2>>(jsonObj["list"].ToString());

                //MessageBox.Show(shareFile_2d[0].Server_filename);


                ////保存文件
                ////https://pan.baidu.com/share/transfer?shareid=3579357180&from=3945083150&ondup=newcopy&async=1&channel=chunlei&web=1&app_id=250528
                //fileShareOper.SaveFile(share_id,ukstr,shareFile_2d[1].Server_filename,url);
                #endregion

                //带提取码请求
                string[] s = url.Split('/');
                Console.WriteLine("https://pan.baidu.com/share/verify?surl=" + s[s.Length - 1].Substring(1, 22));
                Console.WriteLine("pwd=" + password + "&vcode=&vcode_str=");
                CookieCollection cc = HttpRequest.SendDataByPostRcookies(
                    "https://pan.baidu.com/share/verify?surl=" + s[s.Length - 1].Substring(1, 22),
                    "pwd=" + password + "&vcode=&vcode_str=",
                    ref Common.cookies, url);
                cookies.Add(cc);
                Common.cookies.Add(cc);

            //}

            //获取页面
            string Rstr = HttpRequest.SendDataByGET(url, "", ref cookies);

            //获取uk参数
            ukstr = new Regex("uk=[0-9]+").Match(Rstr).Value.Substring(3);
            //获取share_id
            share_id = new Regex("shareid\":[0-9]+").Match(Rstr).Value.Substring(9);
            //获取列表
            Regex regex_str = new Regex("(\"list\":)(.+)(},\"uk\")");
            string liststr = regex_str.Match(Rstr).Groups[2].Value;
            Console.WriteLine(liststr);
            shareFilelist = JsonConvert.DeserializeObject<List<ShareFile>>(liststr);
            return shareFilelist;
        }

        public List<ShareFile_2> GetFilelist(string sharePath)
        {
            string json = HttpRequest.SendDataByGET(
                          "https://pan.baidu.com/share/list?uk=" + ukstr + "&shareid=" + share_id + "&order=other&desc=1&showempty=0&web=1&page=1&num=100&dir=" + HttpRequest.tourl(sharePath),
                          "", ref cookies);
            //json反序列哈
            JObject jsonObj = (JObject)JsonConvert.DeserializeObject(json);
            shareFile_2s = JsonConvert.DeserializeObject<List<ShareFile_2>>(jsonObj["list"].ToString());
            return shareFile_2s;
        }

        //保存文件
        public string SaveFile(string fs_id,string savepath)
        {

            Console.WriteLine("fsidlist=%5B" + fs_id + "%5D&path=" + savepath);
            return HttpRequest.SendDataByPost("https://pan.baidu.com/share/transfer?shareid=" + share_id + "&from=" + ukstr + "&ondup=newcopy&async=1&channel=chunlei&web=1&app_id=250528",
                       "fsidlist=%5B" + fs_id + "%5D&path="+savepath, ref Common.cookies, url);
        }
    }
}
