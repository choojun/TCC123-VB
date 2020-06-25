' StackTest.vb
' Demonstrating class Stack.
Imports System.Collections

Module StackTest
    Sub Main()
        Dim stack As New Stack() ' default Capacity of 10

        ' create objects to store in the stack
        Dim aBoolean As Boolean = True
        Dim aCharacter As Char = "$"
        Dim anInteger As Integer = 12345
        Dim aString As String = "Visual"

        ' use method Push to add items to (the top of) the stack
        stack.Push(aBoolean)
        PrintStack(stack)
        stack.Push(aCharacter)
        PrintStack(stack)
        stack.Push(anInteger)
        PrintStack(stack)
        stack.Push(aString)
        PrintStack(stack)

        ' check the top element of the stack
        Console.WriteLine("The top element of the stack is {0}" & _
           vbCrLf, stack.Peek())

        ' remove items from stack
        Try
            While True
                Dim removedObject As Object = stack.Pop()
                Console.WriteLine(removedObject & " popped")
                PrintStack(stack)
            End While
        Catch exception As InvalidOperationException
            ' if exception occurs, print stack trace
            Console.Error.WriteLine(exception)
        End Try
    End Sub ' Main

    ' print the contents of a stack
    Private Sub PrintStack(ByVal stack As Stack)
        If stack.Count = 0 Then
            ' the stack is empty
            Console.WriteLine("stack is empty" & vbCrLf)
        Else
            Console.Write("The stack is: ")

            ' iterate through the stack with a For Each statement
            For Each element As Object In stack
                Console.Write("{0} ", element) ' invokes ToString
            Next element

            Console.WriteLine(vbCrLf)
        End If
    End Sub
End Module