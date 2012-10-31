namespace Library
{
    partial class DeleteUserInfo
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
            this.Delete_UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Delete_UserName
            // 
            this.Delete_UserName.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Delete_UserName.Location = new System.Drawing.Point(338, 165);
            this.Delete_UserName.Name = "Delete_UserName";
            this.Delete_UserName.Size = new System.Drawing.Size(256, 35);
            this.Delete_UserName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(70, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "请输入要删除的用户名:";
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Submit.Location = new System.Drawing.Point(600, 163);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(90, 37);
            this.Submit.TabIndex = 13;
            this.Submit.Text = "提交";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // DeleteUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 392);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Delete_UserName);
            this.Controls.Add(this.label1);
            this.Name = "DeleteUserInfo";
            this.Text = "DeleteUserInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Delete_UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit;
    }
}