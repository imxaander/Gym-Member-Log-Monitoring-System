<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LoggedInAsLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LoggedInLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ViewMembersTab = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MemberFilterColBox = New System.Windows.Forms.ComboBox()
        Me.BySearchLabel = New System.Windows.Forms.Label()
        Me.MemberSearchButton = New System.Windows.Forms.Button()
        Me.MemberSearchTextBox = New System.Windows.Forms.TextBox()
        Me.RefreshMemberButton = New System.Windows.Forms.Button()
        Me.membersGridView = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmployeeFilterColBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmployeeSearchButton = New System.Windows.Forms.Button()
        Me.EmployeeSearchTextBox = New System.Windows.Forms.TextBox()
        Me.RefreshEmployeeButton = New System.Windows.Forms.Button()
        Me.employeesGridView = New System.Windows.Forms.DataGridView()
        Me.ExitButtonMain = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ViewMembersTab.SuspendLayout()
        CType(Me.membersGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.employeesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoggedInAsLabel, Me.LoggedInLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 425)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(657, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LoggedInAsLabel
        '
        Me.LoggedInAsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.LoggedInAsLabel.Name = "LoggedInAsLabel"
        Me.LoggedInAsLabel.Size = New System.Drawing.Size(80, 17)
        Me.LoggedInAsLabel.Text = "Logged in as :"
        '
        'LoggedInLabel
        '
        Me.LoggedInLabel.ForeColor = System.Drawing.Color.Red
        Me.LoggedInLabel.Name = "LoggedInLabel"
        Me.LoggedInLabel.Size = New System.Drawing.Size(62, 17)
        Me.LoggedInLabel.Text = "UserName"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemberToolStripMenuItem, Me.EmployeeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(657, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MemberToolStripMenuItem
        '
        Me.MemberToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMemberToolStripMenuItem, Me.UpdateMemberToolStripMenuItem})
        Me.MemberToolStripMenuItem.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MemberToolStripMenuItem.Name = "MemberToolStripMenuItem"
        Me.MemberToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.MemberToolStripMenuItem.Text = "Member"
        '
        'AddMemberToolStripMenuItem
        '
        Me.AddMemberToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AddMemberToolStripMenuItem.Name = "AddMemberToolStripMenuItem"
        Me.AddMemberToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AddMemberToolStripMenuItem.Text = "Add Member"
        '
        'UpdateMemberToolStripMenuItem
        '
        Me.UpdateMemberToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.UpdateMemberToolStripMenuItem.Name = "UpdateMemberToolStripMenuItem"
        Me.UpdateMemberToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.UpdateMemberToolStripMenuItem.Text = "Update Member"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmployeeToolStripMenuItem, Me.UpdateEmployeeToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'AddEmployeeToolStripMenuItem
        '
        Me.AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        Me.AddEmployeeToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AddEmployeeToolStripMenuItem.Text = "Add Employee"
        '
        'UpdateEmployeeToolStripMenuItem
        '
        Me.UpdateEmployeeToolStripMenuItem.Name = "UpdateEmployeeToolStripMenuItem"
        Me.UpdateEmployeeToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.UpdateEmployeeToolStripMenuItem.Text = "Update Employee"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.ViewMembersTab)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 30)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(632, 390)
        Me.TabControl1.TabIndex = 2
        '
        'ViewMembersTab
        '
        Me.ViewMembersTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ViewMembersTab.Controls.Add(Me.Label3)
        Me.ViewMembersTab.Controls.Add(Me.MemberFilterColBox)
        Me.ViewMembersTab.Controls.Add(Me.BySearchLabel)
        Me.ViewMembersTab.Controls.Add(Me.MemberSearchButton)
        Me.ViewMembersTab.Controls.Add(Me.MemberSearchTextBox)
        Me.ViewMembersTab.Controls.Add(Me.RefreshMemberButton)
        Me.ViewMembersTab.Controls.Add(Me.membersGridView)
        Me.ViewMembersTab.Location = New System.Drawing.Point(4, 23)
        Me.ViewMembersTab.Name = "ViewMembersTab"
        Me.ViewMembersTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ViewMembersTab.Size = New System.Drawing.Size(624, 363)
        Me.ViewMembersTab.TabIndex = 0
        Me.ViewMembersTab.Text = "Members"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(391, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 2)
        Me.Label3.TabIndex = 13
        '
        'MemberFilterColBox
        '
        Me.MemberFilterColBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemberFilterColBox.FormattingEnabled = True
        Me.MemberFilterColBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MemberFilterColBox.Items.AddRange(New Object() {"last_name", "first_name", "middle_name", "gender"})
        Me.MemberFilterColBox.Location = New System.Drawing.Point(532, 8)
        Me.MemberFilterColBox.Name = "MemberFilterColBox"
        Me.MemberFilterColBox.Size = New System.Drawing.Size(86, 22)
        Me.MemberFilterColBox.TabIndex = 7
        '
        'BySearchLabel
        '
        Me.BySearchLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BySearchLabel.AutoSize = True
        Me.BySearchLabel.ForeColor = System.Drawing.Color.White
        Me.BySearchLabel.Location = New System.Drawing.Point(497, 10)
        Me.BySearchLabel.Name = "BySearchLabel"
        Me.BySearchLabel.Size = New System.Drawing.Size(28, 14)
        Me.BySearchLabel.TabIndex = 6
        Me.BySearchLabel.Text = "By : "
        '
        'MemberSearchButton
        '
        Me.MemberSearchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemberSearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.MemberSearchButton.FlatAppearance.BorderSize = 0
        Me.MemberSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MemberSearchButton.ForeColor = System.Drawing.Color.White
        Me.MemberSearchButton.Location = New System.Drawing.Point(310, 4)
        Me.MemberSearchButton.Name = "MemberSearchButton"
        Me.MemberSearchButton.Size = New System.Drawing.Size(75, 25)
        Me.MemberSearchButton.TabIndex = 5
        Me.MemberSearchButton.Text = "Search"
        Me.MemberSearchButton.UseVisualStyleBackColor = False
        '
        'MemberSearchTextBox
        '
        Me.MemberSearchTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemberSearchTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.MemberSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MemberSearchTextBox.ForeColor = System.Drawing.Color.White
        Me.MemberSearchTextBox.Location = New System.Drawing.Point(391, 6)
        Me.MemberSearchTextBox.Name = "MemberSearchTextBox"
        Me.MemberSearchTextBox.Size = New System.Drawing.Size(100, 15)
        Me.MemberSearchTextBox.TabIndex = 4
        '
        'RefreshMemberButton
        '
        Me.RefreshMemberButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.RefreshMemberButton.FlatAppearance.BorderSize = 0
        Me.RefreshMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshMemberButton.ForeColor = System.Drawing.Color.White
        Me.RefreshMemberButton.Location = New System.Drawing.Point(6, 4)
        Me.RefreshMemberButton.Name = "RefreshMemberButton"
        Me.RefreshMemberButton.Size = New System.Drawing.Size(75, 25)
        Me.RefreshMemberButton.TabIndex = 3
        Me.RefreshMemberButton.Text = "Refresh"
        Me.RefreshMemberButton.UseVisualStyleBackColor = False
        '
        'membersGridView
        '
        Me.membersGridView.AllowUserToAddRows = False
        Me.membersGridView.AllowUserToDeleteRows = False
        Me.membersGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.membersGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.membersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.membersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.membersGridView.Location = New System.Drawing.Point(6, 35)
        Me.membersGridView.Name = "membersGridView"
        Me.membersGridView.ReadOnly = True
        Me.membersGridView.Size = New System.Drawing.Size(612, 320)
        Me.membersGridView.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.EmployeeFilterColBox)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.EmployeeSearchButton)
        Me.TabPage2.Controls.Add(Me.EmployeeSearchTextBox)
        Me.TabPage2.Controls.Add(Me.RefreshEmployeeButton)
        Me.TabPage2.Controls.Add(Me.employeesGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(624, 363)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Employees"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(391, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 2)
        Me.Label2.TabIndex = 12
        '
        'EmployeeFilterColBox
        '
        Me.EmployeeFilterColBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmployeeFilterColBox.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeFilterColBox.FormattingEnabled = True
        Me.EmployeeFilterColBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.EmployeeFilterColBox.Items.AddRange(New Object() {"last_name", "first_name", "middle_name"})
        Me.EmployeeFilterColBox.Location = New System.Drawing.Point(532, 8)
        Me.EmployeeFilterColBox.Name = "EmployeeFilterColBox"
        Me.EmployeeFilterColBox.Size = New System.Drawing.Size(86, 22)
        Me.EmployeeFilterColBox.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(497, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "By : "
        '
        'EmployeeSearchButton
        '
        Me.EmployeeSearchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmployeeSearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.EmployeeSearchButton.FlatAppearance.BorderSize = 0
        Me.EmployeeSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeSearchButton.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeSearchButton.ForeColor = System.Drawing.Color.White
        Me.EmployeeSearchButton.Location = New System.Drawing.Point(310, 4)
        Me.EmployeeSearchButton.Name = "EmployeeSearchButton"
        Me.EmployeeSearchButton.Size = New System.Drawing.Size(75, 25)
        Me.EmployeeSearchButton.TabIndex = 9
        Me.EmployeeSearchButton.Text = "Search"
        Me.EmployeeSearchButton.UseVisualStyleBackColor = False
        '
        'EmployeeSearchTextBox
        '
        Me.EmployeeSearchTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmployeeSearchTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.EmployeeSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmployeeSearchTextBox.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeSearchTextBox.ForeColor = System.Drawing.Color.White
        Me.EmployeeSearchTextBox.Location = New System.Drawing.Point(391, 6)
        Me.EmployeeSearchTextBox.Name = "EmployeeSearchTextBox"
        Me.EmployeeSearchTextBox.Size = New System.Drawing.Size(100, 15)
        Me.EmployeeSearchTextBox.TabIndex = 8
        '
        'RefreshEmployeeButton
        '
        Me.RefreshEmployeeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.RefreshEmployeeButton.FlatAppearance.BorderSize = 0
        Me.RefreshEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshEmployeeButton.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshEmployeeButton.ForeColor = System.Drawing.Color.White
        Me.RefreshEmployeeButton.Location = New System.Drawing.Point(6, 5)
        Me.RefreshEmployeeButton.Name = "RefreshEmployeeButton"
        Me.RefreshEmployeeButton.Size = New System.Drawing.Size(75, 25)
        Me.RefreshEmployeeButton.TabIndex = 4
        Me.RefreshEmployeeButton.Text = "Refresh"
        Me.RefreshEmployeeButton.UseVisualStyleBackColor = False
        '
        'employeesGridView
        '
        Me.employeesGridView.AllowUserToAddRows = False
        Me.employeesGridView.AllowUserToDeleteRows = False
        Me.employeesGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.employeesGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.employeesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.employeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employeesGridView.Location = New System.Drawing.Point(6, 35)
        Me.employeesGridView.Name = "employeesGridView"
        Me.employeesGridView.ReadOnly = True
        Me.employeesGridView.Size = New System.Drawing.Size(612, 321)
        Me.employeesGridView.TabIndex = 0
        '
        'ExitButtonMain
        '
        Me.ExitButtonMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButtonMain.BackColor = System.Drawing.Color.Transparent
        Me.ExitButtonMain.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButtonMain.ForeColor = System.Drawing.Color.White
        Me.ExitButtonMain.Location = New System.Drawing.Point(633, 0)
        Me.ExitButtonMain.Name = "ExitButtonMain"
        Me.ExitButtonMain.Size = New System.Drawing.Size(24, 24)
        Me.ExitButtonMain.TabIndex = 3
        Me.ExitButtonMain.Text = "×"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(657, 447)
        Me.Controls.Add(Me.ExitButtonMain)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gym Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ViewMembersTab.ResumeLayout(False)
        Me.ViewMembersTab.PerformLayout()
        CType(Me.membersGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.employeesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LoggedInAsLabel As ToolStripStatusLabel
    Friend WithEvents LoggedInLabel As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents membersGridView As DataGridView
    Friend WithEvents ViewMembersTab As TabPage
    Friend WithEvents RefreshMemberButton As Button
    Friend WithEvents MemberFilterColBox As ComboBox
    Friend WithEvents BySearchLabel As Label
    Friend WithEvents MemberSearchButton As Button
    Friend WithEvents MemberSearchTextBox As TextBox
    Friend WithEvents employeesGridView As DataGridView
    Friend WithEvents RefreshEmployeeButton As Button
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeFilterColBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EmployeeSearchButton As Button
    Friend WithEvents EmployeeSearchTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ExitButtonMain As Label
End Class
