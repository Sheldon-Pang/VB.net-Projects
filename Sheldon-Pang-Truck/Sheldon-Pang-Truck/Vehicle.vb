Public Class Vehicle
    Public mNumberofPassengers As Integer
    Dim mColor As String

    'Overridable Get and Set of Property NumberofPassengers()
    Public Overridable Property NumberofPassengers As Integer
        Get
            Return mNumberofPassengers
        End Get
        Set(value As Integer)
            mNumberofPassengers = value
        End Set
    End Property


    'Overridable Get and Set of Property Color()
    Public Overridable Property Color() As String
        Get
            Return mColor
        End Get
        Set(ByVal value As String)
            mColor = value
        End Set
    End Property

End Class
