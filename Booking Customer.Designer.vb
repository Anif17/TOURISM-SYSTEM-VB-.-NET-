<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking_Customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Booking_Customer))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.dtpDateGo = New System.Windows.Forms.DateTimePicker()
        Me.lblStaff = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtIcPassport = New System.Windows.Forms.TextBox()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSenior = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtChild = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAdult = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkOrchidFarm = New System.Windows.Forms.CheckBox()
        Me.chkSkyBridge = New System.Windows.Forms.CheckBox()
        Me.chkSkyRide = New System.Windows.Forms.CheckBox()
        Me.chkUniversalStudio = New System.Windows.Forms.CheckBox()
        Me.chkCableCar = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbPackage = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstReceipt = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.pctBack = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.pctCustomer = New System.Windows.Forms.PictureBox()
        Me.btnAnother = New System.Windows.Forms.Button()
        Me.grpInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pctBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pctCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Showcard Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(421, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(512, 60)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "CUSTOMER BOOKING "
        '
        'grpInfo
        '
        Me.grpInfo.BackColor = System.Drawing.Color.Silver
        Me.grpInfo.BackgroundImage = CType(resources.GetObject("grpInfo.BackgroundImage"), System.Drawing.Image)
        Me.grpInfo.Controls.Add(Me.txtName)
        Me.grpInfo.Controls.Add(Me.txtEmail)
        Me.grpInfo.Controls.Add(Me.dtpDateGo)
        Me.grpInfo.Controls.Add(Me.lblStaff)
        Me.grpInfo.Controls.Add(Me.txtPhone)
        Me.grpInfo.Controls.Add(Me.Label4)
        Me.grpInfo.Controls.Add(Me.lblName)
        Me.grpInfo.Controls.Add(Me.txtIcPassport)
        Me.grpInfo.Controls.Add(Me.lblNumber)
        Me.grpInfo.Controls.Add(Me.lblEmail)
        Me.grpInfo.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfo.Location = New System.Drawing.Point(33, 85)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(642, 261)
        Me.grpInfo.TabIndex = 16
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "CUSTOMER INFO : "
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Silver
        Me.txtName.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(286, 30)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(326, 30)
        Me.txtName.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.Silver
        Me.txtEmail.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(286, 169)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(326, 30)
        Me.txtEmail.TabIndex = 10
        '
        'dtpDateGo
        '
        Me.dtpDateGo.CalendarFont = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateGo.CalendarForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.dtpDateGo.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.dtpDateGo.Location = New System.Drawing.Point(286, 214)
        Me.dtpDateGo.Name = "dtpDateGo"
        Me.dtpDateGo.Size = New System.Drawing.Size(328, 30)
        Me.dtpDateGo.TabIndex = 60
        '
        'lblStaff
        '
        Me.lblStaff.AutoSize = True
        Me.lblStaff.BackColor = System.Drawing.Color.Transparent
        Me.lblStaff.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaff.Location = New System.Drawing.Point(15, 37)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(167, 26)
        Me.lblStaff.TabIndex = 0
        Me.lblStaff.Text = "CUSTOMER NAME : "
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.Silver
        Me.txtPhone.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(286, 121)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(326, 30)
        Me.txtPhone.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "DEPARTURE DATE : "
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(15, 83)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(225, 26)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "CUSTOMER IC/PASSPORT : "
        '
        'txtIcPassport
        '
        Me.txtIcPassport.BackColor = System.Drawing.Color.Silver
        Me.txtIcPassport.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIcPassport.Location = New System.Drawing.Point(286, 76)
        Me.txtIcPassport.Name = "txtIcPassport"
        Me.txtIcPassport.Size = New System.Drawing.Size(326, 30)
        Me.txtIcPassport.TabIndex = 8
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblNumber.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(15, 128)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(249, 26)
        Me.lblNumber.TabIndex = 2
        Me.lblNumber.Text = "CUSTOMER PHONE NUMBER : "
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(15, 176)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(171, 26)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "CUSTOMER EMAIL : "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.txtSenior)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtChild)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtAdult)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(33, 581)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 134)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TOTAL CUSTOMER : "
        '
        'txtSenior
        '
        Me.txtSenior.BackColor = System.Drawing.Color.Silver
        Me.txtSenior.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenior.Location = New System.Drawing.Point(316, 25)
        Me.txtSenior.Name = "txtSenior"
        Me.txtSenior.Size = New System.Drawing.Size(82, 30)
        Me.txtSenior.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SENIOR CITIZEN : "
        '
        'txtChild
        '
        Me.txtChild.BackColor = System.Drawing.Color.Silver
        Me.txtChild.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChild.Location = New System.Drawing.Point(316, 94)
        Me.txtChild.Name = "txtChild"
        Me.txtChild.Size = New System.Drawing.Size(82, 30)
        Me.txtChild.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ADULT :"
        '
        'txtAdult
        '
        Me.txtAdult.BackColor = System.Drawing.Color.Silver
        Me.txtAdult.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdult.Location = New System.Drawing.Point(316, 60)
        Me.txtAdult.Name = "txtAdult"
        Me.txtAdult.Size = New System.Drawing.Size(82, 30)
        Me.txtAdult.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CHILD : "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmbPackage)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(33, 365)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(642, 210)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PACKAGES INFO : "
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.chkOrchidFarm)
        Me.GroupBox4.Controls.Add(Me.chkSkyBridge)
        Me.GroupBox4.Controls.Add(Me.chkSkyRide)
        Me.GroupBox4.Controls.Add(Me.chkUniversalStudio)
        Me.GroupBox4.Controls.Add(Me.chkCableCar)
        Me.GroupBox4.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(191, 75)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(432, 116)
        Me.GroupBox4.TabIndex = 67
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Option :"
        '
        'chkOrchidFarm
        '
        Me.chkOrchidFarm.AutoSize = True
        Me.chkOrchidFarm.BackColor = System.Drawing.Color.Transparent
        Me.chkOrchidFarm.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOrchidFarm.Location = New System.Drawing.Point(6, 80)
        Me.chkOrchidFarm.Name = "chkOrchidFarm"
        Me.chkOrchidFarm.Size = New System.Drawing.Size(229, 30)
        Me.chkOrchidFarm.TabIndex = 68
        Me.chkOrchidFarm.Text = "LARGEST ORCHID FARM"
        Me.chkOrchidFarm.UseVisualStyleBackColor = False
        '
        'chkSkyBridge
        '
        Me.chkSkyBridge.AutoSize = True
        Me.chkSkyBridge.BackColor = System.Drawing.Color.Transparent
        Me.chkSkyBridge.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSkyBridge.Location = New System.Drawing.Point(256, 54)
        Me.chkSkyBridge.Name = "chkSkyBridge"
        Me.chkSkyBridge.Size = New System.Drawing.Size(127, 30)
        Me.chkSkyBridge.TabIndex = 67
        Me.chkSkyBridge.Text = "SKYBRIDGE"
        Me.chkSkyBridge.UseVisualStyleBackColor = False
        '
        'chkSkyRide
        '
        Me.chkSkyRide.AutoSize = True
        Me.chkSkyRide.BackColor = System.Drawing.Color.Transparent
        Me.chkSkyRide.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSkyRide.Location = New System.Drawing.Point(256, 28)
        Me.chkSkyRide.Name = "chkSkyRide"
        Me.chkSkyRide.Size = New System.Drawing.Size(105, 30)
        Me.chkSkyRide.TabIndex = 66
        Me.chkSkyRide.Text = "SKYRIDE"
        Me.chkSkyRide.UseVisualStyleBackColor = False
        '
        'chkUniversalStudio
        '
        Me.chkUniversalStudio.AutoSize = True
        Me.chkUniversalStudio.BackColor = System.Drawing.Color.Transparent
        Me.chkUniversalStudio.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUniversalStudio.Location = New System.Drawing.Point(6, 54)
        Me.chkUniversalStudio.Name = "chkUniversalStudio"
        Me.chkUniversalStudio.Size = New System.Drawing.Size(188, 30)
        Me.chkUniversalStudio.TabIndex = 65
        Me.chkUniversalStudio.Text = "UNIVERSAL STUDIO"
        Me.chkUniversalStudio.UseVisualStyleBackColor = False
        '
        'chkCableCar
        '
        Me.chkCableCar.AutoSize = True
        Me.chkCableCar.BackColor = System.Drawing.Color.Transparent
        Me.chkCableCar.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCableCar.Location = New System.Drawing.Point(6, 28)
        Me.chkCableCar.Name = "chkCableCar"
        Me.chkCableCar.Size = New System.Drawing.Size(230, 30)
        Me.chkCableCar.TabIndex = 63
        Me.chkCableCar.Text = "CABLE CAR SINGAPURA"
        Me.chkCableCar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 26)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "ADD-ON PACKAGE : "
        '
        'cmbPackage
        '
        Me.cmbPackage.BackColor = System.Drawing.Color.Silver
        Me.cmbPackage.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPackage.FormattingEnabled = True
        Me.cmbPackage.Items.AddRange(New Object() {"NORMAL PACKAGE", "PREMIUM PACKAGE ", "PLANTINIUM PACKAGE "})
        Me.cmbPackage.Location = New System.Drawing.Point(284, 31)
        Me.cmbPackage.Name = "cmbPackage"
        Me.cmbPackage.Size = New System.Drawing.Size(328, 33)
        Me.cmbPackage.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 26)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "PACKAGE : "
        '
        'lstReceipt
        '
        Me.lstReceipt.BackColor = System.Drawing.Color.Silver
        Me.lstReceipt.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReceipt.FormattingEnabled = True
        Me.lstReceipt.HorizontalScrollbar = True
        Me.lstReceipt.ItemHeight = 27
        Me.lstReceipt.Location = New System.Drawing.Point(43, 58)
        Me.lstReceipt.Name = "lstReceipt"
        Me.lstReceipt.Size = New System.Drawing.Size(498, 544)
        Me.lstReceipt.TabIndex = 60
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Silver
        Me.btnCalculate.BackgroundImage = CType(resources.GetObject("btnCalculate.BackgroundImage"), System.Drawing.Image)
        Me.btnCalculate.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(499, 611)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(254, 78)
        Me.btnCalculate.TabIndex = 63
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'pctBack
        '
        Me.pctBack.BackColor = System.Drawing.Color.Silver
        Me.pctBack.BackgroundImage = CType(resources.GetObject("pctBack.BackgroundImage"), System.Drawing.Image)
        Me.pctBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctBack.Image = Global.SINGAPORE_PAKAGES.My.Resources.Resources.icons8_reply_arrow_50
        Me.pctBack.Location = New System.Drawing.Point(0, 745)
        Me.pctBack.Name = "pctBack"
        Me.pctBack.Size = New System.Drawing.Size(84, 58)
        Me.pctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBack.TabIndex = 64
        Me.pctBack.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.BackgroundImage = Global.SINGAPORE_PAKAGES.My.Resources.Resources.Ohhappiness1
        Me.GroupBox3.Controls.Add(Me.lstReceipt)
        Me.GroupBox3.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(760, 85)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(587, 630)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RECEIPT : "
        '
        'pctCustomer
        '
        Me.pctCustomer.BackColor = System.Drawing.Color.Silver
        Me.pctCustomer.BackgroundImage = CType(resources.GetObject("pctCustomer.BackgroundImage"), System.Drawing.Image)
        Me.pctCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctCustomer.Image = Global.SINGAPORE_PAKAGES.My.Resources.Resources.add_user1
        Me.pctCustomer.Location = New System.Drawing.Point(667, 710)
        Me.pctCustomer.Name = "pctCustomer"
        Me.pctCustomer.Size = New System.Drawing.Size(75, 55)
        Me.pctCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCustomer.TabIndex = 67
        Me.pctCustomer.TabStop = False
        '
        'btnAnother
        '
        Me.btnAnother.BackColor = System.Drawing.Color.Silver
        Me.btnAnother.BackgroundImage = CType(resources.GetObject("btnAnother.BackgroundImage"), System.Drawing.Image)
        Me.btnAnother.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnother.Location = New System.Drawing.Point(499, 697)
        Me.btnAnother.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnother.Name = "btnAnother"
        Me.btnAnother.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAnother.Size = New System.Drawing.Size(254, 78)
        Me.btnAnother.TabIndex = 67
        Me.btnAnother.Text = " ANOTHER CUSTOMER"
        Me.btnAnother.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnother.UseVisualStyleBackColor = False
        '
        'Booking_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SINGAPORE_PAKAGES.My.Resources.Resources.BACKGROUND_SINGAPORE_8
        Me.ClientSize = New System.Drawing.Size(1384, 802)
        Me.Controls.Add(Me.pctCustomer)
        Me.Controls.Add(Me.btnAnother)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.pctBack)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Booking_Customer"
        Me.Text = "Booking Customer"
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.pctBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.pctCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblStaff As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtIcPassport As TextBox
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSenior As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtChild As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAdult As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpDateGo As DateTimePicker
    Friend WithEvents cmbPackage As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lstReceipt As ListBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents pctBack As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkUniversalStudio As CheckBox
    Friend WithEvents chkCableCar As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkOrchidFarm As CheckBox
    Friend WithEvents chkSkyBridge As CheckBox
    Friend WithEvents chkSkyRide As CheckBox
    Friend WithEvents pctCustomer As PictureBox
    Friend WithEvents btnAnother As Button
End Class
