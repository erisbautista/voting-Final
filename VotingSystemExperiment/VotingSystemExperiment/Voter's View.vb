Imports MySql.Data.MySqlClient
Public Class VotingView
    Private conn As New MySqlConnection
    Private read As MySqlDataReader
    Private sql As String
    Private adapts As New MySqlDataAdapter
    Private com As New MySqlCommand
    Public val As Integer
    Public val2 As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=127.0.0.1; user=root; database=wbvoting; port=3306; SslMode=none")
        Try
            conn.Open()
            FillComboBox()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub FillComboBox()
        Combo(1, President)
        Combo(2, VicePresident)
        Combo(3, Secretary)
        Combo(4, Treasurer)
        Combo(5, Auditor)
        Combo(6, PIO)
        Combo(6, PIO2)
        Combo(7, PeaceOfficer)
        Combo(7, PeaceOfficer2)
        Combo(8, G8Rep)
        Combo(8, G8Rep2)
        Combo(9, G9Rep)
        Combo(9, G9Rep2)
        Combo(10, G10Rep)
        Combo(10, G10Rep2)
        Combo(11, G11Rep)
        Combo(11, G11Rep2)
        Combo(12, G12Rep)
        Combo(12, G12Rep2)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles President.SelectedIndexChanged
        getIm(Pic_president, President)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VicePresident.SelectedIndexChanged
        getIm(Pic_VicePresident, VicePresident)
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Secretary.SelectedIndexChanged
        getIm(Pic_Secretary, Secretary)
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Treasurer.SelectedIndexChanged
        getIm(Pic_Treasure, Treasurer)
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Auditor.SelectedIndexChanged
        getIm(Pic_Auditor, Auditor)
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PIO.SelectedIndexChanged
        getIm(Pic_PIO, PIO)
        PIO2.Items.Clear()
        Combo(6, PIO2)
        If PIO2.Items.Contains(PIO.Text) Then
            PIO2.Items.Remove(PIO.Text)
        End If
    End Sub
    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PIO2.SelectedIndexChanged
        getIm(Pic_PIO2, PIO2)
        PIO.Items.Clear()
        Combo(6, PIO)
        If PIO.Items.Contains(PIO2.Text) Then
            PIO.Items.Remove(PIO2.Text)
        End If
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PeaceOfficer.SelectedIndexChanged
        getIm(Pic_PO, PeaceOfficer)
        PeaceOfficer2.Items.Clear()
        Combo(7, PeaceOfficer2)
        If PeaceOfficer2.Items.Contains(PeaceOfficer.Text) Then
            PeaceOfficer2.Items.Remove(PeaceOfficer.Text)
        End If
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PeaceOfficer2.SelectedIndexChanged
        getIm(Pic_PO2, PeaceOfficer2)
        PeaceOfficer.Items.Clear()
        Combo(7, PeaceOfficer)
        If PeaceOfficer.Items.Contains(PeaceOfficer2.Text) Then
            PeaceOfficer.Items.Remove(PeaceOfficer2.Text)
        End If
    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles G8Rep.SelectedIndexChanged
        getIm(Pic_G8R, G8Rep)
        G8Rep2.Items.Clear()
        Combo(8, G8Rep2)
        If G8Rep2.Items.Contains(G8Rep.Text) Then
            G8Rep2.Items.Remove(G8Rep.Text)
        End If
    End Sub

    Private Sub ComboBox11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles G8Rep2.SelectedIndexChanged
        getIm(Pic_G8R2, G8Rep2)
        G8Rep.Items.Clear()
        Combo(8, G8Rep)
        If G8Rep.Items.Contains(G8Rep2.Text) Then
            G8Rep.Items.Remove(G8Rep2.Text)
        End If
    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles G9Rep.SelectedIndexChanged
        getIm(Pic_G9R, G9Rep)
        G9Rep2.Items.Clear()
        Combo(9, G9Rep2)
        If G9Rep2.Items.Contains(G9Rep.Text) Then
            G9Rep2.Items.Remove(G9Rep.Text)
        End If
    End Sub

    Private Sub ComboBox15_SelectedIndexChanged(sender As Object, e As EventArgs) Handles G9Rep2.SelectedIndexChanged
        getIm(Pic_G9R2, G9Rep2)
        G9Rep.Items.Clear()
        Combo(9, G9Rep)
        If G9Rep.Items.Contains(G9Rep2.Text) Then
            G9Rep.Items.Remove(G9Rep2.Text)
        End If
    End Sub

    Private Sub ComboBox16_SelectedIndexChanged(sender As Object, e As EventArgs) Handles G10Rep.SelectedIndexChanged
        getIm(Pic_G10R, G10Rep)
        G10Rep2.Items.Clear()
        Combo(10, G10Rep2)
        If G10Rep2.Items.Contains(G10Rep.Text) Then
            G10Rep2.Items.Remove(G10Rep.Text)
        End If
    End Sub

    Private Sub ComboBox13_SelectedIndexChanged(sender As Object, e As EventArgs) Handles G10Rep2.SelectedIndexChanged
        getIm(Pic_G10R2, G10Rep2)
        G10Rep.Items.Clear()
        Combo(10, G10Rep)
        If G10Rep.Items.Contains(G10Rep2.Text) Then
            G10Rep.Items.Remove(G10Rep2.Text)
        End If
    End Sub

    Private Sub ComboBox18_SelectedIndexChanged(sender As Object, e As EventArgs) Handles G11Rep.SelectedIndexChanged
        getIm(Pic_G11R, G11Rep)
        G11Rep2.Items.Clear()
        Combo(11, G11Rep2)
        If G11Rep2.Items.Contains(G11Rep.Text) Then
            G11Rep2.Items.Remove(G11Rep.Text)
        End If
    End Sub

    Private Sub ComboBox19_SelectedIndexChanged(sender As Object, e As EventArgs) Handles G11Rep2.SelectedIndexChanged
        getIm(Pic_G11R2, G11Rep2)
        G11Rep.Items.Clear()
        Combo(11, G11Rep)
        If G11Rep.Items.Contains(G11Rep2.Text) Then
            G11Rep.Items.Remove(G11Rep2.Text)
        End If
    End Sub

    Private Sub ComboBox14_SelectedIndexChanged(sender As Object, e As EventArgs) Handles G12Rep.SelectedIndexChanged
        getIm(Pic_G12R, G12Rep)
        G12Rep2.Items.Clear()
        Combo(12, G12Rep2)
        If G12Rep2.Items.Contains(G12Rep.Text) Then
            G12Rep2.Items.Remove(G12Rep.Text)
        End If
    End Sub

    Private Sub ComboBox17_SelectedIndexChanged(sender As Object, e As EventArgs) Handles G12Rep2.SelectedIndexChanged
        getIm(Pic_G12R2, G12Rep2)
        G12Rep.Items.Clear()
        Combo(12, G12Rep)
        If G12Rep.Items.Contains(G12Rep2.Text) Then
            G12Rep.Items.Remove(G12Rep2.Text)
        End If
    End Sub

    Private Sub BttnPartyList1_Click_1(sender As Object, e As EventArgs) Handles BttnPartyList1.Click
        val = 1
        PartyListView.val2 = val
        PartyListView.Show()
    End Sub

    Private Sub BttnPartyList2_Click_1(sender As Object, e As EventArgs) Handles BttnPartyList2.Click
        val = 2
        PartyListView.val2 = val
        PartyListView.Show()
    End Sub

    Private Sub BttnPartyList2_MouseEnter(sender As Object, e As EventArgs) Handles BttnPartyList2.MouseEnter
        BttnPartyList2.BackColor = Color.Blue
        BttnPartyList2.ForeColor = Color.GhostWhite
    End Sub

    Private Sub BttnPartyList2_MouseLeave(sender As Object, e As EventArgs) Handles BttnPartyList2.MouseLeave
        BttnPartyList2.BackColor = Color.GhostWhite
        BttnPartyList2.ForeColor = Color.Black
    End Sub

    Private Sub BttnPartyList1_MouseEnter(sender As Object, e As EventArgs) Handles BttnPartyList1.MouseEnter
        BttnPartyList1.BackColor = Color.Blue
        BttnPartyList1.ForeColor = Color.GhostWhite
    End Sub

    Private Sub BttnPartyList1_MouseLeave(sender As Object, e As EventArgs) Handles BttnPartyList1.MouseLeave
        BttnPartyList1.BackColor = Color.GhostWhite
        BttnPartyList1.ForeColor = Color.Black
    End Sub

    Private Sub SubmitBttn_MouseEnter(sender As Object, e As EventArgs) Handles SubmitBttn.MouseEnter
        SubmitBttn.BackColor = Color.Blue
        SubmitBttn.ForeColor = Color.GhostWhite
    End Sub

    Private Sub SubmitBttn_MouseLeave(sender As Object, e As EventArgs) Handles SubmitBttn.MouseLeave
        SubmitBttn.ForeColor = Color.Black
        SubmitBttn.BackColor = Color.GhostWhite
    End Sub

    Private Sub SubmitBttn_Click(sender As Object, e As EventArgs) Handles SubmitBttn.Click

    End Sub
End Class
