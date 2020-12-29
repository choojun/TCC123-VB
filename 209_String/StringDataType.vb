Imports System.Windows.Forms

Module StringDataType
    Sub Main()
        Dim stringOne, stringTwo, stringOutput As String
        stringOne = "Welcome to"
        stringTwo = " Visual Programming"
        stringOutput = stringOne + stringTwo
        MessageBox.Show("The string is : " & stringOutput, "Concatenation")

        System.Console.Write("Enter first name: ")
        stringOne = Console.ReadLine()
        System.Console.Write("Enter last name: ")
        stringTwo = Console.ReadLine()
        stringOutput = stringOne + " " + stringTwo
        MessageBox.Show("My name is : " & stringOutput, "Concatenation")

        Dim hPhoneNumber As String
        hPhoneNumber = "012-3456789"
        MessageBox.Show("Telephone number is: " & hPhoneNumber)

        Dim msg As String
        msg = "Visual Programming Is fun"
        MessageBox.Show(msg & "!")

        Dim myMsg As String
        myMsg = "Visual Programming is fun"
        MessageBox.Show(myMsg)



        stringOne = "Hello World"

        ' return the length of a string
        System.Console.WriteLine("The length of stringOne is " _
                & stringOne.Length & " characters")
        ' return the first 5 characters
        System.Console.WriteLine("The first 5 characters are " _
                & stringOne.Substring(0, 5))
        ' Find the index location of l
        System.Console.WriteLine("The first 'l' located at index " _
                & stringOne.IndexOf("l"))
        ' Replace the 'Hello' to 'Goodbye'
        System.Console.WriteLine("The Hello replaced by " _
                & stringOne.Replace("Hello", "Goodbye"))
        ' Convert 'Hello World' to uppercase
        System.Console.WriteLine("The Hello World in uppercase " _
                & stringOne.ToUpper())
        ' Convert 'Hello World' to lowercase
        System.Console.WriteLine("The Hello World in lowercase " _
                & stringOne.ToLower())
        ' Determines whether a string contains a specific substring
        Console.WriteLine("stringOne contains the letter r?: {0}",
                stringOne.Contains("r"))

    End Sub
End Module
