Public Class Form1
    'Call Truck class and print value to screen when user click enter
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim truck As Truck = New Truck()
        truck.NumberofPassengers = txtPassengers.Text
        truck.Color = txtColor.Text
        truck.NumberofDoors = txtDoors.Text
        truck.MaxCargoWeight = txtWeight.Text
        MessageBox.Show("You entered, " & truck.NumberofPassengers & " Passengers, " & truck.Color &
                        " Color , " & truck.NumberofDoors & " Doors, " & truck.MaxCargoWeight & " Weight, ")

    End Sub
    'clear textbox
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtColor.Clear()
        txtDoors.Clear()
        txtPassengers.Clear()
        txtWeight.Clear()
    End Sub
    'exit the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
