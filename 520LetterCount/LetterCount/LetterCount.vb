' LetterCount.vb
' Application counts the number of occurrences 
' of each letter in a string.
Imports System.Collections.Generic

Public Module LetterCount
    Public Sub Main()
        ' create sorted dictionary based on user input
        Dim dictionary As SortedDictionary(Of Char, Integer) = _
           CollectLetters()

        ' display sorted dictionary content
        DisplayDictionary(Dictionary)
    End Sub

    ' create sorted dictionary from user input
    Private Function CollectLetters() _
       As SortedDictionary(Of Char, Integer)

        ' create a new sorted dictionary
        Dim dictionary As New SortedDictionary(Of Char, Integer)()

        Console.WriteLine("Enter a string: ") ' prompt for user input
        Dim input As String = Console.ReadLine() ' get input
        input = input.ToLower() ' make string lowercase

        ' processing each character of the input
        For i As Integer = 0 To input.Length - 1
            Dim charKey As Char = input(i) ' get character at position i

            ' ensure that the character is a letter
            If Char.IsLetter(charKey) Then
                ' if the dictionary contains the letter
                If dictionary.ContainsKey(charKey) Then
                    dictionary(charKey) += 1
                Else
                    ' add new letter with a count of 1 to the dictionary
                    dictionary.Add(charKey, 1)
                End If
            End If
        Next

        Return dictionary
    End Function

    ' display dictionary content
    Private Sub DisplayDictionary(Of K, V)( _
       ByVal dictionary As SortedDictionary(Of K, V))

        Console.WriteLine(vbCrLf & "Sorted dictionary contains:" & _
           vbCrLf & "{0,-12}{1,-12}", "Key:", "Value:")

        ' generate output for each key in the sorted dictionary
        ' by iterating through the Keys property with a foreach statement
        For Each key As K In dictionary.Keys
            Console.WriteLine("{0,-12}{1,-12}", key, dictionary(key))
        Next

        Console.WriteLine(vbCrLf & "size: {0}", dictionary.Count)
    End Sub
End Module
