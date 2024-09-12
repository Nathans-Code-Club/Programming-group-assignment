<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.Open_Button = New System.Windows.Forms.Button()
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Output_Display = New System.Windows.Forms.RichTextBox()
        Me.Name_TextBox = New System.Windows.Forms.TextBox()
        Me.Surname_TextBox = New System.Windows.Forms.TextBox()
        Me.Age_TextBox = New System.Windows.Forms.TextBox()
        Me.Occupation_TextBox = New System.Windows.Forms.TextBox()
        Me.Location_TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Save_Button
        '
        Me.Save_Button.Location = New System.Drawing.Point(178, 383)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(75, 23)
        Me.Save_Button.TabIndex = 0
        Me.Save_Button.Text = "Save"
        Me.Save_Button.UseVisualStyleBackColor = True
        '
        'Open_Button
        '
        Me.Open_Button.Location = New System.Drawing.Point(335, 383)
        Me.Open_Button.Name = "Open_Button"
        Me.Open_Button.Size = New System.Drawing.Size(75, 23)
        Me.Open_Button.TabIndex = 1
        Me.Open_Button.Text = "Open"
        Me.Open_Button.UseVisualStyleBackColor = True
        '
        'Clear_Button
        '
        Me.Clear_Button.Location = New System.Drawing.Point(484, 383)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(75, 23)
        Me.Clear_Button.TabIndex = 2
        Me.Clear_Button.Text = "Clear"
        Me.Clear_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(645, 383)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Exit_Button.TabIndex = 3
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Output_Display
        '
        Me.Output_Display.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Output_Display.Location = New System.Drawing.Point(178, 42)
        Me.Output_Display.Name = "Output_Display"
        Me.Output_Display.Size = New System.Drawing.Size(542, 303)
        Me.Output_Display.TabIndex = 4
        Me.Output_Display.Text = "Output:"
        '
        'Name_TextBox
        '
        Me.Name_TextBox.Location = New System.Drawing.Point(24, 42)
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.Size = New System.Drawing.Size(134, 20)
        Me.Name_TextBox.TabIndex = 5
        Me.Name_TextBox.Text = "Whats your Name"
        Me.Name_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Surname_TextBox
        '
        Me.Surname_TextBox.Location = New System.Drawing.Point(24, 104)
        Me.Surname_TextBox.Name = "Surname_TextBox"
        Me.Surname_TextBox.Size = New System.Drawing.Size(134, 20)
        Me.Surname_TextBox.TabIndex = 6
        Me.Surname_TextBox.Text = "Whats your Surname"
        Me.Surname_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Age_TextBox
        '
        Me.Age_TextBox.Location = New System.Drawing.Point(24, 178)
        Me.Age_TextBox.Name = "Age_TextBox"
        Me.Age_TextBox.Size = New System.Drawing.Size(134, 20)
        Me.Age_TextBox.TabIndex = 7
        Me.Age_TextBox.Text = "How old are you"
        Me.Age_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Occupation_TextBox
        '
        Me.Occupation_TextBox.Location = New System.Drawing.Point(24, 246)
        Me.Occupation_TextBox.Name = "Occupation_TextBox"
        Me.Occupation_TextBox.Size = New System.Drawing.Size(134, 20)
        Me.Occupation_TextBox.TabIndex = 8
        Me.Occupation_TextBox.Text = "Your Field of work"
        Me.Occupation_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Location_TextBox
        '
        Me.Location_TextBox.Location = New System.Drawing.Point(24, 325)
        Me.Location_TextBox.Name = "Location_TextBox"
        Me.Location_TextBox.Size = New System.Drawing.Size(134, 20)
        Me.Location_TextBox.TabIndex = 9
        Me.Location_TextBox.Text = "Your Local Suberb"
        Me.Location_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Location_TextBox)
        Me.Controls.Add(Me.Occupation_TextBox)
        Me.Controls.Add(Me.Age_TextBox)
        Me.Controls.Add(Me.Surname_TextBox)
        Me.Controls.Add(Me.Name_TextBox)
        Me.Controls.Add(Me.Output_Display)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Clear_Button)
        Me.Controls.Add(Me.Open_Button)
        Me.Controls.Add(Me.Save_Button)
        Me.Name = "Form1"
        Me.Text = "Customer Records Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Save_Button As Button
    Friend WithEvents Open_Button As Button
    Friend WithEvents Clear_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Output_Display As RichTextBox
    Friend WithEvents Name_TextBox As TextBox
    Friend WithEvents Surname_TextBox As TextBox
    Friend WithEvents Age_TextBox As TextBox
    Friend WithEvents Occupation_TextBox As TextBox
    Friend WithEvents Location_TextBox As TextBox
End Class
