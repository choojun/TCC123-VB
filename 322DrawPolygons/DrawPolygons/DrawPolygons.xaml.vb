﻿' Fig. 16.4: DrawPolygons.xaml.vb
' Drawing Polylines and Polygons.
Class DrawPolygons
   ' stores the collection of points for the multi-sided shapes
   Private points As New PointCollection()

   ' when the window loads, assign the PointCollection to shape points
   Private Sub mainWindow_Loaded(ByVal sender As System.Object, _
      ByVal e As System.Windows.RoutedEventArgs) _
      Handles mainWindow.Loaded

      polyLine.Points = points ' assign Polyline points
      polygon.Points = points ' assign Polygon points
        filledPolygon.Points = points ' assign filled Polygon points

        polyLine.Visibility = Windows.Visibility.Visible
        polygon.Visibility = Windows.Visibility.Visible
        filledPolygon.Visibility = Windows.Visibility.Visible
   End Sub ' mainWindow_Loaded

   ' adds a new point when the user clicks on the canvas
   Private Sub drawCanvas_MouseDown(ByVal sender As Object, _
      ByVal e As System.Windows.Input.MouseButtonEventArgs) _
      Handles drawCanvas.MouseDown

      points.Add(e.GetPosition(drawCanvas)) ' add point to collection
   End Sub ' drawCanvas_MouseDown

   ' when the clear Button is clicked
   Private Sub clearButton_Click(ByVal sender As Object, _
      ByVal e As System.Windows.RoutedEventArgs) _
      Handles clearButton.Click

      points.Clear() ' clear the points from the collection
   End Sub ' clearButton_Click

   ' when the user selects the Polyline
   Private Sub lineRadio_Checked(ByVal sender As Object, _
      ByVal e As System.Windows.RoutedEventArgs) _
      Handles lineRadio.Checked

      ' Polyline is visible, the other two are not
      polyLine.Visibility = Windows.Visibility.Visible
      polygon.Visibility = Windows.Visibility.Collapsed
      filledPolygon.Visibility = Windows.Visibility.Collapsed
   End Sub ' lineRadio_Checked

   ' when the user selects the Polygon
   Private Sub polygonRadio_Checked(ByVal sender As Object, _
      ByVal e As System.Windows.RoutedEventArgs) _
      Handles polygonRadio.Checked

      ' Polygon is visible, the other two are not
      polyLine.Visibility = Windows.Visibility.Collapsed
      polygon.Visibility = Windows.Visibility.Visible
      filledPolygon.Visibility = Windows.Visibility.Collapsed
   End Sub ' polygonRadio_Checked

   ' when the user selects the filled Polygon
   Private Sub filledPolygonRadio_Checked(ByVal sender As Object, _
      ByVal e As System.Windows.RoutedEventArgs) _
      Handles filledPolygonRadio.Checked

      ' filled Polygon is visible, the other two are not
      polyLine.Visibility = Windows.Visibility.Collapsed
      polygon.Visibility = Windows.Visibility.Collapsed
      filledPolygon.Visibility = Windows.Visibility.Visible
   End Sub ' filledPolygonRadio_Checked
End Class ' DrawPolygons

' **************************************************************************
' * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
' * Pearson Education, Inc. All Rights Reserved.                           *
' *                                                                        *
' * DISCLAIMER: The authors and publisher of this book have used their     *
' * best efforts in preparing the book. These efforts include the          *
' * development, research, and testing of the theories and programs        *
' * to determine their effectiveness. The authors and publisher make       *
' * no warranty of any kind, expressed or implied, with regard to these    *
' * programs or to the documentation contained in these books. The authors *
' * and publisher shall not be liable in any event for incidental or       *
' * consequential damages in connection with, or arising out of, the       *
' * furnishing, performance, or use of these programs.                     *
' **************************************************************************