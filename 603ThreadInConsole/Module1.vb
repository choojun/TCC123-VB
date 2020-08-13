Imports System.IO
Imports System.Threading

Module Module1

    'Declare private member array size
    Dim ARRAY_ROW As Integer = 3
    Dim ARRAY_COL As Integer = 3

    'Declare 2-D Array
    Dim TwoDimDataArray(ARRAY_ROW - 1, ARRAY_COL - 1) As Integer
    Dim SumOfRowSums As Integer
    Dim SumOfColSums As Integer
    Sub Main()
        'Load the array data from a file using Stream Reader
        LoadFromFile()

        'Multithreading
        Dim thread1 As New Thread(AddressOf DisplayTableWithSum)
        Dim thread2 As New Thread(AddressOf DisplaySumOfRowSums)
        Dim thread3 As New Thread(AddressOf DisplaySumOfColSums)

        'Set Thread's priority

        'Threads start
        thread1.Start()
        thread2.Start()
        thread3.Start()

        'DisplayTableWithSum()
        'DisplaySumOfRowSums()
        'DisplaySumOfColSums()
        Console.ReadLine()
    End Sub

    Private Sub DisplaySumOfColSums()
        Console.WriteLine("The Sum of the Col Sums: " & SumOfColSums)
    End Sub

    Private Sub DisplaySumOfRowSums()
        Console.WriteLine("The Sum of the Row Sums: " & SumOfRowSums)
    End Sub

    Private Sub DisplayTableWithSum()

        Dim sumEachRow(TwoDimDataArray.GetUpperBound(0)) As Integer
        'Iterate through the array (x,y)
        '(0,0) (0,1) (0,2)...
        '(1,0) (1,1) (1,2)...
        '(2,0) (2,1) (2,2)...
        For r = 0 To TwoDimDataArray.GetUpperBound(0)
            'Nest through col y
            For c = 0 To TwoDimDataArray.GetUpperBound(1)
                'Sum each row
                sumEachRow(r) += TwoDimDataArray(r, c)
                Console.Write(TwoDimDataArray(r, c).ToString & " ")
            Next
            Console.Write("Sum: " & sumEachRow(r))
            Console.WriteLine("")
            'Sum Of Row Sums
            SumOfRowSums += sumEachRow(r)
        Next
        Console.WriteLine("Sum: ")
        'Sum for columns...

    End Sub

    'Typical diplay for 2-D array
    Private Sub DisplayTable()
        'Iterate through the array (x,y)
        '(0,0) (0,1) (0,2)...
        '(1,0) (1,1) (1,2)...
        '(2,0) (2,1) (2,2)...
        For index0 = 0 To TwoDimDataArray.GetUpperBound(0)
            'Nest through col y
            For index1 = 0 To TwoDimDataArray.GetUpperBound(1)
                Console.Write(TwoDimDataArray(index0, index1).ToString & " ")
            Next
            Console.WriteLine("")
        Next
    End Sub

    Private Sub LoadFromFile()
        'Create an instance of Stream Reader to read from a file
        Dim sr As StreamReader = New StreamReader("DataNumber.txt")
        'Line of text pointer variable
        Dim lineOfText As String
        Dim row As Integer = 0
        'Read and display the lines from the file until the end using a Do Loop Until
        Do
            'start the read
            lineOfText = sr.ReadLine()
            'Check for space split, if nothing exit
            If lineOfText Is Nothing Then
                Exit Do
            End If

            'Split the space with temp array
            Dim aryTextFile() As String
            aryTextFile = lineOfText.Split(" ")

            'Store then into array col
            For col = 0 To UBound(aryTextFile)
                TwoDimDataArray(row, col) = Convert.ToInt32(aryTextFile(col))
            Next

            row += 1

            'Loop until the Line of text pointer reads nothing (to the end of the file)
        Loop Until lineOfText Is Nothing
        sr.Close()
    End Sub

End Module
