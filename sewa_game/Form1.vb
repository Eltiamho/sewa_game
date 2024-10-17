Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

'Module ModuleKoneksi
'    'Deklarasi variabel koneksi string untuk digunakan dalam seluruh aplikasi
'    Private connectionString As String = "server=localhost;user id=root;" & "password=;database=sewa_game;"
'    ' Fungsi untuk mendapatkan objek MySqlConnection
'    Public Function GetConnection() As MySqlConnection
'        Dim conn As New MySqlConnection(connectionString)
'        Try
'            ' Buka koneksi
'            conn.Open()
'        Catch ex As MySqlException
'            'Jika gagal koneksi, tampilkan pesan error
'            MessageBox.Show("Error: " & ex.Message)
'        End Try
'        'Kembalikan objek koneksi yang sudah dibuka
'        Return conn
'    End Function
'End Module

Public Class LoginForm
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand

    Sub Koneksi()
        conn.ConnectionString = "server=localhost;user id=root;" & "password=;database=sewa_game;"
        Try
            conn.Open()

        Catch myerror As MySqlException
            MsgBox("Error Koneksi : " & myerror.Message)
            conn.Close()


        End Try
    End Sub

    Public Function GenerateUserID() As String
        Dim newUserID As String = ""
        Dim lastUserID As String = ""

        ' Step 1: Get the last ID from the database
        Dim query As String = "SELECT idUser FROM users ORDER BY idUser DESC LIMIT 1"


        Using cmd = New MySqlCommand(query, conn)
            Try
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    lastUserID = reader("idUser").ToString()
                End If
                reader.Close()
            Catch ex As MySqlException
                MessageBox.Show("Error : " & ex.Message)
            Finally
                'Pastikan koneksi ditutup
                conn.Close()
            End Try
        End Using

        ' Step 2: Generate new ID based on the last Order ID
        If lastUserID = "" Then
            ' If no records found, start with a base ID
            newUserID = "U001"
        Else
            ' Extract the numeric part and increment it
            Dim numericPart As Integer = Integer.Parse(lastUserID.Substring(3)) ' Extracts the number after "ORD"
            numericPart += 1
            newUserID = "U" & numericPart.ToString("D3") ' Formats to ensure 4 digits, e.g., ORD1002
        End If

        Return newUserID
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Masuk_Click(sender As Object, e As EventArgs) Handles Daftar.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Koneksi()
        Dim userId = GenerateUserID()
        cmd = New MySqlCommand("insert into users values (@userId,'" & username.Text & "', '" & password.Text & "','" & email.Text & "')", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Registrasi")
        cmd.Dispose()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles email.TextChanged

    End Sub
End Class
