<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNewBook.aspx.cs" Inherits="AddNewBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server" Height="478px" Width="1286px">
            <table>
               
                <tr>
                    <td>
                        <asp:Label ID="Book_Name" runat="server" Text="Book_Name"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtBookName" runat="server" OnTextChanged="BookName_TextChanged"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Book_Current_Amount" runat="server" Text="Book_Current_Amount"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtBook_CurrentAmount" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Book_Base_Amount" runat="server" Text="Book_Base_Amount"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtBook_BaseAmount" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Department_Id" runat="server" Text="Department_Id"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtDepartmentId" runat="server"  requared="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Book_Image" runat="server" Text="Book_Image"></asp:Label></td>
                    <td>
                        <asp:FileUpload ID="fileupload" runat="server" />

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Department_Name" runat="server" Text="Department_Name"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtDepartmentName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Author_Name" runat="server" Text="Author_Name"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtAuthorName" runat="server"></asp:TextBox></td>
                </tr>
                


            </table>

            <asp:Button ID="Btn_addnew" runat="server" Text="Save" OnClick="Btn_addnew_Click"/>
            <asp:Button ID="btn_back" runat="server" Text="Back" onclick="btn_back_Click" Visible="false"/>

        </asp:Panel>
    </form>
</body>
</html>
