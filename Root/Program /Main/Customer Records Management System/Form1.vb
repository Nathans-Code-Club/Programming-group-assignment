Imports System.IO

Public Class Form1
    Private filePath As String = "C:\Users\Nathan\Desktop\Education\customer_record_system\Container\customerRecords.txt"
    Private backupPath As String = "C:\Users\Nathan\Desktop\Education\customer_record_system\Container\customerRecords_backup.txt"

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        Try
            Dim name As String = Name_TextBox.Text
            Dim surname As String = Surname_TextBox.Text
            Dim age As String = Age_TextBox.Text
            Dim occupation As String = Occupation_TextBox.Text
            Dim location As String = Location_TextBox.Text
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

    Private Sub Open_Button_Click(sender As Object, e As EventArgs) Handles Open_Button.Click
        Try
            If File.Exists(filePath) Then
                Output_Display.Clear()
                Dim records As String() = File.ReadAllLines(filePath)
                For Each record As String In records
                    Output_Display.AppendText(record & Environment.NewLine)
                Next
            Else
                MessageBox.Show("No records found.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while reading the records: " & ex.Message)
        End Try
    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        Name_TextBox.Clear()
        Surname_TextBox.Clear()
        Age_TextBox.Clear()
        Occupation_TextBox.Clear()
        Location_TextBox.Clear()
        Output_Display.Clear()
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub Save_ButtonClick(sender As Object, e As EventArgs) Handles Save_Button.Click
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
