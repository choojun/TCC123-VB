' Guestbook.aspx.vb
' Code-behind file that defines event handlers for the guestbook.
Partial Class Guestbook
   Inherits System.Web.UI.Page

   ' Submit Button adds a new guestbook entry to the database,
   ' clears the form and displays the updated list of guestbook entries
   Protected Sub submitButton_Click(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles submitButton.Click

      ' create dictionary of parameters for inserting
      Dim insertParameters As New ListDictionary()

      ' add current date and the user's name, e-mail address and message
      ' to dictionary of insert parameters                              
      insertParameters.Add("Date", Date.Now.ToShortDateString())
      insertParameters.Add("Name", nameTextBox.Text)
      insertParameters.Add("Email", emailTextBox.Text)
      insertParameters.Add("Message", messageTextBox.Text)

      ' execute an INSERT LINQ statement to add a new entry to the      
      ' Messages table in the Guestbook data context that contains the  
      ' current date and the user's name, e-mail address and message    
      messagesLinqDataSource.Insert(InsertParameters)

      ' clear the TextBoxes
      nameTextBox.Text = String.Empty
      emailTextBox.Text = String.Empty
      messageTextBox.Text = String.Empty

      ' update the GridView with the new database table contents
      messagesGridView.DataBind()
   End Sub ' submitButton_Click

   ' Clear Button clears the Web Form's TextBoxes
   Protected Sub clearButton_Click(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles clearButton.Click
      nameTextBox.Text = String.Empty
      emailTextBox.Text = String.Empty
      messageTextBox.Text = String.Empty
   End Sub ' clearButton_Click
End Class ' Guestbook

