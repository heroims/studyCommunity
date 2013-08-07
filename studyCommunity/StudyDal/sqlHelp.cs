using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace StudyDal
{
    class sqlHelp
    {
        SqlConnection cn;
        SqlCommand cmd;

        public List<ArrayList> sqlDr(string sqlSel, string[] str1, string[] str2)
        {
            using (cn = new SqlConnection(Comm.getConStr()))
            {
                List<ArrayList> list = new List<ArrayList>();
                ArrayList objList = null;
                cmd = new SqlCommand(sqlSel, cn);
                if (str1 != null && str2 != null)
                {
                    for (int i = 0; i < str1.Length; i++)
                    {
                        cmd.Parameters.Add(new SqlParameter(str1[i], str2[i]));
                    }
                }
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    objList = new ArrayList();
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        objList.Add(dr[i]);
                    }
                    list.Add(objList);
                }
                dr.Close();
                return list;
            }
        }

        public DataSet sqlDs(string sqlSel,string[] str1,string[] str2)
        {
            cn = new SqlConnection(Comm.getConStr());
            cmd = new SqlCommand(sqlSel, cn);
            if (str1 != null && str2 != null)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    cmd.Parameters.Add(new SqlParameter(str1[i], str2[i]));
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds=new DataSet();
            da.Fill(ds);
            return ds; 
        }

        public int sqlUpdate(string sqlSel, string[] str1, string[] str2)
        {
            using (cn = new SqlConnection(Comm.getConStr()))
            {
                cmd = new SqlCommand(sqlSel, cn);
                for (int i = 0; i < str1.Length; i++)
                {
                    cmd.Parameters.Add(new SqlParameter(str1[i], str2[i]));
                }
                try
                {
                    cn.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }  
        }

        public DataSet sqlProcDs(string procName, string[] str1, string[] str2)
        {
            cn = new SqlConnection(Comm.getConStr());
            cmd = new SqlCommand(procName, cn);
            cmd.CommandType=CommandType.StoredProcedure;
            if (str1!=null&&str2!=null)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    cmd.Parameters.Add(new SqlParameter(str1[i],str2[i]));
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds; 
        }

        public List<ArrayList> sqlProcDr(string procName, string[] str1, string[] str2)
        {
            using (cn = new SqlConnection(Comm.getConStr()))
            {
                List<ArrayList> list = new List<ArrayList>();
                ArrayList objList = null;
                cmd = new SqlCommand(procName, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (str1 != null && str2 != null)
                {
                    for (int i = 0; i < str1.Length; i++)
                    {
                        cmd.Parameters.Add(new SqlParameter(str1[i], str2[i]));
                    }
                }
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    objList = new ArrayList();
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        objList.Add(dr[i]);
                    }
                    list.Add(objList);
                }
                dr.Close();
                return list;
            }
        }

        public object sqlOneDr(string sqlSel, string[] str1, string[] str2)
        {
            using (cn = new SqlConnection(Comm.getConStr()))
            {
                cmd = new SqlCommand(sqlSel, cn);
                if (str1 != null && str2 != null)
                {
                    for (int i = 0; i < str1.Length; i++)
                    {
                        cmd.Parameters.Add(new SqlParameter(str1[i], str2[i]));
                    }
                }
                cn.Open();
                return cmd.ExecuteScalar();
            }
        }

        public ArrayList sqlOnesDr(string sqlSel, string[] str1, string[] str2)
        {
            using (cn = new SqlConnection(Comm.getConStr()))
            {
                cmd = new SqlCommand(sqlSel, cn);
                if (str1 != null && str2 != null)
                {
                    for (int i = 0; i < str1.Length; i++)
                    {
                        cmd.Parameters.Add(new SqlParameter(str1[i], str2[i]));
                    }
                }
                ArrayList objList = null;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    objList = new ArrayList();
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        objList.Add(dr[i]);
                    }
                }
                dr.Close();
                return objList;
            }
        }
    }
}
