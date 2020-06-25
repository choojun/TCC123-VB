'frmCheckBoxes.vb
'to calculate the sum of various items

Public Class frmCheckBoxes

    Private Sub match(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    chkOrange.CheckedChanged, chkApple.CheckedChanged, chkGrape.CheckedChanged, chkPearl.CheckedChanged

        Dim sum As Double = 0

        If chkOrange.Checked Then
            sum += 1.0
        End If
        If chkApple.Checked Then
            sum += 0.6
        End If
        If chkGrape.Checked Then
            sum += 8.0
        End If
        If chkPearl.Checked Then
            sum += 2.0
        End If
        txtTotal.Text = FormatCurrency(sum) 'display the amount in $ sign
    End Sub
End Class
