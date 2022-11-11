<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateMember
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
        Me.EditButton = New System.Windows.Forms.Button()
        Me.EditIdTextBox = New System.Windows.Forms.TextBox()
        Me.MemberIdLabel = New System.Windows.Forms.Label()
        Me.MemberIdEditLabel = New System.Windows.Forms.Label()
        Me.MemberIdShowLabel = New System.Windows.Forms.Label()
        Me.LastNameEditLabel = New System.Windows.Forms.Label()
        Me.LastNameEditTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameEditTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameEditLabel = New System.Windows.Forms.Label()
        Me.MiddleNameEditTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DobEditLabel = New System.Windows.Forms.Label()
        Me.DateOfBirthPicker = New System.Windows.Forms.DateTimePicker()
        Me.GenderEditTextBox = New System.Windows.Forms.ComboBox()
        Me.AddGenderLabel = New System.Windows.Forms.Label()
        Me.AddressEditTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContactNoTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MemberTableAdapter1 = New gym_member_Log_monitoring_system.GymManagementDataSetTableAdapters.MemberTableAdapter()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateLeftLabel = New System.Windows.Forms.Label()
        Me.EndDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.AddEndDateLabel = New System.Windows.Forms.Label()
        Me.AddDateStartLabel = New System.Windows.Forms.Label()
        Me.ImageEditBox = New System.Windows.Forms.PictureBox()
        CType(Me.ImageEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(311, 215)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 9
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'EditIdTextBox
        '
        Me.EditIdTextBox.Location = New System.Drawing.Point(86, 217)
        Me.EditIdTextBox.Name = "EditIdTextBox"
        Me.EditIdTextBox.Size = New System.Drawing.Size(219, 20)
        Me.EditIdTextBox.TabIndex = 8
        '
        'MemberIdLabel
        '
        Me.MemberIdLabel.AutoSize = True
        Me.MemberIdLabel.Location = New System.Drawing.Point(21, 220)
        Me.MemberIdLabel.Name = "MemberIdLabel"
        Me.MemberIdLabel.Size = New System.Drawing.Size(63, 13)
        Me.MemberIdLabel.TabIndex = 12
        Me.MemberIdLabel.Text = "Member Id :"
        '
        'MemberIdEditLabel
        '
        Me.MemberIdEditLabel.AutoSize = True
        Me.MemberIdEditLabel.Location = New System.Drawing.Point(20, 253)
        Me.MemberIdEditLabel.Name = "MemberIdEditLabel"
        Me.MemberIdEditLabel.Size = New System.Drawing.Size(63, 13)
        Me.MemberIdEditLabel.TabIndex = 13
        Me.MemberIdEditLabel.Text = "Member Id :"
        '
        'MemberIdShowLabel
        '
        Me.MemberIdShowLabel.AutoSize = True
        Me.MemberIdShowLabel.ForeColor = System.Drawing.Color.Red
        Me.MemberIdShowLabel.Location = New System.Drawing.Point(86, 253)
        Me.MemberIdShowLabel.Name = "MemberIdShowLabel"
        Me.MemberIdShowLabel.Size = New System.Drawing.Size(58, 13)
        Me.MemberIdShowLabel.TabIndex = 14
        Me.MemberIdShowLabel.Text = "member_id"
        '
        'LastNameEditLabel
        '
        Me.LastNameEditLabel.AutoSize = True
        Me.LastNameEditLabel.Location = New System.Drawing.Point(20, 284)
        Me.LastNameEditLabel.Name = "LastNameEditLabel"
        Me.LastNameEditLabel.Size = New System.Drawing.Size(64, 13)
        Me.LastNameEditLabel.TabIndex = 15
        Me.LastNameEditLabel.Text = "Last Name :"
        '
        'LastNameEditTextBox
        '
        Me.LastNameEditTextBox.ForeColor = System.Drawing.Color.Red
        Me.LastNameEditTextBox.Location = New System.Drawing.Point(86, 281)
        Me.LastNameEditTextBox.Name = "LastNameEditTextBox"
        Me.LastNameEditTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameEditTextBox.TabIndex = 16
        '
        'FirstNameEditTextBox
        '
        Me.FirstNameEditTextBox.ForeColor = System.Drawing.Color.Red
        Me.FirstNameEditTextBox.Location = New System.Drawing.Point(86, 307)
        Me.FirstNameEditTextBox.Name = "FirstNameEditTextBox"
        Me.FirstNameEditTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameEditTextBox.TabIndex = 18
        '
        'FirstNameEditLabel
        '
        Me.FirstNameEditLabel.AutoSize = True
        Me.FirstNameEditLabel.Location = New System.Drawing.Point(20, 310)
        Me.FirstNameEditLabel.Name = "FirstNameEditLabel"
        Me.FirstNameEditLabel.Size = New System.Drawing.Size(63, 13)
        Me.FirstNameEditLabel.TabIndex = 17
        Me.FirstNameEditLabel.Text = "First Name :"
        '
        'MiddleNameEditTextBox
        '
        Me.MiddleNameEditTextBox.ForeColor = System.Drawing.Color.Red
        Me.MiddleNameEditTextBox.Location = New System.Drawing.Point(86, 333)
        Me.MiddleNameEditTextBox.Name = "MiddleNameEditTextBox"
        Me.MiddleNameEditTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MiddleNameEditTextBox.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Middle Name :"
        '
        'DobEditLabel
        '
        Me.DobEditLabel.AutoSize = True
        Me.DobEditLabel.Location = New System.Drawing.Point(213, 281)
        Me.DobEditLabel.Name = "DobEditLabel"
        Me.DobEditLabel.Size = New System.Drawing.Size(72, 13)
        Me.DobEditLabel.TabIndex = 21
        Me.DobEditLabel.Text = "Date of Birth :"
        '
        'DateOfBirthPicker
        '
        Me.DateOfBirthPicker.CustomFormat = "yyy-MM-dd"
        Me.DateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfBirthPicker.Location = New System.Drawing.Point(291, 278)
        Me.DateOfBirthPicker.Name = "DateOfBirthPicker"
        Me.DateOfBirthPicker.Size = New System.Drawing.Size(95, 20)
        Me.DateOfBirthPicker.TabIndex = 22
        '
        'GenderEditTextBox
        '
        Me.GenderEditTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderEditTextBox.FormattingEnabled = True
        Me.GenderEditTextBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderEditTextBox.Location = New System.Drawing.Point(291, 304)
        Me.GenderEditTextBox.Name = "GenderEditTextBox"
        Me.GenderEditTextBox.Size = New System.Drawing.Size(95, 21)
        Me.GenderEditTextBox.TabIndex = 24
        '
        'AddGenderLabel
        '
        Me.AddGenderLabel.AutoSize = True
        Me.AddGenderLabel.Location = New System.Drawing.Point(238, 307)
        Me.AddGenderLabel.Name = "AddGenderLabel"
        Me.AddGenderLabel.Size = New System.Drawing.Size(48, 13)
        Me.AddGenderLabel.TabIndex = 23
        Me.AddGenderLabel.Text = "Gender :"
        '
        'AddressEditTextBox
        '
        Me.AddressEditTextBox.ForeColor = System.Drawing.Color.Red
        Me.AddressEditTextBox.Location = New System.Drawing.Point(86, 359)
        Me.AddressEditTextBox.Name = "AddressEditTextBox"
        Me.AddressEditTextBox.Size = New System.Drawing.Size(300, 20)
        Me.AddressEditTextBox.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 359)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Address :"
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.ForeColor = System.Drawing.Color.Red
        Me.ContactNoTextBox.Location = New System.Drawing.Point(291, 333)
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.Size = New System.Drawing.Size(95, 20)
        Me.ContactNoTextBox.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Contact No :"
        '
        'MemberTableAdapter1
        '
        Me.MemberTableAdapter1.ClearBeforeFill = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(122, 489)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(70, 23)
        Me.DeleteButton.TabIndex = 30
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(206, 489)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(70, 23)
        Me.UpdateButton.TabIndex = 31
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Membership Ends :"
        '
        'DateLeftLabel
        '
        Me.DateLeftLabel.AutoSize = True
        Me.DateLeftLabel.ForeColor = System.Drawing.Color.Red
        Me.DateLeftLabel.Location = New System.Drawing.Point(220, 449)
        Me.DateLeftLabel.Name = "DateLeftLabel"
        Me.DateLeftLabel.Size = New System.Drawing.Size(56, 13)
        Me.DateLeftLabel.TabIndex = 33
        Me.DateLeftLabel.Text = "Dates Left"
        '
        'EndDatePicker
        '
        Me.EndDatePicker.CustomFormat = "yyyy-MM-dd"
        Me.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDatePicker.Location = New System.Drawing.Point(257, 399)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.Size = New System.Drawing.Size(95, 20)
        Me.EndDatePicker.TabIndex = 37
        '
        'StartDatePicker
        '
        Me.StartDatePicker.CustomFormat = "yyyy-MM-dd"
        Me.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDatePicker.Location = New System.Drawing.Point(82, 399)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.Size = New System.Drawing.Size(95, 20)
        Me.StartDatePicker.TabIndex = 36
        '
        'AddEndDateLabel
        '
        Me.AddEndDateLabel.AutoSize = True
        Me.AddEndDateLabel.Location = New System.Drawing.Point(220, 405)
        Me.AddEndDateLabel.Name = "AddEndDateLabel"
        Me.AddEndDateLabel.Size = New System.Drawing.Size(26, 13)
        Me.AddEndDateLabel.TabIndex = 35
        Me.AddEndDateLabel.Text = "End"
        '
        'AddDateStartLabel
        '
        Me.AddDateStartLabel.AutoSize = True
        Me.AddDateStartLabel.Location = New System.Drawing.Point(44, 405)
        Me.AddDateStartLabel.Name = "AddDateStartLabel"
        Me.AddDateStartLabel.Size = New System.Drawing.Size(29, 13)
        Me.AddDateStartLabel.TabIndex = 34
        Me.AddDateStartLabel.Text = "Start"
        '
        'ImageEditBox
        '
        Me.ImageEditBox.Location = New System.Drawing.Point(12, 12)
        Me.ImageEditBox.Name = "ImageEditBox"
        Me.ImageEditBox.Size = New System.Drawing.Size(374, 175)
        Me.ImageEditBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageEditBox.TabIndex = 29
        Me.ImageEditBox.TabStop = False
        '
        'UpdateMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 522)
        Me.Controls.Add(Me.EndDatePicker)
        Me.Controls.Add(Me.StartDatePicker)
        Me.Controls.Add(Me.AddEndDateLabel)
        Me.Controls.Add(Me.AddDateStartLabel)
        Me.Controls.Add(Me.DateLeftLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.ImageEditBox)
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
        Me.Name = "UpdateMember"
        Me.Text = "Update Member"
        CType(Me.ImageEditBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EditButton As Button
    Friend WithEvents EditIdTextBox As TextBox
    Friend WithEvents MemberIdLabel As Label
    Friend WithEvents MemberIdEditLabel As Label
    Friend WithEvents MemberIdShowLabel As Label
    Friend WithEvents LastNameEditLabel As Label
    Friend WithEvents LastNameEditTextBox As TextBox
    Friend WithEvents FirstNameEditTextBox As TextBox
    Friend WithEvents FirstNameEditLabel As Label
    Friend WithEvents MiddleNameEditTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DobEditLabel As Label
    Friend WithEvents DateOfBirthPicker As DateTimePicker
    Friend WithEvents GenderEditTextBox As ComboBox
    Friend WithEvents AddGenderLabel As Label
    Friend WithEvents AddressEditTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ContactNoTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ImageEditBox As PictureBox
    Friend WithEvents MemberTableAdapter1 As GymManagementDataSetTableAdapters.MemberTableAdapter
    Friend WithEvents DeleteButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DateLeftLabel As Label
    Friend WithEvents EndDatePicker As DateTimePicker
    Friend WithEvents StartDatePicker As DateTimePicker
    Friend WithEvents AddEndDateLabel As Label
    Friend WithEvents AddDateStartLabel As Label
End Class
