<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Login = New System.Windows.Forms.TabPage()
        Me.Daftar = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.mail = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.User = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Pass = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Login.SuspendLayout()
        Me.Daftar.SuspendLayout()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.Navy
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button1.Font = New System.Drawing.Font("Rockwell", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.Transparent
        Me.button1.Location = New System.Drawing.Point(670, 441)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(463, 50)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Login"
        Me.button1.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Login)
        Me.TabControl1.Controls.Add(Me.Daftar)
        Me.TabControl1.Font = New System.Drawing.Font("Rockwell", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(1, -3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1890, 869)
        Me.TabControl1.TabIndex = 3
        '
        'Login
        '
        Me.Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Login.BackgroundImage = CType(resources.GetObject("Login.BackgroundImage"), System.Drawing.Image)
        Me.Login.Controls.Add(Me.TextBox2)
        Me.Login.Controls.Add(Me.Label2)
        Me.Login.Controls.Add(Me.Label1)
        Me.Login.Controls.Add(Me.TextBox1)
        Me.Login.Controls.Add(Me.button1)
        Me.Login.Location = New System.Drawing.Point(4, 37)
        Me.Login.Name = "Login"
        Me.Login.Padding = New System.Windows.Forms.Padding(3)
        Me.Login.Size = New System.Drawing.Size(1882, 828)
        Me.Login.TabIndex = 0
        Me.Login.Text = "Masuk"
        '
        'Daftar
        '
        Me.Daftar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Daftar.BackgroundImage = CType(resources.GetObject("Daftar.BackgroundImage"), System.Drawing.Image)
        Me.Daftar.Controls.Add(Me.Button2)
        Me.Daftar.Controls.Add(Me.password)
        Me.Daftar.Controls.Add(Me.Pass)
        Me.Daftar.Controls.Add(Me.username)
        Me.Daftar.Controls.Add(Me.User)
        Me.Daftar.Controls.Add(Me.email)
        Me.Daftar.Controls.Add(Me.mail)
        Me.Daftar.Location = New System.Drawing.Point(4, 37)
        Me.Daftar.Name = "Daftar"
        Me.Daftar.Padding = New System.Windows.Forms.Padding(3)
        Me.Daftar.Size = New System.Drawing.Size(1882, 828)
        Me.Daftar.TabIndex = 1
        Me.Daftar.Text = "Daftar"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(877, 282)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(256, 35)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 14.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(663, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 14.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(663, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(877, 356)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(256, 35)
        Me.TextBox2.TabIndex = 4
        '
        'mail
        '
        Me.mail.AutoSize = True
        Me.mail.BackColor = System.Drawing.Color.Transparent
        Me.mail.Font = New System.Drawing.Font("Rockwell", 14.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mail.Location = New System.Drawing.Point(573, 328)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(105, 37)
        Me.mail.TabIndex = 0
        Me.mail.Text = "Email"
        '
        'email
        '
        Me.email.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email.Location = New System.Drawing.Point(886, 333)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(365, 35)
        Me.email.TabIndex = 1
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username.Location = New System.Drawing.Point(886, 388)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(365, 35)
        Me.username.TabIndex = 3
        '
        'User
        '
        Me.User.AutoSize = True
        Me.User.BackColor = System.Drawing.Color.Transparent
        Me.User.Font = New System.Drawing.Font("Rockwell", 14.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.User.Location = New System.Drawing.Point(573, 383)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(172, 37)
        Me.User.TabIndex = 2
        Me.User.Text = "Username"
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.Location = New System.Drawing.Point(886, 443)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(365, 35)
        Me.password.TabIndex = 5
        '
        'Pass
        '
        Me.Pass.AutoSize = True
        Me.Pass.BackColor = System.Drawing.Color.Transparent
        Me.Pass.Font = New System.Drawing.Font("Rockwell", 14.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pass.Location = New System.Drawing.Point(573, 438)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(163, 37)
        Me.Pass.TabIndex = 4
        Me.Pass.Text = "Password"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Rockwell", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(580, 518)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(671, 50)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Register"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1889, 864)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "LoginForm"
        Me.Text = "Login Form"
        Me.TabControl1.ResumeLayout(False)
        Me.Login.ResumeLayout(False)
        Me.Login.PerformLayout()
        Me.Daftar.ResumeLayout(False)
        Me.Daftar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Login As TabPage
    Friend WithEvents Daftar As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents Pass As Label
    Friend WithEvents username As TextBox
    Friend WithEvents User As Label
    Friend WithEvents email As TextBox
    Friend WithEvents mail As Label
    Friend WithEvents Button2 As Button
End Class
