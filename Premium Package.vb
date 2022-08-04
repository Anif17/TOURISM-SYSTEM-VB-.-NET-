Public Class Premium_Package
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        Platinum_Package.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub
End Class