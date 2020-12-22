Public Class Form1
    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnEnable.Click
        txtBox.Enabled = True
        txtBox.Focus()
    End Sub

    Private Sub btnDisable_Click(sender As Object, e As EventArgs) Handles btnDisable.Click
        txtBox.Enabled = False
    End Sub
End Class
