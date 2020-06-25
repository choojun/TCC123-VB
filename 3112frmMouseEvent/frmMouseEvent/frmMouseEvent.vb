'frmMouseEvent.vb
'Use mouse to draw on a Form

Public Class frmDrawing
    'determines whether to paint or not
    Private needPaint As Boolean = False

    'paint when you press down mouse button
    Private Sub frmDrawing_MouseDown(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        needPaint = True
    End Sub

    'stop painting when you release the mouse button
    Private Sub frmDrawing_MouseUp(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        needPaint = False
    End Sub

    'draw triangle when you drag the mouse
    Private Sub frmDrawing_MouseMove(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        'check if mouse button is being pressed
        If (needPaint) Then
            'draw a triangle when the mouse pointer is present
            Dim draw As Graphics = CreateGraphics()
            draw.FillEllipse( _
               New SolidBrush(Color.SandyBrown), e.X, e.Y, 4, 4)
            draw.Dispose()
        End If
    End Sub

    Private Sub frmDrawing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
