<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGroupBoxPanel
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
        Me.grpMain = New System.Windows.Forms.GroupBox()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnVB = New System.Windows.Forms.Button()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.btnright = New System.Windows.Forms.Button()
        Me.btnleft = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.grpMain.SuspendLayout()
        Me.PnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.btnC)
        Me.grpMain.Controls.Add(Me.btnVB)
        Me.grpMain.Location = New System.Drawing.Point(41, 15)
        Me.grpMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpMain.Size = New System.Drawing.Size(260, 123)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        Me.grpMain.Text = "Languages"
        '
        'btnC
        '
        Me.btnC.Location = New System.Drawing.Point(144, 47)
        Me.btnC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(100, 28)
        Me.btnC.TabIndex = 1
        Me.btnC.Text = "C Language"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnVB
        '
        Me.btnVB.Location = New System.Drawing.Point(8, 47)
        Me.btnVB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVB.Name = "btnVB"
        Me.btnVB.Size = New System.Drawing.Size(100, 28)
        Me.btnVB.TabIndex = 0
        Me.btnVB.Text = "Visual Basic"
        Me.btnVB.UseVisualStyleBackColor = True
        '
        'PnlMain
        '
        Me.PnlMain.AutoScroll = True
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.btnright)
        Me.PnlMain.Controls.Add(Me.btnleft)
        Me.PnlMain.Location = New System.Drawing.Point(41, 198)
        Me.PnlMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(259, 123)
        Me.PnlMain.TabIndex = 1
        '
        'btnright
        '
        Me.btnright.Location = New System.Drawing.Point(180, 48)
        Me.btnright.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnright.Name = "btnright"
        Me.btnright.Size = New System.Drawing.Size(100, 28)
        Me.btnright.TabIndex = 1
        Me.btnright.Text = "Right"
        Me.btnright.UseVisualStyleBackColor = True
        '
        'btnleft
        '
        Me.btnleft.Location = New System.Drawing.Point(-27, 48)
        Me.btnleft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnleft.Name = "btnleft"
        Me.btnleft.Size = New System.Drawing.Size(100, 28)
        Me.btnleft.TabIndex = 0
        Me.btnleft.Text = "Left"
        Me.btnleft.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(37, 155)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(264, 28)
        Me.lblMessage.TabIndex = 2
        '
        'frmGroupBoxPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(329, 336)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.grpMain)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmGroupBoxPanel"
        Me.Text = "GroupBox & Panel"
        Me.grpMain.ResumeLayout(False)
        Me.PnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents btnVB As System.Windows.Forms.Button
    Friend WithEvents btnright As System.Windows.Forms.Button
    Friend WithEvents btnleft As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class
