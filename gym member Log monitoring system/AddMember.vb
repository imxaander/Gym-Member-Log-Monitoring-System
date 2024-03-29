﻿Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Diagnostics
Imports Org.BouncyCastle.Utilities
Imports System.Threading
Imports System.Timers

Public Class AddMember
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

    Public startDate
    Public endDate
    Public PackageDescription
    Private Sub AddMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set restrictions to date pickers
        DateOfBirthPicker.MaxDate = DateTime.Now

        'StartDatePicker.MinDate = DateTime.Now
        'EndDatePicker.MinDate = DateTime.Now

        Dim DatAcc As New DataAccess()
        Dim arr = DatAcc.GetPackagesDuration()
        PackageComboBox.DataSource = arr

        Debug.WriteLine(conn.ConnectionString)

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
            Dim contact = ContactTextBox1.Text + "/" + ContactTextBox2.Text + "/" + ContactTextBox3.Text
            Dim email = EmailTextBox.Text
            Dim address = LocationComboBox.Text + ", " + AddressTextBox.Text
            Dim dateStart = startDate
            Dim dateEnd = endDate

            'image insertion
            Dim ms As New MemoryStream
            MemberImagePreview.Image.Save(ms, MemberImagePreview.Image.RawFormat)

            Dim image = ms.ToArray()
            Try
                Dim d As Date = Date.Now()
                Dim df As String = d.ToString("yyyy/MM")
                Dim sql = " INSERT INTO [Member]([member_id],[last_name],[first_name],[middle_name],[dob],[gender],[contact],[email],[address],[date_Start],[date_End], [image], [blacklisted], [visible]) 
                            VALUES('" & df & "' + '/' +
                                CONVERT(VARCHAR, (SELECT COUNT(*) FROM Member WHERE DATEPART(MONTH, date_Start) = DATEPART(MONTH, GETDATE()))), '" & lastName & "', '" & firstName & "', '" & middleName & "','" & dob & "','" & gender & "','" & contact & "','" & email & "','" & address & "','" & dateStart & "','" & dateEnd & "', @img, 0, 1)"
                Debug.WriteLine(sql)
                conn.ConnectionString = connectionString
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

        Dim emailRegexMatch = Regex.IsMatch(EmailTextBox.Text, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")

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
        ElseIf Not emailRegexMatch Then
            MessageBox.Show("Wrong Format : " + "Email")
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
        ContactTextBox1.Text = ""
        AddressTextBox.Text = ""
    End Sub

    Private Sub InsertImageButton_Click(sender As Object, e As EventArgs) Handles InsertImageButton.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image (*.JPG;*.PNG;*.GIF) | *.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            MemberImagePreview.Image = Image.FromFile(opf.FileName)
        End If

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

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles AddMemberTopPanel.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles AddMemberTopPanel.MouseMove  ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles AddMemberTopPanel.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub PackageComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PackageComboBox.SelectedIndexChanged

        Dim durationString As String = PackageComboBox.Text
        Dim durationMonths = Integer.Parse(Regex.Replace(durationString, "[^\d]", ""))

        startDate = Date.Now.ToString("yyyy-MM-dd")
        endDate = Date.Now.AddMonths(durationMonths).ToString("yyyy-MM-dd")

    End Sub

    'text only
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LastNameTextBox.KeyPress, FirstNameTextBox.KeyPress, MiddleNameTextBox.KeyPress, AddressTextBox.KeyPress
        ' Allow only letters and numbers
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'number only
    Private Sub NumBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContactTextBox1.KeyPress, ContactTextBox2.KeyPress, ContactTextBox3.KeyPress
        ' Allow only letters and numbers
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


#End Region
End Class

Class DataAccess
    Public Function GetPackagesDuration() As String()
        Dim tb As New DataTable
        Dim SQL As String = "SELECT * from Package;"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(SQL, conn)
                conn.Open()
                tb.Load(cmd.ExecuteReader)
                conn.Close()
            End Using
        End Using
        Dim durations = tb.AsEnumerable().Select(Function(x) x.Field(Of String)("duration")).ToArray()
        Return durations
    End Function
End Class
