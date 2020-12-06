Public Class Form1
    Public x As Integer, n As Integer, i As Integer, p As Boolean, y As String
    Public lastNunber, inRegular As Integer
    '以下为无用的API函数
    'Private Declare Function DrawMenuBar Lib "user32" (ByVal Hwnd As Long)
    'Private Declare Function GetWindowLog Lib "user32" Alias "GetWindowLogA" (ByVal Hwnd As Long, ByVal nIndex As Long)
    'Private Declare Function SetWindowLog Lib "user32" Alias "SetWindowLogA" (ByVal Hwnd As Long, ByVal nIndex As Long, ByVal dwNewLog As Long) As Long
    'Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As String
    'Private Const GWL_STYLE As Long = (-16)
    'Private Const GWL_EXSTYLE = (-20)
    'Private Const WS_CAPTION As Long = &HC00000
    Private Sub CmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdStart.Click
        If Number.Text = "" Then
            NumberShower.Text = "Err"
            MsgBox("人数不能为空，请输入人数！！！"， vbExclamation + vbOKOnly， "错误")

        Else
            n = Val(Number.Text)
            CmdStart.Enabled = False
            CmdStop.Enabled = True
            'Do While CmdStop.Enabled = True
            'x = 0
            Timer1.Interval = 5
            Timer1.Start()
            'Loop
        End If

    End Sub

    Public Sub Reset()
        NumberShower.Visible = True
        CmdStart.Visible = True
        CmdStop.Visible = True
        CmdEnd.Visible = True
        CmdSet.Visible = True
        Label1.Visible = False
        Label2.Visible = True
        Label3.Visible = False
        Number.Visible = True
        Password.Visible = False
        IsKill.Visible = False
        isDoNotAgain.Visible = False
        KillNumber.Visible = False
        CmdOk.Visible = False
        CmdCancel.Visible = False
        CmdSetOk.Visible = False
        CmdStop.Enabled = False
        ListBox1.Visible = False
        Label4.Visible = False
        isKillRegular.Visible = False
        'isKillRegular.Enabled = False
        regularTime.Visible = False
    End Sub

    Private Sub CmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdStop.Click
        Timer1.Stop()
        CmdStart.Enabled = True
        CmdStop.Enabled = False
        If IsKill.Checked = True Then
            If isKillRegular.Checked = True Then
                If inRegular = Val(regularTime.Text) - 1 Then
                    NumberShower.Text = KillNumber.Text
                    y = Val(KillNumber.Text)
                    x = y
                    inRegular = inRegular + 1
                    inRegular = 0
                    'ElseIf inRegular = 0
                    'NumberShower.Text = KillNumber.Text
                    'y = Val(KillNumber.Text)
                    'x = y
                    'inRegular = inRegular + 1
                Else
                    inRegular = inRegular + 1
                End If
            ElseIf isKillRegular.Checked = False
                NumberShower.Text = KillNumber.Text
                y = Val(KillNumber.Text)
                x = y
                'inRegular = inRegular + 1
            End If


        ElseIf IsKill.Checked = False
            Do While x = 0
                x = Int(Rnd() * (n - 1)) + 1
            Loop
            NumberShower.Text = x
            y = x

        End If
        If isDoNotAgain.Checked = True Then
            If lastNunber = x Then
                Do While x = lastNunber Or x = 0
                    x = Int(Rnd() * (n - 1)) + 1
                Loop
                NumberShower.Text = x
                y = x
            End If
        End If
        If y < 10 And isKillRegular.Checked = False Then
            NumberShower.Text = 0 & NumberShower.Text
        End If
        If ListBox1.Visible = False Then
            ListBox1.Visible = True
            Label4.Visible = True
        End If
        If x = Val(NumberShower.Text) Then
            ListBox1.Items.Add("恭喜" & x & "号被选中!")
        Else
            x = Val(NumberShower.Text)
            ListBox1.Items.Add("恭喜" & x & "号被选中!")
        End If

        lastNunber = x
    End Sub

    Private Sub CmdEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEnd.Click
        End
    End Sub

    Private Sub CmdSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSet.Click
        Label2.Visible = False
        Number.Visible = False
        CmdStart.Visible = False
        CmdStop.Visible = False
        CmdEnd.Visible = False
        CmdSet.Visible = False
        NumberShower.Visible = False
        ListBox1.Visible = False
        Label4.Visible = False
        Label1.Visible = True
        Password.Visible = True
        CmdOk.Visible = True
        CmdCancel.Visible = True
        Password.Select()
    End Sub

    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If Password.Text = "{123456}" Then
            Label1.Visible = False
            Password.Visible = False
            CmdOk.Visible = False
            CmdCancel.Visible = False
            'Label2.Visible = True
            Label3.Visible = True
            'Number.Visible = True
            IsKill.Visible = True
            isDoNotAgain.Visible = True
            KillNumber.Visible = True
            CmdSetOk.Visible = True
            isKillRegular.Visible = True
            regularTime.Visible = True
            i = 0
            Password.Text = ""
        Else
            If i = 3 Then
                MsgBox("对不起,你无权打开设置", vbCritical, "警告")
                Call Reset()
                CmdSet.Enabled = False
            Else
                i = i + 1
                MsgBox("密码输入错误,你还有" & 4 - i & "次机会", vbExclamation, "警告")
                Password.Text = ""
            End If
        End If
    End Sub

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Call Reset()
    End Sub

    Private Sub IsKill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsKill.CheckedChanged
        'TODO:设置循环
        If isDoNotAgain.Checked = True Then
            With isDoNotAgain
                .Checked = False
                '.Enabled = False
            End With
        End If
        If IsKill.Checked = True Then
            KillNumber.Enabled = True
            isDoNotAgain.Enabled = False
            lastNunber = 0
            isKillRegular.Enabled = True
        Else
            KillNumber.Enabled = False
            isDoNotAgain.Enabled = True
            isKillRegular.Enabled = False
        End If
    End Sub

    Private Sub Number_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles Number.MaskInputRejected

    End Sub

    Private Sub isDoNotAgain_CheckedChanged(sender As Object, e As EventArgs) Handles isDoNotAgain.CheckedChanged
        If IsKill.Checked = True Then
            With IsKill
                .Checked = False
                '.Enabled = False
            End With
        End If
        If isDoNotAgain.Checked = True Then
            IsKill.Enabled = False
        Else
            IsKill.Enabled = True
            lastNunber = 0
        End If
    End Sub

    Private Sub isDoNotAgain_Click(sender As Object, e As EventArgs) Handles isDoNotAgain.Click

    End Sub

    Private Sub isKillRegular_CheckedChanged(sender As Object, e As EventArgs) Handles isKillRegular.CheckedChanged
        If isKillRegular.Checked = True Then
            regularTime.Enabled = True
        Else
            regularTime.Enabled = False
            inRegular = 0
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub regularTime_TextChanged(sender As Object, e As EventArgs) Handles regularTime.TextChanged
        inRegular = 0
    End Sub

    Private Sub KillNumber_TextChanged(sender As Object, e As EventArgs) Handles KillNumber.TextChanged
        inRegular = 0
    End Sub

    Private Sub Password_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles Password.MaskInputRejected

    End Sub

    Private Sub KillNumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles KillNumber.MaskInputRejected

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub regularTime_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles regularTime.MaskInputRejected

    End Sub

    Private Sub CmdSetOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSetOk.Click
        If KillNumber.Text = "" And IsKill.Checked = True Then
            MsgBox("输入的号码不能为空！"， vbCritical + vbOKOnly， "错误")
        Else
            If （regularTime.Text = "" Or regularTime.Text = "0"） And isKillRegular.Checked = True Then
                MsgBox("输入的循环次数不能为空或者为零！"， vbCritical + vbOKOnly， "错误")
            Else
                Call Reset()
            End If

        End If

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static int1 As Integer
        int1 = int1 + 1
        Select Case int1
            Case Is = 1
                x = 0
            Case Is = 2
                x = Int(Rnd() * (n)) + 1
            Case Is = 3
                NumberShower.Text = x
                y = x
                If y < 10 Then
                    NumberShower.Text = 0 & NumberShower.Text
                End If
            Case Is = 4
                    int1 = 0
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim IStyle As Long
        'Dim Hwnd As Long
        'FormBorderStyle = 0
        Me.ControlBox = True
        Me.MaximizeBox = False
        Panel1.BackColor = Color.Transparent
        Panel2.BackColor = Color.Transparent
        NumberShower.BackColor = Color.Transparent
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        LinkLabel1.BackColor = Color.Transparent
        IsKill.BackColor = Color.Transparent
        isDoNotAgain.BackColor = Color.Transparent
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        AboutBox1.Show()
    End Sub
End Class
