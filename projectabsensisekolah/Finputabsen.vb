Imports System.Data.OleDb

Public Class Finputabsen
    Dim DBbaru As Boolean
    Dim absenID As String
    Sub koneksi()
        lokasiDB = "provider= Microsoft.ACE.OLEDB.12.0; Data source=DBabsensi.accdb"
        CONN = New OleDbConnection(lokasiDB)
        If CONN.State = ConnectionState.Closed Then CONN.Open()
    End Sub

    Private Sub Fabsensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBbaru = True
        Call koneksi()
        DA = New OleDb.OleDbDataAdapter("select * from tbl_absen", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_absen")
        DGVsis.DataSource = (DS.Tables("tbl_absen"))



    End Sub
    Sub viewGrid()
        DBbaru = True
        koneksi()
        DA = New OleDb.OleDbDataAdapter("select * from tbl_absen", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_absen")
        DGVsis.DataSource = (DS.Tables("tbl_absen"))


    End Sub
    Sub bersihkan()
        DBbaru = True
        absenID = ""
        Text_namasis.Text = ""
        Text_ket.Text = ""
        Text_notlp.Text = ""
        Text_kelas.Text = ""
        Text_nisn.Text = ""
        Text_jurusan.Text = ""
        Text_izin.Text = ""
        Text_sakit.Text = ""
        Text_hadir.Text = ""
        Focus()




    End Sub
    Sub textboxsis()
        Dim i As Integer
        i = DGVsis.CurrentRow.Index
        DBbaru = False
        absenID = DGVsis.Item(0, i).Value
        Text_nisn.Text = DGVsis.Item(1, i).Value
        Text_namasis.Text = DGVsis.Item(2, i).Value
        Text_kelas.Text = DGVsis.Item(3, i).Value
        Text_jurusan.Text = DGVsis.Item(4, i).Value
        Text_ket.Text = DGVsis.Item(5, i).Value
        Text_notlp.Text = DGVsis.Item(6, i).Value
        Text_izin.Text = DGVsis.Item(7, i).Value
        Text_sakit.Text = DGVsis.Item(8, i).Value
        Text_hadir.Text = DGVsis.Item(9, i).Value
    End Sub
    Sub jalnakanaccses(ByVal acsess As String)
        CMD = New OleDbCommand
        koneksi()

        Try
            CMD.Connection = CONN
            CMD.CommandType = CommandType.Text
            CMD.CommandText = acsess
            CMD.ExecuteNonQuery()
            CMD.Dispose()
            MsgBox("Data Sudah Disimpan", vbInformation)

        Catch ex As Exception
            MessageBox.Show("Tidak bisa menyimpan data ke Database " & ex.Message)

        End Try
    End Sub
    Sub jalankanhapus(ByVal acsess As String)
        CMD = New OleDbCommand
        koneksi()

        Try
            CMD.Connection = CONN
            CMD.CommandType = CommandType.Text
            CMD.CommandText = acsess
            CMD.ExecuteNonQuery()
            CMD.Dispose()
            MsgBox("Data Sudah Dihapus", vbInformation)

        Catch ex As Exception
            MessageBox.Show("Tidak bisa menghapus data " & ex.Message)

        End Try

    End Sub

    Private Sub DGVsis_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVsis.CellContentClick
        textboxsis()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Text_jurusan_TextChanged(sender As Object, e As EventArgs) Handles Text_kelas.TextChanged

    End Sub

    Private Sub Btn_closesis_Click(sender As Object, e As EventArgs) Handles Btn_closesis.Click
        FAbsensekolah.Show()
        Me.Hide()

    End Sub

    Private Sub Text_alamat_TextChanged(sender As Object, e As EventArgs) Handles Text_ket.TextChanged

    End Sub

    Private Sub Btn_tambah_Click(sender As Object, e As EventArgs) Handles Btn_tambah.Click
        Dim Accses As String

        Me.Cursor = Cursors.WaitCursor

        If DBbaru Then
            Accses = "INSERT INTO [tbl_absen] ([NISN], [Nama_lengkap], [Kelas], [jurusan],[Tanpa_ket],[No_tlp],[Izin],[Sakit],[hadir]) VALUES('" & Text_nisn.Text & "', '" & Text_jurusan.Text & "','" & Text_namasis.Text & "', '" & Text_kelas.Text & "', '" & Text_ket.Text & "','" & Text_notlp.Text & "','" & Text_izin.Text & "','" & Text_sakit.Text & "','" & Text_hadir.Text & "')"

        Else
            Accses = "UPDATE [tbl_absen] SET [NISN]='" & Text_nisn.Text &
                "', [Nama_lengkap]='" & Text_namasis.Text &
                "', [Kelas]='" & Text_kelas.Text &
                "', [Jurusan]='" & Text_jurusan.Text &
                "', [Tanpa_ket] ='" & Text_ket.Text &
                "', [No_tlp] = '" & Text_notlp.Text &
                "', [Izin] = '" & Text_izin.Text &
                "', [Sakit] ='" & Text_sakit.Text &
                "', [hadir] ='" & Text_hadir.Text &
                 "' WHERE ID =" & absenID & " "
        End If

        jalnakanaccses(Accses)
        bersihkan()
        viewGrid()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Btn_hapus_Click(sender As Object, e As EventArgs) Handles Btn_hapus.Click
        If absenID <> "" Then
            Dim Accses As String
            Dim pesan As Integer


            pesan = MsgBox("Apakah anda yakin akan menghapus Data ID " & absenID, vbExclamation + vbYesNo, "Perhatian")
            If pesan = vbNo Then Exit Sub

            Accses = "DELETE FROM [tbl_absen] WHERE ID = " & absenID


            jalankanhapus(Accses)
            Me.Cursor = Cursors.WaitCursor
            bersihkan()
            viewGrid()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Btn_upgrade_Click(sender As Object, e As EventArgs) Handles Btn_upgrade.Click
        bersihkan()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        bersihkan()
        DBbaru = True
    End Sub
End Class