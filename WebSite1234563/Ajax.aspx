<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ajax.aspx.cs" Inherits="Ajax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <div>
            Page Load Time: <asp:Label ID="lblLoadTime" runat="server" Text="Label"></asp:Label>
        </div><br />

        <div>
            <asp:UpdatePanel ID="udpPartialUpdateDemo" runat="server">
                <ContentTemplate>
                    Partial Page Load Time: <asp:Label ID="lblParitalLoadTime" runat="server" Text="Label"></asp:Label>
                    <br />
                    <asp:LinkButton ID="lnkPartialSubmit" runat="server" OnClick="lnkPartialSubmit_Click">Partial Submit</asp:LinkButton>
                    <br />

                </ContentTemplate>
             </asp:UpdatePanel>
            <asp:LinkButton ID="lnkSubmit" runat="server" OnClick="lnkSubmit_Click">Full Submit</asp:LinkButton>
        </div>
















    </div>
    </form>
</body>
</html>
