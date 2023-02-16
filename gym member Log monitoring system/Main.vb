Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Data
Imports GemBox.Spreadsheet
Imports System.Windows
Imports System.Net.Http
Imports System.Threading

Public Class Main
    Public Property userInfoReader As SqlDataReader
    Public Property userName As String
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not userInfoReader Is Nothing Then
            LoggedInLabel.Text = userInfoReader("username")
        End If

        'Check permissions then disable other buttons if not permitted
        If userInfoReader("updateMember") <> True Then
            UpdateMemberButton.Enabled = False
        End If

        If userInfoReader("deleteMember") <> True Then
            UpdateMember.DeleteButton.Enabled = False
        End If

        If userInfoReader("addMember") <> True Then
            AddMemberButton.Enabled = False
        End If

        userInfoReader.Close()
        conn.Close()

        'Load Member Overview
        LoadMemberOverView()
        LoadEmployeeOverView()

        'ui
        'membersGridView.Dock = DockStyle.Fill
        'employeesGridView.Dock = DockStyle.Fill

        employeesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'membersGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        Timer.Interval = 1000
        Timer.Start()

        'set defaults
        MemberFilterColBox.SelectedIndex = 5
        StatusBox.SelectedIndex = 4

    End Sub
    Public Sub LoadMemberOverView()

        'Initialize dataTable and get table values
        Dim dtMembers As New DataTable

        Dim sql As String = "SELECT * FROM [Member] ORDER BY member_id ASC"
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
        ColorMemberRows()

        'change table columns to nicer name
        membersGridView.Columns("member_id").HeaderCell.Value = "Member ID"
        membersGridView.Columns("last_name").HeaderCell.Value = "Last Name"
        membersGridView.Columns("first_name").HeaderCell.Value = "First Name"
        membersGridView.Columns("middle_name").HeaderCell.Value = "Middle Name"
        membersGridView.Columns("dob").HeaderCell.Value = "Date of Birth"
        membersGridView.Columns("gender").HeaderCell.Value = "Gender"
        membersGridView.Columns("contact").HeaderCell.Value = "Contact No"
        membersGridView.Columns("email").HeaderCell.Value = "Email"
        membersGridView.Columns("address").HeaderCell.Value = "Address"
        membersGridView.Columns("date_Start").HeaderCell.Value = "Started Date"
        membersGridView.Columns("date_End").HeaderCell.Value = "Ending Date"
        membersGridView.Columns("image").HeaderCell.Value = "Image"

        membersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub ColorMemberRows()
        'change color of row depending on how many days left
        Dim dangerDays = 7
        Dim warningDays = 14
        Dim outDays = 0
        Dim dateToday = Date.Today

        For i = 0 To membersGridView.Rows.Count - 1


            If dangerDays > (DateTime.Parse(membersGridView.Rows(i).Cells("date_End").Value) - DateTime.Parse(dateToday)).TotalDays Then
                membersGridView.Rows(i).DefaultCellStyle.BackColor = Color.Red
            ElseIf warningDays > (DateTime.Parse(membersGridView.Rows(i).Cells("date_End").Value) - DateTime.Parse(dateToday)).TotalDays Then
                membersGridView.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
            End If

            If outDays < (DateTime.Parse(dateToday) - DateTime.Parse(membersGridView.Rows(i).Cells("date_End").Value)).TotalDays Then
                membersGridView.Rows(i).DefaultCellStyle.BackColor = Color.Blue
            End If


        Next
    End Sub

    Private Sub membersGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles membersGridView.CellFormatting
        If TypeOf e.Value Is Byte() Then
            membersGridView.Columns(0).Width = 50
        End If

        Dim columnName As String = "contact"
        If membersGridView.Columns(e.ColumnIndex).Name = columnName Then
            e.Value = GetFirstValue(e.Value.ToString())
            membersGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = e.Value.ToString()
        End If
    End Sub

    Private Function GetFirstValue(input As String) As String
        Return input.Split(","c)(0)
    End Function
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

        'change table columns to nicer name
        employeesGridView.Columns("employee_id").HeaderCell.Value = "Employee ID"
        employeesGridView.Columns("last_name").HeaderCell.Value = "Last Name"
        employeesGridView.Columns("first_name").HeaderCell.Value = "First Name"
        employeesGridView.Columns("middle_name").HeaderCell.Value = "Middle Name"
        employeesGridView.Columns("gender").HeaderCell.Value = "Gender"
        employeesGridView.Columns("dob").HeaderCell.Value = "Birthdate"
        employeesGridView.Columns("contact").HeaderCell.Value = "Contact"
        employeesGridView.Columns("address").HeaderCell.Value = "Address"

    End Sub

    Public Sub FilterMemberDataGridView() Handles SearchButton.Click
        Dim dtMembers As New DataTable
        Dim sql As String = ""

        If MemberFilterColBox.Text = "Member ID" Then
            sql = "SELECT * FROM [Member] WHERE  LOWER(member_id) LIKE LOWER('%" + MemberSearchTextBox.Text + "%')"
        ElseIf MemberFilterColBox.Text = "Last Name" Then
            sql = "SELECT * FROM [Member] WHERE  LOWER(last_name) LIKE LOWER('%" + MemberSearchTextBox.Text + "%')"
        ElseIf MemberFilterColBox.Text = "First Name" Then
            sql = "SELECT * FROM [Member] WHERE  LOWER(first_name) LIKE LOWER('%" + MemberSearchTextBox.Text + "%')"
        ElseIf MemberFilterColBox.Text = "Middle Name" Then
            sql = "SELECT * FROM [Member] WHERE  LOWER(middle_name) LIKE LOWER('%" + MemberSearchTextBox.Text + "%')"
        ElseIf MemberFilterColBox.Text = "Email" Then
            sql = "SELECT * FROM [Member] WHERE  LOWER(email) LIKE LOWER('%" + MemberSearchTextBox.Text + "%')"
        ElseIf MemberFilterColBox.Text = "All" Then
            sql = "SELECT * FROM [Member] WHERE
                    LOWER(member_id) LIKE LOWER('%" + MemberSearchTextBox.Text + "%') OR
                    LOWER(email) LIKE LOWER('%" + MemberSearchTextBox.Text + "%') OR
                    LOWER(last_name) LIKE LOWER('%" + MemberSearchTextBox.Text + "%') OR
                    LOWER(first_name) LIKE LOWER('%" + MemberSearchTextBox.Text + "%') OR
                    LOWER(middle_name) LIKE LOWER('%" + MemberSearchTextBox.Text + "%') OR
                    LOWER(contact) LIKE LOWER('%" + MemberSearchTextBox.Text + "%') OR
                    LOWER(address) LIKE LOWER('%" + MemberSearchTextBox.Text + "%')"
        Else
            sql = "SELECT * FROM [Member]"
        End If

        Dim sqlCom As New SqlCommand(sql, conn)

        conn.Open()
        Dim sqlRead As SqlDataReader = sqlCom.ExecuteReader()

        dtMembers.Load(sqlRead)

        sqlRead.Close()

        membersGridView.DataSource = dtMembers
        conn.Close()
        ColorMemberRows()
    End Sub
    Public Sub FilterEmployeeDataGridView()
        Dim dtEmployees As New DataTable

        Dim sql = "SELECT * FROM [Employee] WHERE
                    LOWER(employee_id) LIKE LOWER('%" + EmployeeSearchTextBox.Text + "%') OR
                    LOWER(last_name) LIKE LOWER('%" + EmployeeSearchTextBox.Text + "%') OR
                    LOWER(first_name) LIKE LOWER('%" + EmployeeSearchTextBox.Text + "%') OR
                    LOWER(middle_name) LIKE LOWER('%" + EmployeeSearchTextBox.Text + "%') OR
                    LOWER(contact) LIKE LOWER('%" + EmployeeSearchTextBox.Text + "%') OR
                    LOWER(address) LIKE LOWER('%" + EmployeeSearchTextBox.Text + "%')"

        Dim sqlCom As New SqlCommand(sql, conn)
        conn.Open()

        Dim sqlRead As SqlDataReader = sqlCom.ExecuteReader()

        dtEmployees.Load(sqlRead)

        sqlRead.Close()

        employeesGridView.DataSource = dtEmployees
        conn.Close()
    End Sub


    Private Sub SearchButton_Click(sender As Object, e As EventArgs)
        FilterMemberDataGridView()
    End Sub

    Private Sub RefreshMemberButton_Click(sender As Object, e As EventArgs) Handles RefreshMemberButton.Click
        LoadMemberOverView()
    End Sub

    Private Sub RefreshEmployeeButton_Click(sender As Object, e As EventArgs) Handles RefreshEmployeeButton.Click
        LoadEmployeeOverView()
    End Sub
    Private Sub AddEmployeeButton_Click(sender As Object, e As EventArgs) Handles AddEmployeeButton.Click
        AddEmployee.Show()
    End Sub
    Private Sub UpdateEmployeeButton_Click(sender As Object, e As EventArgs) Handles UpdateEmployeeButton.Click
        UpdateEmployee.Show()
    End Sub
    Private Sub AddMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMemberButton.Click
        AddMember.Show()
    End Sub
    Private Sub UpdateMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateMemberButton.Click
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

    Private Sub membersGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles membersGridView.CellClick

        If membersGridView.CurrentCell.Value IsNot Nothing AndAlso TypeOf membersGridView.CurrentCell.Value Is Byte() Then
            Dim byteArray As Byte() = membersGridView.CurrentCell.Value
            Using ms As New MemoryStream(byteArray)
                Dim img As Image = Image.FromStream(ms)
                Dim imageViewForm As New ImageView()
                imageViewForm.PictureBoxPrev.Image = img
                imageViewForm.Show()
            End Using
        Else

            'Show message or do something else
            Debug.WriteLine(membersGridView.CurrentCell.GetType())

        End If
    End Sub

    Private Sub MembersTabButton_Click(sender As Object, e As EventArgs) Handles MembersTabButton.Click
        TabControl.SelectedTab = ViewMembersTab
        MembersTabButton.BackColor = Color.FromArgb(52, 55, 78)
        EmployeesTabButton.BackColor = Color.FromArgb(40, 42, 58)
    End Sub

    Private Sub EmployeesTabButton_Click(sender As Object, e As EventArgs) Handles EmployeesTabButton.Click
        TabControl.SelectedTab = ViewEmployeesTab
        MembersTabButton.BackColor = Color.FromArgb(40, 42, 58)
        EmployeesTabButton.BackColor = Color.FromArgb(52, 55, 78)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub ChangeFonts()
        Label4.Font = FontModule.GetFont()
    End Sub

    Private Sub StatusBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StatusBox.SelectedIndexChanged
        Dim dtMembers As New DataTable
        Dim sql As String = ""

        Dim status = StatusBox.Text

        If StatusBox.Text = "Almost Due" Then
            sql = "SELECT * FROM [Member] WHERE date_End BETWEEN GETDATE() AND DATEADD(day, 6, GETDATE())"
        ElseIf StatusBox.Text = "Warning" Then
            sql = "SELECT * FROM [Member] WHERE date_End BETWEEN  DATEADD(day, 6, GETDATE()) AND DATEADD(day, 13, GETDATE())"
        ElseIf StatusBox.Text = "Safe" Then
            sql = "SELECT * FROM [Member] WHERE date_End > DATEADD(day, 14, GETDATE())"
        ElseIf StatusBox.Text = "Out of Service" Then
            sql = "SELECT * FROM [Member] WHERE date_End < GETDATE()"
        ElseIf StatusBox.Text = "All" Then
            sql = "SELECT * FROM [Member]"
        End If

        Dim sqlCom As New SqlCommand(sql, conn)

        conn.Open()
        Dim sqlRead As SqlDataReader = sqlCom.ExecuteReader()

        dtMembers.Load(sqlRead)

        sqlRead.Close()

        membersGridView.DataSource = dtMembers
        conn.Close()
        ColorMemberRows()


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
    'amriennt

End Class


