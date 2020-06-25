' BasePlusCommissionEmployee.vb
' BasePlusCommissionEmployee class inherits CommissionEmployee.
Public Class BasePlusCommissionEmployee
   Inherits CommissionEmployee

   Private baseSalaryValue As Decimal ' base salary

   ' six-argument constructor
   Public Sub New(ByVal first As String, ByVal last As String, _
      ByVal ssn As String, ByVal sales As Decimal, _
      ByVal rate As Decimal, ByVal salary As Decimal)
      MyBase.New(first, last, ssn, sales, rate)
      BaseSalary = salary
   End Sub ' New

   ' property BaseSalary
   Public Property BaseSalary() As Decimal
      Get
         Return baseSalaryValue
      End Get

      Set(ByVal salary As Decimal)
         If salary < 0 Then ' validate salary
            baseSalaryValue = 0
         Else
            baseSalaryValue = salary
         End If
      End Set
   End Property ' BaseSalary

   ' calculate earnings; override method CalculateEarnings 
   Public Overrides Function CalculateEarnings() As Decimal
      Return BaseSalary + MyBase.CalculateEarnings()
   End Function ' CalculateEarnings

   ' return String representation of BasePlusCommissionEmployee object
   Public Overrides Function ToString() As String
      Return ("base-salaried " & MyBase.ToString() & _
         String.Format("; base salary: {0:C}", BaseSalary))
   End Function ' ToString
End Class ' BasePlusCommissionEmployee
