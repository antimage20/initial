Imports System.Data
Imports System.Data.SqlClient

Public Class FrmRegister
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=userregvb;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[userreg]
           ([name]
           ,[email]
           ,[password])
     VALUES
           ('" + TxtName.Text + "', '" + TxtEmail.Text + "', '" + TxtPassword.Text + "')", con)
        con.Open()
        cmd.ExecuteNonQuery()

        MessageBox.Show("You have register successfully!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        frmLogin.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Hide()
        frmLogin.Show()


    End Sub
End Class