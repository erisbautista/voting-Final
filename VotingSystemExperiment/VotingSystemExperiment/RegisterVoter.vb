Imports MySql.Data.MySqlClient
Public Class RegisterVoter
    Private conn As New MySqlConnection
    Private com As New MySqlCommand
    Private adapt As New MySqlDataAdapter
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ModifyBttn.Click

    End Sub

    Private Sub RegisterBttn_Click(sender As Object, e As EventArgs) Handles RegisterBttn.Click
        RegisterForm.Show()
    End Sub

    Private Sub RegisterVoter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        Try
            conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            conn.Open()
            query = "SELECT `Voter_ID`, `Fname`, `MName`, `Lname` FROM `tbl_voters`"
            com = New MySqlCommand(query, conn)
            adapt.SelectCommand = com
            adapt.Fill(data)
            source.DataSource = data
            DataGridView1.DataSource = source
            adapt.Update(data)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        Try
            conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            conn.Open()
            query = "SELECT `Voter_ID`, `Fname`, `MName`, `Lname` FROM `tbl_voters` where `Voter_ID`='" & TextBox1.Text & "'"
            com = New MySqlCommand(query, conn)
            adapt.SelectCommand = com
            adapt.Fill(Data)
            source.DataSource = Data
            DataGridView1.DataSource = source
            adapt.Update(Data)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim query As String
        Dim data As New DataTable
        Dim source As New BindingSource
        If TextBox1.Text = Nothing Then
            Try
                conn.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
                conn.Open()
                query = "SELECT `Voter_ID`, `Fname`, `MName`, `Lname` FROM `tbl_voters`"
                com = New MySqlCommand(query, conn)
                adapt.SelectCommand = com
                adapt.Fill(data)
                source.DataSource = data
                DataGridView1.DataSource = source
                adapt.Update(data)
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
            End Try
        End If

    End Sub
End Class