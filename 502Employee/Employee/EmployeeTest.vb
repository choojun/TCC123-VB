' EmployeeTest.vb
' Application to test class Employee.
Module EmployeeTest
    ' Main begins program execution
    Sub Main()
        ' create Employee objects
        Dim emp1 As New Employee("Steven", "Phan", 5000)
        Dim emp2 As New Employee("Jennifer", "Low", 8000)

        ' display employees
        Console.WriteLine("Employee 1: " & emp1.FirstName & " " & _
           emp1.LastName & "; Yearly Salary: " & _
           12 * emp1.MonthlySalary)
        Console.WriteLine("Employee 2: " & emp2.FirstName & " " & _
           emp2.LastName & "; Yearly Salary: " & _
           12 * emp2.MonthlySalary)

        ' increase employee salaries by 10%
        Console.WriteLine(vbCrLf & "Increasing employee salaries by 10%")
        emp1.MonthlySalary = emp1.MonthlySalary * 1.1
        emp2.MonthlySalary = emp2.MonthlySalary * 1.1

        ' display employees with new yearly salary
        Console.WriteLine("Employee 1: " & emp1.FirstName & " " & _
           emp1.LastName & "; Yearly Salary: " & _
           12 * emp1.MonthlySalary)
        Console.WriteLine("Employee 2: " & emp2.FirstName & " " & _
           emp2.LastName & "; Yearly Salary: " & _
           12 * emp2.MonthlySalary)
    End Sub
End Module