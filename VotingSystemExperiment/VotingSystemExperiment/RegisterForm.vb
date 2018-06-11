Imports MySql.Data.MySqlClient
Public Class RegisterForm
    Private query As MySqlCommand
    Private conn As MySqlConnection
    Private READER As MySqlDataReader
    Private comm As MySqlCommand
    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TxtBoxPW.Text = Nothing
        Dim num As Integer
        For z As Integer = 0 To 8
            Randomize()
            num = Int(9 * Rnd())
            TxtBoxPW.Text = TxtBoxPW.Text & num
        Next
    End Sub

    Private Sub BttnProceed_Click(sender As Object, e As EventArgs) Handles BttnProceed.Click
        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Try
            con.ConnectionString = "server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO `tbl_voters`( `Voter_ID`, `Fname`, `MName`, `Lname`, `PASSWORD`) 
                                VALUES ('" & TxtBoxVID.Text & " ', '" & TxtBoxFN.Text & "', '" & TxtBoxMN.Text & "' , '" & TxtBoxLN.Text & "', '" & TxtBoxPW.Text & "')"
            MsgBox("Please Remember The ID and PASSWORD this will be used to login to the system:
                    ID =" & TxtBoxVID.Text & " 
                    Password = " & TxtBoxPW.Text & "")
            cmd.ExecuteNonQuery()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try
    End Sub
End Class