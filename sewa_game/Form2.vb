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
                Dim gameImage As New PictureBox
                gameImage.Size = New Size(300, 150)
                gameImage.SizeMode = PictureBoxSizeMode.StretchImage
                gameImage.Location = New Point(xPos, yPos)

                ' Ambil gambar dari path di database
                Dim imagePath As String = reader("image_path").ToString()
                If IO.File.Exists(imagePath) Then
                    gameImage.Image = Image.FromFile(imagePath)
                Else
                    gameImage.Image = Image.FromFile("default_image.jpg")
                End If

                Dim id As String = reader("id").ToString()

                ' Tambahkan event handler untuk menangani klik gambar
                AddHandler gameImage.Click, Sub(s, ea) ShowGameDetail(id)

                PanelGame.Controls.Add(gameImage)

                ' Tambahkan label untuk nama game dan harga
                Dim gameName As New Label With {
                .Text = reader("name").ToString(),
                .Font = New Font("Arial", 12, FontStyle.Bold),
                .Location = New Point(xPos, yPos + 160)
            }
                PanelGame.Controls.Add(gameName)

                Dim gamePrice As New Label With {
                .Text = "Rp. " & reader("price").ToString() & "/month",
                .Font = New Font("Arial", 10, FontStyle.Italic),
                .Size = New Size(200, 50),
                .Location = New Point(xPos, yPos + 240)
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
        detailForm.ShowDialog()
    End Sub

    ' Event untuk tombol Browse Game (default menampilkan semua game dari database)
    Private Sub BtnBrowseGame_Click(sender As Object, e As EventArgs) Handles BtnBrowseGame.Click
        ShowBrowseGames()
    End Sub

    ' Event untuk tombol My Game (menampilkan game yang disewa pengguna)
    Private Sub BtnMyGame_Click(sender As Object, e As EventArgs) Handles BtnMyGame.Click
        ' Bersihkan tampilan panel
        PanelGame.Controls.Clear()

        ' Logika untuk menampilkan game yang telah disewa oleh pengguna bisa diterapkan di sini
        ' Sebagai contoh: Tampilkan game yang disewa oleh pengguna (gunakan database table untuk menyimpan informasi sewa)
        Dim rentedGame As New Label
        rentedGame.Text = "kosong"
        rentedGame.Location = New Point(10, 10)
        PanelGame.Controls.Add(rentedGame)
    End Sub


End Class