using HoDown.domain;
using HoDown.utool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace HoDown
{
    public partial class Form_OpenShare : Form
    {
        private string url;
        private string password;
        FileShareOper fileShareOper;
        List<ShareFile> shareFilelist;
        List<ShareFile_2> shareFilelist_2;
        Fileclass fileclass = new Fileclass();
        int deep = 0;
        public Form_OpenShare(string url,string password)
        {
            this.url = url;
            this.password = password;
            fileShareOper = new FileShareOper(url, password);
            InitializeComponent();
        }

        private void Form_OpenShare_Load(object sender, EventArgs e)
        {
            checkedListBox1.CheckOnClick = true;
            //MessageBox.Show(url+"\n"+password) ;
            shareFilelist = fileShareOper.GetpageStart();
            if (shareFilelist == null)
            {
                MessageBox.Show("页面错误");
                return;
            }

            foreach (ShareFile file in shareFilelist)
            {
                //TreeNode node = new TreeNode(file.Server_filename);
                //node.Name =file.Path;
                //treeView1.Nodes.Add(node);
                checkedListBox1.Items.Add(file.Server_filename);
            }

        }

        private void checkedListBox1_DoubleClick(object sender, EventArgs e)
        {
            int i = checkedListBox1.SelectedIndex;
            //MessageBox.Show(i.ToString());
            if (deep > 0)
            {
                if (!shareFilelist_2[i].Isdir.Equals("1"))
                {
                    return;
                }
            }
            else
            {
                if (!shareFilelist[i].Isdir.Equals("1"))
                {
                    return;
                }
            }
            if (i!=-1)
            {
                
                
                checkedListBox1.Items.Clear();
                if (shareFilelist_2 != null)
                {
                    shareFilelist_2.Clear();
                }
                if (deep > 0)
                {
                    shareFilelist_2 = fileShareOper.GetFilelist(shareFilelist_2[i].Path);
                }
                else
                {
                    shareFilelist_2 = fileShareOper.GetFilelist(shareFilelist[i].Path);
                }
                //MessageBox.Show(shareFilelist_2[0].Server_filename);
                deep++;

                if (shareFilelist_2!=null)
                {
                    foreach (ShareFile_2 file in shareFilelist_2)
                    {
                        checkedListBox1.Items.Add(file.Server_filename);
                    }
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            if (shareFilelist != null)
            {
                foreach (ShareFile file in shareFilelist)
                {
                    checkedListBox1.Items.Add(file.Server_filename);
                }
            }
            deep = 0;
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
            //int i = checkedListBox1.SelectedIndex;
            //if (i != -1)
            //{
            //    checkedListBox1.Items[i].
            //}
        }

        private void button2_取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_确定_Click(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            string name = "HoDonw_"+ Convert.ToInt64(ts.TotalSeconds).ToString();
            //MessageBox.Show(name);
            //创建一个文件夹
            HttpRequest.SendDataByPost(
                    "https://pan.baidu.com/api/create?a=commit&channel=chunlei&web=1&app_id=250528",
                    "path=" + "%2Fapps%2F"+HttpRequest.tourl(name) + "&isdir=1&block_list=%5B%5D",
                    ref Common.cookies
                    );
            string fileliststr = HttpRequest.tourl("/apps/" + name);
            string filelist_fid = GetFilelist();
            HttpRequest.tourl(filelist_fid);
            fileShareOper.SaveFile(filelist_fid, fileliststr);

            //添加下载任务
            List<FileBd> filelist =  fileclass.LoadFile("/apps");
            if (filelist == null)
            {
                return;
            }
            foreach (FileBd f in filelist)
            {
                if (f.Server_filename.Equals(name))
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
                    FileBd file = f;
                    new Task(new Action(() => {
                        fileclass.ParseFilesAsync(file);
                    })).Start();
                    MessageBox.Show("下载任务添加成功");
                    this.Close();
                }
            }
        }

        private void button3_保存到_Click(object sender, EventArgs e)
        {
            Form_shareSave form_Share = new Form_shareSave();
            DialogResult ds =  form_Share.ShowDialog();
            if (ds == DialogResult.OK)
            {
                fileShareOper.SaveFile(GetFilelist(), form_Share.SavePath);
                MessageBox.Show("操作完成");
                this.Close();
            }
            form_Share.Dispose();
            
        }


        private string GetFilelist()
        {
            string filelist_fid = "";
            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {

                int checkindex = checkedListBox1.CheckedIndices[i];
                if (deep > 0)
                {
                    filelist_fid += shareFilelist_2[checkindex].Fs_id;
                }
                else
                {
                    filelist_fid += shareFilelist[checkindex].Fs_id;
                }

                if (checkedListBox1.CheckedIndices.Count != 1 && i < checkedListBox1.CheckedIndices.Count - 1)
                {
                    filelist_fid += ",";
                }
            }

            return filelist_fid;
        }
    }
}
