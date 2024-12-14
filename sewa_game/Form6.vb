Imports System.Data.Common
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form6
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
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Koneksi()
        Dim query As String = "SELECT * FROM game"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            dgvGame.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub dgvGame_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGame.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvGame.Rows(e.RowIndex)
            txtID.Text = row.Cells("id").Value.ToString()
            txtNamaGame.Text = row.Cells("name").Value.ToString()
            txtDeskripsi.Text = row.Cells("description").Value.ToString()
            txtHarga.Text = row.Cells("price").Value.ToString()
            txtImagePath.Text = row.Cells("image_path").Value.ToString()

            ' Menampilkan gambar di PictureBox
            If IO.File.Exists(txtImagePath.Text) Then
                pbGameImage.Image = Image.FromFile(txtImagePath.Text)
            Else
                pbGameImage.Image = Nothing
            End If
        End If
    End Sub
    Private Sub btnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            txtImagePath.Text = openFileDialog.FileName
            pbGameImage.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Koneksi()
        Dim query As String = "UPDATE game SET name = @nama, description = @deskripsi, price = @harga, image_path = @image WHERE id = @id"

        Try
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", txtNamaGame.Text)
            cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text)
            cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
            cmd.Parameters.AddWithValue("@image", txtImagePath.Text)
            cmd.Parameters.AddWithValue("@id", txtID.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diperbarui!")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Koneksi()
        Dim query As String = "DELETE FROM game WHERE id = @id"

        Try
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", txtID.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus!")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class