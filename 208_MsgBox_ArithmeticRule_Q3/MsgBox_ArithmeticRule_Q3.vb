Imports System.Windows.Forms

Module MsgBox_ArithmeticRule_Q3
    Sub Main()
        Dim num1, num2 As Integer
        System.Console.Write("Please enter first number: ")
        num1 = Console.ReadLine()

        System.Console.Write("Please enter second number: ")
        num2 = Console.ReadLine()

        System.Console.WriteLine("")
        MessageBox.Show("Sum = " & (num1 + num2))
        MessageBox.Show("Difference = " & (num1 - num2))
        MessageBox.Show("Product = " & (num1 * num2))
        MessageBox.Show("Quotient = " & (num1 / num2))
    End Sub
End Module
