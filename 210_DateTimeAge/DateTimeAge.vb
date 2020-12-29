Module DateTimeAge

    Sub Main()
        Dim Year, Month, Day As Integer
        Console.Write("Enter year of your birthday (in integer): ")
        Year = Console.ReadLine()

        Console.Write("Enter month of your birthday (in integer): ")
        Month = Console.ReadLine()

        Console.Write("Enter day of your birthday (in integer): ")
        Day = Console.ReadLine()

        Dim Today As Date = DateTime.Now
        Dim birthday As Date = New DateTime(Year, Month, Day)
        Dim age As Double = (Today - birthday).TotalDays / 365
        Console.WriteLine("You are " & age & " years old")
    End Sub

End Module
