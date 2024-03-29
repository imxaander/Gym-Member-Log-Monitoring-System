﻿Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text.RegularExpressions
Imports System.IO
Public Class AddEmployee
    'Define the CS_DROPSHADOW constant
    Private Const CS_DROPSHADOW As Integer = 131072

    ' Override the CreateParams property
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property
    Private Sub AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set restrictions to date pickers
        DateOfBirthPicker.MaxDate = DateTime.Now

        'StartDatePicker.MinDate = DateTime.Now
        'EndDatePicker.MinDate = DateTime.Now
    End Sub
    Private Sub AddEmployeeButton_Click(sender As Object, e As EventArgs) Handles AddEmployeeButton.Click
        If CheckAddFields() Then

            Dim sqlCommand = New SqlCommand("SELECT TOP 1 * FROM [Member] ORDER BY ID DESC", conn)


            'create values for member information'
            Dim employeeId = GenerateUID(9)
            Dim lastName = LastNameTextBox.Text
            Dim firstName = FirstNameTextBox.Text
            Dim middleName = MiddleNameTextBox.Text
            Dim dob = DateOfBirthPicker.Text
            Dim gender = GenderBox.Text
            Dim contact = ContactTextBox.Text
            Dim address = AddressTextBox.Text

            Try
                Dim d As Date = Date.Now()
                Dim df As String = d.ToString("yyyy/MM")
                Dim sql = "INSERT INTO [Employee]([employee_id],[last_name],[first_name],[middle_name],[dob],[gender],[contact],[address]) 
                            VALUES('" & df & "' + '/' +
                                CONVERT(VARCHAR, (SELECT COUNT(*) FROM Employee)), '" & lastName & "', '" & firstName & "', '" & middleName & "','" & dob & "','" & gender & "','" & contact & "','" & address & "')"

                Dim sqlcom As New SqlCommand(sql, conn)
                conn.Open()
                If sqlcom.ExecuteNonQuery > 0 Then
                    MessageBox.Show("Added to Database.")
                    conn.Close()
                    ClearFields()
                    Main.LoadMemberOverView()
                End If
            Catch ex As Exception
                MessageBox.Show("SQL Error: " + ex.Message)
                conn.Close()
            End Try
        End If
    End Sub

    Private Function CheckAddFields() As Boolean
        Dim valid As Boolean

        Dim contactRegex As Regex = New Regex("^(09|\+639)\d{9}$")
        Dim contactRegexMatch As Match = contactRegex.Match(ContactTextBox.Text)

        If LastNameTextBox.Text = "" Then
            MessageBox.Show("Missing Field : " + "Last Name")
            valid = False
        ElseIf FirstNameTextBox.Text = "" Then
            MessageBox.Show("Missing Field : " + "First Name")
            valid = False
        ElseIf MiddleNameTextBox.Text = "" Then
            MessageBox.Show("Missing Field : " + "Middle Name")
            valid = False
        ElseIf GenderBox.Text = "" Then
            MessageBox.Show("Missing Field : " + "Gender")
            valid = False
        ElseIf AddressTextBox.Text = "" Then
            MessageBox.Show("Missing Field : " + "Address")
            valid = False
        ElseIf Not contactRegexMatch.Success Then
            MessageBox.Show("Wrong Format : " + "Contact No")

            valid = False
        Else
            valid = True
        End If
        Return valid

    End Function

    Private Sub CancelAddButton_Click(sender As Object, e As EventArgs) Handles CancelAddButton.Click
        Me.Close()
    End Sub

    Private Sub ClearFieldsButton_Click(sender As Object, e As EventArgs) Handles ClearFieldsButton.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        LastNameTextBox.Text = ""
        FirstNameTextBox.Text = ""
        MiddleNameTextBox.Text = ""
        DateOfBirthPicker.Text = ""
        GenderBox.Text = ""
        ContactTextBox.Text = ""
        AddressTextBox.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub

#Region " Move Form "

    ' [ Move Form ]
    '
    ' // By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles AddEmployeeTopPanel.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles AddEmployeeTopPanel.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles AddEmployeeTopPanel.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    'text only
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LastNameTextBox.KeyPress, FirstNameTextBox.KeyPress, MiddleNameTextBox.KeyPress, AddressTextBox.KeyPress
        ' Allow only letters and numbers
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'number only
    Private Sub NumBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContactTextBox.KeyPress
        ' Allow only letters and numbers
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
#End Region

End Class

