Imports System.Data.SqlClient
Public Class frmUser

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)

        Me.Hide()
        frmLogin.Show()

    End Sub

    Private Sub btnBookNow_Click(sender As Object, e As EventArgs)

        Dim frmHome As New frmHome(Me)
        frmHome.ShowDialog()
        Me.Hide()

    End Sub

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RECSDataSet.RECSADS' table. You can move, or remove it, as needed.
        Me.RECSADSTableAdapter.Fill(Me.RECSDataSet.RECSADS)

        'TODO: This line of code loads data into the 'AdminrecordDataSet.adminrecords' table. You can move, or remove it, as needed.
        Me.AdminrecordsTableAdapter.Fill(Me.AdminrecordDataSet.adminrecords)

    End Sub

    Private Sub btnBookNow_Click_1(sender As Object, e As EventArgs) Handles btnBookNow.Click

        Dim Oneway As String = rbOneWay.Checked
        Dim Roundtrip As String = rbRoundTrip.Checked
        Dim From As String = cbxFrom.SelectedItem
        Dim tos As String = cbxTo.SelectedItem
        Dim Depart As String = dtpDepart.Value
        Dim Returns As String = dtpReturn.Value
        Dim People As String = cbxPeople.SelectedItem

        Dim query As String = "INSERT INTO RECSADS VALUES (@OneWay, @RoundTrip, @_From, @_To, @DepartDate, @ReturnDate, @People)"
        Using con As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RECS;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@OneWay", Oneway)
                cmd.Parameters.AddWithValue("@RoundTrip", Roundtrip)
                cmd.Parameters.AddWithValue("@_From", From)
                cmd.Parameters.AddWithValue("@_To", tos)
                cmd.Parameters.AddWithValue("@DepartDate", Depart)
                cmd.Parameters.AddWithValue("@ReturnDate", Returns)
                cmd.Parameters.AddWithValue("@People", People)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Data Save!")
                BindData()


            End Using

        End Using

    End Sub

    Public Sub BindData()
        Dim query As String = "SELECT * FROM RESCSADS"
        Using con As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RECS;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
            Dim temp As Integer = 0
            For i As Integer = 0 To DataGridView1.RowCount - 1
                For j As Integer = 0 To DataGridView1.ColumnCount - 1
                    If DataGridView1.Rows(i).Cells(j).Value.ToString = txtSearch.Text Then
                        MessageBox.Show("Record found")
                        temp = 1
                    End If

                Next
            Next
            If temp = 0 Then
                MessageBox.Show("Record not found")
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Dim query As String = "SELECT * FROM RECSADS WHERE OnewWay LIKE '%" & txtSearch.Text & "%' OR RoundTrip LIKE '%" & txtSearch.Text & "%'"
        Using con As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RECS;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As SqlDataAdapter = New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            DataGridView1.DataSource = dt
                        Else
                            MessageBox.Show("No record found!")
                        End If
                    End Using
                End Using
            End Using
        End Using

    End Sub
End Class