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
        Me.ExportExcelButton = New System.Windows.Forms.Button()
        Me.MemberFilterColBox = New System.Windows.Forms.ComboBox()
        Me.BySearchLabel = New System.Windows.Forms.Label()
        Me.MemberSearchButton = New System.Windows.Forms.Button()
        Me.MemberSearchTextBox = New System.Windows.Forms.TextBox()
        Me.RefreshMemberButton = New System.Windows.Forms.Button()
        Me.membersGridView = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.EmployeeFilterColBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmployeeSearchButton = New System.Windows.Forms.Button()
        Me.EmployeeSearchTextBox = New System.Windows.Forms.TextBox()
        Me.RefreshEmployeeButton = New System.Windows.Forms.Button()
        Me.employeesGridView = New System.Windows.Forms.DataGridView()
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoggedInAsLabel, Me.LoggedInLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 393)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(657, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LoggedInAsLabel
        '
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemberToolStripMenuItem, Me.EmployeeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(657, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MemberToolStripMenuItem
        '
        Me.MemberToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMemberToolStripMenuItem, Me.UpdateMemberToolStripMenuItem})
        Me.MemberToolStripMenuItem.Name = "MemberToolStripMenuItem"
        Me.MemberToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MemberToolStripMenuItem.Text = "Member"
        '
        'AddMemberToolStripMenuItem
        '
        Me.AddMemberToolStripMenuItem.Name = "AddMemberToolStripMenuItem"
        Me.AddMemberToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AddMemberToolStripMenuItem.Text = "Add Member"
        '
        'UpdateMemberToolStripMenuItem
        '
        Me.UpdateMemberToolStripMenuItem.Name = "UpdateMemberToolStripMenuItem"
        Me.UpdateMemberToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.UpdateMemberToolStripMenuItem.Text = "Update Member"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmployeeToolStripMenuItem, Me.UpdateEmployeeToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'AddEmployeeToolStripMenuItem
        '
        Me.AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        Me.AddEmployeeToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AddEmployeeToolStripMenuItem.Text = "Add Employee"
        '
        'UpdateEmployeeToolStripMenuItem
        '
        Me.UpdateEmployeeToolStripMenuItem.Name = "UpdateEmployeeToolStripMenuItem"
        Me.UpdateEmployeeToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.UpdateEmployeeToolStripMenuItem.Text = "Update Employee"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ViewMembersTab)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(632, 362)
        Me.TabControl1.TabIndex = 2
        '
        'ViewMembersTab
        '
        Me.ViewMembersTab.Controls.Add(Me.ExportExcelButton)
        Me.ViewMembersTab.Controls.Add(Me.MemberFilterColBox)
        Me.ViewMembersTab.Controls.Add(Me.BySearchLabel)
        Me.ViewMembersTab.Controls.Add(Me.MemberSearchButton)
        Me.ViewMembersTab.Controls.Add(Me.MemberSearchTextBox)
        Me.ViewMembersTab.Controls.Add(Me.RefreshMemberButton)
        Me.ViewMembersTab.Controls.Add(Me.membersGridView)
        Me.ViewMembersTab.Location = New System.Drawing.Point(4, 22)
        Me.ViewMembersTab.Name = "ViewMembersTab"
        Me.ViewMembersTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ViewMembersTab.Size = New System.Drawing.Size(624, 336)
        Me.ViewMembersTab.TabIndex = 0
        Me.ViewMembersTab.Text = "Members"
        Me.ViewMembersTab.UseVisualStyleBackColor = True
        '
        'ExportExcelButton
        '
        Me.ExportExcelButton.Location = New System.Drawing.Point(229, 4)
        Me.ExportExcelButton.Name = "ExportExcelButton"
        Me.ExportExcelButton.Size = New System.Drawing.Size(75, 23)
        Me.ExportExcelButton.TabIndex = 8
        Me.ExportExcelButton.Text = "Export Excel"
        Me.ExportExcelButton.UseVisualStyleBackColor = True
        '
        'MemberFilterColBox
        '
        Me.MemberFilterColBox.FormattingEnabled = True
        Me.MemberFilterColBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MemberFilterColBox.Items.AddRange(New Object() {"last_name", "first_name", "middle_name"})
        Me.MemberFilterColBox.Location = New System.Drawing.Point(532, 7)
        Me.MemberFilterColBox.Name = "MemberFilterColBox"
        Me.MemberFilterColBox.Size = New System.Drawing.Size(86, 21)
        Me.MemberFilterColBox.TabIndex = 7
        '
        'BySearchLabel
        '
        Me.BySearchLabel.AutoSize = True
        Me.BySearchLabel.Location = New System.Drawing.Point(497, 9)
        Me.BySearchLabel.Name = "BySearchLabel"
        Me.BySearchLabel.Size = New System.Drawing.Size(28, 13)
        Me.BySearchLabel.TabIndex = 6
        Me.BySearchLabel.Text = "By : "
        '
        'MemberSearchButton
        '
        Me.MemberSearchButton.Location = New System.Drawing.Point(310, 4)
        Me.MemberSearchButton.Name = "MemberSearchButton"
        Me.MemberSearchButton.Size = New System.Drawing.Size(75, 23)
        Me.MemberSearchButton.TabIndex = 5
        Me.MemberSearchButton.Text = "Search"
        Me.MemberSearchButton.UseVisualStyleBackColor = True
        '
        'MemberSearchTextBox
        '
        Me.MemberSearchTextBox.Location = New System.Drawing.Point(391, 6)
        Me.MemberSearchTextBox.Name = "MemberSearchTextBox"
        Me.MemberSearchTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MemberSearchTextBox.TabIndex = 4
        '
        'RefreshMemberButton
        '
        Me.RefreshMemberButton.Location = New System.Drawing.Point(6, 4)
        Me.RefreshMemberButton.Name = "RefreshMemberButton"
        Me.RefreshMemberButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshMemberButton.TabIndex = 3
        Me.RefreshMemberButton.Text = "Refresh"
        Me.RefreshMemberButton.UseVisualStyleBackColor = True
        '
        'membersGridView
        '
        Me.membersGridView.AllowUserToAddRows = False
        Me.membersGridView.AllowUserToDeleteRows = False
        Me.membersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.membersGridView.Location = New System.Drawing.Point(6, 32)
        Me.membersGridView.Name = "membersGridView"
        Me.membersGridView.ReadOnly = True
        Me.membersGridView.Size = New System.Drawing.Size(612, 298)
        Me.membersGridView.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.EmployeeFilterColBox)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.EmployeeSearchButton)
        Me.TabPage2.Controls.Add(Me.EmployeeSearchTextBox)
        Me.TabPage2.Controls.Add(Me.RefreshEmployeeButton)
        Me.TabPage2.Controls.Add(Me.employeesGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(624, 336)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Employees"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'EmployeeFilterColBox
        '
        Me.EmployeeFilterColBox.FormattingEnabled = True
        Me.EmployeeFilterColBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.EmployeeFilterColBox.Items.AddRange(New Object() {"last_name", "first_name", "middle_name"})
        Me.EmployeeFilterColBox.Location = New System.Drawing.Point(532, 7)
        Me.EmployeeFilterColBox.Name = "EmployeeFilterColBox"
        Me.EmployeeFilterColBox.Size = New System.Drawing.Size(86, 21)
        Me.EmployeeFilterColBox.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(497, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "By : "
        '
        'EmployeeSearchButton
        '
        Me.EmployeeSearchButton.Location = New System.Drawing.Point(310, 4)
        Me.EmployeeSearchButton.Name = "EmployeeSearchButton"
        Me.EmployeeSearchButton.Size = New System.Drawing.Size(75, 23)
        Me.EmployeeSearchButton.TabIndex = 9
        Me.EmployeeSearchButton.Text = "Search"
        Me.EmployeeSearchButton.UseVisualStyleBackColor = True
        '
        'EmployeeSearchTextBox
        '
        Me.EmployeeSearchTextBox.Location = New System.Drawing.Point(391, 6)
        Me.EmployeeSearchTextBox.Name = "EmployeeSearchTextBox"
        Me.EmployeeSearchTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmployeeSearchTextBox.TabIndex = 8
        '
        'RefreshEmployeeButton
        '
        Me.RefreshEmployeeButton.Location = New System.Drawing.Point(6, 6)
        Me.RefreshEmployeeButton.Name = "RefreshEmployeeButton"
        Me.RefreshEmployeeButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshEmployeeButton.TabIndex = 4
        Me.RefreshEmployeeButton.Text = "Refresh"
        Me.RefreshEmployeeButton.UseVisualStyleBackColor = True
        '
        'employeesGridView
        '
        Me.employeesGridView.AllowUserToAddRows = False
        Me.employeesGridView.AllowUserToDeleteRows = False
        Me.employeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employeesGridView.Location = New System.Drawing.Point(6, 33)
        Me.employeesGridView.Name = "employeesGridView"
        Me.employeesGridView.ReadOnly = True
        Me.employeesGridView.Size = New System.Drawing.Size(612, 297)
        Me.employeesGridView.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 415)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Gym Management"
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
    Friend WithEvents ExportExcelButton As Button
    Friend WithEvents employeesGridView As DataGridView
    Friend WithEvents RefreshEmployeeButton As Button
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeFilterColBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EmployeeSearchButton As Button
    Friend WithEvents EmployeeSearchTextBox As TextBox
End Class
