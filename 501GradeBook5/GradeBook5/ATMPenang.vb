Imports Tutorial5

Public Class ATMPenang
    Inherits ATMClass

    Public Overrides Function Balance() As Decimal
        Return MyBase.Balance() - 0.5F
    End Function


End Class
