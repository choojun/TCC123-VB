Module Module1

    Sub Main()
        Console.WriteLine("Enter your number")
        Dim number As Integer
        number = Console.ReadLine()

        Select Case (number Mod 2)
            Case 0
                Console.WriteLine("{0} is an even number", number)
            Case 1
                Console.WriteLine("{0} is an odd number", number)
            Case Else
                Console.WriteLine("Impossible event!")
        End Select
    End Sub

End Module
