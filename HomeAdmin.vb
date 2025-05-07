Imports System.Text
Imports MySql.Data.MySqlClient

Public Class HomeAdmin
    Sub Kosong()
        txtKode.Clear()
        txtMerk.Clear()
        txtSeri.Clear()
        txtHarga.Clear()
        txtKode.Focus()
    End Sub

    Sub tampilJenis()
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If

        Dim query As String = "SELECT * FROM kameras"
        DA = New MySqlDataAdapter(query, CONN)

        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "merkKamera")
        DataGridView1.DataSource = DS.Tables("merkKamera")
        DataGridView1.Refresh()
    End Sub

    Sub aturGrid()
        DataGridView1.Columns(0).Width = 83
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 150
        DataGridView1.Columns(0).HeaderText = "Kode Kamera"
        DataGridView1.Columns(1).HeaderText = "Merk Kamera"
        DataGridView1.Columns(2).HeaderText = "Seri Kamera"
        DataGridView1.Columns(3).HeaderText = "Harga"
        DataGridView1.Columns(4).HeaderText = "Penyewa"

    End Sub

    Private Sub HomeAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        koneksi()
        tampilJenis()
        Kosong()
        aturGrid()

        txtKode.MaxLength = 5
        txtMerk.MaxLength = 50
        txtSeri.MaxLength = 50
        txtHarga.MaxLength = 10
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtKode.Text = row.Cells(0).Value.ToString()
            txtMerk.Text = row.Cells(1).Value.ToString()
            txtSeri.Text = row.Cells(2).Value.ToString()
            txtHarga.Text = row.Cells(3).Value.ToString
            txtPenyewa.Text = row.Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtSeri.Text = Nothing Or txtKode.Text = Nothing Or txtMerk.Text = Nothing Then
            MsgBox("Data belum lengkap")
            txtKode.Focus()
        Else
            CMD = New MySqlCommand("SELECT * FROM kameras WHERE kodeKamera = @kode", CONN)
            CMD.Parameters.AddWithValue("@kode", txtKode.Text)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("INSERT INTO kameras (kodeKamera, merkKamera, seriKamera, harga) VALUES (@kode, @merk, @seri, @harga)", CONN)
                CMD.Parameters.AddWithValue("@kode", txtKode.Text)
                CMD.Parameters.AddWithValue("@merk", txtMerk.Text)
                CMD.Parameters.AddWithValue("@seri", txtSeri.Text)
                CMD.Parameters.AddWithValue("@harga", txtHarga.Text)
                CMD.ExecuteNonQuery()
                tampilJenis()
                Kosong()
                MsgBox("Simpan Data Sukses!", MsgBoxStyle.Information)
            Else
                RD.Close()
                MsgBox("Data Tersebut Sudah Ada")
            End If
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtSeri.Text = Nothing Or txtKode.Text = Nothing Or txtMerk.Text = Nothing Then
            MsgBox("Data belum lengkap")
            txtKode.Focus()
            Return
        End If
        If txtKode.Text = Nothing Then
            MsgBox("Data belum dipilih")
            txtKode.Focus()
        Else
            CMD = New MySqlCommand("SELECT * FROM kameras WHERE kodeKamera = @kode", CONN)
            CMD.Parameters.AddWithValue("@kode", txtKode.Text)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                If Not IsDBNull(RD("username")) Then
                    RD.Close()
                    MsgBox("Data tidak dapat diubah karena sudah terkait dengan user.")
                    Return
                End If
                RD.Close()
                CMD = New MySqlCommand("UPDATE kameras SET merkKamera = @merk, seriKamera = @seri, harga = @harga WHERE kodeKamera = @kode", CONN)
                CMD.Parameters.AddWithValue("@kode", txtKode.Text)
                CMD.Parameters.AddWithValue("@merk", txtMerk.Text)
                CMD.Parameters.AddWithValue("@seri", txtSeri.Text)
                CMD.Parameters.AddWithValue("@harga", txtHarga.Text)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil diubah")
                tampilJenis()
                Kosong()
            Else
                RD.Close()
                MsgBox("Data tidak ada")
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKode.Text = Nothing Then
            MsgBox("Data belum dipilih")
            txtKode.Focus()
        Else
            CMD = New MySqlCommand("SELECT * FROM kameras WHERE kodeKamera = @kode", CONN)
            CMD.Parameters.AddWithValue("@kode", txtKode.Text)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                If Not IsDBNull(RD("username")) Then
                    RD.Close()
                    MsgBox("Data tidak dapat dihapus karena sudah terkait dengan user.")
                    Return
                End If
                RD.Close()
                CMD = New MySqlCommand("DELETE FROM kameras WHERE kodeKamera = @kode", CONN)
                CMD.Parameters.AddWithValue("@kode", txtKode.Text)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus")
                tampilJenis()
                Kosong()
            Else
                RD.Close()
                MsgBox("Data tidak ada")
            End If
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class