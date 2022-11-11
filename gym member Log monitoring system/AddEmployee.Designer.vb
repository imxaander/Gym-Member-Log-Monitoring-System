<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployee
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
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.ClearFieldsButton = New System.Windows.Forms.Button()
        Me.CancelAddButton = New System.Windows.Forms.Button()
        Me.AddEmployeeButton = New System.Windows.Forms.Button()
        Me.GenderBox = New System.Windows.Forms.ComboBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.DateOfBirthPicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddGenderLabel = New System.Windows.Forms.Label()
        Me.AddDobLabel = New System.Windows.Forms.Label()
        Me.AddMiddleNameLabel = New System.Windows.Forms.Label()
        Me.AddFirstNameLabel = New System.Windows.Forms.Label()
        Me.AddLastNameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(146, 210)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AddressTextBox.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Address"
        '
        'ContactTextBox
        '
        Me.ContactTextBox.Location = New System.Drawing.Point(146, 184)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ContactTextBox.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Contact No"
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(146, 100)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MiddleNameTextBox.TabIndex = 46
        '
        'ClearFieldsButton
        '
        Me.ClearFieldsButton.Location = New System.Drawing.Point(364, 17)
        Me.ClearFieldsButton.Name = "ClearFieldsButton"
        Me.ClearFieldsButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearFieldsButton.TabIndex = 45
        Me.ClearFieldsButton.Text = "Clear"
        Me.ClearFieldsButton.UseVisualStyleBackColor = True
        '
        'CancelAddButton
        '
        Me.CancelAddButton.Location = New System.Drawing.Point(271, 276)
        Me.CancelAddButton.Name = "CancelAddButton"
        Me.CancelAddButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelAddButton.TabIndex = 44
        Me.CancelAddButton.Text = "Cancel"
        Me.CancelAddButton.UseVisualStyleBackColor = True
        '
        'AddEmployeeButton
        '
        Me.AddEmployeeButton.Location = New System.Drawing.Point(146, 276)
        Me.AddEmployeeButton.Name = "AddEmployeeButton"
        Me.AddEmployeeButton.Size = New System.Drawing.Size(75, 23)
        Me.AddEmployeeButton.TabIndex = 43
        Me.AddEmployeeButton.Text = "Confirm Add"
        Me.AddEmployeeButton.UseVisualStyleBackColor = True
        '
        'GenderBox
        '
        Me.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderBox.FormattingEnabled = True
        Me.GenderBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderBox.Location = New System.Drawing.Point(146, 156)
        Me.GenderBox.Name = "GenderBox"
        Me.GenderBox.Size = New System.Drawing.Size(200, 21)
        Me.GenderBox.TabIndex = 40
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(146, 71)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FirstNameTextBox.TabIndex = 39
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(146, 43)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LastNameTextBox.TabIndex = 38
        '
        'DateOfBirthPicker
        '
        Me.DateOfBirthPicker.CustomFormat = "yyy-MM-dd"
        Me.DateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfBirthPicker.Location = New System.Drawing.Point(146, 129)
        Me.DateOfBirthPicker.Name = "DateOfBirthPicker"
        Me.DateOfBirthPicker.Size = New System.Drawing.Size(95, 20)
        Me.DateOfBirthPicker.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Employee Details"
        '
        'AddGenderLabel
        '
        Me.AddGenderLabel.AutoSize = True
        Me.AddGenderLabel.Location = New System.Drawing.Point(93, 159)
        Me.AddGenderLabel.Name = "AddGenderLabel"
        Me.AddGenderLabel.Size = New System.Drawing.Size(42, 13)
        Me.AddGenderLabel.TabIndex = 32
        Me.AddGenderLabel.Text = "Gender"
        '
        'AddDobLabel
        '
        Me.AddDobLabel.AutoSize = True
        Me.AddDobLabel.Location = New System.Drawing.Point(71, 135)
        Me.AddDobLabel.Name = "AddDobLabel"
        Me.AddDobLabel.Size = New System.Drawing.Size(66, 13)
        Me.AddDobLabel.TabIndex = 31
        Me.AddDobLabel.Text = "Date of Birth"
        '
        'AddMiddleNameLabel
        '
        Me.AddMiddleNameLabel.AutoSize = True
        Me.AddMiddleNameLabel.Location = New System.Drawing.Point(69, 103)
        Me.AddMiddleNameLabel.Name = "AddMiddleNameLabel"
        Me.AddMiddleNameLabel.Size = New System.Drawing.Size(69, 13)
        Me.AddMiddleNameLabel.TabIndex = 30
        Me.AddMiddleNameLabel.Text = "Middle Name"
        '
        'AddFirstNameLabel
        '
        Me.AddFirstNameLabel.AutoSize = True
        Me.AddFirstNameLabel.Location = New System.Drawing.Point(83, 74)
        Me.AddFirstNameLabel.Name = "AddFirstNameLabel"
        Me.AddFirstNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.AddFirstNameLabel.TabIndex = 29
        Me.AddFirstNameLabel.Text = "First Name"
        '
        'AddLastNameLabel
        '
        Me.AddLastNameLabel.AutoSize = True
        Me.AddLastNameLabel.Location = New System.Drawing.Point(77, 46)
        Me.AddLastNameLabel.Name = "AddLastNameLabel"
        Me.AddLastNameLabel.Size = New System.Drawing.Size(58, 13)
        Me.AddLastNameLabel.TabIndex = 28
        Me.AddLastNameLabel.Text = "Last Name"
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 333)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ContactTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MiddleNameTextBox)
        Me.Controls.Add(Me.ClearFieldsButton)
        Me.Controls.Add(Me.CancelAddButton)
        Me.Controls.Add(Me.AddEmployeeButton)
        Me.Controls.Add(Me.GenderBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.DateOfBirthPicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AddGenderLabel)
        Me.Controls.Add(Me.AddDobLabel)
        Me.Controls.Add(Me.AddMiddleNameLabel)
        Me.Controls.Add(Me.AddFirstNameLabel)
        Me.Controls.Add(Me.AddLastNameLabel)
        Me.Name = "AddEmployee"
        Me.Text = "AddEmployee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ContactTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MiddleNameTextBox As TextBox
    Friend WithEvents ClearFieldsButton As Button
    Friend WithEvents CancelAddButton As Button
    Friend WithEvents AddEmployeeButton As Button
    Friend WithEvents GenderBox As ComboBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents DateOfBirthPicker As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents AddGenderLabel As Label
    Friend WithEvents AddDobLabel As Label
    Friend WithEvents AddMiddleNameLabel As Label
    Friend WithEvents AddFirstNameLabel As Label
    Friend WithEvents AddLastNameLabel As Label
End Class
