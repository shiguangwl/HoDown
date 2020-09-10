using HoDown.domain;
using HoDown.utool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
           
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            Task task = new Task(new Action(()=> {
                Fileclass fileclass = new Fileclass();
                string mess = HttpRequest.SendDataByGET("http://52.xxhoz.com/hodown.txt", "", ref Common.cookies);
                if (mess==null)
                {
                    MessageBox.Show("服务器连接失败");
                    System.Environment.Exit(0);
                }
                if (!"1.2".Equals(mess))
                {
                    MessageBox.Show("软件版本已停用");
                    System.Diagnostics.Process.Start("https://timeho.lanzous.com/u/%E6%97%B6%E5%85%89TIME");
                    System.Environment.Exit(0);
                }


                Cookie cookie1 = new Cookie();

                string cookiesstr = fileclass.GetCookiesFromFile("http://pan.pan.baidu.com");
                fileclass.Setcookiesformstring(cookiesstr);

                List<FileBd> fs = fileclass.LoadFile();
                if (fs != null && fs.Count > 0)
                {
                    Common.isSign = true;
                }

                this.Invoke(new Action(() => {
                    Form_Main main = new Form_Main();
                    main.Owner = this;
                    this.Hide();
                    main.ShowDialog();
                    Application.ExitThread();
                    this.DialogResult = DialogResult.OK;
                }));
            }));

            task.Start();
            
            //Form_Main main = new Form_Main();
            //main.Owner = this;
            //this.Hide();
            //main.ShowDialog();
            //Application.ExitThread();
            //Application.ExitThread();

        }
    }
}
