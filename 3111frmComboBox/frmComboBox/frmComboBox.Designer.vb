<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTitle
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
        Me.lblTitle = New System.Windows.Forms.Label
        Me.cboTitle = New System.Windows.Forms.ComboBox
        Me.lblName = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.btnName = New System.Windows.Forms.Button
        Me.TxtDisplay = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title:"
        '
        'cboTitle
        '
        Me.cboTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTitle.FormattingEnabled = True
        Me.cboTitle.Items.AddRange(New Object() {"Dr.", "Mr.", "Ms.", "Mrs."})
        Me.cboTitle.Location = New System.Drawing.Point(56, 6)
        Me.cboTitle.Name = "cboTitle"
        Me.cboTitle.Size = New System.Drawing.Size(71, 21)
        Me.cboTitle.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 50)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(56, 47)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 3
        '
        'btnName
        '
        Me.btnName.Location = New System.Drawing.Point(15, 104)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(114, 23)
        Me.btnName.TabIndex = 4
        Me.btnName.Text = "Display Name"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'TxtDisplay
        '
        Me.TxtDisplay.Location = New System.Drawing.Point(12, 146)
        Me.TxtDisplay.Name = "TxtDisplay"
        Me.TxtDisplay.ReadOnly = True
        Me.TxtDisplay.Size = New System.Drawing.Size(173, 20)
        Me.TxtDisplay.TabIndex = 5
        '
        'frmTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(206, 183)
        Me.Controls.Add(Me.TxtDisplay)
        Me.Controls.Add(Me.btnName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.cboTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmTitle"
        Me.Text = "Title name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cboTitle As System.Windows.Forms.ComboBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnName As System.Windows.Forms.Button
    Friend WithEvents TxtDisplay As System.Windows.Forms.TextBox

End Class
