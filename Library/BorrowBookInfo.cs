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
            user = u;
        }

        private void Borrow_Submit_Click(object sender, EventArgs e)
        {
            book.Title = BorrowBook_textbox.Text;
            if (!manager.CheckBookExists(book))
            {
                MessageBox.Show("此本书不存在!请核实您所输入的书名!");
                return;
            }
            book = manager.getBook(book);
            if (book.Num > 0)
            {
                if (!manager.checkBookHadBorrow(user, book))
                {
                    manager.borrowBook(user, book);
                    MessageBox.Show("借阅成功!请于2个月后归还!");
                }
                else
                {
                    MessageBox.Show("这本书您已经借阅过了!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("图书已全部借出!库存量已经为0!");
            }
        }
    }
}
