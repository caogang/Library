﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Library
{
    class Manager
    {
        User user = new User();

        internal User User
        {
            get { return user; }
            set { user = value; }
        }
        Book book = new Book();

        internal Book Book
        {
            get { return book; }
            set { book = value; }
        }
        UserDAO userDAO = new UserDAO();

        internal UserDAO UserDAO
        {
            get { return userDAO; }
            set { userDAO = value; }
        }
        BookDAO bookDAO = new BookDAO();

        internal BookDAO BookDAO
        {
            get { return bookDAO; }
            set { bookDAO = value; }
        }

        public User getUser(User user)
        {
            return userDAO.getUser(user);
        }

        public bool CheckUserValidate(User user)
        {
            return userDAO.checkUserValidate(user);
        }

        public bool CheckUserNameExists(String username)
        {
            return userDAO.checkUserNameExist(username);
        }

        public int addUser(User user)
        {
            return userDAO.insertUser(user);
        }

        public int deleteUser(User user)
        {
            return userDAO.deleteUser(user);
        }

        public int editUser(User user)
        {
            return userDAO.updateUser(user);
        }

        public DataSet selectUser(String username)
        {
            user.UserName = username;
            if (username != "")
            {
                return userDAO.getUserToDataset(user);
            }
            else
            {
                return userDAO.selectUser();
            }
        }

        public DataTable selectBooksByUser(User user)
        {
            try
            {
                return bookDAO.getBookToDataSetByUser(user).Tables[0];
            }
            catch
            {
                DataTable dt =new DataTable();
                return dt;
            }
        }

    }
}
