Module Module1

    Function passByRef(ByRef i As Integer()) As Integer
        Dim add As Integer = 0
        For item As Integer = 0 To (i.Length - 1)
            add = add + i(item)
        Next
        Return add
    End Function

    Sub Main()
        Dim array1 As Integer() = New Integer() {2, 4, 6, 8}
        Dim total As Integer = passByRef(array1) ' total = 20
        Console.WriteLine("total: {0}", total)
    End Sub

End Module
