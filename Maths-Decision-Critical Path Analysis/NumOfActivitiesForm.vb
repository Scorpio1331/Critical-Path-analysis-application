Public Class FrmNumOfActivities

    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        FrmListForm.Testing = NumUDActivityCounter.Value
        Me.Close()
    End Sub

    Private Sub FrmNumOfActivities_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmListForm.Show()
    End Sub
End Class