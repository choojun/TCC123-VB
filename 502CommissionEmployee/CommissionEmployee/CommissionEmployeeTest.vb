' CommissionEmployeeTest.vb
' Testing class CommissionEmployee.
Module CommissionEmployeeTest
    Sub Main()
        ' instantiate CommissionEmployee object
        Dim employee As New CommissionEmployee( _
           "Steven", "Phan", "999-99-9999", 500000, 0.06D)

        ' get commission employee data
        Console.WriteLine("Employee information obtained by properties:" _
           & vbCrLf & "First name is " & employee.FirstName & vbCrLf & _
           "Last name is " & employee.LastName & vbCrLf & _
           "IC Number is " & employee.IcNumber)
        Console.WriteLine("Gross sales is {0:C}", employee.GrossSales)
        Console.WriteLine("Commission rate is {0:F}", _
           employee.CommissionRate)

        employee.GrossSales = 100000 ' set gross sales
        employee.CommissionRate = 0.1D ' set commission rate to 10%

        ' get new employee information
        Console.WriteLine(vbCrLf & _
           "Updated employee information obtained by ToString: " & _
           vbCrLf & employee.ToString() & vbCrLf)

        ' display the employee's earnings
        Console.WriteLine("Employee's earnings: {0:C}", _
           employee.CalculateEarnings())
    End Sub
End Module