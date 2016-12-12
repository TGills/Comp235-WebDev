<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReviewExercise2.aspx.cs" Inherits="Lab01.ReviewExercise2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact Manager</title>
</head>    
<body>
    <form id="form1" runat="server">
    <div>  
        Contact Manager</div>
        <table style="width:100%;">
            <tr><td class="auto-style3">First Name: </td><td>
                <asp:TextBox ID="txtFirstName" runat="server" style="margin-left: 0px"></asp:TextBox></td></tr>
            <tr><td class="auto-style3">Last Name: </td><td>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td></tr>
            <tr><td class="auto-style3">Phone Number: </td><td>
                <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox></td></tr>
            <tr><td class="auto-style3">
                <asp:LinkButton ID="lbPrevious" runat="server" OnClick="lbPrevious_Click">Previous</asp:LinkButton> </td>
                <td class="auto-style3">
                    <asp:LinkButton ID="lbNext" runat="server" OnClick="lbNext_Click">Next</asp:LinkButton> </td></tr>
            <tr><td class="auto-style3" colspan="2">
                <asp:Button ID="btnSave" runat="server" Text="Save Changes" OnClick="btnSave_Click" /></td></tr>
            </table>
    </form>
</body>
    
</html>