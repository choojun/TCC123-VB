'CreateArray.vb
'Declaring and allocating an array

Module CreateArray
    Sub Main()
        'declare array variable
        Dim array1 As Integer()

        'allocate memory for 5 element array 
        array1 = New Integer(0 To 4) {}
        array1(2) = 998
        Console.WriteLine("Index " & vbTab & "Value")

        'Display values in array
        For counter As Integer = 0 To array1.GetUpperBound(0)
            Console.WriteLine(counter & vbTab & array1(counter))
        Next

        Console.WriteLine(vbCrLf & "The array contains " & _
        array1.Length & " elements.")
    End Sub
End Module
