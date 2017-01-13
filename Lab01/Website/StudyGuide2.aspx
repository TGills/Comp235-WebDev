<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudyGuide2.aspx.cs" Inherits="StudyGuide2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Repeater 
            ID="Repeater1" 
            runat="server">
            <ItemTemplate>
               <a href ='StudyGuide2.aspx?Id=<%#Eval("id")%>'><%#Eval("Title") %></a> |
            </ItemTemplate>
        </asp:Repeater>
    
    
    </div>
        <asp:GridView 
            ID="GridView1" 
            runat="server">
        </asp:GridView>
    </form>
</body>
</html>
