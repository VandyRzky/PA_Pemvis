Imports MySql.Data.MySqlClient
Imports System.Text

Public Class Registrasi
    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Form1.Show()

        Me.Close()
    End Sub

    Private Sub Registrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        koneksi()
        txtUsernameRegis.MaxLength = 15
        txtPasswordRegis.MaxLength = 8
    End Sub

    Private Function loginAdmin()
        If txtUsernameRegis.Text = "admin" Then
            Return True
        End If
        Return False
    End Function

    Private Sub btnRegistrasi_Click(sender As Object, e As EventArgs) Handles btnRegistrasi.Click
        If txtUsernameRegis.Text = Nothing Or txtPasswordRegis.Text = Nothing Then
            MsgBox("Data belum lengkap")
            txtUsernameRegis.Focus()
        ElseIf loginAdmin Then
            MsgBox("Username sudah terpakai")
            txtUsernameRegis.Focus()
        Else
            CMD = New MySqlCommand("SELECT * FROM users WHERE username = @username", CONN)
            CMD.Parameters.AddWithValue("@username", txtUsernameRegis.Text)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("INSERT INTO users (username, password) VALUES (@username, @password)", CONN)
                CMD.Parameters.AddWithValue("@username", txtUsernameRegis.Text)
                CMD.Parameters.AddWithValue("@password", txtPasswordRegis.Text)
                CMD.ExecuteNonQuery()

                MsgBox("Registrasi berhasil!", MsgBoxStyle.Information)
                Me.Close()

                Form1.Show()

            Else
                RD.Close()
                MsgBox("Username sudah dipakai")
                txtUsernameRegis.Focus()
            End If
        End If
    End Sub
End Class