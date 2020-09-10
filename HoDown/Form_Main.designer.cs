namespace HoDown
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panel1_web = new System.Windows.Forms.Panel();
            this.tabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.tabPage1_Filelist = new System.Windows.Forms.TabPage();
            this.web_view = new MiniBlinkPinvoke.BlinkBrowser();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.下载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更多ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.待开发ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2_Downlist = new System.Windows.Forms.TabPage();
            this.blinkBrowser1 = new MiniBlinkPinvoke.BlinkBrowser();
            this.tabPage3_打开链接 = new CCWin.SkinControl.SkinTabPage();
            this.panel1_两个按钮 = new System.Windows.Forms.Panel();
            this.button3_登录完成未跳转 = new System.Windows.Forms.Button();
            this.button2_COOkie登录 = new System.Windows.Forms.Button();
            this.tableLayoutPanel_打开链接 = new System.Windows.Forms.TableLayoutPanel();
            this.skinTextBox1_链接 = new CCWin.SkinControl.SkinTextBox();
            this.button_打开链接 = new System.Windows.Forms.Button();
            this.skinButton1_去登录 = new CCWin.SkinControl.SkinButton();
            this.tabPage3_关于 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2_tab = new System.Windows.Forms.Panel();
            this.button1_回家 = new System.Windows.Forms.Button();
            this.button_退出 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2_viwepath = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1_web.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1_Filelist.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2_Downlist.SuspendLayout();
            this.tabPage3_打开链接.SuspendLayout();
            this.panel1_两个按钮.SuspendLayout();
            this.tableLayoutPanel_打开链接.SuspendLayout();
            this.tabPage3_关于.SuspendLayout();
            this.panel2_tab.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1_web
            // 
            this.panel1_web.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1_web.Controls.Add(this.tabControl1);
            this.panel1_web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_web.Location = new System.Drawing.Point(9, 102);
            this.panel1_web.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1_web.Name = "panel1_web";
            this.panel1_web.Size = new System.Drawing.Size(1242, 717);
            this.panel1_web.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tabControl1.Controls.Add(this.tabPage1_Filelist);
            this.tabControl1.Controls.Add(this.tabPage2_Downlist);
            this.tabControl1.Controls.Add(this.tabPage3_打开链接);
            this.tabControl1.Controls.Add(this.tabPage3_关于);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.tabControl1.HeadBack = null;
            this.tabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tabControl1.ItemSize = new System.Drawing.Size(70, 36);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageArrowDown")));
            this.tabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageArrowHover")));
            this.tabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageCloseHover")));
            this.tabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageCloseNormal")));
            this.tabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageDown")));
            this.tabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageHover")));
            this.tabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tabControl1.PageNorml = null;
            this.tabControl1.SelectedIndex = 2;
            this.tabControl1.Size = new System.Drawing.Size(1242, 717);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1_Filelist
            // 
            this.tabPage1_Filelist.Controls.Add(this.web_view);
            this.tabPage1_Filelist.Controls.Add(this.listView1);
            this.tabPage1_Filelist.Font = new System.Drawing.Font("宋体", 9F);
            this.tabPage1_Filelist.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage1_Filelist.Location = new System.Drawing.Point(0, 36);
            this.tabPage1_Filelist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1_Filelist.Name = "tabPage1_Filelist";
            this.tabPage1_Filelist.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1_Filelist.Size = new System.Drawing.Size(1242, 681);
            this.tabPage1_Filelist.TabIndex = 0;
            this.tabPage1_Filelist.Text = "资源列表";
            this.tabPage1_Filelist.UseVisualStyleBackColor = true;
            // 
            // web_view
            // 
            this.web_view._ZoomFactor = 0F;
            this.web_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_view.HTML = "";
            this.web_view.Location = new System.Drawing.Point(3, 2);
            this.web_view.Margin = new System.Windows.Forms.Padding(4);
            this.web_view.Name = "web_view";
            this.web_view.Size = new System.Drawing.Size(1236, 677);
            this.web_view.TabIndex = 1;
            this.web_view.Text = "web_view";
            this.web_view.Url = "http://pan.baidu.com";
            this.web_view.ZoomFactor = 0F;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("宋体", 9F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 2);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1236, 677);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.下载ToolStripMenuItem,
            this.更多ToolStripMenuItem,
            this.待开发ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 76);
            // 
            // 下载ToolStripMenuItem
            // 
            this.下载ToolStripMenuItem.Name = "下载ToolStripMenuItem";
            this.下载ToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.下载ToolStripMenuItem.Text = "下载";
            this.下载ToolStripMenuItem.Click += new System.EventHandler(this.下载ToolStripMenuItem_Click);
            // 
            // 更多ToolStripMenuItem
            // 
            this.更多ToolStripMenuItem.Name = "更多ToolStripMenuItem";
            this.更多ToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.更多ToolStripMenuItem.Text = "更多..";
            // 
            // 待开发ToolStripMenuItem
            // 
            this.待开发ToolStripMenuItem.Name = "待开发ToolStripMenuItem";
            this.待开发ToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.待开发ToolStripMenuItem.Text = "待开发...";
            // 
            // tabPage2_Downlist
            // 
            this.tabPage2_Downlist.Controls.Add(this.blinkBrowser1);
            this.tabPage2_Downlist.Font = new System.Drawing.Font("宋体", 9F);
            this.tabPage2_Downlist.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage2_Downlist.Location = new System.Drawing.Point(0, 36);
            this.tabPage2_Downlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2_Downlist.Name = "tabPage2_Downlist";
            this.tabPage2_Downlist.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2_Downlist.Size = new System.Drawing.Size(1242, 681);
            this.tabPage2_Downlist.TabIndex = 1;
            this.tabPage2_Downlist.Text = "查看下载";
            this.tabPage2_Downlist.UseVisualStyleBackColor = true;
            // 
            // blinkBrowser1
            // 
            this.blinkBrowser1._ZoomFactor = 0F;
            this.blinkBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blinkBrowser1.HTML = "";
            this.blinkBrowser1.Location = new System.Drawing.Point(3, 2);
            this.blinkBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.blinkBrowser1.Name = "blinkBrowser1";
            this.blinkBrowser1.Size = new System.Drawing.Size(1236, 677);
            this.blinkBrowser1.TabIndex = 0;
            this.blinkBrowser1.Text = "blinkBrowser1";
            this.blinkBrowser1.Url = "";
            this.blinkBrowser1.ZoomFactor = 0F;
            // 
            // tabPage3_打开链接
            // 
            this.tabPage3_打开链接.BackColor = System.Drawing.Color.White;
            this.tabPage3_打开链接.Controls.Add(this.label6);
            this.tabPage3_打开链接.Controls.Add(this.panel1_两个按钮);
            this.tabPage3_打开链接.Controls.Add(this.tableLayoutPanel_打开链接);
            this.tabPage3_打开链接.Controls.Add(this.skinButton1_去登录);
            this.tabPage3_打开链接.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage3_打开链接.Font = new System.Drawing.Font("宋体", 9F);
            this.tabPage3_打开链接.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage3_打开链接.Location = new System.Drawing.Point(0, 36);
            this.tabPage3_打开链接.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3_打开链接.Name = "tabPage3_打开链接";
            this.tabPage3_打开链接.Size = new System.Drawing.Size(1242, 681);
            this.tabPage3_打开链接.TabIndex = 3;
            this.tabPage3_打开链接.TabItemImage = null;
            this.tabPage3_打开链接.Text = "打开链接";
            // 
            // panel1_两个按钮
            // 
            this.panel1_两个按钮.Controls.Add(this.button3_登录完成未跳转);
            this.panel1_两个按钮.Controls.Add(this.button2_COOkie登录);
            this.panel1_两个按钮.Location = new System.Drawing.Point(17, 561);
            this.panel1_两个按钮.Margin = new System.Windows.Forms.Padding(4);
            this.panel1_两个按钮.Name = "panel1_两个按钮";
            this.panel1_两个按钮.Size = new System.Drawing.Size(391, 52);
            this.panel1_两个按钮.TabIndex = 3;
            // 
            // button3_登录完成未跳转
            // 
            this.button3_登录完成未跳转.Location = new System.Drawing.Point(165, 4);
            this.button3_登录完成未跳转.Margin = new System.Windows.Forms.Padding(4);
            this.button3_登录完成未跳转.Name = "button3_登录完成未跳转";
            this.button3_登录完成未跳转.Size = new System.Drawing.Size(220, 45);
            this.button3_登录完成未跳转.TabIndex = 1;
            this.button3_登录完成未跳转.Text = "登录成功未跳转点我";
            this.button3_登录完成未跳转.UseVisualStyleBackColor = true;
            this.button3_登录完成未跳转.Click += new System.EventHandler(this.button3_登录完成未跳转_Click);
            // 
            // button2_COOkie登录
            // 
            this.button2_COOkie登录.Location = new System.Drawing.Point(4, 4);
            this.button2_COOkie登录.Margin = new System.Windows.Forms.Padding(4);
            this.button2_COOkie登录.Name = "button2_COOkie登录";
            this.button2_COOkie登录.Size = new System.Drawing.Size(153, 45);
            this.button2_COOkie登录.TabIndex = 0;
            this.button2_COOkie登录.Text = "cookie登录";
            this.button2_COOkie登录.UseVisualStyleBackColor = true;
            this.button2_COOkie登录.Click += new System.EventHandler(this.button2_COOkie登录_Click);
            // 
            // tableLayoutPanel_打开链接
            // 
            this.tableLayoutPanel_打开链接.ColumnCount = 2;
            this.tableLayoutPanel_打开链接.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.87392F));
            this.tableLayoutPanel_打开链接.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.12608F));
            this.tableLayoutPanel_打开链接.Controls.Add(this.skinTextBox1_链接, 0, 0);
            this.tableLayoutPanel_打开链接.Controls.Add(this.button_打开链接, 1, 0);
            this.tableLayoutPanel_打开链接.Location = new System.Drawing.Point(200, 245);
            this.tableLayoutPanel_打开链接.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel_打开链接.Name = "tableLayoutPanel_打开链接";
            this.tableLayoutPanel_打开链接.RowCount = 1;
            this.tableLayoutPanel_打开链接.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_打开链接.Size = new System.Drawing.Size(796, 68);
            this.tableLayoutPanel_打开链接.TabIndex = 1;
            // 
            // skinTextBox1_链接
            // 
            this.skinTextBox1_链接.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1_链接.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1_链接.DownBack = null;
            this.skinTextBox1_链接.Icon = null;
            this.skinTextBox1_链接.IconIsButton = false;
            this.skinTextBox1_链接.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1_链接.IsPasswordChat = '\0';
            this.skinTextBox1_链接.IsSystemPasswordChar = false;
            this.skinTextBox1_链接.Lines = new string[0];
            this.skinTextBox1_链接.Location = new System.Drawing.Point(0, 0);
            this.skinTextBox1_链接.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1_链接.MaxLength = 32767;
            this.skinTextBox1_链接.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1_链接.MouseBack = null;
            this.skinTextBox1_链接.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1_链接.Multiline = true;
            this.skinTextBox1_链接.Name = "skinTextBox1_链接";
            this.skinTextBox1_链接.NormlBack = null;
            this.skinTextBox1_链接.Padding = new System.Windows.Forms.Padding(5, 22, 5, 5);
            this.skinTextBox1_链接.ReadOnly = false;
            this.skinTextBox1_链接.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1_链接.Size = new System.Drawing.Size(619, 68);
            // 
            // 
            // 
            this.skinTextBox1_链接.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1_链接.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1_链接.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTextBox1_链接.SkinTxt.Location = new System.Drawing.Point(5, 22);
            this.skinTextBox1_链接.SkinTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.skinTextBox1_链接.SkinTxt.Multiline = true;
            this.skinTextBox1_链接.SkinTxt.Name = "BaseText";
            this.skinTextBox1_链接.SkinTxt.Size = new System.Drawing.Size(609, 41);
            this.skinTextBox1_链接.SkinTxt.TabIndex = 0;
            this.skinTextBox1_链接.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1_链接.SkinTxt.WaterText = "";
            this.skinTextBox1_链接.TabIndex = 0;
            this.skinTextBox1_链接.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1_链接.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1_链接.WaterText = "";
            this.skinTextBox1_链接.WordWrap = true;
            // 
            // button_打开链接
            // 
            this.button_打开链接.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_打开链接.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_打开链接.Location = new System.Drawing.Point(622, 2);
            this.button_打开链接.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_打开链接.Name = "button_打开链接";
            this.button_打开链接.Size = new System.Drawing.Size(171, 64);
            this.button_打开链接.TabIndex = 1;
            this.button_打开链接.Text = "打开";
            this.button_打开链接.UseVisualStyleBackColor = true;
            this.button_打开链接.Click += new System.EventHandler(this.button_打开链接_Click);
            // 
            // skinButton1_去登录
            // 
            this.skinButton1_去登录.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1_去登录.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1_去登录.DownBack = null;
            this.skinButton1_去登录.Font = new System.Drawing.Font("JetBrains Mono", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinButton1_去登录.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skinButton1_去登录.Location = new System.Drawing.Point(452, 68);
            this.skinButton1_去登录.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.skinButton1_去登录.MouseBack = null;
            this.skinButton1_去登录.Name = "skinButton1_去登录";
            this.skinButton1_去登录.NormlBack = null;
            this.skinButton1_去登录.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.skinButton1_去登录.Size = new System.Drawing.Size(281, 82);
            this.skinButton1_去登录.TabIndex = 0;
            this.skinButton1_去登录.Text = "登录百度网盘账号";
            this.skinButton1_去登录.UseVisualStyleBackColor = false;
            this.skinButton1_去登录.Click += new System.EventHandler(this.skinButton1_去登录_Click);
            // 
            // tabPage3_关于
            // 
            this.tabPage3_关于.Controls.Add(this.label5);
            this.tabPage3_关于.Controls.Add(this.label4);
            this.tabPage3_关于.Controls.Add(this.label3);
            this.tabPage3_关于.Font = new System.Drawing.Font("宋体", 9F);
            this.tabPage3_关于.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage3_关于.Location = new System.Drawing.Point(0, 36);
            this.tabPage3_关于.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3_关于.Name = "tabPage3_关于";
            this.tabPage3_关于.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3_关于.Size = new System.Drawing.Size(1242, 681);
            this.tabPage3_关于.TabIndex = 2;
            this.tabPage3_关于.Text = "关于";
            this.tabPage3_关于.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(159, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(800, 45);
            this.label5.TabIndex = 2;
            this.label5.Text = "本软件仅供学习交流使用，不得用于商业用途";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "版本:1.2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 57);
            this.label3.TabIndex = 0;
            this.label3.Text = "HoDown by TimeHo";
            // 
            // panel2_tab
            // 
            this.panel2_tab.Controls.Add(this.button1_回家);
            this.panel2_tab.Controls.Add(this.button_退出);
            this.panel2_tab.Controls.Add(this.label2);
            this.panel2_tab.Controls.Add(this.label1);
            this.panel2_tab.Controls.Add(this.textBox2_viwepath);
            this.panel2_tab.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2_tab.Location = new System.Drawing.Point(9, 44);
            this.panel2_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2_tab.Name = "panel2_tab";
            this.panel2_tab.Size = new System.Drawing.Size(1242, 58);
            this.panel2_tab.TabIndex = 6;
            // 
            // button1_回家
            // 
            this.button1_回家.Location = new System.Drawing.Point(73, 12);
            this.button1_回家.Margin = new System.Windows.Forms.Padding(4);
            this.button1_回家.Name = "button1_回家";
            this.button1_回家.Size = new System.Drawing.Size(57, 31);
            this.button1_回家.TabIndex = 9;
            this.button1_回家.Text = "回家";
            this.button1_回家.Click += new System.EventHandler(this.button1_回家_Click);
            // 
            // button_退出
            // 
            this.button_退出.Enabled = false;
            this.button_退出.Location = new System.Drawing.Point(4, 12);
            this.button_退出.Margin = new System.Windows.Forms.Padding(4);
            this.button_退出.Name = "button_退出";
            this.button_退出.Size = new System.Drawing.Size(61, 31);
            this.button_退出.TabIndex = 8;
            this.button_退出.Text = "退出";
            this.button_退出.Click += new System.EventHandler(this.button_退出_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(1016, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "仅供学习使用.";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "当前位置:";
            // 
            // textBox2_viwepath
            // 
            this.textBox2_viwepath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2_viwepath.Enabled = false;
            this.textBox2_viwepath.Location = new System.Drawing.Point(221, 15);
            this.textBox2_viwepath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2_viwepath.Name = "textBox2_viwepath";
            this.textBox2_viwepath.Size = new System.Drawing.Size(788, 25);
            this.textBox2_viwepath.TabIndex = 4;
            this.textBox2_viwepath.Text = "/";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "文件.png");
            this.imageList1.Images.SetKeyName(1, "文件夹.png");
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "HoDown 1.2";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(109, 76);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(108, 24);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "默认链接分析格式";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 828);
            this.Controls.Add(this.panel1_web);
            this.Controls.Add(this.panel2_tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "HoDown  一个学习软件";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1_web.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1_Filelist.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2_Downlist.ResumeLayout(false);
            this.tabPage3_打开链接.ResumeLayout(false);
            this.tabPage3_打开链接.PerformLayout();
            this.panel1_两个按钮.ResumeLayout(false);
            this.tableLayoutPanel_打开链接.ResumeLayout(false);
            this.tabPage3_关于.ResumeLayout(false);
            this.tabPage3_关于.PerformLayout();
            this.panel2_tab.ResumeLayout(false);
            this.panel2_tab.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_web;
        private System.Windows.Forms.TabPage tabPage1_Filelist;
        private System.Windows.Forms.TabPage tabPage2_Downlist;
        private System.Windows.Forms.Panel panel2_tab;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox2_viwepath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 下载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更多ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 待开发ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private MiniBlinkPinvoke.BlinkBrowser web_view;
        private System.Windows.Forms.Timer timer2;
        private MiniBlinkPinvoke.BlinkBrowser blinkBrowser1;
        private System.Windows.Forms.Panel panel1_两个按钮;
        private System.Windows.Forms.Button button3_登录完成未跳转;
        private System.Windows.Forms.Button button2_COOkie登录;
        private System.Windows.Forms.TabPage tabPage3_关于;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_退出;
        private System.Windows.Forms.Button button1_回家;
        private CCWin.SkinControl.SkinTabControl tabControl1;
        private System.Windows.Forms.ListView listView1;
        private CCWin.SkinControl.SkinTabPage tabPage3_打开链接;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_打开链接;
        private CCWin.SkinControl.SkinTextBox skinTextBox1_链接;
        private CCWin.SkinControl.SkinButton skinButton1_去登录;
        private System.Windows.Forms.Button button_打开链接;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.Label label6;
    }
}