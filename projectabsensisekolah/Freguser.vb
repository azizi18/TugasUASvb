Imports System.Data.OleDb

Public Class Freguser
    Dim databaru As Boolean
    Dim userID As String



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_simpan.Click
        Dim Accses As String

        Me.Cursor = Cursors.WaitCursor

        If databaru Then
            Accses = "INSERT INTO [tbl_User] ([Nama], [email], [username], [password],[Level]) VALUES('" & Text_Nama.Text & "', '" & Text_email.Text & "', '" & Text_username.Text & "', '" & Text_passworduser.Text & "','" & Text_leveluser.Text & "')"

        Else
            Accses = "UPDATE [tbl_User] SET [Nama]='" & Text_Nama.Text &
                "', [email]='" & Text_email.Text &
                "', [username]='" & Text_username.Text &
                "', [password]='" & Text_passworduser.Text &
                "', [Level] ='" & Text_leveluser.Text &
                 "' WHERE ID =" & userID & " "
        End If

        jalnakanaccses(Accses)
        bersihkanform()
        isiGrid()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Text_Nama.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Text_username.TextChanged

    End Sub

    Private Sub Freguser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        databaru = True
        koneksi()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM  tbl_User", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Tbl_User")
        DGVdatuser.DataSource = DS.Tables("tbl_User")
        DGVdatuser.Enabled = True
    End Sub
    Sub isiGrid()
        koneksi()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM  tbl_User", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Tbl_User")
        DGVdatuser.DataSource = DS.Tables("tbl_User")
        DGVdatuser.Enabled = True

    End Sub

    Sub bersihkanform()
        databaru = False
        userID = ""
        Text_Nama.Text = ""
        Text_username.Text = ""
        Text_passworduser.Text = ""
        Text_email.Text = ""
        Text_leveluser.Text = ""
        Focus()
    End Sub
    Sub textbox()
        Dim i As Integer
        i = DGVdatuser.CurrentRow.Index
        databaru = False
        userID = DGVdatuser.Item(0, i).Value
        Text_Nama.Text = DGVdatuser.Item(1, i).Value
        Text_email.Text = DGVdatuser.Item(2, i).Value
        Text_username.Text = DGVdatuser.Item(3, i).Value
        Text_passworduser.Text = DGVdatuser.Item(4, i).Value
        Text_leveluser.Text = DGVdatuser.Item(5, i).Value
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

    Private Sub DGVdatuser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVdatuser.CellContentClick
        textbox()

    End Sub

    Private Sub Btn_bersih_Click(sender As Object, e As EventArgs) Handles Btn_bersih.Click
        bersihkanform()

    End Sub

    Private Sub Btn_hapus_Click(sender As Object, e As EventArgs) Handles Btn_hapus.Click
        If userID <> "" Then
            Dim Accses As String
            Dim pesan As Integer
           

            pesan = MsgBox("Apakah anda yakin akan menghapus Data ID " & userID, vbExclamation + vbYesNo, "Perhatian")
            If pesan = vbNo Then Exit Sub

            Accses = "DELETE FROM [tbl_User] WHERE ID = " & userID

            
            jalankanhapus(Accses)
                Me.Cursor = Cursors.WaitCursor
                bersihkanform()
                isiGrid()
                Me.Cursor = Cursors.Default
            End If
    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click
        bersihkanform()
        databaru = True
    End Sub

    Private Sub Btn_kembali_Click(sender As Object, e As EventArgs) Handles Btn_kembali.Click
        FAbsensekolah.Show()
        Me.Hide()

    End Sub
End Class