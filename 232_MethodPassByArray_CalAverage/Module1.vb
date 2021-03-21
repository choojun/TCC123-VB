Module Module1

    ' Return average of "some number" of doubles.
    Function calculateAverage(ByVal values As Double()) As Double
        Console.WriteLine("I received {0} doubles.", values.Length)
        Dim sum As Double = 0
        If (values.Length = 0) Then
            Return sum
        End If
        For i As Integer = 0 To (values.Length - 1)
            sum += values(i)
        Next
        Return sum
    End Function

    Sub Main()
        ' Pass in a comma-delimited list of doubles...
        Dim average As Double
        average = calculateAverage(New Double() {4.0, 3.2, 5.7, 64.22, 87.2})
        Console.WriteLine("Average of data is: {0}", average)

        ' ...Or pass an array of doubles.
        Dim data As Double() = {4.0, 3.2, 5.7}
        average = calculateAverage(data)
        Console.WriteLine("Average of data is: {0}", average)
    End Sub

End Module
