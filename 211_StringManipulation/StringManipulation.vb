Module StringManipulation

    Sub Main()
        Dim a As Integer = 4
        Dim b As Integer = 2
        Dim c As String = "Visual"
        Dim d As String = "Basic"
        Console.WriteLine(c.Length)
        Console.WriteLine(c.ToLower())
        Console.WriteLine(c.Substring(a, b - 1))
        Console.WriteLine(c.IndexOf(d))
    End Sub

End Module
