<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMember
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AddLastNameLabel = New System.Windows.Forms.Label()
        Me.AddFirstNameLabel = New System.Windows.Forms.Label()
        Me.AddMiddleNameLabel = New System.Windows.Forms.Label()
        Me.AddDobLabel = New System.Windows.Forms.Label()
        Me.AddGenderLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateOfBirthPicker = New System.Windows.Forms.DateTimePicker()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderBox = New System.Windows.Forms.ComboBox()
        Me.AddMemberButton = New System.Windows.Forms.Button()
        Me.CancelAddButton = New System.Windows.Forms.Button()
        Me.ClearFieldsButton = New System.Windows.Forms.Button()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.InsertImageButton = New System.Windows.Forms.Button()
        Me.MemberImagePreview = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PackageComboBox = New System.Windows.Forms.ComboBox()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.LocationComboBox = New System.Windows.Forms.ComboBox()
        Me.NumPrefixBox = New System.Windows.Forms.ComboBox()
        CType(Me.MemberImagePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddLastNameLabel
        '
        Me.AddLastNameLabel.AutoSize = True
        Me.AddLastNameLabel.ForeColor = System.Drawing.Color.White
        Me.AddLastNameLabel.Location = New System.Drawing.Point(82, 72)
        Me.AddLastNameLabel.Name = "AddLastNameLabel"
        Me.AddLastNameLabel.Size = New System.Drawing.Size(58, 13)
        Me.AddLastNameLabel.TabIndex = 0
        Me.AddLastNameLabel.Text = "Last Name"
        '
        'AddFirstNameLabel
        '
        Me.AddFirstNameLabel.AutoSize = True
        Me.AddFirstNameLabel.ForeColor = System.Drawing.Color.White
        Me.AddFirstNameLabel.Location = New System.Drawing.Point(88, 100)
        Me.AddFirstNameLabel.Name = "AddFirstNameLabel"
        Me.AddFirstNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.AddFirstNameLabel.TabIndex = 1
        Me.AddFirstNameLabel.Text = "First Name"
        '
        'AddMiddleNameLabel
        '
        Me.AddMiddleNameLabel.AutoSize = True
        Me.AddMiddleNameLabel.ForeColor = System.Drawing.Color.White
        Me.AddMiddleNameLabel.Location = New System.Drawing.Point(74, 129)
        Me.AddMiddleNameLabel.Name = "AddMiddleNameLabel"
        Me.AddMiddleNameLabel.Size = New System.Drawing.Size(69, 13)
        Me.AddMiddleNameLabel.TabIndex = 2
        Me.AddMiddleNameLabel.Text = "Middle Name"
        '
        'AddDobLabel
        '
        Me.AddDobLabel.AutoSize = True
        Me.AddDobLabel.ForeColor = System.Drawing.Color.White
        Me.AddDobLabel.Location = New System.Drawing.Point(76, 161)
        Me.AddDobLabel.Name = "AddDobLabel"
        Me.AddDobLabel.Size = New System.Drawing.Size(66, 13)
        Me.AddDobLabel.TabIndex = 3
        Me.AddDobLabel.Text = "Date of Birth"
        '
        'AddGenderLabel
        '
        Me.AddGenderLabel.AutoSize = True
        Me.AddGenderLabel.ForeColor = System.Drawing.Color.White
        Me.AddGenderLabel.Location = New System.Drawing.Point(98, 185)
        Me.AddGenderLabel.Name = "AddGenderLabel"
        Me.AddGenderLabel.Size = New System.Drawing.Size(42, 13)
        Me.AddGenderLabel.TabIndex = 4
        Me.AddGenderLabel.Text = "Gender"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 359)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Membership"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Member Details"
        '
        'DateOfBirthPicker
        '
        Me.DateOfBirthPicker.CustomFormat = "yyy-MM-dd"
        Me.DateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfBirthPicker.Location = New System.Drawing.Point(151, 155)
        Me.DateOfBirthPicker.Name = "DateOfBirthPicker"
        Me.DateOfBirthPicker.Size = New System.Drawing.Size(95, 20)
        Me.DateOfBirthPicker.TabIndex = 9
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LastNameTextBox.ForeColor = System.Drawing.Color.White
        Me.LastNameTextBox.Location = New System.Drawing.Point(151, 69)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 13)
        Me.LastNameTextBox.TabIndex = 10
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FirstNameTextBox.ForeColor = System.Drawing.Color.White
        Me.FirstNameTextBox.Location = New System.Drawing.Point(151, 97)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 13)
        Me.FirstNameTextBox.TabIndex = 11
        '
        'GenderBox
        '
        Me.GenderBox.BackColor = System.Drawing.Color.Black
        Me.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderBox.ForeColor = System.Drawing.Color.White
        Me.GenderBox.FormattingEnabled = True
        Me.GenderBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderBox.Location = New System.Drawing.Point(151, 182)
        Me.GenderBox.Name = "GenderBox"
        Me.GenderBox.Size = New System.Drawing.Size(200, 21)
        Me.GenderBox.TabIndex = 14
        '
        'AddMemberButton
        '
        Me.AddMemberButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.AddMemberButton.FlatAppearance.BorderSize = 0
        Me.AddMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddMemberButton.ForeColor = System.Drawing.Color.White
        Me.AddMemberButton.Location = New System.Drawing.Point(151, 448)
        Me.AddMemberButton.Name = "AddMemberButton"
        Me.AddMemberButton.Size = New System.Drawing.Size(75, 23)
        Me.AddMemberButton.TabIndex = 17
        Me.AddMemberButton.Text = "Confirm Add"
        Me.AddMemberButton.UseVisualStyleBackColor = False
        '
        'CancelAddButton
        '
        Me.CancelAddButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.CancelAddButton.FlatAppearance.BorderSize = 0
        Me.CancelAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelAddButton.ForeColor = System.Drawing.Color.White
        Me.CancelAddButton.Location = New System.Drawing.Point(276, 448)
        Me.CancelAddButton.Name = "CancelAddButton"
        Me.CancelAddButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelAddButton.TabIndex = 18
        Me.CancelAddButton.Text = "Cancel"
        Me.CancelAddButton.UseVisualStyleBackColor = False
        '
        'ClearFieldsButton
        '
        Me.ClearFieldsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.ClearFieldsButton.FlatAppearance.BorderSize = 0
        Me.ClearFieldsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearFieldsButton.ForeColor = System.Drawing.Color.White
        Me.ClearFieldsButton.Location = New System.Drawing.Point(369, 43)
        Me.ClearFieldsButton.Name = "ClearFieldsButton"
        Me.ClearFieldsButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearFieldsButton.TabIndex = 19
        Me.ClearFieldsButton.Text = "Clear"
        Me.ClearFieldsButton.UseVisualStyleBackColor = False
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.MiddleNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MiddleNameTextBox.ForeColor = System.Drawing.Color.White
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(151, 126)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(200, 13)
        Me.MiddleNameTextBox.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(81, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Contact No"
        '
        'ContactTextBox
        '
        Me.ContactTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ContactTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ContactTextBox.ForeColor = System.Drawing.Color.White
        Me.ContactTextBox.Location = New System.Drawing.Point(223, 210)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(128, 13)
        Me.ContactTextBox.TabIndex = 22
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AddressTextBox.ForeColor = System.Drawing.Color.White
        Me.AddressTextBox.Location = New System.Drawing.Point(260, 236)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(91, 13)
        Me.AddressTextBox.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(81, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(98, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Image"
        '
        'InsertImageButton
        '
        Me.InsertImageButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.InsertImageButton.FlatAppearance.BorderSize = 0
        Me.InsertImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InsertImageButton.ForeColor = System.Drawing.Color.White
        Me.InsertImageButton.Location = New System.Drawing.Point(151, 281)
        Me.InsertImageButton.Name = "InsertImageButton"
        Me.InsertImageButton.Size = New System.Drawing.Size(75, 23)
        Me.InsertImageButton.TabIndex = 26
        Me.InsertImageButton.Text = "Insert Image"
        Me.InsertImageButton.UseVisualStyleBackColor = False
        '
        'MemberImagePreview
        '
        Me.MemberImagePreview.Location = New System.Drawing.Point(276, 281)
        Me.MemberImagePreview.Name = "MemberImagePreview"
        Me.MemberImagePreview.Size = New System.Drawing.Size(112, 91)
        Me.MemberImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MemberImagePreview.TabIndex = 27
        Me.MemberImagePreview.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.Location = New System.Drawing.Point(436, 0)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(24, 24)
        Me.ExitButton.TabIndex = 52
        Me.ExitButton.Text = "×"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(151, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 2)
        Me.Label6.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(151, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 2)
        Me.Label7.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(151, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 2)
        Me.Label8.TabIndex = 55
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(223, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 2)
        Me.Label9.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(260, 252)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 2)
        Me.Label10.TabIndex = 57
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemberToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(460, 24)
        Me.MenuStrip1.TabIndex = 58
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MemberToolStripMenuItem
        '
        Me.MemberToolStripMenuItem.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MemberToolStripMenuItem.Name = "MemberToolStripMenuItem"
        Me.MemberToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.MemberToolStripMenuItem.Text = "Add Member"
        '
        'PackageComboBox
        '
        Me.PackageComboBox.FormattingEnabled = True
        Me.PackageComboBox.Location = New System.Drawing.Point(125, 356)
        Me.PackageComboBox.Name = "PackageComboBox"
        Me.PackageComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PackageComboBox.TabIndex = 59
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.ForeColor = System.Drawing.Color.White
        Me.DescriptionLabel.Location = New System.Drawing.Point(98, 409)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(64, 13)
        Me.DescriptionLabel.TabIndex = 60
        Me.DescriptionLabel.Text = "Membership"
        '
        'LocationComboBox
        '
        Me.LocationComboBox.BackColor = System.Drawing.Color.Black
        Me.LocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LocationComboBox.ForeColor = System.Drawing.Color.White
        Me.LocationComboBox.FormattingEnabled = True
        Me.LocationComboBox.Items.AddRange(New Object() {"Paranaque", "Las Piñas"})
        Me.LocationComboBox.Location = New System.Drawing.Point(151, 233)
        Me.LocationComboBox.Name = "LocationComboBox"
        Me.LocationComboBox.Size = New System.Drawing.Size(103, 21)
        Me.LocationComboBox.TabIndex = 61
        '
        'NumPrefixBox
        '
        Me.NumPrefixBox.BackColor = System.Drawing.Color.Black
        Me.NumPrefixBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NumPrefixBox.ForeColor = System.Drawing.Color.White
        Me.NumPrefixBox.FormattingEnabled = True
        Me.NumPrefixBox.Items.AddRange(New Object() {"0817", "0905", "0906", "0908", "0909", "0910", "0912", "0915", "0916", "0917", "0918", "0919", "0920", "0921", "0922", "0923", "0924", "0925", "0926", "0927", "0928", "0929", "0930", "0931", "0932", "0934", "0935", "0936", "0937", "0938", "0939", "0940", "0941", "0942", "0943", "0945", "0946", "0947", "0948", "0949", "0950", "0951", "0953", "0954", "0955", "0956", "0961", "0965", "0966", "0967", "0973", "0974", "0975", "0976", "0977", "0978", "0979", "0994", "0995", "0996", "0997", "0998", "0999"})
        Me.NumPrefixBox.Location = New System.Drawing.Point(151, 207)
        Me.NumPrefixBox.Name = "NumPrefixBox"
        Me.NumPrefixBox.Size = New System.Drawing.Size(66, 21)
        Me.NumPrefixBox.TabIndex = 62
        '
        'AddMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(460, 483)
        Me.Controls.Add(Me.NumPrefixBox)
        Me.Controls.Add(Me.LocationComboBox)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.PackageComboBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MemberImagePreview)
        Me.Controls.Add(Me.InsertImageButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ContactTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MiddleNameTextBox)
        Me.Controls.Add(Me.ClearFieldsButton)
        Me.Controls.Add(Me.CancelAddButton)
        Me.Controls.Add(Me.AddMemberButton)
        Me.Controls.Add(Me.GenderBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.DateOfBirthPicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddGenderLabel)
        Me.Controls.Add(Me.AddDobLabel)
        Me.Controls.Add(Me.AddMiddleNameLabel)
        Me.Controls.Add(Me.AddFirstNameLabel)
        Me.Controls.Add(Me.AddLastNameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddMember"
        Me.Text = " "
        CType(Me.MemberImagePreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddLastNameLabel As Label
    Friend WithEvents AddFirstNameLabel As Label
    Friend WithEvents AddMiddleNameLabel As Label
    Friend WithEvents AddDobLabel As Label
    Friend WithEvents AddGenderLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateOfBirthPicker As DateTimePicker
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents GenderBox As ComboBox
    Friend WithEvents AddMemberButton As Button
    Friend WithEvents CancelAddButton As Button
    Friend WithEvents ClearFieldsButton As Button
    Friend WithEvents MiddleNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ContactTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents InsertImageButton As Button
    Friend WithEvents MemberImagePreview As PictureBox
    Friend WithEvents ExitButton As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PackageComboBox As ComboBox
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents LocationComboBox As ComboBox
    Friend WithEvents NumPrefixBox As ComboBox
End Class
