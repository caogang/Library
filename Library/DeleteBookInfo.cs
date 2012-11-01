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
    public partial class DeleteBookInfo : Form
    {
        Manager manager = new Manager();
        Book book = new Book();
        public DeleteBookInfo()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            book.Title = Delete_BookName.Text;
            if (!manager.CheckBookExists(book))
            {
                MessageBox.Show("图书不存在!请重新输入!");
                return;
            }
            try
            {
                manager.deleteBook(book);
                MessageBox.Show("删除图书成功!");
                Delete_BookName.ResetText();
                return;
            }
            catch
            {
                MessageBox.Show("删除图书时出现未知错误!");
            }
        }
    }
}
