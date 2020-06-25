<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRadioButton
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
        Me.grpLang = New System.Windows.Forms.GroupBox
        Me.radC = New System.Windows.Forms.RadioButton
        Me.radVB = New System.Windows.Forms.RadioButton
        Me.txtLang = New System.Windows.Forms.TextBox
        Me.grpLang.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLang
        '
        Me.grpLang.Controls.Add(Me.radC)
        Me.grpLang.Controls.Add(Me.radVB)
        Me.grpLang.Location = New System.Drawing.Point(23, 12)
        Me.grpLang.Name = "grpLang"
        Me.grpLang.Size = New System.Drawing.Size(189, 100)
        Me.grpLang.TabIndex = 0
        Me.grpLang.TabStop = False
        Me.grpLang.Text = "Programming Language"
        '
        'radC
        '
        Me.radC.AutoSize = True
        Me.radC.Location = New System.Drawing.Point(40, 62)
        Me.radC.Name = "radC"
        Me.radC.Size = New System.Drawing.Size(83, 17)
        Me.radC.TabIndex = 1
        Me.radC.TabStop = True
        Me.radC.Text = "&C Language"
        Me.radC.UseVisualStyleBackColor = True
        '
        'radVB
        '
        Me.radVB.AutoSize = True
        Me.radVB.Location = New System.Drawing.Point(40, 28)
        Me.radVB.Name = "radVB"
        Me.radVB.Size = New System.Drawing.Size(82, 17)
        Me.radVB.TabIndex = 0
        Me.radVB.TabStop = True
        Me.radVB.Text = "&Visual Basic"
        Me.radVB.UseVisualStyleBackColor = True
        '
        'txtLang
        '
        Me.txtLang.Location = New System.Drawing.Point(52, 152)
        Me.txtLang.Name = "txtLang"
        Me.txtLang.ReadOnly = True
        Me.txtLang.Size = New System.Drawing.Size(128, 20)
        Me.txtLang.TabIndex = 2
        '
        'frmRadioButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 250)
        Me.Controls.Add(Me.txtLang)
        Me.Controls.Add(Me.grpLang)
        Me.Name = "frmRadioButton"
        Me.Text = "Choose Only One"
        Me.grpLang.ResumeLayout(False)
        Me.grpLang.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpLang As System.Windows.Forms.GroupBox
    Friend WithEvents radC As System.Windows.Forms.RadioButton
    Friend WithEvents radVB As System.Windows.Forms.RadioButton
    Friend WithEvents txtLang As System.Windows.Forms.TextBox

End Class
