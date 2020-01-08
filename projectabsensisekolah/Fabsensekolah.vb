Public Class FAbsensekolah

    Private Sub Fmenuutama_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Fmenuutama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slabel8.Text = Today
        Call terbuka()



        
    End Sub
    Sub terkunci()
        Mi_login.Enabled = True
        Mi_logout.Enabled = False
        Ms_menu.Enabled = False
        Ms_laporan.Enabled = False
        Ms_utility.Enabled = False
        Slabel2.Text = ""
        Slabel4.Text = ""
        Slabel6.Text = ""

        End Sub
    Sub terbuka()
        Mi_login.Enabled = False
        Mi_logout.Enabled = True
        Ms_menu.Enabled = True
        Ms_laporan.Enabled = True
        Ms_utility.Enabled = True
        If Slabel6.Text = "User" Then
            Mi_user.Enabled = False
        Else
            Mi_user.Enabled = True
        End If


    End Sub

    Private Sub DataGuruToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AbsensiSekolahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Mi_abssiswa.Click
        Finputabsen.Show()
        Me.Hide()
    End Sub

    Private Sub LihatAbsenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Fabsensiswa.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Mi_user.Click
        Freguser.Show()
        Me.Hide()

    End Sub

    Private Sub IdentitasSekolahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Mi_laporkehdiran.Click

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Mi_login.Click
        Call terkunci()
        Flogin.ShowDialog()
        Me.Hide()
        
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked


    End Sub
    Private Sub Mi_logout_Click(sender As Object, e As EventArgs) Handles Mi_logout.Click
        Call terkunci()
        Flogin.Show()
        Me.Hide()


    End Sub
 

    Private Sub Mi_exit_Click(sender As Object, e As EventArgs) Handles Mi_exit.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Slabel10.Text = TimeOfDay
    End Sub
End Class