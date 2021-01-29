Module Module1

    Sub Main()
        Dim userIsDone As String = ""
        While userIsDone.ToLower <> "yes"
            Console.WriteLine("In while loop")
            Console.Write("Are you done? [yes] [no]: ")
            userIsDone = Console.ReadLine()
        End While

        Console.Write("Enter a number (less than 50): ")
        Dim number As Integer = Console.ReadLine()
        'Statement multiplies number by 2 and displays number
        'while number is less than 50
        While number < 50
            Console.Write(number & " ")
            number = Number * 2
        End While
    End Sub

End Module
