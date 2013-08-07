using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudyModel;
using StudyDal;

namespace StudyBll
{
    public class TypeBll
    {
        TypeDal td = new TypeDal();

        public List<tb_Type> selType()
        {
            return td.selType();
        }
    }
}
