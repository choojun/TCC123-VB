' QueueTest.vb
' Testing class QueueInheritance.
Imports QueueInheritanceLibrary
Imports LinkedListLibrary

' demonstrate functionality of class QueueInheritance
Module QueueTest
    Sub Main()
        Dim queue As New QueueInheritance()

        ' create objects to store in the stack
        Dim aBoolean As Boolean = True
        Dim aCharacter As Char = "$"
        Dim anInteger As Integer = 12345
        Dim aString As String = "hello"

        ' use method Enqueue to add items to queue
        queue.Enqueue(aBoolean)
        queue.Print()
        queue.Enqueue(aCharacter)
        queue.Print()
        queue.Enqueue(anInteger)
        queue.Print()
        queue.Enqueue(aString)
        queue.Print()

        ' use method Dequeue to remove items from queue
        Dim removedObject As Object = Nothing

        ' remove items from queue
        Try
            While True
                removedObject = queue.Dequeue()
                Console.WriteLine(removedObject & " dequeued")
                queue.Print()
            End While
        Catch exception As EmptyListException
            ' if exception occurs, print stack trace
            Console.Error.WriteLine(exception.StackTrace)
        End Try
    End Sub ' Main
End Module ' QueueTest

