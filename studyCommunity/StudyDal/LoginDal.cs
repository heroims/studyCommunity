using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudyModel;
using System.Collections;

namespace StudyDal
{
    public class LoginDal
    {
        sqlHelp sqlDal = new sqlHelp();

        public string getPass(string UserName, string Soul, string Ques)
        {
            object obj = sqlDal.sqlOneDr("select Pass from tb_login where convert(varchar,Name)=@Name and convert(varchar,PassSolution)=@PassSolution and convert(varchar,PassQuestion)=@PassQuestion",
                new string[] { "@Name", "@PassSolution", "@PassQuestion" },
                new string[] { UserName, Soul, Ques });
            if (obj==null)
            {
                return null;
            }
            else
            {
                return obj.ToString();
            }
        }
        public List<tb_login> selLogin()
        {
            tb_login login=null;
            string sel = "select ID,Name,LoginDate,Lock from tb_login";
            List<ArrayList> list = sqlDal.sqlDr(sel, null, null);
            List<tb_login> loginList = new List<tb_login>();
            foreach (ArrayList obj in list)
            {
                login = new tb_login();
                login.Id = (int)obj[0];
                login.Name = obj[1].ToString();
                login.LoginDate = (DateTime)obj[2];
                login._lock1 = (int)obj[3];
                loginList.Add(login);
            }
            return loginList;
        }

        public int addLogin(tb_login login)
        {
            return sqlDal.sqlUpdate("insert into tb_login(Name,Pass,Zname,Sex,Email,IDcard,PassQuestion,PassSolution) values(@Name,@Pass,@Zname,@Sex,@Email,@IDcard,@PassQuestion,@PassSolution)",
                new string[]{"@Name","@Pass","@Zname","@Sex","@Email","@IDcard","@PassQuestion","@PassSolution"},
                new string[]{login.Name,login.Pass,login.Zname,login.Sex,login.Email,login.Idcard,login.PassQuestion,login.PassSolution});
        }

        public int delLogin(int id)
        {
            return sqlDal.sqlUpdate("delete tb_login where ID=@ID",
                new string[] { "@ID" }, 
                new string[] { id.ToString() });
        }

        public int updateLockLogin(string Name)
        {
            return sqlDal.sqlUpdate("update tb_login set Lock=case when Lock=0 then 1 else 0 end where convert(varchar,Name)=@Name",
                new string[] { "@Name" },
                new string[] { Name });
        }

        public int isUserName(string Name)
        {
            return (int)sqlDal.sqlOneDr("select count(*) from tb_login where convert(varchar,Name)=@Name",
                new string[] { "@Name" },
                new string[] { Name });
        }

        public int isLogin(tb_login login)
        {
            return (int)sqlDal.sqlOneDr("select count(*) from tb_login where convert(varchar,Name)=@Name and convert(varchar,Pass)=@Pass and Lock=0",
                new string[] { "@Name", "@Pass" },
                new string[] { login.Name, login.Pass });
        }
    }
}
