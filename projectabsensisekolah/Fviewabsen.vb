Imports System.Data.OleDb

Public Class Fviewabsen


    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
    Sub koneksi()
        lokasiDB = "provider= Microsoft.ACE.OLEDB.12.0; Data source=DBabsensi.accdb"
        CONN = New OleDbConnection(lokasiDB)
        If CONN.State = ConnectionState.Closed Then CONN.Open()
    End Sub

    Private Sub Fviewabsen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM  tbl_absen", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_absen")
        DGVlihatke.DataSource = DS.Tables("tbl_absen")
        Label_tanggal.Text = Today
    End Sub

    Private Sub Label_jam_Click(sender As Object, e As EventArgs) Handles Lbl_jam.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbl_jam.Text = TimeOfDay
    End Sub

    Private Sub Label_tanggal_Click(sender As Object, e As EventArgs) Handles Label_tanggal.Click

    End Sub

    Private Sub btn_kemsis_Click(sender As Object, e As EventArgs) Handles btn_kemsis.Click
        FAbsensekolah.Show()
        Me.Hide()

    End Sub
End Class