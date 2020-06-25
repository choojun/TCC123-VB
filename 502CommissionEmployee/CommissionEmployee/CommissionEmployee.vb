' CommmissionEmployee.vb
' CommissionEmployee class represents a commission employee.
Public Class CommissionEmployee
    Inherits Object ' optional

    Private firstNameValue As String ' first name
    Private lastNameValue As String ' last name
    Private icNumberValue As String ' social security number
    Private grossSalesValue As Decimal ' gross weekly sales
    Private commissionRateValue As Decimal ' commission percentage

    ' five-argument constructor
    Public Sub New(ByVal first As String, ByVal last As String, _
       ByVal ssn As String, ByVal sales As Decimal, ByVal rate As Decimal)

        ' implicit call to Object constructor occurs here
        FirstName = first
        LastName = last
        IcNumber = ssn
        GrossSales = sales ' validate and store gross sales
        CommissionRate = rate ' validate and store commission rate
    End Sub ' New

    ' property FirstName
    Public Property FirstName() As String
        Get
            Return firstNameValue
        End Get

        Set(ByVal first As String)
            firstNameValue = first ' no validation
        End Set
    End Property ' FirstName

    ' property LastName
    Public Property LastName() As String
        Get
            Return lastNameValue
        End Get

        Set(ByVal last As String)
            lastNameValue = last ' no validation
        End Set
    End Property ' LastName

    ' property IcNumber
    Public Property IcNumber() As String
        Get
            Return IcNumberValue
        End Get

        Set(ByVal ic As String)
            IcNumberValue = ic ' no validation
        End Set
    End Property ' IcNumber

    ' property GrossSales
    Public Property GrossSales() As Decimal
        Get
            Return grossSalesValue
        End Get

        Set(ByVal sales As Decimal)
            If sales < 0.0 Then ' validate gross sales
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
            If rate > 0.0 AndAlso rate < 1.0 Then ' validate rate
                commissionRateValue = rate
            Else
                commissionRateValue = 0
            End If
        End Set
    End Property ' CommissionRate

    ' calculate earnings
    Public Function CalculateEarnings() As Decimal
        Return commissionRateValue * grossSalesValue
    End Function ' CalculateEarnings

    ' return String representation of CommissionEmployee object
    Public Overrides Function ToString() As String
        Return ("commission employee: " & firstNameValue & " " & _
           lastNameValue & vbCrLf & "IC number: " & _
           IcNumberValue & vbCrLf & "gross sales: " & _
           String.Format("{0:C}", grossSalesValue) & vbCrLf & _
           "commission rate: " & String.Format("{0:F}", _
           commissionRateValue))
    End Function ' ToString
End Class ' CommissionEmployee