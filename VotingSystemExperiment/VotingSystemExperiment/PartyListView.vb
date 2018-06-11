Public Class PartyListView
    Public val As Integer
    Public val2 As Integer
    Private Sub PartyListView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If val2 = 1 Then
            Me.Size = New Size(456, 474)
            ShowPartylist(DataGridView1, 1)
        End If
        If val2 = 2 Then
            Me.Size = New Size(456, 474)
            ShowPartylist(DataGridView1, 2)
        End If
        If val2 = 3 Then
            Label1.Visible = True
            Label2.Visible = True
            ShowPartylist(DataGridView1, 1)
            ShowPartylist(DataGridView2, 2)
        End If
    End Sub
End Class