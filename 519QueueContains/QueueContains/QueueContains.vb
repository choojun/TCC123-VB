Module QueueContains

    Sub Main()
        Dim numbers As New Queue(Of String)
        numbers.Enqueue("one")
        numbers.Enqueue("two")
        numbers.Enqueue("three")
        numbers.Enqueue("four")
        numbers.Enqueue("five")


        Console.WriteLine("numbers.Contains(""four"") = {0}", numbers.Contains("four"))

        Console.WriteLine("numbers.Clear()")
        numbers.Clear()
        Console.WriteLine("numbers.Count = {0}", numbers.Count)
    End Sub

End Module
