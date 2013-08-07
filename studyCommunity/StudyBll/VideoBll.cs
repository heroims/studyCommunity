using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudyDal;
using StudyModel;
using System.Data;

namespace StudyBll
{
    public class VideoBll
    {
        VideoDal vd = new VideoDal();

        public int getSearchVideoCount(string VideoType, string SearchKey)
        {
            return vd.getSearchVideoCount(VideoType, SearchKey);
        }

        public List<tb_Video> selSearchVideo(string VideoType, string SearchKey, int pageIndex, int pageSize)
        {
            return vd.selSearchVideo(VideoType, SearchKey, pageIndex.ToString(), pageSize.ToString());
        }

        public DataSet selMyVideo(string Name)
        {
            return vd.selMyVideo(Name);
        }

        public List<tb_Video> selVideo()
        {
            return vd.selVideo();
        }

        public int AddClickNum(int VideoID)
        {
            return vd.AddClickNum(VideoID);
        }

        public tb_Video selOneVideo(int VideoID)
        {
            return vd.selOneVideo(VideoID);
        }

        public DataSet selTopVideo()
        {
            return vd.selTopVideo();
        }

        public DataSet selNewViedo()
        {
            return vd.selNewVideo();
        }

        public int addVideo(tb_Video video)
        {
            return vd.addVideo(video);
        }

        public int delVideo(int videoID)
        {
            return vd.delVideo(videoID);
        }

        public string selVideoUrl(int videoID) 
        {
            return vd.selVideoUrl(videoID);
        }
    }
}
