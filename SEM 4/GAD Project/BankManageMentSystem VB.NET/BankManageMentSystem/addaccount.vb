Public Class addaccount

    Private Sub addaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankaccountsDataSet1.baccounts' table. You can move, or remove it, as needed.
        Me.BaccountsTableAdapter.Fill(Me.BankaccountsDataSet.baccounts)

    End Sub
  

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDb.OleDbConnection

        con.ConnectionString = "PROVIDER = Microsoft.Ace.OLEDB.12.0; Data Source =H:\Coding\Vidyalankar Clg Project\SEM 4\GAD Project\Bank Management System DataBase\bankaccounts.accdb"


        Dim SqlString As String = "Insert Into [baccounts] (Acc_Id,Acc_Name,PhoneNumber,Address,Email,AdharNumber) Values (TextBox1,TextBox2,TextBox3,TextBox4,TextBox5,TextBox6)"

        Using conn As New OleDb.OleDbConnection(con.ConnectionString)

            Using cmd As New OleDb.OleDbCommand(SqlString, con)



                cmd.CommandType = CommandType.Text

                cmd.Parameters.AddWithValue("column", TextBox1.Text)

                cmd.Parameters.AddWithValue("column", TextBox2.Text)
                cmd.Parameters.AddWithValue("column", TextBox3.Text)
                cmd.Parameters.AddWithValue("column", TextBox4.Text)
                cmd.Parameters.AddWithValue("column", TextBox5.Text)
                cmd.Parameters.AddWithValue("column", TextBox6.Text)


                con.Open()

                cmd.ExecuteNonQuery()
                MsgBox("Account added Successfully")

                Me.DataGridView1.Refresh()

                con.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub cls_Click(sender As Object, e As EventArgs) Handles cls.Click
        Me.Close()

    End Sub

    Private Sub DepositToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepositToolStripMenuItem.Click
        Deposit.Show()


    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        home.Show()

    End Sub

    Private Sub AddAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAccountToolStripMenuItem.Click
        Me.Show()


    End Sub

    Private Sub UpdateAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAccountToolStripMenuItem.Click
        updateaccount.Show()

    End Sub

    Private Sub DeleteAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAccountToolStripMenuItem.Click
        deleteaccount.Show()

    End Sub

    Private Sub WithdrawToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithdrawToolStripMenuItem.Click
        Withdraw.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

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
End Class