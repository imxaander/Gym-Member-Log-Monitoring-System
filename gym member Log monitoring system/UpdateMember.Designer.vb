<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateMember
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
        Me.ExitButton = New System.Windows.Forms.Label()
        Me.UpdateMemberPanel = New System.Windows.Forms.Panel()
        Me.UpdateMemberTopPanel = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ContactNoTextBox1 = New System.Windows.Forms.TextBox()
        Me.ContactNoTextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.ImageEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UpdateMemberPanel.SuspendLayout()
        Me.UpdateMemberTopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.EditButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditButton.FlatAppearance.BorderSize = 0
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.ForeColor = System.Drawing.Color.White
        Me.EditButton.Location = New System.Drawing.Point(181, 33)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 9
        Me.EditButton.Text = "EDIT"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'EditIdTextBox
        '
        Me.EditIdTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.EditIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EditIdTextBox.ForeColor = System.Drawing.Color.Black
        Me.EditIdTextBox.Location = New System.Drawing.Point(28, 33)
        Me.EditIdTextBox.Name = "EditIdTextBox"
        Me.EditIdTextBox.Size = New System.Drawing.Size(147, 20)
        Me.EditIdTextBox.TabIndex = 8
        '
        'MemberIdLabel
        '
        Me.MemberIdLabel.AutoSize = True
        Me.MemberIdLabel.BackColor = System.Drawing.Color.Transparent
        Me.MemberIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MemberIdLabel.ForeColor = System.Drawing.Color.Black
        Me.MemberIdLabel.Location = New System.Drawing.Point(25, 16)
        Me.MemberIdLabel.Name = "MemberIdLabel"
        Me.MemberIdLabel.Size = New System.Drawing.Size(63, 13)
        Me.MemberIdLabel.TabIndex = 12
        Me.MemberIdLabel.Text = "Member Id :"
        '
        'MemberIdEditLabel
        '
        Me.MemberIdEditLabel.AutoSize = True
        Me.MemberIdEditLabel.BackColor = System.Drawing.Color.Transparent
        Me.MemberIdEditLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MemberIdEditLabel.ForeColor = System.Drawing.Color.Black
        Me.MemberIdEditLabel.Location = New System.Drawing.Point(278, 33)
        Me.MemberIdEditLabel.Name = "MemberIdEditLabel"
        Me.MemberIdEditLabel.Size = New System.Drawing.Size(63, 13)
        Me.MemberIdEditLabel.TabIndex = 13
        Me.MemberIdEditLabel.Text = "Member Id :"
        '
        'MemberIdShowLabel
        '
        Me.MemberIdShowLabel.AutoSize = True
        Me.MemberIdShowLabel.ForeColor = System.Drawing.Color.Red
        Me.MemberIdShowLabel.Location = New System.Drawing.Point(278, 50)
        Me.MemberIdShowLabel.Name = "MemberIdShowLabel"
        Me.MemberIdShowLabel.Size = New System.Drawing.Size(58, 13)
        Me.MemberIdShowLabel.TabIndex = 14
        Me.MemberIdShowLabel.Text = "member_id"
        '
        'LastNameEditLabel
        '
        Me.LastNameEditLabel.AutoSize = True
        Me.LastNameEditLabel.BackColor = System.Drawing.Color.Transparent
        Me.LastNameEditLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LastNameEditLabel.ForeColor = System.Drawing.Color.Black
        Me.LastNameEditLabel.Location = New System.Drawing.Point(149, 192)
        Me.LastNameEditLabel.Name = "LastNameEditLabel"
        Me.LastNameEditLabel.Size = New System.Drawing.Size(63, 13)
        Me.LastNameEditLabel.TabIndex = 15
        Me.LastNameEditLabel.Text = "Last Name :"
        '
        'LastNameEditTextBox
        '
        Me.LastNameEditTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.LastNameEditTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LastNameEditTextBox.ForeColor = System.Drawing.Color.Black
        Me.LastNameEditTextBox.Location = New System.Drawing.Point(152, 208)
        Me.LastNameEditTextBox.Name = "LastNameEditTextBox"
        Me.LastNameEditTextBox.Size = New System.Drawing.Size(142, 20)
        Me.LastNameEditTextBox.TabIndex = 16
        '
        'FirstNameEditTextBox
        '
        Me.FirstNameEditTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.FirstNameEditTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FirstNameEditTextBox.ForeColor = System.Drawing.Color.Black
        Me.FirstNameEditTextBox.Location = New System.Drawing.Point(28, 208)
        Me.FirstNameEditTextBox.Name = "FirstNameEditTextBox"
        Me.FirstNameEditTextBox.Size = New System.Drawing.Size(115, 20)
        Me.FirstNameEditTextBox.TabIndex = 18
        '
        'FirstNameEditLabel
        '
        Me.FirstNameEditLabel.AutoSize = True
        Me.FirstNameEditLabel.BackColor = System.Drawing.Color.Transparent
        Me.FirstNameEditLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.FirstNameEditLabel.ForeColor = System.Drawing.Color.Black
        Me.FirstNameEditLabel.Location = New System.Drawing.Point(25, 192)
        Me.FirstNameEditLabel.Name = "FirstNameEditLabel"
        Me.FirstNameEditLabel.Size = New System.Drawing.Size(62, 13)
        Me.FirstNameEditLabel.TabIndex = 17
        Me.FirstNameEditLabel.Text = "First Name :"
        '
        'MiddleNameEditTextBox
        '
        Me.MiddleNameEditTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.MiddleNameEditTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiddleNameEditTextBox.ForeColor = System.Drawing.Color.Black
        Me.MiddleNameEditTextBox.Location = New System.Drawing.Point(302, 208)
        Me.MiddleNameEditTextBox.Name = "MiddleNameEditTextBox"
        Me.MiddleNameEditTextBox.Size = New System.Drawing.Size(104, 20)
        Me.MiddleNameEditTextBox.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(299, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Middle Name :"
        '
        'DobEditLabel
        '
        Me.DobEditLabel.AutoSize = True
        Me.DobEditLabel.BackColor = System.Drawing.Color.Transparent
        Me.DobEditLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DobEditLabel.ForeColor = System.Drawing.Color.Black
        Me.DobEditLabel.Location = New System.Drawing.Point(203, 240)
        Me.DobEditLabel.Name = "DobEditLabel"
        Me.DobEditLabel.Size = New System.Drawing.Size(72, 13)
        Me.DobEditLabel.TabIndex = 21
        Me.DobEditLabel.Text = "Date of Birth :"
        '
        'DateOfBirthPicker
        '
        Me.DateOfBirthPicker.CustomFormat = "yyy-MM-dd"
        Me.DateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfBirthPicker.Location = New System.Drawing.Point(206, 256)
        Me.DateOfBirthPicker.Name = "DateOfBirthPicker"
        Me.DateOfBirthPicker.Size = New System.Drawing.Size(95, 20)
        Me.DateOfBirthPicker.TabIndex = 22
        '
        'GenderEditTextBox
        '
        Me.GenderEditTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderEditTextBox.FormattingEnabled = True
        Me.GenderEditTextBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderEditTextBox.Location = New System.Drawing.Point(307, 256)
        Me.GenderEditTextBox.Name = "GenderEditTextBox"
        Me.GenderEditTextBox.Size = New System.Drawing.Size(95, 21)
        Me.GenderEditTextBox.TabIndex = 24
        '
        'AddGenderLabel
        '
        Me.AddGenderLabel.AutoSize = True
        Me.AddGenderLabel.BackColor = System.Drawing.Color.Transparent
        Me.AddGenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.AddGenderLabel.ForeColor = System.Drawing.Color.Black
        Me.AddGenderLabel.Location = New System.Drawing.Point(307, 240)
        Me.AddGenderLabel.Name = "AddGenderLabel"
        Me.AddGenderLabel.Size = New System.Drawing.Size(48, 13)
        Me.AddGenderLabel.TabIndex = 23
        Me.AddGenderLabel.Text = "Gender :"
        '
        'AddressEditTextBox
        '
        Me.AddressEditTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.AddressEditTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddressEditTextBox.ForeColor = System.Drawing.Color.Black
        Me.AddressEditTextBox.Location = New System.Drawing.Point(28, 256)
        Me.AddressEditTextBox.Name = "AddressEditTextBox"
        Me.AddressEditTextBox.Size = New System.Drawing.Size(169, 20)
        Me.AddressEditTextBox.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Address :"
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ContactNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactNoTextBox.ForeColor = System.Drawing.Color.Black
        Me.ContactNoTextBox.Location = New System.Drawing.Point(28, 299)
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.Size = New System.Drawing.Size(95, 20)
        Me.ContactNoTextBox.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Contact No :"
        '
        'MemberTableAdapter1
        '
        Me.MemberTableAdapter1.ClearBeforeFill = True
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteButton.FlatAppearance.BorderSize = 0
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.Location = New System.Drawing.Point(253, 89)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(70, 23)
        Me.DeleteButton.TabIndex = 30
        Me.DeleteButton.Text = "DELETE"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateButton.FlatAppearance.BorderSize = 0
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateButton.ForeColor = System.Drawing.Color.White
        Me.UpdateButton.Location = New System.Drawing.Point(332, 89)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(70, 23)
        Me.UpdateButton.TabIndex = 31
        Me.UpdateButton.Text = "UPDATE"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(258, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Membership Ends :"
        '
        'DateLeftLabel
        '
        Me.DateLeftLabel.AutoSize = True
        Me.DateLeftLabel.ForeColor = System.Drawing.Color.Red
        Me.DateLeftLabel.Location = New System.Drawing.Point(258, 345)
        Me.DateLeftLabel.Name = "DateLeftLabel"
        Me.DateLeftLabel.Size = New System.Drawing.Size(56, 13)
        Me.DateLeftLabel.TabIndex = 33
        Me.DateLeftLabel.Text = "Dates Left"
        '
        'EndDatePicker
        '
        Me.EndDatePicker.CustomFormat = "yyyy-MM-dd"
        Me.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDatePicker.Location = New System.Drawing.Point(152, 338)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.Size = New System.Drawing.Size(95, 20)
        Me.EndDatePicker.TabIndex = 37
        '
        'StartDatePicker
        '
        Me.StartDatePicker.CustomFormat = "yyyy-MM-dd"
        Me.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDatePicker.Location = New System.Drawing.Point(25, 338)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.Size = New System.Drawing.Size(95, 20)
        Me.StartDatePicker.TabIndex = 36
        '
        'AddEndDateLabel
        '
        Me.AddEndDateLabel.AutoSize = True
        Me.AddEndDateLabel.BackColor = System.Drawing.Color.Transparent
        Me.AddEndDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.AddEndDateLabel.ForeColor = System.Drawing.Color.Black
        Me.AddEndDateLabel.Location = New System.Drawing.Point(149, 322)
        Me.AddEndDateLabel.Name = "AddEndDateLabel"
        Me.AddEndDateLabel.Size = New System.Drawing.Size(26, 13)
        Me.AddEndDateLabel.TabIndex = 35
        Me.AddEndDateLabel.Text = "End"
        '
        'AddDateStartLabel
        '
        Me.AddDateStartLabel.AutoSize = True
        Me.AddDateStartLabel.BackColor = System.Drawing.Color.Transparent
        Me.AddDateStartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.AddDateStartLabel.ForeColor = System.Drawing.Color.Black
        Me.AddDateStartLabel.Location = New System.Drawing.Point(25, 322)
        Me.AddDateStartLabel.Name = "AddDateStartLabel"
        Me.AddDateStartLabel.Size = New System.Drawing.Size(29, 13)
        Me.AddDateStartLabel.TabIndex = 34
        Me.AddDateStartLabel.Text = "Start"
        '
        'ImageEditBox
        '
        Me.ImageEditBox.Location = New System.Drawing.Point(28, 89)
        Me.ImageEditBox.Name = "ImageEditBox"
        Me.ImageEditBox.Size = New System.Drawing.Size(219, 100)
        Me.ImageEditBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageEditBox.TabIndex = 29
        Me.ImageEditBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.Font = New System.Drawing.Font("Gadugi", 18.75!, System.Drawing.FontStyle.Bold)
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.Location = New System.Drawing.Point(400, -2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(24, 24)
        Me.ExitButton.TabIndex = 68
        Me.ExitButton.Text = "×"
        '
        'UpdateMemberPanel
        '
        Me.UpdateMemberPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateMemberPanel.BackColor = System.Drawing.Color.White
        Me.UpdateMemberPanel.Controls.Add(Me.ContactNoTextBox2)
        Me.UpdateMemberPanel.Controls.Add(Me.ContactNoTextBox1)
        Me.UpdateMemberPanel.Controls.Add(Me.EditIdTextBox)
        Me.UpdateMemberPanel.Controls.Add(Me.EditButton)
        Me.UpdateMemberPanel.Controls.Add(Me.EndDatePicker)
        Me.UpdateMemberPanel.Controls.Add(Me.MemberIdLabel)
        Me.UpdateMemberPanel.Controls.Add(Me.StartDatePicker)
        Me.UpdateMemberPanel.Controls.Add(Me.MemberIdEditLabel)
        Me.UpdateMemberPanel.Controls.Add(Me.AddEndDateLabel)
        Me.UpdateMemberPanel.Controls.Add(Me.MemberIdShowLabel)
        Me.UpdateMemberPanel.Controls.Add(Me.AddDateStartLabel)
        Me.UpdateMemberPanel.Controls.Add(Me.LastNameEditLabel)
        Me.UpdateMemberPanel.Controls.Add(Me.DateLeftLabel)
        Me.UpdateMemberPanel.Controls.Add(Me.LastNameEditTextBox)
        Me.UpdateMemberPanel.Controls.Add(Me.Label4)
        Me.UpdateMemberPanel.Controls.Add(Me.FirstNameEditLabel)
        Me.UpdateMemberPanel.Controls.Add(Me.UpdateButton)
        Me.UpdateMemberPanel.Controls.Add(Me.FirstNameEditTextBox)
        Me.UpdateMemberPanel.Controls.Add(Me.DeleteButton)
        Me.UpdateMemberPanel.Controls.Add(Me.Label1)
        Me.UpdateMemberPanel.Controls.Add(Me.ImageEditBox)
        Me.UpdateMemberPanel.Controls.Add(Me.MiddleNameEditTextBox)
        Me.UpdateMemberPanel.Controls.Add(Me.ContactNoTextBox)
        Me.UpdateMemberPanel.Controls.Add(Me.DobEditLabel)
        Me.UpdateMemberPanel.Controls.Add(Me.Label3)
        Me.UpdateMemberPanel.Controls.Add(Me.DateOfBirthPicker)
        Me.UpdateMemberPanel.Controls.Add(Me.AddressEditTextBox)
        Me.UpdateMemberPanel.Controls.Add(Me.AddGenderLabel)
        Me.UpdateMemberPanel.Controls.Add(Me.Label2)
        Me.UpdateMemberPanel.Controls.Add(Me.GenderEditTextBox)
        Me.UpdateMemberPanel.Location = New System.Drawing.Point(1, 30)
        Me.UpdateMemberPanel.Name = "UpdateMemberPanel"
        Me.UpdateMemberPanel.Size = New System.Drawing.Size(433, 368)
        Me.UpdateMemberPanel.TabIndex = 69
        '
        'UpdateMemberTopPanel
        '
        Me.UpdateMemberTopPanel.Controls.Add(Me.Label5)
        Me.UpdateMemberTopPanel.Location = New System.Drawing.Point(39, 1)
        Me.UpdateMemberTopPanel.Name = "UpdateMemberTopPanel"
        Me.UpdateMemberTopPanel.Size = New System.Drawing.Size(355, 23)
        Me.UpdateMemberTopPanel.TabIndex = 70
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
        Me.Label5.Size = New System.Drawing.Size(165, 25)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Update Member"
        '
        'ContactNoTextBox1
        '
        Me.ContactNoTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ContactNoTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactNoTextBox1.ForeColor = System.Drawing.Color.Black
        Me.ContactNoTextBox1.Location = New System.Drawing.Point(129, 299)
        Me.ContactNoTextBox1.Name = "ContactNoTextBox1"
        Me.ContactNoTextBox1.Size = New System.Drawing.Size(95, 20)
        Me.ContactNoTextBox1.TabIndex = 38
        '
        'ContactNoTextBox2
        '
        Me.ContactNoTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ContactNoTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactNoTextBox2.ForeColor = System.Drawing.Color.Black
        Me.ContactNoTextBox2.Location = New System.Drawing.Point(230, 299)
        Me.ContactNoTextBox2.Name = "ContactNoTextBox2"
        Me.ContactNoTextBox2.Size = New System.Drawing.Size(95, 20)
        Me.ContactNoTextBox2.TabIndex = 39
        '
        'UpdateMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(435, 400)
        Me.Controls.Add(Me.UpdateMemberTopPanel)
        Me.Controls.Add(Me.UpdateMemberPanel)
        Me.Controls.Add(Me.ExitButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UpdateMember"
        Me.Text = "Update Member"
        CType(Me.ImageEditBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UpdateMemberPanel.ResumeLayout(False)
        Me.UpdateMemberPanel.PerformLayout()
        Me.UpdateMemberTopPanel.ResumeLayout(False)
        Me.UpdateMemberTopPanel.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents ExitButton As Label
    Friend WithEvents UpdateMemberPanel As Panel
    Friend WithEvents UpdateMemberTopPanel As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents ContactNoTextBox2 As TextBox
    Friend WithEvents ContactNoTextBox1 As TextBox
End Class
