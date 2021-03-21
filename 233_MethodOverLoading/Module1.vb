Module Module1

    Function add(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x + y
    End Function

    Function add(ByVal x As Double, ByVal y As Double) As Double
        Return x + y
    End Function

    Function add(ByVal x As Long, ByVal y As Long) As Long
        Return x + y
    End Function

    Sub Main()
        ' Calls int version of Add()
        Console.WriteLine(add(10, 10))
        ' Calls long version of Add() (using the New digit separator)
        Console.WriteLine(add(900_000_000_000, 900_000_000_000))
        ' Calls double version of Add()
        Console.WriteLine(add(4.3, 4.4))
    End Sub

End Module
