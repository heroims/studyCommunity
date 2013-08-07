using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudyModel;
using StudyDal;

namespace StudyBll
{
    public class SpeakBll
    {
        SpeakDal sd = new SpeakDal();

        public int addSpeak(tb_Speak speak)
        {
            return sd.addSpeak(speak);
        }

        public List<tb_Speak> selPagingSpeak(string TableName, int TutorialID, int pageIndex, int pageSize)
        {
            return sd.selPagingSpeak(TableName, TutorialID, pageIndex, pageSize);
        }

        public int getPageCount(string TutorialType, int TutorialID)
        {
            return sd.getPageCount(TutorialType, TutorialID);
        }

        public int delSpeak(int SpeakID)
        {
            return sd.delSpeak(SpeakID);
        }
    }
}
