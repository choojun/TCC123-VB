'FrmLabelTextBoxButton.vb
'User input password into text box and 
'click on the button to show the hidden password

Public Class frmLabelTextBoxButton

    'event handler for btnDisplayPassword's Click event
    Private Sub btnDisplayPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayPassword.Click

        'Display the text of user input
        lblDisplayPassword.Text = txtInputPassword.Text
    End Sub
End Class
