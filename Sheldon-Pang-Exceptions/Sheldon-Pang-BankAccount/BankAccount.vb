Public Class BankAccount
    'Inheritance, Account is the parent
    Inherits Account
    Public Function Deposit() As Double
        Deposit = startBal + amount
        MessageBox.Show("You have successfully deposited amount of " & amount)
    End Function

    Public Function Withdraw() As Double
        'newly added code, check if user entered a postive number
        If amount <= 0 Then
            MessageBox.Show("You can only withdraw a potive number")
            'Account balance does not change
            Withdraw = startBal
        ElseIf amount > startBal Then
            MessageBox.Show("The amount to withdraw cannot exceed the balance.")
            'Account balance does not change
            Withdraw = startBal
        Else
            Withdraw = startBal - amount
        End If
    End Function

End Class
