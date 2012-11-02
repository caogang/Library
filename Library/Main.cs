using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class Main : Form
    {
        string userName;
        User user = new User();
        public Main(User u)
        {
            user = u;
            InitializeComponent();
            label5.Text = user.UserName;
            userName = user.UserName;
            UserInfo userinfo = new UserInfo(user);
            userinfo.TopLevel = false;
            userinfo.FormBorderStyle = FormBorderStyle.None;
            Info.Controls.Add(userinfo);
            userinfo.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CheckUserInfo_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CheckUserInfo checkUserInfo = new CheckUserInfo(userName);
            checkUserInfo.TopLevel = false;
            checkUserInfo.FormBorderStyle = FormBorderStyle.None;
            Info.Controls.Clear();
            Info.Controls.Add(checkUserInfo);
            checkUserInfo.Show();
        }

        private void UserInfo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo userinfo = new UserInfo(user);
            userinfo.TopLevel = false;
            userinfo.FormBorderStyle = FormBorderStyle.None;
            Info.Controls.Clear();
            Info.Controls.Add(userinfo);
            userinfo.Show();
        }

        private void AddUserInfo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserInfo add_userinfo = new AddUserInfo();
            add_userinfo.TopLevel = false;
            add_userinfo.FormBorderStyle = FormBorderStyle.None;
            Info.Controls.Clear();
            Info.Controls.Add(add_userinfo);
            add_userinfo.Show();
        }

        private void DeleteUser_ToolStripMenuItem(object sender, EventArgs e)
        {
            DeleteUserInfo delete_userinfo = new DeleteUserInfo();
            delete_userinfo.TopLevel = false;
            delete_userinfo.FormBorderStyle = FormBorderStyle.None;
            Info.Controls.Clear();
            Info.Controls.Add(delete_userinfo);
            delete_userinfo.Show();
        }

        private void CheckBookHadBorrow(object sender, EventArgs e)
        {
            CheckBookHadBorrow_Info checkBookHadBorrow_Info = new CheckBookHadBorrow_Info(user);
            checkBookHadBorrow_Info.TopLevel = false;
            checkBookHadBorrow_Info.FormBorderStyle = FormBorderStyle.None;
            Info.Controls.Clear();
            Info.Controls.Add(checkBookHadBorrow_Info);
            checkBookHadBorrow_Info.Show();
        }

        private void CheckBookInfo_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CheckBookInfo checkBookInfo = new CheckBookInfo(userName);
            checkBookInfo.TopLevel = false;
            checkBookInfo.FormBorderStyle = FormBorderStyle.None;
            Info.Controls.Clear();
            Info.Controls.Add(checkBookInfo);
            checkBookInfo.Show();
        }

        private void AddBookInfo_ToolStripMenuItem(object sender, EventArgs e)
        {
            AddBookInfo addBookInfo = new AddBookInfo(user);
            addBookInfo.TopLevel = false;
            addBookInfo.FormBorderStyle = FormBorderStyle.None;
            Info.Controls.Clear();
            Info.Controls.Add(addBookInfo);
            addBookInfo.Show();
        }

        private void DeleteBookInfo_ToolStripMenuItem(object sender, EventArgs e)
        {
            DeleteBookInfo deleteBookInfo = new DeleteBookInfo();
            deleteBookInfo.TopLevel = false;
            deleteBookInfo.FormBorderStyle = FormBorderStyle.None;
            Info.Controls.Clear();
            Info.Controls.Add(deleteBookInfo);
            deleteBookInfo.Show();
        }

        private void BorrowBookInfo_ToolStripMenuItem(object sender, EventArgs e)
        {
            BorrowBookInfo borrowBookInfo = new BorrowBookInfo(user);
            borrowBookInfo.TopLevel = false;
            borrowBookInfo.FormBorderStyle = FormBorderStyle.None;
            Info.Controls.Clear();
            Info.Controls.Add(borrowBookInfo);
            borrowBookInfo.Show();
        }

    }
}
