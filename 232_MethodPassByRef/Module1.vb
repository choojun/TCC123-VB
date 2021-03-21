Module Module1

    Sub passByRef(ByRef i As Integer)
        i = i + 1
    End Sub

    Sub Main()
        Dim j As Integer = 0
        passByRef(j)
        Console.WriteLine(j) 'j = 1
    End Sub

End Module
