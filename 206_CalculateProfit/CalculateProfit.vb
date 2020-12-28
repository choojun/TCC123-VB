Module CalculateProfit

    Sub Main()
        Dim revenue, costs, profits As Double
        Dim unitPrice As Double = 2.0
        Dim quantity As Integer = 10
        costs = unitPrice * quantity
        revenue = 40.0
        profits = revenue - costs

        System.Console.WriteLine("Profit of WOU Sdn. Bhd.: " & profits)
        System.Console.ReadLine()
    End Sub

End Module
