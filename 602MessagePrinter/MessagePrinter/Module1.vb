Imports System.Threading

Module Module1

    Sub Main()
        ' create CMessagePrinter instances
        Dim printer1 As New MessagePrinter()
        Dim printer2 As New MessagePrinter()
        Dim printer3 As New MessagePrinter()

        ' Create each thread. Use CMessagePrinter's
        ' Print method as argument to ThreadStart delegate
        Dim thread1 As New Thread(AddressOf printer1.Print)
        Dim thread2 As New Thread(AddressOf printer2.Print)
        Dim thread3 As New Thread(AddressOf printer3.Print)

        ' name each thread
        thread1.Name = "thread1"
        thread2.Name = "thread2"
        thread3.Name = "thread3"

        Console.WriteLine("Starting threads")
        ' call each thread's Start method to place each
        ' thread in Started state
        thread1.Start()
        thread2.Start()
        thread3.Start()

        Console.WriteLine("Threads started" & vbCrLf)

        Console.ReadLine()
    End Sub

End Module
