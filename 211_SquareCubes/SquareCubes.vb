Module SquareCubes

    Sub Main()
        ' display header for table
        Console.WriteLine("number" + vbTab + "square" + vbTab + "cube")

        ' dispaly table with necessary values And spacing
        Console.WriteLine("1" & vbTab & Math.Pow(1, 2) & vbTab & Math.Pow(1, 3))
        Console.WriteLine("2" & vbTab & Math.Pow(2, 2) & vbTab & Math.Pow(2, 3))
        Console.WriteLine("3" & vbTab & Math.Pow(3, 2) & vbTab & Math.Pow(3, 3))
        Console.WriteLine("4" & vbTab & Math.Pow(4, 2) & vbTab & Math.Pow(4, 3))
    End Sub

End Module
