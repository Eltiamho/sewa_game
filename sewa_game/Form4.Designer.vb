<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.Labelemail = New System.Windows.Forms.Label()
        Me.Labelgame = New System.Windows.Forms.Label()
        Me.Labeldurasi = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.simpan = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.sewa = New System.Windows.Forms.NumericUpDown()
        Me.listGame = New System.Windows.Forms.ComboBox()
        CType(Me.sewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Labelemail
        '
        Me.Labelemail.AutoSize = True
        Me.Labelemail.Location = New System.Drawing.Point(117, 83)
        Me.Labelemail.Name = "Labelemail"
        Me.Labelemail.Size = New System.Drawing.Size(60, 25)
        Me.Labelemail.TabIndex = 0
        Me.Labelemail.Text = "Email"
        '
        'Labelgame
        '
        Me.Labelgame.AutoSize = True
        Me.Labelgame.Location = New System.Drawing.Point(117, 177)
        Me.Labelgame.Name = "Labelgame"
        Me.Labelgame.Size = New System.Drawing.Size(100, 25)
        Me.Labelgame.TabIndex = 1
        Me.Labelgame.Text = "pilih game"
        '
        'Labeldurasi
        '
        Me.Labeldurasi.AutoSize = True
        Me.Labeldurasi.Location = New System.Drawing.Point(117, 387)
        Me.Labeldurasi.Name = "Labeldurasi"
        Me.Labeldurasi.Size = New System.Drawing.Size(171, 25)
        Me.Labeldurasi.TabIndex = 2
        Me.Labeldurasi.Text = "durasi penyewaan"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(318, 79)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(245, 29)
        Me.TextBoxEmail.TabIndex = 3
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(461, 465)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(101, 44)
        Me.simpan.TabIndex = 6
        Me.simpan.Text = "simpan"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(111, 584)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(685, 369)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'sewa
        '
        Me.sewa.Location = New System.Drawing.Point(332, 387)
        Me.sewa.Name = "sewa"
        Me.sewa.Size = New System.Drawing.Size(120, 29)
        Me.sewa.TabIndex = 8
        '
        'listGame
        '
        Me.listGame.FormattingEnabled = True
        Me.listGame.Location = New System.Drawing.Point(318, 170)
        Me.listGame.Name = "listGame"
        Me.listGame.Size = New System.Drawing.Size(241, 32)
        Me.listGame.TabIndex = 9
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2884, 1584)
        Me.Controls.Add(Me.listGame)
        Me.Controls.Add(Me.sewa)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.Labeldurasi)
        Me.Controls.Add(Me.Labelgame)
        Me.Controls.Add(Me.Labelemail)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.sewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Labelemail As Label
    Friend WithEvents Labelgame As Label
    Friend WithEvents Labeldurasi As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents simpan As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents sewa As NumericUpDown
    Friend WithEvents listGame As ComboBox
End Class
