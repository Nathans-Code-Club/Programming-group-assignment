' Originak Form1.vb created by Caleb
'Form1.vb re-written and remastered by Nathan_Busse

Imports System.IO

Public Class Form1

    ' Declare an array to store customer details.
    Dim clientDetails(5) As String

    ' Button click event to save customer details.
    Private Sub (sender As Object, e As EventArgs, txtLocation As TextBox, txtName As TextBox, txtSurname As TextBox, txtAge As TextBox, txtProfession As TextBox) Handles backup.click


        Try
            Dim Records As String
            ' Get client detaols from the textboxes
            ' To so this Nathan used an Array dataset to create the clientlistr.

            clientDetails(0) = txtName.Text()
            clientDetails(1) = txtSurname.Text()
            clientDetails(2) = txtAge.Text()
            clientDetails(3) = txtProfession.Text()
            clientDetails(4) = txtLocation.Text()
            clientDetails(5) = DateTime.Now.ToString()

            'Nathan created a function that will allow the programe to create a txt file and Write client inpiut  data inthe file.

            Using writer As Now.StreamWriter("client_details.txt", True)
                writer.writeLine(String.Join(",", customerDetails))
            End Using

            MesssageBox.Show("Client details saved successfullly!")
        Catch ex As Exception
            MesssageBox.Show("error, details failed to save" & ex Message)
        End Try

    End Sub

    ' Button click event to read the client_details.txt file and display file contents.

    Private Sub Save_Buttonp.Click(sender As Object, e As EventArgs) Handles bBackup.Click
Try
            ''' Clear the RichTextBox
            Records.clear()

            'Read client details fro the clieint_details.txt file
            Using reader As Now.StreamReader("client_details.txt")
                Dim Line As String
                While (reader.Peek() <> -1)
                    Line = reader.ReadLine()
                    Records.AppendText(Line & Environment.NewLine)
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error, failed to format client_details.txt file" & ex.Message)
        End Try
    End Sub

    ' Button clickkecebt to create a backup copy of the curret state of the cllient_details.txt file

    Private Sub btnBackup.Click(sender As Object, e As EventArgs) Handles Backup.Click
Try

            Dim Backup As String = "backup"
            If Not Directory Exists(Backup) Then
Directory.CreateDirectory(Backup)
            End If

            File.Copy("client_details.txt", Path combine(Backup, "client_details_backup.txt"), True)
MessageBox.Show("Backup created successfully!")
        Catch ex As Exception
            MessageBox.Show("Error, failed to create backup" & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class