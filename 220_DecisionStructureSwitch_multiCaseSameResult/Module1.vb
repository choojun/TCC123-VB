Module Module1

    Sub Main()
        Dim Year, Month, Day As Integer
        Dim birthday As Date
        Try
            Console.Write("Enter year of your birthday (in integer): ")
            Year = Console.ReadLine()
            Console.Write("Enter month of your birthday (in integer): ")
            Month = Console.ReadLine()
            Console.Write("Enter day of your birthday (in integer): ")
            Day = Console.ReadLine()
            birthday = New DateTime(Year, Month, Day)

            Select Case (birthday.DayOfWeek)
                Case DayOfWeek.Monday
                    Console.WriteLine("Your birthday is on Monday.")
                Case DayOfWeek.Tuesday
                    Console.WriteLine("Your birthday is on Tuesday.")
                Case DayOfWeek.Wednesday
                    Console.WriteLine("Your birthday is on Wednesday.")
                Case DayOfWeek.Thursday
                    Console.WriteLine("Your birthday is on Thursday.")
                Case DayOfWeek.Friday
                    Console.WriteLine("Your birthday is on Friday.")
                Case DayOfWeek.Saturday
                    Console.WriteLine("Your birthday is on Saturday.")
                Case Else
                    Console.WriteLine("Your birthday is on Sunday.")
            End Select

            Select Case (birthday.DayOfWeek)
                Case DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday
                    Console.WriteLine("It is on weekday.")
                Case Else
                    Console.WriteLine("It is the weekend!")
            End Select

        Catch ex As Exception
            Console.WriteLine("Bad input!")
        End Try
    End Sub

End Module
