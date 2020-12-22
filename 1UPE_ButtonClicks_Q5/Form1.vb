Public Class Form1
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblOne.Text = "Wawasan Open University"
        txtBox.Enabled = True
        btnReset.Focus()
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        lblOne.Text = "Welcome to WOU!"
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        txtBox.Enabled = False
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        btnTotal.Focus()
    End Sub
End Class
