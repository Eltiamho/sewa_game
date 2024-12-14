Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports MySqlConnector
Imports Mysqlx.Crud
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles
Public Class report
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
    Private dataSet As DataSet
    Private dataAdapter As MySqlDataAdapter
    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim email As String
    '    email = TextBox1.Text
    '    Dim dt As New DataTable()
    '    Koneksi()
    '    Dim query As String = "
    '        SELECT 
    '            t.kode_transaksi, 
    '            g.id, 
    '            g.name, 
    '            t.email_user, 
    '            t.lama_penyewaan, 
    '            g.price,
    '            t.harga_total, 
    '            t.tanggal
    '        FROM 
    '            transaksi_sewa t
    '        INNER JOIN 
    '            game g ON g.id = t.id_game

    '        WHERE 
    '            t.email_user = @email;"
    '    Using cmd As New MySqlCommand(query, conn)
    '        cmd.Parameters.AddWithValue("@email", email)
    '        Dim adapter As New MySqlDataAdapter(cmd)
    '        adapter.Fill(dt)
    '    End Using

    '    ' Check if data exists
    '    If dt.Rows.Count = 0 Then
    '        MessageBox.Show("No data found for the given email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Return
    '    End If

    '    ' Bind data to the ReportViewer
    '    Dim rds As New ReportDataSource("DataSet1", dt)
    '    ReportViewer1.LocalReport.DataSources.Clear()
    '    ReportViewer1.LocalReport.DataSources.Add(rds)

    '    ' Refresh the ReportViewer
    '    ReportViewer1.RefreshReport()
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String = TextBox1.Text.Trim()
        If String.IsNullOrWhiteSpace(email) Then
            MessageBox.Show("Email tidak boleh kosong.")
            Return
        End If

        Dim dt As New DataTable()
        Try
            Koneksi()
            Dim query As String = "
            SELECT 
                t.kode_transaksi, 
                g.id, 
                g.name, 
                t.email_user, 
                t.lama_penyewaan, 
                g.price,
                t.harga_total, 
                t.tanggal
            FROM 
                transaksi_sewa t
            INNER JOIN 
                game g ON g.id = t.id_game
            WHERE 
                t.email_user = @email;"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@email", email)
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using

            If dt.Rows.Count = 0 Then
                MessageBox.Show("Tidak ada data untuk email ini.")
                Return
            End If

            Dim rds As New ReportDataSource("DataSet1", dt)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim email As String = TextBox1.Text.Trim()
        If String.IsNullOrWhiteSpace(email) Then
            MessageBox.Show("Email tidak boleh kosong.")
            Return
        End If

        Dim dt As New DataTable()
        Try
            Koneksi()

            ' Membuat query dasar tanpa filter status
            Dim query As String = "
    SELECT 
        t.kode_transaksi, 
        g.id, 
        g.name, 
        t.email_user, 
        t.lama_penyewaan, 
        g.price,
        t.harga_total, 
        t.tanggal
        CASE 
            WHEN t.status = 1 THEN 'Sudah Dibayar'
            WHEN t.status = 0 THEN 'Belum Dibayar'
            ELSE 'Tidak Diketahui'
        END AS status
    FROM 
        transaksi_sewa t
    INNER JOIN 
        game g ON g.id = t.id_game
    WHERE 
        t.email_user = @email"

            ' Jika CheckBoxStatus dicentang, tambahkan filter untuk status 1
            If CheckBox1.Checked Then
                query &= " AND t.status = 1"
            End If

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@email", email)
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using

            If dt.Rows.Count = 0 Then
                MessageBox.Show("Tidak ada data untuk email ini.")
                Return
            End If

            Dim rds As New ReportDataSource("DataSet1", dt)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

    End Sub
End Class