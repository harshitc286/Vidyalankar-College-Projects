Public Class bankd

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cls_Click(sender As Object, e As EventArgs) Handles cls.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        home.managername.Text = TextBox1.Text
        home.brnamee.Text = TextBox2.Text
        home.Label6.Text = TextBox3.Text
        MsgBox("Bank Details Updated")



    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click

    End Sub
End Class