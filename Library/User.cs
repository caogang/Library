using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{

    public class User
    {
        private int user_id;

        public int User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string sex;

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private string isAdmin;

        public string IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }
        private int hadBorrow;

        public int HadBorrow
        {
            get { return hadBorrow; }
            set { hadBorrow = value; }
        }
        private int countBorrow;

        public int CountBorrow
        {
            get { return countBorrow; }
            set { countBorrow = value; }
        }
    }

}
