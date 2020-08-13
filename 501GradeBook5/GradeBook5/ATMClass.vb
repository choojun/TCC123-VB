Public Class ATMClass
    Implements IAtm
    Dim m_balance As Decimal = 100

    Public Overridable Function Balance() As Decimal Implements IAtm.Balance
        Return m_balance
    End Function

    Public Sub DepositMoney(ByVal amount As Decimal) Implements IAtm.DepositMoney
        m_balance += amount
    End Sub

    Public Sub WithdrawMoney(ByVal amount As Decimal) Implements IAtm.WithdrawMoney
        m_balance -= amount
    End Sub


End Class
