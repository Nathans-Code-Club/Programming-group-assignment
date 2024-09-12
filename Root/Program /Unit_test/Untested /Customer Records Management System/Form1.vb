Imports System.IO

Public Class Form1
    Private filePath As String = "C:\Users\Nathan\Desktop\Education\customer_record_system\Container\customerRecords.txt"
    Private backupPath As String = "C:\Users\Nathan\Desktop\Education\customer_record_system\Container\customerRecords_backup.txt"

    ' Set default placeholder text when the form loads
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetPlaceholders()
    End Sub

    ' Set initial placeholder text for all TextBoxes
    Private Sub SetPlaceholders()
        Name_TextBox.Text = "What's your Name"
        Surname_TextBox.Text = "What's your Surname"
        Age_TextBox.Text = "How old are you"
        Occupation_TextBox.Text = "Your Field of work"
        Location_TextBox.Text = "Your Local Suburb"
    End Sub

    ' Placeholder logic for Name_TextBox
    Private Sub Name_TextBox_Enter(sender As Object, e As EventArgs) Handles Name_TextBox.Enter
        If Name_TextBox.Text = "What's your Name" Then
            Name_TextBox.Text = ""
        End If
    End Sub

    Private Sub Name_TextBox_Leave(sender As Object, e As EventArgs) Handles Name_TextBox.Leave
        If String.IsNullOrWhiteSpace(Name_TextBox.Text) Then
            Name_TextBox.Text = "What's your Name"
        End If
    End Sub

    ' Placeholder logic for Surname_TextBox
    Private Sub Surname_TextBox_Enter(sender As Object, e As EventArgs) Handles Surname_TextBox.Enter
        If Surname_TextBox.Text = "What's your Surname" Then
            Surname_TextBox.Text = ""
        End If
    End Sub

    Private Sub Surname_TextBox_Leave(sender As Object, e As EventArgs) Handles Surname_TextBox.Leave
        If String.IsNullOrWhiteSpace(Surname_TextBox.Text) Then
            Surname_TextBox.Text = "What's your Surname"
        End If
    End Sub

    ' Placeholder logic for Age_TextBox
    Private Sub Age_TextBox_Enter(sender As Object, e As EventArgs) Handles Age_TextBox.Enter
        If Age_TextBox.Text = "How old are you" Then
            Age_TextBox.Text = ""
        End If
    End Sub

    Private Sub Age_TextBox_Leave(sender As Object, e As EventArgs) Handles Age_TextBox.Leave
        If String.IsNullOrWhiteSpace(Age_TextBox.Text) Then
            Age_TextBox.Text = "How old are you"
        End If
    End Sub

    ' Placeholder logic for Occupation_TextBox
    Private Sub Occupation_TextBox_Enter(sender As Object, e As EventArgs) Handles Occupation_TextBox.Enter
        If Occupation_TextBox.Text = "Your Field of work" Then
            Occupation_TextBox.Text = ""
        End If
    End Sub

    Private Sub Occupation_TextBox_Leave(sender As Object, e As EventArgs) Handles Occupation_TextBox.Leave
        If String.IsNullOrWhiteSpace(Occupation_TextBox.Text) Then
            Occupation_TextBox.Text = "Your Field of work"
        End If
    End Sub

    ' Placeholder logic for Location_TextBox
    Private Sub Location_TextBox_Enter(sender As Object, e As EventArgs) Handles Location_TextBox.Enter
        If Location_TextBox.Text = "Your Local Suburb" Then
            Location_TextBox.Text = ""
        End If
    End Sub

    Private Sub Location_TextBox_Leave(sender As Object, e As EventArgs) Handles Location_TextBox.Leave
        If String.IsNullOrWhiteSpace(Location_TextBox.Text) Then
            Location_TextBox.Text = "Your Local Suburb"
        End If
    End Sub

    ' Save Button Logic
    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        Try
            Dim name As String = Name_TextBox.Text
            Dim surname As String = Surname_TextBox.Text
            Dim age As String = Age_TextBox.Text
            Dim occupation As String = Occupation_TextBox.Text
            Dim location As String = Location_TextBox.Text

            If String.IsNullOrWhiteSpace(name) OrElse String.IsNullOrWhiteSpace(surname) OrElse
               String.IsNullOrWhiteSpace(age) OrElse String.IsNullOrWhiteSpace(occupation) OrElse
               String.IsNullOrWhiteSpace(location) Then
                MessageBox.Show("Please fill in all fields.")
                Return
            End If

            Dim record As String = $"{name},{surname},{age},{occupation},{location},{DateTime.Now:yyyy-MM-dd HH:mm:ss}"
            File.AppendAllText(filePath, record & Environment.NewLine)

            MessageBox.Show("Record saved successfully.")
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving the record: " & ex.Message)
        End Try
    End Sub

    ' Open Button Logic
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

    ' Clear Button Logic
    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        Name_TextBox.Clear()
        Surname_TextBox.Clear()
        Age_TextBox.Clear()
        Occupation_TextBox.Clear()
        Location_TextBox.Clear()
        Output_Display.Clear()
        SetPlaceholders() ' Reset the placeholders after clearing
    End Sub

    ' Exit Button Logic
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    ' Backup logic for Save Button
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
End Class