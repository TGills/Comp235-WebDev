﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test2Exercise.aspx.cs" Inherits="Test2Exercise" %>

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

        <asp:UpdatePanel 
            ID="UpdatePanel1" 
            runat="server">
            <ContentTemplate>
        <asp:DropDownList 
            ID="ddlMovieCats" 
            DataTextField="Title" 
            DataValueField="Title" 
            runat="server"
            AutoPostBack="true"
            OnSelectedIndexChanged="ddlMovieCats_SelectedIndexChanged">
        </asp:DropDownList>
      
        <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <span class="MovieTitle"><%#Eval("Title") %>
            <span style="display:none" class="MovieDetail">
                <%#Eval("Director") %><br />
                <%#Eval("Description") %><br />
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
            $(".MovieTitle").each(function(index){
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
