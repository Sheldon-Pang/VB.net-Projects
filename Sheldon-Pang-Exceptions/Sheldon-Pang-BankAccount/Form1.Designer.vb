<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStartBal = New System.Windows.Forms.TextBox()
        Me.txtAccNum = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtEndBal = New System.Windows.Forms.TextBox()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Account Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Starting Account Balance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Transaction Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Account Balance"
        '
        'txtStartBal
        '
        Me.txtStartBal.Location = New System.Drawing.Point(228, 121)
        Me.txtStartBal.Name = "txtStartBal"
        Me.txtStartBal.Size = New System.Drawing.Size(156, 22)
        Me.txtStartBal.TabIndex = 1
        '
        'txtAccNum
        '
        Me.txtAccNum.Enabled = False
        Me.txtAccNum.Location = New System.Drawing.Point(228, 78)
        Me.txtAccNum.Name = "txtAccNum"
        Me.txtAccNum.ReadOnly = True
        Me.txtAccNum.Size = New System.Drawing.Size(156, 22)
        Me.txtAccNum.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(228, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(156, 22)
        Me.txtName.TabIndex = 1
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(228, 166)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(156, 22)
        Me.txtAmount.TabIndex = 1
        '
        'txtEndBal
        '
        Me.txtEndBal.Enabled = False
        Me.txtEndBal.Location = New System.Drawing.Point(228, 210)
        Me.txtEndBal.Name = "txtEndBal"
        Me.txtEndBal.ReadOnly = True
        Me.txtEndBal.Size = New System.Drawing.Size(156, 22)
        Me.txtEndBal.TabIndex = 1
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(82, 278)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(119, 46)
        Me.btnDeposit.TabIndex = 2
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Location = New System.Drawing.Point(242, 278)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(119, 46)
        Me.btnWithdraw.TabIndex = 2
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(101, 348)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 37)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(254, 348)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 37)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Location = New System.Drawing.Point(56, 420)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(165, 17)
        Me.LabelError.TabIndex = 3
        Me.LabelError.Text = "Exception error message"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 473)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtAccNum)
        Me.Controls.Add(Me.txtEndBal)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtStartBal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Bichen Pang - BankAccount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStartBal As TextBox
    Friend WithEvents txtAccNum As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtEndBal As TextBox
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents LabelError As Label
End Class
