Module Module1

    Sub Main()
        Dim x As Integer = 4
        Dim y As Integer = 2
        Dim z As Integer = 1
        If (x + y) < z Then
            y = 9
        Else
            y = x * z
        End If
        Console.WriteLine(y)
    End Sub

End Module
