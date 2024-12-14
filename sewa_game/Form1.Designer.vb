<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Login = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ShowPassword = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Daftar = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.Login.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Daftar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.Navy
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button1.Font = New System.Drawing.Font("Rockwell", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.Transparent
        Me.button1.Location = New System.Drawing.Point(20, 328)
        Me.button1.Margin = New System.Windows.Forms.Padding(4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(464, 50)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Login"
        Me.button1.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Login)
        Me.TabControl1.Controls.Add(Me.Daftar)
        Me.TabControl1.Font = New System.Drawing.Font("Rockwell", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(3095, 1753)
        Me.TabControl1.TabIndex = 3
        '
        'Login
        '
        Me.Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Login.BackgroundImage = CType(resources.GetObject("Login.BackgroundImage"), System.Drawing.Image)
        Me.Login.Controls.Add(Me.Button3)
        Me.Login.Controls.Add(Me.ShowPassword)
        Me.Login.Controls.Add(Me.Panel2)
        Me.Login.Location = New System.Drawing.Point(4, 37)
        Me.Login.Margin = New System.Windows.Forms.Padding(4)
        Me.Login.Name = "Login"
        Me.Login.Padding = New System.Windows.Forms.Padding(4)
        Me.Login.Size = New System.Drawing.Size(3087, 1712)
        Me.Login.TabIndex = 0
        Me.Login.Text = "Masuk"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Navy
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Rockwell", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(1260, 962)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(464, 50)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Admin"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ShowPassword
        '
        Me.ShowPassword.AutoSize = True
        Me.ShowPassword.BackColor = System.Drawing.Color.Transparent
        Me.ShowPassword.Font = New System.Drawing.Font("Rockwell", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPassword.ForeColor = System.Drawing.Color.Transparent
        Me.ShowPassword.Location = New System.Drawing.Point(1759, 800)
        Me.ShowPassword.Name = "ShowPassword"
        Me.ShowPassword.Size = New System.Drawing.Size(156, 31)
        Me.ShowPassword.TabIndex = 5
        Me.ShowPassword.Text = "Tampilkan"
        Me.ShowPassword.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.button1)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Location = New System.Drawing.Point(1240, 554)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(513, 494)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 33)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 26.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(130, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(252, 75)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "LOGIN"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Rockwell", 8.142858!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(229, 246)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(255, 30)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Rockwell", 8.142858!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(229, 172)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(255, 30)
        Me.TextBox1.TabIndex = 1
        '
        'Daftar
        '
        Me.Daftar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Daftar.BackgroundImage = CType(resources.GetObject("Daftar.BackgroundImage"), System.Drawing.Image)
        Me.Daftar.Controls.Add(Me.CheckBox1)
        Me.Daftar.Controls.Add(Me.Button2)
        Me.Daftar.Controls.Add(Me.password)
        Me.Daftar.Controls.Add(Me.username)
        Me.Daftar.Controls.Add(Me.email)
        Me.Daftar.Controls.Add(Me.Panel1)
        Me.Daftar.Location = New System.Drawing.Point(4, 37)
        Me.Daftar.Margin = New System.Windows.Forms.Padding(4)
        Me.Daftar.Name = "Daftar"
        Me.Daftar.Padding = New System.Windows.Forms.Padding(4)
        Me.Daftar.Size = New System.Drawing.Size(3087, 1712)
        Me.Daftar.TabIndex = 1
        Me.Daftar.Text = "Daftar"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Rockwell", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox1.Location = New System.Drawing.Point(1830, 742)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(156, 31)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Tampilkan"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Rockwell", 14.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(1140, 813)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(671, 50)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Register"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.Location = New System.Drawing.Point(1447, 737)
        Me.password.Margin = New System.Windows.Forms.Padding(4)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(365, 35)
        Me.password.TabIndex = 5
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username.Location = New System.Drawing.Point(1447, 682)
        Me.username.Margin = New System.Windows.Forms.Padding(4)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(365, 35)
        Me.username.TabIndex = 3
        '
        'email
        '
        Me.email.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email.Location = New System.Drawing.Point(1446, 623)
        Me.email.Margin = New System.Windows.Forms.Padding(4)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(365, 35)
        Me.email.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(1116, 481)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(708, 419)
        Me.Panel1.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(196, 46)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(205, 46)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 46)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 21.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(228, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(245, 62)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "DAFTAR"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2884, 1584)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LoginForm"
        Me.Text = "Login Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.Login.ResumeLayout(False)
        Me.Login.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Daftar.ResumeLayout(False)
        Me.Daftar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Login As TabPage
    Friend WithEvents Daftar As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ShowPassword As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
End Class
