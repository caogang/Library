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
    public partial class ReturnBookInfo : Form
    {
        User user = new User();
        Book book = new Book();
        Manager manager = new Manager();
        public ReturnBookInfo(User u)
        {
            user = u;
            InitializeComponent();
        }

        private void Return_Submit_Click(object sender, EventArgs e)
        {
            book.Title = ReturnBook_textbox.Text;
            book = manager.getBook(book);
            if(manager.returnBook(user, book) == 1)
            {
                MessageBox.Show("归还图书成功!");
            }
        }
    }
}
