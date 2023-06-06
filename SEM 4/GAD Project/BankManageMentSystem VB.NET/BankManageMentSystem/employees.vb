Public Class employees

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New OleDb.OleDbConnection

        con.ConnectionString = "PROVIDER = Microsoft.Ace.OLEDB.12.0; Data Source =C:\Users\suyash ekhande\Desktop\desk\bankmanagementsystem\project\BankManageMentSystem\BankManageMentSystem\bemployees.accdb"


        Dim SqlString As String = "Insert Into [bemployees] (Emp_ID,Emp_Name,Phone,Address,Email,Job,salary) Values (TextBox1,TextBox2,TextBox3,TextBox4,TextBox5,ComboBox1,TextBox6.Text)"

        Using conn As New OleDb.OleDbConnection(con.ConnectionString)



            Using cmd As New OleDb.OleDbCommand(SqlString, con)



                cmd.CommandType = CommandType.Text

                cmd.Parameters.AddWithValue("column", TextBox1.Text)

                cmd.Parameters.AddWithValue("column", TextBox2.Text)
                cmd.Parameters.AddWithValue("column", TextBox3.Text)
                cmd.Parameters.AddWithValue("column", TextBox4.Text)
                cmd.Parameters.AddWithValue("column", TextBox5.Text)
                cmd.Parameters.AddWithValue("column", ComboBox1.Text)
                cmd.Parameters.AddWithValue("column", TextBox6.Text)


                con.Open()

                cmd.ExecuteNonQuery()
                MsgBox("Account added Successfully")



                con.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                ComboBox1.Text = ""
                TextBox6.Text = ""

            End Using
        End Using
    End Sub

    Private Sub addemployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BemployeesDataSet1.bemployees' table. You can move, or remove it, as needed.




    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New OleDb.OleDbConnection

        con.ConnectionString = "PROVIDER = Microsoft.Ace.OLEDB.12.0; Data Source =C:\Users\suyash ekhande\Desktop\desk\bankmanagementsystem\project\BankManageMentSystem\BankManageMentSystem\bemployees.accdb"


        Dim SqlString As String = "delete from [bemployees] where Emp_ID = @TextBox7.Text "

        Using conn As New OleDb.OleDbConnection(con.ConnectionString)



            Using cmd As New OleDb.OleDbCommand(SqlString, con)



                cmd.CommandType = CommandType.Text

                cmd.Parameters.AddWithValue("column", TextBox7.Text)




                con.Open()
                MsgBox("Account deleted!!")



                cmd.ExecuteNonQuery()




            End Using
        End Using
    End Sub
End Class