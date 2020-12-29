Module Module1

    Sub Main()
        Console.WriteLine("Enter your age")
        Dim age As Integer = Console.ReadLine()
        If (age > 0) Then
            Console.WriteLine("You have entered {0}", age)
        Else
            Console.WriteLine("Invalid input")
        End If

        If (age < 11) Then
            Console.WriteLine("You're a child!")
        ElseIf (age < 18) Then
            Console.WriteLine("You're a teenager!")
        ElseIf (age < 50) Then
            Console.WriteLine("You're an adult!")
        Else
            Console.WriteLine("You're an old person")
        End If
    End Sub

End Module
