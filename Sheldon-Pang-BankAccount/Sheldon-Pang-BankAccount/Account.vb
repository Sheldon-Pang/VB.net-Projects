Public Class Account
    Public mCustomerName As String
    Public mAccountNumber As String

    Public startBal As Double
    Public amount As Double
    Public endBal As Double

    'Constructor with two parameters, need ask user for Starting Account Balance and Transaction Amount
    Public Sub New(ByVal a As Double, ByVal b As Double)
        startBal = a
        amount = b
    End Sub

    Public Sub New()
        mCustomerName = "Good Customer"
        mAccountNumber = "1234"
    End Sub

    Public Property CustomerName() As String
        Get
            Return mCustomerName
        End Get
        Set
            mCustomerName = "Good Customer"
        End Set
    End Property

    Public Property AccountNumber() As String
        Get
            Return mAccountNumber
        End Get
        Set
            mAccountNumber = "1234"
        End Set
    End Property




End Class
