' GradeBookTest.vb
' Create and manipulate a GradeBook object.
Module GradeBookTest

    Sub Main()
        ' line 8 creates a GradeBook object that is referenced by 
        ' variable gradeBook of type GradeBook
        Dim gradeBook As New GradeBook

        ' display initial value of property CourseName (invokes Get)
        Console.WriteLine( _
           "Initial course name is: " & gradeBook.CourseName & vbCrLf)

        ' Enter course name
        Console.Write("Please enter the course name: ")

        ' read course name
        Dim theName As String = Console.ReadLine()

        gradeBook.CourseName = theName ' set the CourseName (invokes Set)
        Console.WriteLine()

        ' display welcome message including the course name (invokes Get)
        gradeBook.DisplayMessage()
    End Sub
End Module