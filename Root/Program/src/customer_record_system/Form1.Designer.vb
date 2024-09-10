<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtSurname = New TextBox()
        txtAge = New TextBox()
        txtOccupation = New TextBox()
        txtLocation = New TextBox()
        btnSave = New Button()
        btnRead = New Button()
        rtbDisplay = New RichTextBox()
        btnClear = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(111, 108)
        txtName.Name = "txtName"
        txtName.Size = New Size(100, 23)
        txtName.TabIndex = 0
        txtName.Text = "Name"
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(111, 149)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(100, 23)
        txtSurname.TabIndex = 1
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(111, 188)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(100, 23)
        txtAge.TabIndex = 2
        ' 
        ' txtOccupation
        ' 
        txtOccupation.Location = New Point(111, 221)
        txtOccupation.Name = "txtOccupation"
        txtOccupation.Size = New Size(100, 23)
        txtOccupation.TabIndex = 3
        ' 
        ' txtLocation
        ' 
        txtLocation.Location = New Point(111, 261)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(100, 23)
        txtLocation.TabIndex = 4
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(350, 310)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 5
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnRead
        ' 
        btnRead.Location = New Point(448, 310)
        btnRead.Name = "btnRead"
        btnRead.Size = New Size(75, 23)
        btnRead.TabIndex = 6
        btnRead.Text = "Open"
        btnRead.UseVisualStyleBackColor = True
        ' 
        ' rtbDisplay
        ' 
        rtbDisplay.Location = New Point(336, 108)
        rtbDisplay.Name = "rtbDisplay"
        rtbDisplay.Size = New Size(396, 176)
        rtbDisplay.TabIndex = 7
        rtbDisplay.Text = ""
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(576, 310)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(687, 310)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 9
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(rtbDisplay)
        Controls.Add(btnRead)
        Controls.Add(btnSave)
        Controls.Add(txtLocation)
        Controls.Add(txtOccupation)
        Controls.Add(txtAge)
        Controls.Add(txtSurname)
        Controls.Add(txtName)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtOccupation As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents rtbDisplay As RichTextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button

End Class
