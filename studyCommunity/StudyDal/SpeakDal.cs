using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudyModel;
using System.Data;
using System.Collections;

namespace StudyDal
{
    public class SpeakDal
    {
        sqlHelp sqlDal = new sqlHelp();

        public int addSpeak(tb_Speak speak)
        {
            return sqlDal.sqlUpdate("insert into tb_Speak(Speakman,TutorialType,TutorialID,SpeakContent) values(@Speakman,@TutorialType,@TutorialID,@SpeakContent)",
                new string[] { "@Speakman","@TutorialType","@TutorialID","@SpeakContent" },
                new string[] { speak.Speakman, speak.TutorialType, speak.TutorialID.ToString(),speak.SpeakContent });
        }

        public List<tb_Speak> selPagingSpeak(string TableName, int TutorialID, int pageIndex, int pageSize)
        {
            tb_Speak Speak = null;
            DataSet list = sqlDal.sqlProcDs("GETSPEAKTABLEPAGE",
                new string[] { "@TABLENAME", "@TutorialID", "@PAGEINDEX", "@PAGESIZE" },
                new string[] { TableName, TutorialID.ToString(), pageIndex.ToString(), pageSize.ToString() });
            List<tb_Speak> speakList = new List<tb_Speak>();
            foreach (DataRow obj in list.Tables[0].Rows)
            {
                Speak = new tb_Speak();
                Speak.SpeakID = Convert.ToInt32(obj[0]);
                Speak.Speakman = obj[1].ToString();
                Speak.SpeakDate = Convert.ToDateTime(obj[5]);
                Speak.SpeakContent = obj[4].ToString();
                speakList.Add(Speak);
            }
            return speakList;
        }

        public int getPageCount(string TutorialType, int TutorialID)
        {
            return (int)sqlDal.sqlOneDr("select count(*) from tb_Speak,tb_Video where convert(varchar,TutorialType)=@TutorialType and TutorialID=@TutorialID",
                new string[] { "@TutorialType", "@TutorialID" },
                new string[] { TutorialType, TutorialID.ToString() });
        }

        public int delSpeak(int SpeakID)
        {
            return (int)sqlDal.sqlUpdate("delete tb_Speak where SpeakID=@SpeakID",
                new string[] { "@SpeakID" },
                new string[] { SpeakID.ToString() });
        }
    }
}
