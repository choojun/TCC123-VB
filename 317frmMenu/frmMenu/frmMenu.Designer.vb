<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPicture = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPictureVisible = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPictureSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPictureSize = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPictureSizeSmall = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPictureSizeLarge = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblWou = New System.Windows.Forms.Label()
        Me.PicWou = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PicWou, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuPicture})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(328, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuPicture
        '
        Me.mnuPicture.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPictureVisible, Me.mnuPictureSeparator, Me.mnuPictureSize})
        Me.mnuPicture.Name = "mnuPicture"
        Me.mnuPicture.Size = New System.Drawing.Size(56, 20)
        Me.mnuPicture.Text = "Picture"
        '
        'mnuPictureVisible
        '
        Me.mnuPictureVisible.Checked = True
        Me.mnuPictureVisible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuPictureVisible.Name = "mnuPictureVisible"
        Me.mnuPictureVisible.Size = New System.Drawing.Size(108, 22)
        Me.mnuPictureVisible.Text = "Visible"
        '
        'mnuPictureSeparator
        '
        Me.mnuPictureSeparator.Name = "mnuPictureSeparator"
        Me.mnuPictureSeparator.Size = New System.Drawing.Size(105, 6)
        '
        'mnuPictureSize
        '
        Me.mnuPictureSize.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPictureSizeSmall, Me.mnuPictureSizeLarge})
        Me.mnuPictureSize.Name = "mnuPictureSize"
        Me.mnuPictureSize.Size = New System.Drawing.Size(108, 22)
        Me.mnuPictureSize.Text = "Size"
        '
        'mnuPictureSizeSmall
        '
        Me.mnuPictureSizeSmall.Name = "mnuPictureSizeSmall"
        Me.mnuPictureSizeSmall.Size = New System.Drawing.Size(103, 22)
        Me.mnuPictureSizeSmall.Text = "Small"
        '
        'mnuPictureSizeLarge
        '
        Me.mnuPictureSizeLarge.Checked = True
        Me.mnuPictureSizeLarge.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuPictureSizeLarge.Name = "mnuPictureSizeLarge"
        Me.mnuPictureSizeLarge.Size = New System.Drawing.Size(103, 22)
        Me.mnuPictureSizeLarge.Text = "Large"
        '
        'lblWou
        '
        Me.lblWou.AutoSize = True
        Me.lblWou.Location = New System.Drawing.Point(48, 148)
        Me.lblWou.Name = "lblWou"
        Me.lblWou.Size = New System.Drawing.Size(234, 13)
        Me.lblWou.TabIndex = 2
        Me.lblWou.Text = "The Main Campus of Wawasan Open University"
        '
        'PicWou
        '
        Me.PicWou.Image = Global.frmMenu.My.Resources.Resources.wouHomestead
        Me.PicWou.Location = New System.Drawing.Point(14, 37)
        Me.PicWou.Name = "PicWou"
        Me.PicWou.Size = New System.Drawing.Size(301, 108)
        Me.PicWou.TabIndex = 1
        Me.PicWou.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 207)
        Me.Controls.Add(Me.lblWou)
        Me.Controls.Add(Me.PicWou)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PicWou, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPicture As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPictureVisible As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PicWou As System.Windows.Forms.PictureBox
    Friend WithEvents mnuPictureSize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPictureSizeSmall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPictureSizeLarge As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPictureSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblWou As Label
End Class
