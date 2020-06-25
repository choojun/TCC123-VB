' Solution: Employee.vb
' Employee class declaration.
Public Class Employee
    Private firstNameValue As String ' first name of employee
    Private lastNameValue As String ' last name of employee
    Private monthlySalaryValue As Integer ' monthly salary of employee

    ' constructor initializes first name, last name and monthly salary
    Public Sub New(ByVal first As String, ByVal last As String, _
       ByVal salary As Integer)
        FirstName = first
        LastName = last
        MonthlySalary = salary
    End Sub ' New

    ' property that gets and sets the employee's first name;
    ' no validation necessary
    Public Property FirstName() As String
        Get ' retrieve firstNameValue
            Return firstNameValue
        End Get

        Set(ByVal value As String) ' set firstNameValue
            firstNameValue = value
        End Set
    End Property ' FirstName

    ' property that gets and sets the employee's last name;
    ' no validation necessary
    Public Property LastName() As String
        Get ' retrieve lastNameValue
            Return lastNameValue
        End Get

        Set(ByVal value As String) ' set lastNameValue
            lastNameValue = value
        End Set
    End Property ' LastName

    ' property that gets and sets the employee's monthly salary; the Set
    ' accessor ensures that the monthly salary is positive
    Public Property MonthlySalary() As Integer
        Get ' retrieve monthlySalaryValue
            Return monthlySalaryValue
        End Get

        Set(ByVal value As Integer) ' set monthlySalaryValue
            If value >= 0 Then ' if salary is positive
                monthlySalaryValue = value
            End If
        End Set
    End Property ' MonthlySalary
End Class ' Employee
