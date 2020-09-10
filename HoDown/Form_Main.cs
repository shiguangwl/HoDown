using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HoDown.domain;
using HoDown.utool;
using System.Threading;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using CCWin;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using CCWin.SkinControl;
using System.Diagnostics;
using System.Security.Policy;
using Newtonsoft.Json.Linq;

namespace HoDown
{
    
    public partial class Form_Main : Skin_VS
    {
        public const int WM_CLIPBOARDUPDATE = 0x031D;
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool AddClipboardFormatListener(IntPtr hWnd);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RemoveClipboardFormatListener(IntPtr hWnd);

        private Process process;
        private Fileclass fileclass = new Fileclass();
        public Form_Main()
        {
            //初始化窗口
            //Form1 form1 = new Form1();
            //form1.ShowDialog();
            //form1.Dispose();

            

            InitializeComponent();
            blinkBrowser1.Url =  "file:///"+ Directory.GetCurrentDirectory() + "/HoData/AriaNg.html";

            #region listView添加列
            this.listView1.View = View.Details;
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.Columns.Add("文件名",550,HorizontalAlignment.Left);
            this.listView1.Columns.Add("大小",150,HorizontalAlignment.Left);
            this.listView1.Columns.Add("修改时间",200,HorizontalAlignment.Left);
            #endregion 
        }

        private void StartLoad()
        {
            //获取/设置cookies
            string cookiesstr = fileclass.GetCookiesFromFile("http://pan.pan.baidu.com");
            fileclass.Setcookiesformstring(cookiesstr);
            //加载文件 封装到对象
            List<FileBd> filelist = fileclass.LoadFile();

            if (filelist != null)
            {
                Common.isSign = true;
                //更新文件列表
                updatelist(filelist);
            }
            
        }



       //窗口加载事件 
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Common.isSign)
            {
                web_view.Visible = false;
                panel1_两个按钮.Visible = false;
                tabControl1.SelectedIndex = 0;
                StartLoad();
            }


            //打开下载器
            //System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"//HoData//start.exe");
            
            if (process == null || process.HasExited)
            {
                process = new Process();
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = "start.cmd";

                //info.Arguments = "--conf-path=baidu.ini";
                info.UseShellExecute = false;
                info.RedirectStandardInput = false;
                info.RedirectStandardOutput = false;
                info.CreateNoWindow = true;
                process.StartInfo = info;
                try
                {
                    process.Start();
                }
                catch
                {
                    process = null;
                    MessageBox.Show("启动加载失败:0");
                }

            }



