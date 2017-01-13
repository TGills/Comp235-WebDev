<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ajax6.aspx.cs" Inherits="AJAX_Ajax6_Ajax6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                    <ProgressTemplate>
                        <img src="Progress.gif" />
                        Working on it
                    </ProgressTemplate>
                </asp:UpdateProgress>
                <asp:Button ID="btnCancel" runat="server" Text="Button" OnClick="btnCancel_Click" />
                <asp:Label ID="lblFortune" runat="server" Text="Label"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>










    </div>
    </form>
</body>
    <script type="text/javascript">

    var prm = Sys.WebForms.PageRequestManager.getInstance();
    prm.add_initializeRequest(prm_initializeRequest);
    
    function prm_initializeRequest(sender, args)
    {
        if (args.get_postBackElement().id == 'btnCancel')
        {
            prm.abortPostBack();
            alert("Fortune Aborted!");
        }
        else
        {
        
            $get('btnCancel').disabled = false;
        }
    }
    </script> 

</html>
