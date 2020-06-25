Class Images
    Private Sub btnTransform_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnTransform.Click
        'Defining the TranslateTransform
        Dim moveImage As New TranslateTransform()

        'Setting the x,y parameters
        moveImage.X = Convert.ToDouble(txtTransformXCoordinate.Text.Trim)
        moveImage.Y = Convert.ToDouble(txtTransformYCoordinate.Text.Trim)

        'Assigning the transform to the image
        imgImage.RenderTransform = moveImage
    End Sub

    Private Sub btnRotate_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnRotate.Click
        'Defining the RotateTransform
        Dim rotateImage As New RotateTransform()

        'Setting the roatation angle
        rotateImage.Angle = Convert.ToDouble(txtRoateAngle.Text.Trim)

        'Assigning the transform to the image
        imgImage.RenderTransform = rotateImage
    End Sub

    Private Sub btnSkew_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnSkew.Click
        'Defining the SkewTransform
        Dim skewImage As New SkewTransform()

        'Setting the x,y parameters
        skewImage.AngleX = Convert.ToDouble(txtSkewXCoordiante.Text.Trim)
        skewImage.AngleY = Convert.ToDouble(txtSkewYCoordiante.Text.Trim)

        'Assigning the transform to the image
        imgImage.RenderTransform = skewImage
    End Sub

    Private Sub btnScale_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnScale.Click
        'Defining the ScaleTransform
        Dim scaleImage As New ScaleTransform()

        'Setting the x,y parameters
        scaleImage.ScaleX = Convert.ToDouble(txtScaleXCoordiante.Text.Trim)
        scaleImage.ScaleY = Convert.ToDouble(txtScaleYCoordiante.Text.Trim)

        'Assigning the transform to the image
        imgImage.RenderTransform = scaleImage
    End Sub
End Class
