Public Class Truck
    'Inheritance, Vehicle is the parent
    Inherits Vehicle

    Dim mNumberofDoors As Integer
    Dim mMaxCargoWeight As Double

    'Override Base Property NumberofPassengers()
    Public Overrides Property NumberofPassengers As Integer
        Get
            Return mNumberofPassengers
        End Get
        Set(value As Integer)
            If value = 1 Or value = 2 Then
                mNumberofPassengers = value
            Else
                MessageBox.Show("you need to enter less than 3 passengers.")
            End If
        End Set
    End Property

    'Get and Set of Property NumberofDoors()
    Public Property NumberofDoors() As Integer
        Get
            Return mNumberofDoors
        End Get
        Set(ByVal value As Integer)
            mNumberofDoors = value
        End Set
    End Property
    'Get and Set of Property MaxCargoWeight()
    Public Property MaxCargoWeight() As Double
        Get
            Return mMaxCargoWeight
        End Get
        Set(ByVal value As Double)
            mMaxCargoWeight = value
        End Set
    End Property
End Class
