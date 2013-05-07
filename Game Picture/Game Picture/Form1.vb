Public Class Form1
    Public nama As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        nama = TextBox1.Text
        If TextBox1.Text = "" Then
            MsgBox("Maaf, Mohon isikan Nama", , "STOP!!")
        Else
            MsgBox("Hello, " & nama & "! Selamat Bermain", , "SELAMAT DATANG!!")
            Me.Hide()
            awal.Show()
        End If


    End Sub
End Class
