' Employee.vb
' Employee abstract base class.
Public MustInherit Class Employee
   Private firstNameValue As String
   Private lastNameValue As String
   Private socialSecurityNumberValue As String

   ' three-argument constructor
   Public Sub New(ByVal first As String, ByVal last As String, _
      ByVal ssn As String)
      FirstName = first
      LastName = last
      SocialSecurityNumber = ssn
   End Sub ' New

   ' property FirstName
   Public Property FirstName() As String
      Get
         Return firstNameValue
      End Get

      Set(ByVal first As String)
         firstNameValue = first
      End Set
   End Property ' FirstName

   ' property LastName
   Public Property LastName() As String
      Get
         Return lastNameValue
      End Get

      Set(ByVal last As String)
         lastNameValue = last
      End Set
   End Property ' LastName

   ' property SocialSecurityNumber
   Public Property SocialSecurityNumber() As String
      Get
         Return socialSecurityNumberValue
      End Get

      Set(ByVal ssn As String)
         socialSecurityNumberValue = ssn
      End Set
   End Property ' SocialSecurityNumber

   ' return String representation of Employee object
   Public Overrides Function ToString() As String
      Return (String.Format("{0} {1}", FirstName, LastName) & vbCrLf & _
         "social security number: " & SocialSecurityNumber)
   End Function ' ToString

   ' abstract method overridden by derived class
   Public MustOverride Function CalculateEarnings() As Decimal
End Class ' Employee

