'frmRadioButton.vb
'To choose any one of the prograaming languages

Public Class frmRadioButton

    Private Sub radVB_CheckedChanged(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles radVB.CheckedChanged, radC.CheckedChanged
        If radVB.Checked Then
            txtLang.Text = "Visual Programming."
        ElseIf radC.Checked Then
            txtLang.Text = "Structured Programming."
        End If
    End Sub
End Class
