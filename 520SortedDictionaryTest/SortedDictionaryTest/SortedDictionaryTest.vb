' SortedDictionaryTest.vb
' Counts the number of each word in a String
' and stores them in a generic sorted dictionary.
Imports System.Text.RegularExpressions
Imports System.Collections.Generic

Module StoredDictionaryTest
    Sub Main()
        ' create sorted dictionary 
        Dim dictionary As SortedDictionary(Of String, Integer) = _
           CollectWords()

        ' display sorted dictionary content
        DisplayDictionary(dictionary)
    End Sub

    ' create sorted dictionary 
    Private Function CollectWords() As SortedDictionary(Of String, Integer)
        ' create a new sorted dictionary
        Dim dictionary As New SortedDictionary(Of String, Integer)()

        Console.Write("Enter a string: ")
        Dim input As String = Console.ReadLine()

        ' split input text into tokens
        Dim words As String() = Regex.Split(input, "\s+")

        ' processing input words
        For Each word As String In words
            Dim wordKey As String = word.ToLower() ' get word in lowercase

            ' if the dictionary contains the word
            If dictionary.ContainsKey(wordKey) Then
                dictionary(wordKey) += 1
            Else
                ' add new word with a count of 1 to the dictionary
                dictionary.Add(wordKey, 1)
            End If
        Next

        Return dictionary
    End Function

    ' display dictionary content
    Private Sub DisplayDictionary(Of K, V)( _
       ByVal dictionary As SortedDictionary(Of K, V))

        Console.WriteLine(vbCrLf & "Sorted dictionary contains:" _
           & vbCrLf & "{0,-12}{1,-12}", "Key:", "Value:")

        ' generate output for each key in the sorted dictionary
        ' by iterating through the Keys property with a For Each statement
        For Each key As K In dictionary.Keys
            Console.WriteLine("{0,-12}{1,-12}", key, dictionary(key))
        Next

        Console.WriteLine(vbCrLf & "size: {0}", dictionary.Count)
    End Sub
End Module