<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UserControlClock1 = New Clock.UserControlClock
        Me.SuspendLayout()
        '
        'UserControlClock1
        '
        Me.UserControlClock1.Location = New System.Drawing.Point(43, 25)
        Me.UserControlClock1.Name = "UserControlClock1"
        Me.UserControlClock1.Size = New System.Drawing.Size(117, 101)
        Me.UserControlClock1.TabIndex = 0
        '
        'frmClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(209, 161)
        Me.Controls.Add(Me.UserControlClock1)
        Me.Name = "frmClock"
        Me.Text = "Clock"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UserControlClock1 As Clock.UserControlClock

End Class
