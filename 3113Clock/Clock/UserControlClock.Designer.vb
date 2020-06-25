<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlClock
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Me.lblClock = New System.Windows.Forms.Label
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblClock
        '
        Me.lblClock.Location = New System.Drawing.Point(3, 0)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(113, 101)
        Me.lblClock.TabIndex = 0
        Me.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrClock
        '
        Me.tmrClock.Enabled = True
        Me.tmrClock.Interval = 1000
        '
        'UserControlClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblClock)
        Me.Name = "UserControlClock"
        Me.Size = New System.Drawing.Size(117, 101)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblClock As System.Windows.Forms.Label
    Friend WithEvents tmrClock As System.Windows.Forms.Timer

End Class
