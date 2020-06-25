<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUnique
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
        Me.lblCount = New System.Windows.Forms.Label
        Me.txtOutput = New System.Windows.Forms.TextBox
        Me.lblNumbersEntered = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.txtNumber = New System.Windows.Forms.TextBox
        Me.lblNumber = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblCount
        '
        Me.lblCount.Enabled = False
        Me.lblCount.Location = New System.Drawing.Point(107, 55)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(91, 29)
        Me.lblCount.TabIndex = 11
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(15, 97)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(337, 176)
        Me.txtOutput.TabIndex = 10
        '
        'lblNumbersEntered
        '
        Me.lblNumbersEntered.Location = New System.Drawing.Point(12, 55)
        Me.lblNumbersEntered.Name = "lblNumbersEntered"
        Me.lblNumbersEntered.Size = New System.Drawing.Size(153, 29)
        Me.lblNumbersEntered.TabIndex = 9
        Me.lblNumbersEntered.Text = "Numbers entered"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(252, 9)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 34)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "OK"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(110, 13)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber.TabIndex = 7
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(12, 20)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(73, 13)
        Me.lblNumber.TabIndex = 6
        Me.lblNumber.Text = "Enter number:"
        '
        'FrmUnique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 340)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.lblNumbersEntered)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblNumber)
        Me.Name = "FrmUnique"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents lblNumbersEntered As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblNumber As System.Windows.Forms.Label

End Class