            //剪切监听
            AddClipboardFormatListener(this.Handle);
            Message mes = new Message();
            DefWndProc(ref mes);
        }


        //更新文件列表
        public void  updatelist(List<FileBd> files)
        {
            //设置全局文件列表
            Common.filelist = files;
            listView1.Items.Clear();
            textBox2_viwepath.Text = Common.filePath;
            if (files!=null)
            {
                foreach (FileBd file in files)
                {
                    ListViewItem item;
                    if ("1".Equals(file.Isdir))
                    {
                        item = listView1.Items.Add(file.Server_filename, 1);
                        item.SubItems.Add("-");
                    }
                    else
                    {
                        item = listView1.Items.Add(file.Server_filename, 0);
                        item.SubItems.Add(fileclass.FormetFileSize(Convert.ToInt64(file.Size)));
                    }
                    item.SubItems.Add(fileclass.StampToDateTime(file.Local_mtime).ToString());
                }
            }
        }

        //当双击一个文件夹
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("双击了");
            int indexSelect = listView1.SelectedItems[0].Index;

            if (indexSelect != -1)
            {
                if (Common.filelist[indexSelect].Isdir.Equals("1"))
                {
                    Common.filePath = Common.filelist[indexSelect].Path;
                    //文件/文件夹路径
                    string filepath = Common.filelist[indexSelect].Path;
                    updatelist(fileclass.LoadFile(filepath));
                }
            }
        }

        //回到首页
        private void button1_回家_Click(object sender, EventArgs e)
        {
            Common.filePath = "/";
            updatelist(fileclass.LoadFile());
        }

        //右键下载实现
        private void 下载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int indexSelect = listView1.SelectedItems[0].Index;
            if (indexSelect != -1)
            {
                using (Form_DownPath downPath = new Form_DownPath())
                {

                    DialogResult dg = downPath.ShowDialog();
                    if (dg == DialogResult.OK)
                    {
                        Common.SavePathStatic = downPath.textBox1.Text;
                        //MessageBox.Show(Common.SavePathStatic);
                    }
                    else
                    {
                        return;
                    }

                }
                FileBd file = Common.filelist[indexSelect];
                new Task(new Action(() =>{
                    fileclass.ParseFilesAsync(file);
                })).Start();

                tabControl1.SelectedTab = tabPage2_Downlist;
            }
            
        }

        //页面跳转/判断是否登录
        private void timer2_Tick(object sender, EventArgs e)
        {
            string url1 = "https://pan.baidu.com/disk/home?errno=0&errmsg=Auth%20Login%20Sucess&&bduss=&ssnerror=0&traceid=#/all?path=%2F&vmode=list";
            string url2 = "https://pan.baidu.com/disk/home?#/all?path=%2F&vmode=list";

            if (web_view.Url.Equals(url1) || web_view.Url.Equals(url2))
            {
                timer2.Enabled = false;
                //MessageBox.Show("登录成功"+web_view.Url);


                if (!Common.isSign)
                {

                    web_view.Visible = false;
                    panel1_两个按钮.Visible = false;
                    StartLoad();
                }
            }
        }
        private void button3_登录完成未跳转_Click(object sender, EventArgs e)
        {
            StartLoad();
            if (Common.isSign)
            {
                web_view.Visible = false;
                panel1_两个按钮.Visible = false;
            }
        }
        private void button2_COOkie登录_Click(object sender, EventArgs e)
        {
            Form_cookielogin form_Cookielogin = new Form_cookielogin();
            DialogResult dg = form_Cookielogin.ShowDialog();
            if (dg == DialogResult.OK)
            {
                string cookiesstr = form_Cookielogin.textBox1.Text;
                //MessageBox.Show(Common.SavePathStatic);
                fileclass.Setcookiesformstring(cookiesstr);
                List<FileBd> fs = fileclass.LoadFile();
                if (fs != null && fs.Count > 0)
                {
                    Common.isSign = true;
                    web_view.Visible = false;
                    panel1_两个按钮.Visible = false;
                    StartLoad();
                }
                else
                {
                    MessageBox.Show("数据加载失败");
                }
            }
            else
            {
                return;
            }
        }

        private void button_退出_Click(object sender, EventArgs e)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\cookie\\cookies.dat"))
            {
                //MessageBox.Show(Directory.GetCurrentDirectory() + "\\cookie\\cookies.dat" +"存在");
                File.Delete(Directory.GetCurrentDirectory() + "\\cookie\\cookies.dat");
                MessageBox.Show("用户退出成功");
                
                System.Environment.Exit(0);
                //web_view.Visible = true;
                //panel1_两个按钮.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete(Directory.GetCurrentDirectory() + "\\cookie\\cookies.dat");
            web_view.Url = "http://pan.baidu.com";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            web_view.Visible = false;
            panel1_两个按钮.Visible = false;
            StartLoad();
        }

        //剪切板监听事件
        string clipboard_str = "";
        //链接
        Regex regex_url = new Regex("https://pan.baidu.com/s/.{23}");
        //密码
        Regex regex_password = new Regex(@"(提取码[：|:]\s*)(\w{4})");
        Form_shareSave form_ShareSave = new Form_shareSave();
        protected override void DefWndProc(ref Message m)
        {
            
            if (m.Msg == WM_CLIPBOARDUPDATE)
            {
                //Console.WriteLine("切板变动:"+Clipboard.GetText());
                //if (Clipboard.ContainsText())
                //{

                //    //判断是否为下载链接
                //    clipboard_str =  Clipboard.GetText();
                //    if (clipboard_str.Contains("pan.baidu.com/s/"))
                //    {
                //        string url = regex_url.Match(clipboard_str).Value;
                //        string password = regex_password.Match(clipboard_str).Groups[1].Value;
                //        //RemoveClipboardFormatListener(this.Handle);
                //        if (!form_ShareSave.Visible)
                //        {
                //            if (password.Equals("") || password.IsNull())
                //            {
                //                password = "空";
                //            }
                //            form_ShareSave.LoadStart(url, password);
                //            form_ShareSave.Show();
                //        }
                //    }

                //}
            }
            else
            {
                base.DefWndProc(ref m);
            }

            //博文链接http://xxhoz.com/2020/05/12/Csharp%E5%89%AA%E5%88%87%E6%9D%BF%E7%9B%91%E6%8E%A7%E5%90%84%E7%B1%BB%E6%95%B0%E6%8D%AE/
        }

        private void skinButton1_去登录_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button_打开链接_Click(object sender, EventArgs e)
        {

            string url = regex_url.Match(skinTextBox1_链接.Text).Value;
            string password = regex_password.Match(skinTextBox1_链接.Text).Groups[2].Value;
            if (!form_ShareSave.Visible)
            {
                if (password.Equals("") || password.IsNull())
                {
                    password = "空";
                }
                //form_ShareSave.LoadStart(url, password);
                //form_ShareSave.Show();

                Form_OpenShare form_OpenShare = new Form_OpenShare(url, password);
                form_OpenShare.ShowDialog();
                form_OpenShare.Dispose();

            }
        }

        //更改选项卡
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //退出程序
        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (process != null && !process.HasExited)
            {
                process.Kill();
            }
            System.Environment.Exit(0);
        }

        //显示界面
        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.ShowInTaskbar = false;
            this.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            e.Cancel = true;
            this.Visible = false;
        }
        //ces
        FileShareOper fileShareOper = new FileShareOper("","");
        private void button1_Click_1(object sender, EventArgs e)
        {
            CookieContainer cookies = new CookieContainer();
            
  
        }


    }
}