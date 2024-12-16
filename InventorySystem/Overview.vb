Public Class Overview
    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        AbsenceMonitoring.Show()

        Me.Hide()
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        Homepage.Show()

        Me.Hide()
    End Sub

    Private Sub MT_Cashier_Click(sender As Object, e As EventArgs) Handles MT_Cashier.Click
        TransactionOverview.Show()

        Me.Hide()
    End Sub
End Class