<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LoginTitleLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsernameLoginLabel = New System.Windows.Forms.Label()
        Me.PasswordLoginLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.ExitLoginButton = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginTitleLabel
        '
        Me.LoginTitleLabel.AutoSize = True
        Me.LoginTitleLabel.Location = New System.Drawing.Point(144, 31)
        Me.LoginTitleLabel.Name = "LoginTitleLabel"
        Me.LoginTitleLabel.Size = New System.Drawing.Size(100, 13)
        Me.LoginTitleLabel.TabIndex = 0
        Me.LoginTitleLabel.Text = "Manny Paksiw Gym"
        Me.LoginTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Member Log Monitoring System"
        '
        'UsernameLoginLabel
        '
        Me.UsernameLoginLabel.AutoSize = True
        Me.UsernameLoginLabel.Location = New System.Drawing.Point(144, 99)
        Me.UsernameLoginLabel.Name = "UsernameLoginLabel"
        Me.UsernameLoginLabel.Size = New System.Drawing.Size(58, 13)
        Me.UsernameLoginLabel.TabIndex = 2
        Me.UsernameLoginLabel.Text = "Username:"
        '
        'PasswordLoginLabel
        '
        Me.PasswordLoginLabel.AutoSize = True
        Me.PasswordLoginLabel.Location = New System.Drawing.Point(144, 126)
        Me.PasswordLoginLabel.Name = "PasswordLoginLabel"
        Me.PasswordLoginLabel.Size = New System.Drawing.Size(56, 13)
        Me.PasswordLoginLabel.TabIndex = 3
        Me.PasswordLoginLabel.Text = "Password:"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(209, 96)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 4
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(209, 123)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 5
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(147, 163)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(75, 23)
        Me.LoginButton.TabIndex = 6
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'ExitLoginButton
        '
        Me.ExitLoginButton.Location = New System.Drawing.Point(233, 163)
        Me.ExitLoginButton.Name = "ExitLoginButton"
        Me.ExitLoginButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitLoginButton.TabIndex = 7
        Me.ExitLoginButton.Text = "Exit"
        Me.ExitLoginButton.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 194)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExitLoginButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLoginLabel)
        Me.Controls.Add(Me.UsernameLoginLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LoginTitleLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginTitleLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameLoginLabel As Label
    Friend WithEvents PasswordLoginLabel As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents ExitLoginButton As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
End Class
