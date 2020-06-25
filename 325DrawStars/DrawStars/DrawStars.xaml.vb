' Applying transforms to a Polygon.
Class DrawStars
   ' duplicate the polygon several times and rotate each
   Private Sub DrawStars_Loaded(ByVal sender As System.Object, _
      ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

      Dim random As New Random() ' used to get random values for colors

      ' create 18 more stars
      For count = 1 To 18
            Dim newStar = New Polygon() ' create a new polygon object
            newStar.Points = star.Points ' copy the points collection

         Dim colorValues(3) As Byte ' create a four element Byte array
         random.NextBytes(colorValues) ' creates four random values
         newStar.Fill = New SolidColorBrush(Color.FromArgb( _
            colorValues(0), colorValues(1), colorValues(2), _
            colorValues(3))) ' creates a random color brush

         ' apply a rotation to the shape
         Dim rotate = New RotateTransform(count * 20, 150, 150)
         newStar.RenderTransform = rotate
         mainCanvas.Children.Add(newStar) ' add the polygon to the window
      Next ' count
   End Sub ' DrawStars_Loaded
End Class ' DrawStars
