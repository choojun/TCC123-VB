'frmComboBox.vb
'Use ComboBox to select the title

Public Class frmTitle

    Private Sub btnName_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnName.Click
        'display the title and full name in text box.
        TxtDisplay.Text = cboTitle.Text & " " & txtName.Text
    End Sub
End Class
