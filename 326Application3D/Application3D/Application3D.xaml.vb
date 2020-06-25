' Changing the axis of rotation for a 3-D animation.
Imports System.Windows.Media.Media3D

Class Application3D
   ' when user selects xRadio, set axis of rotation
   Private Sub xRadio_Checked(ByVal sender As System.Object, _
      ByVal e As System.Windows.RoutedEventArgs) Handles xRadio.Checked

      rotation.Axis = New Vector3D(1, 0, 0) ' set rotation axis
      camera.Position = New Point3D(6, 0, 0) ' set camera position
   End Sub ' xRadio_Checked

   ' when user selects yRadio, set axis of rotation
   Private Sub yRadio_Checked(ByVal sender As System.Object, _
      ByVal e As System.Windows.RoutedEventArgs) Handles yRadio.Checked

      rotation.Axis = New Vector3D(0, 1, 0) ' set rotation axis
      camera.Position = New Point3D(6, 0, 0) ' set camera position
   End Sub ' yRadio_Checked

   ' when user selects zRadio, set axis of rotation
   Private Sub zRadio_Checked(ByVal sender As System.Object, _
      ByVal e As System.Windows.RoutedEventArgs) Handles zRadio.Checked

      rotation.Axis = New Vector3D(0, 0, 1) ' set rotation axis
      camera.Position = New Point3D(6, 0, 1) ' set camera position
   End Sub ' zRadio_Checked
End Class ' Application3D
