<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmToolTips
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
        Me.components = New System.ComponentModel.Container()
        Me.lblVB = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblWOU = New System.Windows.Forms.Label()
        Me.lblPHP = New System.Windows.Forms.Label()
        Me.lblJava = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblVB
        '
        Me.lblVB.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblVB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVB.Location = New System.Drawing.Point(16, 65)
        Me.lblVB.Name = "lblVB"
        Me.lblVB.Size = New System.Drawing.Size(80, 22)
        Me.lblVB.TabIndex = 0
        Me.lblVB.Text = "Visual Basic"
        Me.lblToolTip.SetToolTip(Me.lblVB, "Visual Programming")
        '
        'lblC
        '
        Me.lblC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblC.Location = New System.Drawing.Point(16, 87)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(80, 25)
        Me.lblC.TabIndex = 1
        Me.lblC.Text = "C Language"
        Me.lblToolTip.SetToolTip(Me.lblC, "Structured Programming")
        '
        'lblWOU
        '
        Me.lblWOU.AutoSize = True
        Me.lblWOU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWOU.Location = New System.Drawing.Point(12, 29)
        Me.lblWOU.Name = "lblWOU"
        Me.lblWOU.Size = New System.Drawing.Size(194, 20)
        Me.lblWOU.TabIndex = 2
        Me.lblWOU.Text = "Wawasan Open University"
        Me.lblToolTip.SetToolTip(Me.lblWOU, "Visit us at http://www.wou.edu.my")
        '
        'lblPHP
        '
        Me.lblPHP.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblPHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPHP.Location = New System.Drawing.Point(16, 112)
        Me.lblPHP.Name = "lblPHP"
        Me.lblPHP.Size = New System.Drawing.Size(80, 25)
        Me.lblPHP.TabIndex = 3
        Me.lblPHP.Text = "PHP"
        Me.lblToolTip.SetToolTip(Me.lblPHP, "Web Database Application")
        '
        'lblJava
        '
        Me.lblJava.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJava.Location = New System.Drawing.Point(16, 137)
        Me.lblJava.Name = "lblJava"
        Me.lblJava.Size = New System.Drawing.Size(80, 25)
        Me.lblJava.TabIndex = 4
        Me.lblJava.Text = "Java Language"
        Me.lblToolTip.SetToolTip(Me.lblJava, "Programming Fundamentals with Java")
        '
        'frmToolTips
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(260, 185)
        Me.Controls.Add(Me.lblJava)
        Me.Controls.Add(Me.lblPHP)
        Me.Controls.Add(Me.lblWOU)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblVB)
        Me.Name = "frmToolTips"
        Me.Text = "Tool Tips"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVB As System.Windows.Forms.Label
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents lblToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lblWOU As Label
    Friend WithEvents lblPHP As Label
    Friend WithEvents lblJava As Label
End Class
