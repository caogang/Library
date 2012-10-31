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
    public partial class Login : Form
    {
        User user = new User();
        Manager manager = new Manager();
        public Login()
        {
            InitializeComponent();
        }

        private void login(object sender, EventArgs e)
        {
            user.UserName = textBox1.Text;
            user.PassWord = textBox2.Text;
            if (!manager.CheckUserNameExists(user.UserName))
            {
                MessageBox.Show("用户名不存在!请重新输入!");
                return;
            }
            if (manager.CheckUserValidate(user))
            {
                user = manager.getUser(user);
                MessageBox.Show("登陆成功！");
                Main f2 = new Main(user);
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("密码不正确!登录失败!");
            }
        }

        private void Reset(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
