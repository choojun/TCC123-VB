'UserControlClock.vb
'Custom control with a Label and a Timer.

Public Class UserControlClock
    'update label for each 1000 milliseconds
    Private Sub tmrClock_Tick(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles tmrClock.Tick

        'get current time (Now), and convert to String
        lblClock.Text = DateTime.Now.ToLongTimeString()
    End Sub
End Class
