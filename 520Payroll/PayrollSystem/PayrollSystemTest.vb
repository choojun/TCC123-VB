' PayrollSystemTest.vb
' Employee hierarchy test program.
Module PayrollSystemTest
   Sub Main()
      ' create derived-class objects
      Dim salariedEmployee As New SalariedEmployee( _
         "John", "Smith", "111-11-1111", 800)
      Dim hourlyEmployee As New HourlyEmployee( _
         "Karen", "Price", "222-22-2222", 16.75D, 40)
      Dim commissionEmployee As New CommissionEmployee( _
         "Sue", "Jones", "333-33-3333", 10000, 0.06D)
      Dim basePlusCommissionEmployee As New BasePlusCommissionEmployee( _
         "Bob", "Lewis", "444-44-4444", 5000, 0.04D, 300)

      ' display each employee's info non-polymorphically
      Console.WriteLine("Employees processed individually:" & vbCrLf)
      Console.WriteLine(salariedEmployee.ToString() & vbCrLf & _
         String.Format("earned: {0:C}", _
         salariedEmployee.CalculateEarnings()) & vbCrLf)
      Console.WriteLine(hourlyEmployee.ToString() & vbCrLf & _
         String.Format("earned: {0:C}", _
         hourlyEmployee.CalculateEarnings()) & vbCrLf)
      Console.WriteLine(commissionEmployee.ToString() & vbCrLf & _
         String.Format("earned: {0:C}", _
         commissionEmployee.CalculateEarnings()) & vbCrLf)
      Console.WriteLine(basePlusCommissionEmployee.ToString() & _
         vbCrLf & String.Format("earned: {0:C}", _
         basePlusCommissionEmployee.CalculateEarnings()) & vbCrLf)

      ' create four-element Employee array
      Dim employees() As Employee = {salariedEmployee, hourlyEmployee, _
         commissionEmployee, basePlusCommissionEmployee}

      Console.WriteLine("Employees processed polymorphically:" & vbCrLf)

      ' polymorphically process each element in array employees
      For Each currentEmployee As Employee In employees
         Console.WriteLine(currentEmployee.ToString())

         ' determine if currentEmployee is a BasePlusCommissionEmployee
         If (TypeOf currentEmployee Is BasePlusCommissionEmployee) Then

            ' downcast Employee reference to BasePlusCommissionEmployee
            Dim employee As BasePlusCommissionEmployee = _
               TryCast(currentEmployee, BasePlusCommissionEmployee)

            employee.BaseSalary *= 1.1D
            Console.WriteLine(String.Format( _
               "new base salary with 10% increase is: {0:C}", _
               employee.BaseSalary))
         End If

         Console.Write(String.Format("earned {0:C}", _
            currentEmployee.CalculateEarnings()) & vbCrLf & vbCrLf)
      Next

      ' get type name of each object in employees array
      For i As Integer = 0 To employees.Length - 1
         Console.WriteLine(String.Format("Employee {0} is a {1}", _
            i, employees(i).GetType().FullName))
      Next
   End Sub ' Main
End Module ' PayrollSystemTest
