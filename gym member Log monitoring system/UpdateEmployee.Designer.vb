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
        Me.ExitButton = New System.Windows.Forms.Label()
        Me.MemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateMemberTopPanel = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UpdateMemberTopPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateButton.FlatAppearance.BorderSize = 0
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateButton.ForeColor = System.Drawing.Color.White
        Me.UpdateButton.Location = New System.Drawing.Point(320, 192)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(70, 23)
        Me.UpdateButton.TabIndex = 58
        Me.UpdateButton.Text = "UPDATE"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteButton.FlatAppearance.BorderSize = 0
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.Location = New System.Drawing.Point(244, 192)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(70, 23)
        Me.DeleteButton.TabIndex = 57
        Me.DeleteButton.Text = "DELETE"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ContactNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactNoTextBox.ForeColor = System.Drawing.Color.Black
        Me.ContactNoTextBox.Location = New System.Drawing.Point(29, 195)
        Me.ContactNoTextBox.MaxLength = 11
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.Size = New System.Drawing.Size(95, 20)
        Me.ContactNoTextBox.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(26, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Contact No :"
        '
        'AddressEditTextBox
        '
        Me.AddressEditTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.AddressEditTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddressEditTextBox.ForeColor = System.Drawing.Color.Black
        Me.AddressEditTextBox.Location = New System.Drawing.Point(28, 147)
        Me.AddressEditTextBox.Name = "AddressEditTextBox"
        Me.AddressEditTextBox.Size = New System.Drawing.Size(147, 20)
        Me.AddressEditTextBox.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 127)
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
        Me.GenderEditTextBox.Location = New System.Drawing.Point(295, 146)
        Me.GenderEditTextBox.Name = "GenderEditTextBox"
        Me.GenderEditTextBox.Size = New System.Drawing.Size(95, 21)
        Me.GenderEditTextBox.TabIndex = 52
        '
        'AddGenderLabel
        '
        Me.AddGenderLabel.AutoSize = True
        Me.AddGenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.AddGenderLabel.ForeColor = System.Drawing.Color.Black
        Me.AddGenderLabel.Location = New System.Drawing.Point(292, 127)
        Me.AddGenderLabel.Name = "AddGenderLabel"
        Me.AddGenderLabel.Size = New System.Drawing.Size(48, 13)
        Me.AddGenderLabel.TabIndex = 51
        Me.AddGenderLabel.Text = "Gender :"
        '
        'DateOfBirthPicker
        '
        Me.DateOfBirthPicker.CustomFormat = "yyy-MM-dd"
        Me.DateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfBirthPicker.Location = New System.Drawing.Point(184, 147)
        Me.DateOfBirthPicker.Name = "DateOfBirthPicker"
        Me.DateOfBirthPicker.Size = New System.Drawing.Size(95, 20)
        Me.DateOfBirthPicker.TabIndex = 50
        '
        'DobEditLabel
        '
        Me.DobEditLabel.AutoSize = True
        Me.DobEditLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DobEditLabel.ForeColor = System.Drawing.Color.Black
        Me.DobEditLabel.Location = New System.Drawing.Point(181, 127)
        Me.DobEditLabel.Name = "DobEditLabel"
        Me.DobEditLabel.Size = New System.Drawing.Size(72, 13)
        Me.DobEditLabel.TabIndex = 49
        Me.DobEditLabel.Text = "Date of Birth :"
        '
        'MiddleNameEditTextBox
        '
        Me.MiddleNameEditTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.MiddleNameEditTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiddleNameEditTextBox.ForeColor = System.Drawing.Color.Black
        Me.MiddleNameEditTextBox.Location = New System.Drawing.Point(295, 94)
        Me.MiddleNameEditTextBox.Name = "MiddleNameEditTextBox"
        Me.MiddleNameEditTextBox.Size = New System.Drawing.Size(95, 20)
        Me.MiddleNameEditTextBox.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(292, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Middle Name :"
        '
        'FirstNameEditTextBox
        '
        Me.FirstNameEditTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.FirstNameEditTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FirstNameEditTextBox.ForeColor = System.Drawing.Color.Black
        Me.FirstNameEditTextBox.Location = New System.Drawing.Point(184, 94)
        Me.FirstNameEditTextBox.Name = "FirstNameEditTextBox"
        Me.FirstNameEditTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameEditTextBox.TabIndex = 46
        '
        'FirstNameEditLabel
        '
        Me.FirstNameEditLabel.AutoSize = True
        Me.FirstNameEditLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.FirstNameEditLabel.ForeColor = System.Drawing.Color.Black
        Me.FirstNameEditLabel.Location = New System.Drawing.Point(181, 78)
        Me.FirstNameEditLabel.Name = "FirstNameEditLabel"
        Me.FirstNameEditLabel.Size = New System.Drawing.Size(62, 13)
        Me.FirstNameEditLabel.TabIndex = 45
        Me.FirstNameEditLabel.Text = "First Name :"
        '
        'LastNameEditTextBox
        '
        Me.LastNameEditTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.LastNameEditTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LastNameEditTextBox.ForeColor = System.Drawing.Color.Black
        Me.LastNameEditTextBox.Location = New System.Drawing.Point(28, 94)
        Me.LastNameEditTextBox.Name = "LastNameEditTextBox"
        Me.LastNameEditTextBox.Size = New System.Drawing.Size(147, 20)
        Me.LastNameEditTextBox.TabIndex = 44
        '
        'LastNameEditLabel
        '
        Me.LastNameEditLabel.AutoSize = True
        Me.LastNameEditLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LastNameEditLabel.ForeColor = System.Drawing.Color.Black
        Me.LastNameEditLabel.Location = New System.Drawing.Point(25, 78)
        Me.LastNameEditLabel.Name = "LastNameEditLabel"
        Me.LastNameEditLabel.Size = New System.Drawing.Size(63, 13)
        Me.LastNameEditLabel.TabIndex = 43
        Me.LastNameEditLabel.Text = "Last Name :"
        '
        'MemberIdShowLabel
        '
        Me.MemberIdShowLabel.AutoSize = True
        Me.MemberIdShowLabel.ForeColor = System.Drawing.Color.White
        Me.MemberIdShowLabel.Location = New System.Drawing.Point(265, 42)
        Me.MemberIdShowLabel.Name = "MemberIdShowLabel"
        Me.MemberIdShowLabel.Size = New System.Drawing.Size(66, 13)
        Me.MemberIdShowLabel.TabIndex = 42
        Me.MemberIdShowLabel.Text = "employee_id"
        '
        'MemberIdEditLabel
        '
        Me.MemberIdEditLabel.AutoSize = True
        Me.MemberIdEditLabel.ForeColor = System.Drawing.Color.White
        Me.MemberIdEditLabel.Location = New System.Drawing.Point(265, 21)
        Me.MemberIdEditLabel.Name = "MemberIdEditLabel"
        Me.MemberIdEditLabel.Size = New System.Drawing.Size(71, 13)
        Me.MemberIdEditLabel.TabIndex = 41
        Me.MemberIdEditLabel.Text = "Employee Id :"
        '
        'MemberIdLabel
        '
        Me.MemberIdLabel.AutoSize = True
        Me.MemberIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MemberIdLabel.ForeColor = System.Drawing.Color.Black
        Me.MemberIdLabel.Location = New System.Drawing.Point(25, 21)
        Me.MemberIdLabel.Name = "MemberIdLabel"
        Me.MemberIdLabel.Size = New System.Drawing.Size(68, 13)
        Me.MemberIdLabel.TabIndex = 40
        Me.MemberIdLabel.Text = "Employee Id:"
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.EditButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditButton.FlatAppearance.BorderSize = 0
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.ForeColor = System.Drawing.Color.White
        Me.EditButton.Location = New System.Drawing.Point(184, 37)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 39
        Me.EditButton.Text = "EDIT"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'EditIdTextBox
        '
        Me.EditIdTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.EditIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EditIdTextBox.ForeColor = System.Drawing.Color.Black
        Me.EditIdTextBox.Location = New System.Drawing.Point(28, 37)
        Me.EditIdTextBox.Name = "EditIdTextBox"
        Me.EditIdTextBox.Size = New System.Drawing.Size(147, 20)
        Me.EditIdTextBox.TabIndex = 38
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.Font = New System.Drawing.Font("Gadugi", 18.75!, System.Drawing.FontStyle.Bold)
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.Location = New System.Drawing.Point(416, -3)
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
        'UpdateMemberTopPanel
        '
        Me.UpdateMemberTopPanel.Controls.Add(Me.Label5)
        Me.UpdateMemberTopPanel.Location = New System.Drawing.Point(32, 0)
        Me.UpdateMemberTopPanel.Name = "UpdateMemberTopPanel"
        Me.UpdateMemberTopPanel.Size = New System.Drawing.Size(355, 23)
        Me.UpdateMemberTopPanel.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(-5, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 25)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Update Employee"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.MemberIdLabel)
        Me.Panel1.Controls.Add(Me.EditIdTextBox)
        Me.Panel1.Controls.Add(Me.EditButton)
        Me.Panel1.Controls.Add(Me.UpdateButton)
        Me.Panel1.Controls.Add(Me.MemberIdEditLabel)
        Me.Panel1.Controls.Add(Me.DeleteButton)
        Me.Panel1.Controls.Add(Me.MemberIdShowLabel)
        Me.Panel1.Controls.Add(Me.ContactNoTextBox)
        Me.Panel1.Controls.Add(Me.LastNameEditLabel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LastNameEditTextBox)
        Me.Panel1.Controls.Add(Me.AddressEditTextBox)
        Me.Panel1.Controls.Add(Me.FirstNameEditLabel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.FirstNameEditTextBox)
        Me.Panel1.Controls.Add(Me.GenderEditTextBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.AddGenderLabel)
        Me.Panel1.Controls.Add(Me.MiddleNameEditTextBox)
        Me.Panel1.Controls.Add(Me.DateOfBirthPicker)
        Me.Panel1.Controls.Add(Me.DobEditLabel)
        Me.Panel1.Location = New System.Drawing.Point(1, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 233)
        Me.Panel1.TabIndex = 72
        '
        'UpdateEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(452, 263)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UpdateMemberTopPanel)
        Me.Controls.Add(Me.ExitButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UpdateEmployee"
        Me.Text = "UpdateEmployee"
        Me.UpdateMemberTopPanel.ResumeLayout(False)
        Me.UpdateMemberTopPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents ExitButton As Label
    Friend WithEvents MemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateMemberTopPanel As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
End Class
