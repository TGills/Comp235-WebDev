<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="Lab01.FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="fupUploader" runat="server" />
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        <asp:DataList ID="dlstImages" 
            runat="server" 
            RepeatColumns="3" 
            RepeatDirection="Horizontal">
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" style="width:200px" 
                    ImageUrl='<%# Eval("Name", "~/UploadedFiles/{0}") %>' /><br />
                    <%# Eval("Name") %><br />
                 <a href='FileUpload.aspx?id=<%# Eval("Name")%>'>Delete</a> 
            </ItemTemplate>
        </asp:DataList>

    </div>
    </form>
</body>
</html>
 