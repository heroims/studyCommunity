using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using StudyModel;

namespace StudyDal
{
    public class TypeDal
    {
        sqlHelp sqlDal = new sqlHelp();
        public List<tb_Type> selType()
        {
            tb_Type type = null;
            string sel = "select TypeID,TypeName from tb_Type";
            List<ArrayList> list = sqlDal.sqlDr(sel, null, null);
            List<tb_Type> typeList = new List<tb_Type>();
            foreach (ArrayList obj in list)
            {
                type = new tb_Type();
                type.TypeID = (int)obj[0];
                type.TypeName = obj[1].ToString();
                typeList.Add(type);
            }
            return typeList;
        }
    }
}
