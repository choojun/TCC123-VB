
Partial Class WebTime
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object,
                            ByVal e As EventArgs) Handles Me.Init
        'display the server's current time in timeLabel
        timeLabel.Text = DateTime.Now.ToString("hh:mm:ss")
    End Sub

End Class
