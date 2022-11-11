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
        Me.AddDateStartLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddEndDateLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateOfBirthPicker = New System.Windows.Forms.DateTimePicker()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderBox = New System.Windows.Forms.ComboBox()
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.EndDatePicker = New System.Windows.Forms.DateTimePicker()
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
        CType(Me.MemberImagePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddLastNameLabel
        '
        Me.AddLastNameLabel.AutoSize = True
        Me.AddLastNameLabel.Location = New System.Drawing.Point(82, 50)
        Me.AddLastNameLabel.Name = "AddLastNameLabel"
        Me.AddLastNameLabel.Size = New System.Drawing.Size(58, 13)
        Me.AddLastNameLabel.TabIndex = 0
        Me.AddLastNameLabel.Text = "Last Name"
        '
        'AddFirstNameLabel
        '
        Me.AddFirstNameLabel.AutoSize = True
        Me.AddFirstNameLabel.Location = New System.Drawing.Point(88, 78)
        Me.AddFirstNameLabel.Name = "AddFirstNameLabel"
        Me.AddFirstNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.AddFirstNameLabel.TabIndex = 1
        Me.AddFirstNameLabel.Text = "First Name"
        '
        'AddMiddleNameLabel
        '
        Me.AddMiddleNameLabel.AutoSize = True
        Me.AddMiddleNameLabel.Location = New System.Drawing.Point(74, 107)
        Me.AddMiddleNameLabel.Name = "AddMiddleNameLabel"
        Me.AddMiddleNameLabel.Size = New System.Drawing.Size(69, 13)
        Me.AddMiddleNameLabel.TabIndex = 2
        Me.AddMiddleNameLabel.Text = "Middle Name"
        '
        'AddDobLabel
        '
        Me.AddDobLabel.AutoSize = True
        Me.AddDobLabel.Location = New System.Drawing.Point(76, 139)
        Me.AddDobLabel.Name = "AddDobLabel"
        Me.AddDobLabel.Size = New System.Drawing.Size(66, 13)
        Me.AddDobLabel.TabIndex = 3
        Me.AddDobLabel.Text = "Date of Birth"
        '
        'AddGenderLabel
        '
        Me.AddGenderLabel.AutoSize = True
        Me.AddGenderLabel.Location = New System.Drawing.Point(98, 163)
        Me.AddGenderLabel.Name = "AddGenderLabel"
        Me.AddGenderLabel.Size = New System.Drawing.Size(42, 13)
        Me.AddGenderLabel.TabIndex = 4
        Me.AddGenderLabel.Text = "Gender"
        '
        'AddDateStartLabel
        '
        Me.AddDateStartLabel.AutoSize = True
        Me.AddDateStartLabel.Location = New System.Drawing.Point(113, 363)
        Me.AddDateStartLabel.Name = "AddDateStartLabel"
        Me.AddDateStartLabel.Size = New System.Drawing.Size(29, 13)
        Me.AddDateStartLabel.TabIndex = 5
        Me.AddDateStartLabel.Text = "Start"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 337)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Membership"
        '
        'AddEndDateLabel
        '
        Me.AddEndDateLabel.AutoSize = True
        Me.AddEndDateLabel.Location = New System.Drawing.Point(114, 389)
        Me.AddEndDateLabel.Name = "AddEndDateLabel"
        Me.AddEndDateLabel.Size = New System.Drawing.Size(26, 13)
        Me.AddEndDateLabel.TabIndex = 7
        Me.AddEndDateLabel.Text = "End"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Member Details"
        '
        'DateOfBirthPicker
        '
        Me.DateOfBirthPicker.CustomFormat = "yyy-MM-dd"
        Me.DateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfBirthPicker.Location = New System.Drawing.Point(151, 133)
        Me.DateOfBirthPicker.Name = "DateOfBirthPicker"
        Me.DateOfBirthPicker.Size = New System.Drawing.Size(95, 20)
        Me.DateOfBirthPicker.TabIndex = 9
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(151, 47)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LastNameTextBox.TabIndex = 10
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(151, 75)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FirstNameTextBox.TabIndex = 11
        '
        'GenderBox
        '
        Me.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderBox.FormattingEnabled = True
        Me.GenderBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderBox.Location = New System.Drawing.Point(151, 160)
        Me.GenderBox.Name = "GenderBox"
        Me.GenderBox.Size = New System.Drawing.Size(200, 21)
        Me.GenderBox.TabIndex = 14
        '
        'StartDatePicker
        '
        Me.StartDatePicker.CustomFormat = "yyyy-MM-dd"
        Me.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDatePicker.Location = New System.Drawing.Point(151, 357)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.Size = New System.Drawing.Size(95, 20)
        Me.StartDatePicker.TabIndex = 15
        '
        'EndDatePicker
        '
        Me.EndDatePicker.CustomFormat = "yyyy-MM-dd"
        Me.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDatePicker.Location = New System.Drawing.Point(151, 383)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.Size = New System.Drawing.Size(95, 20)
        Me.EndDatePicker.TabIndex = 16
        '
        'AddMemberButton
        '
        Me.AddMemberButton.Location = New System.Drawing.Point(151, 426)
        Me.AddMemberButton.Name = "AddMemberButton"
        Me.AddMemberButton.Size = New System.Drawing.Size(75, 23)
        Me.AddMemberButton.TabIndex = 17
        Me.AddMemberButton.Text = "Confirm Add"
        Me.AddMemberButton.UseVisualStyleBackColor = True
        '
        'CancelAddButton
        '
        Me.CancelAddButton.Location = New System.Drawing.Point(276, 426)
        Me.CancelAddButton.Name = "CancelAddButton"
        Me.CancelAddButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelAddButton.TabIndex = 18
        Me.CancelAddButton.Text = "Cancel"
        Me.CancelAddButton.UseVisualStyleBackColor = True
        '
        'ClearFieldsButton
        '
        Me.ClearFieldsButton.Location = New System.Drawing.Point(369, 21)
        Me.ClearFieldsButton.Name = "ClearFieldsButton"
        Me.ClearFieldsButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearFieldsButton.TabIndex = 19
        Me.ClearFieldsButton.Text = "Clear"
        Me.ClearFieldsButton.UseVisualStyleBackColor = True
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(151, 104)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MiddleNameTextBox.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Contact No"
        '
        'ContactTextBox
        '
        Me.ContactTextBox.Location = New System.Drawing.Point(151, 188)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ContactTextBox.TabIndex = 22
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(151, 214)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AddressTextBox.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(98, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Image"
        '
        'InsertImageButton
        '
        Me.InsertImageButton.Location = New System.Drawing.Point(151, 259)
        Me.InsertImageButton.Name = "InsertImageButton"
        Me.InsertImageButton.Size = New System.Drawing.Size(75, 23)
        Me.InsertImageButton.TabIndex = 26
        Me.InsertImageButton.Text = "Insert Image"
        Me.InsertImageButton.UseVisualStyleBackColor = True
        '
        'MemberImagePreview
        '
        Me.MemberImagePreview.Location = New System.Drawing.Point(276, 259)
        Me.MemberImagePreview.Name = "MemberImagePreview"
        Me.MemberImagePreview.Size = New System.Drawing.Size(112, 91)
        Me.MemberImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MemberImagePreview.TabIndex = 27
        Me.MemberImagePreview.TabStop = False
        '
        'AddMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 469)
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
        Me.Controls.Add(Me.EndDatePicker)
        Me.Controls.Add(Me.StartDatePicker)
        Me.Controls.Add(Me.GenderBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.DateOfBirthPicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AddEndDateLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddDateStartLabel)
        Me.Controls.Add(Me.AddGenderLabel)
        Me.Controls.Add(Me.AddDobLabel)
        Me.Controls.Add(Me.AddMiddleNameLabel)
        Me.Controls.Add(Me.AddFirstNameLabel)
        Me.Controls.Add(Me.AddLastNameLabel)
        Me.Name = "AddMember"
        Me.Text = "Add Member"
        CType(Me.MemberImagePreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddLastNameLabel As Label
    Friend WithEvents AddFirstNameLabel As Label
    Friend WithEvents AddMiddleNameLabel As Label
    Friend WithEvents AddDobLabel As Label
    Friend WithEvents AddGenderLabel As Label
    Friend WithEvents AddDateStartLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AddEndDateLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateOfBirthPicker As DateTimePicker
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents GenderBox As ComboBox
    Friend WithEvents StartDatePicker As DateTimePicker
    Friend WithEvents EndDatePicker As DateTimePicker
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
End Class
