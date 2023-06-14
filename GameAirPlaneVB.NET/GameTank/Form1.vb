Imports Microsoft.DirectX.DirectSound
Imports Microsoft.DirectX
Imports Microsoft.DirectX.AudioVideoPlayback









Public Class Form1
    Dim _end As Boolean = False

    Dim _count As Integer = 3
    Dim yunilix As Boolean = True
    Dim vertikalYunilix As Boolean = True
    Dim p1 As Point = New Point()
    'okning orni
    Dim p2 As Point = New Point()
    Dim p3 As Point = New Point()
    Dim _flagBullet As Boolean = True


    Dim _airVerticalSpace As Integer = 1
    Dim _IsTang As Boolean = True
    Dim _IsYunilix As Boolean = True


    Dim x1_Bullet2 As Integer
    Dim x2_Bullet2 As Integer
    Dim y1_Bullet2 As Integer
    Dim y2_Bullet2 As Integer

    Dim x1_Tank1 As Integer
    Dim x2_Tank1 As Integer
    Dim y1_Tank1 As Integer
    Dim y2_Tank1 As Integer



    Dim x1_Bullet1 As Integer
    Dim x2_Bullet1 As Integer
    Dim y1_Bullet1 As Integer
    Dim y2_Bullet1 As Integer

    Dim x1_Tank2 As Integer
    Dim x2_Tank2 As Integer
    Dim y1_Tank2 As Integer
    Dim y2_Tank2 As Integer

    Dim _stepSpace As Integer = 10


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If yunilix = True Then
            If Tank2.Location.X > Panel_Main.Width - Tank2.Width Then
                yunilix = False
                Tank2.Image = GameTank.My.Resources.airplaneLeft

            End If

            p1 = New Point(Tank2.Location.X + 5, Tank2.Location.Y + _airVerticalSpace)
            Tank2.Location = p1

        Else
            If Tank2.Location.X < 0 Then
                yunilix = True
                Tank2.Image = GameTank.My.Resources.airplaneRight

            End If
            p1 = New Point(Tank2.Location.X - 5, Tank2.Location.Y + _airVerticalSpace)
            Tank2.Location = p1
        End If


        If vertikalYunilix = True Then
            If Tank2.Location.Y > (Panel_Main.Height / 6) * 5 Then
                _airVerticalSpace = -1
                vertikalYunilix = False
            End If


        Else
            If Tank2.Location.Y < 0 Then
                _airVerticalSpace = 1
                vertikalYunilix = True
            End If
        End If









        x1_Bullet2 = Bullet2.Location.X
        x2_Bullet2 = Bullet2.Location.X + Bullet2.Width
        y1_Bullet2 = Bullet2.Location.Y
        y2_Bullet2 = Bullet2.Location.Y + Bullet2.Height

        x1_Bullet1 = Bullet1.Location.X
        x2_Bullet1 = Bullet1.Location.X + Bullet1.Width
        y1_Bullet1 = Bullet1.Location.Y
        y2_Bullet1 = Bullet1.Location.Y + Bullet1.Height


        '///////////////
        x1_Tank1 = Tank1.Location.X
        x2_Tank1 = Tank1.Location.X + Tank1.Width
        y1_Tank1 = Tank1.Location.Y
        y2_Tank1 = Tank1.Location.Y + Tank1.Height

        x1_Tank2 = Tank2.Location.X
        x2_Tank2 = Tank2.Location.X + Tank2.Width
        y1_Tank2 = Tank2.Location.Y
        y2_Tank2 = Tank2.Location.Y + Tank2.Height



        If ((x1_Bullet2 >= x1_Tank1 And x1_Bullet2 <= x2_Tank1) Or (x2_Bullet2 >= x1_Tank1 And x2_Bullet2 <= x2_Tank1)) And ((y1_Bullet2 >= y1_Tank1 And y1_Bullet2 <= y2_Tank1) Or (y2_Bullet2 >= y1_Tank1 And y2_Bullet2 <= y2_Tank1)) Then

            'Tank2.Image = GaPanel_Main.My.Resources.boom
            'Tank2.Visible = False
            Timer1.Enabled = False
            _end = True
            Button2.Visible = False
            PlaySound("boom.wav", BufferPlayFlags.Default)
            Tank1.Image = GameTank.My.Resources.boom
            MessageBox.Show("Game Over!")

            Return
        End If


        If ((x1_Bullet1 >= x1_Tank2 And x1_Bullet1 <= x2_Tank2) Or (x2_Bullet1 >= x1_Tank2 And x2_Bullet1 <= x2_Tank2)) And ((y1_Bullet1 >= y1_Tank2 And y1_Bullet1 <= y2_Tank2) Or (y2_Bullet1 >= y1_Tank2 And y2_Bullet1 <= y2_Tank2)) Then
            _flagBullet = True

            p3 = New Point(Tank1.Location.X + Tank1.Width / 2, Panel_Main.Height + Tank1.Location.Y)
            Bullet1.Location = p3
            Bullet1.Image = GameTank.My.Resources.boom
            Bullet1.Visible = False

            If _count > 0 Then _count = _count - 1
            Lab_Life.Text = _count.ToString()
            If _count = 0 Then

                Timer1.Enabled = False
                _end = True
                Button2.Visible = False
                PlaySound("boom.wav", BufferPlayFlags.Default)
                Tank2.Image = GameTank.My.Resources.boom
                'Timer2.Enabled = True

                MessageBox.Show("You Win!!!!!!!")
                Return
            End If

        End If









        If Bullet1.Location.Y <= 0 Then
            _flagBullet = True
            GetBullet1DefaultLocation()
            Bullet1.Visible = False
        End If
        If _flagBullet = False Then
            Bullet1.Location = New Point(p3.X, Bullet1.Location.Y - 2)
        End If




        'bullet2
        If Bullet2.Location.Y >= Panel_Main.Height Then
            p2 = New Point(Tank2.Location.X + Tank2.Width / 2, Tank2.Location.Y + Tank2.Height)
            Bullet2.Location = p2
            PlaySound("tank2_ok.wav", BufferPlayFlags.Default)
        End If
        Bullet2.Location = New Point(p2.X, Bullet2.Location.Y + 2)







    End Sub


    Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean
        If _end = False Then
            Dim key As Keys = keyData

            Select Case key

                Case Keys.A
                    If Tank1.Location.X > 0 Then
                        Tank1.Location = New Point(Tank1.Location.X - _stepSpace, Tank1.Location.Y)
                        If _flagBullet = True Then
                            GetBullet1DefaultLocation()
                        End If
                    End If

                Case Keys.D
                    If Tank1.Location.X + Tank1.Width < Panel_Main.Width Then
                        Tank1.Location = New Point(Tank1.Location.X + _stepSpace, Tank1.Location.Y)
                        If _flagBullet = True Then
                            GetBullet1DefaultLocation()
                        End If
                    End If

                Case Keys.W
                    If Tank1.Location.Y > 0 Then
                        Tank1.Location = New Point(Tank1.Location.X, Tank1.Location.Y - _stepSpace)
                        If _flagBullet = True Then
                            GetBullet1DefaultLocation()
                        End If
                    End If
                Case Keys.S
                    If Tank1.Location.Y + Tank1.Height < Panel_Main.Height Then
                        Tank1.Location = New Point(Tank1.Location.X, Tank1.Location.Y + _stepSpace)
                        If _flagBullet = True Then
                            GetBullet1DefaultLocation()
                        End If

                    End If

                Case Keys.J
                    If _flagBullet = True Then
                        PlaySound("tank1_ok.wav", BufferPlayFlags.Default)

                        GetBullet1DefaultLocation()

                        Bullet1.Image = GameTank.My.Resources.Bullet2
                        Bullet1.Visible = True
                        _flagBullet = False
                    End If

            End Select



        End If
        If keyData = Keys.A Or keyData = Keys.D Or keyData = Keys.W Or keyData = Keys.S Then
            Return False
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If
    End Function

    Private Sub GetBullet1DefaultLocation()
        p3 = New Point(Tank1.Location.X + Tank1.Width / 2, Tank1.Location.Y)
        Bullet1.Location = p3
    End Sub



    Dim _audio As Audio
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '背景音乐
        _audio = New Audio("back.mp3")
        AddHandler _audio.Ending, AddressOf BackMusic_Ending
        _audio.Play()
        '重置
        ReSet()
    End Sub

    '音乐播放完成触发事件
    Private Sub BackMusic_Ending(sender As Object, e As EventArgs)
        _audio.Play()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GetBullet1DefaultLocation()
        Tank2.Image = GameTank.My.Resources.airplaneRight
        Tank1.Image = GameTank.My.Resources.mytank
        ReSet()
        Timer1.Enabled = True
        Tank1.Visible = True
        _count = 3
        Lab_Life.Text = 3
        Tank2.Visible = True
    End Sub



    '重置
    Private Sub ReSet()

        Tank1.Image = GameTank.My.Resources.airplane1
        Tank1.Location = New Point(Panel_Main.Width / 2, Panel_Main.Height - Tank1.Height)
        Tank2.Image = GameTank.My.Resources.airplaneRight
        Tank2.Location = New Point(0, 0)

        Button2.Text = "Stop"
        Button2.Visible = True
        _end = False
        Bullet1.Visible = False
        p2 = New Point(Tank2.Location.X + Tank2.Width / 2, Tank2.Location.Y + Tank2.Height)
        Bullet2.Location = p2
        p3 = New Point(Tank1.Location.X + Tank1.Width / 2, Tank1.Location.Y)
        Bullet1.Location = p3
    End Sub


    Dim backBuffer As SecondaryBuffer
    Dim backDev As Device = New Device()
    '播放音乐
    Public Sub PlaySound(path As String, playState As BufferPlayFlags)

        backDev.SetCooperativeLevel(Me, CooperativeLevel.Normal)
        backBuffer = New SecondaryBuffer(path, backDev)
        backBuffer.Play(0, playState)

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Timer1.Enabled = True Then
            Timer1.Enabled = False
            Button2.Text = "Play"
        Else
            Timer1.Enabled = True
            Button2.Text = "Stop"
        End If

    End Sub
End Class
