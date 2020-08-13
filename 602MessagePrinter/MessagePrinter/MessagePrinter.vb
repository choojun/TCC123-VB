' Thread control method prints verbose message,
' sleeps and prints waking up verbose message.
Imports System.Threading
Public Class MessagePrinter
    Private sleepTime As Integer
    Private Shared randomObject As New Random()

    ' constructor to initialize a CMessagePrinter object
    Public Sub New()
        ' pick random sleep time between 0 and 5 seconds
        sleepTime = randomObject.Next(5001)
    End Sub ' New

    ' method Print controls thread that prints messages
    Public Sub Print()
        ' obtain reference to currently executing thread
        Dim current As Thread = Thread.CurrentThread

        ' put thread to sleep for sleepTime amount of time
        Console.WriteLine(current.Name & " going to sleep for " & sleepTime)

        Thread.Sleep(sleepTime)

        ' print thread name
        Console.WriteLine(current.Name & " awake (done sleeping)!")
    End Sub ' Print
End Class
