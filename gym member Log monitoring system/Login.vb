Imports System.Data.SqlClient
Imports System.Configuration
Public Class Login
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MessageBox.Show("Please input required fields.", "Authentication Error (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim sql As String = "SELECT * FROM [User] WHERE username = '" & UsernameTextBox.Text & "' AND password = '" & PasswordTextBox.Text & "'"

            Dim sqlCom As New SqlCommand(sql, conn)
            conn.Open()

            Dim sqlRead As SqlDataReader = sqlCom.ExecuteReader()
            If sqlRead.Read() Then
                    Dim userInfoReader = sqlRead
                    Dim userName = sqlRead("username")
                    Dim mainForm As New Main()
                    mainForm.userInfoReader = userInfoReader
                    mainForm.userName = userName
                    Me.Hide()
                    mainForm.Show()
                    conn.Close()
                Else
                    MessageBox.Show("Cant find an account with your credentials.", "Authentication Error (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    conn.Close()
                End If

        End If
    End Sub

    Private Sub ExitLoginButton_Click(sender As Object, e As EventArgs) Handles ExitLoginButton.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PasswordLoginLabel_Click(sender As Object, e As EventArgs) Handles PasswordLoginLabel.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UsernameLoginLabel_Click(sender As Object, e As EventArgs) Handles UsernameLoginLabel.Click

    End Sub


End Class