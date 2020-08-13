Public Interface IAtm

    Sub WithdrawMoney(ByVal amount As Decimal)
    Sub DepositMoney(ByVal amount As Decimal)
    Function Balance() As Decimal

End Interface
