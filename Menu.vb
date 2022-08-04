Public Class MenuApplication
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        End
    End Sub

    Private Sub btnPackage_Click(sender As Object, e As EventArgs) Handles btnPackage.Click
        Me.Hide()
        Package_Available.Show()
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        Me.Hide()
        Booking_Customer.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Me.Hide()
        Booking_Report.Show()
    End Sub


End Class