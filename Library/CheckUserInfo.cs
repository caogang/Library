﻿using System;
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
    }
}
