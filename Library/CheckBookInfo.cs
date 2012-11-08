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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "编辑";
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            Check_dataGridView1.DataSource = manager.selectBook(CheckBook_textbox1.Text).Tables[0].DefaultView;
            DataGridViewImageColumn image = new DataGridViewImageColumn();//添加一个自定义Image列
            image.HeaderText = "编辑";
            image.Width = 50;
            image.DefaultCellStyle = dataGridViewCellStyle1;
            image.Image = global::Library.Properties.Resources.edit2;
            DataGridViewImageColumn image1 = new DataGridViewImageColumn();//添加一个自定义删除列
            image1.HeaderText = "删除";
            image1.DefaultCellStyle = dataGridViewCellStyle1;
            image1.Width = 50;
            image1.Image = global::Library.Properties.Resources.delete1;
            /*DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.DefaultCellStyle = dataGridViewCellStyle1;
            button.HeaderText = "Edit";
            button.Text = "编辑";
            button.Width = 50;
            Check_dataGridView1.Columns.AddRange(button);*/
            Check_dataGridView1.Columns.AddRange(image);
            Check_dataGridView1.Columns.AddRange(image1);
        }

        private void Edit_Submit_Click(object sender, EventArgs e)
        {
            edit_Submit();
        }

        private void Check_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex].HeaderText == "编辑")
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                edit_Submit();
            }
        }

        private void edit_Submit()
        {
            int row = Check_dataGridView1.CurrentCell.RowIndex;
            book.Book_id = Convert.ToInt16(Check_dataGridView1.Rows[row].Cells[0].Value);
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
