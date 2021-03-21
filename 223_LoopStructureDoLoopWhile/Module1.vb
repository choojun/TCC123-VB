Module Module1

    Sub Main()
        Dim number As Integer = 1

        'Print values 1 to 4
        Do
            Console.Write(number & " ")
            number += 1
        Loop While number <= 4
        Console.WriteLine()

        number = 1
        'Print values from 1 to 4
        Do
            Console.Write(number & " ")
            number += 1
        Loop Until number > 4
        Console.WriteLine()
        Console.WriteLine()

        Dim savingBal As Double = 1000
        Dim interestRate As Double = 1.0
        Dim counter As Integer = 0
        Do
            Console.WriteLine(counter & " " & savingBal)
            savingBal = (1 + interestRate) * savingBal
            counter += 1
        Loop Until (savingBal > 2000)
        Console.WriteLine(counter)
        Console.WriteLine()

        Dim payAmount As Integer = 500
        Do
            'Processing steps
            payAmount = payAmount - 50
        Loop Until payAmount > 200
        Console.WriteLine(payAmount)
    End Sub

End Module
