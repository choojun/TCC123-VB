' GenericMethod.vb
' To print arrays of different types.
Module GenericMethod
    Sub Main()
        ' create arrays of Integer, Double and Char types
        Dim integerArray As Integer() = {10, 20, 30, 40, 50, 60}
        Dim doubleArray As Double() = {10.1, 20.2, 30.3, 40.4, 50.5, 60.6}
        Dim charArray As Char() = {"V"c, "I"c, "S"c, "U"c, "A"c, "L"c}

        Console.WriteLine("integerArray contains:")
        PrintArray(integerArray) ' pass an Integer array argument
        Console.WriteLine("doubleArray contains:")
        PrintArray(doubleArray) ' pass a Double array argument
        Console.WriteLine("charArray contains:")
        PrintArray(charArray) ' pass a Char array argument
    End Sub ' Main

    ' outputs array of any type
    Public Sub PrintArray(Of E)(ByVal inputArray() As E)
        For Each element As E In inputArray
            Console.Write(element.ToString() & " ")
        Next element

        Console.WriteLine(vbCrLf)
    End Sub
End Module