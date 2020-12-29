Module Module1

    Sub Main()
        Dim num1, num2 As Integer
        Console.Write("Enter first number: ")
        num1 = Console.ReadLine()

        Console.Write("Enter second number: ")
        num2 = Console.ReadLine()

        If num1 > num2 Then
            Console.WriteLine("First number is larger than the second number")
        ElseIf num2 > num1 Then
            Console.WriteLine("Second number is larger than the first number")
        ElseIf num2 = num1 Then
            Console.WriteLine("These two numbers are equal")
        End If
    End Sub

End Module
