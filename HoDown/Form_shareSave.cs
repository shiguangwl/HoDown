using CCWin;
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
using HoDown.Properties;

namespace HoDown
{
    public partial class Form_shareSave : Skin_Mac
    {
        Fileclass fileclass = new Fileclass();
        public string SavePath;
        public Form_shareSave()
        {
            this.TopMost = true;
            InitializeComponent();
        }
        public void LoadStart()
        {
            
        }
        private void Form_shareSave_Load(object sender, EventArgs e)
        {
            
            treeView1.CheckBoxes = false;
            TreeNode root = new TreeNode("全部文件");
            root.Name = "/";
            treeView1.Nodes.Add(root);

            List<FileBd> list = fileclass.LoadFile();
            foreach (FileBd f in list)
            {
                if ("1".Equals(f.Isdir))
                {
                    TreeNode node = new TreeNode(f.Server_filename);
                    node.Name = f.Path;
                    //文件夹非空
                    if (f.Dir_empty == 0)
                    {
                        node.Nodes.Add(new TreeNode("Node2513356652"));
                    }
                    root.Nodes.Add(node);
                }
            }
            root.Expand();
        }

        private void Form_shareSave_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            treeView1.SelectedNode = e.Node;
            TreeNode root = e.Node;
            if (root.Nodes.Count == 1)
            {
                if (root.Nodes[0].Text.Equals("Node2513356652"))
                {
                    root.Nodes.Clear();
                    //MessageBox.Show(root.Name);
                    List<FileBd> list = fileclass.LoadFile(root.Name);
                    foreach (FileBd f in list)
                    {
                        if ("1".Equals(f.Isdir))
                        {
                            TreeNode node = new TreeNode(f.Server_filename);
                            node.Name = f.Path;
                            //文件夹非空
                            if (f.Dir_empty == 0)
                            {
                                node.Nodes.Add(new TreeNode("Node2513356652"));
                            }
                            root.Nodes.Add(node);
                        }
                    }
                }
            }
        }

        private void button_新建文件夹_Click(object sender, EventArgs e)
        {
            TreeNode root = treeView1.SelectedNode;
            Form_shareSave2 form_ShareSave2 = new Form_shareSave2();
            form_ShareSave2.label2_保存位置.Text = "创建位置:"+root.Name+"/";
            DialogResult rs = form_ShareSave2.ShowDialog();
            if (rs==DialogResult.OK)
            {
                string name = form_ShareSave2.textBox1.Text;
                string filepath =HttpRequest.tourl(treeView1.SelectedNode.Name + "/" + name);
                HttpRequest.SendDataByPost(
                    "https://pan.baidu.com/api/create?a=commit&channel=chunlei&web=1&app_id=250528",
                    "path=" + filepath + "&isdir=1&block_list=%5B%5D",
                    ref Common.cookies
                    );

                root.Nodes.Clear();
                root.Nodes.Add(new TreeNode("Node2513356652"));
                root.Expand();

                foreach (TreeNode node in root.Nodes)
                {
                    if (node.Text.Equals(name))
                    {
                        MessageBox.Show(node.Text + "            " + name);
                        treeView1.SelectedNode = treeView1.Nodes[0];
                    }
                }
            }
            form_ShareSave2.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode = treeView1.Nodes[0];
        }

        private void button_保存_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode!=null)
            {
                SavePath = treeView1.SelectedNode.Name;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void button_取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
