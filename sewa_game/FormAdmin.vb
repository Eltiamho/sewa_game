Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Public Class FormAdmin
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader

    Sub Koneksi()
        ' Tutup koneksi terlebih dahulu jika masih terbuka
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.ConnectionString = "server=localhost;user id=root;" & "password=;database=sewa_game;"
        Try
            conn.Open()

        Catch myerror As MySqlException
            MsgBox("Error Koneksi : " & myerror.Message)
            conn.Close()


        End Try
    End Sub
    Private Sub Clear()
        id.Text = ""
        nama.Text = ""
        desc.Text = ""
        harga.Text = ""
        imgPth.Text = ""
    End Sub
    Private Sub loadTransaksi()
        Try
            Dim query As String = "SELECT * FROM game;"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader()

            ' Kosongkan ListView sebelum menambahkan data baru
            ListView.Items.Clear()

            ' Tambahkan data ke ListView
            While reader.Read()
                ' Membuat item baru untuk ListView
                Dim item As New ListViewItem(reader.Item(0).ToString()) ' kode_transaksi
                item.SubItems.Add(reader.Item(1).ToString()) ' id_game
                item.SubItems.Add(reader.Item(2).ToString()) ' lama_penyewaan
                item.SubItems.Add(reader.Item(3).ToString()) ' harga
                item.SubItems.Add(reader.Item(4).ToString()) ' harga

                ListView.Items.Add(item) ' Tambahkan item ke ListView
            End While

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        loadTransaksi()
    End Sub

    Private Sub ListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView.SelectedIndexChanged

    End Sub


    Public Sub InsertOrder()
        Koneksi()
        Dim idGame As String = id.Text
        Dim name As String = nama.Text
        Dim descr As String = desc.Text
        Dim hrg As String = harga.Text
        Dim img As String = imgPth.Text

        ' Query untuk insert
        Dim query As String = "INSERT INTO game (id,name,description,price,image_path) VALUES (@kode_transaksi, @email_user, @id_game, @lama_penyewaan, @harga_total)"
        'Dim query As String = "INSERT INTO transaksi_sewa (kode_transaksi,email_user,id_game,lama_penyewaan,harga_total) VALUES (@kode_transaksi, @email_user, @id_game, @lama_penyewaan,SELECT price FROM game WHERE id = @id_game) * @lama_penyewaan)"
        'Panggil koneksi dari modul modKoneksi
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@kode_transaksi", idGame)
            command.Parameters.AddWithValue("@email_user", name)
            command.Parameters.AddWithValue("@id_game", descr)
            command.Parameters.AddWithValue("@lama_penyewaan", hrg)
            command.Parameters.AddWithValue("@harga_total", img)

            Try
                command.ExecuteNonQuery()
                MessageBox.Show("Sukses menyimpan Game dengan kode: " & idGame)

            Catch ex As MySqlException
                MessageBox.Show("Error : " & ex.Message)
            Finally
                'Pastikan koneksi ditutup
            End Try
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        InsertOrder()
        loadTransaksi()
        Clear()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Koneksi()
        Dim idGame As String = id.Text
        Using command As New MySqlCommand("DELETE FROM game WHERE id = " & idGame, conn)
            Try
                command.ExecuteNonQuery()
                MessageBox.Show("berhasil terhapus")
            Catch ex As Exception
                MessageBox.Show("gagal terhapus")
            End Try
        End Using
        loadTransaksi()
        Clear()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Koneksi()
        Dim idGame As String = id.Text
        Dim name As String = nama.Text
        Dim descr As String = desc.Text
        Dim hrg As String = harga.Text
        Dim img As String = imgPth.Text

        ' Query untuk insert
        Dim query As String = "UPDATE game SET name = @name, description = @descr, price = @hrg, image_path = @img WHERE id = @idGame"

        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@name", name)
            command.Parameters.AddWithValue("@descr", descr)
            command.Parameters.AddWithValue("@hrg", hrg)
            command.Parameters.AddWithValue("@img", img)
            command.Parameters.AddWithValue("@idGame", idGame) ' Tambahkan parameter idGame

            Try
                command.ExecuteNonQuery()
                MessageBox.Show("Sukses menyimpan Game dengan kode: " & idGame)
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message) ' Tangkap exception lain
            Finally
                ' Pastikan koneksi ditutup
                'If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                '    conn.Close()
                'End If
            End Try
        End Using
        loadTransaksi()
        Clear()

    End Sub

    Private Sub id_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class