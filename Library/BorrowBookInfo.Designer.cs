namespace Library
{
    partial class BorrowBookInfo
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
            this.Borrow_Submit = new System.Windows.Forms.Button();
            this.BorrowBook_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Borrow_Submit
            // 
            this.Borrow_Submit.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Borrow_Submit.Location = new System.Drawing.Point(565, 131);
            this.Borrow_Submit.Name = "Borrow_Submit";
            this.Borrow_Submit.Size = new System.Drawing.Size(92, 35);
            this.Borrow_Submit.TabIndex = 5;
            this.Borrow_Submit.Text = "提交";
            this.Borrow_Submit.UseVisualStyleBackColor = true;
            this.Borrow_Submit.Click += new System.EventHandler(this.Borrow_Submit_Click);
            // 
            // BorrowBook_textbox
            // 
            this.BorrowBook_textbox.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowBook_textbox.Location = new System.Drawing.Point(311, 131);
            this.BorrowBook_textbox.Name = "BorrowBook_textbox";
            this.BorrowBook_textbox.Size = new System.Drawing.Size(237, 35);
            this.BorrowBook_textbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(67, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入要借阅的书名:";
            // 
            // BorrowBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 392);
            this.Controls.Add(this.Borrow_Submit);
            this.Controls.Add(this.BorrowBook_textbox);
            this.Controls.Add(this.label1);
            this.Name = "BorrowBookInfo";
            this.Text = "BorrowBookInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Borrow_Submit;
        private System.Windows.Forms.TextBox BorrowBook_textbox;
        private System.Windows.Forms.Label label1;
    }
}