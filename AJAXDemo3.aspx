<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AJAXDemo3.aspx.cs" Inherits="AJAXDemo3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbMovies1ConnectionString %>" SelectCommand="SELECT * FROM [MovieCategories]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:dbMovies1ConnectionString %>" SelectCommand="SELECT * FROM [Movies]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:dbMovies1ConnectionString %>" SelectCommand="SELECT * FROM [MovieCategories] WHERE ([Id] = @Id)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList2" DefaultValue="0" Name="Id" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>


        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id"></asp:DropDownList>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="Title" DataValueField="Id"></asp:DropDownList>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>


        <br />
        <br />


    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource3">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Position" HeaderText="Position" SortExpression="Position" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
