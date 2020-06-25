' GradeBook.vb
' GradeBook class with a constructor to initialise the course name.
Public Class GradeBook
    ' course name for this GradeBook
    Private courseNameValue As String

    ' constructor initialises course name with String supplied as argument
    Public Sub New(ByVal name As String)
        CourseName = name ' initialise courseNameValue via property
    End Sub ' New

    ' property CourseName
    Public Property CourseName() As String
        Get ' retrieve courseNameValue
            Return courseNameValue
        End Get

        ' set courseNameValue
        Set(ByVal value As String)
            courseNameValue = value ' store the course name in the object
        End Set
    End Property ' CourseName

    ' display a welcome message to the GradeBook user
    Public Sub DisplayMessage()
        ' use property CourseName to display the
        ' name of the course this GradeBook represents
        Console.WriteLine("Welcome to the grade book for " _
            & vbCrLf & CourseName & "!")
    End Sub
End Class