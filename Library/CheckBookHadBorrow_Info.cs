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
    public partial class CheckBookHadBorrow_Info : Form
    {
        Manager manager = new Manager();
        public CheckBookHadBorrow_Info(User u)
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = manager.selectBooksByUser(u);
            dataGridView1.DataSource = dt.DefaultView;
        }
    }
}
