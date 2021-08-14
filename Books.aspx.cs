using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Books : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = ClsBooks.SelecBook();
        Book_Grid.DataSource = ds;
        Book_Grid.DataBind();
    }
    protected void Btn_AddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddNewBook.aspx");
    }
}