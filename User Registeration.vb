Imports System.Data.OleDb
Public Class UserRegistration
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub UserRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataEmployee1DataSet1.login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.DataEmployee1DataSet1.login)

    End Sub

    Private Sub pctBack_Click(sender As Object, e As EventArgs) Handles pctBack.Click
        Me.Hide()
        Login.Show()

        txtConfirm.Text = ""
        txtEmail.Text = ""
        txtName.Text = ""
        txtPassword.Text = ""
        txtPhone.Text = ""
        txtStaff.Text = ""
        txtUsername.Text = ""
    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data source = D:\SINGAPORE PAKAGE (GROUP PROJECT)\SINGAPORE PAKAGES\dataEmployee1.accdb"
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "update Login set  [USERNAME]='" & txtUsername.Text & "', [PASSWORD]='" & txtPassword.Text & "', [STAFF NAME]='" & txtName.Text &
                  "', [NO PHONE]='" & txtPhone.Text & "', [EMAIL]='" & txtEmail.Text & "' where [STAFF ID]=" & txtStaff.Text & ""

        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        MsgBox("Update Success")

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data source = D:\SINGAPORE PAKAGE (GROUP PROJECT)\SINGAPORE PAKAGES\dataEmployee1.accdb"
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()

        Dim deleteID As String
        deleteID = InputBox("Enter staff id to be delete")

        command = "Delete from [Login] where [STAFF ID]=" & deleteID & ""

        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        MsgBox("Record Delete Success")

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txtConfirm.Text = ""
        txtEmail.Text = ""
        txtName.Text = ""
        txtPassword.Text = ""
        txtPhone.Text = ""
        txtStaff.Text = ""
        txtUsername.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtConfirm.Text <> txtPassword.Text Then
            MsgBox("Enter password input correctly!", MsgBoxStyle.Exclamation)
        Else
            pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data source = D:\SINGAPORE PAKAGE (GROUP PROJECT)\SINGAPORE PAKAGES\dataEmployee1.accdb"
            connstring = pro
            myconnection.ConnectionString = connstring
            myconnection.Open()

            command = " insert into Login ([STAFF ID],[USERNAME],[PASSWORD],[STAFF NAME],[NO PHONE],[EMAIL]) values (?,?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
            cmd.Parameters.Add(New OleDbParameter("STAFF ID", CType(txtStaff.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("USERNAME", CType(txtUsername.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PASSWORD", CType(txtPassword.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("STAFF NAME", CType(txtName.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("NO PHONE", CType(txtPhone.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("EMAIL", CType(txtEmail.Text, String)))
            MsgBox("Record save succeed!")

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myconnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Me.Hide()
            Login.Show()

            txtConfirm.Text = ""
            txtEmail.Text = ""
            txtName.Text = ""
            txtPassword.Text = ""
            txtPhone.Text = ""
            txtStaff.Text = ""
            txtUsername.Text = ""
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.LoginBindingSource.MoveNext()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Me.LoginBindingSource.MoveFirst()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Me.LoginBindingSource.MoveLast()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.LoginBindingSource.MovePrevious()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Me.txtPassword.PasswordChar = ""
        Me.txtConfirm.PasswordChar = ""
    End Sub
End Class
