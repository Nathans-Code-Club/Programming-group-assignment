.' Originak Form1.vb created by Caleb
'Form1.vb re-written and remastered by Nathan_Busse

Imports System.IO

Public Class Form1

    ' Declare an array to store customer details.
    Dim clientDetails(0) As String

    ' Button click event to save customer details.
    Private Sub (sender As Object, e As EventArgs, Location_Textbox As TextBox, Name_Textbox As TextBox, Surname_Textbox As TextBox, Age_Textbox As TextBox, Occupation_Textbox As TextBox) Handles Save_Button.click


        Try
            Dim Records As String
            ' Get client detaols from the textboxes
            ' To so this Nathan used an Array dataset to create the clientlistr.

            clientDetails(1) = Name_Textbox.Text()
            clientDetails(2) = Surname_Textbox.Text()
            clientDetails(3) = Age_Textbox.Text()
            clientDetails(4) = Occupation_Textbox.Text()
            clientDetails(5) = Location_Textbox.Text()
            clientDetails(6) = DateTime.ToString()

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

    Private Sub Open_Button.Click(sender As Object, e As EventArgs) Handles Open_Button.Click
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

    Private Sub Save_Button.Click(sender As Object, e As EventArgs) Handles Save_Button.Click
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