namespace Library
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询图书ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.添加图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询已借图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.归还图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询用户ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查询图书ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Info = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.图书管理ToolStripMenuItem,
            this.查询图书ToolStripMenuItem,
            this.用户信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询用户ToolStripMenuItem,
            this.添加用户ToolStripMenuItem,
            this.删除用户ToolStripMenuItem});
            this.用户管理ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(118, 28);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 查询用户ToolStripMenuItem
            // 
            this.查询用户ToolStripMenuItem.Name = "查询用户ToolStripMenuItem";
            this.查询用户ToolStripMenuItem.Size = new System.Drawing.Size(176, 28);
            this.查询用户ToolStripMenuItem.Text = "查询用户";
            this.查询用户ToolStripMenuItem.Click += new System.EventHandler(this.CheckUserInfo_ToolStripMenuItem1_Click);
            // 
            // 添加用户ToolStripMenuItem
            // 
            this.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem";
            this.添加用户ToolStripMenuItem.Size = new System.Drawing.Size(176, 28);
            this.添加用户ToolStripMenuItem.Text = "添加用户";
            this.添加用户ToolStripMenuItem.Click += new System.EventHandler(this.AddUserInfo_ToolStripMenuItem_Click);
            // 
            // 删除用户ToolStripMenuItem
            // 
            this.删除用户ToolStripMenuItem.Name = "删除用户ToolStripMenuItem";
            this.删除用户ToolStripMenuItem.Size = new System.Drawing.Size(176, 28);
            this.删除用户ToolStripMenuItem.Text = "删除用户";
            this.删除用户ToolStripMenuItem.Click += new System.EventHandler(this.DeleteUser_ToolStripMenuItem);
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询图书ToolStripMenuItem2,
            this.添加图书ToolStripMenuItem,
            this.删除图书ToolStripMenuItem,
            this.借阅图书ToolStripMenuItem,
            this.查询已借图书ToolStripMenuItem,
            this.归还图书ToolStripMenuItem});
            this.图书管理ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(118, 28);
            this.图书管理ToolStripMenuItem.Text = "图书管理";
            // 
            // 查询图书ToolStripMenuItem2
            // 
            this.查询图书ToolStripMenuItem2.Name = "查询图书ToolStripMenuItem2";
            this.查询图书ToolStripMenuItem2.Size = new System.Drawing.Size(224, 28);
            this.查询图书ToolStripMenuItem2.Text = "查询图书";
            this.查询图书ToolStripMenuItem2.Click += new System.EventHandler(this.CheckBookInfo_ToolStripMenuItem1_Click);
            // 
            // 添加图书ToolStripMenuItem
            // 
            this.添加图书ToolStripMenuItem.Name = "添加图书ToolStripMenuItem";
            this.添加图书ToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.添加图书ToolStripMenuItem.Text = "添加图书";
            this.添加图书ToolStripMenuItem.Click += new System.EventHandler(this.AddBookInfo_ToolStripMenuItem);
            // 
            // 删除图书ToolStripMenuItem
            // 
            this.删除图书ToolStripMenuItem.Name = "删除图书ToolStripMenuItem";
            this.删除图书ToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.删除图书ToolStripMenuItem.Text = "删除图书";
            this.删除图书ToolStripMenuItem.Click += new System.EventHandler(this.DeleteBookInfo_ToolStripMenuItem);
            // 
            // 借阅图书ToolStripMenuItem
            // 
            this.借阅图书ToolStripMenuItem.Name = "借阅图书ToolStripMenuItem";
            this.借阅图书ToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.借阅图书ToolStripMenuItem.Text = "借阅图书";
            this.借阅图书ToolStripMenuItem.Click += new System.EventHandler(this.BorrowBookInfo_ToolStripMenuItem);
            // 
            // 查询已借图书ToolStripMenuItem
            // 
            this.查询已借图书ToolStripMenuItem.Name = "查询已借图书ToolStripMenuItem";
            this.查询已借图书ToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.查询已借图书ToolStripMenuItem.Text = "查询已借图书";
            this.查询已借图书ToolStripMenuItem.Click += new System.EventHandler(this.CheckBookHadBorrow);
            // 
            // 归还图书ToolStripMenuItem
            // 
            this.归还图书ToolStripMenuItem.Name = "归还图书ToolStripMenuItem";
            this.归还图书ToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.归还图书ToolStripMenuItem.Text = "归还图书";
            this.归还图书ToolStripMenuItem.Click += new System.EventHandler(this.ReturnBook_ToolStripMenuItem);
            // 
            // 查询图书ToolStripMenuItem
            // 
            this.查询图书ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询用户ToolStripMenuItem1,
            this.查询图书ToolStripMenuItem1});
            this.查询图书ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.查询图书ToolStripMenuItem.Name = "查询图书ToolStripMenuItem";
            this.查询图书ToolStripMenuItem.Size = new System.Drawing.Size(70, 28);
            this.查询图书ToolStripMenuItem.Text = "查询";
            // 
            // 查询用户ToolStripMenuItem1
            // 
            this.查询用户ToolStripMenuItem1.Name = "查询用户ToolStripMenuItem1";
            this.查询用户ToolStripMenuItem1.Size = new System.Drawing.Size(176, 28);
            this.查询用户ToolStripMenuItem1.Text = "查询用户";
            this.查询用户ToolStripMenuItem1.Click += new System.EventHandler(this.CheckUserInfo_ToolStripMenuItem1_Click);
            // 
            // 查询图书ToolStripMenuItem1
            // 
            this.查询图书ToolStripMenuItem1.Name = "查询图书ToolStripMenuItem1";
            this.查询图书ToolStripMenuItem1.Size = new System.Drawing.Size(176, 28);
            this.查询图书ToolStripMenuItem1.Text = "查询图书";
            this.查询图书ToolStripMenuItem1.Click += new System.EventHandler(this.CheckBookInfo_ToolStripMenuItem1_Click);
            // 
            // 用户信息ToolStripMenuItem
            // 
            this.用户信息ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.用户信息ToolStripMenuItem.Name = "用户信息ToolStripMenuItem";
            this.用户信息ToolStripMenuItem.Size = new System.Drawing.Size(118, 28);
            this.用户信息ToolStripMenuItem.Text = "用户信息";
            this.用户信息ToolStripMenuItem.Click += new System.EventHandler(this.UserInfo_ToolStripMenuItem_Click);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.SystemColors.Control;
            this.Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Info.Location = new System.Drawing.Point(0, 32);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(784, 430);
            this.Info.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(551, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "游客";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(486, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.linkLabel1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(668, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 20);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "注销";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主窗体";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询图书ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 添加图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询用户ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查询图书ToolStripMenuItem1;
        private System.Windows.Forms.Panel Info;
        private System.Windows.Forms.ToolStripMenuItem 用户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅图书ToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 查询已借图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 归还图书ToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;

    }
}