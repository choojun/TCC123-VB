Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        Label1.Text = TextBox1.Text + " is added into ListBox!"
    End Sub
End Class
