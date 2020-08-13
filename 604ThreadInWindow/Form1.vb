Imports System.IO

Public Class myForm

    'Declare private member array size
    Dim ARRAY_ROW As Integer = 3
    Dim ARRAY_COL As Integer = 3

    'Declare 2-D Array
    Dim TwoDimDataArray(ARRAY_ROW - 1, ARRAY_COL - 1) As Integer
    Dim SumOfRowSums As Integer
    Dim SumOfColSums As Integer
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'Load the array data from a file using Stream Reader
        LoadFromFile()

        Dim sumEachRow(TwoDimDataArray.GetUpperBound(0)) As Integer

        Dim Height As Integer = TwoDimDataArray.GetUpperBound(0) + 1
        Dim Width As Integer = TwoDimDataArray.GetUpperBound(1) + 1

        'To add sum column
        Me.myDataGridView.ColumnCount = Width + 1

        'Iterate through the array (x,y)
        '(0,0) (0,1) (0,2)...
        '(1,0) (1,1) (1,2)...
        '(2,0) (2,1) (2,2)...
        For r = 0 To TwoDimDataArray.GetUpperBound(0)
            'create data grid view row
            Dim dgvrow As DataGridViewRow = New DataGridViewRow()
            dgvrow.CreateCells(Me.myDataGridView)

            'Nest through col y
            For c = 0 To TwoDimDataArray.GetUpperBound(1)
                dgvrow.Cells(c).Value = TwoDimDataArray(r, c)

                'Sum each row
                sumEachRow(r) += TwoDimDataArray(r, c)

            Next
            myDataGridView.Columns(Width).HeaderText = "Sum"
            dgvrow.Cells(Width).Value = sumEachRow(r)
            'format bold
            dgvrow.Cells(Width).Style.Font = New Font(Control.DefaultFont, FontStyle.Bold)
            Me.myDataGridView.Rows.Add(dgvrow)

            'Sum Of Row Sums
            SumOfRowSums += sumEachRow(r)
        Next

        'Resize column
        Me.myDataGridView.AutoResizeColumns()
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

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        txtSumRowSums.Text = SumOfRowSums
        txtSumColSums.Text = SumOfColSums
    End Sub
End Class
