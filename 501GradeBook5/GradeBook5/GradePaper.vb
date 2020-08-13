Public Class GradePaper
    Inherits GradeBook

    'Method overloading means having two or more methods 
    'with the same name but different signatures
    Overloads Sub DisplayMessage()
        Console.WriteLine("I should be called modern GradePaper")
        'Apply encapsulation
        Me.forMyChildAccess = "Only child can access"
    End Sub

    'Polymorphism: share the same base class method
    'Method overriding: sometimes it is necessary for the
    'subclass to modify the methods defined the base class
    Public Overrides Function poly() As String
        Return "Fish - Swim"
    End Function

End Class
