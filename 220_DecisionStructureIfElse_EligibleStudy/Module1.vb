Module Module1

    Sub Main()
        Console.Write("Please enter your age: ")
        Dim age As Double = Console.ReadLine()

        If (age >= 21) Then
            Console.WriteLine("You are eligible to study at WOU")
        Else
            Console.WriteLine("You are eligible to study in " & (21 - age) & " years")
        End If
    End Sub

End Module
