<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Q1.aspx.cs" Inherits="Q1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource 
            ID="SqlDataSource1" 
            runat="server" 
            ConnectionString="<%$ ConnectionStrings:dbEmp1ConnectionString %>" 
            SelectCommand="SELECT * FROM [Jobs]">
        </asp:SqlDataSource>
    
        <asp:SqlDataSource 
            ID="SqlDataSource2" 
            runat="server" 
            ConnectionString="<%$ ConnectionStrings:dbEmp1ConnectionString %>" 
            SelectCommand="SELECT [EmployeeId], [LastName], [FirstName] FROM [Employees] WHERE ([JobCode] = @JobCode)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" DefaultValue="1000" Name="JobCode" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
        <asp:DropDownList 
            ID="DropDownList1" 
            runat="server" 
            AutoPostBack="True"
            DataSourceID="SqlDataSource1" 
            DataTextField="JobDescription" 
            DataValueField="JobCode" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:DataList 
            ID="DataList1" 
            runat="server" 
            DataKeyField="EmployeeId" 
            DataSourceID="SqlDataSource2">
            <ItemTemplate>
                EmployeeId:
                <asp:Label ID="EmployeeIdLabel" runat="server" Text='<%# Eval("EmployeeId") %>' />
                <br />
                LastName:
                <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
                <br />
                FirstName:
                <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
    </form>
</body>
</html>
