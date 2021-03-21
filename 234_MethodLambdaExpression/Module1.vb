Module Module1

    Sub Main()
        Console.ForegroundColor = ConsoleColor.DarkRed
        Console.WriteLine("Lambda Expression with function")
        Dim increment1 = Function(x) x + 1
        Dim increment2 = Function(x)
                             Return x + 2
                         End Function
        Console.WriteLine(increment1(1)) 'value 2
        Console.WriteLine(increment2(2)) 'value 4


        Console.BackgroundColor = ConsoleColor.White
        Console.WriteLine("Lambda Expression with subroutine")
        Dim writeline1 = Sub(x) Console.WriteLine(x)
        Dim writeline2 = Sub(x)
                             Console.WriteLine(x)
                         End Sub
        writeline1(3) 'value 3
        writeline1(6) 'value 6
    End Sub

End Module
