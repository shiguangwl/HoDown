namespace HoDown
{
    partial class Form_Message
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
            this.label1_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_message
            // 
            this.label1_message.AutoSize = true;
            this.label1_message.Font = new System.Drawing.Font("JetBrains Mono", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_message.Location = new System.Drawing.Point(12, 57);
            this.label1_message.Name = "label1_message";
            this.label1_message.Size = new System.Drawing.Size(104, 31);
            this.label1_message.TabIndex = 0;
            this.label1_message.Text = "label1";
            // 
            // Form_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 142);
            this.Controls.Add(this.label1_message);
            this.Name = "Form_Message";
            this.Text = "Form_Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1_message;
    }
}