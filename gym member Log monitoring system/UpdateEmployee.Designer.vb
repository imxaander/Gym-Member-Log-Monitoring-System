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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Label()
        Me.MemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.UpdateButton.FlatAppearance.BorderSize = 0
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateButton.ForeColor = System.Drawing.Color.White
        Me.UpdateButton.Location = New System.Drawing.Point(223, 243)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(70, 23)
        Me.UpdateButton.TabIndex = 58
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.DeleteButton.FlatAppearance.BorderSize = 0
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.Location = New System.Drawing.Point(139, 243)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(70, 23)
        Me.DeleteButton.TabIndex = 57
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ContactNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ContactNoTextBox.ForeColor = System.Drawing.Color.White
        Me.ContactNoTextBox.Location = New System.Drawing.Point(314, 163)
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.Size = New System.Drawing.Size(95, 13)
        Me.ContactNoTextBox.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(242, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Contact No :"
        '
        'AddressEditTextBox
        '
        Me.AddressEditTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.AddressEditTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AddressEditTextBox.ForeColor = System.Drawing.Color.White
        Me.AddressEditTextBox.Location = New System.Drawing.Point(109, 189)
        Me.AddressEditTextBox.Name = "AddressEditTextBox"
        Me.AddressEditTextBox.Size = New System.Drawing.Size(300, 13)
        Me.AddressEditTextBox.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(53, 188)
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
        Me.GenderEditTextBox.Location = New System.Drawing.Point(314, 134)
        Me.GenderEditTextBox.Name = "GenderEditTextBox"
        Me.GenderEditTextBox.Size = New System.Drawing.Size(95, 21)
        Me.GenderEditTextBox.TabIndex = 52
        '
        'AddGenderLabel
        '
        Me.AddGenderLabel.AutoSize = True
        Me.AddGenderLabel.ForeColor = System.Drawing.Color.White
        Me.AddGenderLabel.Location = New System.Drawing.Point(261, 137)
        Me.AddGenderLabel.Name = "AddGenderLabel"
        Me.AddGenderLabel.Size = New System.Drawing.Size(48, 13)
        Me.AddGenderLabel.TabIndex = 51
        Me.AddGenderLabel.Text = "Gender :"
        '
        'DateOfBirthPicker
        '
        Me.DateOfBirthPicker.CustomFormat = "yyy-MM-dd"
        Me.DateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfBirthPicker.Location = New System.Drawing.Point(314, 108)
        Me.DateOfBirthPicker.Name = "DateOfBirthPicker"
        Me.DateOfBirthPicker.Size = New System.Drawing.Size(95, 20)
        Me.DateOfBirthPicker.TabIndex = 50
        '
        'DobEditLabel
        '
        Me.DobEditLabel.AutoSize = True
        Me.DobEditLabel.ForeColor = System.Drawing.Color.White
        Me.DobEditLabel.Location = New System.Drawing.Point(236, 111)
        Me.DobEditLabel.Name = "DobEditLabel"
        Me.DobEditLabel.Size = New System.Drawing.Size(72, 13)
        Me.DobEditLabel.TabIndex = 49
        Me.DobEditLabel.Text = "Date of Birth :"
        '
        'MiddleNameEditTextBox
        '
        Me.MiddleNameEditTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.MiddleNameEditTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MiddleNameEditTextBox.ForeColor = System.Drawing.Color.White
        Me.MiddleNameEditTextBox.Location = New System.Drawing.Point(109, 163)
        Me.MiddleNameEditTextBox.Name = "MiddleNameEditTextBox"
        Me.MiddleNameEditTextBox.Size = New System.Drawing.Size(100, 13)
        Me.MiddleNameEditTextBox.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Middle Name :"
        '
        'FirstNameEditTextBox
        '
        Me.FirstNameEditTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.FirstNameEditTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FirstNameEditTextBox.ForeColor = System.Drawing.Color.White
        Me.FirstNameEditTextBox.Location = New System.Drawing.Point(109, 137)
        Me.FirstNameEditTextBox.Name = "FirstNameEditTextBox"
        Me.FirstNameEditTextBox.Size = New System.Drawing.Size(100, 13)
        Me.FirstNameEditTextBox.TabIndex = 46
        '
        'FirstNameEditLabel
        '
        Me.FirstNameEditLabel.AutoSize = True
        Me.FirstNameEditLabel.ForeColor = System.Drawing.Color.White
        Me.FirstNameEditLabel.Location = New System.Drawing.Point(41, 139)
        Me.FirstNameEditLabel.Name = "FirstNameEditLabel"
        Me.FirstNameEditLabel.Size = New System.Drawing.Size(63, 13)
        Me.FirstNameEditLabel.TabIndex = 45
        Me.FirstNameEditLabel.Text = "First Name :"
        '
        'LastNameEditTextBox
        '
        Me.LastNameEditTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.LastNameEditTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LastNameEditTextBox.ForeColor = System.Drawing.Color.White
        Me.LastNameEditTextBox.Location = New System.Drawing.Point(109, 111)
        Me.LastNameEditTextBox.Name = "LastNameEditTextBox"
        Me.LastNameEditTextBox.Size = New System.Drawing.Size(100, 13)
        Me.LastNameEditTextBox.TabIndex = 44
        '
        'LastNameEditLabel
        '
        Me.LastNameEditLabel.AutoSize = True
        Me.LastNameEditLabel.ForeColor = System.Drawing.Color.White
        Me.LastNameEditLabel.Location = New System.Drawing.Point(41, 113)
        Me.LastNameEditLabel.Name = "LastNameEditLabel"
        Me.LastNameEditLabel.Size = New System.Drawing.Size(64, 13)
        Me.LastNameEditLabel.TabIndex = 43
        Me.LastNameEditLabel.Text = "Last Name :"
        '
        'MemberIdShowLabel
        '
        Me.MemberIdShowLabel.AutoSize = True
        Me.MemberIdShowLabel.ForeColor = System.Drawing.Color.White
        Me.MemberIdShowLabel.Location = New System.Drawing.Point(109, 83)
        Me.MemberIdShowLabel.Name = "MemberIdShowLabel"
        Me.MemberIdShowLabel.Size = New System.Drawing.Size(66, 13)
        Me.MemberIdShowLabel.TabIndex = 42
        Me.MemberIdShowLabel.Text = "employee_id"
        '
        'MemberIdEditLabel
        '
        Me.MemberIdEditLabel.AutoSize = True
        Me.MemberIdEditLabel.ForeColor = System.Drawing.Color.White
        Me.MemberIdEditLabel.Location = New System.Drawing.Point(37, 82)
        Me.MemberIdEditLabel.Name = "MemberIdEditLabel"
        Me.MemberIdEditLabel.Size = New System.Drawing.Size(71, 13)
        Me.MemberIdEditLabel.TabIndex = 41
        Me.MemberIdEditLabel.Text = "Employee Id :"
        '
        'MemberIdLabel
        '
        Me.MemberIdLabel.AutoSize = True
        Me.MemberIdLabel.ForeColor = System.Drawing.Color.White
        Me.MemberIdLabel.Location = New System.Drawing.Point(37, 49)
        Me.MemberIdLabel.Name = "MemberIdLabel"
        Me.MemberIdLabel.Size = New System.Drawing.Size(68, 13)
        Me.MemberIdLabel.TabIndex = 40
        Me.MemberIdLabel.Text = "Employee Id:"
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.EditButton.FlatAppearance.BorderSize = 0
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.ForeColor = System.Drawing.Color.White
        Me.EditButton.Location = New System.Drawing.Point(334, 45)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 39
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'EditIdTextBox
        '
        Me.EditIdTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.EditIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EditIdTextBox.ForeColor = System.Drawing.Color.White
        Me.EditIdTextBox.Location = New System.Drawing.Point(109, 47)
        Me.EditIdTextBox.Name = "EditIdTextBox"
        Me.EditIdTextBox.Size = New System.Drawing.Size(219, 13)
        Me.EditIdTextBox.TabIndex = 38
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateEmployeeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(438, 24)
        Me.MenuStrip1.TabIndex = 59
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(110, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(219, 2)
        Me.Label6.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(109, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 2)
        Me.Label4.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(109, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 2)
        Me.Label5.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(110, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 2)
        Me.Label7.TabIndex = 63
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(109, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 2)
        Me.Label8.TabIndex = 64
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(106, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(300, 2)
        Me.Label9.TabIndex = 65
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(313, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 2)
        Me.Label10.TabIndex = 66
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.Location = New System.Drawing.Point(414, 0)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(24, 24)
        Me.ExitButton.TabIndex = 67
        Me.ExitButton.Text = "×"
        '
        'MemberToolStripMenuItem
        '
        Me.MemberToolStripMenuItem.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MemberToolStripMenuItem.Name = "MemberToolStripMenuItem"
        Me.MemberToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.MemberToolStripMenuItem.Text = "Update Employee"
        '
        'UpdateEmployeeToolStripMenuItem
        '
        Me.UpdateEmployeeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UpdateEmployeeToolStripMenuItem.Name = "UpdateEmployeeToolStripMenuItem"
        Me.UpdateEmployeeToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.UpdateEmployeeToolStripMenuItem.Text = "Update Employee"
        '
        'UpdateEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(438, 271)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MenuStrip1)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UpdateEmployee"
        Me.Text = "UpdateEmployee"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ExitButton As Label
    Friend WithEvents UpdateEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MemberToolStripMenuItem As ToolStripMenuItem
End Class
