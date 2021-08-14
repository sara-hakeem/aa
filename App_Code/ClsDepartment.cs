using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

/// <summary>
/// Summary description for ClsDepartment
/// </summary>
public class ClsDepartment
{
	public ClsDepartment()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static DataSet SelectDepartment(int Dep_id=0,string Dep_Name=null)
    {
        string com = "Sproc_SelectDepartment";
        SqlParameter p1 = new SqlParameter("@Dep_id", Dep_id);
        SqlParameter p2 = new SqlParameter("@Dep_name", Dep_Name);
        DataSet ds = DataAccessLayer.RunSelect(com,p1,p2);
        return ds;
             
    }
}