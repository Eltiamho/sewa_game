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
        Me.PanelGame.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelGame.Location = New System.Drawing.Point(3, -1)
        Me.PanelGame.Name = "PanelGame"
        Me.PanelGame.Size = New System.Drawing.Size(3078, 1929)
        Me.PanelGame.TabIndex = 0
        '
        'BtnBrowseGame
        '
        Me.BtnBrowseGame.Location = New System.Drawing.Point(49, 59)
        Me.BtnBrowseGame.Name = "BtnBrowseGame"
        Me.BtnBrowseGame.Size = New System.Drawing.Size(151, 62)
        Me.BtnBrowseGame.TabIndex = 1
        Me.BtnBrowseGame.Text = "Browse"
        Me.BtnBrowseGame.UseVisualStyleBackColor = True
        '
        'BtnMyGame
        '
        Me.BtnMyGame.Location = New System.Drawing.Point(272, 59)
        Me.BtnMyGame.Name = "BtnMyGame"
        Me.BtnMyGame.Size = New System.Drawing.Size(151, 62)
        Me.BtnMyGame.TabIndex = 2
        Me.BtnMyGame.Text = "My Game"
        Me.BtnMyGame.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2884, 1584)
        Me.Controls.Add(Me.BtnMyGame)
        Me.Controls.Add(Me.BtnBrowseGame)
        Me.Controls.Add(Me.PanelGame)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PanelGame As Panel
    Friend WithEvents BtnBrowseGame As Button
    Friend WithEvents BtnMyGame As Button
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
