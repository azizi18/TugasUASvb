Imports System.Data.OleDb
Module Modulekoneksi
    Public CONN As OleDbConnection
    Public CMD As OleDbCommand
    Public DS As New DataSet
    Public DA As OleDbDataAdapter
    Public RD As OleDbDataReader
    Public lokasiDB As String

    Sub koneksi()
        lokasiDB = "provider= Microsoft.ACE.OLEDB.12.0; Data source=DBlogin.accdb"
        CONN = New OleDbConnection(lokasiDB)
        If CONN.State = ConnectionState.Closed Then CONN.Open()
    End Sub
    

End Module
