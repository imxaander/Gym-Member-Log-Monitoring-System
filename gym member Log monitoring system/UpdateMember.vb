﻿Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class UpdateMember

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

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If EditIdTextBox.Text = "" Then
            MessageBox.Show("Please Enter a Member ID!", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim member_info = FetchMemberDetails()
            If Not member_info Is Nothing Then
                MemberIdShowLabel.Text = member_info.member_id
                LastNameEditTextBox.Text = member_info.last_name
                FirstNameEditTextBox.Text = member_info.first_name
                MiddleNameEditTextBox.Text = member_info.middle_name
                DateOfBirthPicker.Value = member_info.dob
                GenderEditTextBox.Text = member_info.gender

                Dim inputString As String = member_info.contact_no
                Dim separatedStrings() As String = inputString.Split("/")

                ContactNoTextBox.Text = separatedStrings(0)
                ContactNoTextBox1.Text = separatedStrings(1)
                ContactNoTextBox2.Text = separatedStrings(2)
                AddressEditTextBox.Text = member_info.address
                StartDatePicker.Value = member_info.start_date
                EndDatePicker.Value = member_info.end_date
                DateLeftLabel.Text = (member_info.start_date - member_info.end_date).TotalDays.ToString() + " Day(s) Left"
                ImageEditBox.Image = Image.FromStream(New MemoryStream(CType(member_info.image, Byte())))
            End If
        End If
    End Sub
    Private Function FetchMemberDetails()
        Dim member_id = EditIdTextBox.Text
        Dim member_info As New MemberInfo

        Dim sql = "SELECT * FROM [Member] WHERE member_id = '" & member_id & "'"
        Dim sqlCom As New SqlCommand(sql, conn)
        sqlCom.Connection = conn
        conn.Open()
        Dim sqlRead As SqlDataReader = sqlCom.ExecuteReader()

        If sqlRead.Read() Then
            member_info.member_id = sqlRead("member_id")
            member_info.first_name = sqlRead("first_name")
            member_info.last_name = sqlRead("last_name")
            member_info.middle_name = sqlRead("middle_name")
            member_info.dob = sqlRead("dob")
            member_info.gender = sqlRead("gender")
            member_info.contact_no = sqlRead("contact")
            member_info.address = sqlRead("address")
            member_info.start_date = sqlRead("date_Start")
            member_info.end_date = sqlRead("date_End")
            member_info.image = sqlRead("image")
            member_info.blacklisted = sqlRead("blacklisted")
            sqlRead.Close()
            conn.Close()
        Else
            MessageBox.Show("There's No Such Member with the Member ID!", "Searching Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            member_info = Nothing
            sqlRead.Close()
            conn.Close()
        End If

        Return member_info
    End Function
    Private Class MemberInfo
        Public member_id As String
        Public first_name As String
        Public last_name As String
        Public middle_name As String
        Public dob As Date
        Public gender As String
        Public contact_no As String
        Public address As String
        Public start_date As Date
        Public end_date As Date
        Public image As Byte()
        Public blacklisted As Boolean
    End Class

    Private Sub ImageEditBox_Click(sender As Object, e As EventArgs) Handles ImageEditBox.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image (*.JPG;*.PNG;*.GIF) | *.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            ImageEditBox.Image = Image.FromFile(opf.FileName)
        End If
    End Sub
    Private Function UpdateMember()
        If CheckAddFields() Then

            'initialize values
            Dim member_id = MemberIdShowLabel.Text
            Dim lastName = LastNameEditTextBox.Text
            Dim firstName = FirstNameEditTextBox.Text
            Dim middleName = MiddleNameEditTextBox.Text
            Dim dob = DateOfBirthPicker.Text
            Dim gender = GenderEditTextBox.Text
            Dim contact = ContactNoTextBox.Text + "/" + ContactNoTextBox1.Text + "/" + ContactNoTextBox2.Text
            Dim address = AddressEditTextBox.Text
            Dim dateStart = StartDatePicker.Text
            Dim dateEnd = EndDatePicker.Text
            Dim blacklisted = BlackListCheckBox.Checked

            Dim ms As New MemoryStream
            ImageEditBox.Image.Save(ms, ImageEditBox.Image.RawFormat)
            Dim image = ms.ToArray()
            Try
                Dim sqlcom As New SqlCommand("UPDATE [Member] SET last_name = '" & lastName & "', first_name = '" & firstName & "', middle_name = '" & middleName & "', dob = '" & dob & "', gender = '" & gender & "', contact = '" & contact & "', address = '" & address & "', date_Start = '" & dateStart & "', date_End = '" & dateEnd & "',  image = @image, blacklisted = '" & blacklisted & "' WHERE member_id = '" & member_id & "'", conn)
                sqlcom.Parameters.Add("@image", SqlDbType.Image).Value = image
                conn.Open()
                If sqlcom.ExecuteNonQuery > 0 Then
                    MessageBox.Show("User Updated.")
                    conn.Close()
                    Main.LoadMemberOverView()
                End If
            Catch ex As Exception
                MessageBox.Show("SQL Error: " + ex.Message)
                conn.Close()
            End Try
        End If
    End Function
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        UpdateMember()
    End Sub

    Private Function CheckAddFields() As Boolean
        Dim valid As Boolean
        Dim contactRegex As Regex = New Regex("^(09|\+639)\d{9}$")
        Dim contactRegexMatch As Match = contactRegex.Match(ContactNoTextBox.Text)

        If LastNameEditTextBox.Text = "" Then
            MessageBox.Show("Missing Field : " + "Last Name")
            valid = False
        ElseIf FirstNameEditTextBox.Text = "" Then
            MessageBox.Show("Missing Field : " + "First Name")
            valid = False
        ElseIf MiddleNameEditTextBox.Text = "" Then
            MessageBox.Show("Missing Field : " + "Middle Name")
            valid = False
        ElseIf GenderEditTextBox.Text = "" Then
            MessageBox.Show("Missing Field : " + "Gender")
            valid = False
        ElseIf AddressEditTextBox.Text = "" Then
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

    Private Sub EditIdTextBox_TextChanged(sender As Object, e As EventArgs) Handles EditIdTextBox.TextChanged

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        If Not MemberIdShowLabel.Text Is Nothing Then
            Try
                Dim sqlcom As New SqlCommand("UPDATE [Member] SET visible = 0 WHERE member_id = '" & MemberIdShowLabel.Text & "'", conn)
                conn.Open()
                If ConfirmDialog() = True Then
                    If sqlcom.ExecuteNonQuery > 0 Then
                        MessageBox.Show("Employee Deleted.")
                        conn.Close()
                    Else
                        conn.Close()
                    End If
                Else
                    conn.Close()
                End If
            Catch ex As Exception
                MessageBox.Show("SQL Error: " + ex.Message)
                conn.Close()
            End Try
        Else
            MessageBox.Show("No one to be deleted.")
        End If

        If Not MemberIdShowLabel.Text Is Nothing Then
            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand("update_member_id", connection)
                command.CommandType = CommandType.StoredProcedure

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
        End If

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub


    'text only
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FirstNameEditTextBox.KeyPress, LastNameEditTextBox.KeyPress, MiddleNameEditTextBox.KeyPress, AddressEditTextBox.KeyPress
        ' Allow only letters and numbers
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'number only
    Private Sub NumBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContactNoTextBox.KeyPress, ContactNoTextBox1.KeyPress, ContactNoTextBox2.KeyPress
        ' Allow only letters and numbers
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
#Region " Move Form "

    ' [ Move Form ]
    '
    ' // By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles UpdateMemberTopPanel.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles UpdateMemberTopPanel.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles UpdateMemberTopPanel.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub BlacklistButton_Click(sender As Object, e As EventArgs) Handles BlacklistButton.Click
        BlackListCheckBox.Checked = True
        If ConfirmDialog() Then
            UpdateMember()
        Else
            BlackListCheckBox.Checked = False
        End If
    End Sub

    Private Sub BlackListCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BlackListCheckBox.CheckedChanged

    End Sub


#End Region
End Class