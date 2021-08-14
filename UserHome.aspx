<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserHome.aspx.cs" Inherits="UserHome" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script>

        function Details(Book_Id) {

            window.location = "Book_Detail.aspx?id=" + Book_Id;
        }






        function Borrow(Book_Id) {
            alert("Are you need to borrow this book ?");
            $.ajax({
                url: '<%=ResolveUrl("~/WebService.asmx/Borrow_Item")%>',
                data: "{'Book_Id':'" + Book_Id + "'}",
                dataType: "json",
                type: "post",
                contentType: "application/json;charset=utf-8",
                success: function (data) {
                    alert(data.d)
                    window.location = "UserHome.aspx";
                },
                error: function (response) { },
                failure: function (response) { }
            });
        }
        function back(Book_Id) {
            alert("Are you need to back this book ?");
            $.ajax({
                url: '<%=ResolveUrl("~/WebService.asmx/Back_Book")%>',
                data: "{'Book_Id':'" + Book_Id + "'}",
                dataType: "json",
                type: "post",
                contentType: "application/json;charset=utf-8",
                success: function (data) {
                    alert(data.d)
                    window.location = "UserHome.aspx";
                },
                error: function (response) { },
                failure: function (response) { }
            });
        }
    </script>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Panel ID="Panel1" runat="server" Height="439px" Width="1322px">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="الاقسام"></asp:Label></td>
                    <td>
                        <telerik:RadComboBox ID="ChooseDepartment" runat="server" EmptyMessage="اختر القسم " AutoPostBack="true">
                        </telerik:RadComboBox>
                    </td>
                </tr>
            </table>

            <telerik:RadGrid RenderMode="Lightweight" ID="BOOKRadGrid" runat="server" AutoGenerateColumns="False" GroupPanelPosition="Top" Height="121px">

                <MasterTableView TableLayout="Auto">

                    <Columns>
                        <telerik:GridBoundColumn DataField="Book_Name" HeaderText="Book_Name"
                            SortExpression="Book_Name" UniqueName="Book_Name">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="Author_Name" HeaderText="Author_Name"
                            SortExpression="Author_Name" UniqueName="Author_Name">
                        </telerik:GridBoundColumn>
                        <telerik:GridTemplateColumn DataField="Book_Details" HeaderText="Book_Details"
                            SortExpression="Book_Details" UniqueName="Book_Details">
                            <ItemTemplate>
                                <a onclick='<%#"Details(" + Eval("Book_Id") + ");" %>' class='icon pencil icon-blue icon-size2'>Details</a>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>


                        <telerik:GridTemplateColumn DataField="Borrow_Book" HeaderText="Borrow_Book"
                            SortExpression="ProductID" UniqueName="ProductID">
                            <ItemTemplate>
                                <a onclick='<%#"Borrow(" + Eval("Book_Id") + ");" %>' class='icon pencil icon-blue icon-size2'>Borrow</a>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn DataField="borrow_Back" HeaderText="borrow_Back"
                            SortExpression="borrow_Back" UniqueName="borrow_Back">
                            <ItemTemplate>
                                <a onclick='<%#"back(" + Eval("Book_Id") + ");" %>' class='icon pencil icon-blue icon-size2'>borrow_Back</a>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>



                    </Columns>

                </MasterTableView>
                <FilterMenu RenderMode="Lightweight">
                </FilterMenu>
                <HeaderContextMenu RenderMode="Lightweight">
                </HeaderContextMenu>
            </telerik:RadGrid>
        </asp:Panel>
    </form>
</body>
</html>
