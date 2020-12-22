Public Class Form1
    Private Sub btnPerak_Click(sender As Object, e As EventArgs) Handles btnPerak.Click
        lblCapital.Text = "Ipoh"
        lblDescription.Text = "Ipoh is famous for its food"
    End Sub

    Private Sub btnPenang_Click(sender As Object, e As EventArgs) Handles btnPenang.Click
        lblCapital.Text = "George Town"
        lblDescription.Text = "Penang is famous for its belacan"
    End Sub

    Private Sub btnJohor_Click(sender As Object, e As EventArgs) Handles btnJohor.Click
        lblCapital.Text = "Johor Bahru"
        lblDescription.Text = "Johor is fomous for its curry"
    End Sub

    Private Sub btnSelangor_Click(sender As Object, e As EventArgs) Handles btnSelangor.Click
        lblCapital.Text = "Shah Alam"
        lblDescription.Text = "Selangor is famous for its noodle"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
