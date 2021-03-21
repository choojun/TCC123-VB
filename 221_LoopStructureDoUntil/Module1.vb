Module Module1

    Sub Main()
        Console.Write("Enter a number (less than 50): ")
        Dim number As Integer = Console.ReadLine()
        'Statement multiplies number by 2 and displays number
        'Find out the first multiple of 2 larger than 50
        Do Until number > 50
            Console.Write(number & " ")
            number = number * 2
        Loop
        Console.WriteLine()

        Dim payAmt As Integer = 500
        Do Until payAmt > 200
            'Processing steps
            payAmt = payAmt - 50
        Loop
        Console.WriteLine(payAmt)

    End Sub

End Module
