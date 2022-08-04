Imports System.Data.OleDb
Imports System.Data
Public Class Login
    Dim connection As New OleDbConnection(My.Settings.dataEmployee1ConnectionString)

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
            MsgBox("Enter Credentials ", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("select count(*) from login where username=? and password=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtUsername.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtPassword.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                MsgBox("Login succeed", MsgBoxStyle.Information)
                Me.Hide()
                MenuApplication.Show()
            Else
                MsgBox("Account not found check credentials", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub lblSign_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSign.LinkClicked
        UserRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub picShow_Click(sender As Object, e As EventArgs) Handles picShow.Click
        Me.txtPassword.PasswordChar = ""
    End Sub

End Class