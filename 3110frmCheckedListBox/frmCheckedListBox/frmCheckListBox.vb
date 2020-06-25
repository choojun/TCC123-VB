'frmCheckListBox.vb
'Using the checked ListBox to add items to a display ListBox

Public Class frmChkLstBox

    ' add an item to or remove an item from lstSubject
    Private Sub chklstSubject_ItemCheck(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.ItemCheckEventArgs) _
    Handles chkLstSubject.ItemCheck

        ' obtain selected item
        Dim item As String = chkLstSubject.SelectedItem.ToString()

        ' if the selected item is checked, add to lstSubject
        ' else, remove it from lstSubject
        If e.NewValue = CheckState.Checked Then
            lstSubject.Items.Add(item)
        Else
            lstSubject.Items.Remove(item)
        End If
    End Sub
End Class
