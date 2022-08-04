<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking_Report
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
        Me.lstReport = New System.Windows.Forms.ListBox()
        Me.pctBack = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pctBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstReport
        '
        Me.lstReport.BackColor = System.Drawing.Color.Silver
        Me.lstReport.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReport.FormattingEnabled = True
        Me.lstReport.ItemHeight = 27
        Me.lstReport.Location = New System.Drawing.Point(120, 129)
        Me.lstReport.Name = "lstReport"
        Me.lstReport.Size = New System.Drawing.Size(839, 652)
        Me.lstReport.TabIndex = 0
        '
        'pctBack
        '
        Me.pctBack.BackColor = System.Drawing.Color.Silver
        Me.pctBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctBack.Image = Global.SINGAPORE_PAKAGES.My.Resources.Resources.icons8_reply_arrow_50
        Me.pctBack.Location = New System.Drawing.Point(-1, 777)
        Me.pctBack.Name = "pctBack"
        Me.pctBack.Size = New System.Drawing.Size(84, 58)
        Me.pctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBack.TabIndex = 62
        Me.pctBack.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SINGAPORE_PAKAGES.My.Resources.Resources.BACKGROUND_SINGAPORE_2
        Me.PictureBox1.Location = New System.Drawing.Point(-13, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1031, 854)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(326, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(438, 60)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "BOOKING REPORT"
        '
        'Booking_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 833)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pctBack)
        Me.Controls.Add(Me.lstReport)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Booking_Report"
        Me.Text = "Booking Report"
        CType(Me.pctBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstReport As ListBox
    Friend WithEvents pctBack As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
