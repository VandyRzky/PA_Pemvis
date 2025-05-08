Imports System.Text
Imports MySql.Data.MySqlClient

Public Class SewaKameraUser
    Private userLogin As String
    Public Sub New(nama As String)
        InitializeComponent()
        userLogin = nama
    End Sub
    Sub Kosong()
        txtKode.Clear()
        txtMerk.Clear()
        txtSeri.Clear()
        txtKode.Focus()
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
        DataGridView1.Columns(3).Width = 100
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

    Private Sub btnSewa_Click(sender As Object, e As EventArgs) Handles btnSewa.Click

    End Sub
End Class