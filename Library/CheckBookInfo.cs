﻿using System;
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
            else if (dgv.Columns[e.ColumnIndex].HeaderText == "删除")
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                delete_Submit();
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
            EditBook editor = new EditBook(book,this);
            editor.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            delete_Submit();
        }

        private void delete_Submit()
        {
            int row = Check_dataGridView1.CurrentCell.RowIndex;
            book.Book_id = Convert.ToInt16(Check_dataGridView1.Rows[row].Cells[0].Value);
            book.Title = Check_dataGridView1.Rows[row].Cells[1].Value.ToString();
            DialogResult r = MessageBox.Show("是否要真的删除", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                manager.deleteBook(book);
                MessageBox.Show("删除成功!");
                refreshSelf();
            }
            else return;
            //manager.deleteBook(book);
        }

        public void refreshSelf()
        {
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

    }
}
