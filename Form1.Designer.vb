<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txt_grosspay = New System.Windows.Forms.TextBox()
        Me.txt_family_leave = New System.Windows.Forms.TextBox()
        Me.txt_disability = New System.Windows.Forms.TextBox()
        Me.txt_unemployment = New System.Windows.Forms.TextBox()
        Me.txt_netpay = New System.Windows.Forms.TextBox()
        Me.Benefits = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmd_cal = New System.Windows.Forms.Button()
        Me.cmd_clear = New System.Windows.Forms.Button()
        Me.cmd_close = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_reload = New System.Windows.Forms.Button()
        Me.cmd_save = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_un_rate = New System.Windows.Forms.TextBox()
        Me.txt_dis_rate = New System.Windows.Forms.TextBox()
        Me.txt_fl_rate = New System.Windows.Forms.TextBox()
        Me.Benefits.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_grosspay
        '
        Me.txt_grosspay.Location = New System.Drawing.Point(63, 45)
        Me.txt_grosspay.Name = "txt_grosspay"
        Me.txt_grosspay.Size = New System.Drawing.Size(82, 20)
        Me.txt_grosspay.TabIndex = 0
        '
        'txt_family_leave
        '
        Me.txt_family_leave.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_family_leave.Location = New System.Drawing.Point(17, 54)
        Me.txt_family_leave.Name = "txt_family_leave"
        Me.txt_family_leave.ReadOnly = True
        Me.txt_family_leave.Size = New System.Drawing.Size(82, 20)
        Me.txt_family_leave.TabIndex = 1
        '
        'txt_disability
        '
        Me.txt_disability.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_disability.Location = New System.Drawing.Point(134, 54)
        Me.txt_disability.Name = "txt_disability"
        Me.txt_disability.ReadOnly = True
        Me.txt_disability.Size = New System.Drawing.Size(82, 20)
        Me.txt_disability.TabIndex = 2
        '
        'txt_unemployment
        '
        Me.txt_unemployment.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_unemployment.Location = New System.Drawing.Point(241, 54)
        Me.txt_unemployment.Name = "txt_unemployment"
        Me.txt_unemployment.ReadOnly = True
        Me.txt_unemployment.Size = New System.Drawing.Size(82, 20)
        Me.txt_unemployment.TabIndex = 3
        '
        'txt_netpay
        '
        Me.txt_netpay.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_netpay.Location = New System.Drawing.Point(287, 45)
        Me.txt_netpay.Name = "txt_netpay"
        Me.txt_netpay.ReadOnly = True
        Me.txt_netpay.Size = New System.Drawing.Size(77, 20)
        Me.txt_netpay.TabIndex = 4
        '
        'Benefits
        '
        Me.Benefits.Controls.Add(Me.Label5)
        Me.Benefits.Controls.Add(Me.Label4)
        Me.Benefits.Controls.Add(Me.Label3)
        Me.Benefits.Controls.Add(Me.txt_unemployment)
        Me.Benefits.Controls.Add(Me.txt_disability)
        Me.Benefits.Controls.Add(Me.txt_family_leave)
        Me.Benefits.Location = New System.Drawing.Point(46, 88)
        Me.Benefits.Name = "Benefits"
        Me.Benefits.Size = New System.Drawing.Size(342, 94)
        Me.Benefits.TabIndex = 5
        Me.Benefits.TabStop = False
        Me.Benefits.Text = "Benefits"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(238, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "NJ Unemployment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "NJ Disability"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "NJ Family Leave"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Gross Pay"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Net Pay"
        '
        'cmd_cal
        '
        Me.cmd_cal.Location = New System.Drawing.Point(163, 198)
        Me.cmd_cal.Name = "cmd_cal"
        Me.cmd_cal.Size = New System.Drawing.Size(99, 27)
        Me.cmd_cal.TabIndex = 8
        Me.cmd_cal.Text = "Calculate"
        Me.cmd_cal.UseVisualStyleBackColor = True
        '
        'cmd_clear
        '
        Me.cmd_clear.Location = New System.Drawing.Point(161, 45)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(67, 20)
        Me.cmd_clear.TabIndex = 9
        Me.cmd_clear.Text = "Clear"
        Me.cmd_clear.UseVisualStyleBackColor = True
        '
        'cmd_close
        '
        Me.cmd_close.Location = New System.Drawing.Point(317, 461)
        Me.cmd_close.Name = "cmd_close"
        Me.cmd_close.Size = New System.Drawing.Size(91, 24)
        Me.cmd_close.TabIndex = 10
        Me.cmd_close.Text = "Close"
        Me.cmd_close.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_reload)
        Me.GroupBox1.Controls.Add(Me.cmd_save)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_un_rate)
        Me.GroupBox1.Controls.Add(Me.txt_dis_rate)
        Me.GroupBox1.Controls.Add(Me.txt_fl_rate)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 264)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 181)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rates"
        '
        'cmd_reload
        '
        Me.cmd_reload.Location = New System.Drawing.Point(199, 119)
        Me.cmd_reload.Name = "cmd_reload"
        Me.cmd_reload.Size = New System.Drawing.Size(99, 22)
        Me.cmd_reload.TabIndex = 16
        Me.cmd_reload.Text = "Reload"
        Me.cmd_reload.UseVisualStyleBackColor = True
        '
        'cmd_save
        '
        Me.cmd_save.Location = New System.Drawing.Point(70, 119)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(99, 22)
        Me.cmd_save.TabIndex = 13
        Me.cmd_save.Text = "Save"
        Me.cmd_save.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(253, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "UnemploymentRate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(146, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Disability Rate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Family Leave Rate"
        '
        'txt_un_rate
        '
        Me.txt_un_rate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_un_rate.Location = New System.Drawing.Point(256, 70)
        Me.txt_un_rate.Name = "txt_un_rate"
        Me.txt_un_rate.Size = New System.Drawing.Size(82, 20)
        Me.txt_un_rate.TabIndex = 13
        '
        'txt_dis_rate
        '
        Me.txt_dis_rate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_dis_rate.Location = New System.Drawing.Point(149, 70)
        Me.txt_dis_rate.Name = "txt_dis_rate"
        Me.txt_dis_rate.Size = New System.Drawing.Size(82, 20)
        Me.txt_dis_rate.TabIndex = 12
        '
        'txt_fl_rate
        '
        Me.txt_fl_rate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_fl_rate.Location = New System.Drawing.Point(32, 70)
        Me.txt_fl_rate.Name = "txt_fl_rate"
        Me.txt_fl_rate.Size = New System.Drawing.Size(82, 20)
        Me.txt_fl_rate.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 506)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmd_close)
        Me.Controls.Add(Me.cmd_clear)
        Me.Controls.Add(Me.cmd_cal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Benefits)
        Me.Controls.Add(Me.txt_netpay)
        Me.Controls.Add(Me.txt_grosspay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Benefits Calculator"
        Me.TopMost = True
        Me.Benefits.ResumeLayout(False)
        Me.Benefits.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_grosspay As TextBox
    Friend WithEvents txt_family_leave As TextBox
    Friend WithEvents txt_disability As TextBox
    Friend WithEvents txt_unemployment As TextBox
    Friend WithEvents txt_netpay As TextBox
    Friend WithEvents Benefits As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmd_cal As Button
    Friend WithEvents cmd_clear As Button
    Friend WithEvents cmd_close As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmd_reload As Button
    Friend WithEvents cmd_save As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_un_rate As TextBox
    Friend WithEvents txt_dis_rate As TextBox
    Friend WithEvents txt_fl_rate As TextBox
End Class
