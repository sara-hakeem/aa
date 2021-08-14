using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class UserHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                DataSet ds_ = ClsBooks.SelecBook(int.Parse(Request.QueryString["id"].ToString()));
                DataTable dt = ds_.Tables[0];
                //txtName.Text = dt.Rows[0]["Item_name"].ToString();
                //txtCode.Text = dt.Rows[0]["Item_code"].ToString();
                //txtBaseAmount.Text = dt.Rows[0]["Item_Base_Ampunt"].ToString();
                //txtCurrentAmount.Text = dt.Rows[0]["Item_Current_Amount"].ToString();
                //txtPrice.Text = dt.Rows[0]["Item_Price"].ToString();
            }
        }
        /////////////////////
        DataSet ds = ClsBooks.SelecBook();
        BOOKRadGrid.DataSource = ds;
       BOOKRadGrid.DataBind();
        //////////////
        DataSet ds_dep = ClsDepartment.SelectDepartment();
        
        ChooseDepartment.DataSource = ds_dep.Tables[0];
        ChooseDepartment.DataTextField = "Department_Name";
        ChooseDepartment.DataValueField = "Department_Id";
        ChooseDepartment.DataBind();

        ChooseDepartment.SelectedIndexChanged += ChooseDepartment_SelectedIndexChanged;

    }

    void ChooseDepartment_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
    {
        DataSet dss = ClsBooks.Select_Book_By_Department(e.Text.Trim());
        BOOKRadGrid.DataSource = dss;
        BOOKRadGrid.DataBind();
    }
  
    protected void BOOKRadGrid_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        BOOKRadGrid.AutoGenerateColumns = false;

    }
    
   
}