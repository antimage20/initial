Public Class frmPayment

    Dim f2 As frmHome
    Public Sub New(ByVal f2 As frmHome)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        f2 = f2

        txtTicket.Text = f2.btnTotalpayment.Text

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub rbGcash_CheckedChanged(sender As Object, e As EventArgs) Handles rbGcash.CheckedChanged

        If rbGcash.Checked Then
            txtFee.Text = 10.0
        End If

    End Sub

    Private Sub rbPaymaya_CheckedChanged(sender As Object, e As EventArgs) Handles rbPaymaya.CheckedChanged

        If rbPaymaya.Checked Then
            txtFee.Text = 10.0
        End If

    End Sub

    Private Sub rbCounter_CheckedChanged(sender As Object, e As EventArgs) Handles rbCounter.CheckedChanged

        If rbCounter.Checked Then
            txtFee.Text = 0.00
        End If

    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click

        Dim a, b As Double

        a = txtTicket.Text
        b = txtFee.Text

        btnTotal.Text = a + b

    End Sub

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtTicket.Enabled = False
        txtFee.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()
        f2.Show()

    End Sub

End Class