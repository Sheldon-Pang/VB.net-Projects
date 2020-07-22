Public Class Form1
    'clear textbox
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmount.Clear()
        txtEndBal.Clear()
        txtStartBal.Clear()
    End Sub
    'exit the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    'set customer name and account number when program starts
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bankAccount As New Account
        txtName.Text = bankAccount.CustomerName
        txtAccNum.Text = bankAccount.AccountNumber
    End Sub
    'deposit button
    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        If txtAmount.Text > 0 Then
            Dim bankAccount As BankAccount = New BankAccount With {
            .amount = txtAmount.Text,
            .startBal = txtStartBal.Text
        }
            txtEndBal.Text = bankAccount.Deposit()
        Else
            MessageBox.Show("You need to deposit a value greater than 0")
        End If

    End Sub
    'withdraw button
    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        Dim bankAccount As BankAccount = New BankAccount With {
            .amount = txtAmount.Text,
            .startBal = txtStartBal.Text
        }
        txtEndBal.Text = bankAccount.Withdraw()
    End Sub
End Class
