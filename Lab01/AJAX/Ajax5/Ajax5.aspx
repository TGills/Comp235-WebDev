<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ajax5.aspx.cs" Inherits="AJAX_Ajax5_Ajax5" %>

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
                <br />
                <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                    <ProgressTemplate>
                        <img src="Progress.gif" />
                    </ProgressTemplate>
                </asp:UpdateProgress>
            </ContentTemplate>
        </asp:UpdatePanel>


        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
            </ContentTemplate>
        </asp:UpdatePanel>



    
    </div>
    </form>
</body>
    <script type="text/javascript">

    var prm = Sys.WebForms.PageRequestManager.getInstance();
    prm.add_initializeRequest( prm_initializeRequest );    
    
    function prm_initializeRequest(sender, args)
    {
        if (prm.get_isInAsyncPostBack())
        {
            alert('Still Processing First Request');
            args.set_cancel(true);
        }
    }
    </script>

</html>
