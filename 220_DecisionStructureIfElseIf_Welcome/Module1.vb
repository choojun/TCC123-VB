Module Module1

    Sub Main()
        Console.Write("Please enter p, i or k: ")
        Dim city As String = Console.ReadLine()
        If city = "p" Then
            Console.WriteLine("Welcome to Penang")
        ElseIf city = "i" Then
            Console.WriteLine("Welcome to Ipoh")
        ElseIf city = "k" Then
            Console.WriteLine("Welcome to Kedah")
        End If
    End Sub

End Module
