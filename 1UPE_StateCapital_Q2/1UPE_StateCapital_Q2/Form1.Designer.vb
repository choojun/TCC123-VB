<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCap = New System.Windows.Forms.Label()
        Me.btnPerak = New System.Windows.Forms.Button()
        Me.btnPenang = New System.Windows.Forms.Button()
        Me.btnJohor = New System.Windows.Forms.Button()
        Me.btnSelangor = New System.Windows.Forms.Button()
        Me.lblCapital = New System.Windows.Forms.Label()
        Me.lblDes = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(169, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCap
        '
        Me.lblCap.AutoSize = True
        Me.lblCap.Location = New System.Drawing.Point(25, 152)
        Me.lblCap.Name = "lblCap"
        Me.lblCap.Size = New System.Drawing.Size(47, 15)
        Me.lblCap.TabIndex = 1
        Me.lblCap.Text = "Capital:"
        '
        'btnPerak
        '
        Me.btnPerak.Location = New System.Drawing.Point(12, 12)
        Me.btnPerak.Name = "btnPerak"
        Me.btnPerak.Size = New System.Drawing.Size(75, 30)
        Me.btnPerak.TabIndex = 2
        Me.btnPerak.Text = "Perak"
        Me.btnPerak.UseVisualStyleBackColor = True
        '
        'btnPenang
        '
        Me.btnPenang.Location = New System.Drawing.Point(12, 48)
        Me.btnPenang.Name = "btnPenang"
        Me.btnPenang.Size = New System.Drawing.Size(75, 28)
        Me.btnPenang.TabIndex = 3
        Me.btnPenang.Text = "Penang"
        Me.btnPenang.UseVisualStyleBackColor = True
        '
        'btnJohor
        '
        Me.btnJohor.Location = New System.Drawing.Point(12, 82)
        Me.btnJohor.Name = "btnJohor"
        Me.btnJohor.Size = New System.Drawing.Size(75, 23)
        Me.btnJohor.TabIndex = 4
        Me.btnJohor.Text = "Johor"
        Me.btnJohor.UseVisualStyleBackColor = True
        '
        'btnSelangor
        '
        Me.btnSelangor.Location = New System.Drawing.Point(12, 111)
        Me.btnSelangor.Name = "btnSelangor"
        Me.btnSelangor.Size = New System.Drawing.Size(75, 23)
        Me.btnSelangor.TabIndex = 5
        Me.btnSelangor.Text = "Selangor"
        Me.btnSelangor.UseVisualStyleBackColor = True
        '
        'lblCapital
        '
        Me.lblCapital.AutoSize = True
        Me.lblCapital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCapital.Location = New System.Drawing.Point(73, 150)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(2, 17)
        Me.lblCapital.TabIndex = 6
        Me.lblCapital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDes
        '
        Me.lblDes.AutoSize = True
        Me.lblDes.Location = New System.Drawing.Point(2, 181)
        Me.lblDes.Name = "lblDes"
        Me.lblDes.Size = New System.Drawing.Size(70, 15)
        Me.lblDes.TabIndex = 7
        Me.lblDes.Text = "Description:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescription.Location = New System.Drawing.Point(73, 181)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(2, 17)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 205)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblDes)
        Me.Controls.Add(Me.lblCapital)
        Me.Controls.Add(Me.btnSelangor)
        Me.Controls.Add(Me.btnJohor)
        Me.Controls.Add(Me.btnPenang)
        Me.Controls.Add(Me.btnPerak)
        Me.Controls.Add(Me.lblCap)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "State Capitals"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblCap As Label
    Friend WithEvents btnPerak As Button
    Friend WithEvents btnPenang As Button
    Friend WithEvents btnJohor As Button
    Friend WithEvents btnSelangor As Button
    Friend WithEvents lblCapital As Label
    Friend WithEvents lblDes As Label
    Friend WithEvents lblDescription As Label
End Class
