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
        Book book = new Book();
        Manager manager = new Manager();
        public CheckBookInfo(String username)
        {
            InitializeComponent();
        }

        private void CheckBook_Submit_Click(object sender, EventArgs e)
        {
            Check_dataGridView1.DataSource = manager.selectBook(CheckBook_textbox1.Text).Tables[0].DefaultView;
        }

        private void Edit_Submit_Click(object sender, EventArgs e)
        {
            int row = Check_dataGridView1.CurrentCell.RowIndex;
            book.Book_id=Convert.ToInt16(Check_dataGridView1.Rows[row].Cells[0].Value);
            book.Title = Check_dataGridView1.Rows[row].Cells[1].Value.ToString();
            book.Content = Check_dataGridView1.Rows[row].Cells[2].Value.ToString();
            book.Num = Convert.ToInt16(Check_dataGridView1.Rows[row].Cells[3].Value);
            book.Date = (DateTime)Check_dataGridView1.Rows[row].Cells[4].Value;
            book.Publisher = Check_dataGridView1.Rows[row].Cells[5].Value.ToString();
            book.Publishing_home = Check_dataGridView1.Rows[row].Cells[6].Value.ToString();
            EditBook editor = new EditBook(book);
            editor.Show();
        }
    }
}
