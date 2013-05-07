Public Class Tebak
    Public data(11)
    Public jawab(11)
    Public x As Integer = 0
    Public skor As Integer = 0

    Public Function grub()

        PictureBox2.BackgroundImage = data(x)
        'MessageBox.Show(x.ToString)
    End Function

    Public Function cek_jawab()
        If TextBox1.Text = jawab(x) Then
            MessageBox.Show("Benar!!")
            'tanda = True
            x += 1
            grub()
            skor += 1
            TextBox1.Clear()

        Else
            MessageBox.Show("Salah!!")
            '    cek_jawab()
        End If
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        data(0) = My.Resources._1
        data(1) = My.Resources.gandrung
        data(2) = My.Resources.jaipong
        data(3) = My.Resources.payung
        data(4) = My.Resources.piring
        data(5) = My.Resources.sajojo
        data(6) = My.Resources.samman
        data(7) = My.Resources.topeng
        data(8) = My.Resources.reog
        data(9) = My.Resources.remo
        PictureBox2.BackgroundImage = My.Resources._1

        jawab(0) = "tor-tor"
        jawab(1) = "gandrung"
        jawab(2) = "jaipong"
        jawab(3) = "payung"
        jawab(4) = "piring"
        jawab(5) = "sajojo"
        jawab(6) = "samman"
        jawab(7) = "topeng"
        jawab(8) = "reog"
        jawab(9) = "remo"


    End Sub
    Private Sub Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok.Click
        cek_jawab()

        If x = 10 Then
            MessageBox.Show("Selamat Nilai Anda " & skor.ToString)
            Me.Hide()
            Pilih.Show()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Pilih.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        helptebak.Show()
    End Sub

    
End Class
