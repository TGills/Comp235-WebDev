<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Q3.aspx.cs" Inherits="Q3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1">
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getEmployeesNoList" TypeName="employeeManager"></asp:ObjectDataSource>
    
    </div>
        <asp:Panel ID="Panel1" runat="server">
            First Name:<br />
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            Last Name:<br />
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            Job Code:<br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="JobCode" DataValueField="JobCode">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbEmp1ConnectionString %>" SelectCommand="SELECT [JobCode] FROM [Jobs]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:Button ID="btnAddEmployee" runat="server" OnClick="btnAddEmployee_Click" Text="Add Employee" />
        </asp:Panel>
    </form>
</body>
</html>
