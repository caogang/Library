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
    public partial class CheckUserInfo : Form
    {
        User user = new User();
        Manager manager = new Manager();
        public CheckUserInfo(String username)
        {
            InitializeComponent();
        }

        private void Check_Submit_Click(object sender, EventArgs e)
        {
            Check_dataGridView1.DataSource = manager.selectUser(CheckUser_textbox1.Text).Tables[0].DefaultView;
        }

        private void Edit_Submit_Click(object sender, EventArgs e)
        {
            int row = Check_dataGridView1.CurrentCell.RowIndex;
            user.User_id = Convert.ToInt16(Check_dataGridView1.Rows[row].Cells[0].Value);
            user.UserName = Check_dataGridView1.Rows[row].Cells[1].Value.ToString();
            user.PassWord = Check_dataGridView1.Rows[row].Cells[2].Value.ToString();
            user.Age = Convert.ToInt16(Check_dataGridView1.Rows[row].Cells[3].Value);
            user.IsAdmin = Check_dataGridView1.Rows[row].Cells[4].Value.ToString();
            user.Sex = Check_dataGridView1.Rows[row].Cells[5].Value.ToString();
            user.HadBorrow = Convert.ToInt16(Check_dataGridView1.Rows[row].Cells[6].Value);
            user.CountBorrow = Convert.ToInt16(Check_dataGridView1.Rows[row].Cells[7].Value);
            EditUser editor = new EditUser(user);
            editor.Show();
        }
    }
}
