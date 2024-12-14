Imports System.Diagnostics.Eventing
Imports System.Drawing.Text
Imports MySql.Data.MySqlClient

Public Class Form4
    Private Username As String


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
        TextBoxEmail.Text = "" & LoginForm.mail
        LoadGamesFromDatabase()
        tId.Text = GenerateOrderID()
        loadTransaksi()
        Label3.Text = "Pesanan yang belum dibayar atas email " & LoginForm.mail
    End Sub

    Private Sub loadTransaksi()
        Try
            Dim query As String = "SELECT kode_transaksi, id_game,lama_penyewaan,harga_total FROM transaksi_sewa where email_user = @email AND Status = 0;"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@email", LoginForm.mail)
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

                ListView.Items.Add(item) ' Tambahkan item ke ListView
            End While

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
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

    Private Sub RefreshForm()
        tId.Clear() ' Clear the customer name input
        'tbNama.Focus() ' Set focus back to the customer name TextBox
        TextBoxEmail.Clear()
        loadTransaksi()

    End Sub


    Public Sub InsertOrder()
        Koneksi()
        tId.Text = GenerateOrderID()
        Dim emailUser As String = TextBoxEmail.Text
        Dim durasiSewa As Integer = sewa.Value
        Dim game As String = (listGame.SelectedIndex + 1).ToString() ' Ambil ID game sesuai index checkbox
        Dim kode As String = tId.Text
        ' Ambil harga dari game
        Dim hargaGame As Integer = 0
        Dim hargaQuery As String = "SELECT price FROM game WHERE id = @id_game"

        Using hargaCommand As New MySqlCommand(hargaQuery, conn)
            hargaCommand.Parameters.AddWithValue("@id_game", game)
            ' Menggunakan ExecuteScalar untuk mendapatkan harga sebagai integer
            hargaGame = Convert.ToInt32(hargaCommand.ExecuteScalar())
        End Using

        ' Hitung harga total
        Dim hargaTotal As Integer = hargaGame * durasiSewa




        ' Query untuk insert
        Dim query As String = "INSERT INTO transaksi_sewa (kode_transaksi, email_user, id_game, lama_penyewaan, harga_total) VALUES (@kode_transaksi, @email_user, @id_game, @lama_penyewaan, @harga_total)"
        'Dim query As String = "INSERT INTO transaksi_sewa (kode_transaksi,email_user,id_game,lama_penyewaan,harga_total) VALUES (@kode_transaksi, @email_user, @id_game, @lama_penyewaan,SELECT price FROM game WHERE id = @id_game) * @lama_penyewaan)"
        'Panggil koneksi dari modul modKoneksi
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@kode_transaksi", kode)
            command.Parameters.AddWithValue("@email_user", emailUser)
            command.Parameters.AddWithValue("@id_game", game)
            command.Parameters.AddWithValue("@lama_penyewaan", durasiSewa)
            command.Parameters.AddWithValue("@harga_total", hargaTotal)

            Try
                If hargaTotal = 0 Then
                    MessageBox.Show("Durasi tidak boleh 0 : ")

                Else
                    command.ExecuteNonQuery()
                    MessageBox.Show("Sukses menyimpan Transaksi dengan kode: " & kode)

                End If


            Catch ex As MySqlException
                MessageBox.Show("Error : " & ex.Message)
            Finally
                ListView.Refresh()
                'Pastikan koneksi ditutup
            End Try
        End Using
    End Sub
    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        InsertOrder()
        loadTransaksi()
        report.Show()


    End Sub



    Public Function GenerateOrderID() As String
        Dim newOrderID As String = ""
        Dim lastOrderID As String = ""
        Koneksi()
        ' Step 1: Get the last Order ID from the database
        Dim query As String = "SELECT kode_transaksi FROM transaksi_sewa ORDER BY kode_transaksi DESC LIMIT 1"
        Using command As New MySqlCommand(query, conn)
            Try
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    lastOrderID = reader("kode_transaksi").ToString()
                End If
                reader.Close()
            Catch ex As MySqlException
                MessageBox.Show("Error : " & ex.Message)
            Finally
                'Pastikan koneksi ditutup
            End Try
        End Using

        ' Step 2: Generate new Order ID based on the last Order ID
        If lastOrderID = "" Then
            ' If no records found, start with a base ID
            newOrderID = "T001"
        Else
            ' Extract the numeric part and increment it
            Dim numericPart As Integer = Integer.Parse(lastOrderID.Substring(1)) ' Extracts the number after "ORD"
            numericPart += 1
            newOrderID = "T" & numericPart.ToString("D3") ' Formats to ensure 4 digits, e.g., ORD1002
        End If

        Return newOrderID
    End Function

    Private Sub listGame_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listGame.SelectedIndexChanged

    End Sub

    Private Sub sewa_ValueChanged(sender As Object, e As EventArgs) Handles sewa.ValueChanged

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView.SelectedIndexChanged

    End Sub

    Private Sub tId_TextChanged(sender As Object, e As EventArgs) Handles tId.TextChanged
        GenerateOrderID()
    End Sub

    Private Sub Labelemail_Click(sender As Object, e As EventArgs) Handles Labelemail.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()

        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Payment.Show()
    End Sub
End Class