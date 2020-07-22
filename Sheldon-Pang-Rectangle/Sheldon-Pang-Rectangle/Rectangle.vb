Public Class Rectangle

    Public width As Double
    Public height As Double

    'Constructor with no parameters, default rectangle, the values for width and height are 1
    Public Sub New()
        width = 1.0
        height = 1.0
    End Sub

    'Constructor with two parameters, need ask user for two input value
    Public Sub New(ByVal a As Double, ByVal b As Double)
        width = a
        height = b
    End Sub

    'method for calculating the area and display area in messagebox
    Public Function getArea() As Double
        getArea = width * height
        MessageBox.Show("Rectangle width is " & width & ", height is " & height & ", Area is " & getArea)
    End Function

End Class
