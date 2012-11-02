namespace Library
{
    partial class EditBook
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Reset = new System.Windows.Forms.Button();
            this.Book_content = new System.Windows.Forms.TextBox();
            this.Book_publishing_home = new System.Windows.Forms.TextBox();
            this.Book_publisher = new System.Windows.Forms.TextBox();
            this.Book_num = new System.Windows.Forms.TextBox();
            this.Book_Title = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Reset.Location = new System.Drawing.Point(563, 362);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(126, 41);
            this.Reset.TabIndex = 27;
            this.Reset.Text = "退出编辑";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Book_content
            // 
            this.Book_content.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Book_content.Location = new System.Drawing.Point(140, 285);
            this.Book_content.Multiline = true;
            this.Book_content.Name = "Book_content";
            this.Book_content.Size = new System.Drawing.Size(233, 119);
            this.Book_content.TabIndex = 25;
            // 
            // Book_publishing_home
            // 
            this.Book_publishing_home.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Book_publishing_home.Location = new System.Drawing.Point(140, 239);
            this.Book_publishing_home.Name = "Book_publishing_home";
            this.Book_publishing_home.Size = new System.Drawing.Size(194, 35);
            this.Book_publishing_home.TabIndex = 24;
            // 
            // Book_publisher
            // 
            this.Book_publisher.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Book_publisher.Location = new System.Drawing.Point(140, 192);
            this.Book_publisher.Name = "Book_publisher";
            this.Book_publisher.Size = new System.Drawing.Size(194, 35);
            this.Book_publisher.TabIndex = 23;
            // 
            // Book_num
            // 
            this.Book_num.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Book_num.Location = new System.Drawing.Point(140, 95);
            this.Book_num.Name = "Book_num";
            this.Book_num.Size = new System.Drawing.Size(194, 35);
            this.Book_num.TabIndex = 22;
            // 
            // Book_Title
            // 
            this.Book_Title.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Book_Title.Location = new System.Drawing.Point(140, 47);
            this.Book_Title.Name = "Book_Title";
            this.Book_Title.Size = new System.Drawing.Size(194, 35);
            this.Book_Title.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(16, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "出版公司:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "出 版 者:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "出版日期:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "总库存量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "内    容:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "图书名称:";
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.update.Location = new System.Drawing.Point(417, 362);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(126, 41);
            this.update.TabIndex = 29;
            this.update.Text = "更新";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 462);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Book_content);
            this.Controls.Add(this.Book_publishing_home);
            this.Controls.Add(this.Book_publisher);
            this.Controls.Add(this.Book_num);
            this.Controls.Add(this.Book_Title);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditBook";
            this.Text = "EditBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox Book_content;
        private System.Windows.Forms.TextBox Book_publishing_home;
        private System.Windows.Forms.TextBox Book_publisher;
        private System.Windows.Forms.TextBox Book_num;
        private System.Windows.Forms.TextBox Book_Title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update;
    }
}