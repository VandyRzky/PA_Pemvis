Imports System.Drawing.Printing
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class SewaKameraUser
    Private userLogin As String
    Dim kodeKamera As String
    Dim merkKamera As String
    Dim seriKamera As String
    Dim tanggalAwal As Date
    Dim tanggalAkhir As Date
    Dim totalHarga As Integer

    Public Sub New(nama As String)
        InitializeComponent()
        userLogin = nama
    End Sub
    Sub Kosong()
        txtKode.Clear()
        txtMerk.Clear()
        txtSeri.Clear()
        txtHarga.Clear()
    End Sub

    Sub tampilJenis()
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If

        Dim query As String = "SELECT * FROM kameras WHERE username IS NULL"
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
        DataGridView1.Columns(3).Width = 150
        DataGridView1.Columns(4).Width = 150
        DataGridView1.Columns(0).HeaderText = "Kode Kamera"
        DataGridView1.Columns(1).HeaderText = "Merk Kamera"
        DataGridView1.Columns(2).HeaderText = "Seri Kamera"
        DataGridView1.Columns(3).HeaderText = "Harga"
        DataGridView1.Columns(4).HeaderText = "Penyewa"
    End Sub

    Private Sub SewaKameraUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        koneksi()
        tampilJenis()
        Kosong()
        aturGrid()

        txtKode.ReadOnly = True
        txtMerk.ReadOnly = True
        txtSeri.ReadOnly = True
        txtHarga.ReadOnly = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtKode.Text = row.Cells(0).Value.ToString()
            txtMerk.Text = row.Cells(1).Value.ToString()
            txtSeri.Text = row.Cells(2).Value.ToString()
            txtHarga.Text = row.Cells(3).Value.ToString()
        End If
    End Sub

    Function cekInput()
        If txtKode.Text = Nothing Or txtMerk.Text = Nothing Or txtSeri.Text = Nothing Or txtHarga.Text = Nothing Then
            Return True
        End If
        Return False
    End Function

    Private Sub btnSewa_Click(sender As Object, e As EventArgs) Handles btnSewa.Click
        If cekInput() Then
            MsgBox("Pilih kamera dahulu")
            Return
        End If
        kodeKamera = txtKode.Text
        merkKamera = txtMerk.Text
        seriKamera = txtSeri.Text
        Dim hargaKamera As Integer = txtHarga.Text

        tanggalAwal = dtpPinjam.Value.Date
        tanggalAkhir = dtpKembali.Value.Date

        Dim selisihHari As TimeSpan = tanggalAkhir - tanggalAwal
        Dim jumlahHari As Integer = selisihHari.Days

        jumlahHari += 1

        If jumlahHari <= 0 Then
            MsgBox("Tanggal tidak boleh negatif")
            Return
        End If

        totalHarga = jumlahHari * hargaKamera

        Dim konfirmasi As New InvoiceForm(kodeKamera, seriKamera, merkKamera, tanggalAwal, tanggalAkhir, totalHarga)

        'konfirmasi.Show()
        If konfirmasi.ShowDialog() = DialogResult.OK Then
            Dim ukuranStruk As New PaperSize("Struk", 300, 600) ' lebar 3 inch, tinggi 6 inch
            Dim marginKiri As Integer = 10
            Dim marginKanan As Integer = 10
            Dim marginAtas As Integer = 10
            Dim marginBawah As Integer = 10

            PrintDocument1.DefaultPageSettings.PaperSize = ukuranStruk
            PrintDocument1.DefaultPageSettings.Margins = New Margins(marginKiri, marginKanan, marginAtas, marginBawah)
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
            SewaKamera()
        End If
    End Sub

    Private Sub SewaKamera()
        CMD = New MySqlCommand("INSERT INTO transaksitb (tanggalPinjam, tanggalKembali, totalHarga, statusSewa, kodeKamera, username) VALUES (@pinjam, @kembali, @harga, @status, @kode, @username)", CONN)
        CMD.Parameters.AddWithValue("@pinjam", tanggalAwal)
        CMD.Parameters.AddWithValue("@kembali", tanggalAkhir)
        CMD.Parameters.AddWithValue("@harga", totalHarga)
        CMD.Parameters.AddWithValue("@status", "Disewa")
        CMD.Parameters.AddWithValue("@kode", kodeKamera)
        CMD.Parameters.AddWithValue("@username", userLogin)
        CMD.ExecuteNonQuery()
        CMD = New MySqlCommand("UPDATE kameras SET username = @username WHERE kodeKamera = @kode", CONN)
        CMD.Parameters.AddWithValue("@username", userLogin)
        CMD.Parameters.AddWithValue("@kode", kodeKamera)
        CMD.ExecuteNonQuery()
        tampilJenis()
        Kosong()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontJudul As New Font("Arial", 14, FontStyle.Bold)
        Dim fontIsi As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)

        Dim x As Integer = e.MarginBounds.Left
        Dim y As Integer = e.MarginBounds.Top


        e.Graphics.DrawString("Bukti Penyewaan Kamera", fontJudul, brush, x, y)
        y += 40

        e.Graphics.DrawString("Kode Kamera     : " & kodeKamera, fontIsi, brush, x, y)
        y += 25
        e.Graphics.DrawString("Merk Kamera     : " & merkKamera, fontIsi, brush, x, y)
        y += 25
        e.Graphics.DrawString("Seri Kamera     : " & seriKamera, fontIsi, brush, x, y)
        y += 25


        e.Graphics.DrawString("Tanggal Pinjam  : " & tanggalAwal.ToShortDateString(), fontIsi, brush, x, y)
        y += 25
        e.Graphics.DrawString("Tanggal Kembali : " & tanggalAkhir.ToShortDateString(), fontIsi, brush, x, y)
        y += 25

        e.Graphics.DrawString("Harga per Hari  : Rp " & totalHarga.ToString("N0"), fontIsi, brush, x, y)
    End Sub


End Class