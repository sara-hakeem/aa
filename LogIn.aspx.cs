using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LogIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string txtName = User_Name.Text;
        string txtPass = User_Pass.Text;
        int data = ClsUser.UserLogIn(txtName, txtPass);
        Session["role"] = data;

        if (data == -1)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('can not find this user')", true);
        }
        else if (data == 1)
            Response.Redirect("AdminHome.aspx");
        else

            Response.Redirect("UserHome.aspx");

       
    }
       
    protected void User_Name_TextChanged(object sender, EventArgs e)
    {

    }
}