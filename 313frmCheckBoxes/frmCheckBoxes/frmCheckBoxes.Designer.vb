<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckBoxes
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
        Me.chkOrange = New System.Windows.Forms.CheckBox
        Me.chkApple = New System.Windows.Forms.CheckBox
        Me.chkGrape = New System.Windows.Forms.CheckBox
        Me.chkPearl = New System.Windows.Forms.CheckBox
        Me.lblTotal = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'chkOrange
        '
        Me.chkOrange.AutoSize = True
        Me.chkOrange.Location = New System.Drawing.Point(16, 24)
        Me.chkOrange.Name = "chkOrange"
        Me.chkOrange.Size = New System.Drawing.Size(93, 17)
        Me.chkOrange.TabIndex = 0
        Me.chkOrange.Text = "&Orange (RM1)"
        Me.chkOrange.UseVisualStyleBackColor = True
        '
        'chkApple
        '
        Me.chkApple.AutoSize = True
        Me.chkApple.Location = New System.Drawing.Point(16, 47)
        Me.chkApple.Name = "chkApple"
        Me.chkApple.Size = New System.Drawing.Size(99, 17)
        Me.chkApple.TabIndex = 1
        Me.chkApple.Text = "&Apple (Rm0.60)"
        Me.chkApple.UseVisualStyleBackColor = True
        '
        'chkGrape
        '
        Me.chkGrape.AutoSize = True
        Me.chkGrape.Location = New System.Drawing.Point(16, 70)
        Me.chkGrape.Name = "chkGrape"
        Me.chkGrape.Size = New System.Drawing.Size(87, 17)
        Me.chkGrape.TabIndex = 2
        Me.chkGrape.Text = "&Grape (RM8)"
        Me.chkGrape.UseVisualStyleBackColor = True
        '
        'chkPearl
        '
        Me.chkPearl.AutoSize = True
        Me.chkPearl.Location = New System.Drawing.Point(16, 93)
        Me.chkPearl.Name = "chkPearl"
        Me.chkPearl.Size = New System.Drawing.Size(82, 17)
        Me.chkPearl.TabIndex = 3
        Me.chkPearl.Text = "&Pearl (RM2)"
        Me.chkPearl.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(13, 191)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(117, 13)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total Amount Payment:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(139, 188)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 5
        '
        'frmCheckBoxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 224)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.chkPearl)
        Me.Controls.Add(Me.chkGrape)
        Me.Controls.Add(Me.chkApple)
        Me.Controls.Add(Me.chkOrange)
        Me.Name = "frmCheckBoxes"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkOrange As System.Windows.Forms.CheckBox
    Friend WithEvents chkApple As System.Windows.Forms.CheckBox
    Friend WithEvents chkGrape As System.Windows.Forms.CheckBox
    Friend WithEvents chkPearl As System.Windows.Forms.CheckBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox

End Class
