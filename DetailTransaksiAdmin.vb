Imports MySql.Data.MySqlClient
Imports System.Text

Public Class DetailTransaksiAdmin
    Dim kodeTransaksi As String

    Public Sub New(kode As String)
        InitializeComponent()
        kodeTransaksi = kode
    End Sub

    Private Sub getData()
        Dim query As String = "SELECT * FROM transaksitb JOIN kameras ON transaksitb.kodeKamera=kameras.kodeKamera WHERE id = @id"
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@id", kodeTransaksi)
        Dim reader As MySqlDataReader = CMD.ExecuteReader()
        If reader.Read() Then
            txtKode.Text = reader("kodeKamera").ToString
            txtMerk.Text = reader("merkKamera").ToString
            txtSeri.Text = reader("seriKamera").ToString
            txtPinjam.Text = reader("tanggalPinjam").ToString
            txtKembali.Text = reader("tanggalKembali").ToString
            txtHarga.Text = reader("totalHarga").ToString
        End If
        reader.Close()
    End Sub
    Private Sub DetailTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        koneksi()
        getData()

        txtKode.ReadOnly = True
        txtMerk.ReadOnly = True
        txtSeri.ReadOnly = True
        txtPinjam.ReadOnly = True
        txtKembali.ReadOnly = True
        txtHarga.ReadOnly = True
    End Sub
End Class