using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShowReport : System.Web.UI.Page
{
    ReportDocument rprt = new ReportDocument(); 
    protected void Page_Load(object sender, EventArgs e)
    {
        rprt.Load(Server.MapPath("~/Select_Book.rpt"));

        string str = "Sproc_SelectBook";
        using (SqlConnection con = new SqlConnection(@"data source=DESKTOP-OSUB2CK;initial catalog=Test;integrated security=true"))
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = str;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
         
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand.CommandTimeout = 0;
            DataSet ds = new DataSet();
            da.Fill(ds, "Report_DataSet");
            rprt.SetDataSource(ds);
            CrystalReportViewer1.ReportSource = rprt;
            CrystalReportViewer1.RefreshReport();

        }

    }
}