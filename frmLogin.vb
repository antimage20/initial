Imports System.Data
Imports System.Data.SqlClient
Public Class frmLogin

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        Dim con As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=forgotvb;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from loginforget where username = '" + TxtUsername.Text + "'and password= '" + TxtPassword.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Login Success")
            Me.Hide()
            frmUser.Show()
        Else
            MessageBox.Show("Wrong username or password!")
            frmUser.Hide()
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnClose.Click

        Application.Exit()

    End Sub

    Private Sub BtnForgorPassword_Click(sender As Object, e As EventArgs) Handles BtnForgorPassword.Click

        Dim hm As frmForgotPassword = New frmForgotPassword
        hm.Show()
        Dim f As frmLogin = New frmLogin
        f.Hide()

    End Sub

    Private Sub CbxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CbxShowPassword.CheckedChanged

        If CbxShowPassword.Checked Then
            TxtPassword.UseSystemPasswordChar = False
        Else
            TxtPassword.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub BtnCreatAcc_Click(sender As Object, e As EventArgs) 

        Me.Hide()
        FrmRegister.Show()

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
