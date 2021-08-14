using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Book_Detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            int x = int.Parse(Session["role"].ToString());

            if (x == 0)
            {
                btnEDIT.Visible = false;
            }
            else
            {
                btnEDIT.Visible = true;
            }
        }
        catch
        {
            Response.Redirect("LogIn.aspx");

        }


        if (Request.QueryString["id"] != null)
        {
            string p = HostingEnvironment.MapPath("~/");
            DataSet ds = ClsBooks.SelecBook(int.Parse(Request.QueryString["id"].ToString()));
            DataTable dt = ds.Tables[0];
            name.Text = dt.Rows[0]["Book_Name"].ToString();
            Auther.Text = dt.Rows[0]["Author_Name"].ToString();
            book_image.ImageUrl = @"D:\2\DSC_4174.jpg";
        }

    }

    protected void btnEDIT_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddNewBook.aspx");
    }
}