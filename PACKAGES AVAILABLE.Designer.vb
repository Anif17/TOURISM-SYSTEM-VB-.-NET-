<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Package_Available
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpInfoPackage = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShowPlantinium = New System.Windows.Forms.Button()
        Me.btnShowAddOn = New System.Windows.Forms.Button()
        Me.btnShowPremium = New System.Windows.Forms.Button()
        Me.btnShowNormal = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pctBack = New System.Windows.Forms.PictureBox()
        Me.grpInfoPackage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Cooper Black", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(112, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(632, 55)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "PACKAGES AVAILABLE"
        '
        'grpInfoPackage
        '
        Me.grpInfoPackage.BackColor = System.Drawing.Color.Silver
        Me.grpInfoPackage.Controls.Add(Me.Label4)
        Me.grpInfoPackage.Controls.Add(Me.Label3)
        Me.grpInfoPackage.Controls.Add(Me.Label2)
        Me.grpInfoPackage.Controls.Add(Me.Label1)
        Me.grpInfoPackage.Controls.Add(Me.btnShowPlantinium)
        Me.grpInfoPackage.Controls.Add(Me.btnShowAddOn)
        Me.grpInfoPackage.Controls.Add(Me.btnShowPremium)
        Me.grpInfoPackage.Controls.Add(Me.btnShowNormal)
        Me.grpInfoPackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfoPackage.Location = New System.Drawing.Point(92, 97)
        Me.grpInfoPackage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpInfoPackage.Name = "grpInfoPackage"
        Me.grpInfoPackage.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpInfoPackage.Size = New System.Drawing.Size(637, 313)
        Me.grpInfoPackage.TabIndex = 15
        Me.grpInfoPackage.TabStop = False
        Me.grpInfoPackage.Text = "INFORMATION PACKAGE : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(267, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "INFO FOR ADD-ON ACTIVITY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(311, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "INFO FOR PLANTINIUM PACKAGE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(281, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "INFO FOR PREMIUM PACKAGE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(275, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "INFO FOR NORMAL PACKAGE"
        '
        'btnShowPlantinium
        '
        Me.btnShowPlantinium.Location = New System.Drawing.Point(389, 161)
        Me.btnShowPlantinium.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnShowPlantinium.Name = "btnShowPlantinium"
        Me.btnShowPlantinium.Size = New System.Drawing.Size(233, 55)
        Me.btnShowPlantinium.TabIndex = 2
        Me.btnShowPlantinium.Text = "PLANTINIUM PACKAGE"
        Me.btnShowPlantinium.UseVisualStyleBackColor = True
        '
        'btnShowAddOn
        '
        Me.btnShowAddOn.Location = New System.Drawing.Point(389, 222)
        Me.btnShowAddOn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnShowAddOn.Name = "btnShowAddOn"
        Me.btnShowAddOn.Size = New System.Drawing.Size(233, 55)
        Me.btnShowAddOn.TabIndex = 2
        Me.btnShowAddOn.Text = "ADD-ON ACTIVITY"
        Me.btnShowAddOn.UseVisualStyleBackColor = True
        '
        'btnShowPremium
        '
        Me.btnShowPremium.Location = New System.Drawing.Point(389, 101)
        Me.btnShowPremium.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnShowPremium.Name = "btnShowPremium"
        Me.btnShowPremium.Size = New System.Drawing.Size(233, 55)
        Me.btnShowPremium.TabIndex = 1
        Me.btnShowPremium.Text = "PREMIUM PACKAGE"
        Me.btnShowPremium.UseVisualStyleBackColor = True
        '
        'btnShowNormal
        '
        Me.btnShowNormal.Location = New System.Drawing.Point(389, 41)
        Me.btnShowNormal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnShowNormal.Name = "btnShowNormal"
        Me.btnShowNormal.Size = New System.Drawing.Size(233, 55)
        Me.btnShowNormal.TabIndex = 0
        Me.btnShowNormal.Text = "NORMAL PACKAGE"
        Me.btnShowNormal.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SINGAPORE_PAKAGES.My.Resources.Resources.BACKGROUND_SINGAPORE
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(814, 504)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'pctBack
        '
        Me.pctBack.BackColor = System.Drawing.Color.Silver
        Me.pctBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctBack.Image = Global.SINGAPORE_PAKAGES.My.Resources.Resources.icons8_reply_arrow_50
        Me.pctBack.Location = New System.Drawing.Point(-2, 444)
        Me.pctBack.Name = "pctBack"
        Me.pctBack.Size = New System.Drawing.Size(84, 58)
        Me.pctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBack.TabIndex = 61
        Me.pctBack.TabStop = False
        '
        'Package_Available
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.SINGAPORE_PAKAGES.My.Resources.Resources.BACKGROUND_SINGAPORE
        Me.ClientSize = New System.Drawing.Size(813, 502)
        Me.Controls.Add(Me.pctBack)
        Me.Controls.Add(Me.grpInfoPackage)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Package_Available"
        Me.Text = "PACKAGES AVAILABLE"
        Me.grpInfoPackage.ResumeLayout(False)
        Me.grpInfoPackage.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents grpInfoPackage As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnShowPlantinium As Button
    Friend WithEvents btnShowAddOn As Button
    Friend WithEvents btnShowPremium As Button
    Friend WithEvents btnShowNormal As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pctBack As PictureBox
End Class
