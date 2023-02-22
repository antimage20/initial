Imports System.Net
Imports System.Net.Mail
Public Class frmForgotPassword
    Dim randomCode As String
    Public Shared toUser As String
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        If (TxtVerify.Text.Equals(randomCode)) Then
            Dim Reset As Reset = New Reset
            Reset.Show()
            Dim hm As frmForgotPassword = New frmForgotPassword
            hm.Hide()
        Else
            MessageBox.Show("wrong code")

        End If

    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click

        Try
            Dim from, pass, messageBody As String
            Dim rand As Random = New Random()
            randomCode = (rand.Next(999999)).ToString
            Dim message As MailMessage = New MailMessage
            toUser = TxtEmailPhone.Text
            from = "jamesdignos20@gmail.com"
            pass = "jsgnrimlaiozfqck"
            messageBody = "your verification code is " + randomCode
            message.To.Add(toUser)
            message.From = New MailAddress(from)
            message.Body = messageBody
            message.Subject = "password resetting code"

            Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
            smtp.EnableSsl = True
            smtp.Port = 587
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network
            smtp.Credentials = New NetworkCredential(from, pass)



            smtp.Send(message)
            MessageBox.Show("Please check your email and copy the code")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()
        frmLogin.Show()

    End Sub

    Private Sub frmForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class