<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NumberShower = New System.Windows.Forms.Label()
        Me.CmdStart = New System.Windows.Forms.Button()
        Me.CmdStop = New System.Windows.Forms.Button()
        Me.CmdEnd = New System.Windows.Forms.Button()
        Me.CmdSet = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Number = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.MaskedTextBox()
        Me.CmdOk = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.IsKill = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.KillNumber = New System.Windows.Forms.MaskedTextBox()
        Me.CmdSetOk = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.regularTime = New System.Windows.Forms.MaskedTextBox()
        Me.isKillRegular = New System.Windows.Forms.CheckBox()
        Me.isDoNotAgain = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumberShower
        '
        Me.NumberShower.AutoSize = True
        Me.NumberShower.BackColor = System.Drawing.Color.Silver
        Me.NumberShower.Font = New System.Drawing.Font("思源黑体 CN Medium", 199.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NumberShower.ForeColor = System.Drawing.Color.White
        Me.NumberShower.Location = New System.Drawing.Point(173, 29)
        Me.NumberShower.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.NumberShower.Name = "NumberShower"
        Me.NumberShower.Size = New System.Drawing.Size(951, 753)
        Me.NumberShower.TabIndex = 0
        Me.NumberShower.Text = "00"
        '
        'CmdStart
        '
        Me.CmdStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdStart.Font = New System.Drawing.Font("思源黑体 CN Regular", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CmdStart.Location = New System.Drawing.Point(76, 746)
        Me.CmdStart.Margin = New System.Windows.Forms.Padding(6)
        Me.CmdStart.Name = "CmdStart"
        Me.CmdStart.Size = New System.Drawing.Size(188, 72)
        Me.CmdStart.TabIndex = 1
        Me.CmdStart.Text = "开始"
        Me.CmdStart.UseVisualStyleBackColor = True
        '
        'CmdStop
        '
        Me.CmdStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdStop.Enabled = False
        Me.CmdStop.Font = New System.Drawing.Font("思源黑体 CN Regular", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CmdStop.Location = New System.Drawing.Point(276, 746)
        Me.CmdStop.Margin = New System.Windows.Forms.Padding(6)
        Me.CmdStop.Name = "CmdStop"
        Me.CmdStop.Size = New System.Drawing.Size(188, 72)
        Me.CmdStop.TabIndex = 2
        Me.CmdStop.Text = "结束"
        Me.CmdStop.UseVisualStyleBackColor = True
        '
        'CmdEnd
        '
        Me.CmdEnd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdEnd.Font = New System.Drawing.Font("思源黑体 CN Regular", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CmdEnd.Location = New System.Drawing.Point(476, 746)
        Me.CmdEnd.Margin = New System.Windows.Forms.Padding(6)
        Me.CmdEnd.Name = "CmdEnd"
        Me.CmdEnd.Size = New System.Drawing.Size(188, 72)
        Me.CmdEnd.TabIndex = 3
        Me.CmdEnd.Text = "关闭"
        Me.CmdEnd.UseVisualStyleBackColor = True
        '
        'CmdSet
        '
        Me.CmdSet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdSet.Font = New System.Drawing.Font("思源黑体 CN Regular", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CmdSet.Location = New System.Drawing.Point(882, 746)
        Me.CmdSet.Margin = New System.Windows.Forms.Padding(6)
        Me.CmdSet.Name = "CmdSet"
        Me.CmdSet.Size = New System.Drawing.Size(188, 72)
        Me.CmdSet.TabIndex = 4
        Me.CmdSet.Text = "设置"
        Me.CmdSet.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(450, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 38)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "人数"
        '
        'Number
        '
        Me.Number.Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Number.ForeColor = System.Drawing.Color.Black
        Me.Number.Location = New System.Drawing.Point(555, 60)
        Me.Number.Margin = New System.Windows.Forms.Padding(6)
        Me.Number.Name = "Number"
        Me.Number.Size = New System.Drawing.Size(240, 44)
        Me.Number.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(252, 322)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 38)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "请输入密码"
        Me.Label1.Visible = False
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Password.ForeColor = System.Drawing.Color.Black
        Me.Password.Location = New System.Drawing.Point(476, 319)
        Me.Password.Margin = New System.Windows.Forms.Padding(6)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(300, 44)
        Me.Password.TabIndex = 8
        Me.Password.Visible = False
        '
        'CmdOk
        '
        Me.CmdOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdOk.Font = New System.Drawing.Font("思源黑体 CN Regular", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CmdOk.Location = New System.Drawing.Point(288, 440)
        Me.CmdOk.Margin = New System.Windows.Forms.Padding(6)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(188, 72)
        Me.CmdOk.TabIndex = 9
        Me.CmdOk.Text = "确定"
        Me.CmdOk.UseVisualStyleBackColor = True
        Me.CmdOk.Visible = False
        '
        'CmdCancel
        '
        Me.CmdCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdCancel.Font = New System.Drawing.Font("思源黑体 CN Regular", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CmdCancel.Location = New System.Drawing.Point(690, 440)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(6)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(188, 72)
        Me.CmdCancel.TabIndex = 10
        Me.CmdCancel.Text = "取消"
        Me.CmdCancel.UseVisualStyleBackColor = True
        Me.CmdCancel.Visible = False
        '
        'IsKill
        '
        Me.IsKill.AutoSize = True
        Me.IsKill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IsKill.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.IsKill.ForeColor = System.Drawing.Color.White
        Me.IsKill.Location = New System.Drawing.Point(378, 314)
        Me.IsKill.Margin = New System.Windows.Forms.Padding(6)
        Me.IsKill.Name = "IsKill"
        Me.IsKill.Size = New System.Drawing.Size(201, 42)
        Me.IsKill.TabIndex = 11
        Me.IsKill.Text = "坑人模式"
        Me.IsKill.UseVisualStyleBackColor = True
        Me.IsKill.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(292, 396)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 38)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "要坑的人"
        Me.Label3.Visible = False
        '
        'KillNumber
        '
        Me.KillNumber.Enabled = False
        Me.KillNumber.Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.KillNumber.ForeColor = System.Drawing.Color.Black
        Me.KillNumber.Location = New System.Drawing.Point(473, 393)
        Me.KillNumber.Margin = New System.Windows.Forms.Padding(6)
        Me.KillNumber.Name = "KillNumber"
        Me.KillNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.KillNumber.Size = New System.Drawing.Size(240, 44)
        Me.KillNumber.TabIndex = 13
        Me.KillNumber.Visible = False
        '
        'CmdSetOk
        '
        Me.CmdSetOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdSetOk.Font = New System.Drawing.Font("思源黑体 CN Regular", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CmdSetOk.Location = New System.Drawing.Point(690, 600)
        Me.CmdSetOk.Margin = New System.Windows.Forms.Padding(6)
        Me.CmdSetOk.Name = "CmdSetOk"
        Me.CmdSetOk.Size = New System.Drawing.Size(188, 72)
        Me.CmdSetOk.TabIndex = 14
        Me.CmdSetOk.Text = "确定"
        Me.CmdSetOk.UseVisualStyleBackColor = True
        Me.CmdSetOk.Visible = False
        '
        'Timer1
        '
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 33
        Me.ListBox1.Location = New System.Drawing.Point(1056, 482)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(236, 202)
        Me.ListBox1.TabIndex = 16
        Me.ListBox1.Tag = ""
        Me.ListBox1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("思源黑体 CN Regular", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1094, 425)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 51)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "选中名单"
        Me.Label4.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("思源黑体 CN Regular", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel1.Location = New System.Drawing.Point(1120, 780)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(96, 51)
        Me.LinkLabel1.TabIndex = 18
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "关于"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.regularTime)
        Me.Panel2.Controls.Add(Me.isKillRegular)
        Me.Panel2.Controls.Add(Me.isDoNotAgain)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Controls.Add(Me.CmdSetOk)
        Me.Panel2.Controls.Add(Me.KillNumber)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.IsKill)
        Me.Panel2.Controls.Add(Me.CmdCancel)
        Me.Panel2.Controls.Add(Me.CmdOk)
        Me.Panel2.Controls.Add(Me.Password)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Number)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.CmdSet)
        Me.Panel2.Controls.Add(Me.CmdEnd)
        Me.Panel2.Controls.Add(Me.CmdStop)
        Me.Panel2.Controls.Add(Me.CmdStart)
        Me.Panel2.Controls.Add(Me.NumberShower)
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1376, 924)
        Me.Panel2.TabIndex = 21
        '
        'regularTime
        '
        Me.regularTime.Enabled = False
        Me.regularTime.Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.regularTime.ForeColor = System.Drawing.Color.Black
        Me.regularTime.Location = New System.Drawing.Point(476, 510)
        Me.regularTime.Margin = New System.Windows.Forms.Padding(6)
        Me.regularTime.Name = "regularTime"
        Me.regularTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.regularTime.Size = New System.Drawing.Size(240, 44)
        Me.regularTime.TabIndex = 21
        Me.regularTime.Visible = False
        '
        'isKillRegular
        '
        Me.isKillRegular.AutoSize = True
        Me.isKillRegular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.isKillRegular.Enabled = False
        Me.isKillRegular.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.isKillRegular.ForeColor = System.Drawing.Color.White
        Me.isKillRegular.Location = New System.Drawing.Point(378, 456)
        Me.isKillRegular.Margin = New System.Windows.Forms.Padding(6)
        Me.isKillRegular.Name = "isKillRegular"
        Me.isKillRegular.Size = New System.Drawing.Size(201, 42)
        Me.isKillRegular.TabIndex = 20
        Me.isKillRegular.Text = "循环坑人"
        Me.isKillRegular.UseVisualStyleBackColor = True
        Me.isKillRegular.Visible = False
        '
        'isDoNotAgain
        '
        Me.isDoNotAgain.AutoSize = True
        Me.isDoNotAgain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.isDoNotAgain.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.isDoNotAgain.ForeColor = System.Drawing.Color.White
        Me.isDoNotAgain.Location = New System.Drawing.Point(378, 224)
        Me.isDoNotAgain.Margin = New System.Windows.Forms.Padding(6)
        Me.isDoNotAgain.Name = "isDoNotAgain"
        Me.isDoNotAgain.Size = New System.Drawing.Size(239, 42)
        Me.isDoNotAgain.TabIndex = 19
        Me.isDoNotAgain.Text = "防重复模式"
        Me.isDoNotAgain.UseVisualStyleBackColor = True
        Me.isDoNotAgain.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(6, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1374, 928)
        Me.Panel1.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1380, 940)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "随机抽号软件"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmdStart As System.Windows.Forms.Button
    Friend WithEvents CmdStop As System.Windows.Forms.Button
    Friend WithEvents CmdEnd As System.Windows.Forms.Button
    Friend WithEvents CmdSet As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Number As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Password As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CmdOk As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents IsKill As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents KillNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CmdSetOk As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents NumberShower As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents isDoNotAgain As CheckBox
    Friend WithEvents isKillRegular As CheckBox
    Friend WithEvents regularTime As MaskedTextBox
End Class
