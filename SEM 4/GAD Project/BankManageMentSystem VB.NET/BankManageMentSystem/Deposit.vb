Public Class Deposit

    Private Sub cls_Click(sender As Object, e As EventArgs) Handles cls.Click
        Me.Hide()
    End Sub

    Private Sub Deposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankaccountsDataSet.baccounts' table. You can move, or remove it, as needed.
        Me.BaccountsTableAdapter.Fill(Me.BankaccountsDataSet.baccounts)
        dat.Text = Date.Now.ToString("MM/dd/yyyy")
        Timer1.Start()


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub dat_Click(sender As Object, e As EventArgs) Handles dat.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        clock.Text = TimeOfDay
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New OleDb.OleDbConnection

        con.ConnectionString = "PROVIDER = Microsoft.Ace.OLEDB.12.0; Data Source =F:\Sem.4\extra vs code\bankmanagementsystem\bankmanagementsystem\project\BankManageMentSystem\BankManageMentSystem\bankaccounts.accdb"


        Dim SqlString As String = "update [baccounts] set [Balance] = Balance+@TextBox2.Text where [Acc_Id] = @TextBox1.Text"

        Using conn As New OleDb.OleDbConnection(con.ConnectionString)

            Using cmd As New OleDb.OleDbCommand(SqlString, con)



                cmd.CommandType = CommandType.Text

                cmd.Parameters.AddWithValue("column", TextBox2.Text)
                cmd.Parameters.AddWithValue("column", TextBox1.Text)
                con.Open()

                MsgBox("Amount Deposited Successfully")

                cmd.ExecuteNonQuery()
                Me.DataGridView1.Refresh()

                TextBox2.Text = ""
                TextBox1.Text = ""

            End Using
        End Using
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        home.Show()

    End Sub

    Private Sub AccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountsToolStripMenuItem.Click

    End Sub

    Private Sub AddAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAccountToolStripMenuItem.Click
        addaccount.Show()

    End Sub

    Private Sub UpdateAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAccountToolStripMenuItem.Click
        updateaccount.Show()


    End Sub

    Private Sub DeleteAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAccountToolStripMenuItem.Click
        deleteaccount.Show()
    End Sub

    Private Sub DepositToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepositToolStripMenuItem.Click
        Me.Show()

    End Sub

    Private Sub WithdrawToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithdrawToolStripMenuItem.Click
        Withdraw.Show()

    End Sub

    Private Sub RegisterProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterProductToolStripMenuItem.Click
        Register.Show()

    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        about.Show()

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Help.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub
End Class