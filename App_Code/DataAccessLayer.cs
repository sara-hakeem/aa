using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for UserDataAccessLayer
/// </summary>
public class DataAccessLayer
{
    public DataAccessLayer()
    {

    }
    public static int RunDml(string str, params SqlParameter[] arr)
    {
        using (SqlConnection con = new SqlConnection(@"data source=DESKTOP-OSUB2CK;initial catalog=Test;integrated security=true"))
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = str;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            foreach (SqlParameter p in arr)
            {
                cmd.Parameters.Add(p);
            }
            con.Open();
            int affected = cmd.ExecuteNonQuery();
            return affected;

        }
    }

    public static DataSet RunSelect(string str, params SqlParameter[] arr)
    {
        using (SqlConnection con = new SqlConnection(@"data source=DESKTOP-OSUB2CK;initial catalog=Test;integrated security=true"))
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = str;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            foreach (SqlParameter p in arr)
            {
                cmd.Parameters.Add(p);
            }
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand.CommandTimeout = 0;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

    }

    public static string RunSelectCell(string str, params SqlParameter[] arr)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(@"data source=DESKTOP-OSUB2CK;initial catalog=Test;integrated security=true"))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = str;
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                foreach (SqlParameter p in arr)
                {
                    cmd.Parameters.Add(p);
                }
                con.Open();
                string x = cmd.ExecuteScalar().ToString();
                return x;
            }
        }
        catch 
        {
            return null;
        }

    }


}