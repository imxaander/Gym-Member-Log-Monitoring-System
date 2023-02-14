<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddEmployee
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
        Me.ExitButton = New System.Windows.Forms.Label()
        Me.AddEmployeePanel = New System.Windows.Forms.Panel()
        Me.AddEmployeeTopPanel = New System.Windows.Forms.Panel()
        Me.AddEmployeePanel.SuspendLayout()
        Me.AddEmployeeTopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.AddressTextBox.ForeColor = System.Drawing.Color.Black
        Me.AddressTextBox.Location = New System.Drawing.Point(400, 115)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(197, 24)
        Me.AddressTextBox.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(397, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Address"
        '
        'ContactTextBox
        '
        Me.ContactTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ContactTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ContactTextBox.ForeColor = System.Drawing.Color.Black
        Me.ContactTextBox.Location = New System.Drawing.Point(260, 115)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(133, 24)
        Me.ContactTextBox.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(257, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Contact No"
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.MiddleNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiddleNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MiddleNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(489, 49)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(108, 24)
        Me.MiddleNameTextBox.TabIndex = 46
        '
        'ClearFieldsButton
        '
        Me.ClearFieldsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClearFieldsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearFieldsButton.FlatAppearance.BorderSize = 0
        Me.ClearFieldsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearFieldsButton.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.ClearFieldsButton.ForeColor = System.Drawing.Color.White
        Me.ClearFieldsButton.Location = New System.Drawing.Point(167, 173)
        Me.ClearFieldsButton.Name = "ClearFieldsButton"
        Me.ClearFieldsButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearFieldsButton.TabIndex = 45
        Me.ClearFieldsButton.Text = "CLEAR"
        Me.ClearFieldsButton.UseVisualStyleBackColor = False
        '
        'CancelAddButton
        '
        Me.CancelAddButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CancelAddButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelAddButton.FlatAppearance.BorderSize = 0
        Me.CancelAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelAddButton.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.CancelAddButton.ForeColor = System.Drawing.Color.White
        Me.CancelAddButton.Location = New System.Drawing.Point(350, 173)
        Me.CancelAddButton.Name = "CancelAddButton"
        Me.CancelAddButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelAddButton.TabIndex = 44
        Me.CancelAddButton.Text = "CANCEL"
        Me.CancelAddButton.UseVisualStyleBackColor = False
        '
        'AddEmployeeButton
        '
        Me.AddEmployeeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.AddEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddEmployeeButton.FlatAppearance.BorderSize = 0
        Me.AddEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddEmployeeButton.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.AddEmployeeButton.ForeColor = System.Drawing.Color.White
        Me.AddEmployeeButton.Location = New System.Drawing.Point(260, 173)
        Me.AddEmployeeButton.Name = "AddEmployeeButton"
        Me.AddEmployeeButton.Size = New System.Drawing.Size(75, 23)
        Me.AddEmployeeButton.TabIndex = 43
        Me.AddEmployeeButton.Text = "CONFIRM"
        Me.AddEmployeeButton.UseVisualStyleBackColor = False
        '
        'GenderBox
        '
        Me.GenderBox.BackColor = System.Drawing.Color.White
        Me.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GenderBox.ForeColor = System.Drawing.Color.Black
        Me.GenderBox.FormattingEnabled = True
        Me.GenderBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderBox.Location = New System.Drawing.Point(129, 117)
        Me.GenderBox.Name = "GenderBox"
        Me.GenderBox.Size = New System.Drawing.Size(113, 21)
        Me.GenderBox.TabIndex = 40
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.FirstNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.FirstNameTextBox.Location = New System.Drawing.Point(260, 49)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(214, 24)
        Me.FirstNameTextBox.TabIndex = 39
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LastNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.LastNameTextBox.Location = New System.Drawing.Point(28, 49)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(214, 24)
        Me.LastNameTextBox.TabIndex = 38
        '
        'DateOfBirthPicker
        '
        Me.DateOfBirthPicker.CustomFormat = "yyy-MM-dd"
        Me.DateOfBirthPicker.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.DateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfBirthPicker.Location = New System.Drawing.Point(28, 117)
        Me.DateOfBirthPicker.Name = "DateOfBirthPicker"
        Me.DateOfBirthPicker.Size = New System.Drawing.Size(95, 22)
        Me.DateOfBirthPicker.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 24)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Add Employee"
        '
        'AddGenderLabel
        '
        Me.AddGenderLabel.AutoSize = True
        Me.AddGenderLabel.BackColor = System.Drawing.Color.Transparent
        Me.AddGenderLabel.Font = New System.Drawing.Font("Gadugi", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.AddGenderLabel.ForeColor = System.Drawing.Color.Black
        Me.AddGenderLabel.Location = New System.Drawing.Point(129, 101)
        Me.AddGenderLabel.Name = "AddGenderLabel"
        Me.AddGenderLabel.Size = New System.Drawing.Size(39, 13)
        Me.AddGenderLabel.TabIndex = 32
        Me.AddGenderLabel.Text = "Gender"
        '
        'AddDobLabel
        '
        Me.AddDobLabel.AutoSize = True
        Me.AddDobLabel.BackColor = System.Drawing.Color.Transparent
        Me.AddDobLabel.Font = New System.Drawing.Font("Gadugi", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.AddDobLabel.ForeColor = System.Drawing.Color.Black
        Me.AddDobLabel.Location = New System.Drawing.Point(25, 101)
        Me.AddDobLabel.Name = "AddDobLabel"
        Me.AddDobLabel.Size = New System.Drawing.Size(62, 13)
        Me.AddDobLabel.TabIndex = 31
        Me.AddDobLabel.Text = "Date of Birth"
        '
        'AddMiddleNameLabel
        '
        Me.AddMiddleNameLabel.AutoSize = True
        Me.AddMiddleNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.AddMiddleNameLabel.Font = New System.Drawing.Font("Gadugi", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.AddMiddleNameLabel.ForeColor = System.Drawing.Color.Black
        Me.AddMiddleNameLabel.Location = New System.Drawing.Point(486, 32)
        Me.AddMiddleNameLabel.Name = "AddMiddleNameLabel"
        Me.AddMiddleNameLabel.Size = New System.Drawing.Size(66, 13)
        Me.AddMiddleNameLabel.TabIndex = 30
        Me.AddMiddleNameLabel.Text = "Middle Name"
        '
        'AddFirstNameLabel
        '
        Me.AddFirstNameLabel.AutoSize = True
        Me.AddFirstNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.AddFirstNameLabel.Font = New System.Drawing.Font("Gadugi", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.AddFirstNameLabel.ForeColor = System.Drawing.Color.Black
        Me.AddFirstNameLabel.Location = New System.Drawing.Point(257, 32)
        Me.AddFirstNameLabel.Name = "AddFirstNameLabel"
        Me.AddFirstNameLabel.Size = New System.Drawing.Size(53, 13)
        Me.AddFirstNameLabel.TabIndex = 29
        Me.AddFirstNameLabel.Text = "First Name"
        '
        'AddLastNameLabel
        '
        Me.AddLastNameLabel.AutoSize = True
        Me.AddLastNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.AddLastNameLabel.Font = New System.Drawing.Font("Gadugi", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.AddLastNameLabel.ForeColor = System.Drawing.Color.Black
        Me.AddLastNameLabel.Location = New System.Drawing.Point(25, 30)
        Me.AddLastNameLabel.Name = "AddLastNameLabel"
        Me.AddLastNameLabel.Size = New System.Drawing.Size(53, 13)
        Me.AddLastNameLabel.TabIndex = 28
        Me.AddLastNameLabel.Text = "Last Name"
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.Font = New System.Drawing.Font("Gadugi", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.Location = New System.Drawing.Point(593, 0)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(24, 24)
        Me.ExitButton.TabIndex = 51
        Me.ExitButton.Text = "×"
        '
        'AddEmployeePanel
        '
        Me.AddEmployeePanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddEmployeePanel.BackColor = System.Drawing.Color.White
        Me.AddEmployeePanel.Controls.Add(Me.LastNameTextBox)
        Me.AddEmployeePanel.Controls.Add(Me.AddLastNameLabel)
        Me.AddEmployeePanel.Controls.Add(Me.AddressTextBox)
        Me.AddEmployeePanel.Controls.Add(Me.AddFirstNameLabel)
        Me.AddEmployeePanel.Controls.Add(Me.Label4)
        Me.AddEmployeePanel.Controls.Add(Me.AddMiddleNameLabel)
        Me.AddEmployeePanel.Controls.Add(Me.ContactTextBox)
        Me.AddEmployeePanel.Controls.Add(Me.AddDobLabel)
        Me.AddEmployeePanel.Controls.Add(Me.Label3)
        Me.AddEmployeePanel.Controls.Add(Me.AddGenderLabel)
        Me.AddEmployeePanel.Controls.Add(Me.MiddleNameTextBox)
        Me.AddEmployeePanel.Controls.Add(Me.DateOfBirthPicker)
        Me.AddEmployeePanel.Controls.Add(Me.ClearFieldsButton)
        Me.AddEmployeePanel.Controls.Add(Me.FirstNameTextBox)
        Me.AddEmployeePanel.Controls.Add(Me.CancelAddButton)
        Me.AddEmployeePanel.Controls.Add(Me.GenderBox)
        Me.AddEmployeePanel.Controls.Add(Me.AddEmployeeButton)
        Me.AddEmployeePanel.Location = New System.Drawing.Point(1, 32)
        Me.AddEmployeePanel.Name = "AddEmployeePanel"
        Me.AddEmployeePanel.Size = New System.Drawing.Size(627, 215)
        Me.AddEmployeePanel.TabIndex = 52
        '
        'AddEmployeeTopPanel
        '
        Me.AddEmployeeTopPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddEmployeeTopPanel.Controls.Add(Me.Label2)
        Me.AddEmployeeTopPanel.Location = New System.Drawing.Point(12, 5)
        Me.AddEmployeeTopPanel.Name = "AddEmployeeTopPanel"
        Me.AddEmployeeTopPanel.Size = New System.Drawing.Size(578, 24)
        Me.AddEmployeeTopPanel.TabIndex = 53
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(629, 249)
        Me.Controls.Add(Me.AddEmployeeTopPanel)
        Me.Controls.Add(Me.AddEmployeePanel)
        Me.Controls.Add(Me.ExitButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddEmployee"
        Me.Text = "     "
        Me.AddEmployeePanel.ResumeLayout(False)
        Me.AddEmployeePanel.PerformLayout()
        Me.AddEmployeeTopPanel.ResumeLayout(False)
        Me.AddEmployeeTopPanel.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents ExitButton As Label
    Friend WithEvents AddEmployeePanel As Panel
    Friend WithEvents AddEmployeeTopPanel As Panel
End Class
