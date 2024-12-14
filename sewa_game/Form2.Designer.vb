<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelGame = New System.Windows.Forms.Panel()
        Me.BtnBrowseGame = New System.Windows.Forms.Button()
        Me.BtnMyGame = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "gta 5.png")
        Me.ImageList1.Images.SetKeyName(1, "valorant.png")
        '
        'PanelGame
        '
        Me.PanelGame.BackColor = System.Drawing.Color.Transparent
        Me.PanelGame.BackgroundImage = CType(resources.GetObject("PanelGame.BackgroundImage"), System.Drawing.Image)
        Me.PanelGame.ForeColor = System.Drawing.Color.White
        Me.PanelGame.Location = New System.Drawing.Point(3, -5)
        Me.PanelGame.Name = "PanelGame"
        Me.PanelGame.Size = New System.Drawing.Size(3078, 1933)
        Me.PanelGame.TabIndex = 0
        '
        'BtnBrowseGame
        '
        Me.BtnBrowseGame.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnBrowseGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBrowseGame.Location = New System.Drawing.Point(49, 59)
        Me.BtnBrowseGame.Name = "BtnBrowseGame"
        Me.BtnBrowseGame.Size = New System.Drawing.Size(151, 62)
        Me.BtnBrowseGame.TabIndex = 1
        Me.BtnBrowseGame.Text = "Browse"
        Me.BtnBrowseGame.UseVisualStyleBackColor = False
        '
        'BtnMyGame
        '
        Me.BtnMyGame.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnMyGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMyGame.Location = New System.Drawing.Point(272, 59)
        Me.BtnMyGame.Name = "BtnMyGame"
        Me.BtnMyGame.Size = New System.Drawing.Size(151, 62)
        Me.BtnMyGame.TabIndex = 2
        Me.BtnMyGame.Text = "My Game"
        Me.BtnMyGame.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2703, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 103)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2884, 1584)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnMyGame)
        Me.Controls.Add(Me.BtnBrowseGame)
        Me.Controls.Add(Me.PanelGame)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PanelGame As Panel
    Friend WithEvents BtnBrowseGame As Button
    Friend WithEvents BtnMyGame As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents PictureBox1 As PictureBox
End Class
