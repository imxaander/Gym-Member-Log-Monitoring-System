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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.ViewMembersTab = New System.Windows.Forms.TabPage()
        Me.membersGridView = New System.Windows.Forms.DataGridView()
        Me.RefreshMemberButton = New System.Windows.Forms.PictureBox()
        Me.UpdateMemberButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.AddMemberButton = New System.Windows.Forms.Button()
        Me.MemberFilterColBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MemberSearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.ViewEmployeesTab = New System.Windows.Forms.TabPage()
        Me.employeesGridView = New System.Windows.Forms.DataGridView()
        Me.RefreshEmployeeButton = New System.Windows.Forms.PictureBox()
        Me.UpdateEmployeeButton = New System.Windows.Forms.Button()
        Me.EmployeeSearchButton = New System.Windows.Forms.Button()
        Me.AddEmployeeButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EmployeeSearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EmployeesTabButton = New System.Windows.Forms.Button()
        Me.MembersTabButton = New System.Windows.Forms.Button()
        Me.MainHeading = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.ExitButtonMain = New System.Windows.Forms.PictureBox()
        Me.LoggedInLabel = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl.SuspendLayout()
        Me.ViewMembersTab.SuspendLayout()
        CType(Me.membersGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefreshMemberButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ViewEmployeesTab.SuspendLayout()
        CType(Me.employeesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefreshEmployeeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.ExitButtonMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl.Controls.Add(Me.ViewMembersTab)
        Me.TabControl.Controls.Add(Me.ViewEmployeesTab)
        Me.TabControl.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.ItemSize = New System.Drawing.Size(0, 1)
        Me.TabControl.Location = New System.Drawing.Point(14, 61)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(990, 567)
        Me.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl.TabIndex = 2
        '
        'ViewMembersTab
        '
        Me.ViewMembersTab.BackColor = System.Drawing.Color.White
        Me.ViewMembersTab.Controls.Add(Me.membersGridView)
        Me.ViewMembersTab.Controls.Add(Me.RefreshMemberButton)
        Me.ViewMembersTab.Controls.Add(Me.UpdateMemberButton)
        Me.ViewMembersTab.Controls.Add(Me.SearchButton)
        Me.ViewMembersTab.Controls.Add(Me.AddMemberButton)
        Me.ViewMembersTab.Controls.Add(Me.MemberFilterColBox)
        Me.ViewMembersTab.Controls.Add(Me.Label2)
        Me.ViewMembersTab.Controls.Add(Me.Label4)
        Me.ViewMembersTab.Controls.Add(Me.StatusBox)
        Me.ViewMembersTab.Controls.Add(Me.Label1)
        Me.ViewMembersTab.Controls.Add(Me.MemberSearchTextBox)
        Me.ViewMembersTab.Controls.Add(Me.SearchLabel)
        Me.ViewMembersTab.Location = New System.Drawing.Point(4, 5)
        Me.ViewMembersTab.Name = "ViewMembersTab"
        Me.ViewMembersTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ViewMembersTab.Size = New System.Drawing.Size(982, 558)
        Me.ViewMembersTab.TabIndex = 0
        '
        'membersGridView
        '
        Me.membersGridView.AllowUserToAddRows = False
        Me.membersGridView.AllowUserToDeleteRows = False
        Me.membersGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.membersGridView.BackgroundColor = System.Drawing.Color.White
        Me.membersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.membersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.membersGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.membersGridView.Location = New System.Drawing.Point(23, 140)
        Me.membersGridView.Name = "membersGridView"
        Me.membersGridView.ReadOnly = True
        Me.membersGridView.Size = New System.Drawing.Size(946, 415)
        Me.membersGridView.TabIndex = 11
        '
        'RefreshMemberButton
        '
        Me.RefreshMemberButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshMemberButton.Image = Global.gym_member_Log_monitoring_system.My.Resources.Resources._2805355
        Me.RefreshMemberButton.Location = New System.Drawing.Point(570, 100)
        Me.RefreshMemberButton.Name = "RefreshMemberButton"
        Me.RefreshMemberButton.Size = New System.Drawing.Size(39, 31)
        Me.RefreshMemberButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RefreshMemberButton.TabIndex = 10
        Me.RefreshMemberButton.TabStop = False
        '
        'UpdateMemberButton
        '
        Me.UpdateMemberButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateMemberButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.UpdateMemberButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateMemberButton.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UpdateMemberButton.ForeColor = System.Drawing.Color.White
        Me.UpdateMemberButton.Location = New System.Drawing.Point(847, 18)
        Me.UpdateMemberButton.Name = "UpdateMemberButton"
        Me.UpdateMemberButton.Size = New System.Drawing.Size(122, 31)
        Me.UpdateMemberButton.TabIndex = 11
        Me.UpdateMemberButton.Text = "UPDATE / EDIT"
        Me.UpdateMemberButton.UseVisualStyleBackColor = False
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.SearchButton.ForeColor = System.Drawing.Color.White
        Me.SearchButton.Location = New System.Drawing.Point(450, 100)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(114, 31)
        Me.SearchButton.TabIndex = 9
        Me.SearchButton.Text = "SEARCH"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'AddMemberButton
        '
        Me.AddMemberButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddMemberButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.AddMemberButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddMemberButton.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.AddMemberButton.ForeColor = System.Drawing.Color.White
        Me.AddMemberButton.Location = New System.Drawing.Point(733, 18)
        Me.AddMemberButton.Name = "AddMemberButton"
        Me.AddMemberButton.Size = New System.Drawing.Size(114, 31)
        Me.AddMemberButton.TabIndex = 10
        Me.AddMemberButton.Text = "CREATE NEW"
        Me.AddMemberButton.UseVisualStyleBackColor = False
        '
        'MemberFilterColBox
        '
        Me.MemberFilterColBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.MemberFilterColBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MemberFilterColBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MemberFilterColBox.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MemberFilterColBox.FormattingEnabled = True
        Me.MemberFilterColBox.ItemHeight = 19
        Me.MemberFilterColBox.Items.AddRange(New Object() {"Member ID", "First Name", "Last Name", "Middle Name", "Email", "All"})
        Me.MemberFilterColBox.Location = New System.Drawing.Point(355, 104)
        Me.MemberFilterColBox.Name = "MemberFilterColBox"
        Me.MemberFilterColBox.Size = New System.Drawing.Size(87, 27)
        Me.MemberFilterColBox.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(351, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(-5, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Members"
        '
        'StatusBox
        '
        Me.StatusBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.StatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StatusBox.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.StatusBox.FormattingEnabled = True
        Me.StatusBox.ItemHeight = 19
        Me.StatusBox.Items.AddRange(New Object() {"Danger", "Warning", "Safe", "All"})
        Me.StatusBox.Location = New System.Drawing.Point(882, 100)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.Size = New System.Drawing.Size(87, 27)
        Me.StatusBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(878, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Status"
        '
        'MemberSearchTextBox
        '
        Me.MemberSearchTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.MemberSearchTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.MemberSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MemberSearchTextBox.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MemberSearchTextBox.ForeColor = System.Drawing.Color.Black
        Me.MemberSearchTextBox.Location = New System.Drawing.Point(23, 104)
        Me.MemberSearchTextBox.MaxLength = 20
        Me.MemberSearchTextBox.Multiline = True
        Me.MemberSearchTextBox.Name = "MemberSearchTextBox"
        Me.MemberSearchTextBox.Size = New System.Drawing.Size(326, 27)
        Me.MemberSearchTextBox.TabIndex = 0
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.BackColor = System.Drawing.Color.Transparent
        Me.SearchLabel.Font = New System.Drawing.Font("Gadugi", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.Location = New System.Drawing.Point(19, 82)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(186, 19)
        Me.SearchLabel.TabIndex = 4
        Me.SearchLabel.Text = "Who are you looking for?"
        '
        'ViewEmployeesTab
        '
        Me.ViewEmployeesTab.BackColor = System.Drawing.Color.White
        Me.ViewEmployeesTab.Controls.Add(Me.employeesGridView)
        Me.ViewEmployeesTab.Controls.Add(Me.RefreshEmployeeButton)
        Me.ViewEmployeesTab.Controls.Add(Me.UpdateEmployeeButton)
        Me.ViewEmployeesTab.Controls.Add(Me.EmployeeSearchButton)
        Me.ViewEmployeesTab.Controls.Add(Me.AddEmployeeButton)
        Me.ViewEmployeesTab.Controls.Add(Me.Label5)
        Me.ViewEmployeesTab.Controls.Add(Me.EmployeeSearchTextBox)
        Me.ViewEmployeesTab.Controls.Add(Me.Label7)
        Me.ViewEmployeesTab.Location = New System.Drawing.Point(4, 5)
        Me.ViewEmployeesTab.Name = "ViewEmployeesTab"
        Me.ViewEmployeesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ViewEmployeesTab.Size = New System.Drawing.Size(982, 558)
        Me.ViewEmployeesTab.TabIndex = 1
        '
        'employeesGridView
        '
        Me.employeesGridView.AllowUserToAddRows = False
        Me.employeesGridView.AllowUserToDeleteRows = False
        Me.employeesGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.employeesGridView.BackgroundColor = System.Drawing.Color.White
        Me.employeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employeesGridView.Location = New System.Drawing.Point(23, 140)
        Me.employeesGridView.Name = "employeesGridView"
        Me.employeesGridView.ReadOnly = True
        Me.employeesGridView.Size = New System.Drawing.Size(946, 415)
        Me.employeesGridView.TabIndex = 11
        '
        'RefreshEmployeeButton
        '
        Me.RefreshEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshEmployeeButton.Image = Global.gym_member_Log_monitoring_system.My.Resources.Resources._2805355
        Me.RefreshEmployeeButton.Location = New System.Drawing.Point(475, 100)
        Me.RefreshEmployeeButton.Name = "RefreshEmployeeButton"
        Me.RefreshEmployeeButton.Size = New System.Drawing.Size(39, 31)
        Me.RefreshEmployeeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RefreshEmployeeButton.TabIndex = 10
        Me.RefreshEmployeeButton.TabStop = False
        '
        'UpdateEmployeeButton
        '
        Me.UpdateEmployeeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateEmployeeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.UpdateEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateEmployeeButton.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UpdateEmployeeButton.ForeColor = System.Drawing.Color.White
        Me.UpdateEmployeeButton.Location = New System.Drawing.Point(847, 18)
        Me.UpdateEmployeeButton.Name = "UpdateEmployeeButton"
        Me.UpdateEmployeeButton.Size = New System.Drawing.Size(122, 31)
        Me.UpdateEmployeeButton.TabIndex = 11
        Me.UpdateEmployeeButton.Text = "UPDATE / EDIT"
        Me.UpdateEmployeeButton.UseVisualStyleBackColor = False
        '
        'EmployeeSearchButton
        '
        Me.EmployeeSearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.EmployeeSearchButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmployeeSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeSearchButton.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.EmployeeSearchButton.ForeColor = System.Drawing.Color.White
        Me.EmployeeSearchButton.Location = New System.Drawing.Point(355, 100)
        Me.EmployeeSearchButton.Name = "EmployeeSearchButton"
        Me.EmployeeSearchButton.Size = New System.Drawing.Size(114, 31)
        Me.EmployeeSearchButton.TabIndex = 9
        Me.EmployeeSearchButton.Text = "SEARCH"
        Me.EmployeeSearchButton.UseVisualStyleBackColor = False
        '
        'AddEmployeeButton
        '
        Me.AddEmployeeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddEmployeeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.AddEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddEmployeeButton.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.AddEmployeeButton.ForeColor = System.Drawing.Color.White
        Me.AddEmployeeButton.Location = New System.Drawing.Point(733, 18)
        Me.AddEmployeeButton.Name = "AddEmployeeButton"
        Me.AddEmployeeButton.Size = New System.Drawing.Size(114, 31)
        Me.AddEmployeeButton.TabIndex = 10
        Me.AddEmployeeButton.Text = "CREATE NEW"
        Me.AddEmployeeButton.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(-5, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 30)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Employees"
        '
        'EmployeeSearchTextBox
        '
        Me.EmployeeSearchTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.EmployeeSearchTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.EmployeeSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmployeeSearchTextBox.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.EmployeeSearchTextBox.ForeColor = System.Drawing.Color.Black
        Me.EmployeeSearchTextBox.Location = New System.Drawing.Point(23, 104)
        Me.EmployeeSearchTextBox.MaxLength = 20
        Me.EmployeeSearchTextBox.Multiline = True
        Me.EmployeeSearchTextBox.Name = "EmployeeSearchTextBox"
        Me.EmployeeSearchTextBox.Size = New System.Drawing.Size(326, 27)
        Me.EmployeeSearchTextBox.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Gadugi", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 19)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Who are you looking for?"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.EmployeesTabButton)
        Me.Panel3.Controls.Add(Me.MembersTabButton)
        Me.Panel3.Controls.Add(Me.MainHeading)
        Me.Panel3.Location = New System.Drawing.Point(-1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 641)
        Me.Panel3.TabIndex = 4
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.gym_member_Log_monitoring_system.My.Resources.Resources.manipaksiw_logo_nobg
        Me.PictureBox4.Location = New System.Drawing.Point(15, 25)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(59, 62)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.gym_member_Log_monitoring_system.My.Resources.Resources.group
        Me.PictureBox2.Location = New System.Drawing.Point(27, 197)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.gym_member_Log_monitoring_system.My.Resources.Resources.group
        Me.PictureBox1.Location = New System.Drawing.Point(27, 135)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'EmployeesTabButton
        '
        Me.EmployeesTabButton.BackColor = System.Drawing.Color.Transparent
        Me.EmployeesTabButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmployeesTabButton.FlatAppearance.BorderSize = 0
        Me.EmployeesTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeesTabButton.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.EmployeesTabButton.ForeColor = System.Drawing.Color.White
        Me.EmployeesTabButton.Location = New System.Drawing.Point(3, 183)
        Me.EmployeesTabButton.Name = "EmployeesTabButton"
        Me.EmployeesTabButton.Size = New System.Drawing.Size(204, 57)
        Me.EmployeesTabButton.TabIndex = 2
        Me.EmployeesTabButton.Text = "Employees"
        Me.EmployeesTabButton.UseVisualStyleBackColor = False
        '
        'MembersTabButton
        '
        Me.MembersTabButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.MembersTabButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MembersTabButton.FlatAppearance.BorderSize = 0
        Me.MembersTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MembersTabButton.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MembersTabButton.ForeColor = System.Drawing.Color.White
        Me.MembersTabButton.Location = New System.Drawing.Point(0, 120)
        Me.MembersTabButton.Name = "MembersTabButton"
        Me.MembersTabButton.Size = New System.Drawing.Size(210, 57)
        Me.MembersTabButton.TabIndex = 1
        Me.MembersTabButton.Text = "Members"
        Me.MembersTabButton.UseVisualStyleBackColor = False
        '
        'MainHeading
        '
        Me.MainHeading.AutoSize = True
        Me.MainHeading.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainHeading.ForeColor = System.Drawing.Color.White
        Me.MainHeading.Location = New System.Drawing.Point(92, 37)
        Me.MainHeading.Name = "MainHeading"
        Me.MainHeading.Size = New System.Drawing.Size(87, 48)
        Me.MainHeading.TabIndex = 0
        Me.MainHeading.Text = "MANNY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PAKSIW"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.TimeLabel)
        Me.Panel4.Controls.Add(Me.ExitButtonMain)
        Me.Panel4.Controls.Add(Me.LoggedInLabel)
        Me.Panel4.Controls.Add(Me.PictureBox3)
        Me.Panel4.Controls.Add(Me.TabControl)
        Me.Panel4.Location = New System.Drawing.Point(215, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1019, 641)
        Me.Panel4.TabIndex = 5
        '
        'TimeLabel
        '
        Me.TimeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TimeLabel.Location = New System.Drawing.Point(455, 29)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(42, 19)
        Me.TimeLabel.TabIndex = 11
        Me.TimeLabel.Text = "Time"
        '
        'ExitButtonMain
        '
        Me.ExitButtonMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButtonMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButtonMain.Image = Global.gym_member_Log_monitoring_system.My.Resources.Resources.logout
        Me.ExitButtonMain.Location = New System.Drawing.Point(960, 25)
        Me.ExitButtonMain.Name = "ExitButtonMain"
        Me.ExitButtonMain.Size = New System.Drawing.Size(27, 26)
        Me.ExitButtonMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExitButtonMain.TabIndex = 10
        Me.ExitButtonMain.TabStop = False
        '
        'LoggedInLabel
        '
        Me.LoggedInLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoggedInLabel.AutoSize = True
        Me.LoggedInLabel.BackColor = System.Drawing.Color.Transparent
        Me.LoggedInLabel.Font = New System.Drawing.Font("Gadugi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoggedInLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.LoggedInLabel.Location = New System.Drawing.Point(848, 29)
        Me.LoggedInLabel.Name = "LoggedInLabel"
        Me.LoggedInLabel.Size = New System.Drawing.Size(82, 19)
        Me.LoggedInLabel.TabIndex = 10
        Me.LoggedInLabel.Text = "User Name"
        Me.LoggedInLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = Global.gym_member_Log_monitoring_system.My.Resources.Resources.user
        Me.PictureBox3.Location = New System.Drawing.Point(807, 23)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'Timer
        '
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1246, 640)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gym Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl.ResumeLayout(False)
        Me.ViewMembersTab.ResumeLayout(False)
        Me.ViewMembersTab.PerformLayout()
        CType(Me.membersGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefreshMemberButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ViewEmployeesTab.ResumeLayout(False)
        Me.ViewEmployeesTab.PerformLayout()
        CType(Me.employeesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefreshEmployeeButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.ExitButtonMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As TabControl
    Friend WithEvents ViewMembersTab As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MainHeading As Label
    Friend WithEvents EmployeesTabButton As Button
    Friend WithEvents MembersTabButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents MemberSearchTextBox As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents SearchLabel As Label
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents MemberFilterColBox As ComboBox
    Public WithEvents Label2 As Label
    Friend WithEvents StatusBox As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents UpdateMemberButton As Button
    Friend WithEvents AddMemberButton As Button
    Friend WithEvents ExitButtonMain As PictureBox
    Friend WithEvents LoggedInLabel As Label
    Friend WithEvents RefreshMemberButton As PictureBox
    Friend WithEvents membersGridView As DataGridView
    Friend WithEvents ViewEmployeesTab As TabPage
    Friend WithEvents employeesGridView As DataGridView
    Friend WithEvents RefreshEmployeeButton As PictureBox
    Friend WithEvents UpdateEmployeeButton As Button
    Friend WithEvents EmployeeSearchButton As Button
    Friend WithEvents AddEmployeeButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents EmployeeSearchTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Timer As Timer
    Friend WithEvents TimeLabel As Label
End Class
