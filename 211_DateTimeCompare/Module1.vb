Module Module1

    Sub Main()
        ' assign today's date
        Dim todayDate As Date = DateTime.Now
        Console.WriteLine(todayDate)
        ' add two month
        Dim newDate As Date = todayDate.AddMonths(2)
        Console.WriteLine("Interval days after 2 months: " &
                          (newDate - todayDate).TotalDays)
    End Sub

End Module
