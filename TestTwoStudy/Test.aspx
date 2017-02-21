<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">        
    <div>
        <asp:ScriptManager 
            ID="ScriptManager1" 
            runat="server">
        </asp:ScriptManager>
        <asp:DataList 
            ID="DataList1" 
            runat="server">
        </asp:DataList>   
            <asp:UpdatePanel 
            ID="UpdatePanel1" 
            runat="server">
                <ContentTemplate>
                    <asp:TextBox 
                        ID="txtStockCode" 
                        runat="server">
                    </asp:TextBox>
                    <asp:Button 
                        ID="btnDisplayStock" 
                        runat="server" 
                        OnClick="btnDisplayStock_Click" 
                        Text="Display Stock"
                        AutoPostBack="true" />
                    <asp:DataList ID="DataList2" runat="server">
                        <ItemTemplate>
                            <span class="StockSymbol"><%#Eval("StockSymbol") %>
                            <span style="display:none" class="StockDetail">
                            <%#Eval("StockName") %><br />
                            <%#Eval("Shares") %><br />
                            <%#Eval("Price") %><br />
                            <hr />
                            </span></span>
                        </ItemTemplate>
                    </asp:DataList>
                </ContentTemplate>
            </asp:UpdatePanel> 
        </div>        
    </form>
    <script>
        var prm = Sys.WebForms.PageRequestManager.getInstance();
        prm.add_endRequest(function() {
            $(".StockSymbol").each(function(index){
                $(this).click(function() {
                    if ($(this).children().css("display") == "none")
                        $(this).children().show();
                    else
                        $(this).children().hide();
                });
            });
        });
    </script> 
</body>
</html>
