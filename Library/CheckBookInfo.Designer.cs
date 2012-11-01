namespace Library
{
    partial class CheckBookInfo
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
            this.Check_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckBook_Submit = new System.Windows.Forms.Button();
            this.CheckBook_textbox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Check_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Check_dataGridView1
            // 
            this.Check_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Check_dataGridView1.Location = new System.Drawing.Point(120, 145);
            this.Check_dataGridView1.Name = "Check_dataGridView1";
            this.Check_dataGridView1.RowTemplate.Height = 23;
            this.Check_dataGridView1.Size = new System.Drawing.Size(552, 185);
            this.Check_dataGridView1.TabIndex = 7;
            // 
            // CheckBook_Submit
            // 
            this.CheckBook_Submit.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBook_Submit.Location = new System.Drawing.Point(570, 62);
            this.CheckBook_Submit.Name = "CheckBook_Submit";
            this.CheckBook_Submit.Size = new System.Drawing.Size(102, 37);
            this.CheckBook_Submit.TabIndex = 6;
            this.CheckBook_Submit.Text = "查询";
            this.CheckBook_Submit.UseVisualStyleBackColor = true;
            this.CheckBook_Submit.Click += new System.EventHandler(this.CheckBook_Submit_Click);
            // 
            // CheckBook_textbox1
            // 
            this.CheckBook_textbox1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBook_textbox1.Location = new System.Drawing.Point(365, 64);
            this.CheckBook_textbox1.Name = "CheckBook_textbox1";
            this.CheckBook_textbox1.Size = new System.Drawing.Size(189, 35);
            this.CheckBook_textbox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(97, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "请输入要查询的图书名:";
            // 
            // CheckBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 392);
            this.Controls.Add(this.Check_dataGridView1);
            this.Controls.Add(this.CheckBook_Submit);
            this.Controls.Add(this.CheckBook_textbox1);
            this.Controls.Add(this.label1);
            this.Name = "CheckBookInfo";
            this.Text = "CheckBookInfo";
            ((System.ComponentModel.ISupportInitialize)(this.Check_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Check_dataGridView1;
        private System.Windows.Forms.Button CheckBook_Submit;
        private System.Windows.Forms.TextBox CheckBook_textbox1;
        private System.Windows.Forms.Label label1;
    }
}