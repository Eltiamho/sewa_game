<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.MySqlCommand2 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.dgvGame = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtImagePath = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtDeskripsi = New System.Windows.Forms.TextBox()
        Me.txtNamaGame = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBrowseImage = New System.Windows.Forms.Button()
        Me.pbGameImage = New System.Windows.Forms.PictureBox()
        CType(Me.dgvGame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGameImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica Rounded", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(554, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 66)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sewa Game"
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'MySqlCommand2
        '
        Me.MySqlCommand2.CacheAge = 0
        Me.MySqlCommand2.Connection = Nothing
        Me.MySqlCommand2.EnableCaching = False
        Me.MySqlCommand2.Transaction = Nothing
        '
        'dgvGame
        '
        Me.dgvGame.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGame.Location = New System.Drawing.Point(89, 467)
        Me.dgvGame.Name = "dgvGame"
        Me.dgvGame.ReadOnly = True
        Me.dgvGame.RowHeadersWidth = 72
        Me.dgvGame.RowTemplate.Height = 31
        Me.dgvGame.Size = New System.Drawing.Size(1302, 367)
        Me.dgvGame.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "ID game"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(98, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "deskripsi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(98, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 25)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Nama game"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(98, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 25)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "image path"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(321, 158)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(136, 29)
        Me.txtID.TabIndex = 21
        '
        'txtImagePath
        '
        Me.txtImagePath.Location = New System.Drawing.Point(321, 310)
        Me.txtImagePath.Name = "txtImagePath"
        Me.txtImagePath.ReadOnly = True
        Me.txtImagePath.Size = New System.Drawing.Size(136, 29)
        Me.txtImagePath.TabIndex = 23
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(321, 271)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(136, 29)
        Me.txtHarga.TabIndex = 24
        '
        'txtDeskripsi
        '
        Me.txtDeskripsi.Location = New System.Drawing.Point(321, 230)
        Me.txtDeskripsi.Multiline = True
        Me.txtDeskripsi.Name = "txtDeskripsi"
        Me.txtDeskripsi.Size = New System.Drawing.Size(423, 29)
        Me.txtDeskripsi.TabIndex = 25
        '
        'txtNamaGame
        '
        Me.txtNamaGame.Location = New System.Drawing.Point(321, 195)
        Me.txtNamaGame.Name = "txtNamaGame"
        Me.txtNamaGame.Size = New System.Drawing.Size(268, 29)
        Me.txtNamaGame.TabIndex = 26
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(103, 378)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(130, 37)
        Me.btnUpdate.TabIndex = 27
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(515, 378)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(130, 37)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(306, 378)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 37)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBrowseImage
        '
        Me.btnBrowseImage.Location = New System.Drawing.Point(606, 299)
        Me.btnBrowseImage.Name = "btnBrowseImage"
        Me.btnBrowseImage.Size = New System.Drawing.Size(128, 52)
        Me.btnBrowseImage.TabIndex = 31
        Me.btnBrowseImage.Text = "Browse"
        Me.btnBrowseImage.UseVisualStyleBackColor = True
        '
        'pbGameImage
        '
        Me.pbGameImage.Location = New System.Drawing.Point(1117, 245)
        Me.pbGameImage.Name = "pbGameImage"
        Me.pbGameImage.Size = New System.Drawing.Size(112, 90)
        Me.pbGameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGameImage.TabIndex = 32
        Me.pbGameImage.TabStop = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1541, 907)
        Me.Controls.Add(Me.pbGameImage)
        Me.Controls.Add(Me.btnBrowseImage)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtNamaGame)
        Me.Controls.Add(Me.txtDeskripsi)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtImagePath)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvGame)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.dgvGame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGameImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents MySqlCommand2 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents dgvGame As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtImagePath As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents txtNamaGame As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBrowseImage As Button
    Friend WithEvents pbGameImage As PictureBox
End Class
