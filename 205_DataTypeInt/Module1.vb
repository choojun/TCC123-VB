Module Module1

    Sub Main()
        ' variables used in addition calculation
        Dim num1, num2, sum As Integer

        ' prompt the user to enter first number
        System.Console.Write("Please enter first number: ")
        num1 = System.Console.ReadLine()

        ' prompt the user to enter second number
        System.Console.Write("Please enter second number: ")
        num2 = System.Console.ReadLine()

        sum = num1 + num2 ' add the numbers

        ' display the sum
        System.Console.WriteLine("The sum is " & sum)
    End Sub

End Module
