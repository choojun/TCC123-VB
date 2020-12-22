Public Class Form1
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtOutput.Text = ""
        txtOutput.BackColor = Color.White
        txtOutput.Visible = True
        Me.Text = "Button Clicks"
        Me.ForeColor = Color.Black
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        txtOutput.Text = "Hello World"
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        txtOutput.Text = "Hello World"
        txtOutput.BackColor = Color.Blue
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtOutput.Text = "Hello World"
        txtOutput.Visible = False
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        Me.Text = "Hello World"
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        txtOutput.Text = "Wawasan Open University"
        txtOutput.ForeColor = Color.Green
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        Me.ForeColor = Color.Red
    End Sub
End Class
