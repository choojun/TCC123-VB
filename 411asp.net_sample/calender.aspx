<!DOCTYPE html>

<html>
<head>

    <script language="VB" runat="server">

        Sub Date_Selected(sender As Object, e As EventArgs) 
            Label1.Text = "Selected date is: " + Calendar1.SelectedDate.ToShortDateString
        End Sub

    </script>

</head>

<body>

    <h3><font face="Verdana">Calendar Example</font></h3>

    <form runat=server>

        <asp:Calendar id=Calendar1 onselectionchanged="Date_Selected" runat="server" />
        
        <p>
        
        <asp:Label id=Label1 runat="server" />
        
    </form>

</body>
</html>