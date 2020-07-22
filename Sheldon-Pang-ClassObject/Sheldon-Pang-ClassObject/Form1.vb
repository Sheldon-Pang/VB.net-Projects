Public Class Form1
    Private Sub ButtonDisplay_Click(sender As Object, e As EventArgs) Handles ButtonDisplay.Click
        'Create Object
        Dim Student As New Person
        Student.Firstname = TextBoxFirstName.Text
        Student.Lastname = TextBoxLastName.Text
        Student.Address = TextBoxAddress.Text
        Student.City = TextBoxCity.Text
        Student.State = TextBoxState.Text
        Student.Zip = TextBoxZip.Text
        Student.Phone = TextBoxPhone.Text
        'Display Message
        MessageBox.Show(Student.Firstname + " " + Student.Lastname + Environment.NewLine +
                        Student.Address + Environment.NewLine + Student.City + ", " +
                        Student.State + " " + Student.Zip + Environment.NewLine +
                        Student.Phone)
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        'Clear textbox when user click 'Clear'
        TextBoxFirstName.Clear()
        TextBoxLastName.Clear()
        TextBoxAddress.Clear()
        TextBoxCity.Clear()
        TextBoxState.Clear()
        TextBoxZip.Clear()
        TextBoxPhone.Clear()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        'Exit program when user click 'Exit'
        Close()
    End Sub
End Class
