<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminHome.aspx.cs" Inherits="AdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="277px" Width="1263px">
            <asp:Button ID="Btn_Borrow" runat="server" Text="الاستعارات" Height="34px" Width="146px" />
            <asp:Button ID="btn_Back" runat="server" Height="34px" Text="المرتجع" Width="126px" />
            <asp:Button ID="btn_users" runat="server" Height="37px" Text="المستخدمين " Width="120px" />
            <asp:Button ID="btn_books" runat="server" Height="34px" OnClick="btn_books_Click" Text="الكتب" Width="144px" />
        </asp:Panel>
    </form>
</body>
</html>
