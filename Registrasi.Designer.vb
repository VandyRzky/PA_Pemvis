<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrasi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnRegistrasi = New Button()
        txtPasswordRegis = New TextBox()
        txtUsernameRegis = New TextBox()
        lblLogin = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnRegistrasi
        ' 
        btnRegistrasi.Location = New Point(150, 295)
        btnRegistrasi.Name = "btnRegistrasi"
        btnRegistrasi.Size = New Size(94, 29)
        btnRegistrasi.TabIndex = 13
        btnRegistrasi.Text = "Registrasi"
        btnRegistrasi.UseVisualStyleBackColor = True
        ' 
        ' txtPasswordRegis
        ' 
        txtPasswordRegis.Location = New Point(128, 187)
        txtPasswordRegis.Name = "txtPasswordRegis"
        txtPasswordRegis.Size = New Size(231, 27)
        txtPasswordRegis.TabIndex = 12
        ' 
        ' txtUsernameRegis
        ' 
        txtUsernameRegis.Location = New Point(128, 110)
        txtUsernameRegis.Name = "txtUsernameRegis"
        txtUsernameRegis.Size = New Size(231, 27)
        txtUsernameRegis.TabIndex = 11
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Location = New Point(113, 327)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(170, 20)
        lblLogin.TabIndex = 10
        lblLogin.Text = "Sudah punya akun?login"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 9
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 8
        Label2.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(181, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 20)
        Label1.TabIndex = 7
        Label1.Text = "Registrasi"
        ' 
        ' Registrasi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(389, 393)
        Controls.Add(btnRegistrasi)
        Controls.Add(txtPasswordRegis)
        Controls.Add(txtUsernameRegis)
        Controls.Add(lblLogin)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Registrasi"
        Text = "Registrasi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRegistrasi As Button
    Friend WithEvents txtPasswordRegis As TextBox
    Friend WithEvents txtUsernameRegis As TextBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
