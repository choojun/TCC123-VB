<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmDivideByZero
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNumerator = New System.Windows.Forms.Label()
        Me.lblDenominator = New System.Windows.Forms.Label()
        Me.txtNumerator = New System.Windows.Forms.TextBox()
        Me.txtDenominator = New System.Windows.Forms.TextBox()
        Me.cmdDivide = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumerator
        '
        Me.lblNumerator.AutoSize = True
        Me.lblNumerator.Location = New System.Drawing.Point(28, 37)
        Me.lblNumerator.Name = "lblNumerator"
        Me.lblNumerator.Size = New System.Drawing.Size(113, 17)
        Me.lblNumerator.TabIndex = 0
        Me.lblNumerator.Text = "Enter Numerator"
        '
        'lblDenominator
        '
        Me.lblDenominator.AutoSize = True
        Me.lblDenominator.Location = New System.Drawing.Point(28, 73)
        Me.lblDenominator.Name = "lblDenominator"
        Me.lblDenominator.Size = New System.Drawing.Size(127, 17)
        Me.lblDenominator.TabIndex = 1
        Me.lblDenominator.Text = "Enter Denominator"
        '
        'txtNumerator
        '
        Me.txtNumerator.Location = New System.Drawing.Point(187, 37)
        Me.txtNumerator.Name = "txtNumerator"
        Me.txtNumerator.Size = New System.Drawing.Size(186, 22)
        Me.txtNumerator.TabIndex = 2
        '
        'txtDenominator
        '
        Me.txtDenominator.Location = New System.Drawing.Point(187, 73)
        Me.txtDenominator.Name = "txtDenominator"
        Me.txtDenominator.Size = New System.Drawing.Size(186, 22)
        Me.txtDenominator.TabIndex = 3
        '
        'cmdDivide
        '
        Me.cmdDivide.Location = New System.Drawing.Point(22, 131)
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.Size = New System.Drawing.Size(147, 46)
        Me.cmdDivide.TabIndex = 4
        Me.cmdDivide.Text = "Click to Divide"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Location = New System.Drawing.Point(252, 131)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(121, 46)
        Me.lblOutput.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 222)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.cmdDivide)
        Me.Controls.Add(Me.txtDenominator)
        Me.Controls.Add(Me.txtNumerator)
        Me.Controls.Add(Me.lblDenominator)
        Me.Controls.Add(Me.lblNumerator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumerator As Label
    Friend WithEvents lblDenominator As Label
    Friend WithEvents txtNumerator As TextBox
    Friend WithEvents txtDenominator As TextBox
    Friend WithEvents cmdDivide As Button
    Friend WithEvents lblOutput As Label
End Class
