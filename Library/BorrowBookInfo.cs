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
    public partial class BorrowBookInfo : Form
    {
        User user = new User();
        Book book = new Book();
        Manager manager = new Manager();
        public BorrowBookInfo(User u)
        {
            InitializeComponent();
            book.Title = "ad";
            user = u;
            manager.borrowBook(user, book);
        }
    }
}
