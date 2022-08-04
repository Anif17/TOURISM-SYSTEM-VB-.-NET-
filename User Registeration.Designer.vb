<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserRegistration
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserRegistration))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.STAFFIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STAFFNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOPHONEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataEmployee1DataSet1 = New SINGAPORE_PAKAGES.dataEmployee1DataSet1()
        Me.LoginTableAdapter = New SINGAPORE_PAKAGES.dataEmployee1DataSet1TableAdapters.loginTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.pctBack = New System.Windows.Forms.PictureBox()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.txtStaff = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblStaff = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.grpAccount = New System.Windows.Forms.GroupBox()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnShow = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataEmployee1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pctBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInfo.SuspendLayout()
        Me.grpAccount.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STAFFIDDataGridViewTextBoxColumn, Me.USERNAMEDataGridViewTextBoxColumn, Me.PASSWORDDataGridViewTextBoxColumn, Me.STAFFNAMEDataGridViewTextBoxColumn, Me.NOPHONEDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LoginBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(331, 373)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(930, 242)
        Me.DataGridView1.TabIndex = 17
        '
        'STAFFIDDataGridViewTextBoxColumn
        '
        Me.STAFFIDDataGridViewTextBoxColumn.DataPropertyName = "STAFF ID"
        Me.STAFFIDDataGridViewTextBoxColumn.HeaderText = "STAFF ID"
        Me.STAFFIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.STAFFIDDataGridViewTextBoxColumn.Name = "STAFFIDDataGridViewTextBoxColumn"
        Me.STAFFIDDataGridViewTextBoxColumn.Width = 125
        '
        'USERNAMEDataGridViewTextBoxColumn
        '
        Me.USERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.USERNAMEDataGridViewTextBoxColumn.Name = "USERNAMEDataGridViewTextBoxColumn"
        Me.USERNAMEDataGridViewTextBoxColumn.Width = 125
        '
        'PASSWORDDataGridViewTextBoxColumn
        '
        Me.PASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD"
        Me.PASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD"
        Me.PASSWORDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PASSWORDDataGridViewTextBoxColumn.Name = "PASSWORDDataGridViewTextBoxColumn"
        Me.PASSWORDDataGridViewTextBoxColumn.Width = 125
        '
        'STAFFNAMEDataGridViewTextBoxColumn
        '
        Me.STAFFNAMEDataGridViewTextBoxColumn.DataPropertyName = "STAFF NAME"
        Me.STAFFNAMEDataGridViewTextBoxColumn.HeaderText = "STAFF NAME"
        Me.STAFFNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.STAFFNAMEDataGridViewTextBoxColumn.Name = "STAFFNAMEDataGridViewTextBoxColumn"
        Me.STAFFNAMEDataGridViewTextBoxColumn.Width = 125
        '
        'NOPHONEDataGridViewTextBoxColumn
        '
        Me.NOPHONEDataGridViewTextBoxColumn.DataPropertyName = "NO PHONE"
        Me.NOPHONEDataGridViewTextBoxColumn.HeaderText = "NO PHONE"
        Me.NOPHONEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOPHONEDataGridViewTextBoxColumn.Name = "NOPHONEDataGridViewTextBoxColumn"
        Me.NOPHONEDataGridViewTextBoxColumn.Width = 125
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        Me.EMAILDataGridViewTextBoxColumn.Width = 125
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "login"
        Me.LoginBindingSource.DataSource = Me.DataEmployee1DataSet1
        '
        'DataEmployee1DataSet1
        '
        Me.DataEmployee1DataSet1.DataSetName = "dataEmployee1DataSet1"
        Me.DataEmployee1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Storystone", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(654, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(655, 62)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "USER REGISTRATION"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 373)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 242)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MODIFY"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Snow
        Me.btnAdd.Location = New System.Drawing.Point(33, 65)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(116, 41)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Snow
        Me.btnDelete.Location = New System.Drawing.Point(31, 127)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(242, 41)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Snow
        Me.btnUpdate.Location = New System.Drawing.Point(157, 65)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(116, 41)
        Me.btnUpdate.TabIndex = 22
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnLast.BackgroundImage = CType(resources.GetObject("btnLast.BackgroundImage"), System.Drawing.Image)
        Me.btnLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLast.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.ForeColor = System.Drawing.Color.Snow
        Me.btnLast.Location = New System.Drawing.Point(709, 29)
        Me.btnLast.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(204, 41)
        Me.btnLast.TabIndex = 18
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnNext.BackgroundImage = Global.SINGAPORE_PAKAGES.My.Resources.Resources.Ohhappiness
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Snow
        Me.btnNext.Location = New System.Drawing.Point(246, 29)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(204, 41)
        Me.btnNext.TabIndex = 20
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnPrevious.BackgroundImage = CType(resources.GetObject("btnPrevious.BackgroundImage"), System.Drawing.Image)
        Me.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrevious.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.Snow
        Me.btnPrevious.Location = New System.Drawing.Point(480, 29)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(204, 41)
        Me.btnPrevious.TabIndex = 19
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnFirst.BackgroundImage = CType(resources.GetObject("btnFirst.BackgroundImage"), System.Drawing.Image)
        Me.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFirst.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.ForeColor = System.Drawing.Color.Snow
        Me.btnFirst.Location = New System.Drawing.Point(7, 29)
        Me.btnFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(204, 41)
        Me.btnFirst.TabIndex = 17
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'pctBack
        '
        Me.pctBack.BackColor = System.Drawing.Color.Silver
        Me.pctBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctBack.Image = Global.SINGAPORE_PAKAGES.My.Resources.Resources.icons8_reply_arrow_50
        Me.pctBack.Location = New System.Drawing.Point(-4, -1)
        Me.pctBack.Name = "pctBack"
        Me.pctBack.Size = New System.Drawing.Size(84, 58)
        Me.pctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBack.TabIndex = 60
        Me.pctBack.TabStop = False
        '
        'grpInfo
        '
        Me.grpInfo.BackColor = System.Drawing.Color.Silver
        Me.grpInfo.BackgroundImage = CType(resources.GetObject("grpInfo.BackgroundImage"), System.Drawing.Image)
        Me.grpInfo.Controls.Add(Me.txtStaff)
        Me.grpInfo.Controls.Add(Me.txtEmail)
        Me.grpInfo.Controls.Add(Me.lblStaff)
        Me.grpInfo.Controls.Add(Me.txtPhone)
        Me.grpInfo.Controls.Add(Me.lblName)
        Me.grpInfo.Controls.Add(Me.txtName)
        Me.grpInfo.Controls.Add(Me.lblNumber)
        Me.grpInfo.Controls.Add(Me.lblEmail)
        Me.grpInfo.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfo.Location = New System.Drawing.Point(12, 113)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(596, 243)
        Me.grpInfo.TabIndex = 11
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "STAFF INFO : "
        '
        'txtStaff
        '
        Me.txtStaff.Location = New System.Drawing.Point(264, 51)
        Me.txtStaff.Name = "txtStaff"
        Me.txtStaff.Size = New System.Drawing.Size(295, 29)
        Me.txtStaff.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(264, 190)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(295, 29)
        Me.txtEmail.TabIndex = 10
        '
        'lblStaff
        '
        Me.lblStaff.AutoSize = True
        Me.lblStaff.BackColor = System.Drawing.Color.Transparent
        Me.lblStaff.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaff.Location = New System.Drawing.Point(19, 50)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(111, 27)
        Me.lblStaff.TabIndex = 0
        Me.lblStaff.Text = "STAFF ID : "
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(264, 142)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(295, 29)
        Me.txtPhone.TabIndex = 9
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(19, 96)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(141, 27)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "STAFF NAME : "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(264, 97)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(295, 29)
        Me.txtName.TabIndex = 8
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblNumber.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(19, 141)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(229, 27)
        Me.lblNumber.TabIndex = 2
        Me.lblNumber.Text = "STAFF PHONE NUMBER : "
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(19, 189)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(146, 27)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "STAFF EMAIL : "
        '
        'grpAccount
        '
        Me.grpAccount.BackColor = System.Drawing.Color.Silver
        Me.grpAccount.BackgroundImage = CType(resources.GetObject("grpAccount.BackgroundImage"), System.Drawing.Image)
        Me.grpAccount.Controls.Add(Me.btnShow)
        Me.grpAccount.Controls.Add(Me.txtConfirm)
        Me.grpAccount.Controls.Add(Me.Label1)
        Me.grpAccount.Controls.Add(Me.txtUsername)
        Me.grpAccount.Controls.Add(Me.txtPassword)
        Me.grpAccount.Controls.Add(Me.lblUsername)
        Me.grpAccount.Controls.Add(Me.lblPassword)
        Me.grpAccount.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAccount.Location = New System.Drawing.Point(665, 138)
        Me.grpAccount.Name = "grpAccount"
        Me.grpAccount.Size = New System.Drawing.Size(596, 218)
        Me.grpAccount.TabIndex = 8
        Me.grpAccount.TabStop = False
        Me.grpAccount.Text = " STAFF ACCOUNT : "
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New System.Drawing.Point(264, 128)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirm.Size = New System.Drawing.Size(295, 29)
        Me.txtConfirm.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 27)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "CONFIRM PASSWORD  : "
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(264, 47)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(295, 29)
        Me.txtUsername.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(264, 88)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(295, 29)
        Me.txtPassword.TabIndex = 7
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(30, 46)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(125, 27)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.Text = "USERNAME : "
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(30, 88)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(136, 27)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "PASSWORD  : "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SINGAPORE_PAKAGES.My.Resources.Resources.BACKGROUND_SINGAPORE_3
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1351, 773)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.btnFirst)
        Me.GroupBox2.Controls.Add(Me.btnLast)
        Me.GroupBox2.Controls.Add(Me.btnPrevious)
        Me.GroupBox2.Controls.Add(Me.btnNext)
        Me.GroupBox2.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(331, 621)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(930, 80)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CONTROL"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(389, 173)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(170, 39)
        Me.btnShow.TabIndex = 10
        Me.btnShow.Text = "SHOW PASSWORD"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'UserRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1319, 744)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pctBack)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.grpAccount)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UserRegistration"
        Me.Text = "USER REGISTRATION"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataEmployee1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pctBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.grpAccount.ResumeLayout(False)
        Me.grpAccount.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStaff As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtStaff As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents grpAccount As GroupBox
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataEmployee1DataSet1 As dataEmployee1DataSet1
    Friend WithEvents LoginBindingSource As BindingSource
    Friend WithEvents LoginTableAdapter As dataEmployee1DataSet1TableAdapters.loginTableAdapter
    Friend WithEvents STAFFIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USERNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PASSWORDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STAFFNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOPHONEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents pctBack As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnShow As Button
End Class
