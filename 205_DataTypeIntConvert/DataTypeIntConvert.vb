Module DataTypeIntConvert

	Sub Main()
		Dim number As String = ""
		Console.WriteLine("Before conversion, the string representation of number Is " & number)
		System.Console.Write("Enter a number:")
		'Converts the specified String representation of 
		'a number to an equivalent 64-bit signed integer
		number = System.Convert.ToInt64(Console.ReadLine())
		number = number + 1
		Console.WriteLine("")
		Console.WriteLine("After conversion, the integer value after calculation Is " & number)
	End Sub
End Module
