Module Module1

    Sub Main()
        Console.Write("Enter your number: ")
        Dim number As Integer = Console.ReadLine()
        If number < 0 Then
            Console.WriteLine("Negative Number")
        Else

            If number = 0 Then
                Console.WriteLine("Zero Number")
            Else
                Console.WriteLine("Positive Number")
            End If
        End If
    End Sub

End Module
