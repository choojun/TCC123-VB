Module Module1

    'Arguments are passed by value by default.
    Function add(ByVal x As Integer, ByVal y As Integer) As Integer
        Dim answer As Integer = x + y
        ' Caller will Not see these changes
        ' as you are modifying a copy of the original data.
        x = 99999
        y = 88888
        Return answer
    End Function

    Sub Main()
        ' Pass two variables in by value.
        Dim x As Integer = 9, y = 8
        Console.WriteLine("Before call: X: {0}, Y: {1}", x, y)
        Console.WriteLine("Answer is: {0}", add(x, y))
        Console.WriteLine("After call: X: {0}, Y: {1}", x, y)
        Console.ReadLine()
    End Sub

End Module
