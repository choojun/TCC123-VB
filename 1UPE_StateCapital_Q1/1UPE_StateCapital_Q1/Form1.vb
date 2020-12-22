Public Class Form1
    Private Sub btnPerak_Click(sender As Object, e As EventArgs) Handles btnPerak.Click
        lblCapital.Text = "Ipoh"
    End Sub

    Private Sub btnPenang_Click(sender As Object, e As EventArgs) Handles btnPenang.Click
        lblCapital.Text = "George Town"
    End Sub

    Private Sub btnJohor_Click(sender As Object, e As EventArgs) Handles btnJohor.Click
        lblCapital.Text = "Johor Bahru"
    End Sub

    Private Sub btnSelangor_Click(sender As Object, e As EventArgs) Handles btnSelangor.Click
        lblCapital.Text = "Shah Alam"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
