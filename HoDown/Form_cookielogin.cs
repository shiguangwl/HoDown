
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoDown
{
    public partial class Form_cookielogin : Form
    {
        public Form_cookielogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void Form_cookielogin_Load(object sender, EventArgs e)
        {

        }
    }
}
