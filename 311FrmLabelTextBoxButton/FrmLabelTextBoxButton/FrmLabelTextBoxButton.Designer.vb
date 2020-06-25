<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLabelTextBoxButton
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
        Me.txtInputPassword = New System.Windows.Forms.TextBox
        Me.lblDisplayPassword = New System.Windows.Forms.Label
        Me.btnDisplayPassword = New System.Windows.Forms.Button
        Me.lblInputPass = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtInputPassword
        '
        Me.txtInputPassword.Location = New System.Drawing.Point(76, 28)
        Me.txtInputPassword.Name = "txtInputPassword"
        Me.txtInputPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtInputPassword.Size = New System.Drawing.Size(143, 20)
        Me.txtInputPassword.TabIndex = 0
        '
        'lblDisplayPassword
        '
        Me.lblDisplayPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayPassword.Location = New System.Drawing.Point(76, 77)
        Me.lblDisplayPassword.Name = "lblDisplayPassword"
        Me.lblDisplayPassword.Size = New System.Drawing.Size(143, 29)
        Me.lblDisplayPassword.TabIndex = 1
        '
        'btnDisplayPassword
        '
        Me.btnDisplayPassword.Location = New System.Drawing.Point(76, 173)
        Me.btnDisplayPassword.Name = "btnDisplayPassword"
        Me.btnDisplayPassword.Size = New System.Drawing.Size(98, 33)
        Me.btnDisplayPassword.TabIndex = 2
        Me.btnDisplayPassword.Text = "Show Password"
        Me.btnDisplayPassword.UseVisualStyleBackColor = True
        '
        'lblInputPass
        '
        Me.lblInputPass.AutoSize = True
        Me.lblInputPass.Location = New System.Drawing.Point(10, 31)
        Me.lblInputPass.Name = "lblInputPass"
        Me.lblInputPass.Size = New System.Drawing.Size(56, 13)
        Me.lblInputPass.TabIndex = 3
        Me.lblInputPass.Text = "Password:"
        '
        'frmLabelTextBoxButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.lblInputPass)
        Me.Controls.Add(Me.btnDisplayPassword)
        Me.Controls.Add(Me.lblDisplayPassword)
        Me.Controls.Add(Me.txtInputPassword)
        Me.Name = "frmLabelTextBoxButton"
        Me.Text = "Show Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInputPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblDisplayPassword As System.Windows.Forms.Label
    Friend WithEvents btnDisplayPassword As System.Windows.Forms.Button
    Friend WithEvents lblInputPass As System.Windows.Forms.Label

End Class
