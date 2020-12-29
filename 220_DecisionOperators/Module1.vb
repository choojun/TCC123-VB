Module Module1

    Sub Main()
        Dim number As Integer = 128
        If number Mod 2 = 0 Then
            Console.WriteLine("Even Number")
        End If

        Dim username As String = "Wawasan"
        If username = "Wawasan" Then
            Console.WriteLine("Passed. Login Successful")
        Else
            Console.WriteLine("Login failed")
        End If

    End Sub

End Module
