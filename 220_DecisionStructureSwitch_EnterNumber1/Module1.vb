Module Module1

    Sub Main()
        Console.WriteLine("Enter your number")
        Dim number As Integer = Console.ReadLine()
        If (number = 1) Then
            Console.WriteLine("number = 1")
        ElseIf (number > 10) Then
            Console.WriteLine("number > 10")
        End If

        Console.WriteLine("Enter your number (try 2)")
        number = Console.ReadLine()
        Select Case (number)
            Case 1
                Console.WriteLine("number = 1")
            Case number > 10
                Console.WriteLine("number > 10")
        End Select
    End Sub

End Module
