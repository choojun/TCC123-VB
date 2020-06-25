<%@ Page Language="VB" AutoEventWireup="false" CodeFile="WebTime.aspx.vb" Inherits="WebTime" EnableSessionState="False" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        Current time on the Web server:<br />
        <br />
        <asp:Label ID="timeLabel" runat="server" BackColor="Yellow" EnableViewState="False" Font-Size="14pt" ForeColor="Black"></asp:Label>

    </div>
    </form>
</body>
</html>
