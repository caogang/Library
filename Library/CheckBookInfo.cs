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
    public partial class CheckBookInfo : Form
    {
        Manager manager = new Manager();
        public CheckBookInfo(String username)
        {
            InitializeComponent();
        }

        private void CheckBook_Submit_Click(object sender, EventArgs e)
        {
            Check_dataGridView1.DataSource = manager.selectBook(CheckBook_textbox1.Text).Tables[0].DefaultView;
        }
    }
}
