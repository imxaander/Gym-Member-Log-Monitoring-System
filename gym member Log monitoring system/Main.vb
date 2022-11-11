Imports System.Data.SqlClient
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
        LoadEmployeeOverView
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
            sql = "SELECT * FROM [Member] WHERE " & colName & "=@colValue"
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
End Class