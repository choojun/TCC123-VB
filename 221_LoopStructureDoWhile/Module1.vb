Module Module1

    Sub Main()
        Dim userIsDone As String = ""
        Do While (userIsDone.ToLower <> "yes")
            Console.WriteLine("In do-while loop")
            Console.Write("Are you done? [yes] [no]: ")
            userIsDone = Console.ReadLine()
        Loop

        Console.Write("Enter a number (less than 50): ")
        Dim number As Integer = Console.ReadLine()
        'Statement multiplies number by 2 and displays number
        'Do While number is less than 50
        Do While number < 50
            Console.Write(number & " ")
            number = number * 2
        Loop
    End Sub

End Module
