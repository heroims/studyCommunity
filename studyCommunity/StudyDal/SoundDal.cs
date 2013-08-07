using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudyModel;
using System.Collections;
using System.Data;

namespace StudyDal
{
    public class SoundDal
    {
        sqlHelp sqlDal = new sqlHelp();

        public int getSearchSoundCount(string SoundType, string SearchKey)
        {
            return (int)sqlDal.sqlOneDr("select count(*) from tb_Sound where SoundType=@SoundType and SoundName like '%'+@SearchKey+'%'",
                new string[] { "@SoundType", "@SearchKey" },
                new string[] { SoundType, SearchKey });
        }

        public List<tb_Sound> selSearchSound(string SoundType, string SearchKey, string pageIndex, string pageSize)
        {
            tb_Sound sound = null;
            List<ArrayList> list = sqlDal.sqlProcDr("GETTUTORIALTABLEPAGE",
                new string[] { "@TABLENAME", "@TutorialID", "@SearchKey", "@pageIndex", "@pageSize" },
                new string[] { "Sound", SoundType, SearchKey, pageIndex, pageSize });
            List<tb_Sound> soundList = new List<tb_Sound>();
            foreach (ArrayList obj in list)
            {
                sound = new tb_Sound();
                sound.SoundID = (int)obj[0];
                sound.SoundName = obj[1].ToString();
                sound.FBDate = (DateTime)obj[2];
                sound.Name = obj[3].ToString();
                soundList.Add(sound);
            }
            return soundList;
        }

        public DataSet selMySound(string Name) 
        {
            string sel = "select ROW_NUMBER() over(order by SoundID) RowID,SoundID,SoundName,TypeName,FBDate from tb_Sound,tb_Type where SoundType=TypeID and convert(varchar,Name)=@Name";
            return sqlDal.sqlDs(sel,
                new string[] { "@Name" },
                new string[] { Name });  
        }

        public List<tb_Sound> selSound()
        {
            tb_Sound sound = null;
            string sel = "select SoundID,SoundName,FBDate from tb_Sound";
            List<ArrayList> list = sqlDal.sqlDr(sel, null, null);
            List<tb_Sound> soundList = new List<tb_Sound>();
            foreach (ArrayList obj in list)
            {
                sound = new tb_Sound();
                sound.SoundID = (int)obj[0];
                sound.SoundName = obj[1].ToString();
                sound.FBDate = (DateTime)obj[2];
                soundList.Add(sound);
            }
            return soundList;
        }

        public DataSet selTopSound()
        {
            tb_Sound sound = new tb_Sound();
            string sel = "select top 5 SoundID,SoundName,TypeName,ClickSum from tb_Sound,tb_Type where SoundType=TypeID order by ClickSum desc";
            return sqlDal.sqlDs(sel, null, null);
        }

        public DataSet selNewSound()
        {
            tb_Sound sound = new tb_Sound();
            string sel = "select top 10 SoundID,SoundName,TypeName,FBDate from tb_Sound,tb_Type where SoundType=TypeID order by FBDate desc";
            return sqlDal.sqlDs(sel, null, null);
        }

        public int AddClickNum(int SoundID)
        {
            return sqlDal.sqlUpdate("update tb_Sound set ClickSum+=1 where SoundID=@SoundID",
                new string[] { "@SoundID" },
                new string[] { SoundID.ToString() });
        }

        public tb_Sound selOneSound(int SoundID)
        {
            tb_Sound sound = new tb_Sound();
            string sel = "select SoundID,SoundName,FBDate,ClickSum,Name,SoundUrl,SoundContent from tb_Sound where SoundID=@SoundID";
            ArrayList list = sqlDal.sqlOnesDr(sel,
                new string[] { "@SoundID" },
                new string[] { SoundID.ToString() });
            sound.SoundID = (int)list[0];
            sound.SoundName = list[1].ToString();
            sound.FBDate = (DateTime)list[2];
            sound.ClickSum = (int)list[3];
            sound.Name = list[4].ToString();
            sound.SoundUrl = list[5].ToString();
            sound.SoundContent = list[6].ToString();
            return sound;
        }

        public int addSound(tb_Sound sound)
        {
            return sqlDal.sqlUpdate("insert into tb_Sound(SoundType,SoundName,SoundUrl,Name,SoundContent) values(@SoundType,@SoundName,@SoundUrl,@Name,@SoundContent)",
                new string[] { "@SoundType", "@SoundName", "@SoundUrl", "@Name","@SoundContent" },
                new string[] { sound.SoundType.ToString(), sound.SoundName, sound.SoundUrl, sound.Name,sound.SoundContent });

        }

        public int delSound(int soundID)
        {
            return sqlDal.sqlUpdate("delete tb_Sound where SoundID=@SoundID",
                new string[] { "@SoundID" },
                new string[] { soundID.ToString() });
        }

        public string selSoundUrl(int soundID)
        {
            return sqlDal.sqlOneDr("select SoundUrl from tb_Sound where SoundID=@SoundID",
                new string[] { "@VideoID" },
                new string[] { soundID.ToString() }).ToString();
        }
    }
}
