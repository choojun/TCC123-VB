Module Module1

    Sub Main()
        Dim number As Integer

        Console.Write("Enter a number (more than 8): ")
        number = Console.ReadLine()
        Do While Number > 8
            number = number - 8
        Loop

        'observe the following Do-Until loop, any problems?
        Console.Write("Enter a number (less than or equal 8): ")
        number = Console.ReadLine()
        Do Until number <= 8
            number = number + 8
        Loop

        number = 0
        Do While number < 5
            Console.Write(number & " ")
            number = number + 1
        Loop

        number = 0
        Do Until number > 5
            Console.Write(number & " ")
            number = number + 1
        Loop

        number = 3
        Do While number < 15
            number = 2 * number + 1
        Loop
        Console.WriteLine(number)
    End Sub

End Module
