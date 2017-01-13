<%@ Page Language="C#" ViewStateMode="Enabled" AutoEventWireup="true" CodeFile="StudyGuideQ5.aspx.cs" Inherits="StudyGuideQ5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView 
            ID="GridView1" 
            runat="server" 
            DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource 
            ID="ObjectDataSource1" 
            runat="server" 
            DataObjectTypeName="MovieLibrary.Movie" 
            InsertMethod="insertMovieCategory" 
            SelectMethod="getCategories" 
            TypeName="MovieLibrary.MovieData" 
            UpdateMethod="CategoryUpdate">
            <InsertParameters>
                <asp:Parameter Name="Id" Type="Int32" />
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Position" Type="String" />
            </InsertParameters>
        </asp:ObjectDataSource>        
        <asp:Panel ID="Panel1" runat="server">
            ID<br />
            <asp:TextBox 
                ID="tbID" 
                runat="server">
            </asp:TextBox>
            <br />
            Name<br />
            <asp:TextBox 
                ID="tbName" 
                runat="server">
            </asp:TextBox>
            <br />
            Position<br />
            <asp:TextBox 
                ID="tbPosition" 
                runat="server">
            </asp:TextBox>
            <br />
            <br />
            <asp:Button 
                ID="Button1" 
                runat="server" 
                OnClick="Button1_Click" 
                Text="Commit Changes"
                EnablePostback ="True" />
            <br />
        </asp:Panel>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
