Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Payment

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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Try
            Dim query As String = "SELECT SUM(harga_total) AS total_bayar FROM transaksi_sewa WHERE email_user = @Username AND Status = 0;"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Username", LoginForm.mail)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim total As Integer = 0 ' Inisialisasi variabel total

            If reader.Read() Then
                ' Pastikan nilai tidak NULL sebelum diassign
                If Not IsDBNull(reader("total_bayar")) Then
                    total = Convert.ToInt32(reader("total_bayar"))
                End If
            End If

            reader.Close()

            ' Tampilkan hasil total bayar (opsional)
            Label3.Text = "Rp. " & total.ToString()

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Koneksi()
        Try
            Dim query As String = "UPDATE transaksi_sewa SET Status = 1 WHERE email_user = @Email;"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Email", LoginForm.mail)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Pembayaran selesai")
            Else
                MessageBox.Show("Pembayaran tidak tersedia")
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class