'frmListBox.vb
'To add, remove and clear the ListBox Items

Public Class frmListBox

    'Key in items in the txtSubject to the lstSubject
    'then clear textSubject
    Private Sub btnAdd_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnAdd.Click
        lstSubject.Items.Add(txtSubject.Text)
        txtSubject.Clear()
    End Sub

    'Remove an item from lstSubject if the item is selected
    Private Sub btnRemove_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnRemove.Click
        'If an item is selected, remove that item
        If lstSubject.SelectedIndex <> -1 Then
            lstSubject.Items.RemoveAt(lstSubject.SelectedIndex)
        End If
    End Sub

    'Clear all the items in lstSubject
    Private Sub btnClear_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnClear.Click
        lstSubject.Items.Clear()
    End Sub

    'Terminate the application
    Private Sub btnExit_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
