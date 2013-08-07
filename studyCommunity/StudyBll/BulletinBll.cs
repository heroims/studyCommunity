using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudyDal;
using StudyModel;

namespace StudyBll
{
    public class BulletinBll
    {
        BulletinDal ibd = new BulletinDal();

        public int addBulletin(tb_Bulletin bull)
        {
            return ibd.addBulletin(bull);
        }

        public int delBulletin(int id)
        {
            return ibd.delBulletin(id);
        }

        public List<tb_Bulletin> selBulletin()
        {
            return ibd.selBulletin();
        }

        public List<tb_Bulletin> selNewBulletin()
        {
            return ibd.selNewBulletin();
        }

        public tb_Bulletin selOneBulletin(int id)
        {
            return ibd.selOneBulletin(id);
        }
    }
}
