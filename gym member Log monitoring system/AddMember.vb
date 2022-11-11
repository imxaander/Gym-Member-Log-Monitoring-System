Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text.RegularExpressions
Imports System.IO
Public Class AddMember
    Private Sub AddMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set restrictions to date pickers
        DateOfBirthPicker.MaxDate = DateTime.Now

        'StartDatePicker.MinDate = DateTime.Now
        'EndDatePicker.MinDate = DateTime.Now
    End Sub
    Private Sub AddMemberButton_Click(sender As Object, e As EventArgs) Handles AddMemberButton.Click
        If CheckAddFields() Then

            Dim sqlCommand = New SqlCommand("SELECT TOP 1 * FROM [Member] ORDER BY ID DESC", conn)


            'create values for member information'
            Dim memberId = GenerateUID(9)
            Dim lastName = LastNameTextBox.Text
            Dim firstName = FirstNameTextBox.Text
            Dim middleName = MiddleNameTextBox.Text
            Dim dob = DateOfBirthPicker.Text
            Dim gender = GenderBox.Text
            Dim contact = ContactTextBox.Text
            Dim address = AddressTextBox.Text
            Dim dateStart = StartDatePicker.Text
            Dim dateEnd = EndDatePicker.Text

            'image insertion
            Dim ms As New MemoryStream
            MemberImagePreview.Image.Save(ms, MemberImagePreview.Image.RawFormat)

            Dim image = ms.ToArray()
            Try
                Dim sql = "INSERT INTO [Member]([member_id],[last_name],[first_name],[middle_name],[dob],[gender],[contact],[address],[date_Start],[date_End], [image]) VALUES('" & memberId & "', '" & lastName & "', '" & firstName & "', '" & middleName & "','" & dob & "','" & gender & "','" & contact & "','" & address & "','" & dateStart & "','" & dateEnd & "', @img)"

                Dim sqlcom As New SqlCommand(sql, conn)
                sqlcom.Parameters.Add("@img", SqlDbType.Image).Value = image
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
        StartDatePicker.Text = ""
        EndDatePicker.Text = ""
    End Sub

    Private Sub InsertImageButton_Click(sender As Object, e As EventArgs) Handles InsertImageButton.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image (*.JPG;*.PNG;*.GIF) | *.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            MemberImagePreview.Image = Image.FromFile(opf.FileName)
        End If

    End Sub
End Class