Imports System.Data
Imports System.Data.SqlClient
Public Class Reset
    Dim username As String = frmForgotPassword.toUser
    Private Sub confirm_Click(sender As Object, e As EventArgs) Handles confirm.Click

        Dim con As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=forgotvb;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("UPDATE [dbo].[loginforget]
   SET [username] = '" + username + "'
      ,[password] = '" + TxtNewPass.Text + "'
 WHERE [username] = '" + username + "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("password reseted successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            TxtNewPass.UseSystemPasswordChar = False
        Else
            TxtNewPass.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked Then
            TxtVerPass.UseSystemPasswordChar = False
        Else
            TxtVerPass.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        frmLogin.Show()

    End Sub

    Private Sub Reset_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class