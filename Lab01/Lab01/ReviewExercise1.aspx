<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReviewExercise1.aspx.cs" Inherits="Lab01.ReviewExercise1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Shipping Calculator</title>
    <style type="text/css">
        .auto-style3 {
            width: 137px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width:100%;">
            <tr><td class="auto-style3">Quantity: </td><td>
                <asp:TextBox ID="txtQuan" runat="server" style="margin-left: 0px"></asp:TextBox></td></tr>
            <tr><td class="auto-style3">Distance: </td><td>
                <asp:TextBox ID="txtDist" runat="server"></asp:TextBox></td></tr>
            <tr><td class="auto-style3">Shipping Type:</td><td>
                <asp:DropDownList ID="ddlShipType" runat="server">
                    <asp:ListItem Value="0">Ground</asp:ListItem>
                    <asp:ListItem Value=".05">Priority Ground</asp:ListItem>
                    <asp:ListItem Value=".10">Air</asp:ListItem>
                </asp:DropDownList>
                </td></tr>
            <tr><td class="auto-style3">Shipping Fee:</td><td>
                <asp:TextBox ID="txtShipFee" runat="server" BackColor="White" BorderColor="Blue" BorderStyle="Solid"></asp:TextBox></td></tr>
            <tr><td class="auto-style3">Shipping Cost: </td><td>
                <asp:TextBox ID="txtShipCost" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid"></asp:TextBox></td></tr>
            <tr><td colspan="2">
                <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="Total" /></td></tr>
            </table>
    
    </div>
    </form>
</body>    
</html>
<script>
    
</script>
