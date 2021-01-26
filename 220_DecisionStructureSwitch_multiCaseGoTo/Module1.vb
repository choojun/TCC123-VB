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
                    GoTo LineWeekday
                Case DayOfWeek.Tuesday
                    GoTo LineWeekday
                Case DayOfWeek.Wednesday
                    GoTo LineWeekday
                Case DayOfWeek.Thursday
                    GoTo LineWeekday
                Case DayOfWeek.Friday
                    GoTo LineWeekday
                Case Else
                    Console.WriteLine("It's the weekend!")
                    GoTo LineWeekend
            End Select
LineWeekday:
            Console.WriteLine("It's on weekday.")
LineWeekend:
        Catch ex As Exception
            Console.WriteLine("Bad input!")
        End Try
    End Sub

End Module
