Module ArithmeticRules

    Sub Main()
        ' Declare variable
        Dim a, b, c, d, e, f, g As Double
        ' Assign a value to variable
        a = 2.0
        b = 3.0

        ' Display the results
        System.Console.WriteLine("When a = " & a &
                                 ", b = " & b)
        System.Console.WriteLine()
        System.Console.WriteLine("5 * b + 1 = " &
                                 (5 * b + 1))
        System.Console.WriteLine("a Mod b + 1 = " &
                                 (a Mod b + 1))
        System.Console.WriteLine("Math.Pow(a, b) + 0.8 = " &
                                 (Math.Pow(a, b) + 0.8))
        System.Console.WriteLine("Math.Log(1) = " &
                                 Math.Log(1))
        System.Console.WriteLine("Math.Log(a/2) + 0.8 = " &
                                 (Math.Log(a / 2) + 0.8))
        System.Console.WriteLine("Math.Exp(0) = " &
                                 Math.Exp(0))
        System.Console.WriteLine("Math.Exp(b-3) + 0.8 = " &
                                 (Math.Exp(b - 3) + 0.8))
        System.Console.WriteLine()
        ' Assign a value to variable
        c = 4.0
        d = 5.0
        e = 6.0
        f = 6.0
        g = 8.0
        System.Console.WriteLine("b * c Mod d + e / f - g = " &
                                 (b * c Mod d + e / f - g))

        System.Console.WriteLine()
        System.Console.WriteLine("Math.PI = " & Math.PI)
        Dim angle As Double = (b * 10) * (180 / Math.PI)
        System.Console.WriteLine("The angle = " & angle)
        Dim radius As Double = angle * (Math.PI / 180)
        System.Console.WriteLine("The radius = " & radius)



    End Sub

End Module
