<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.imgPth = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.desc = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Game"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Game"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Deskripsi"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(84, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 35)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(259, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 35)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(416, 274)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 35)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Tambah"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ListView
        '
        Me.ListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader1})
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
        Me.ListView.Location = New System.Drawing.Point(84, 332)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(905, 337)
        Me.ListView.TabIndex = 12
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader
        '
        Me.ColumnHeader.Text = "ID GAME"
        Me.ColumnHeader.Width = 158
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "NAMA GAME"
        Me.ColumnHeader4.Width = 168
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "DESKRIPSI"
        Me.ColumnHeader5.Width = 212
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Harga"
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "IMAGE PATH"
        Me.ColumnHeader1.Width = 148
        '
        'imgPth
        '
        Me.imgPth.Location = New System.Drawing.Point(275, 239)
        Me.imgPth.Name = "imgPth"
        Me.imgPth.Size = New System.Drawing.Size(143, 29)
        Me.imgPth.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "IMG PATH"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 25)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Harga"
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(275, 199)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(200, 29)
        Me.harga.TabIndex = 15
        '
        'desc
        '
        Me.desc.Location = New System.Drawing.Point(275, 159)
        Me.desc.Name = "desc"
        Me.desc.Size = New System.Drawing.Size(479, 29)
        Me.desc.TabIndex = 5
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(275, 119)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(200, 29)
        Me.nama.TabIndex = 4
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(275, 81)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(93, 29)
        Me.id.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1291, 1040)
        Me.Controls.Add(Me.imgPth)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.desc)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormAdmin"
        Me.Text = "FormAdmin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ListView As ListView
    Friend WithEvents ColumnHeader As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents imgPth As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents harga As TextBox
    Friend WithEvents desc As TextBox
    Friend WithEvents nama As TextBox
    Friend WithEvents id As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
