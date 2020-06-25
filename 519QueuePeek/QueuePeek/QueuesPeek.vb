Module QueuesPeek
    Public Sub Run()
    End Sub 'Run

    Public Sub DisplayValues(ByVal myCollection As IEnumerable)
        Dim myEnumerator As IEnumerator = myCollection.GetEnumerator()
        While myEnumerator.MoveNext()
            Console.WriteLine("{0} ", myEnumerator.Current)
        End While
        Console.WriteLine()
    End Sub 'DisplayValues

    Sub Main()
        Dim intQueue As New Queue()

        ' populate the array
        Dim i As Integer
        For i = 0 To 4
            intQueue.Enqueue((i * 5))
        Next i

        ' Display the Queue.
        Console.WriteLine("intQueue values:")
        DisplayValues(intQueue)




        ' Remove an element from the queue.
        Console.WriteLine("(Dequeue) {0}", intQueue.Dequeue())

        ' Display the Queue.
        Console.WriteLine("intQueue values:")
        DisplayValues(intQueue)



        ' Remove another element from the queue.
        Console.WriteLine("(Dequeue) {0}", intQueue.Dequeue())

        ' Display the Queue.
        Console.WriteLine("intQueue values:")
        DisplayValues(intQueue)




        ' View the first element in the
        ' Queue but do not remove.
        Console.WriteLine("(Peek)   {0}", intQueue.Peek())

        ' Display the Queue.
        Console.WriteLine("intQueue values:")
        DisplayValues(intQueue)
    End Sub 'Main

End Module
