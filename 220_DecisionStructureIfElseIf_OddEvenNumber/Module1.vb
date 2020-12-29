Module Module1

    Sub Main()
        Console.Write("Enter your number: ")
        Dim number As Integer
        number = Console.ReadLine()
        If number Mod 2 = 0 Then
            Console.WriteLine("Even Number")
        Else
            Console.WriteLine("Odd Number")
        End If
    End Sub

End Module
