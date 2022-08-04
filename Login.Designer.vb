<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picShow = New System.Windows.Forms.PictureBox()
        Me.lblSign = New System.Windows.Forms.LinkLabel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SINGAPORE_PAKAGES.My.Resources.Resources.login
        Me.PictureBox1.Location = New System.Drawing.Point(1374, 344)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(236, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DarkGreen
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(277, 360)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(151, 54)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SINGAPORE_PAKAGES.My.Resources.Resources._1491
        Me.PictureBox2.Location = New System.Drawing.Point(495, -21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(445, 541)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Viner Hand ITC", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(27, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(434, 61)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "TRAVEL SINGAPORE"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.picShow)
        Me.Panel2.Controls.Add(Me.lblSign)
        Me.Panel2.Controls.Add(Me.txtPassword)
        Me.Panel2.Controls.Add(Me.btnLogin)
        Me.Panel2.Controls.Add(Me.txtUsername)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(25, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(435, 422)
        Me.Panel2.TabIndex = 10
        '
        'picShow
        '
        Me.picShow.Image = Global.SINGAPORE_PAKAGES.My.Resources.Resources.eye
        Me.picShow.Location = New System.Drawing.Point(305, 280)
        Me.picShow.Name = "picShow"
        Me.picShow.Size = New System.Drawing.Size(54, 42)
        Me.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShow.TabIndex = 15
        Me.picShow.TabStop = False
        '
        'lblSign
        '
        Me.lblSign.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.lblSign.AutoSize = True
        Me.lblSign.BackColor = System.Drawing.Color.Transparent
        Me.lblSign.Location = New System.Drawing.Point(23, 384)
        Me.lblSign.Name = "lblSign"
        Me.lblSign.Size = New System.Drawing.Size(135, 17)
        Me.lblSign.TabIndex = 14
        Me.lblSign.TabStop = True
        Me.lblSign.Text = "New User ? Sign Up"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(26, 287)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(262, 30)
        Me.txtPassword.TabIndex = 12
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(26, 188)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(262, 30)
        Me.txtUsername.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "PASSWORD : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 22)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "USERNAME : "
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(6, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(422, 88)
        Me.Panel3.TabIndex = 8
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Silver
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = Global.SINGAPORE_PAKAGES.My.Resources.Resources.login1
        Me.PictureBox3.Location = New System.Drawing.Point(38, 2)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(89, 84)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 70
        Me.PictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(155, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 38)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Login"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.SINGAPORE_PAKAGES.My.Resources.Resources.istockphoto_930367862_612x612
        Me.ClientSize = New System.Drawing.Size(935, 502)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Login"
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSign As LinkLabel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label7 As Label
    Public WithEvents picShow As PictureBox
End Class
