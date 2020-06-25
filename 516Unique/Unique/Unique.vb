' Unique.vb
' Entering numbers in an array and printing only unique outputs.
Public Class FrmUnique
    Dim inputs As Integer() = New Integer(9) {}
    Dim count As Integer = 0

    ' handles btnOk Click
    Private Sub btnOk_Click(ByVal sender As System.Object, _
       ByVal e As System.EventArgs) Handles btnOk.Click

        ' get input
        Dim temporary As Integer = Convert.ToInt32(txtNumber.Text)

        txtNumber.Text = "" ' clear input

        ' validate that input is within boundary
        If temporary < 10 OrElse temporary > 100 Then
            MessageBox.Show("Please enter a number from 10-100", _
            "INVALID INPUT")
            Exit Sub
        Else
            count += 1
        End If

        ' compare input to the elements in the array
        For i As Integer = 0 To inputs.GetUpperBound(0)
            If temporary = inputs(i) Then
                displayCount()
                Exit Sub
            End If
        Next

        inputs(count - 1) = temporary ' if unique, add input to array

        ' check if done
        If count >= 10 Then
            MessageBox.Show("You have entered 10 numbers", "Done")
            btnOK.Enabled = False
        End If

        ' update display
        displayCount()
        displayInputs()
    End Sub ' btnOk_Click

    ' display numbers entered so far
    Private Sub DisplayCount()
        lblCount.Text = Convert.ToString(count)
    End Sub ' DisplayCount

    ' display input numbers in txtOutput
    Private Sub DisplayInputs()
        Dim output As String = ""

        ' append array elements to String output
        For i As Integer = 0 To inputs.GetUpperBound(0)
            If inputs(i) <> 0 Then
                output &= inputs(i) & vbCrLf
            End If
        Next

        txtOutput.Text = output
    End Sub
End Class


