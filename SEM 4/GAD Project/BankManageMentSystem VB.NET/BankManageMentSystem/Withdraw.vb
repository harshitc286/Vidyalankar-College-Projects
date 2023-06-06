Public Class Withdraw

    Private Sub AddAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAccountToolStripMenuItem.Click

    End Sub

    Private Sub cls_Click(sender As Object, e As EventArgs) Handles cls.Click
        Me.Hide()

    End Sub

    Private Sub Withdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankaccountsDataSet.baccounts' table. You can move, or remove it, as needed.
        Me.BaccountsTableAdapter.Fill(Me.BankaccountsDataSet.baccounts)
        dat.Text = Date.Now.ToString("MM/dd/yyyy")
        Timer1.Start()

    End Sub

    Private Sub dat_Click(sender As Object, e As EventArgs) Handles dat.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        clock.Text = TimeOfDay

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New OleDb.OleDbConnection

        con.ConnectionString = "PROVIDER = Microsoft.Ace.OLEDB.12.0; Data Source =F:\Sem.4\extra vs code\bankmanagementsystem\bankmanagementsystem\project\BankManageMentSystem\BankManageMentSystem\bankaccounts.accdb"


        Dim SqlString As String = "update [baccounts] set [Balance] = Balance-@TextBox2.Text where [Acc_Id] = @TextBox1.Text"

        Using conn As New OleDb.OleDbConnection(con.ConnectionString)

            Using cmd As New OleDb.OleDbCommand(SqlString, con)



                cmd.CommandType = CommandType.Text

                cmd.Parameters.AddWithValue("column", TextBox2.Text)
                cmd.Parameters.AddWithValue("column", TextBox1.Text)
                con.Open()

                MsgBox("Amount Withdrawn Successfully")

                cmd.ExecuteNonQuery()
                Me.DataGridView1.Refresh()

                TextBox2.Text = ""
                TextBox1.Text = ""

            End Using
        End Using
    End Sub
End Class