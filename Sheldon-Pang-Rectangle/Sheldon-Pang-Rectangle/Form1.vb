Public Class Form1

    'exit the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        '
        If txtHeight.Text = "" Or txtWidth.Text = "" Then
            Dim rectangle1 As Rectangle = New Rectangle()
            MessageBox.Show("default width is " & rectangle1.width & ", height is " & rectangle1.height & ", and area is 1.")
        Else
            'create the rectangle
            Dim rectangle2 As Rectangle = New Rectangle With {
                        .width = txtWidth.Text,
                        .height = txtHeight.Text
                    }
            rectangle2.getArea()
        End If



    End Sub

    'clear all the textbox
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtHeight.Clear()
        txtWidth.Clear()
    End Sub
End Class
