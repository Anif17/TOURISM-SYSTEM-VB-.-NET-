Imports System.IO

Public Class Booking_Customer

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim seniorC, adultC, childC, totAllPeople As Integer
        Dim custName, custIcPassport, custPhone, custEmail, namePackage As String
        Dim namecable, nameSkyRide, nameOrchidFarm, nameSkyBridge, nameUniversalStudio As String
        Dim totalPricePackage, totalPriceAddOn, totalPrice As Double
        Dim dateGo As Date
        namePackage = ""
        namecable = ""
        nameSkyRide = ""
        nameOrchidFarm = ""
        nameSkyBridge = ""
        nameUniversalStudio = ""

        custName = txtName.Text
        custIcPassport = txtIcPassport.Text
        custPhone = txtPhone.Text
        custEmail = txtEmail.Text
        dateGo = dtpDateGo.Value

        seniorC = Val(txtSenior.Text)
        adultC = Val(txtAdult.Text)
        childC = Val(txtChild.Text)

        'Input vallidation

        Dim verify As Boolean
        verify = True

        'Check if noting in input
        If (String.IsNullOrEmpty(txtName.Text) Or String.IsNullOrEmpty(txtIcPassport.Text) Or String.IsNullOrEmpty(txtPhone.Text) Or String.IsNullOrEmpty(txtEmail.Text)) Then
            MsgBox("Compulsory to enter Customer Info", vbExclamation, "Error ! ")
            verify = False
            'Check if number in Name being used
        ElseIf (IsNumeric(txtName.Text)) Then
            MsgBox("Compulsory to enter Values in alphabet for First and Last Name only", vbExclamation, "Error ! ")
            verify = False
        End If

        'Check if noting in input
        If (String.IsNullOrEmpty(txtAdult.Text) And String.IsNullOrEmpty(txtChild.Text) And String.IsNullOrEmpty(txtSenior.Text)) Then
            MsgBox("Compulsory to enter Total Customer", vbExclamation, "Error ! ")
            verify = False
        End If

        'End of Input vallidation

        If (cmbPackage.SelectedIndex = 0) Then
            totalPricePackage += (1500 * seniorC) + (3000 * adultC) + (2250 * childC)
            namePackage = "NORMAL PACKAGE"
        ElseIf (cmbPackage.SelectedIndex = 1) Then
            totalPricePackage = 2500 * seniorC + 5000 * adultC + 3750 * childC
            namePackage = "PREMIUM PACKAGE"
        ElseIf (cmbPackage.SelectedIndex = 2) Then
            totalPricePackage = 3000 * seniorC + 6000 * adultC + 4500 * childC
            namePackage = "PLANTINIUM PACKAGE"
        Else
            MsgBox("Compulsory to choose either normal,premium and plantinium", vbExclamation, "Error ! ")
            verify = False
        End If

        totAllPeople = seniorC + adultC + childC

        Dim priceAddOn(4) As Double

        If chkCableCar.Checked Then
            namecable = "CABLE CAR SINGAPURA"
            priceAddOn(0) = 125 * totAllPeople
        Else
            priceAddOn(0) = 0
        End If
        If chkSkyRide.Checked Then
            nameSkyRide = "SKYRIDE"
            priceAddOn(1) = 150 * totAllPeople
        Else
            priceAddOn(1) = 0
        End If
        If chkSkyBridge.Checked Then
            nameSkyBridge = "SKYBRIDGE"
            priceAddOn(2) = 75 * totAllPeople
        Else
            priceAddOn(2) = 0
        End If
        If chkOrchidFarm.Checked Then
            nameOrchidFarm = "LARGEST ORCHID FARM"
            priceAddOn(3) = 45 * totAllPeople
        Else
            priceAddOn(3) = 0
        End If
        If chkUniversalStudio.Checked Then
            nameUniversalStudio = "UNIVERSAL STUDIO"
            priceAddOn(4) = 450 * totAllPeople
        Else
            priceAddOn(4) = 0
        End If

        For Each price As Double In priceAddOn
            totalPriceAddOn += price
        Next

        totalPrice = totalPricePackage + totalPriceAddOn

        If (verify) Then
            lstReceipt.Items.Add("")
            lstReceipt.Items.Add("==================RECEIPT================")
            lstReceipt.Items.Add("CUSTOMER INFORMATION")
            lstReceipt.Items.Add("CUSTOMER NAME : " & custName)
            lstReceipt.Items.Add("CUSTOMER IC/PASSPORT : " & custIcPassport)
            lstReceipt.Items.Add("CUSTOMER NUMBER : " & custPhone)
            lstReceipt.Items.Add("CUSTOMER EMIAL : " & custEmail)
            lstReceipt.Items.Add("")
            lstReceipt.Items.Add("BOOKING INFORMATION")
            lstReceipt.Items.Add("DEPARTURE DATE : " & Format(dateGo, "dd/MM/yyyy"))
            lstReceipt.Items.Add("SELECTED PACKAGE : " & namePackage)
            lstReceipt.Items.Add("SELECTED ADD-ON ACTIVITY : ")

            If chkCableCar.Checked Then
                lstReceipt.Items.Add(vbTab & "► " & namecable)
            End If
            If chkSkyRide.Checked Then
                lstReceipt.Items.Add(vbTab & "► " & nameSkyRide)
            End If
            If chkSkyBridge.Checked Then
                lstReceipt.Items.Add(vbTab & "► " & nameSkyBridge)
            End If
            If chkOrchidFarm.Checked Then
                lstReceipt.Items.Add(vbTab & "► " & nameOrchidFarm)
            End If
            If chkUniversalStudio.Checked Then
                lstReceipt.Items.Add(vbTab & "► " & nameUniversalStudio)
            End If

            lstReceipt.Items.Add("TOTAL SENIOR : " & seniorC)
            lstReceipt.Items.Add("TOTAL ADULT : " & adultC)
            lstReceipt.Items.Add("TOTAL CHILD : " & childC)
            lstReceipt.Items.Add("TOTAL PRICE OF ALL IS RM" & Format(totalPrice, "0.00"))
            lstReceipt.Items.Add("TOTAL PRICE FOR PACKAGE RM" & Format(totalPricePackage, "0.00"))
            lstReceipt.Items.Add("TOTAL PRICE FOR ADD-ON ACTIVITY RM" & Format(totalPriceAddOn, "0.00"))
            lstReceipt.Items.Add("=================THANK YOU==============")

            Dim saveReceipt As StreamWriter
            saveReceipt = File.AppendText("Receipt.txt")
            For index As Integer = 0 To lstReceipt.Items.Count - 1
                Dim text As String = CStr(lstReceipt.Items(index))
                saveReceipt.WriteLine(text)
            Next

            Dim saveFile As StreamWriter
            saveFile = File.AppendText("Booking_Information.txt")
            Dim infoBooking As String = namePackage & ";" & seniorC & ";" & adultC & ";" & childC & ";" &
                Format(totalPricePackage, "0.00") & ";" & Format(totalPriceAddOn, "0.00") & ";" & Format(totalPrice, "0.00")
            saveFile.WriteLine(infoBooking)


            saveReceipt.Close()
            saveFile.Close()
            btnAnother.Visible = True
            pctCustomer.Visible = True
        End If
    End Sub

    Private Sub Booking_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAnother.Visible = False
        pctCustomer.Visible = False
    End Sub

    Private Sub pctBack_Click(sender As Object, e As EventArgs) Handles pctBack.Click
        Me.Hide()
        MenuApplication.Show()
    End Sub

    Private Sub btnAnother_Click(sender As Object, e As EventArgs) Handles btnAnother.Click
        txtAdult.Clear()
        txtChild.Clear()
        txtSenior.Clear()
        txtEmail.Clear()
        txtIcPassport.Clear()
        txtName.Clear()
        txtPhone.Clear()
        cmbPackage.ResetText()
        chkCableCar.Checked = False
        chkOrchidFarm.Checked = False
        chkSkyBridge.Checked = False
        chkSkyRide.Checked = False
        chkUniversalStudio.Checked = False
        btnAnother.Visible = False
        pctCustomer.Visible = False
        lstReceipt.Items.Clear()

    End Sub

End Class
