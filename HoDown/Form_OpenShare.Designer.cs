namespace HoDown
{
    partial class Form_OpenShare
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
            this.button1_确定 = new System.Windows.Forms.Button();
            this.button2_取消 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3_保存到 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_确定
            // 
            this.button1_确定.Location = new System.Drawing.Point(336, 314);
            this.button1_确定.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1_确定.Name = "button1_确定";
            this.button1_确定.Size = new System.Drawing.Size(112, 32);
            this.button1_确定.TabIndex = 2;
            this.button1_确定.Text = "下载";
            this.button1_确定.UseVisualStyleBackColor = true;
            this.button1_确定.Click += new System.EventHandler(this.button1_确定_Click);
            // 
            // button2_取消
            // 
            this.button2_取消.Location = new System.Drawing.Point(479, 314);
            this.button2_取消.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2_取消.Name = "button2_取消";
            this.button2_取消.Size = new System.Drawing.Size(119, 32);
            this.button2_取消.TabIndex = 3;
            this.button2_取消.Text = "取消";
            this.button2_取消.UseVisualStyleBackColor = true;
            this.button2_取消.Click += new System.EventHandler(this.button2_取消_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(635, 304);
            this.checkedListBox1.TabIndex = 6;
            this.checkedListBox1.Click += new System.EventHandler(this.checkedListBox1_Click);
            this.checkedListBox1.DoubleClick += new System.EventHandler(this.checkedListBox1_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "首页";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3_保存到
            // 
            this.button3_保存到.Location = new System.Drawing.Point(164, 314);
            this.button3_保存到.Margin = new System.Windows.Forms.Padding(4);
            this.button3_保存到.Name = "button3_保存到";
            this.button3_保存到.Size = new System.Drawing.Size(143, 32);
            this.button3_保存到.TabIndex = 4;
            this.button3_保存到.Text = "保存到";
            this.button3_保存到.UseVisualStyleBackColor = true;
            this.button3_保存到.Click += new System.EventHandler(this.button3_保存到_Click);
            // 
            // Form_OpenShare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button3_保存到);
            this.Controls.Add(this.button2_取消);
            this.Controls.Add(this.button1_确定);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_OpenShare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "下载/保存 ";
            this.Load += new System.EventHandler(this.Form_OpenShare_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1_确定;
        private System.Windows.Forms.Button button2_取消;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3_保存到;
    }
}