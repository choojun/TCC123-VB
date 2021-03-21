Module Module1

    Sub Main()
        'Display truth table for And
        Console.WriteLine("And" & vbCrLf &
        "True And True: " & (True And True) & vbCrLf &
        "True And False: " & (True And False) & vbCrLf &
        "False And True: " & (False And True) & vbCrLf &
        "False And False: " & (False And False) & vbCrLf)

        'Display truth table for Or
        Console.WriteLine("Or" & vbCrLf &
        "True Or True: " & (True Or True) & vbCrLf &
        "True Or False: " & (True Or False) & vbCrLf &
        "False Or True: " & (False Or True) & vbCrLf &
        "False Or False: " & (False Or False) & vbCrLf)

        'Display truth table for Xor
        Console.WriteLine("Xor" & vbCrLf &
        "True Xor True: " & (True Xor True) & vbCrLf &
        "True Xor False: " & (True Xor False) & vbCrLf &
        "False Xor True: " & (False Xor True) & vbCrLf &
        "False Xor False: " & (False Xor False) & vbCrLf)

        'Display truth table for Not
        Console.WriteLine("Not" & vbCrLf &
        "Not False: " & (Not False) & vbCrLf &
        "Not True: " & (Not True) & vbCrLf)
    End Sub

End Module
