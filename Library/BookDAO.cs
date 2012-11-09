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
                b = this.getBook(b);
                string sql = @"DELETE FROM [Library].[dbo].[Book]
      WHERE book_id = " + b.Book_id + " OR title = '" + b.Title +"'";
                sqlcom = new SqlCommand(sql, conn);
                sqlcom.ExecuteScalar();
                sql = @"DELETE FROM [Library].[dbo].[Link]
      WHERE book_id = " + b.Book_id ;
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

        public DataSet selectBooks()
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

        public Book getBook(Book b)
        {
            string sql = @"SELECT [book_id]
      ,[title]
      ,[content]
      ,[num]
      ,[date]
      ,[publisher]
      ,[publishing_home]
  FROM [Library].[dbo].[Book] where [book_id]='" + b.Book_id + "' OR [title]='" + b.Title + "'";
            sqlcom = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            b.Book_id = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
            b.Title = ds.Tables[0].Rows[0][1].ToString();
            b.Content = ds.Tables[0].Rows[0][2].ToString();
            b.Num = Convert.ToInt16(ds.Tables[0].Rows[0][3]);
            b.Date = (DateTime)ds.Tables[0].Rows[0][4];
            b.Publisher = ds.Tables[0].Rows[0][5].ToString();
            b.Publishing_home = ds.Tables[0].Rows[0][6].ToString();
            return b;
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

        public DataSet getBookToDatasetByTitle(String title)
        {
            string sql = @"SELECT [book_id]
      ,[title]
      ,[content]
      ,[num]
      ,[date]
      ,[publisher]
      ,[publishing_home]
  FROM [Library].[dbo].[Book] where [title] Like '" + title+ "%' ";
            sqlcom = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public DataSet getBookToDatasetByNumber(int num)
        {
            string sql = @"SELECT [book_id]
      ,[title]
      ,[content]
      ,[num]
      ,[date]
      ,[publisher]
      ,[publishing_home]
  FROM [Library].[dbo].[Book] where [num] = " + num;
            sqlcom = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public bool checkBookExist(Book b)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM [Library].[dbo].[Book] where [title]='" + b.Title + "'";
                sqlcom = new SqlCommand(sql, conn);
                object tp = sqlcom.ExecuteScalar();
                if (tp == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public int BorrowBooks(User u, Book b)
        {
            try
            {
                conn.Open();
                DateTime date = new DateTime();
                date = System.DateTime.Now;
                DateTime returnDate = new DateTime();
                returnDate = date.AddMonths(2);
                string sql = @"INSERT INTO [Library].[dbo].[Link]
           ([user_id]
           ,[book_id]
           ,[borrowDate]
           ,[returnDate])
     VALUES
           ('" + u.User_id + @"'
           ,'" + b.Book_id + @"'
           ,'" + date + @"'
           ,'" + returnDate + "')";
                sqlcom = new SqlCommand(sql, conn);
                object tp = sqlcom.ExecuteScalar();
                if (tp == null)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public int ReturnBooks(User u, Book b)
        {
            try
            {
                conn.Open();
                string sql = @"DELETE FROM [Library].[dbo].[Link]
            WHERE [user_id] = " + u.User_id +" AND [book_id] = " + b.Book_id;
                sqlcom = new SqlCommand(sql, conn);
                object tp = sqlcom.ExecuteScalar();
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

        public bool CheckBookHadBorrow(User u, Book b)
        {
            string sql = @"SELECT [book_id]
  FROM [Library].[dbo].[Link] where [user_id]=" + u.User_id;
            sqlcom = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            int[] book_ids = new int[u.HadBorrow];
            for (int i = 0; i < u.HadBorrow; i++)
            {
                book_ids[i] = Convert.ToInt16(ds.Tables[0].Rows[i][0]);
            }
            for (int j = 0; j < u.HadBorrow; j++)
            {
                if (book_ids[j] == b.Book_id)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
