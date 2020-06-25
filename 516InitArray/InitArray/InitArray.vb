'InitArray.vb
'Initialising arrays

Module InitArray
    Sub Main()
        'specify the number of elements and 
        'the value of each element.
        Dim array1 As Integer() = New Integer() _
        {1, 3, 5, 7, 9}

        'allocate array2 based on length of array1
        Dim array2 As Integer() = New Integer(array1.GetUpperBound(0)) {}

        'Set values in array2 by a calculation
        For counter As Integer = 0 To array2.GetUpperBound(0)
            'Generate 1, 2, 3, 4, 5
            array2(counter) = 1 + 1 * counter
        Next

        Console.WriteLine("Index " & vbTab & "Array1" & vbTab & "array2")

        'display values for both arrays side by side
        For counter As Integer = 0 To array1.GetUpperBound(0)
            Console.WriteLine(counter & vbTab & array1(counter) & _
            vbTab & array2(counter))
        Next
    End Sub
End Module
