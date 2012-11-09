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
    public partial class EditBook : Form
    {
        Book book = new Book();
        Manager manager = new Manager();
        CheckBookInfo c = new CheckBookInfo("");
        public EditBook(Book b,CheckBookInfo test)
        {
            book = b;
            InitializeComponent();
            c = test;
            Book_Title.Text = book.Title;
            Book_content.Text = book.Content;
            Book_num.Text = book.Num.ToString() ;
            Book_publisher.Text = book.Publisher;
            Book_publishing_home.Text = book.Publishing_home;
            dateTimePicker1.Value = book.Date;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Click(object sender, EventArgs e)
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
                manager.updateBook(book);
                MessageBox.Show("更新图书数据成功!");
                c.refreshSelf();//修改后刷新CheckBookInfo的datagridview
                resets();
            }
            catch
            {
                MessageBox.Show("更新图书时出现未知错误!");
            }
        }

        private void resets()
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
