' Fig. 21.32: Recommendations.aspx.vb
' Creates book recommendations based on a Session object.
Partial Class Recommendations
   Inherits System.Web.UI.Page

   ' read Session items and populate ListBox with any book recommendations
   Protected Sub Page_Init(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles Me.Init
      ' determine whether Session contains any information
      If Session.Count <> 0 Then
         For i As Integer = 0 To Session.Count - 1
            ' get current key name from Session object
            Dim keyName As String = Session.Keys(i)

            ' use keyName to display one of Session's name-value pairs
            booksListBox.Items.Add(keyName & _
               " How to Program. ISBN#: " & _
               Session(keyName).ToString())
         Next
      Else
         ' if there are no session items, no language was chosen, so
         ' display appropriate message and clear and hide booksListBox
         recommendationsLabel.Text = "No Recommendations"
         booksListBox.Items.Clear()
         booksListBox.Visible = False

         ' modify languageLink because no language was selected
         languageLink.Text = "Click here to choose a language"
      End If
   End Sub ' Page_Init
End Class ' Recommendations

