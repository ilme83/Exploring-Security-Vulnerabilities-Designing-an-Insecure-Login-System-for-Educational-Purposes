Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form2
    Private users As List(Of Dictionary(Of String, String))

    Public Sub New(ByRef userDatabase As List(Of Dictionary(Of String, String)))
        InitializeComponent()
        Me.users = userDatabase
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim newUsername As String = txtNewUsername.Text
        Dim newPassword As String = txtNewPassword.Text

        users.Add(New Dictionary(Of String, String) From {{"username", newUsername}, {"password", newPassword}})
        MessageBox.Show("Hesap başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub txtNewUsername_TextChanged(sender As Object, e As EventArgs) Handles txtNewUsername.TextChanged

    End Sub
End Class