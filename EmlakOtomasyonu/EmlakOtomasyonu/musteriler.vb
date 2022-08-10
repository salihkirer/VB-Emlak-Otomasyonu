Imports System.IO

Public Class musteriler
    Private Sub txtMusteriAra_TextChanged(sender As Object, e As EventArgs) Handles txtMusteriAra.TextChanged

        DGmusteri.Rows.Clear()
        Dim dt As DataTable = dtGetir("select * from musteriler where ad like '%" & txtMusteriAra.Text & "%' or soyad like '%" & txtMusteriAra.Text & "%' or tel like '%" & txtMusteriAra.Text & "%' or e_posta like '%" & txtMusteriAra.Text & "%' or adres like '%" & txtMusteriAra.Text & "%' order by ad")
        For i = 0 To dt.Rows.Count - 1
            Dim fotoYol As String = dt.Rows(i)("fotoYol").ToString()
            If Not File.Exists(Application.StartupPath & "/Resimler/" & fotoYol) Then
                fotoYol = "resimyok.png"
            End If
            DGmusteri.Rows.Add(Image.FromFile(Application.StartupPath & "/Resimler/" & fotoYol), dt.Rows(i)("TC").ToString(),
           dt.Rows(i)("ad").ToString(), dt.Rows(i)("soyad").ToString(),
           dt.Rows(i)("tel").ToString(), dt.Rows(i)("e_posta").ToString(), dt.Rows(i)("adres").ToString())
        Next
    End Sub

    Private Sub musteriler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGmusteri.Rows.Clear()
        Dim dt As DataTable = dtGetir("select * from musteriler order by ad")
        For i = 0 To dt.Rows.Count - 1
            Dim fotoYol As String = dt.Rows(i)("fotoYol").ToString()
            If Not File.Exists(Application.StartupPath & "/Resimler/" & fotoYol) Then
                fotoYol = "resimyok.png"
            End If
            DGmusteri.Rows.Add(Image.FromFile(Application.StartupPath & "/Resimler/" & fotoYol), dt.Rows(i)("TC").ToString(),
           dt.Rows(i)("ad").ToString(), dt.Rows(i)("soyad").ToString(),
           dt.Rows(i)("tel").ToString(), dt.Rows(i)("e_posta").ToString(), dt.Rows(i)("adres").ToString())
        Next
    End Sub

    Private Sub DGmusteri_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGmusteri.CellMouseClick
        Dim dt As DataTable = dtGetir("select * from musteriler where TC=" & Convert.ToDouble(DGmusteri.CurrentRow.Cells(1).Value.ToString()))
        For i = 0 To dt.Rows.Count - 1
            Dim fotoYol As String = dt.Rows(i)("fotoYol").ToString()
            If Not File.Exists(Application.StartupPath & "/Resimler/" & fotoYol) Then
                fotoYol = "resimyok.png"
            End If
            gmSat.txtTc.Text = dt.Rows(i)("TC").ToString()
            gmSat.txtAdi.Text = dt.Rows(i)("ad").ToString()
            gmSat.txtSoyadi.Text = dt.Rows(i)("soyad").ToString()
            gmSat.txtCep.Text = dt.Rows(i)("tel").ToString()
            gmSat.txtMail.Text = dt.Rows(i)("e_posta").ToString()
            gmSat.pbFoto.Image = Image.FromFile(Application.StartupPath & "/Resimler/" & fotoYol)
        Next
        gmSat.Show()
        Me.Close()
    End Sub
End Class