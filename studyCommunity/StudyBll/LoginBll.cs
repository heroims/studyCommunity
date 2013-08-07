using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudyModel;
using StudyDal;

namespace StudyBll
{
    public class LoginBll
    {
        LoginDal ld = new LoginDal();
        public string getPass(string UserName, string Soul, string Ques)
        {
            return ld.getPass(UserName, Soul, Ques);
        }
        public int addLogin(tb_login login)
        {
            return ld.addLogin(login);
        }

        public int delLogin(int id)
        {
            return ld.delLogin(id);
        }

        public int updateLockLogin(string Name)
        {
            return ld.updateLockLogin(Name);
        }

        public List<tb_login> selLogin()
        {
            return ld.selLogin();
        }

        public bool isUserName(string Name)
        {
            if (ld.isUserName(Name)==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isLogin(tb_login login)
        {
            if (ld.isLogin(login)==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
