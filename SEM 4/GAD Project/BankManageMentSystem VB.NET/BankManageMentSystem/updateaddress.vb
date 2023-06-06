Public Class updateaddress

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDb.OleDbConnection

        con.ConnectionString = "PROVIDER = Microsoft.Ace.OLEDB.12.0; Data Source =C:\Users\suyash ekhande\Desktop\desk\bankmanagementsystem\project\BankManageMentSystem\BankManageMentSystem\bankaccounts.accdb"


        Dim SqlString As String = "update [baccounts] set [Address] = @TextBox2.Text where [Acc_Id] = @TextBox1.Text"

        Using conn As New OleDb.OleDbConnection(con.ConnectionString)

            Using cmd As New OleDb.OleDbCommand(SqlString, con)



                cmd.CommandType = CommandType.Text

                cmd.Parameters.AddWithValue("column", TextBox2.Text)
                cmd.Parameters.AddWithValue("column", TextBox1.Text)

                con.Open()

                MsgBox("Address Updated Successfully")

                cmd.ExecuteNonQuery()

                TextBox2.Text = ""
                TextBox1.Text = ""

            End Using
        End Using
    End Sub

    Private Sub updateaddress_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class