Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtOne.ForeColor = Color.Green
        txtTwo.ForeColor = Color.Green
    End Sub

    Private Sub txtOne_TextChanged(sender As Object, e As EventArgs) Handles txtOne.TextChanged
        txtOne.ForeColor = Color.Blue
    End Sub

    Private Sub txtTwo_TextChanged(sender As Object, e As EventArgs) Handles txtTwo.TextChanged
        txtTwo.ForeColor = Color.Red
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtOne.ForeColor = Color.Blue
        txtTwo.ForeColor = Color.Red
    End Sub
End Class
