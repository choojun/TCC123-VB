Module Module1

    Sub Main()
        'Count the number from 1 to 10
        For number As Integer = 1 To 10
            Console.WriteLine("Number is: {0} ", number)
        Next
        Console.WriteLine()

        'Initialisation starts at value 4, repetition condition and
        'increment by 2 are all included in the statement.
        For number As Integer = 4 To 20 Step 2
            Console.WriteLine("Number is: {0} ", number)
        Next
        Console.WriteLine()

        For number As Integer = 1 To 3
            Console.WriteLine("Number and its square are: | {0} | {1} |", number, number * number)
        Next
        Console.WriteLine()

        For number As Integer = 4 To 8
            Console.WriteLine(2 * number)
        Next
        Console.WriteLine()

        For number As Integer = 4 To 8 Step 2
            Console.WriteLine(number)
        Next
        Console.WriteLine("Number increment by 2")
        Console.WriteLine()

        For number As Double = 1 To 10.5 Step 1
            Console.WriteLine(number)
        Next
        Console.WriteLine()

        For number As Double = 1 To 10 Step 0.5
            Console.WriteLine(number)
        Next

    End Sub

End Module
