' GradeBook.vb
' GradeBook class that contains instance variable courseNameValue
' and a property to get and set its value.
Public Class GradeBook
    ' course name for this GradeBook
    Private courseNameValue As String

    ' property CourseName
    Public Property CourseName() As String
        Get ' retrieve courseNameValue
            Return courseNameValue
        End Get

        ' set courseNameValue
        Set(ByVal value As String)
            ' store the course name in the object
            courseNameValue = value
        End Set
    End Property

    ' display a welcome message to the GradeBook user
    Public Sub DisplayMessage()
        ' use property CourseName to display the
        ' name of the course this GradeBook represents
        Console.WriteLine("Welcome to the grade book for " _
            & vbCrLf & CourseName & "!")
    End Sub
End Class