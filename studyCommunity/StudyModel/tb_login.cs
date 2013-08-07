using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyModel
{
    public class tb_login
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        string _pass;

        public string Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }
        string _zname;

        public string Zname
        {
            get { return _zname; }
            set { _zname = value; }
        }
        string _sex;

        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        string _idcard;

        public string Idcard
        {
            get { return _idcard; }
            set { _idcard = value; }
        }
        string _passQuestion;

        public string PassQuestion
        {
            get { return _passQuestion; }
            set { _passQuestion = value; }
        }
        string _passSolution;

        public string PassSolution
        {
            get { return _passSolution; }
            set { _passSolution = value; }
        }
        DateTime _loginDate;

        public DateTime LoginDate
        {
            get { return _loginDate; }
            set { _loginDate = value; }
        }
        int _lock;

        public int _lock1
        {
            get { return _lock; }
            set { _lock = value; }
        }
    }
}
