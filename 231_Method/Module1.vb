Module Module1
    Function sumMe(ByVal a As Integer, ByVal b As Integer) As Integer
        Dim add As Integer = a + b
        Return add
    End Function

    Sub printMe(ByVal a As String, ByVal b As Integer)
        Console.WriteLine("Output: " & b)
    End Sub

    Function multiplyMe(ByVal a As Integer, Optional ByVal b As Integer = 2) As Integer
        Dim multiply As Integer = a * b
        Return multiply
    End Function

    Sub Main()
        Dim number1 As Integer = 3
        Dim number2 As Integer = 6
        Dim total1 As Integer = sumMe(number1, number2)
        printMe("total1: {0}", total1)

        ' Optional Argument
        Dim total3 As Integer = multiplyMe(7) ' a = 7, b = 2
        printMe("total3: {0}", total3)
        Dim total4 As Integer = multiplyMe(7, 3) ' a = 7, b = 3
        printMe("total4: {0}", total4)
    End Sub
End Module
