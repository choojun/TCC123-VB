Imports System.Windows.Forms

Module MsgBox

    Sub Main()

        Dim pi As Double = Math.PI
        MessageBox.Show(pi & "", "pi")
        MessageBox.Show(Math.Round(Math.PI, 2) _
            & "", "pi with 2 decimal place")
        MessageBox.Show(Math.Round(Math.PI, 3) _
            & "", "pi with 3 decimal place")
        MessageBox.Show(Math.Round(Math.PI, 4) _
            & "", "pi with 4 decimal place")

        Dim root As Double = Math.Sqrt(2)
        MessageBox.Show("Square root of 2 is " & root)
    End Sub

End Module
