using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class AddUserInfo : Form
    {
        User user = new User();
        Manager manager = new Manager();
        public AddUserInfo(User u)
        {
            user = u;
            InitializeComponent();
            if (user.IsAdmin != "是")
            {
                label5.Hide();
                checkBox1.Hide();
                Submit.Site.ToString();
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            user.UserName = UserName.Text;
            if (user.UserName == "")
            {
                MessageBox.Show("用户名不允许为空!");
                resetPass();
                return;
            }
            if (manager.CheckUserNameExists(user.UserName))
            {
                MessageBox.Show("用户已存在!请重新输入!");
                reset();
                return;
            }
            user.PassWord = PassWord.Text;
            if (user.PassWord == "")
            {
                MessageBox.Show("密码不允许为空!");
                resetPass();
                return;
            }
            if (radioButton1.Checked)
            {
                user.Sex = radioButton1.Text;
            }
            else
            {
                if (radioButton2.Checked)
                {
                    user.Sex = radioButton2.Text;
                }
                else
                {
                    MessageBox.Show("未选性别!");
                    return;
                }
            }
            if (checkBox1.Checked)
            {
                user.IsAdmin = checkBox1.Text;
            }
            else
            {
                user.IsAdmin = "否";
            }
            try
            {
                user.Age = Convert.ToInt16(Age.Text);
            }
            catch
            {
                MessageBox.Show("年龄必须为数字!请重新输入");
                return;
            }
            try
            {
                manager.addUser(user);
                MessageBox.Show("注册用户成功!");
            }
            catch
            {
                MessageBox.Show("抱歉!发生了未知错误!请重新输入!");
                reset();
                return;
            }
        }
        
        private void reset()
        {
            UserName.ResetText();
            PassWord.ResetText();
            Age.ResetText();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
        }

        private void resetPass()
        {
            PassWord.ResetText();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            reset();
        }

    }
}
