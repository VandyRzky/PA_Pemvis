﻿Imports System.Text
Imports MySql.Data.MySqlClient

Public Class DetailTransaksi
    Dim kodeTransaksi As String
    Dim kodeKamera As String
    Public Property ReturnValue As Boolean

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
            If reader("statusSewa").ToString = "Selesai" Then
                btnKembali.Enabled = False
                btnKembali.Visible = False
            End If
            kodeKamera = reader("kodeKamera").ToString
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

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        CMD = New MySqlCommand("UPDATE kameras SET username = @username WHERE kodeKamera = @kode", CONN)
        CMD.Parameters.AddWithValue("@username", DBNull.Value)
        CMD.Parameters.AddWithValue("@kode", kodeKamera)
        CMD.ExecuteNonQuery()
        CMD = New MySqlCommand("UPDATE transaksitb SET statusSewa = @status WHERE id = @id", CONN)
        CMD.Parameters.AddWithValue("@status", "Selesai")
        CMD.Parameters.AddWithValue("@id", kodeTransaksi)
        CMD.ExecuteNonQuery()

        MessageBox.Show("Kamera berhasil dikembalikan.")

        ReturnValue = True
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class