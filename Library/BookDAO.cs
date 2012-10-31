using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Library
{
    class BookDAO
    {
        SqlCommand sqlcom;
        SqlDataAdapter sda;
        Book book = new Book();
        static string sqlstr = Properties.Settings.Default.LibraryConnectionString;
        SqlConnection conn = new SqlConnection(sqlstr);

        public int insertBook(Book b)
        {
            try
            {
                conn.Open();
                string sql = @"INSERT INTO [Library].[dbo].[Book]
           ([title]
           ,[content]
           ,[num]
           ,[date]
           ,[publisher]
           ,[publishing_home])
     VALUES
           ('" + b.Title + @"'
           ,'" + b.Content + @"'
           ,'" + b.Num + @"'
           ,'" + b.Date + @"'
           ,'" + b.Publisher + @"'
           ,'" + b.Publishing_home + "')";
                sqlcom = new SqlCommand(sql, conn);
                sqlcom.ExecuteScalar();
                return 1;
            }
            catch
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public int deleteBook(Book b)
        {
            try
            {
                conn.Open();
                string sql = @"DELETE FROM [Library].[dbo].[Book]
      WHERE book_id = " + b.Book_id;
                sqlcom = new SqlCommand(sql, conn);
                sqlcom.ExecuteScalar();
                return 1;
            }
            catch
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public int updateBook(Book b)
        {
            try
            {
                conn.Open();
                string sql = @"UPDATE [Library].[dbo].[Book]
   SET [title] = '" + b.Title + @"'
      ,[content] = '" + b.Content + @"'
      ,[num] = '" + b.Num + @"'
      ,[date] = '" + b.Date + @"'
      ,[publisher] = '" + b.Publisher + @"'
      ,[publishing_home] = '" + b.Publishing_home + @"'
 WHERE book_id = " + b.Book_id;
                sqlcom = new SqlCommand(sql, conn);
                sqlcom.ExecuteScalar();
                return 1;
            }
            catch
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataSet selectBook()
        {
            string sql = @"SELECT [book_id]
      ,[title]
      ,[content]
      ,[num]
      ,[date]
      ,[publisher]
      ,[publishing_home]
  FROM [Library].[dbo].[Book]";
            sqlcom = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public DataSet getBookToDataSetByUser(User u)
        {
            string sql = @"SELECT [book_id]
        ,[borrowDate]
        ,[returnDate]
  FROM [Library].[dbo].[Link] where [user_id]=" + u.User_id;
            sqlcom = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            int[] book_ids=new int[u.HadBorrow];
            string[] borrowDates = new string[u.HadBorrow];
            string[] returnDates = new string[u.HadBorrow];
            for (int i = 0; i < u.HadBorrow; i++)
            {
                book_ids[i] = Convert.ToInt16(ds.Tables[0].Rows[i][0]);
                borrowDates[i] = ds.Tables[0].Rows[i][1].ToString();
                returnDates[i] = ds.Tables[0].Rows[i][2].ToString();
            }
            ds = new DataSet();
            for (int i = 0; i < u.HadBorrow; i++ )
            {
                sql = @"SELECT [title]
      ,[content]
      ,[num]
      ,[date]
      ,[publisher]
      ,[publishing_home]
  FROM [Library].[dbo].[Book] where [book_id]="+book_ids[i];
                sqlcom = new SqlCommand(sql, conn);
                sda = new SqlDataAdapter(sqlcom);
                sda.Fill(ds);
            }
            if (u.HadBorrow != 0)
            {
                DataColumn borrowDate = new DataColumn();
                DataColumn returnDate = new DataColumn();
                borrowDate.ColumnName = "借阅日期";
                returnDate.ColumnName = "应归还日期";
                ds.Tables[0].Columns.Add(borrowDate);
                ds.Tables[0].Columns.Add(returnDate);
                for (int i = 0; i < u.HadBorrow; i++)
                {
                    ds.Tables[0].Rows[i]["借阅日期"] = borrowDates[i];
                    ds.Tables[0].Rows[i]["应归还日期"] = returnDates[i];
                }
            }
            return ds;
        }

    }
}
