Module GradeBookTest

    'Main begins program execution
    Sub Main()

        'initialize gradebook to a new object
        Dim gradeBook As New GradeBook()
        'call gradebook's DisplayMessage method
        gradeBook.DisplayMessage()

        'prompt user
        Console.Write("Please enter the course Name: ")
        'get the input
        Dim nameOfCourse As String = Console.ReadLine()
        Dim gradeBook2 As New GradeBook()
        gradeBook2.DisplayMessage(nameOfCourse)

        'Using property
        Dim gradeBook3 As New GradeBook()
        'invoke the Set Property
        gradeBook3.CourseName = nameOfCourse
        'invoke the Get Property
        gradeBook3.DisplayMessageUsingProperty()

        'default constructor
        Dim gradeBook4 As New GradeBook()
        'overload the constructor
        Dim gradeBook5 As New GradeBook("My class #5")
        gradeBook5.DisplayMessageUsingProperty()

        'initialize gradePaper to the Grade Paper object
        Dim gradePaper As New GradePaper()
        'call gradePaper's methods
        gradePaper.DisplayMessage()

        'assign gradePaper reference to the GradeBook object
        Dim gradeBook6 As GradeBook = gradePaper
        'invoke poly method on the gradePaper using the base class
        Console.WriteLine(gradeBook6.poly())

        'Test general ATM 
        Dim user As New ATMClass
        Dim userBalance As Decimal = user.Balance()
        Console.WriteLine("General balance check: " & userBalance)

        'Test ATM Penang
        Dim pgUser As New ATMPenang
        Dim pgUserBalance As Decimal = pgUser.Balance()
        Console.WriteLine("Penang balance check: " & pgUserBalance)

        Console.ReadLine()
    End Sub

End Module
