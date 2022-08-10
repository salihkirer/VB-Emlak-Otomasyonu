Imports System.Data.OleDb

Module vt
    Function Baglan()
        Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Application.StartupPath & "/veritabani.mdb")
        baglanti.Open()
        Return baglanti
    End Function
    Function dtGetir(sql) As DataTable
        Dim baglanti As OleDbConnection = Baglan()
        Dim cmd As New OleDbCommand
        cmd.Connection = baglanti
        cmd.CommandText = sql
        Dim dt As New DataTable
        Dim adp As New OleDbDataAdapter
        adp.SelectCommand = cmd
        adp.Fill(dt)
        cmd.Connection.Close()
        baglanti.Close()
        adp.Dispose()
        cmd.Dispose()
        Return dt
    End Function
    Function sqlCalistir(sql As String) As Boolean
        Dim baglanti As OleDbConnection = Baglan()
        Dim cmd As New OleDbCommand
        cmd.Connection = baglanti
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
        baglanti.Close()
        cmd.Dispose()
        Return True
    End Function
    Function kayitSayisi(sql As String) As Integer
        Dim baglanti As OleDbConnection = Baglan()
        Dim cmd As New OleDbCommand
        cmd.Connection = baglanti
        cmd.CommandText = sql
        Dim dt As New DataTable
        Dim adp As New OleDbDataAdapter
        adp.SelectCommand = cmd
        adp.Fill(dt)
        Return dt.Rows.Count
        cmd.Connection.Close()
        baglanti.Close()
        adp.Dispose()
        cmd.Dispose()
    End Function
End Module
