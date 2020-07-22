Public Class BankAccount
    'Inheritance, Account is the parent
    Inherits Account
    Public Function Deposit() As Double
        Deposit = startBal + amount
        MessageBox.Show("You have successfully deposited amount of " & amount)
    End Function

    Public Function Withdraw() As Double
        If amount <= startBal Then
            Withdraw = startBal - amount
        Else
            MessageBox.Show("The amount to withdraw cannot exceed the balance.")
            'Account balance does not change
            Withdraw = startBal
        End If
    End Function

End Class
