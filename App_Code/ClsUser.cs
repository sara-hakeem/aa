using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ClsLogInandRegister
/// </summary>
public class ClsUser
{
    public ClsUser()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static void UserRegister(string User_Name, string User_Pass, string User_Email, int User_Phone, string User_Address)
    {
        string cmd = "Sproc_Register";
        SqlParameter p1 = new SqlParameter("@User_Name", User_Name);
        SqlParameter p2 = new SqlParameter("@User_Pass", User_Pass);
        SqlParameter p3 = new SqlParameter("@User_Email", User_Email);
        SqlParameter p4 = new SqlParameter("@User_Phone", User_Phone);
        SqlParameter p5 = new SqlParameter("@User_Address", User_Address);
        DataAccessLayer.RunDml(cmd, p1, p2, p3, p4, p5);

    }
    public static int  UserLogIn(string User_Name, string User_Pass)
    {
        string cmd = "Sproc_LogIn";
        SqlParameter p1 = new SqlParameter("@User_Name", User_Name);
        SqlParameter p2 = new SqlParameter("@User_Pass", User_Pass);
        string data = DataAccessLayer.RunSelectCell(cmd, p1, p2);
        if (data == null)
        {
            return -1;
        }
        else
        {
            int role = int.Parse(data);
            return role;
        }
//return data;
        
    }

}
