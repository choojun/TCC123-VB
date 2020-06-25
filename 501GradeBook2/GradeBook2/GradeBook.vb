' GradeBook.vb
' Class declaration with a method that has a parameter.
Public Class GradeBook
    ' display a welcome message to the GradeBook user
    Public Sub DisplayMessage(ByVal courseName As String)
        Console.WriteLine( _
           "Welcome to the grade book for " & courseName & "!")
    End Sub
End Class