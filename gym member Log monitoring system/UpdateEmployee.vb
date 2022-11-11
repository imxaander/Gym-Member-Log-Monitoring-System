Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class UpdateEmployee
    '
    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If EditIdTextBox.Text = "" Then
            MessageBox.Show("Please Enter a Member ID!", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim employee_info = FetchEmployeeDetails()
            If Not employee_info Is Nothing Then
                MemberIdShowLabel.Text = employee_info.employee_id
                LastNameEditTextBox.Text = employee_info.last_name
                FirstNameEditTextBox.Text = employee_info.first_name
                MiddleNameEditTextBox.Text = employee_info.middle_name
                DateOfBirthPicker.Value = employee_info.dob
                GenderEditTextBox.Text = employee_info.gender
                ContactNoTextBox.Text = employee_info.contact_no
                AddressEditTextBox.Text = employee_info.address
            End If
        End If
    End Sub
    Private Function FetchEmployeeDetails()
        Dim employee_id = EditIdTextBox.Text
        Dim employee_info As New EmployeeInfo

        Dim sql = "SELECT * FROM [Employee] WHERE employee_id = '" & employee_id & "'"
        Dim sqlCom As New SqlCommand(sql, conn)
        sqlCom.Connection = conn
        conn.Open()
        Dim sqlRead As SqlDataReader = sqlCom.ExecuteReader()

        If sqlRead.Read() Then
            employee_info.employee_id = sqlRead("employee_id")
            employee_info.first_name = sqlRead("first_name")
            employee_info.last_name = sqlRead("last_name")
            employee_info.middle_name = sqlRead("middle_name")
            employee_info.dob = sqlRead("dob")
            employee_info.gender = sqlRead("gender")
            employee_info.contact_no = sqlRead("contact")
            employee_info.address = sqlRead("address")
            sqlRead.Close()
            conn.Close()
        Else
            MessageBox.Show("There's No Such Employee with Employee Id!", "Searching Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            employee_info = Nothing
            sqlRead.Close()
            conn.Close()
        End If

        Return employee_info
    End Function
    Private Class EmployeeInfo
        Public employee_id As String
        Public first_name As String
        Public last_name As String
        Public middle_name As String
        Public dob As Date
        Public gender As String
        Public contact_no As String
        Public address As String

    End Class

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If CheckAddFields() Then

            'initialize values
            Dim employeeId = MemberIdShowLabel.Text
            Dim lastName = LastNameEditTextBox.Text
            Dim firstName = FirstNameEditTextBox.Text
            Dim middleName = MiddleNameEditTextBox.Text
            Dim dob = DateOfBirthPicker.Text
            Dim gender = GenderEditTextBox.Text
            Dim contact = ContactNoTextBox.Text
            Dim address = AddressEditTextBox.Text

            Try
                Dim sqlcom As New SqlCommand("UPDATE [Employee] SET last_name = '" & lastName & "', first_name = '" & firstName & "', middle_name = '" & middleName & "', dob = '" & dob & "', gender = '" & gender & "', contact = '" & contact & "', address = '" & address & "' WHERE employee_id = '" & employeeId & "'", conn)
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

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If Not MemberIdShowLabel.Text Is Nothing Then
            Try
                Dim sqlcom As New SqlCommand("DELETE FROM Employee WHERE employee_id = '" & MemberIdShowLabel.Text & "'", conn)
                conn.Open()
                If sqlcom.ExecuteNonQuery > 0 Then
                    MessageBox.Show("Employee Deleted.")
                    conn.Close()
                    Main.LoadEmployeeOverView()
                End If
            Catch ex As Exception
                MessageBox.Show("SQL Error: " + ex.Message)
                conn.Close()
            End Try
        Else
            MessageBox.Show("No one to be deleted.")
        End If
    End Sub

End Class