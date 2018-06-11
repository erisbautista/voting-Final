Public Class Admin_View
    Public val As String
    Public val2 As String
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        val = 3
        PartyListView.val2 = val
        PartyListView.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RegisterVoter.Show()
    End Sub
End Class