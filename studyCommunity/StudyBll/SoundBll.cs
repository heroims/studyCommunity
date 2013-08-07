using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudyDal;
using StudyModel;
using System.Data;

namespace StudyBll
{
    public class SoundBll
    {
        SoundDal sd = new SoundDal();

        public int getSearchSoundCount(string SoundType, string SearchKey)
        {
            return sd.getSearchSoundCount(SoundType, SearchKey);
        }
        public List<tb_Sound> selSearchSound(string SoundType, string SearchKey, int pageIndex, int pageSize)
        {
            return sd.selSearchSound(SoundType, SearchKey, pageIndex.ToString(), pageSize.ToString());
        }

        public DataSet selMySound(string Name)
        {
            return sd.selMySound(Name);
        }

        public List<tb_Sound> selSound()
        {
            return sd.selSound();
        }

        public DataSet selTopSound()
        {
            return sd.selTopSound();
        }

        public DataSet selNewSound() 
        {
            return sd.selNewSound();
        }

        public int AddClickNum(int SoundID)
        {
            return sd.AddClickNum(SoundID);
        }

        public tb_Sound selOneSound(int SoundID)
        {
            return sd.selOneSound(SoundID);
        }

        public int addSound(tb_Sound sound)
        {
            return sd.addSound(sound);
        }

        public int delSound(int soundID)
        {
            return sd.delSound(soundID);
        }

        public string selSoundUrl(int soundID)
        {
            return sd.selSoundUrl(soundID);
        }
    }
}
