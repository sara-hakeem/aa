using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


public partial class Borrow : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet  ds=ClsBooks.SelecBook();
        Grid_Details.DataSource = ds;
        Grid_Details.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}