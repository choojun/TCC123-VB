Module Module1

    Sub Main()
        Console.WriteLine("1 [C#], 2 [VB]")
        Console.Write("Please pick your language preference: ")
        Dim n As String = Console.ReadLine()
        Select Case (n)
            Case 1
                Console.WriteLine("Good choice, C# is a fine language.")
            Case 2
                Console.WriteLine("Visual Basic .Net: OOP, multithreading, and more!")
            Case Else
                Console.WriteLine("Well...good luck with that!")
        End Select
    End Sub

End Module
