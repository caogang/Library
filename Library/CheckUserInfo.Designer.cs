namespace Library
{
    partial class CheckUserInfo
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
            this.CheckUser_textbox1 = new System.Windows.Forms.TextBox();
            this.Check_Submit = new System.Windows.Forms.Button();
            this.Check_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Edit_Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Check_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(64, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入要查询的用户名:";
            // 
            // CheckUser_textbox1
            // 
            this.CheckUser_textbox1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckUser_textbox1.Location = new System.Drawing.Point(332, 48);
            this.CheckUser_textbox1.Name = "CheckUser_textbox1";
            this.CheckUser_textbox1.Size = new System.Drawing.Size(189, 35);
            this.CheckUser_textbox1.TabIndex = 1;
            // 
            // Check_Submit
            // 
            this.Check_Submit.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Check_Submit.Location = new System.Drawing.Point(537, 46);
            this.Check_Submit.Name = "Check_Submit";
            this.Check_Submit.Size = new System.Drawing.Size(102, 37);
            this.Check_Submit.TabIndex = 2;
            this.Check_Submit.Text = "查询";
            this.Check_Submit.UseVisualStyleBackColor = true;
            this.Check_Submit.Click += new System.EventHandler(this.Check_Submit_Click);
            // 
            // Check_dataGridView1
            // 
            this.Check_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Check_dataGridView1.Location = new System.Drawing.Point(68, 102);
            this.Check_dataGridView1.MultiSelect = false;
            this.Check_dataGridView1.Name = "Check_dataGridView1";
            this.Check_dataGridView1.ReadOnly = true;
            this.Check_dataGridView1.RowTemplate.Height = 23;
            this.Check_dataGridView1.Size = new System.Drawing.Size(571, 209);
            this.Check_dataGridView1.TabIndex = 3;
            // 
            // Edit_Submit
            // 
            this.Edit_Submit.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Edit_Submit.Location = new System.Drawing.Point(68, 329);
            this.Edit_Submit.Name = "Edit_Submit";
            this.Edit_Submit.Size = new System.Drawing.Size(105, 37);
            this.Edit_Submit.TabIndex = 4;
            this.Edit_Submit.Text = "修改";
            this.Edit_Submit.UseVisualStyleBackColor = true;
            this.Edit_Submit.Click += new System.EventHandler(this.Edit_Submit_Click);
            // 
            // CheckUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 392);
            this.Controls.Add(this.Edit_Submit);
            this.Controls.Add(this.Check_dataGridView1);
            this.Controls.Add(this.Check_Submit);
            this.Controls.Add(this.CheckUser_textbox1);
            this.Controls.Add(this.label1);
            this.Name = "CheckUserInfo";
            this.Text = "CheckUserInfo";
            ((System.ComponentModel.ISupportInitialize)(this.Check_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CheckUser_textbox1;
        private System.Windows.Forms.Button Check_Submit;
        private System.Windows.Forms.DataGridView Check_dataGridView1;
        private System.Windows.Forms.Button Edit_Submit;
    }
}