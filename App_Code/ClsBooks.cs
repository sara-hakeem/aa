using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ClsBooks
/// </summary>
public class ClsBooks
{
    public ClsBooks()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static DataSet SelecBook(int bookid = 0, string Book_name = null)
    {
        string cmd = "Sproc_SelectBook";
        SqlParameter p1 = new SqlParameter("@Book_id", bookid);
        SqlParameter p2 = new SqlParameter("@Book_name", Book_name);
        DataSet ds = DataAccessLayer.RunSelect(cmd, p1, p2);
        return ds;
    }
    public static DataSet Select_Book_By_Department(string DepartmentName)
    {
        string cmd = "Sproc_SelectBook_By_Department";
        SqlParameter p1 = new SqlParameter("@Dep_Name", DepartmentName);

        DataSet ds = DataAccessLayer.RunSelect(cmd, p1);
        return ds;
    }
    public static void insert_Book_borrow(int User_Id, int Book_Id)
    {
        DateTime date_of_bookborrow = DateTime.Now;
        string cmd = "Sproc_BOOK_borrow";
        SqlParameter p1 = new SqlParameter("@USER_ID", User_Id);
        SqlParameter p2 = new SqlParameter("@Book_id ", Book_Id);
        SqlParameter p3 = new SqlParameter("@date_of_borrow", date_of_bookborrow);
        DataAccessLayer.RunDml(cmd, p1, p2, p3);

    }

    public static void insert_Book_back(int User_Id, int Book_Id)
    {
        DateTime date_of_bookborrow = DateTime.Now;
        string cmd = "Sproc_Back_Book";
        SqlParameter p1 = new SqlParameter("@USER_ID", User_Id);
        SqlParameter p2 = new SqlParameter("@Book_id ", Book_Id);
        SqlParameter p3 = new SqlParameter("@date_of_borrow", date_of_bookborrow);
        DataAccessLayer.RunDml(cmd, p1, p2, p3);

    }
    public static void insertNew_Book(string Book_Name, int Book_Book_Current_Amount, int Book_Base_Amount, int Department_Id, string Book_Image, string Department_Name, string Author_Name)
    {

        string cmd = "Sproc_IsertNewbOOK";
        SqlParameter p1 = new SqlParameter("@Book_Name", Book_Name);
        SqlParameter p2 = new SqlParameter("@Book_Book_Current_Amount ", Book_Book_Current_Amount);
        SqlParameter p3 = new SqlParameter("@Book_Base_Amount", Book_Base_Amount);
        SqlParameter p4 = new SqlParameter("@Department_Id", Department_Id);
        SqlParameter p5 = new SqlParameter("@Book_Image", Book_Image);
        SqlParameter p6 = new SqlParameter("@Department_Name", Department_Name);
        SqlParameter p7 = new SqlParameter("@Author_Name", Author_Name);
        DataAccessLayer.RunDml(cmd, p1, p2, p3, p4, p5, p6, p7);

    }
    public static void Delete_Book(int Book_Id)
    {
        string cmd = "Sproc_Delete_Book";
        SqlParameter p1 = new SqlParameter("@Book_Id", Book_Id);

        DataAccessLayer.RunDml(cmd, p1);

    }
    public static void Update_Book(int book_id, string Book_Name, int Book_Book_Current_Amount, int Book_Base_Amount, int Department_Id, string Book_Image, string Department_Name, string Author_Name)
    {
        string cmd = "Sproc_Update_Book";
        SqlParameter p0 = new SqlParameter("@Book_Id", book_id);
        SqlParameter p1 = new SqlParameter("@Book_Name", Book_Name);
        SqlParameter p2 = new SqlParameter("@Book_Book_Current_Amount ", Book_Book_Current_Amount);
        SqlParameter p3 = new SqlParameter("@Book_Base_Amount", Book_Base_Amount);
        SqlParameter p4 = new SqlParameter("@Department_Id", Department_Id);
        SqlParameter p5 = new SqlParameter("@Book_Image", Book_Image);
        SqlParameter p6 = new SqlParameter("@Department_Name", Department_Name);
        SqlParameter p7 = new SqlParameter("@Author_Name", Author_Name);
        DataAccessLayer.RunDml(cmd, p0, p1, p2, p3, p4, p5, p6, p7);

    }


}