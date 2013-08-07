using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyModel
{
    public class tb_Speak
    {
        int _speakID;

        public int SpeakID
        {
            get { return _speakID; }
            set { _speakID = value; }
        }
        string _speakman;

        public string Speakman
        {
            get { return _speakman; }
            set { _speakman = value; }
        }
        string _tutorialType;

        public string TutorialType
        {
            get { return _tutorialType; }
            set { _tutorialType = value; }
        }
        int _tutorialID;

        public int TutorialID
        {
            get { return _tutorialID; }
            set { _tutorialID = value; }
        }
        string _speakContent;

        public string SpeakContent
        {
            get { return _speakContent; }
            set { _speakContent = value; }
        }
        DateTime _speakDate;

        public DateTime SpeakDate
        {
            get { return _speakDate; }
            set { _speakDate = value; }
        }
    }
}
