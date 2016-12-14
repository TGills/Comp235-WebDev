<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FunWithRepeaters.aspx.cs" Inherits="Lab01.FunWithRepeaters" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Repeater ID="rptMovieCats" runat="server" DataSourceID="sqlMovies">
            <ItemTemplate>
               <a href ='FunWithRepeaters.aspx?id=<%#Eval("id")%>'> <%#Eval("Name") %></a> |
            </ItemTemplate>
        </asp:Repeater>
    
    </div>
        <asp:SqlDataSource ID="sqlMovies" runat="server" ConnectionString="<%$ ConnectionStrings:dbMovies1 %>" SelectCommand="SELECT [Id], [Name] FROM [MovieCategories]"></asp:SqlDataSource>
    </form>
</body>
</html>
