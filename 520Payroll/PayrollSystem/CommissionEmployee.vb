' CommissionEmployee.vb
' CommissionEmployee class inherits Employee.
Public Class CommissionEmployee
   Inherits Employee

   Private grossSalesValue As Decimal
   Private commissionRateValue As Decimal

   ' five-argument constructor
   Public Sub New(ByVal first As String, ByVal last As String, _
      ByVal ssn As String, ByVal sales As Decimal, ByVal rate As Decimal)
      MyBase.New(first, last, ssn) ' pass to Employee constructor
      GrossSales = sales ' validate and store gross sales
      CommissionRate = rate ' validate and store commission rate
   End Sub ' New

   ' property GrossSales
   Public Property GrossSales() As Decimal
      Get
         Return grossSalesValue
      End Get

      Set(ByVal sales As Decimal)
         If sales < 0 Then ' validate gross sales
            grossSalesValue = 0
         Else
            grossSalesValue = sales
         End If
      End Set
   End Property ' GrossSales

   ' property CommissionRate
   Public Property CommissionRate() As Decimal
      Get
         Return commissionRateValue
      End Get

      Set(ByVal rate As Decimal)
         If rate > 0.0 AndAlso rate < 1.0 Then ' validate commission rate
            commissionRateValue = rate
         Else
            commissionRateValue = 0
         End If
      End Set
   End Property ' CommissionRate

   ' calculate earnings; override abstract method CalculateEarnings
   Public Overrides Function CalculateEarnings() As Decimal
      Return CommissionRate * GrossSales
   End Function ' CalculateEarnings

   ' return String representation of CommissionEmployee object
   Public Overrides Function ToString() As String
      Return ("commission employee: " & MyBase.ToString() & vbCrLf & _
         String.Format("gross sales: {0:C}; commission rate: {1}", _
         GrossSales, CommissionRate))
   End Function ' ToString
End Class ' CommissionEmployee

