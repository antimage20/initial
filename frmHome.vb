Imports System.Data
Imports System.Data.SqlClient
Public Class frmHome

    Dim frm1 As frmUser
    Public Sub New(ByVal frm1 As frmUser)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        frm1 = frmUser

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        frmUser.Show()

    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnFrom.Enabled = False
        btnTo.Enabled = False
        dtpFrom.Enabled = False
        dtpTo.Enabled = False
        txtPeople.Enabled = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBook1.Click

        btnBusType.Text = "Regular Bus no Aircon"

        Dim a, b As Double

        a = 50 * txtPeople.Text
        btnTotalpayment.Text = b

        btnTotalpayment.Text = a

        gbxSelectSeats.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnBook2.Click

        btnBusType.Text = "Bus W/ Aircon"

        Dim a, b As Double

        a = 100 * txtPeople.Text
        btnTotalpayment.Text = b

        btnTotalpayment.Text = a

        gbxSelectSeats.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBook3.Click

        btnBusType.Text = "Bus W/ Aircon /Wifi"

        Dim a, b As Double

        a = 150 * txtPeople.Text
        btnTotalpayment.Text = b

        btnTotalpayment.Text = a

        gbxSelectSeats.Show()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs)

        Me.Hide()

    End Sub

    Private Sub cbx1_Click(sender As Object, e As EventArgs) Handles cbx1.Click

        If cbx1.Checked Then
            cbx1.BackColor = BackColor.Red
            cbx1.Enabled = False
        Else
            cbx1.BackColor = BackColor.Green
        End If

    End Sub

End Class