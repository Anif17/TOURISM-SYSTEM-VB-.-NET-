Public Class Package_Available
    Private Sub btnShowNormal_Click(sender As Object, e As EventArgs) Handles btnShowNormal.Click
        Normal_Package.Show()
    End Sub

    Private Sub btnShowPremium_Click(sender As Object, e As EventArgs) Handles btnShowPremium.Click
        Premium_Package.Show()
    End Sub

    Private Sub btnShowPlantinium_Click(sender As Object, e As EventArgs) Handles btnShowPlantinium.Click
        Platinum_Package.Show()
    End Sub

    Private Sub btnShowAddOn_Click(sender As Object, e As EventArgs) Handles btnShowAddOn.Click
        add_on_package.Show()
    End Sub

    Private Sub pctBack_Click(sender As Object, e As EventArgs) Handles pctBack.Click
        Me.Hide()
        MenuApplication.Show()
    End Sub
End Class