namespace HoDown
{
    partial class Form_shareSave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_shareSave));
            this.button_新建文件夹 = new System.Windows.Forms.Button();
            this.button_保存 = new System.Windows.Forms.Button();
            this.button_取消 = new System.Windows.Forms.Button();
            this.treeView1 = new CCWin.SkinControl.SkinTreeView();
            this.SuspendLayout();
            // 
            // button_新建文件夹
            // 
            this.button_新建文件夹.Location = new System.Drawing.Point(249, 348);
            this.button_新建文件夹.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_新建文件夹.Name = "button_新建文件夹";
            this.button_新建文件夹.Size = new System.Drawing.Size(101, 38);
            this.button_新建文件夹.TabIndex = 1;
            this.button_新建文件夹.Text = "新建文件夹";
            this.button_新建文件夹.UseVisualStyleBackColor = true;
            this.button_新建文件夹.Click += new System.EventHandler(this.button_新建文件夹_Click);
            // 
            // button_保存
            // 
            this.button_保存.Location = new System.Drawing.Point(377, 348);
            this.button_保存.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_保存.Name = "button_保存";
            this.button_保存.Size = new System.Drawing.Size(68, 38);
            this.button_保存.TabIndex = 2;
            this.button_保存.Text = "保存";
            this.button_保存.UseVisualStyleBackColor = true;
            this.button_保存.Click += new System.EventHandler(this.button_保存_Click);
            // 
            // button_取消
            // 
            this.button_取消.Location = new System.Drawing.Point(468, 348);
            this.button_取消.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_取消.Name = "button_取消";
            this.button_取消.Size = new System.Drawing.Size(68, 38);
            this.button_取消.TabIndex = 3;
            this.button_取消.Text = "取消";
            this.button_取消.UseVisualStyleBackColor = true;
            this.button_取消.Click += new System.EventHandler(this.button_取消_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView1.Location = new System.Drawing.Point(4, 32);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(551, 294);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            // 
            // Form_shareSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 395);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button_取消);
            this.Controls.Add(this.button_保存);
            this.Controls.Add(this.button_新建文件夹);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_shareSave";
            this.Text = "选择目录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_shareSave_FormClosing);
            this.Load += new System.EventHandler(this.Form_shareSave_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_新建文件夹;
        private System.Windows.Forms.Button button_保存;
        private System.Windows.Forms.Button button_取消;
        private CCWin.SkinControl.SkinTreeView treeView1;
    }
}