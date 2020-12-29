Module DateTime

    Sub Main()
        Dim dteDateOfBirth As Date = #9/22/2006#
        Dim dteMerdekaDay As Date = #8/31/1957#
        Console.WriteLine("My birthday is " & dteDateOfBirth)
        Console.WriteLine()

        Dim dteDate As Date = Date.Now
        Console.WriteLine("Today is " & dteDate)
        Console.WriteLine()

        Dim dteDate1 As Date = dteDate
        Dim dteDate2 As Date = dteDate
        Dim dteDate3 As Date = dteDate
        Dim dteDate4 As Date = dteDate
        Dim dteDate5 As Date = dteDate
        ' To add 5 months
        dteDate1 = dteDate1.AddMonths(5)
        Console.WriteLine("5 months later: new date is " & dteDate1)
        ' To add 2 years
        dteDate2 = dteDate2.AddYears(2)
        Console.WriteLine("2 years later: new date is " & dteDate2)
        ' To add 2 minutes
        dteDate3 = dteDate3.AddMinutes(2)
        Console.WriteLine("2 mins later: new date is " & dteDate3)
        ' To add 2 days
        dteDate4 = dteDate4.AddDays(2)
        Console.WriteLine("2 days later: new date is " & dteDate4)
        ' To add 2 hours
        dteDate5 = dteDate5.AddHours(2)
        Console.WriteLine("2 hours later: new date is " & dteDate5)
        Console.WriteLine()

        ' Returns the number of days - after 5 months
        Console.WriteLine("5 months later: " & (dteDate1 - dteDate).TotalDays _
                          & " days, " & (dteDate1 - dteDate).TotalHours & " hours")
        ' Return the number of days - after 2 years
        Console.WriteLine("2 years later: " & (dteDate2 - dteDate).TotalDays _
                          & " days, " & (dteDate2 - dteDate).TotalHours & " hours")
        ' Return the number of days - after 2 minutes
        Console.WriteLine("2 mins later: " & (dteDate3 - dteDate).TotalDays _
                          & " days, " & (dteDate3 - dteDate).TotalSeconds & " seconds")
        ' Return the number of days - after 2 days
        Console.WriteLine("2 days later: " & (dteDate4 - dteDate).TotalDays _
                          & " days, " & (dteDate4 - dteDate).TotalSeconds & " seconds")
        ' Return the number of days - after 2 hours
        Console.WriteLine("2 hours later: " & (dteDate5 - dteDate).TotalDays _
                          & " days, " & (dteDate5 - dteDate).TotalMilliseconds & " milliseconds")
    End Sub

End Module
