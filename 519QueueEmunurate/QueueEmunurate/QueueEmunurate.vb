Module QueueEmunurate

    Sub Main()

        Dim numbers As New Queue(Of String)
        numbers.Enqueue("one")
        numbers.Enqueue("two")
        numbers.Enqueue("three")
        numbers.Enqueue("four")
        numbers.Enqueue("five")

        For Each number As String In numbers
            Console.WriteLine(number)
        Next
        Console.ReadLine()
    End Sub

End Module
