using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;


/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
    [WebMethod]
    public string Borrow_Item(int Book_Id)
    {
        ClsBooks.insert_Book_borrow( 1, Book_Id);

        return "success";
    }
        [WebMethod]
    public string Back_Book(int Book_Id)
    {
        ClsBooks.insert_Book_back( 1, Book_Id);

        return "success";
    }
      [WebMethod]
 public string Delete_Item(int Row_Id)
      {
          ClsBooks.Delete_Book(Row_Id);
          return ("success delete");
     }
    

}
