Public Class fmDivideByZero
    Private Sub cmdDivide_Click(sender As Object, e As EventArgs) Handles cmdDivide.Click

        ' retrieve user input and call Quotient
        Try
            ' Convert.ToInt32 generates FormatException 
            ' if argument is not an integer
            Dim numerator As Integer = Convert.ToInt32(txtNumerator.Text)
            Dim denominator As Integer = Convert.ToInt32(txtDenominator.Text)

            ' division generates DivideByZeroException if
            ' denominator is 0
            Dim result As Integer = numerator \ denominator
            lblOutput.Text = result.ToString()

            ' process invalid number format
        Catch formatExceptionParameter As FormatException
            MessageBox.Show("Learner, you must enter two integers", 'formatExceptionParameter.Message, 
                            "Invalid Number Format",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' user attempted to divide by zero
        Catch divideByZeroExceptionParameter As DivideByZeroException
            MessageBox.Show(divideByZeroExceptionParameter.Message,
                            "Attempted to Divide by Zero",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Finally executes to reset back 
        Finally
            Dim dlgResult As DialogResult =
                MessageBox.Show("Do you want to run again?", "Finally",
                                MessageBoxButtons.YesNo)
            If dlgResult = DialogResult.Yes Then
                lblOutput.Text = String.Empty
                txtDenominator.Text = String.Empty
                txtNumerator.Text = String.Empty
            Else
                Application.Exit()
            End If

        End Try
    End Sub
End Class
