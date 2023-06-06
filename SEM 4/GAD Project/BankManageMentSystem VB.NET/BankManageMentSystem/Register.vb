Public Class Register

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Settings.registered = False Then

            If TextBox1.Text = "123456789" Then
                MsgBox("Product Registered Successfully")
                My.Settings.registered = True
                My.Settings.Save()


            Else
                MsgBox("Nothing here for you...")

            End If

        ElseIf My.Settings.registered = True Then

            MsgBox(" already registered")

        End If
    End Sub
End Class