' SalariedEmployee.vb
' SalariedEmployee class inherits Employee
Public Class SalariedEmployee
   Inherits Employee

   Private weeklySalaryValue As Decimal ' employee's weekly salary

   ' four-argument constructor
   Public Sub New(ByVal first As String, ByVal last As String, _
      ByVal ssn As String, ByVal salary As Decimal)
      MyBase.New(first, last, ssn) ' pass to Employee constructor
      WeeklySalary = salary ' validate and store salary
   End Sub ' New

   ' property WeeklySalary
   Public Property WeeklySalary() As Decimal
      Get
         Return weeklySalaryValue
      End Get

      Set(ByVal salary As Decimal)
         If salary < 0.0 Then ' validate salary
            weeklySalaryValue = 0
         Else
            weeklySalaryValue = salary
         End If
      End Set
   End Property ' WeeklySalary

   ' calculate earnings; override abstract method CalculateEarnings
   Public Overrides Function CalculateEarnings() As Decimal
      Return WeeklySalary
   End Function ' CalculateEarnings

   ' return String representation of SalariedEmployee object
   Public Overrides Function ToString() As String
      Return ("salaried employee: " & MyBase.ToString() & vbCrLf & _
         String.Format("weekly salary {0:C}", WeeklySalary))
   End Function ' ToString
End Class ' SalariedEmployee

