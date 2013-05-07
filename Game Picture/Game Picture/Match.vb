Public Class Match
    Dim Pictures(16) As PictureBox
    Dim Pictures_List(16) As Image
    Dim List1(16), list2(16), Clicks, Number_Of_Image(2) As Integer

    Private Sub Form6_Form6Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Pictures(1) = PictureBox1
        Pictures(2) = PictureBox2
        Pictures(3) = PictureBox3
        Pictures(4) = PictureBox4
        Pictures(5) = PictureBox5
        Pictures(6) = PictureBox6
        Pictures(7) = PictureBox7
        Pictures(8) = PictureBox8
        Pictures(9) = PictureBox9
        Pictures(10) = PictureBox10
        Pictures(11) = PictureBox11
        Pictures(12) = PictureBox12
        Pictures(13) = PictureBox13
        Pictures(14) = PictureBox14
        Pictures(15) = PictureBox15
        Pictures(16) = PictureBox16

        New_Game()
    End Sub
    Sub New_Game()
        Dim I, J, Rnd_NO As Integer
        'clear image
        Clicks = 0
        For I = 1 To 16
            Pictures(I).Image = Nothing
        Next

        For I = 1 To 16
A1:
            Randomize()
            Rnd_NO = Int(16 * Rnd() + 1)

            ' check if rand numbers already use before
            For J = 1 To I
                If Rnd_NO = List1(J) Then GoTo A1
            Next

            List1(I) = Rnd_NO
        Next

        Pictures_List(List1(1)) = My.Resources.selampir

        Pictures_List(List1(2)) = My.Resources.selampir


        'list2  use for matching pictures
        list2(List1(1)) = 1
        list2(List1(2)) = 1

        Pictures_List(List1(3)) = My.Resources.selampir2

        Pictures_List(List1(4)) = My.Resources.selampir2

        list2(List1(3)) = 2
        list2(List1(4)) = 2

        Pictures_List(List1(5)) = My.Resources.pendet

        Pictures_List(List1(6)) = My.Resources.pendet

        list2(List1(5)) = 3
        list2(List1(6)) = 3

        Pictures_List(List1(7)) = My.Resources.pendet2

        Pictures_List(List1(8)) = My.Resources.pendet2

        list2(List1(7)) = 4
        list2(List1(8)) = 4

        Pictures_List(List1(9)) = My.Resources.merak

        Pictures_List(List1(10)) = My.Resources.merak

        list2(List1(9)) = 5
        list2(List1(10)) = 5

        Pictures_List(List1(11)) = My.Resources.merak2

        Pictures_List(List1(12)) = My.Resources.merak2

        list2(List1(11)) = 6
        list2(List1(12)) = 6

        Pictures_List(List1(13)) = My.Resources.legong

        Pictures_List(List1(14)) = My.Resources.legong

        list2(List1(13)) = 7
        list2(List1(14)) = 7

        Pictures_List(List1(15)) = My.Resources.legong2

        Pictures_List(List1(16)) = My.Resources.legong2

        list2(List1(15)) = 8
        list2(List1(16)) = 8


    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        New_Game()
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False

        If Clicks = 1 Then Exit Sub

        'check for matching pictuer

        If list2(Number_Of_Image(1)) = list2(Number_Of_Image(2)) Then

            Pictures(Number_Of_Image(1)).Enabled = False
            Pictures(Number_Of_Image(2)).Enabled = False
            'My.Computer.Audio.Play(My.Resources.Right, AudioPlayMode.WaitToComplete)

            'check if you finsh the game
            Dim Match As Boolean = True
            For i = 1 To 16
                If Pictures(i).Enabled = True Then
                    Match = False
                    Exit For
                End If
            Next

            If Match = True Then

                MsgBox("SELAMAT !! Anda Berhasil menyelesaikan game COCOK GAMBAR", , "Menang !!")
                Me.Hide()
                Pilih.Show()
            End If

        Else

            Pictures(Number_Of_Image(1)).Image = Nothing
            Pictures(Number_Of_Image(2)).Image = Nothing
            'My.Computer.Audio.Play(My.Resources.wrong, AudioPlayMode.WaitToComplete)

        End If

        Clicks = 0

    End Sub



    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ' to don nothing when the program check the matching
        If Timer1.Enabled = True Then Exit Sub

        'to avoid click the same image
        If Number_Of_Image(1) = 1 Then Exit Sub

        Clicks += 1

        ' set the number of image for click 1 and click 2 for comparison later
        Number_Of_Image(Clicks) = 1
        PictureBox1.Image = Pictures_List(1)
        'My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.WaitToComplete)

        If Clicks = 2 Then Timer1.Enabled = True


    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        ' to don nothing when the program check the matching
        If Timer1.Enabled = True Then Exit Sub

        'to avoid click the same image

        If Number_Of_Image(1) = 2 Then Exit Sub
        Clicks += 1
        Number_Of_Image(Clicks) = 2
        PictureBox2.Image = Pictures_List(2)
        'My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)
        If Clicks = 2 Then Timer1.Enabled = True

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        ' to don nothing when the program check the matching
        If Timer1.Enabled = True Then Exit Sub

        'to avoid click the same image

        If Number_Of_Image(1) = 3 Then Exit Sub
        Clicks += 1
        Number_Of_Image(Clicks) = 3
        PictureBox3.Image = Pictures_List(3)
        ' My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)
        If Clicks = 2 Then Timer1.Enabled = True

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        ' to don nothing when the program check the matching
        If Timer1.Enabled = True Then Exit Sub

        'to avoid click the same image

        If Number_Of_Image(1) = 4 Then Exit Sub
        Clicks += 1
        Number_Of_Image(Clicks) = 4
        PictureBox4.Image = Pictures_List(4)
        'My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)
        If Clicks = 2 Then Timer1.Enabled = True

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        ' to don nothing when the program check the matching
        If Timer1.Enabled = True Then Exit Sub

        'to avoid click the same image

        If Number_Of_Image(1) = 5 Then Exit Sub
        Clicks += 1
        Number_Of_Image(Clicks) = 5
        PictureBox5.Image = Pictures_List(5)
        'My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)
        If Clicks = 2 Then Timer1.Enabled = True

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        ' to don nothing when the program check the matching
        If Timer1.Enabled = True Then Exit Sub

        'to avoid click the same image

        If Number_Of_Image(1) = 6 Then Exit Sub
        Clicks += 1
        Number_Of_Image(Clicks) = 6
        PictureBox6.Image = Pictures_List(6)
        'My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)
        If Clicks = 2 Then Timer1.Enabled = True

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        ' to don nothing when the program check the matching
        If Timer1.Enabled = True Then Exit Sub

        'to avoid click the same image

        If Number_Of_Image(1) = 7 Then Exit Sub
        Clicks += 1
        Number_Of_Image(Clicks) = 7
        PictureBox7.Image = Pictures_List(7)
        'My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)
        If Clicks = 2 Then Timer1.Enabled = True

    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        ' to don nothing when the program check the matching
        If Timer1.Enabled = True Then Exit Sub

        'to avoid click the same image

        If Number_Of_Image(1) = 8 Then Exit Sub
        Clicks += 1
        Number_Of_Image(Clicks) = 8
        PictureBox8.Image = Pictures_List(8)
        'My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)
        If Clicks = 2 Then Timer1.Enabled = True

    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        ' to don nothing when the program check the matching
        If Timer1.Enabled = True Then Exit Sub

        'to avoid click the same image

        If Number_Of_Image(1) = 12 Then Exit Sub
        Clicks += 1
        Number_Of_Image(Clicks) = 12
        PictureBox12.Image = Pictures_List(12)
        'My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)
        If Clicks = 2 Then Timer1.Enabled = True

    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        ' to don nothing when the program check the matching
        If Timer1.Enabled = True Then Exit Sub

        'to avoid click the same image

        If Number_Of_Image(1) = 11 Then Exit Sub
        Clicks += 1
        Number_Of_Image(Clicks) = 11
        PictureBox11.Image = Pictures_List(11)
        'My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)
        If Clicks = 2 Then Timer1.Enabled = True

    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        ' to don nothing when the program check the matching
        If Timer1.Enabled = True Then Exit Sub

        'to avoid click the same image
        If Number_Of_Image(1) = 10 Then Exit Sub
        Clicks += 1
        Number_Of_Image(Clicks) = 10
        PictureBox10.Image = Pictures_List(10)
        'My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)
        If Clicks = 2 Then Timer1.Enabled = True

    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        ' to don nothing when the program check the matching
        If Timer1.Enabled = True Then Exit Sub

        'to avoid click the same image

        If Number_Of_Image(1) = 9 Then Exit Sub
        Clicks += 1
        Number_Of_Image(Clicks) = 9
        PictureBox9.Image = Pictures_List(9)
        'My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)
        If Clicks = 2 Then Timer1.Enabled = True

    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        ' to don nothing when the program check the matching
        If Timer1.Enabled = True Then Exit Sub

        'to avoid click the same image

        If Number_Of_Image(1) = 16 Then Exit Sub
        Clicks += 1
        Number_Of_Image(Clicks) = 16
        PictureBox16.Image = Pictures_List(16)
        'My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)
        If Clicks = 2 Then Timer1.Enabled = True

    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        ' to don nothing when the program check the matching
        If Timer1.Enabled = True Then Exit Sub

        'to avoid click the same image

        If Number_Of_Image(1) = 15 Then Exit Sub
        Clicks += 1
        Number_Of_Image(Clicks) = 15
        PictureBox15.Image = Pictures_List(15)
        'My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)
        If Clicks = 2 Then Timer1.Enabled = True

    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        ' to don nothing when the program check the matching
        If Timer1.Enabled = True Then Exit Sub

        'to avoid click the same image

        If Number_Of_Image(1) = 14 Then Exit Sub
        Clicks += 1
        Number_Of_Image(Clicks) = 14
        PictureBox14.Image = Pictures_List(14)
        'My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)
        If Clicks = 2 Then Timer1.Enabled = True

    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        ' to don nothing when the program check the matching
        If Timer1.Enabled = True Then Exit Sub

        'to avoid click the same image

        If Number_Of_Image(1) = 13 Then Exit Sub
        Clicks += 1
        Number_Of_Image(Clicks) = 13
        PictureBox13.Image = Pictures_List(13)
        'My.Computer.Audio.Play(My.Resources.Click, AudioPlayMode.WaitToComplete)
        If Clicks = 2 Then Timer1.Enabled = True

    End Sub

    Private Function PictureBox_click1() As PictureBox
        Throw New NotImplementedException
    End Function

    Private Function PictureBox_click2() As PictureBox
        Throw New NotImplementedException
    End Function



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Pilih.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class