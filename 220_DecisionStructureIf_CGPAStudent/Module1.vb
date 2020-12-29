Module Module1

    Sub Main()
        Console.Write("What is your current CGPA: ")
        Dim cgpa As Double
        cgpa = Console.ReadLine()
        ' Clear() Is used to erase the whole console 
        Console.Clear()

        If (cgpa >= 3.67) Then
            Console.Write("A distinction ")
        End If
        Console.WriteLine("Student in WOU!")
    End Sub

End Module
