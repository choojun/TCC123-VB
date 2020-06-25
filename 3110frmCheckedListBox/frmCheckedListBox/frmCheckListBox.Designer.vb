<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChkLstBox
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
        Me.chkLstSubject = New System.Windows.Forms.CheckedListBox()
        Me.lstSubject = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'chkLstSubject
        '
        Me.chkLstSubject.FormattingEnabled = True
        Me.chkLstSubject.Items.AddRange(New Object() {"Visual Basic", "Java", "C", "Database"})
        Me.chkLstSubject.Location = New System.Drawing.Point(12, 24)
        Me.chkLstSubject.Name = "chkLstSubject"
        Me.chkLstSubject.Size = New System.Drawing.Size(120, 94)
        Me.chkLstSubject.TabIndex = 2
        '
        'lstSubject
        '
        Me.lstSubject.FormattingEnabled = True
        Me.lstSubject.Location = New System.Drawing.Point(147, 24)
        Me.lstSubject.Name = "lstSubject"
        Me.lstSubject.Size = New System.Drawing.Size(120, 95)
        Me.lstSubject.TabIndex = 1
        '
        'frmChkLstBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 144)
        Me.Controls.Add(Me.lstSubject)
        Me.Controls.Add(Me.chkLstSubject)
        Me.Name = "frmChkLstBox"
        Me.Text = "Course Enrollment"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkLstSubject As System.Windows.Forms.CheckedListBox
    Friend WithEvents lstSubject As System.Windows.Forms.ListBox

End Class
