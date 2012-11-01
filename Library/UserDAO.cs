using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Library
{
    class UserDAO
    {

        SqlCommand sqlcom;
        SqlDataAdapter sda;
        User user = new User();
        static string sqlstr = Properties.Settings.Default.LibraryConnectionString;
        SqlConnection conn = new SqlConnection(sqlstr);

        public bool checkUserValidate(User u)
        {
            user = u;
            try
            {
                conn.Open();
                string sql = "SELECT [passWord] FROM [Library].[dbo].[User] where [userName]='" + user.UserName + "'";
                sqlcom = new SqlCommand(sql, conn);
                string pwd = sqlcom.ExecuteScalar().ToString();
                if (pwd == user.PassWord)
                {
                    return true;
                }
                else
                {
                    return false;
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

        public bool checkUserNameExist(String username)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM [Library].[dbo].[User] where [userName]='" + username + "'";
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

        public DataSet selectUser()
        {
            string sql= @"SELECT [user_id]
      ,[userName]
      ,[passWord]
      ,[age]
      ,[isAdmin]
      ,[sex]
      ,[hadBorrow]
      ,[countBorrow]
  FROM [Library].[dbo].[User]";
            sqlcom=new SqlCommand(sql,conn);
            sda=new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public User getUser(User u)
        {
            string sql = @"SELECT [user_id]
      ,[userName]
      ,[passWord]
      ,[age]
      ,[isAdmin]
      ,[sex]
      ,[hadBorrow]
      ,[countBorrow]
  FROM [Library].[dbo].[User] where [userName]='"+u.UserName+"'";
            sqlcom = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            user.User_id = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
            user.UserName = ds.Tables[0].Rows[0][1].ToString();
            user.PassWord = ds.Tables[0].Rows[0][2].ToString();
            user.Age = Convert.ToInt16(ds.Tables[0].Rows[0][3]);
            user.IsAdmin = ds.Tables[0].Rows[0][4].ToString();
            user.Sex = ds.Tables[0].Rows[0][5].ToString();
            user.HadBorrow = Convert.ToInt16(ds.Tables[0].Rows[0][6]);
            user.CountBorrow = Convert.ToInt16(ds.Tables[0].Rows[0][7]);
            return user;
        }

        public DataSet getUserToDataset(User u)
        {
            string sql = @"SELECT [user_id]
      ,[userName]
      ,[passWord]
      ,[age]
      ,[isAdmin]
      ,[sex]
      ,[hadBorrow]
      ,[countBorrow]
  FROM [Library].[dbo].[User] where [userName] Like '" + u.UserName + "%'";
            sqlcom = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public int insertUser(User u)
        {
            try
            {
                conn.Open();
                string sql = @"INSERT INTO [Library].[dbo].[User]
           ([userName]
           ,[passWord]
           ,[age]
           ,[isAdmin]
           ,[sex]
           ,[hadBorrow]
           ,[countBorrow])
     VALUES
           ('" + u.UserName + @"'
           ,'" + u.PassWord + @"'
           ,'" + u.Age + @"'
           ,'" + u.IsAdmin + @"'
           ,'" + u.Sex + @"'
           ,'" + u.HadBorrow + @"'
           ,'" + u.CountBorrow + "')";
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

        public int deleteUser(User u)
        {
            try
            {
                conn.Open();
                string sql = @"DELETE FROM [Library].[dbo].[User]
      WHERE user_id = "+ u.User_id +" OR userName = '"+ u.UserName +"'";
                sqlcom = new SqlCommand(sql, conn);
                sqlcom.ExecuteScalar();
                sql = @"DELETE FROM [Library].[dbo].[Link]
      WHERE user_id = " + u.User_id ;
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

        public int updateUser(User u)
        {
            try
            {
                conn.Open();
                string sql = @"UPDATE [Library].[dbo].[User]
   SET [userName] = '" + u.UserName + @"'
      ,[passWord] = '" + u.PassWord + @"'
      ,[age] = '" + u.Age + @"'
      ,[isAdmin] = '" + u.IsAdmin + @"'
      ,[sex] = '" + u.Sex + @"'
      ,[hadBorrow] = '" + u.HadBorrow + @"'
      ,[countBorrow] = '" + u.CountBorrow + @"'
 WHERE user_id = " + u.User_id ;
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

    }
}
