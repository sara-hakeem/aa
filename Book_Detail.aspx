<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Book_Detail.aspx.cs" Inherits="Book_Detail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 340px; width: 1364px">
    <form id="form1" runat="server">
    <div>
     <table>
       <tr> 
          <td> <asp:Label ID="Book_Name" runat="server" Text="Book_Name"></asp:Label> </td>
          <td> <asp:Label ID="name" runat="server" ></asp:Label></td>
       </tr>
           <tr>
         <td><asp:Label ID="Book_Auter" runat="server" Text="Auther_Name"></asp:Label> </td>
         <td> <asp:Label ID="Auther" runat="server" ></asp:Label> </td>
           </tr>
         
         </table>
        <asp:Image ID="book_image" runat="server" Height="291px" Width="285px" />
       <asp:LinkButton onclick="btnEDIT_Click" runat="server" ID="btnEDIT" Visible="false" Text="Edit"></asp:LinkButton>
       
    </div>
        
    </form>
</body>
</html>
