<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateEmployee
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
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ContactNoTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddressEditTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GenderEditTextBox = New System.Windows.Forms.ComboBox()
        Me.AddGenderLabel = New System.Windows.Forms.Label()
        Me.DateOfBirthPicker = New System.Windows.Forms.DateTimePicker()
        Me.DobEditLabel = New System.Windows.Forms.Label()
        Me.MiddleNameEditTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FirstNameEditTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameEditLabel = New System.Windows.Forms.Label()
        Me.LastNameEditTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameEditLabel = New System.Windows.Forms.Label()
        Me.MemberIdShowLabel = New System.Windows.Forms.Label()
        Me.MemberIdEditLabel = New System.Windows.Forms.Label()
        Me.MemberIdLabel = New System.Windows.Forms.Label()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.EditIdTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(206, 208)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(70, 23)
        Me.UpdateButton.TabIndex = 58
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(122, 208)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(70, 23)
        Me.DeleteButton.TabIndex = 57
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.ForeColor = System.Drawing.Color.Red
        Me.ContactNoTextBox.Location = New System.Drawing.Point(297, 128)
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.Size = New System.Drawing.Size(95, 20)
        Me.ContactNoTextBox.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Contact No :"
        '
        'AddressEditTextBox
        '
        Me.AddressEditTextBox.ForeColor = System.Drawing.Color.Red
        Me.AddressEditTextBox.Location = New System.Drawing.Point(92, 154)
        Me.AddressEditTextBox.Name = "AddressEditTextBox"
        Me.AddressEditTextBox.Size = New System.Drawing.Size(300, 20)
        Me.AddressEditTextBox.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Address :"
        '
        'GenderEditTextBox
        '
        Me.GenderEditTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderEditTextBox.FormattingEnabled = True
        Me.GenderEditTextBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderEditTextBox.Location = New System.Drawing.Point(297, 99)
        Me.GenderEditTextBox.Name = "GenderEditTextBox"
        Me.GenderEditTextBox.Size = New System.Drawing.Size(95, 21)
        Me.GenderEditTextBox.TabIndex = 52
        '
        'AddGenderLabel
        '
        Me.AddGenderLabel.AutoSize = True
        Me.AddGenderLabel.Location = New System.Drawing.Point(244, 102)
        Me.AddGenderLabel.Name = "AddGenderLabel"
        Me.AddGenderLabel.Size = New System.Drawing.Size(48, 13)
        Me.AddGenderLabel.TabIndex = 51
        Me.AddGenderLabel.Text = "Gender :"
        '
        'DateOfBirthPicker
        '
        Me.DateOfBirthPicker.CustomFormat = "yyy-MM-dd"
        Me.DateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfBirthPicker.Location = New System.Drawing.Point(297, 73)
        Me.DateOfBirthPicker.Name = "DateOfBirthPicker"
        Me.DateOfBirthPicker.Size = New System.Drawing.Size(95, 20)
        Me.DateOfBirthPicker.TabIndex = 50
        '
        'DobEditLabel
        '
        Me.DobEditLabel.AutoSize = True
        Me.DobEditLabel.Location = New System.Drawing.Point(219, 76)
        Me.DobEditLabel.Name = "DobEditLabel"
        Me.DobEditLabel.Size = New System.Drawing.Size(72, 13)
        Me.DobEditLabel.TabIndex = 49
        Me.DobEditLabel.Text = "Date of Birth :"
        '
        'MiddleNameEditTextBox
        '
        Me.MiddleNameEditTextBox.ForeColor = System.Drawing.Color.Red
        Me.MiddleNameEditTextBox.Location = New System.Drawing.Point(92, 128)
        Me.MiddleNameEditTextBox.Name = "MiddleNameEditTextBox"
        Me.MiddleNameEditTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MiddleNameEditTextBox.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Middle Name :"
        '
        'FirstNameEditTextBox
        '
        Me.FirstNameEditTextBox.ForeColor = System.Drawing.Color.Red
        Me.FirstNameEditTextBox.Location = New System.Drawing.Point(92, 102)
        Me.FirstNameEditTextBox.Name = "FirstNameEditTextBox"
        Me.FirstNameEditTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameEditTextBox.TabIndex = 46
        '
        'FirstNameEditLabel
        '
        Me.FirstNameEditLabel.AutoSize = True
        Me.FirstNameEditLabel.Location = New System.Drawing.Point(26, 105)
        Me.FirstNameEditLabel.Name = "FirstNameEditLabel"
        Me.FirstNameEditLabel.Size = New System.Drawing.Size(63, 13)
        Me.FirstNameEditLabel.TabIndex = 45
        Me.FirstNameEditLabel.Text = "First Name :"
        '
        'LastNameEditTextBox
        '
        Me.LastNameEditTextBox.ForeColor = System.Drawing.Color.Red
        Me.LastNameEditTextBox.Location = New System.Drawing.Point(92, 76)
        Me.LastNameEditTextBox.Name = "LastNameEditTextBox"
        Me.LastNameEditTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameEditTextBox.TabIndex = 44
        '
        'LastNameEditLabel
        '
        Me.LastNameEditLabel.AutoSize = True
        Me.LastNameEditLabel.Location = New System.Drawing.Point(26, 79)
        Me.LastNameEditLabel.Name = "LastNameEditLabel"
        Me.LastNameEditLabel.Size = New System.Drawing.Size(64, 13)
        Me.LastNameEditLabel.TabIndex = 43
        Me.LastNameEditLabel.Text = "Last Name :"
        '
        'MemberIdShowLabel
        '
        Me.MemberIdShowLabel.AutoSize = True
        Me.MemberIdShowLabel.ForeColor = System.Drawing.Color.Red
        Me.MemberIdShowLabel.Location = New System.Drawing.Point(92, 48)
        Me.MemberIdShowLabel.Name = "MemberIdShowLabel"
        Me.MemberIdShowLabel.Size = New System.Drawing.Size(66, 13)
        Me.MemberIdShowLabel.TabIndex = 42
        Me.MemberIdShowLabel.Text = "employee_id"
        '
        'MemberIdEditLabel
        '
        Me.MemberIdEditLabel.AutoSize = True
        Me.MemberIdEditLabel.Location = New System.Drawing.Point(22, 48)
        Me.MemberIdEditLabel.Name = "MemberIdEditLabel"
        Me.MemberIdEditLabel.Size = New System.Drawing.Size(71, 13)
        Me.MemberIdEditLabel.TabIndex = 41
        Me.MemberIdEditLabel.Text = "Employee Id :"
        '
        'MemberIdLabel
        '
        Me.MemberIdLabel.AutoSize = True
        Me.MemberIdLabel.Location = New System.Drawing.Point(22, 15)
        Me.MemberIdLabel.Name = "MemberIdLabel"
        Me.MemberIdLabel.Size = New System.Drawing.Size(68, 13)
        Me.MemberIdLabel.TabIndex = 40
        Me.MemberIdLabel.Text = "Employee Id:"
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(317, 10)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 39
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'EditIdTextBox
        '
        Me.EditIdTextBox.Location = New System.Drawing.Point(92, 12)
        Me.EditIdTextBox.Name = "EditIdTextBox"
        Me.EditIdTextBox.Size = New System.Drawing.Size(219, 20)
        Me.EditIdTextBox.TabIndex = 38
        '
        'UpdateEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 248)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.ContactNoTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AddressEditTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GenderEditTextBox)
        Me.Controls.Add(Me.AddGenderLabel)
        Me.Controls.Add(Me.DateOfBirthPicker)
        Me.Controls.Add(Me.DobEditLabel)
        Me.Controls.Add(Me.MiddleNameEditTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FirstNameEditTextBox)
        Me.Controls.Add(Me.FirstNameEditLabel)
        Me.Controls.Add(Me.LastNameEditTextBox)
        Me.Controls.Add(Me.LastNameEditLabel)
        Me.Controls.Add(Me.MemberIdShowLabel)
        Me.Controls.Add(Me.MemberIdEditLabel)
        Me.Controls.Add(Me.MemberIdLabel)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.EditIdTextBox)
        Me.Name = "UpdateEmployee"
        Me.Text = "UpdateEmployee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents ContactNoTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AddressEditTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GenderEditTextBox As ComboBox
    Friend WithEvents AddGenderLabel As Label
    Friend WithEvents DateOfBirthPicker As DateTimePicker
    Friend WithEvents DobEditLabel As Label
    Friend WithEvents MiddleNameEditTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FirstNameEditTextBox As TextBox
    Friend WithEvents FirstNameEditLabel As Label
    Friend WithEvents LastNameEditTextBox As TextBox
    Friend WithEvents LastNameEditLabel As Label
    Friend WithEvents MemberIdShowLabel As Label
    Friend WithEvents MemberIdEditLabel As Label
    Friend WithEvents MemberIdLabel As Label
    Friend WithEvents EditButton As Button
    Friend WithEvents EditIdTextBox As TextBox
End Class
