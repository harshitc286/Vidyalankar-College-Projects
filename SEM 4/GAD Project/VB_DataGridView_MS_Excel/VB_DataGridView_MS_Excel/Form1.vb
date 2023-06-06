
Imports Excel = Miccosoft Office.Interop.Excel
Imports System.Drawing.Printing
Imports Systems.Data.DataTable
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports System.IO

Public Class Form1

    Private bitmap As Bitmap
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Try
            Dim iExit As DialogResult

            iExit = MessageBox.Show("Confirm if you want to exit", "Add Data and Save", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
            If iExit = DialogResult.Yes Then
                Application.Exit()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add Data and Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        btnExit_Click(sender, e)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        DataGridView1.Rows.Add(txtStudent_ID.Text, txtFirstname.Text, txtSurname.Text, txtDOB.Text, txtAddress.Text,
        cmbGender.Text, txtMobile.Text, txtEmail.Text)
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        btnAddNew_Click(sender, e)
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim height As Integer = DataGridView1.Height
            DataGridView1.Height = (DataGridView1.RowCount + 1) * DataGridView1.RowTemplate.Height
            bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
            DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            PrintPreviewDialog1.ShowDialog()
            DataGridView1.Height = height

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Try
            e.Graphics.DrawImage(bitmap, 0, 0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        btnPrint_Click(sender, e)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Try
            Dim txt
            For Each txt In Panel2.Controls
                If TypeOf txt Is TextBox Then
                    txt.text
                End If
            Next
            cmbGender.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveToExcel()

    End Sub
End Class

Private Sub SaveToExcel()


    Dim excel As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application()
    Dim workbook As Microsoft.Office.Interop.Excel._Workbook = excel.Workbooks.Add(Type.Missing)
    Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
    Try
        worksheet = workbook.ActiveSheet
        worksheet.Name = "ExportedFromDatGrid"
        Dim cellowIndex As Integer = 1
        Dim cellColumnIndex As Integer = 1
        For j As Integer = 0 To DataGridView1.Columns.Count - 1
            worksheet.Cells(cellowIndex, cellColumnIndex) = DataGridView1.Columns(j).HeaderText
            cellColumnIndex += 1
        Next
        cellColumnIndex = 1
        cellowIndex += 1

        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            For j As Integer = 0 To DataGridView1.Columns.Count - 1
                worksheet.Cells(cellowIndex, cellColumnIndex) = DataGridView.Rows(i).cells(j).Value.Tostring()
                cellColumnIndex += 1
            Next
            cellColumnIndex = 1
            cellowIndex += 1
        Next

        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveDialog.FilterIndex = 2
        If saveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            workbook.SaveAs(saveDialog.FileName)
            MessageBox.Show("Export Successful")
        End If
    Catch ex As System.Exception
        MessageBox.Show(ex.Message)
    Finally
        excel.Quit()
        workbook = Nothing
        excel = Nothing
    End Try
End Sub
