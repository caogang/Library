namespace Library
{
    partial class ReturnBookInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.ReturnBook_textbox = new System.Windows.Forms.TextBox();
            this.Return_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入要归还的书名:";
            // 
            // ReturnBook_textbox
            // 
            this.ReturnBook_textbox.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnBook_textbox.Location = new System.Drawing.Point(256, 115);
            this.ReturnBook_textbox.Name = "ReturnBook_textbox";
            this.ReturnBook_textbox.Size = new System.Drawing.Size(237, 35);
            this.ReturnBook_textbox.TabIndex = 1;
            // 
            // Return_Submit
            // 
            this.Return_Submit.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Return_Submit.Location = new System.Drawing.Point(510, 115);
            this.Return_Submit.Name = "Return_Submit";
            this.Return_Submit.Size = new System.Drawing.Size(92, 35);
            this.Return_Submit.TabIndex = 2;
            this.Return_Submit.Text = "提交";
            this.Return_Submit.UseVisualStyleBackColor = true;
            this.Return_Submit.Click += new System.EventHandler(this.Return_Submit_Click);
            // 
            // ReturnBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 392);
            this.Controls.Add(this.Return_Submit);
            this.Controls.Add(this.ReturnBook_textbox);
            this.Controls.Add(this.label1);
            this.Name = "ReturnBookInfo";
            this.Text = "ReturnBookInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReturnBook_textbox;
        private System.Windows.Forms.Button Return_Submit;
    }
}