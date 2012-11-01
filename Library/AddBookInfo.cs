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
    public partial class AddBookInfo : Form
    {
        Book book = new Book();
        Manager manager = new Manager();
        public AddBookInfo(User u)
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            book.Title = Book_Title.Text;
            try
            {
                book.Num = Convert.ToInt16(Book_num.Text);
            }
            catch
            {
                MessageBox.Show("库存量必须为数字!");
                return;
            }
            book.Content = Book_content.Text;
            book.Publisher = Book_publisher.Text.ToString();
            book.Date = dateTimePicker1.Value;
            book.Publishing_home = Book_publishing_home.Text.ToString();
            try
            {
                manager.addBook(book);
                MessageBox.Show("添加图书成功!");
                reset();
            }
            catch
            {
                MessageBox.Show("添加图书时出现未知错误!");
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            Book_Title.ResetText();
            Book_num.ResetText();
            Book_content.ResetText();
            Book_publisher.ResetText();
            dateTimePicker1.ResetText();
            Book_publishing_home.ResetText();
        }

    }
}
