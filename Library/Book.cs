using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class Book
    {
        int book_id;

        public int Book_id
        {
            get { return book_id; }
            set { book_id = value; }
        }
        string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        int num;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        string publisher;

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        string publishing_home;

        public string Publishing_home
        {
            get { return publishing_home; }
            set { publishing_home = value; }
        }
        string isDown;

        public string IsDown
        {
            get { return isDown; }
            set { isDown = value; }
        }
    }
}
