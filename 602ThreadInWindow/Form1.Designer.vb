<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myForm
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
        Me.myDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSumRowSums = New System.Windows.Forms.TextBox()
        Me.txtSumColSums = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSum = New System.Windows.Forms.Button()
        CType(Me.myDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'myDataGridView
        '
        Me.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.myDataGridView.Location = New System.Drawing.Point(18, 23)
        Me.myDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.myDataGridView.Name = "myDataGridView"
        Me.myDataGridView.RowHeadersWidth = 51
        Me.myDataGridView.Size = New System.Drawing.Size(207, 122)
        Me.myDataGridView.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 162)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sum of Row Sums: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 184)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sum of Col Sums: "
        '
        'txtSumRowSums
        '
        Me.txtSumRowSums.Location = New System.Drawing.Point(128, 162)
        Me.txtSumRowSums.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSumRowSums.Name = "txtSumRowSums"
        Me.txtSumRowSums.Size = New System.Drawing.Size(76, 20)
        Me.txtSumRowSums.TabIndex = 2
        '
        'txtSumColSums
        '
        Me.txtSumColSums.Location = New System.Drawing.Point(128, 184)
        Me.txtSumColSums.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSumColSums.Name = "txtSumColSums"
        Me.txtSumColSums.Size = New System.Drawing.Size(76, 20)
        Me.txtSumColSums.TabIndex = 2
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(27, 231)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(56, 39)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "Data Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(137, 231)
        Me.btnSum.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(67, 39)
        Me.btnSum.TabIndex = 4
        Me.btnSum.Text = "Sum calculation"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'myForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 310)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtSumColSums)
        Me.Controls.Add(Me.txtSumRowSums)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.myDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "myForm"
        Me.Text = "My Form"
        CType(Me.myDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents myDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSumRowSums As TextBox
    Friend WithEvents txtSumColSums As TextBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnSum As Button
End Class
