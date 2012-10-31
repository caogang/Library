using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class UserInfo : Form
    {
        string userName;
        string sql;
        string sqlstr;
        SqlConnection conn;
        public UserInfo(User user)
        {
            InitializeComponent();
            userName = user.UserName;
            User.Text = userName;
            sqlstr = Properties.Settings.Default.LibraryConnectionString;
            conn = new SqlConnection(sqlstr);
            conn.Open();
            sql = @"SELECT [user_id]
      ,[sex]
      ,[hadBorrow]
      ,[countBorrow]
  FROM [Library].[dbo].[User] where [userName]='" + userName + "'";
            SqlCommand scm = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(scm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            int user_id = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
            String sex = ds.Tables[0].Rows[0][1].ToString();
            int hadborrow = Convert.ToInt16(ds.Tables[0].Rows[0][2]);
            int countborrow = Convert.ToInt16(ds.Tables[0].Rows[0][3]);
            Sex.Text = sex;
            hadBorrow.Text = hadborrow.ToString();
            countBorrow.Text = countborrow.ToString();
            int[] book_ids = new int[hadborrow];
            sql = @"SELECT [book_id]
  FROM [Library].[dbo].[Link] where [user_id]=" + user_id;
            SqlCommand scm1 = new SqlCommand(sql, conn);
            SqlDataAdapter sda1 = new SqlDataAdapter(scm1);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);
            for (int i = 0; i < hadborrow; i++)
            {
                book_ids[i] = Convert.ToInt16(ds1.Tables[0].Rows[i][0]);
            }
            DataSet s = new DataSet();
            DataTable dt = new DataTable();
            for (int i = 0; i < hadborrow; i++)
            {
                sql = @"SELECT [title]
      ,[num]
      ,[content]
      ,[date]
      ,[publisher]
      ,[publishing_home]
  FROM [Library].[dbo].[Book] where [book_id]=" + book_ids[i];
                SqlCommand sm = new SqlCommand(sql, conn);
                SqlDataAdapter sa = new SqlDataAdapter(sm);
                sa.Fill(s);
            }
            if (hadborrow != 0)
            {
                dt = s.Tables[0];
                dataGridView1.DataSource = dt.DefaultView;
                dataGridView1.Columns["title"].HeaderText = "书名";
                dataGridView1.Columns["content"].HeaderText = "简介";
                dataGridView1.Columns["publisher"].HeaderText = "著者";
                dataGridView1.Columns["publishing_home"].HeaderText = "出版社";
                dataGridView1.Columns["date"].HeaderText = "出版日期";
                dataGridView1.Columns["num"].HeaderText = "剩余的数目";
            }

        }
    }
}
