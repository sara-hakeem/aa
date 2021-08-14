using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddNewBook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            int x = int.Parse(Session["role"].ToString());

            if (x == 0)
            {
                btn_back.Visible = false;
            }
            else
            {
                btn_back.Visible = true;
            }
        }
        catch
        {
            Response.Redirect("LogIn.aspx");

        }

        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                DataSet ds = ClsBooks.SelecBook(int.Parse(Request.QueryString["id"].ToString()));
                DataTable dt = ds.Tables[0];
                txtBookName.Text = dt.Rows[0]["Book_Name"].ToString();
                txtBook_CurrentAmount.Text = dt.Rows[0]["Book_Current_Amount"].ToString();
                txtBook_BaseAmount.Text = dt.Rows[0]["Book_Base_Amount"].ToString();
                txtDepartmentId.Text = dt.Rows[0]["Department_Id"].ToString();
                //fileupload.NamingContainer vv= dt.Rows[0]["Book_Image"].ToString();
                txtDepartmentName.Text = dt.Rows[0]["Department_Name"].ToString();
                txtAuthorName.Text = dt.Rows[0]["Author_Name"].ToString();
            }

        }
    }
    protected void Btn_addnew_Click(object sender, EventArgs e)
    {

        string p = HostingEnvironment.MapPath("~/");

        SaveStreamAsFile(p + "\\Images", fileupload.PostedFile.InputStream, "aaa"+fileupload.PostedFile.FileName);

        string path = "\\Images" + fileupload.PostedFile.FileName;//using in procedure only to save link of photo in db




        int book_id;
        string Name = txtBookName.Text;
        int current_AMount = int.Parse(txtBook_CurrentAmount.Text);
        int Base_Amount = int.Parse(txtBook_BaseAmount.Text);
        int department_Id = int.Parse(txtDepartmentId.Text);
        String Image = path; 
        string dep_Name = txtDepartmentName.Text;
        string authorname = txtAuthorName.Text;
        if (Request.QueryString["id"] != null)
        {
            book_id = (int.Parse(Request.QueryString["id"].ToString()));
            ClsBooks.Update_Book(book_id, Name, current_AMount, Base_Amount, department_Id, Image, dep_Name, authorname);
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Update is successfull')", true);
            Response.Redirect("Books.aspx");

        }
        else
        {
            ClsBooks.insertNew_Book(Name, current_AMount, Base_Amount, department_Id, Image, dep_Name, authorname);
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Insert is successfull')", true);
            txtBookName.Text = "";
            txtBook_CurrentAmount.Text = "";
            txtBook_BaseAmount.Text = "";
            txtDepartmentId.Text = "";
            //fileupload= null;
            txtDepartmentName.Text = "";
            txtAuthorName.Text = "";
            Response.Redirect("AddNewBook.aspx");
        }
    }

    public static void SaveStreamAsFile(string filePath, Stream inputStream, string fileName)
    {
        DirectoryInfo info = new DirectoryInfo(filePath);
        if (!info.Exists)
        {
            info.Create();
        }

        string filepath = Path.Combine(filePath, fileName);
        using (FileStream outputFileStream = new FileStream(filepath, FileMode.Create))
        {

            inputStream.CopyTo(outputFileStream);
        }
    }

    protected void BookName_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btn_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Books.aspx");
    }
}