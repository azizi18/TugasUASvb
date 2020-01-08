Imports System.Data.OleDb
Public Class Flogin

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Flogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Text_username.Text = ""
        Text_password.Text = ""
    End Sub

    Private Sub Flogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text_username.Text = ""
        Text_password.Text = ""
    End Sub

    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        If Text_username.Text = "" Or Text_password.Text = "" Then
            MsgBox("Username dan password belum diisi,silahkan isi kembali!")
        Else
            Call koneksi()
            CMD = New OleDbCommand("select * from tbl_user where username='" & Text_username.Text & "' and password='" & Text_password.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                Me.Hide()
                FAbsensekolah.Show()
                FAbsensekolah.Slabel2.Text = RD!ID
                FAbsensekolah.Slabel4.Text = RD!Username
                FAbsensekolah.Slabel6.Text = RD!Level

                FAbsensekolah.Mi_login.Enabled = False
                FAbsensekolah.Mi_logout.Enabled = True
                FAbsensekolah.Ms_menu.Enabled = True
                FAbsensekolah.Ms_laporan.Enabled = True
                FAbsensekolah.Ms_utility.Enabled = True
                If FAbsensekolah.Slabel6.Text = "User" Then
                    FAbsensekolah.Mi_user.Enabled = False
                Else
                    FAbsensekolah.Mi_user.Enabled = True
                End If




            Else
                MsgBox("username atau password salah! silahkan isi kembali!")

            End If




        End If
    End Sub

    Private Sub Text_password_TextChanged(sender As Object, e As EventArgs) Handles Text_password.TextChanged

    End Sub

    Private Sub Cbx_tamppas_CheckedChanged(sender As Object, e As EventArgs) Handles Cbx_tamppas.CheckedChanged
        If Cbx_tamppas.Checked Then
            Text_password.UseSystemPasswordChar = False
        Else
            Text_password.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
