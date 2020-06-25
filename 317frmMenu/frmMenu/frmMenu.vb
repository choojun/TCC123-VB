Public Class frmMenu

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        End
    End Sub

    Private Sub mnuPictureVisible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPictureVisible.Click
        'change the visible property of the picture
        'and the state of the checkmark
        PicWou.Visible = Not PicWou.Visible
        mnuPictureVisible.Checked = Not mnuPictureVisible.Checked
    End Sub

    Private Sub mnuPictureSizeSmall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPictureSizeSmall.Click
        'Set the values for a small Picture
        PicWou.Height = 108
        PicWou.Width = 150
        mnuPictureSizeLarge.Checked = False
        mnuPictureSizeSmall.Checked = True
    End Sub

    Private Sub mnuPictureSizeLarge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPictureSizeLarge.Click
        'Set the values for a Large Picture
        PicWou.Height = 108
        PicWou.Width = 301
        mnuPictureSizeSmall.Checked = False
        mnuPictureSizeLarge.Checked = True
    End Sub
End Class
