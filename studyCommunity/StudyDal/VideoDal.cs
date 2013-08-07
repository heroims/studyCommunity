using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudyModel;
using System.Collections;
using System.Data;

namespace StudyDal
{
    public class VideoDal
    {
        sqlHelp sqlDal = new sqlHelp();

        public int getSearchVideoCount(string VideoType, string SearchKey)
        {
            return (int)sqlDal.sqlOneDr("select count(*) from tb_Video where VideoType=@VideoType and VideoName like '%'+@SearchKey+'%'",
                new string[] { "@VideoType", "@SearchKey" },
                new string[] { VideoType, SearchKey });
        }

        public List<tb_Video> selSearchVideo(string VideoType, string SearchKey, string pageIndex, string pageSize)
        {
            tb_Video video = null;
            List<ArrayList> list = sqlDal.sqlProcDr("GETTUTORIALTABLEPAGE",
                new string[] { "@TABLENAME", "@TutorialID", "@SearchKey", "@pageIndex", "@pageSize" },
                new string[] { "Video", VideoType, SearchKey, pageIndex, pageSize });
            List<tb_Video> videoList = new List<tb_Video>();
            foreach (ArrayList obj in list)
            {
                video = new tb_Video();
                video.VideoID = (int)obj[0];
                video.VideoName = obj[1].ToString();
                video.FBDate = (DateTime)obj[2];
                video.Name = obj[3].ToString();
                videoList.Add(video);
            }
            return videoList;
        }

        public DataSet selMyVideo(string Name)
        {
            string sel = "select ROW_NUMBER() over(order by VideoID) RowID,VideoID,VideoName,TypeName,FBDate from tb_Video,tb_Type where VideoType=TypeID and convert(varchar,Name)=@Name";
            return sqlDal.sqlDs(sel,
                new string[] { "@Name" },
                new string[] { Name });
        }

        public List<tb_Video> selVideo()
        {
            tb_Video video = null;
            string sel = "select VideoID,VideoName,FBDate from tb_Video";
            List<ArrayList> list = sqlDal.sqlDr(sel, null, null);
            List<tb_Video> videoList = new List<tb_Video>();
            foreach (ArrayList obj in list)
            {
                video = new tb_Video();
                video.VideoID = (int)obj[0];
                video.VideoName = obj[1].ToString();
                video.FBDate = (DateTime)obj[2];
                videoList.Add(video);
            }
            return videoList;
        }

        public DataSet selTopVideo() 
        {
            tb_Video video = new tb_Video();
            string sel = "select top 5 VideoID,VideoName,TypeName,ClickSum from tb_Video,tb_Type where VideoType=TypeID order by ClickSum desc";
            return sqlDal.sqlDs(sel, null, null);
        }

        public DataSet selNewVideo()
        {
            tb_Video video = new tb_Video();
            string sel = "select top 10 VideoID,VideoName,TypeName,FBDate from tb_Video,tb_Type where VideoType=TypeID order by FBDate desc";
            return sqlDal.sqlDs(sel, null, null);
        }

        public int AddClickNum(int VideoID)
        {
            return sqlDal.sqlUpdate("update tb_Video set ClickSum+=1 where VideoID=@VideoID",
                new string[] { "@VideoID" },
                new string[] { VideoID.ToString() });
        }

        public tb_Video selOneVideo(int VideoID)
        {
            tb_Video video = new tb_Video();
            string sel = "select VideoID,VideoName,FBDate,ClickSum,Name,VideoUrl,VideoContent from tb_Video where VideoID=@VideoID";
            ArrayList list = sqlDal.sqlOnesDr(sel,
                new string[] { "@VideoID" },
                new string[] { VideoID.ToString() });
            video.VideoID = (int)list[0];
            video.VideoName = list[1].ToString();
            video.FBDate = (DateTime)list[2];
            video.ClickSum = (int)list[3];
            video.Name = list[4].ToString();
            video.VideoUrl = list[5].ToString();
            video.VideoContent = list[6].ToString();
            return video;
        }

        public int addVideo(tb_Video video)
        {
            return sqlDal.sqlUpdate("insert into tb_Video(VideoType,VideoName,VideoUrl,Name,VideoContent) values(@VideoType,@VideoName,@VideoUrl,@Name,@VideoContent)",
                new string[] { "@VideoType", "@VideoName", "@VideoUrl", "@Name", "@VideoContent" },
                new string[] { video.VideoType.ToString(), video.VideoName, video.VideoUrl, video.Name,video.VideoContent });

        }

        public int delVideo(int videoID)
        {
            return sqlDal.sqlUpdate("delete tb_Video where VideoID=@VideoID",
                new string[] { "@VideoID" },
                new string[] { videoID.ToString() });
        }

        public string selVideoUrl(int videoID)
        {
            return sqlDal.sqlOneDr("select VideoUrl from tb_Video where VideoID=@VideoID",
                new string[] { "@VideoID" },
                new string[] { videoID.ToString() }).ToString();
        }
    }
}
