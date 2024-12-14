Imports MySql.Data.MySqlClient
Public Class Form2
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Sub Koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=sewa_game;")
        Try
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("Error Koneksi: " & ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowBrowseGames()
    End Sub
    ' Menampilkan daftar game dari database di menu Browse Game
    Private Sub ShowBrowseGames()
        ' Bersihkan panel game sebelum menambahkan game baru
        PanelGame.Controls.Clear()

        Koneksi()

        Try
            Dim query As String = "SELECT id,name, description, price, image_path FROM game;"
            cmd = New MySqlCommand(query, conn)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim xPos As Integer = 50
            Dim yPos As Integer = 150
            Dim maxWidth As Integer = PanelGame.Width - 50
            Dim gameWidth As Integer = 400

            While reader.Read()
                Dim panel As New Panel With {
                    .BackColor = Color.Indigo,
                    .Size = New Size(310, 320),
                    .Location = New Point(xPos, yPos)
                    }

                Dim gameImage As New PictureBox
                gameImage.Size = New Size(300, 150)
                gameImage.SizeMode = PictureBoxSizeMode.StretchImage
                gameImage.Location = New Point(xPos, yPos)
                gameImage.Cursor = Cursors.Hand

                ' Ambil gambar dari path di database
                Dim imagePath As String = reader("image_path").ToString()
                If IO.File.Exists(imagePath) Then
                    gameImage.Image = Image.FromFile(imagePath)
                Else
                    gameImage.Image = Image.FromFile("Screenshot 2024-10-19 184642.png")
                End If

                Dim id As String = reader("id").ToString()

                ' Tambahkan event handler untuk menangani klik gambar
                AddHandler gameImage.Click, Sub(s, ea) ShowGameDetail(id)

                PanelGame.Controls.Add(gameImage)

                ' Tambahkan label untuk nama game dan harga
                Dim gameName As New Label With {
                .Text = reader("name").ToString(),
                .Font = New Font("Arial", 12, FontStyle.Bold),
                .Size = New Size(100, 25),
                .Location = New Point(xPos, yPos + 160),
                .ForeColor = Color.White,
                .BackColor = Color.HotPink
            }
                PanelGame.Controls.Add(gameName)

                Dim gamePrice As New Label With {
                .Text = "Rp. " & reader("price").ToString() & "/month",
                .Font = New Font("Arial", 10, FontStyle.Italic),
                .Size = New Size(125, 15),
                .Location = New Point(xPos, yPos + 240),
                                .ForeColor = Color.White,
                .BackColor = Color.Black
            }
                PanelGame.Controls.Add(gamePrice)

                Dim gameDesc As New Label With {
                .Text = reader("description").ToString(),
                .Size = New Size(100, 50),
                .Location = New Point(xPos, yPos + 200)
            }
                PanelGame.Controls.Add(gameDesc)

                xPos += 400
                If xPos > maxWidth Then
                    xPos = 50
                    yPos += 350
                End If
            End While
            reader.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Method untuk menampilkan detail game
    Private Sub ShowGameDetail(id As String)
        Dim detailForm As New Form3(id)
        ' Tutup form saat ini (Form2)
        Me.Close()
        'Tampilkan Form baru
        detailForm.Show()
        ' detailForm.ShowDialog()
    End Sub

    ' Event untuk tombol Browse Game (default menampilkan semua game dari database)
    Private Sub BtnBrowseGame_Click(sender As Object, e As EventArgs) Handles BtnBrowseGame.Click
        ShowBrowseGames()
    End Sub

    ' Event untuk tombol My Game (menampilkan game yang disewa pengguna)
    Private Sub BtnMyGame_Click(sender As Object, e As EventArgs) Handles BtnMyGame.Click
        ' Bersihkan tampilan panel
        PanelGame.Controls.Clear()

        Koneksi() ' Buka koneksi ke database

        Try
            ' Query untuk mengambil game yang disewa pengguna
            Dim query As String = "SELECT game.name, game.description, game.image_path " &
                              "FROM transaksi_sewa " &
                              "JOIN users ON transaksi_sewa.email_user = users.Email " &
                              "JOIN game ON transaksi_sewa.id_game = game.id " &
                              "WHERE users.Email = @mail;"

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@mail", LoginForm.mail) ' Tambahkan parameter email

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim xPos As Integer = 50
            Dim yPos As Integer = 150
            Dim maxWidth As Integer = PanelGame.Width - 50
            Dim gameWidth As Integer = 400

            ' Loop untuk membaca data dari database
            While reader.Read()
                Dim panel As New Panel With {
                .BackColor = Color.Indigo,
                .Size = New Size(310, 320),
                .Location = New Point(xPos, yPos)
            }

                Dim gameImage As New PictureBox
                gameImage.Size = New Size(300, 150)
                gameImage.SizeMode = PictureBoxSizeMode.StretchImage
                gameImage.Location = New Point(5, 5)
                gameImage.Cursor = Cursors.Hand

                ' Ambil gambar dari path di database
                Dim imagePath As String = reader("image_path").ToString()
                If IO.File.Exists(imagePath) Then
                    gameImage.Image = Image.FromFile(imagePath)
                Else
                    gameImage.Image = Image.FromFile("default_image.png") ' Gambar default jika tidak ditemukan
                End If

                panel.Controls.Add(gameImage)

                ' Tambahkan label untuk nama game
                Dim gameName As New Label With {
                .Text = reader("name").ToString(),
                .Font = New Font("Arial", 12, FontStyle.Bold),
                .Size = New Size(300, 25),
                .Location = New Point(5, 160),
                .ForeColor = Color.White,
                .BackColor = Color.HotPink
            }
                panel.Controls.Add(gameName)

                ' Tambahkan label untuk deskripsi game
                Dim gameDesc As New Label With {
                .Text = reader("description").ToString(),
                .Font = New Font("Arial", 10),
                .Size = New Size(300, 50),
                .Location = New Point(5, 200),
                .ForeColor = Color.White,
                .BackColor = Color.Black
            }
                panel.Controls.Add(gameDesc)

                PanelGame.Controls.Add(panel)

                xPos += 400
                If xPos > maxWidth Then
                    xPos = 50
                    yPos += 350
                End If
            End While
            reader.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close() ' Pastikan koneksi ditutup
        End Try
    End Sub



    ' Logika untuk menampilkan game yang telah disewa oleh pengguna bisa diterapkan di sini
    ' Sebagai contoh: Tampilkan game yang disewa oleh pengguna (gunakan database table untuk menyimpan informasi sewa)
    'Dim rentedGame As New Label
    '    rentedGame.Text = "kosong"
    '    rentedGame.Location = New Point(10, 10)
    '    PanelGame.Controls.Add(rentedGame)
    'End Sub

    Private Sub PanelGame_Paint(sender As Object, e As PaintEventArgs) Handles PanelGame.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        LoginForm.Show()

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

        LoginForm.TextBox1.Text = ""
        LoginForm.TextBox2.Text = ""
        LoginForm.Show()
    End Sub
End Class