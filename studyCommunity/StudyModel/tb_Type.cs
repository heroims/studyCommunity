using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyModel
{
    public class tb_Type
    {
        int _typeID;

        public int TypeID
        {
            get { return _typeID; }
            set { _typeID = value; }
        }
        string _typeName;

        public string TypeName
        {
            get { return _typeName; }
            set { _typeName = value; }
        }
    }
}
