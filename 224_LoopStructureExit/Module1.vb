Module Module1

    Sub Main()
        Dim number As Integer
        ' exit for-next loop statement
        For number = 1 To 30
            If number = 6 Then
                Exit For 'break out the loop
            End If
            Console.Write(number & " ")
        Next
        Console.WriteLine(vbCrLf & "for-next exit from loop at number" & number & vbCrLf)

        number = 1
        ' exit do-until loop statement
        Do Until number > 45
            If number = 6 Then
                Exit Do 'break out the loop
            End If
            Console.Write(number & " ")
            number += 1 'increment number
        Loop
        Console.WriteLine(vbCrLf & "do-until exit from loop at number" & number & vbCrLf)

        number = 1
        ' exit while loop statement
        While number <= 60
            'Skip remaining code in loop only if number = 6
            If number = 6 Then
                Exit While 'break out the loop
            End If
            Console.Write(number & " ")
            number += 1
        End While
        Console.WriteLine(vbCrLf & "while exit from loop at number" & number & vbCrLf)

    End Sub

End Module
