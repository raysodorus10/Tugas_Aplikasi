Public Class frmLogin
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
    Private Sub F_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim SQLTeks As String
        SQLTeks = "SELECT * FROM tb_users WHERE username='" &
        txtUsername.Text & "' AND password='" & txtPassword.Text & "'"
        If (txtUsername.Text = "") Or (txtPassword.Text = "") Then
            MsgBox("Username atau Password masing kosong!", MsgBoxStyle.Critical, "Kesalahan")
            txtUsername.Focus()
            Exit Sub
        End If
        If KoneksiDB.CariData(SQLTeks) Then
            MsgBox("Selamat Bekerja " & txtUsername.Text.ToUpper & "!", MsgBoxStyle.Information, "Welcome")
            Me.Hide()
            F_MainMenu.ShowDialog()
            Me.Close()
        Else
            MsgBox("User atau Password Anda tidak sesuai!", vbCritical, "Error")
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtUsername.Focus()
        End If
    End Sub
End Class