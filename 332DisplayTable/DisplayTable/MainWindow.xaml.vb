Class MainWindow
    Dim database As New BooksDataContext
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs) Handles MyBase.Loaded

        Dim BooksDataSet As DisplayTable.BooksDataSet = CType(Me.FindResource("BooksDataSet"), DisplayTable.BooksDataSet)
        'Load data into the table Authors. You can modify this code as needed.
        Dim BooksDataSetAuthorsTableAdapter As DisplayTable.BooksDataSetTableAdapters.AuthorsTableAdapter = New DisplayTable.BooksDataSetTableAdapters.AuthorsTableAdapter()
        BooksDataSetAuthorsTableAdapter.Fill(BooksDataSet.Authors)
        Dim AuthorsViewSource As System.Windows.Data.CollectionViewSource = CType(Me.FindResource("AuthorsViewSource"), System.Windows.Data.CollectionViewSource)
        AuthorsViewSource.View.MoveCurrentToFirst()
    End Sub


End Class
