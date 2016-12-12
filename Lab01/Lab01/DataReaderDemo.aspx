<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataReaderDemo.aspx.cs" Inherits="Lab01.DataReaderDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            <asp:GridView 
                ID="GridView1" 
                DataKeyNames="id" 
                runat="server" 
                DataSourceID="ObjectDataSource1">
            </asp:GridView>
            <asp:ObjectDataSource 
                ID="ObjectDataSource1" 
                runat="server" 
                SelectMethod="getMovies" 
                TypeName="Lab01.MovieManager">
            </asp:ObjectDataSource>
        </p>
    </div>        
    </form>
</body>
</html>
