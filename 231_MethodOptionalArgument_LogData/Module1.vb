Module Module1

    Sub enterLogData(ByVal message As String, Optional ByVal owner As String = "Programmer")
        Console.Beep()
        Console.WriteLine("Error: {0}", message)
        Console.WriteLine("Owner of Error: {0}", owner)
    End Sub

    Sub Main()
        enterLogData("Oh no! Grid can't find data")
        enterLogData("Oh no! I can't find the payroll data", "CFO")
        enterLogData("Oh no! I can't find my CGPA", "Student")
    End Sub

    'Sub enterLogData(ByVal message As String, ByVal owner As String, Optional timeStamp As DateTime = DateTime.Now)
    '   Console.Beep()
    '   Console.WriteLine("Error: {0}", message)
    '   Console.WriteLine("Owner of Error: {0}", owner)
    '   Console.WriteLine("Time of Error: {0}", timeStamp)
    'End Sub

End Module
