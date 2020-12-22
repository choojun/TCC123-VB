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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(12, 15)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(48, 15)
        Me.lblOutput.TabIndex = 0
        Me.lblOutput.Text = "Output:"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(66, 12)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(178, 23)
        Me.txtOutput.TabIndex = 1
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(24, 50)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(75, 23)
        Me.btnA.TabIndex = 2
        Me.btnA.Text = "Question a"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Location = New System.Drawing.Point(24, 79)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(75, 23)
        Me.btnB.TabIndex = 3
        Me.btnB.Text = "Question b"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Location = New System.Drawing.Point(24, 108)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(75, 23)
        Me.btnC.TabIndex = 4
        Me.btnC.Text = "Question c"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.Location = New System.Drawing.Point(158, 50)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(75, 23)
        Me.btnD.TabIndex = 5
        Me.btnD.Text = "Question d"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Location = New System.Drawing.Point(158, 79)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(75, 23)
        Me.btnE.TabIndex = 6
        Me.btnE.Text = "Question e"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.Location = New System.Drawing.Point(158, 108)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(75, 23)
        Me.btnF.TabIndex = 7
        Me.btnF.Text = "Question f"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(90, 146)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 205)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnF)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.lblOutput)
        Me.Name = "Form1"
        Me.Text = "Button Clicks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOutput As Label
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnA As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnE As Button
    Friend WithEvents btnF As Button
    Friend WithEvents btnReset As Button
End Class
