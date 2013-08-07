using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyModel
{
    public class tb_Video
    {
        int _videoID;

        public int VideoID
        {
            get { return _videoID; }
            set { _videoID = value; }
        }

        int _videoType;

        public int VideoType
        {
            get { return _videoType; }
            set { _videoType = value; }
        }
        string _videoName;

        public string VideoName
        {
            get { return _videoName; }
            set { _videoName = value; }
        }
        string _videoUrl;

        public string VideoUrl
        {
            get { return _videoUrl; }
            set { _videoUrl = value; }
        }
        int _clickSum;

        public int ClickSum
        {
            get { return _clickSum; }
            set { _clickSum = value; }
        }
        string _videoContent;

        public string VideoContent
        {
            get { return _videoContent; }
            set { _videoContent = value; }
        }
        DateTime _FBDate;

        public DateTime FBDate
        {
            get { return _FBDate; }
            set { _FBDate = value; }
        }
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
