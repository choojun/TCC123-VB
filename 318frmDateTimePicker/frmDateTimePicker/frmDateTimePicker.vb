'frmDateTimePicker.vb
'To select a drop off date

Public Class frmDateTimePicker
    ' set DateTimePicker's MinDate and MaxDate properties

    Private Sub frmDateTimePicker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' user cannot select days before today
        dteDateTimePicker.MinDate = DateTime.Today

        ' user can select days up to one month from now
        dteDateTimePicker.MaxDate = DateTime.Today.AddMonths(1)
    End Sub

    ' display delivery date
    Private Sub dteDateTimePicker_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dteDateTimePicker.ValueChanged
        Dim dropDate As DateTime = dteDateTimePicker.Value

        ' add an extra day when items are dropped off Friday-Sunday
        If dropDate.DayOfWeek = DayOfWeek.Friday Or _
           dropDate.DayOfWeek = DayOfWeek.Saturday Or _
           dropDate.DayOfWeek = DayOfWeek.Sunday Then
            ' estimate seven days for delivery
            lblMessage.Text = dropDate.AddDays(7).ToLongDateString()
        Else ' otherwise estimate only four days for delivery
            lblMessage.Text = dropDate.AddDays(4).ToLongDateString()
        End If
    End Sub
End Class
