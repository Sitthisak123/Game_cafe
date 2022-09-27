Imports System.Data.SqlClient
Public Class Form_login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_submit.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=344_05\SQLEXPRESS;Initial Catalog=game_cafe;Integrated Security=True")
        Dim Cmd As SqlCommand = New SqlCommand("SELECT * FROM dbo.customers WHERE cus_username = '" & tb_username.Text & "' AND cus_password = '" & tb_password.Text & "'", conn)
        Dim adap As SqlDataAdapter = New SqlDataAdapter(Cmd)
        Dim data As DataTable = New DataTable()
        adap.Fill(data)
        If data.Rows.Count > 0 Then
            Form_main.Show()
            Me.Hide()
        Else

        End If
    End Sub

    Private Sub Form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_username.Select()
    End Sub

    Private Sub tb_password_TextChanged(sender As Object, e As EventArgs) Handles tb_password.TextChanged, tb_username.TextChanged
        If tb_password.Text.Trim() <> "" And tb_username.Text.Trim() <> "" Then
            bt_submit.Enabled = True
        Else
            bt_submit.Enabled = False
        End If
    End Sub
End Class
