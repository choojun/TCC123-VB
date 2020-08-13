Public Class GradeBook

    'display a welcome message to the gradebook user
    Public Sub DisplayMessage()
        Console.WriteLine("Welcome to the Grade Book, 3VIS1")
    End Sub

    'display welcome message with a parameter
    Public Sub DisplayMessage(ByVal courseName As String)
        Console.WriteLine("Welcome to the Grade Book, " & courseName)
    End Sub

    '1. private member
    Private courseNameValue As String
    Public Property CourseName() As String
        '2. Get by retrieve the private member
        Get
            Return courseNameValue
        End Get
        '3. Set the private member
        Set(value As String)
            courseNameValue = value
        End Set
    End Property

    'display the welcome message that use property
    Public Sub DisplayMessageUsingProperty()
        Console.WriteLine("Welcome to the Grade Book property, " & CourseName)
    End Sub

    'default constructor
    Public Sub New()
        'enter to do something from start
        'Console.WriteLine("first thing first")
    End Sub

    'overload constructor to initialize course name with String arg
    Public Sub New(ByVal name As String)
        CourseName = name
    End Sub

    ''Encapsulation: protected member to share with derived class
    Protected forMyChildAccess As String

    'Polymorphism
    Public Overridable Function poly() As String
        Return "General Move"
    End Function

End Class
