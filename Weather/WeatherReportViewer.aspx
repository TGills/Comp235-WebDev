<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WeatherReportViewer.aspx.cs" Inherits="WeatherReportViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" GroupingText="Add a Report">
            <br />
            <table class="auto-style1">
                <tr>
                    <td>Lat</td>
                    <td>
                        <asp:TextBox ID="txtLat" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Lon</td>
                    <td>
                        <asp:TextBox ID="txtLon" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Facing</td>
                    <td>
                        <asp:TextBox ID="txtFacing" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <asp:LinkButton ID="btnSubmit" runat="server">Add</asp:LinkButton>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
