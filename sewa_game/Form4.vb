Imports System.Diagnostics.Eventing
Imports System.Drawing.Text
Imports MySql.Data.MySqlClient

Public Class Form4
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Sub Koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=sewa_game;")
        Try
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("Error Koneksi: " & ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        LoadGamesFromDatabase()
    End Sub
    Private Sub LoadGamesFromDatabase()
        Try
            Dim query As String = "SELECT name,id FROM game;"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader()

            ' Tambahkan game ke CheckedListBox
            While reader.Read()
                listGame.Items.Add(reader("name").ToString())
            End While
            reader.Close()

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
    'Private Sub FromDatabase()
    '    Try
    '        'Dim queryGame As String = "select * from game"
    '        'cmd = New MySqlCommand(queryGame, conn)
    '        'Dim reader As MySqlDataReader = cmd.ExecuteReader()
    '        'Dim emailUser As String = TextBoxEmail.Text
    '        'listGame.Items.Clear()
    '        'While reader.Read()
    '        '    listGame.Items.Add(reader("name").ToString())
    '        'End While
    '        'reader.Close()

    '    Catch
    '        MessageBox.Show("Error Koneksi: " & ex.Message)

    '    End Try

    'End Sub


    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBoxDurasi_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxEmail_TextChanged(sender As Object, e As EventArgs) Handles TextBoxEmail.TextChanged

    End Sub
    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click

        Koneksi() ' Pastikan koneksi terbuka

        If conn.State = ConnectionState.Open Then
            Dim emailUser As String = TextBoxEmail.Text
            Dim durasiSewa As Integer = sewa.Value
            Dim game As String = (listGame.SelectedIndex + 1).ToString() ' Ambil ID game sesuai index checkbox
            Dim kode As String = GenerateNewID() ' Generate kode transaksi baru

            Try
                ' Query insert transaksi
                Dim query As String = "INSERT INTO transaksi_sewa VALUES (@kode_transaksi, @email_user, @id_game, @lama_penyewaan);"
                cmd = New MySqlCommand(query, conn) ' Buat perintah MySQL

                ' Tambahkan parameter
                cmd.Parameters.AddWithValue("@kode_transaksi", kode)
                cmd.Parameters.AddWithValue("@email_user", emailUser)
                cmd.Parameters.AddWithValue("@id_game", game)
                cmd.Parameters.AddWithValue("@lama_penyewaan", durasiSewa)

                ' Eksekusi query insert (gunakan ExecuteNonQuery karena ini INSERT query)
                cmd.ExecuteNonQuery()

                ' Pesan berhasil
                MessageBox.Show("Berhasil menambah transaksi!")
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
                'Finally
                'conn.Close() 
            Finally
                cmd.Dispose()
                conn.Close()

            End Try


        Else
            MessageBox.Show("Koneksi database tidak terbuka.")
        End If
    End Sub

    'Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
    '    Koneksi()
    '    Dim emailUser As String = TextBoxEmail.Text
    '    Dim durasiSewa As String = sewa.Value.ToString()
    '    Dim game As String = listGame.SelectedIndex + 1.ToString()
    '    Dim kode As String = GenerateNewID()
    '    Try
    '        Dim query As String = "insert into transaksi_sewa values (@kodeTransaksi,@emailUser,@game,@durasiSewa);"
    '        cmd.Parameters.AddWithValue("@kodeTransaksi", kode)
    '        cmd.Parameters.AddWithValue("@emailUser", emailUser)
    '        cmd.Parameters.AddWithValue("@game", game)
    '        cmd.Parameters.AddWithValue("@durasiSewa", durasiSewa)

    '        cmd = New MySqlCommand(query, conn)
    '        cmd.ExecuteNonQuery()

    '        ' Tambahkan game ke CheckedListBox
    '        MessageBox.Show("berhasil menambah transaksi")

    '    Catch ex As MySqlException
    '        MessageBox.Show("Error: " & ex.Message)
    '    Finally
    '        conn.Close() ' Pastikan koneksi ditutup setelah query selesai
    '    End Try

    'End Sub

    Private Function GenerateNewID() As String
        Dim newID As String = "T001" ' Default ID pertama jika tabel kosong


        Koneksi()

        Try
            ' Ambil ID terakhir dari tabel
            Dim query As String = "SELECT MAX(kode_transaksi) FROM transaksi_sewa"
            cmd = New MySqlCommand(query, conn)
            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot DBNull.Value Then
                ' Jika ID terakhir tidak null, ambil ID dan generate ID baru
                Dim lastID As String = result.ToString()

                ' Pisahkan karakter "T" dan angka dari ID terakhir (misal: T001)
                Dim numberPart As Integer = Integer.Parse(lastID.Substring(1)) ' Mengambil bagian angka

                ' Tambahkan 1 pada angka
                numberPart += 1

                ' Format angka agar tetap 3 digit (misal: 001, 002, dll.)
                Dim formattedNumber As String = numberPart.ToString("D3") ' D3 = Format angka menjadi 3 digit

                ' Gabungkan kembali karakter tetap "T" dengan angka baru
                newID = "T" & formattedNumber
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return newID
    End Function

    Private Sub listGame_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listGame.SelectedIndexChanged

    End Sub
End Class