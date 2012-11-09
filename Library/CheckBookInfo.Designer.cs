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
            this.Edit_Submit = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Check_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Check_dataGridView1
            // 
            this.Check_dataGridView1.AllowUserToAddRows = false;
            this.Check_dataGridView1.AllowUserToDeleteRows = false;
            this.Check_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Check_dataGridView1.Location = new System.Drawing.Point(120, 127);
            this.Check_dataGridView1.MultiSelect = false;
            this.Check_dataGridView1.Name = "Check_dataGridView1";
            this.Check_dataGridView1.ReadOnly = true;
            this.Check_dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Check_dataGridView1.RowTemplate.Height = 50;
            this.Check_dataGridView1.RowTemplate.ReadOnly = true;
            this.Check_dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Check_dataGridView1.Size = new System.Drawing.Size(552, 185);
            this.Check_dataGridView1.TabIndex = 7;
            this.Check_dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Check_dataGridView1_CellContentClick);
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
            this.label1.Location = new System.Drawing.Point(31, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "请输入要查询的";
            // 
            // Edit_Submit
            // 
            this.Edit_Submit.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Edit_Submit.Location = new System.Drawing.Point(120, 331);
            this.Edit_Submit.Name = "Edit_Submit";
            this.Edit_Submit.Size = new System.Drawing.Size(89, 36);
            this.Edit_Submit.TabIndex = 8;
            this.Edit_Submit.Text = "修改";
            this.Edit_Submit.UseVisualStyleBackColor = true;
            this.Edit_Submit.Click += new System.EventHandler(this.Edit_Submit_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Column1";
            this.dataGridViewImageColumn1.Image = global::Library.Properties.Resources.delete1;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Delete.Location = new System.Drawing.Point(583, 331);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(89, 36);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "删除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "标题",
            "剩余数量",
            "出版社",
            "作者",
            "出版时间"});
            this.comboBox1.Location = new System.Drawing.Point(210, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "标题";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(337, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = ":";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Location = new System.Drawing.Point(364, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Visible = false;
            // 
            // CheckBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 392);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit_Submit);
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
        private System.Windows.Forms.Button Edit_Submit;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}