﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
namespace StudyDal
{
    public class Comm
    {
        public static string getConStr()
        {
            return ConfigurationManager.ConnectionStrings["conStr"].ToString();
        }
    }
}
