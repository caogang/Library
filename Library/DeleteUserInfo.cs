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
    public partial class DeleteUserInfo : Form
    {
        User user = new User();
        Manager manager = new Manager();
        public DeleteUserInfo()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            user.UserName = Delete_UserName.Text;
            if (!manager.CheckUserNameExists(user.UserName))
            {
                MessageBox.Show("用户" + user.UserName + "不存在!请重新输入!");
                Delete_UserName.ResetText();
                return;
            }
            try
            {
                manager.deleteUser(user);
                MessageBox.Show("删除成功!");
                Delete_UserName.ResetText();
            }
            catch
            {
                MessageBox.Show("删除过程中出现未知错误!");
                return;
            }
        }
    }
}
