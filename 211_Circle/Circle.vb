Module Circle

    Sub Main()
        ' declare Integer variable as radius
        Dim radius As Integer

        ' read the radius of a circle
        Console.Write("Please enter the radius: ")
        radius = Console.ReadLine()

        ' display circle's diameter
        Console.WriteLine("The diameter is " & (2 * radius))

        ' display circle's circumference
        Console.WriteLine("The circumference is " & (2 * Math.PI * radius))

        ' display circle's area
        Console.WriteLine("The area is " & (Math.PI * Math.Pow(radius, 2)))
    End Sub

End Module
