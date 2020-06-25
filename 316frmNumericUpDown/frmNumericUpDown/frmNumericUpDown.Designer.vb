<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumericUpDown
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
        Me.lblPrincipal = New System.Windows.Forms.Label
        Me.lblRate = New System.Windows.Forms.Label
        Me.lblYears = New System.Windows.Forms.Label
        Me.lblBalance = New System.Windows.Forms.Label
        Me.txtPrincipal = New System.Windows.Forms.TextBox
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.nudYear = New System.Windows.Forms.NumericUpDown
        Me.txtDisplay = New System.Windows.Forms.TextBox
        Me.btnCalculate = New System.Windows.Forms.Button
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Location = New System.Drawing.Point(22, 19)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(67, 13)
        Me.lblPrincipal.TabIndex = 0
        Me.lblPrincipal.Text = "HL Principal:"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(22, 53)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(71, 13)
        Me.lblRate.TabIndex = 1
        Me.lblRate.Text = "Interest Rate:"
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Location = New System.Drawing.Point(22, 87)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(37, 13)
        Me.lblYears.TabIndex = 2
        Me.lblYears.Text = "Years:"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(22, 131)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(83, 13)
        Me.lblBalance.TabIndex = 3
        Me.lblBalance.Text = "Yearly Payment:"
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(95, 16)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(100, 20)
        Me.txtPrincipal.TabIndex = 4
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(96, 50)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 5
        '
        'nudYear
        '
        Me.nudYear.Location = New System.Drawing.Point(95, 85)
        Me.nudYear.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.ReadOnly = True
        Me.nudYear.Size = New System.Drawing.Size(101, 20)
        Me.nudYear.TabIndex = 6
        Me.nudYear.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(12, 159)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDisplay.Size = New System.Drawing.Size(254, 104)
        Me.txtDisplay.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(111, 126)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(96, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmNumericUpDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(279, 285)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.nudYear)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Name = "frmNumericUpDown"
        Me.Text = "Housing Loan Calculator"
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrincipal As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents lblYears As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents txtPrincipal As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents nudYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtDisplay As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
