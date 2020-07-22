Public Class Person
    'Person class with public property procedure
    Dim mFirstname As String
    Public Property Firstname() As String
        Get
            Return mFirstname
        End Get
        Set(value As String)
            If value = "Joe" Then
                mFirstname = "Joseph"
                'check the first name and if the entry is "Joe" change is to "Joseph"
            ElseIf value <> Nothing Then
                mFirstname = value
            End If
        End Set
    End Property

    Dim mLastname As String
    Public Property Lastname() As String
        Get
            Return mLastname
        End Get
        Set(value As String)
            If value <> Nothing Then
                mLastname = value
            End If
        End Set
    End Property

    Dim mAddress As String
    Public Property Address() As String
        Get
            Return mAddress
        End Get
        Set(value As String)
            If value <> Nothing Then
                mAddress = value
            End If
        End Set
    End Property

    Dim mCity As String
    Public Property City() As String
        Get
            Return mCity
        End Get
        Set(value As String)
            If value <> Nothing Then
                mCity = value
            End If
        End Set
    End Property

    Dim mState As String
    Public Property State() As String
        Get
            Return mState
        End Get
        Set(value As String)
            If value <> Nothing Then
                mState = value
            End If
        End Set
    End Property

    Dim mZip As String
    Public Property Zip() As String
        Get
            Return mZip
        End Get
        Set(value As String)
            If value <> Nothing Then
                mZip = value
            End If
        End Set
    End Property

    Dim mPhone As String
    Public Property Phone() As String
        Get
            Return mPhone
        End Get
        Set(value As String)
            If value <> Nothing Then
                mPhone = value
            End If
        End Set
    End Property

End Class
