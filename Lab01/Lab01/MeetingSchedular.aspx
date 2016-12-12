<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MeetingSchedular.aspx.cs" Inherits="Lab01.MeetingSchedular" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="calMeetings" runat="server" OnSelectionChanged="calMeetings_onSelectionChanged" OnDayRender="calMeetings_DayRender"></asp:Calendar>
        <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine"></asp:TextBox>
        <asp:Button ID="Save" runat="server" Text="Button" OnClick="Save_Click" />
    </div>
    </form>
</body>
</html>
