' HourlyEmployee.vb
' HourlyEmployee class inherits Employee.
Public Class HourlyEmployee
   Inherits Employee

   Private wageValue As Decimal ' wage per hour
   Private hoursValue As Decimal ' hours worked for week

   ' five-argument constructor
   Public Sub New(ByVal first As String, ByVal last As String, _
      ByVal ssn As String, ByVal hourlyWage As Decimal, _
      ByVal hoursWorked As Decimal)
      MyBase.New(first, last, ssn) ' pass to Employee constructor
      Wage = hourlyWage ' validate and store hourly wage
      Hours = hoursWorked ' validate and store hours worked
   End Sub ' New

   ' property Wage
   Public Property Wage() As Decimal
      Get
         Return wageValue
      End Get

      Set(ByVal hourlyWage As Decimal)
         If hourlyWage < 0 Then ' validate hourly wage
            wageValue = 0
         Else
            wageValue = hourlyWage
         End If
      End Set
   End Property ' Wage

   ' property Hours
   Public Property Hours() As Decimal
      Get
         Return hoursValue
      End Get

      Set(ByVal hoursWorked As Decimal)
         If (hoursWorked >= 0.0) AndAlso (hoursWorked <= 168.0) Then
            hoursValue = hoursWorked ' valid weekly hours
         Else
            hoursValue = 0
         End If
      End Set
   End Property ' Hours

   ' calculate earnings; override abstract method CalculateEarnings
   Public Overrides Function CalculateEarnings() As Decimal
      If Hours <= 40 Then ' no overtime
         Return Wage * Hours
      Else
         Return 40 * Wage + ((Hours - 40) * Wage * 1.5D)
      End If
   End Function ' CalculateEarnings

   ' return String representation of HourlyEmployee object
   Public Overrides Function ToString() As String
      Return ("hourly employee: " & MyBase.ToString() & vbCrLf & _
         String.Format("hourly wage: {0:C}; hours worked: {1}", _
         Wage, Hours))
   End Function ' ToString
End Class ' HourlyEmployee

