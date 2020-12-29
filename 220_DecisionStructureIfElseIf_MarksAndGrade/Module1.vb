Module Module1

    Sub Main()
        Console.Write("Please enter your marks: ")
        Dim marks As Double = Console.ReadLine()

        If marks >= 80 Then
            Console.WriteLine("A")
        ElseIf marks >= 70 Then
            Console.WriteLine("B")
        ElseIf marks >= 60 Then
            Console.WriteLine("C")
        ElseIf marks >= 50 Then
            Console.WriteLine("D")
        Else
            Console.WriteLine("F")
        End If
    End Sub

End Module
