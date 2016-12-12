<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListOMovies.aspx.cs" Inherits="Lab01.ListOMovies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>   
        <asp:GridView 
            ID="GridView1" 
            runat="server" 
            AutoGenerateColumns="False"              
            DataSourceID="ObjectDataSource1">
        </asp:GridView>
        <asp:ObjectDataSource 
            ID="ObjectDataSource1"
            runat="server"
            DeleteMethod="deleteMovie" 
            SelectMethod="getMoviesBycatID" 
            TypeName="MovieManager" 
            UpdateMethod="updateMovie">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="catID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="id" Type="Int32" />
                <asp:Parameter Name="title" Type="String" />
                <asp:Parameter Name="director" Type="String" />
                <asp:Parameter Name="description" Type="String" />
            </UpdateParameters>
        </asp:ObjectDataSource>    
    </div>
        <asp:DropDownList
            ID="DropDownList1" 
            runat="server"
            DataSourceID="ObjectDataSource1"             
            DataTextField="Id"
            DataValueField="Id"
            DataKeyName="Id"
            AutoPostBack="True">
        </asp:DropDownList>
    </form>
</body>
</html>