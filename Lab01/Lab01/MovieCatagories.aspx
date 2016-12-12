<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieCatagories.aspx.cs" Inherits="Lab01.MovieCatagories" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList 
                ID="DropDownList1" 
                runat="server" 
                AutoPostBack="True" 
                DataSourceID="SqlDataSource1"
                DataTextField="Name" 
                DataValueField="Id">
            </asp:DropDownList>
        </div>        
    <div>
        <asp:SqlDataSource 
            ID="SqlDataSource1" 
            runat="server" 
            ConnectionString="<%$ ConnectionStrings:dbMovies1 %>" 
            SelectCommand="SELECT * FROM [Movies]">
        </asp:SqlDataSource>
        </div>
        </form>
        </body>
    </html>