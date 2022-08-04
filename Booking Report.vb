Imports System.IO
Public Class Booking_Report
    Dim reportCustomer As StreamReader
    Private Sub Booking_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim package As String
        Dim senior, adult, child As Integer
        Dim packagePrice, addOnPrice, totPrice
        Dim ctNormalPackage, cPremiumPackage, cPlantiniumPackage As Integer
        Dim totalNormalPackage, totalPremiumPackage, totalPlantiniumPackage As Double
        Dim addOnNormal, addOnPremium, addOnPlantinium As Double
        Dim totalAllPrice, totalAllPackage, totalAllAddOn As Double
        Dim mostChosen, leastChosen As String
        Dim line, data() As String

        ctNormalPackage = 0
        cPremiumPackage = 0
        cPlantiniumPackage = 0
        totalNormalPackage = 0.00
        totalPremiumPackage = 0.00
        totalPlantiniumPackage = 0.00
        addOnNormal = 0.00
        addOnPremium = 0.00
        addOnPlantinium = 0.00
        mostChosen = ""
        leastChosen = ""
        totalAllPrice = 0.00
        totalAllPackage = 0.00
        totalAllAddOn = 0.00

        Try
            reportCustomer = File.OpenText("Booking_Information.txt")

            Do Until reportCustomer.EndOfStream
                line = reportCustomer.ReadLine()
                data = line.Split(";")
                package = data(0)
                senior = Val(data(1))
                adult = Val(data(2))
                child = Val(data(3))
                packagePrice = Val(data(4))
                addOnPrice = Val(data(5))
                totPrice = Val(data(6))

                If (package = "NORMAL PACKAGE") Then
                    totalNormalPackage += packagePrice
                    addOnNormal += addOnPrice
                    ctNormalPackage += 1
                ElseIf (package = "PREMIUM PACKAGE") Then
                    totalPremiumPackage += packagePrice
                    addOnPremium += addOnPrice
                    cPremiumPackage += 1
                ElseIf (package = "PLANTINIUM PACKAGE") Then
                    totalPlantiniumPackage += packagePrice
                    addOnPlantinium += addOnPrice
                    cPlantiniumPackage += 1
                End If

                leastChosen = determineLeastChosen(ctNormalPackage, cPremiumPackage, cPlantiniumPackage)
                mostChosen = determineMostChosen(ctNormalPackage, cPremiumPackage, cPlantiniumPackage)
            Loop

            totalAllPackage = totalNormalPackage + totalPremiumPackage + totalPlantiniumPackage
            totalAllAddOn = addOnNormal + addOnPremium + addOnPlantinium
            totalAllPrice = totalAllPackage + totalAllAddOn

        Catch ex As Exception
            MessageBox.Show("FILE IS MISSING!", "ERROR")
        End Try

        lstReport.Items.Add("******************************   REPORT   *************************************")
        lstReport.Items.Add(" ")
        lstReport.Items.Add("INFORAMTION  : ")
        lstReport.Items.Add(" ")
        lstReport.Items.Add("► NUMBER OF CUSTOMER WHO CHOOSE NORMAL PACKGAE")
        lstReport.Items.Add(vbTab & ctNormalPackage & " CUSTOMER")
        lstReport.Items.Add("► NUMBER OF CUSTOMER WHO CHOOSE PREMIUM PACKGAE")
        lstReport.Items.Add(vbTab & cPremiumPackage & " CUSTOMER")
        lstReport.Items.Add("► NUMBER OF CUSTOMER WHO CHOOSE PLANTINIUM PACKGAE")
        lstReport.Items.Add(vbTab & cPlantiniumPackage & " CUSTOMER")
        lstReport.Items.Add(" ")
        lstReport.Items.Add("► THE MOST CHOSEN PACKAGE BY THE CUSTOMER")
        lstReport.Items.Add(vbTab & mostChosen)
        lstReport.Items.Add("► THE LEAST CHOSEN PACKAGE BY THE CUSTOMER")
        lstReport.Items.Add(vbTab & leastChosen)
        lstReport.Items.Add(" ")
        lstReport.Items.Add("NORMAL PACKAGE : ")
        lstReport.Items.Add(" ")
        lstReport.Items.Add("► TOTAL PRICE FOR PACKAGE IN NORMAL PACKGAE")
        lstReport.Items.Add(vbTab & Format(totalNormalPackage, "RM0.00"))
        lstReport.Items.Add("► TOTAL PRICE FOR ADD ON IN NORMAL PACKGAE")
        lstReport.Items.Add(vbTab & Format(addOnNormal, "RM0.00"))
        lstReport.Items.Add(" ")
        lstReport.Items.Add("PREMIUM PACKAGE : ")
        lstReport.Items.Add(" ")
        lstReport.Items.Add("► TOTAL PRICE FOR PACKAGE IN PREMIUM PACKGAE")
        lstReport.Items.Add(vbTab & Format(totalPremiumPackage, "RM0.00"))
        lstReport.Items.Add("► TOTAL PRICE FOR ADD ON IN PREMIUM PACKGAE")
        lstReport.Items.Add(vbTab & Format(addOnPremium, "RM0.00"))
        lstReport.Items.Add(" ")
        lstReport.Items.Add("PLANTINIUM PACKAGE : ")
        lstReport.Items.Add(" ")
        lstReport.Items.Add("► TOTAL PRICE FOR PACKAGE IN PLANTINIUM PACKGAE")
        lstReport.Items.Add(vbTab & Format(totalPlantiniumPackage, "RM0.00"))
        lstReport.Items.Add("► TOTAL PRICE FOR ADD ON IN PLANTINIUM PACKGAE")
        lstReport.Items.Add(vbTab & Format(addOnPlantinium, "RM0.00"))
        lstReport.Items.Add(" ")
        lstReport.Items.Add("SUM : ")
        lstReport.Items.Add(" ")
        lstReport.Items.Add("► SUM OF ALL PACKAGE PRICE IN NORMAL,PREMIUM AND PLANTINIUM PACKAGES")
        lstReport.Items.Add(vbTab & Format(totalAllPackage, "RM0.00"))
        lstReport.Items.Add("► SUM OF ALL ADD-ON PRICE IN NORMAL,PREMIUM AND PLANTINIUM PACKAGES")
        lstReport.Items.Add(vbTab & Format(totalAllAddOn, "RM0.00"))
        lstReport.Items.Add("► SUM OF ALL PACKAGE WITH ADD-ON PRICE IN ALL PACKAGES")
        lstReport.Items.Add(vbTab & Format(totalAllPrice, "RM0.00"))
        lstReport.Items.Add(" ")
        lstReport.Items.Add("*******************************************************************************")
    End Sub

    Private Sub pctBack_Click(sender As Object, e As EventArgs) Handles pctBack.Click
        Me.Hide()
        MenuApplication.Show()
    End Sub

    Function determineLeastChosen(ByVal cNormal As Integer, ByVal CPremium As Integer, ByVal cPlantinium As Integer) As String
        Dim leastChosen As String
        leastChosen = " "

        If (cNormal < CPremium And cNormal < cPlantinium) Then
            leastChosen = "NORMAL PACKAGE"
        ElseIf (CPremium < cNormal And CPremium < cPlantinium) Then
            leastChosen = "PREMIUM PACKAGE"
        ElseIf (cPlantinium < cNormal And cPlantinium < CPremium) Then
            leastChosen = "PLANTINIUM PACKAGE"
        End If

        Return leastChosen
    End Function

    Function determineMostChosen(ByVal cNormal As Integer, ByVal CPremium As Integer, ByVal cPlantinium As Integer) As String
        Dim mostChosen As String
        mostChosen = " "

        If (cNormal > CPremium And cNormal > cPlantinium) Then
            mostChosen = "NORMAL PACKAGE"
        ElseIf (CPremium > cNormal And CPremium > cPlantinium) Then
            mostChosen = "PREMIUM PACKAGE"
        ElseIf (cPlantinium > cNormal And cPlantinium > CPremium) Then
            mostChosen = "PLANTINIUM PACKAGE"
        End If

        Return mostChosen
    End Function
End Class