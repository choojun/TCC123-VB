' Validation.aspx.vb
' Code-behind file for the form demonstrating validation controls.
Partial Class Validation
   Inherits System.Web.UI.Page

   ' Page_Load event handler executes when the page is loaded
   Protected Sub Page_Load(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles Me.Load
      ' if this is not the first time the page is loading
      ' (i.e., the user has already submitted form data)
      If IsPostBack Then
         ' validate the form
         Validate()
         If IsValid Then
            ' retrieve the values submitted by the user
            Dim name As String = nameTextBox.Text
            Dim email As String = emailTextBox.Text
            Dim phone As String = phoneTextBox.Text

            ' create a table indicating the submitted values
            outputLabel.Text &= _
               "<br />We received the following information:" & _
               "<table style=""background-color: yellow"">" & _
               "<tr><td>Name: </td><td>" & name & "</td></tr>" & _
               "<tr><td>E-mail address: </td>" & _
               "<td>" & email & "</td></tr>" & _
               "<tr><td>Phone number: </td>" & _
               "<td>" & phone & "</td></tr>" & _
               "<table>"
            outputLabel.Visible = True ' display the output message
         End If
      End If
   End Sub ' Page_Load
End Class ' Validation

