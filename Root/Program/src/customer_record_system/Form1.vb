Imports System.IO

Public Class Form1
    Private filePath As String = "C:\Users\Nathan\Desktop\Education\customer_record_system\Container\customerRecords.txt"
    Private backupPath As String = "C:\Users\Nathan\Desktop\Education\customer_record_system\Container\customerRecords_backup.txt"

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim name As String = txtName.Text
            Dim surname As String = txtSurname.Text
            Dim age As String = txtAge.Text
            Dim occupation As String = txtOccupation.Text
            Dim location As String = txtLocation.Text
            Dim dateTime As Integer = DateAndTime.DateString = (CType("yyyy-MM-dd HH:mm:ss", String))

            If String.IsNullOrWhiteSpace(name) OrElse String.IsNullOrWhiteSpace(surname) OrElse
               String.IsNullOrWhiteSpace(age) OrElse String.IsNullOrWhiteSpace(occupation) OrElse
               String.IsNullOrWhiteSpace(location) Then
                MessageBox.Show("Please fill in all fields.")
                Return
            End If

            Dim record As String = $"{name},{surname},{age},{occupation},{location},{dateTime}"
            File.AppendAllText(filePath, record & Environment.NewLine)

            MessageBox.Show("Record saved successfully.")
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving the record: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Try
            If File.Exists(filePath) Then
                rtbDisplay.Clear()
                Dim records As String() = File.ReadAllLines(filePath)
                For Each record As String In records
                    rtbDisplay.AppendText(record & Environment.NewLine)
                Next
            Else
                MessageBox.Show("No records found.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while reading the records: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtSurname.Clear()
        txtAge.Clear()
        txtOccupation.Clear()
        txtLocation.Clear()
        rtbDisplay.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If File.Exists(filePath) Then
                Directory.CreateDirectory(Path.GetDirectoryName(backupPath))
                File.Copy(filePath, backupPath, True)
                MessageBox.Show("Backup created successfully.")
            Else
                MessageBox.Show("No file to back up.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while creating the backup: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
