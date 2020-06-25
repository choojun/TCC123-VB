'frmNumericUpDown.vb
'To calculate the housing loan interest payment.

Public Class frmNumericUpDown
    Private Sub btnCalculate_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' declare variables to hold user input
        Dim principal As Decimal ' hold principal
        Dim rate As Double ' hold interest rate
        Dim year As Integer ' hold number of years
        Dim amount As Decimal ' hold amount

        ' retrieve user input
        principal = Convert.ToDecimal(txtPrincipal.Text)
        rate = Convert.ToDouble(txtRate.Text)
        year = Convert.ToInt32(nudYear.Value)

        ' output header
        txtDisplay.Text = "Year" & vbTab & "Payment" & vbCrLf

        ' calculate amount after each year and append to output
        For yearCounter As Integer = 1 To year
            amount = principal * Convert.ToDecimal( _
               Math.Pow(1 + rate / 100, yearCounter))
            txtDisplay.Text &= (yearCounter & vbTab & _
               String.Format("{0:C}", amount) & vbCrLf)
        Next
    End Sub
End Class
