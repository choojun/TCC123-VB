Module Module1

    Sub Main()
        Console.WriteLine("C# or VB")
        Console.Write("Please pick your language preference: ")
        Dim langChoice As String = Console.ReadLine()
        Select Case (langChoice)
            Case "C#"
                Console.WriteLine("Good choice, C# is a fine language.")
            Case "VB"
                Console.WriteLine("VB: OOP, multithreading and more!")
            Case Else
                Console.WriteLine("Well...good luck with that!")
        End Select

        Dim pass As Boolean
        Console.Write("Please enter your marks: ")
        Dim marks As Double = Console.ReadLine()
        If marks >= 40 Then
            pass = True
        Else
            pass = False
        End If
        Select Case (pass)
            Case True
                Console.WriteLine("Congratulation, you pass the course!")
            Case False
                Console.WriteLine("Sorry, you failed your course.")
            Case Else
                Console.WriteLine("Impossible event!")
        End Select

        Dim longDecimalValue As Long = 4294967296
        Select Case (longDecimalValue)
            Case 4_294_967_296
                Console.WriteLine("Decimal.")
            Case Else
                Console.WriteLine("Others")
        End Select

        Dim longHexadecimalValue As Long = 4294967296
        Select Case (longHexadecimalValue)
            Case &H1_0000_0000
                Console.WriteLine("Hexadecimal.")
            Case Else
                Console.WriteLine("Others")
        End Select

        Dim longBinaryValue As Long = 4294967296
        Select Case (longBinaryValue)
            Case &B1_0000_0000_0000_0000_0000_0000_0000_0000
                Console.WriteLine("Binary.")
            Case Else
                Console.WriteLine("Others")
        End Select

        Dim longMixValue As Long = 1129281068651370124
        Select Case (longBinaryValue)
            Case &H_0FAC_0326_1489_D68C
                Console.WriteLine("Mix.")
            Case Else
                Console.WriteLine("Others")
        End Select
    End Sub

End Module
