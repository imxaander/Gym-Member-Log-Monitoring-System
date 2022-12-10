<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PasswordLoginLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.UsernameLoginLabel = New System.Windows.Forms.Label()
        Me.ExitLoginButton = New System.Windows.Forms.Button()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'PasswordLoginLabel
        '
        Me.PasswordLoginLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PasswordLoginLabel.AutoSize = True
        Me.PasswordLoginLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLoginLabel.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLoginLabel.ForeColor = System.Drawing.Color.White
        Me.PasswordLoginLabel.Location = New System.Drawing.Point(94, 112)
        Me.PasswordLoginLabel.Name = "PasswordLoginLabel"
        Me.PasswordLoginLabel.Size = New System.Drawing.Size(67, 14)
        Me.PasswordLoginLabel.TabIndex = 3
        Me.PasswordLoginLabel.Text = "PASSWORD"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.White
        Me.PasswordTextBox.Location = New System.Drawing.Point(57, 139)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(146, 13)
        Me.PasswordTextBox.TabIndex = 5
        Me.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'LoginButton
        '
        Me.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LoginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.LoginButton.FlatAppearance.BorderSize = 0
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginButton.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.Location = New System.Drawing.Point(85, 181)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(90, 23)
        Me.LoginButton.TabIndex = 6
        Me.LoginButton.Text = "LOGIN"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'UsernameLoginLabel
        '
        Me.UsernameLoginLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsernameLoginLabel.AutoSize = True
        Me.UsernameLoginLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLoginLabel.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLoginLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLoginLabel.Location = New System.Drawing.Point(96, 41)
        Me.UsernameLoginLabel.Name = "UsernameLoginLabel"
        Me.UsernameLoginLabel.Size = New System.Drawing.Size(65, 14)
        Me.UsernameLoginLabel.TabIndex = 2
        Me.UsernameLoginLabel.Text = "USERNAME"
        '
        'ExitLoginButton
        '
        Me.ExitLoginButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ExitLoginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ExitLoginButton.FlatAppearance.BorderSize = 0
        Me.ExitLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitLoginButton.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitLoginButton.ForeColor = System.Drawing.Color.White
        Me.ExitLoginButton.Location = New System.Drawing.Point(85, 210)
        Me.ExitLoginButton.Name = "ExitLoginButton"
        Me.ExitLoginButton.Size = New System.Drawing.Size(90, 23)
        Me.ExitLoginButton.TabIndex = 7
        Me.ExitLoginButton.Text = "EXIT"
        Me.ExitLoginButton.UseVisualStyleBackColor = False
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsernameTextBox.ForeColor = System.Drawing.Color.White
        Me.UsernameTextBox.Location = New System.Drawing.Point(57, 69)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(146, 13)
        Me.UsernameTextBox.TabIndex = 4
        Me.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.UsernameLoginLabel)
        Me.Panel1.Controls.Add(Me.UsernameTextBox)
        Me.Panel1.Controls.Add(Me.ExitLoginButton)
        Me.Panel1.Controls.Add(Me.PasswordLoginLabel)
        Me.Panel1.Controls.Add(Me.LoginButton)
        Me.Panel1.Controls.Add(Me.PasswordTextBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(258, 278)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(58, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 2)
        Me.Label1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(58, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 2)
        Me.Label2.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.gym_member_Log_monitoring_system.My.Resources.Resources.manipaksiw_logo_nobg
        Me.PictureBox1.Location = New System.Drawing.Point(12, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(283, 425)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PasswordLoginLabel As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents UsernameLoginLabel As Label
    Friend WithEvents ExitLoginButton As Button
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
