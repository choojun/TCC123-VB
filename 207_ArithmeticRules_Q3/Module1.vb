Module Module1

    Sub Main()
        Dim num1, num2 As Integer
        System.Console.Write("Please enter first number: ")
        num1 = Console.ReadLine()

        System.Console.Write("Please enter second number: ")
        num2 = Console.ReadLine()

        System.Console.WriteLine("")
        System.Console.WriteLine("Sum = " & (num1 + num2))
        System.Console.WriteLine("Difference = " & (num1 - num2))
        System.Console.WriteLine("Product = " & (num1 * num2))
        System.Console.WriteLine("Quotient = " & (num1 / num2))
    End Sub

End Module
