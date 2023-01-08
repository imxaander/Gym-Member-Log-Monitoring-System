﻿Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Data
Imports GemBox.Spreadsheet


Public Class Main
    Public Property userInfoReader As SqlDataReader
    Public Property userName As String
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not userInfoReader Is Nothing Then
            LoggedInLabel.Text = userInfoReader("username")
        End If

        'Check permissions then disable other buttons if not permitted
        If userInfoReader("updateMember") <> True Then
            UpdateMemberToolStripMenuItem.Enabled = False
        End If

        If userInfoReader("deleteMember") <> True Then
            UpdateMember.DeleteButton.Enabled = False
        End If

        If userInfoReader("addMember") <> True Then
            AddMemberToolStripMenuItem.Enabled = False
        End If

        userInfoReader.Close()
        conn.Close()

        'Load Member Overview
        LoadMemberOverView()
        LoadEmployeeOverView()

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim d As Date = Date.Now()
            Dim df As String = d.ToString("yyyy_MM")
            Dim sql As String = "INSERT INTO Test 
                                VALUES ('" & df & "' + '/' +
                                        CONVERT(VARCHAR, (SELECT COUNT(*) FROM Test WHERE date_column = CONVERT(VARCHAR, GETDATE(), 103))),
                                        CONVERT(VARCHAR, GETDATE(), 103)
                                 )"
            Dim cmd As New SqlCommand(sql, conn)

            cmd.ExecuteReader()
        End Using
    End Sub
    Public Sub LoadMemberOverView()

        'Initialize dataTable and get table values
        Dim dtMembers As New DataTable

        Dim sql As String = "SELECT * FROM [Member]"
        Dim sqlCom As New SqlCommand(sql, conn)
        sqlCom.Connection = conn
        conn.Open()

        Dim sqlRead As SqlDataReader = sqlCom.ExecuteReader()

        dtMembers.Load(sqlRead)

        sqlRead.Close()
        conn.Close()

        'load table values to the grid view
        membersGridView.DataSource = dtMembers

        'change color of row depending on how many days left
        Dim redWarningDays = 7
        Dim orangeWarningDays = 14
        Dim dateToday = Date.Today

        For i = 0 To membersGridView.Rows.Count - 1
            If redWarningDays > (DateTime.Parse(membersGridView.Rows(i).Cells("date_End").Value) - DateTime.Parse(dateToday)).TotalDays Then
                membersGridView.Rows(i).DefaultCellStyle.BackColor = Color.Red
            ElseIf orangeWarningDays > (DateTime.Parse(membersGridView.Rows(i).Cells("date_End").Value) - DateTime.Parse(dateToday)).TotalDays Then
                membersGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
            End If
        Next

        'change table columns to nicer name
        membersGridView.Columns("member_id").HeaderCell.Value = "Member ID"
        membersGridView.Columns("last_name").HeaderCell.Value = "Last Name"
        membersGridView.Columns("first_name").HeaderCell.Value = "First Name"
        membersGridView.Columns("middle_name").HeaderCell.Value = "Middle Name"
        membersGridView.Columns("dob").HeaderCell.Value = "Date of Birth"
        membersGridView.Columns("gender").HeaderCell.Value = "Gender"
        membersGridView.Columns("contact").HeaderCell.Value = "Contact No"
        membersGridView.Columns("address").HeaderCell.Value = "Address"
        membersGridView.Columns("date_Start").HeaderCell.Value = "Started Date"
        membersGridView.Columns("date_End").HeaderCell.Value = "Ending Date"
        membersGridView.Columns("image").HeaderCell.Value = "Image"

        'image resizing 
    End Sub
    Private Sub membersGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles membersGridView.CellFormatting
        Debug.WriteLine("Hi")
        If e.ColumnIndex = 0 AndAlso e.Value IsNot Nothing AndAlso membersGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).ValueType Is GetType(System.Drawing.Image) Then
            Dim image As Image = DirectCast(e.Value, Image)
            e.Value = image
            membersGridView.Rows(e.RowIndex).Height = image.Height
            membersGridView.Columns(e.ColumnIndex).Width = image.Width
            Debug.WriteLine("I think this should work")
        End If
    End Sub
    Public Sub LoadEmployeeOverView()
        'get values of from the table (employee)
        Dim dtEmployees As New DataTable

        Dim sql As String = "SELECT * FROM [Employee]"
        Dim sqlCom As New SqlCommand(sql, conn)
        sqlCom.Connection = conn
        conn.Open()

        Dim sqlRead As SqlDataReader = sqlCom.ExecuteReader()

        dtEmployees.Load(sqlRead)

        sqlRead.Close()
        conn.Close()

        'load values to the grid view
        employeesGridView.DataSource = dtEmployees


    End Sub

    Public Sub FilterMemberDataGridView()
        Dim colValue As String = MemberSearchTextBox.Text
        Dim colName As String = MemberFilterColBox.Text

        Dim dtMembers As New DataTable
        Dim sql As String
        If MemberSearchTextBox.Text = "" Or MemberFilterColBox.Text = "" Then
            sql = "SELECT * FROM [Member]"
        Else
            sql = "SELECT * FROM [Member] WHERE " & colName & " LIKE @colValue"
        End If
        Dim sqlCom As New SqlCommand(sql, conn)
        sqlCom.Parameters.Add("@colValue", SqlDbType.VarChar).Value = colValue
        conn.Open()

        Dim sqlRead As SqlDataReader = sqlCom.ExecuteReader()

        dtMembers.Load(sqlRead)

        sqlRead.Close()

        membersGridView.DataSource = dtMembers
        conn.Close()
    End Sub
    Public Sub FilterEmployeeDataGridView()
        Dim colValue As String = EmployeeSearchTextBox.Text
        Dim colName As String = EmployeeFilterColBox.Text

        Dim dtEmployees As New DataTable

        Dim sql As String
        If EmployeeSearchTextBox.Text = "" Or EmployeeFilterColBox.Text = "" Then
            sql = "SELECT * FROM [Employee]"
        Else
            sql = "SELECT * FROM [Employee] WHERE " & colName & "=@colValue"
        End If
        Dim sqlCom As New SqlCommand(sql, conn)
        sqlCom.Parameters.Add("@colValue", SqlDbType.VarChar).Value = colValue
        conn.Open()

        Dim sqlRead As SqlDataReader = sqlCom.ExecuteReader()

        dtEmployees.Load(sqlRead)

        sqlRead.Close()

        employeesGridView.DataSource = dtEmployees
        conn.Close()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles MemberSearchButton.Click
        FilterMemberDataGridView()
    End Sub

    Private Sub RefreshMemberButton_Click(sender As Object, e As EventArgs) Handles RefreshMemberButton.Click
        LoadMemberOverView()
    End Sub

    Private Sub RefreshEmployeeButton_Click(sender As Object, e As EventArgs) Handles RefreshEmployeeButton.Click
        LoadEmployeeOverView()
    End Sub
    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        AddEmployee.Show()
    End Sub
    Private Sub UpdateEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateEmployeeToolStripMenuItem.Click
        UpdateEmployee.Show()
    End Sub
    Private Sub AddMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMemberToolStripMenuItem.Click
        AddMember.Show()
    End Sub
    Private Sub UpdateMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateMemberToolStripMenuItem.Click
        UpdateMember.Show()
    End Sub
    Private Sub EmployeeSearchButton_Click(sender As Object, e As EventArgs) Handles EmployeeSearchButton.Click
        FilterEmployeeDataGridView()
    End Sub

    Private Sub ExportExcelButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitButtonMain_Click(sender As Object, e As EventArgs) Handles ExitButtonMain.Click
        ExitApplication()
    End Sub

    Public Sub ExitApplication()
        Login.Close()
        Close()
        AddMember.Close()
        AddEmployee.Close()
        UpdateEmployee.Close()
        UpdateMember.Close()
    End Sub

#Region " Move Form "

    ' [ Move Form ]
    '
    ' // By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MenuStrip1.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MenuStrip1.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MenuStrip1.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

#End Region




    'Code just incase automatic filtering
    'Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
    'FilterDataGridView()
    'End Sub
    'Private Sub FilterColBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilterColBox.SelectedIndexChanged
    'FilterDataGridView()
    'End Sub
    'Private Sub MemberBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    'Me.Validate()
    ' End Sub
    'amriennt
End Class