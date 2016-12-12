<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
            DataKeyNames="Id" 
            AutoGenerateEditButton="True" OnPreRender="Page_PreRender" OnRowCancelingEdit="Gridview1_RowCancelingEdit" OnRowDeleted="Page_PreRender" OnRowDeleting="Page_PreRender" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating1">
        </asp:GridView>

    
    </div>
    </form>
</body>
</html>
