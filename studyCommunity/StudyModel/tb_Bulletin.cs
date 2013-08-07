using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyModel
{
    public class tb_Bulletin
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        string _content;

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
