'frmGroupBoxPanel.vb
'Using GroupBoxes and Panels to hold buttons

Public Class frmGroupBoxPanel

    'event handler for btnVB's Click event
    Private Sub btnVB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVB.Click
        lblMessage.Text = "Visual Basic pressed" 'change text in label
    End Sub

    'event handler for btnC's Click event
    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        lblMessage.Text = "C Language pressed" 'change text in label
    End Sub

    'event handler for btnleft's Click event
    Private Sub btnleft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnleft.Click
        lblMessage.Text = "Left pressed"  'change text in label
    End Sub

    'event handler for btnright's Click event
    Private Sub btnright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnright.Click
        lblMessage.Text = "Right pressed"  'change text in label
    End Sub
End Class
