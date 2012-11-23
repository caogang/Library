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
            if (Check_dataGridView1.ColumnCount != 0)
            {
                Check_dataGridView1.Columns.RemoveAt(Check_dataGridView1.ColumnCount - 1);
                Check_dataGridView1.Columns.RemoveAt(Check_dataGridView1.ColumnCount - 1);
                Check_dataGridView1.Columns.RemoveAt(Check_dataGridView1.ColumnCount - 1);
            }
            try
            {
                string test = comboBox1.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("请选择要查询的项目!");
                return;
            }
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            if (comboBox1.SelectedItem.ToString() != "出版时间")
            {
                if (comboBox1.SelectedItem.ToString() == "剩余数量")
                {
                    try
                    {
                        Convert.ToInt16(CheckBook_textbox1.Text);
                    }
                    catch
                    {
                        MessageBox.Show("输入不合法,请输入数字!");
                        return;
                    }
                }
                Check_dataGridView1.DataSource = manager.selectBook(CheckBook_textbox1.Text, comboBox1.SelectedItem.ToString()).Tables[0].DefaultView;
            }
            else
            {
                Check_dataGridView1.DataSource = manager.selectBook(dateTimePicker1.Value.ToShortDateString(), comboBox1.SelectedItem.ToString()).Tables[0].DefaultView;
            }
            DataGridViewImageColumn image = new DataGridViewImageColumn();//添加一个自定义Image编辑列
            image.HeaderText = "编辑";
            image.Width = 50;
            image.DefaultCellStyle = dataGridViewCellStyle1;
            image.Image = global::Library.Properties.Resources.edit2;
            DataGridViewImageColumn image1 = new DataGridViewImageColumn();//添加一个自定义Image删除列
            image1.HeaderText = "删除";
            image1.DefaultCellStyle = dataGridViewCellStyle1;
            image1.Width = 60;
            image1.Image = global::Library.Properties.Resources.delete1;
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "上/下架";
            button.Width = 60;
            button.DefaultCellStyle.NullValue = "上/下架";
            Check_dataGridView1.Columns.AddRange(image);
            Check_dataGridView1.Columns.AddRange(image1);
            Check_dataGridView1.Columns.AddRange(button);
        }

        private void Edit_Submit_Click(object sender, EventArgs e)
        {
            init();
            if (book.Book_id != 0)
            {
                edit_Submit();
            }
        }

        private void Check_dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            init();
            if (book.IsDown == "是")
            {
                Down.Text = "上架";
                Down.Refresh();
            }
            else
            {
                Down.Text = "下架";
                Down.Refresh();
            } 
        }

        private void edit_Submit()
        {
            EditBook editor = new EditBook(book, this);
            editor.Show();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            init();
            if (book.Book_id != 0)
            {
                delete_Submit();
            }
        }

        private void delete_Submit()
        {
            init();
            DialogResult r = MessageBox.Show("是否要真的删除", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                manager.deleteBook(book);
                MessageBox.Show("删除成功!");
                refreshSelf();
            }
            else return;
        }

        public void refreshSelf()
        {
            init();
            CheckBook_Submit_Click(new object(), new EventArgs());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "出版时间")
            {
                CheckBook_textbox1.Visible = false;
                dateTimePicker1.Visible = true;
            }
            else
            {
                CheckBook_textbox1.Visible = true;
                dateTimePicker1.Visible = false;
            }
        }

        private void DownOrUp()
        {
            string test;
            if (book.IsDown == "是")
            {
                book.IsDown = "否";
                test = "上架";
            }
            else
            {
                book.IsDown = "是";
                test = "下架";
            }
            try
            {
                manager.updateBook(book);
                MessageBox.Show("图书"+ test +"成功");
            }
            catch
            {
                MessageBox.Show("由于未知原因!图书"+ test +"失败!");
                return;
            }
            refreshSelf();
        }

        private void Down_Click(object sender, EventArgs e)
        {
            init();
            if (book.Book_id != 0)
            {
                DownOrUp();
            }
        }

        private void init()
        {
                if (Check_dataGridView1.CurrentRow != null)
                {
                    //int row = Check_dataGridView1.CurrentRow.Index;
                    book = new Book();
                    book.Book_id = Convert.ToInt16(Check_dataGridView1.CurrentRow.Cells[0].Value);
                    book = manager.getBook(book);
                }
                else
                {
                    book.Book_id = 0;
                }
            
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
                Edit_Submit_Click(sender, e);
            }
            else if (dgv.Columns[e.ColumnIndex].HeaderText == "删除")
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                Delete_Click(sender, e);
            }
            else if (dgv.Columns[e.ColumnIndex].HeaderText == "上/下架")
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                Down_Click(sender, e);
            }
        }

    }
}
