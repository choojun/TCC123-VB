' GradeBookTest.vb
' GradeBook constructor used to specify the course name at the
' time each GradeBook object is created.
Module GradeBookTest

    Sub Main()
        ' create GradeBook object
        Dim gradeBook1 As New GradeBook(
           "TCC123/05 Visual Programming")
        Dim gradeBook2 As New GradeBook(
           "TCC128/05 Fundamental of Programming")

        ' display initial value of CourseName for each GradeBook
        Console.WriteLine( _
           "gradeBook1 course name is: " & gradeBook1.CourseName)
        Console.WriteLine( _
           "gradeBook2 course name is: " & gradeBook2.CourseName)
    End Sub
End Module