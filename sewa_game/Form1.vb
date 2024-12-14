Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports MyApp.Models
Imports sewa_game.MyApp.Models


Public Class LoginForm
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand

    'Dim form4 As New Form4(TextBox1.Text)

    Public Shared mail As String

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


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Masuk_Click(sender As Object, e As EventArgs) Handles Daftar.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click


        mail = TextBox1.Text


        If TextBox2.Text.Length < 8 Then
            MessageBox.Show("Password harus minimal 8 karakter.")
            Return
        End If

        Koneksi()
        Try
            Dim query As String = "SELECT * FROM users WHERE Email = @Username AND password = @Password"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Username", TextBox1.Text)
            cmd.Parameters.AddWithValue("@Password", TextBox2.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                MessageBox.Show("Login berhasil!")
                ' Tambahkan logika untuk melanjutkan ke halaman berikutnya
                Me.Hide() ' Sembunyikan form login
                Form2.Show()
            Else
                MessageBox.Show("Username atau password salah!")
            End If
            reader.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error : " & ex.Message)
        Finally
            conn.Close()
            report.Show()

            'formTujuan.UserData = TextBox1.Text ' Mengirim data dari TextBox
            'formTujuan.Show()

        End Try
    End Sub
    Private Sub ShowPassword_CheckedChanged_1(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.Checked Then
            TextBox2.UseSystemPasswordChar = False ' Tampilkan password
        Else
            TextBox2.UseSystemPasswordChar = True ' Sembunyikan password
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True ' Sembunyikan password secara default
        password.UseSystemPasswordChar = True
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If password.Text.Length < 8 Then
            MessageBox.Show("Password harus minimal 8 karakter.")
            Return
        End If
        Koneksi()
        cmd = New MySqlCommand("insert into users values ('" & username.Text & "', '" & password.Text & "','" & email.Text & "')", conn)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Registrasi. Silahkan pergi ke menu Masuk!")
            ' Clear TextBox setelah berhasil registrasi
            username.Text = ""
            password.Text = ""
            email.Text = ""
        Catch ex As MySqlException
            MessageBox.Show("Error : " & ex.Message)
        Finally
            ' Tutup koneksi setelah eksekusi selesai
            conn.Close()
        End Try
        cmd.Dispose()
        'cmd.ExecuteNonQuery()
        'MsgBox("Berhasil Registrasi")
        'cmd.Dispose()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles email.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            password.UseSystemPasswordChar = False ' Tampilkan password
        Else
            password.UseSystemPasswordChar = True ' Sembunyikan password
        End If
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim useNameAdmin As String = "admin"
        Dim pw As String = "admin123"
        If useNameAdmin = TextBox1.Text And pw = TextBox2.Text Then

            Form6.Show()


            MessageBox.Show("Username / password salah")
        End If


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Form6.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Form6.Show()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    'sembunyikan password


End Class
