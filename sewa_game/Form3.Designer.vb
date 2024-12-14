<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(293, 99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1461, 887)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.BackColor = System.Drawing.Color.HotPink
        Me.LabelName.Font = New System.Drawing.Font("Rockwell Extra Bold", 8.142858!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.ForeColor = System.Drawing.Color.White
        Me.LabelName.Location = New System.Drawing.Point(301, 1026)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(91, 24)
        Me.LabelName.TabIndex = 1
        Me.LabelName.Text = "Label1"
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelDescription.ForeColor = System.Drawing.Color.White
        Me.LabelDescription.Location = New System.Drawing.Point(1784, 99)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(71, 25)
        Me.LabelDescription.TabIndex = 2
        Me.LabelDescription.Text = "Label1"
        '
        'LabelPrice
        '
        Me.LabelPrice.AutoSize = True
        Me.LabelPrice.BackColor = System.Drawing.Color.Black
        Me.LabelPrice.ForeColor = System.Drawing.Color.White
        Me.LabelPrice.Location = New System.Drawing.Point(300, 1078)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(71, 25)
        Me.LabelPrice.TabIndex = 3
        Me.LabelPrice.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(293, 1213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 96)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Sewa game"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(98, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(189, 50)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "BROWSE GAME"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(324, 31)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(163, 50)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "MY GAME"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(2884, 1584)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelPrice)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelDescription As Label
    Friend WithEvents LabelPrice As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
