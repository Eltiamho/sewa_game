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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Game", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Durasi", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Harga", System.Windows.Forms.HorizontalAlignment.Left)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Labelemail = New System.Windows.Forms.Label()
        Me.Labelgame = New System.Windows.Forms.Label()
        Me.Labeldurasi = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.simpan = New System.Windows.Forms.Button()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sewa = New System.Windows.Forms.NumericUpDown()
        Me.listGame = New System.Windows.Forms.ComboBox()
        Me.tId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.sewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Labelemail
        '
        Me.Labelemail.AutoSize = True
        Me.Labelemail.BackColor = System.Drawing.Color.Transparent
        Me.Labelemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelemail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Labelemail.Location = New System.Drawing.Point(106, 293)
        Me.Labelemail.Name = "Labelemail"
        Me.Labelemail.Size = New System.Drawing.Size(91, 32)
        Me.Labelemail.TabIndex = 0
        Me.Labelemail.Text = "Email"
        '
        'Labelgame
        '
        Me.Labelgame.AutoSize = True
        Me.Labelgame.BackColor = System.Drawing.Color.Transparent
        Me.Labelgame.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelgame.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Labelgame.Location = New System.Drawing.Point(106, 345)
        Me.Labelgame.Name = "Labelgame"
        Me.Labelgame.Size = New System.Drawing.Size(155, 32)
        Me.Labelgame.TabIndex = 1
        Me.Labelgame.Text = "pilih game"
        '
        'Labeldurasi
        '
        Me.Labeldurasi.AutoSize = True
        Me.Labeldurasi.BackColor = System.Drawing.Color.Transparent
        Me.Labeldurasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeldurasi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Labeldurasi.Location = New System.Drawing.Point(106, 400)
        Me.Labeldurasi.Name = "Labeldurasi"
        Me.Labeldurasi.Size = New System.Drawing.Size(261, 32)
        Me.Labeldurasi.TabIndex = 2
        Me.Labeldurasi.Text = "durasi penyewaan"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxEmail.Location = New System.Drawing.Point(436, 297)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(245, 29)
        Me.TextBoxEmail.TabIndex = 3
        '
        'simpan
        '
        Me.simpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.simpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.simpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.simpan.ForeColor = System.Drawing.Color.Navy
        Me.simpan.Location = New System.Drawing.Point(435, 470)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(242, 44)
        Me.simpan.TabIndex = 6
        Me.simpan.Text = "simpan"
        Me.simpan.UseVisualStyleBackColor = False
        '
        'ListView
        '
        Me.ListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView.FullRowSelect = True
        Me.ListView.GridLines = True
        ListViewGroup1.Header = "Game"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "Durasi"
        ListViewGroup2.Name = "ListViewGroup2"
        ListViewGroup3.Header = "Harga"
        ListViewGroup3.Name = "ListViewGroup3"
        Me.ListView.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.ListView.HideSelection = False
        Me.ListView.Location = New System.Drawing.Point(112, 727)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(1224, 556)
        Me.ListView.TabIndex = 11
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader
        '
        Me.ColumnHeader.Text = "Kode Transaksi"
        Me.ColumnHeader.Width = 158
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID GAME"
        Me.ColumnHeader3.Width = 95
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Durasi Sewa per bulan"
        Me.ColumnHeader4.Width = 212
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Harga"
        Me.ColumnHeader5.Width = 447
        '
        'sewa
        '
        Me.sewa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sewa.Location = New System.Drawing.Point(436, 400)
        Me.sewa.Name = "sewa"
        Me.sewa.Size = New System.Drawing.Size(120, 29)
        Me.sewa.TabIndex = 8
        '
        'listGame
        '
        Me.listGame.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.listGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.listGame.FormattingEnabled = True
        Me.listGame.Location = New System.Drawing.Point(436, 345)
        Me.listGame.Name = "listGame"
        Me.listGame.Size = New System.Drawing.Size(241, 32)
        Me.listGame.TabIndex = 9
        '
        'tId
        '
        Me.tId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tId.Location = New System.Drawing.Point(436, 247)
        Me.tId.Name = "tId"
        Me.tId.Size = New System.Drawing.Size(100, 29)
        Me.tId.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(106, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 32)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Kode Transaksi"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(64, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 51)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(592, 397)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 32)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "/ bulan"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Plum
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1403, 739)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(598, 108)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Pembayaran"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(123, 631)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(558, 48)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Pesanan yang belum dibayar"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(2884, 1584)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tId)
        Me.Controls.Add(Me.listGame)
        Me.Controls.Add(Me.sewa)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.Labeldurasi)
        Me.Controls.Add(Me.Labelgame)
        Me.Controls.Add(Me.Labelemail)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.sewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Labelemail As Label
    Friend WithEvents Labelgame As Label
    Friend WithEvents Labeldurasi As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents simpan As Button
    Friend WithEvents ListView As ListView
    Friend WithEvents sewa As NumericUpDown
    Friend WithEvents listGame As ComboBox
    Friend WithEvents tId As TextBox
    Friend WithEvents ColumnHeader As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
End Class
