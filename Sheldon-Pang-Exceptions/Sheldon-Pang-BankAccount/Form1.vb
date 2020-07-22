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
        'newly added code, try and catch
        Try
            'use if statement to check if the amount to be deposited is greater than 0
            If txtAmount.Text > 0 Then
                Dim bankAccount As BankAccount = New BankAccount With {
                    .amount = txtAmount.Text,
                    .startBal = txtStartBal.Text
                }
                txtEndBal.Text = bankAccount.Deposit()
            Else
                MessageBox.Show("You need to deposit a value greater than 0")
            End If
        Catch ex As Exception 'exception object and display in label control on main form
            MessageBox.Show("Please only enter postive number")
            LabelError.Text = ex.Message
        End Try

    End Sub
    'withdraw button
    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        'newly added code, try and catch
        Try
            Dim bankAccount As BankAccount = New BankAccount With {
            .amount = txtAmount.Text,
            .startBal = txtStartBal.Text
        }
            txtEndBal.Text = bankAccount.Withdraw()
        Catch ex As Exception 'exception object and display in label control on main form
            MessageBox.Show("Please only enter postive number")
            LabelError.Text = ex.Message
        End Try
    End Sub
End Class
