' GradeBookTest.vb
' Create a GradeBook object and call its DisplayMessage method.
Module GradeBookTest
    ' Main program 
    Sub Main()
        ' initialize gradeBook to reference a new gradeBook object
        Dim gradeBook As New GradeBook

        ' prompt to input course name
        Console.Write("Please enter the course name: ")

        ' read the course name
        Dim nameOfCourse As String = Console.ReadLine()

        Console.WriteLine() ' display a blank line

        ' call gradeBook's DisplayMessage method
        ' and pass nameOfCourse as an argument
        gradeBook.DisplayMessage(nameOfCourse)
    End Sub
End Module