using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyModel
{
    public class tb_Sound
    {
        int _soundID;

        public int SoundID
        {
            get { return _soundID; }
            set { _soundID = value; }
        }
        int _soundType;

        public int SoundType
        {
            get { return _soundType; }
            set { _soundType = value; }
        }
        string _soundName;

        public string SoundName
        {
            get { return _soundName; }
            set { _soundName = value; }
        }
        string _soundUrl;

        public string SoundUrl
        {
            get { return _soundUrl; }
            set { _soundUrl = value; }
        }
        int _clickSum;

        public int ClickSum
        {
            get { return _clickSum; }
            set { _clickSum = value; }
        }
        string _soundContent;

        public string SoundContent
        {
            get { return _soundContent; }
            set { _soundContent = value; }
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
