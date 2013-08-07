using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudyModel;
using System.Collections;

namespace StudyDal
{
    public class BulletinDal
    {
        sqlHelp sqlDal = new sqlHelp();

        public int addBulletin(tb_Bulletin bull)
        {
            return sqlDal.sqlUpdate("insert into tb_Bulletin(Title,Content,Name) values(@Title,@Content,@Name)",
                new string[] { "@Title", "@Content", "@Name" },
                new string[] { bull.Title, bull.Content, bull.Name });
        }

        public int delBulletin(int id)
        {
            return sqlDal.sqlUpdate("delete tb_Bulletin where ID=@ID",
                new string[] { "@ID" },
                new string[] { id.ToString() });
        }

        public List<tb_Bulletin> selBulletin()
        {
            tb_Bulletin bull = null;
            string sel = "select ID,Title,Date from tb_Bulletin";
            List<ArrayList> list = sqlDal.sqlDr(sel, null, null);
            List<tb_Bulletin> bullList=new List<tb_Bulletin>();
            foreach (ArrayList obj in list)
            {
                bull = new tb_Bulletin();
                bull.Id=(int)obj[0];
                bull.Title = obj[1].ToString();
                bull.Date = (DateTime)obj[2];
                bullList.Add(bull);
            }
            return bullList;
        }

        public List<tb_Bulletin> selNewBulletin()
        {
            tb_Bulletin bull = null;
            string sel = "select top 5 ID,Title,Date from tb_Bulletin order by Date desc";
            List<ArrayList> list = sqlDal.sqlDr(sel, null, null);
            List<tb_Bulletin> bullList = new List<tb_Bulletin>();
            foreach (ArrayList obj in list)
            {
                bull = new tb_Bulletin();
                bull.Id = (int)obj[0];
                bull.Title = obj[1].ToString();
                bull.Date = (DateTime)obj[2];
                bullList.Add(bull);
            }
            return bullList;
        }

        public tb_Bulletin selOneBulletin(int id)
        {
            tb_Bulletin bull = new tb_Bulletin();
            string sel = "select ID,Title,Date,Content,Name from tb_Bulletin where ID=@ID";
            ArrayList list = sqlDal.sqlOnesDr(sel,
                new string[] { "@ID" },
                new string[] { id.ToString() });
            bull.Id = (int)list[0];
            bull.Title = list[1].ToString();
            bull.Date = (DateTime)list[2];
            bull.Content = list[3].ToString();
            bull.Name = list[4].ToString();
            return bull;
        }
    }
}
