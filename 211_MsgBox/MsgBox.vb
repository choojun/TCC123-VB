Imports System.Windows.Forms

Module MsgBox

    Sub Main()
        Dim x, y, z As Integer
        y = 4
        z = 5
        MessageBox.Show(y & "", "Y")
        MessageBox.Show((y + y) & "", "(y + y)")
        MessageBox.Show("y + z")
    End Sub

End Module
