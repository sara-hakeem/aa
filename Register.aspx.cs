using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        String TxtName = User_Name.Text;
        string txtPass = User_Pass.Text;
        string txtEmail = User_Email.Text;
        int TxtPhone = int.Parse(User_Phone.Text);
        string txtAddress = User_Address.Text;
        ClsUser.UserRegister(TxtName, txtPass, txtEmail, TxtPhone, txtAddress);
        Response.Redirect("Home.aspx");
    }
}