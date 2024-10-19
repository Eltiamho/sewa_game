Imports MySql.Data.MySqlClient

Public Class Form3

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

    Public Sub New(id As String)
        InitializeComponent()

        Koneksi()

        ' Set data ke label atau kontrol di sini

        Try
            Dim query As String = "SELECT id, name, description, price, image_path FROM game WHERE id = @id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", id)

            ' Pastikan untuk menjalankan reader setelah menambahkan parameter
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim imagePath As String = reader("image_path").ToString()
                If IO.File.Exists(imagePath) Then
                    PictureBox1.Image = Image.FromFile(imagePath)
                Else
                    PictureBox1.Image = Image.FromFile("default_image.jpg")
                End If

                LabelName.Text = reader("name").ToString()
                ' Tambahkan kontrol lain jika perlu
                LabelDescription.Text = reader("description").ToString()
                LabelPrice.Text = "Rp. " & reader("price").ToString() & "/month"
            Else
                MessageBox.Show("Game tidak ditemukan.")
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sewaForm As New Form4()

        ' Tampilkan form baru
        sewaForm.Show()

        ' Tutup form saat ini (Form2)
        Me.Close()
    End Sub


    Private Sub LabelName_Click(sender As Object, e As EventArgs) Handles LabelName.Click

    End Sub
End Class