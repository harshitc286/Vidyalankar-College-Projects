Public Class deleteaccount

    Private Sub deleteaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankaccountsDataSet1.baccounts' table. You can move, or remove it, as needed.
        Me.BaccountsTableAdapter.Fill(Me.BankaccountsDataSet.baccounts)




        

    End Sub

    Private Sub cls_Click(sender As Object, e As EventArgs) Handles cls.Click
        Me.Close()
        home.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDb.OleDbConnection

        con.ConnectionString = "PROVIDER = Microsoft.Ace.OLEDB.12.0; Data Source =C:\Users\suyash ekhande\Desktop\desk\bankmanagementsystem\project\BankManageMentSystem\BankManageMentSystem\bankaccounts.accdb"


        Dim SqlString As String = "delete from [baccounts] where Acc_Id = Textbox1.Text "

        Using conn As New OleDb.OleDbConnection(con.ConnectionString)



            Using cmd As New OleDb.OleDbCommand(SqlString, con)



                cmd.CommandType = CommandType.Text

                cmd.Parameters.AddWithValue("column", TextBox1.Text)

                


                con.Open()
                MsgBox("Account deleted!!")
                BaccountsTableAdapter.Update(BankaccountsDataSet1.baccounts)
                Me.DataGridView1.Refresh()


                cmd.ExecuteNonQuery()




            End Using
        End Using
    End Sub

    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        home.Show()

    End Sub

    Private Sub AddAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAccountToolStripMenuItem.Click
        addaccount.Show()

    End Sub

    Private Sub UpdateAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAccountToolStripMenuItem.Click
        updateaccount.Show()
    End Sub

    Private Sub DeleteAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAccountToolStripMenuItem.Click
        Me.Show()

    End Sub

    Private Sub DepositToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepositToolStripMenuItem.Click
        Deposit.Show()

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

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        Help.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class