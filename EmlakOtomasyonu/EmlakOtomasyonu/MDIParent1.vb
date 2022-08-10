Imports System.IO
Imports System.Windows.Forms

Public Class MDIParent1
    Public Sub konutGetir()
        DGkonut.Rows.Clear()
        Dim dt As DataTable = dtGetir("select * from konutlar order by gmKodu")
        For i = 0 To dt.Rows.Count - 1
            Dim fotoYol As String = dt.Rows(i)("fotoYol").ToString()
            If Not File.Exists(Application.StartupPath & "/Resimler/" & fotoYol) Then
                fotoYol = "resimyok.png"
            End If
            DGkonut.Rows.Add(Image.FromFile(Application.StartupPath & "/Resimler/" & fotoYol), dt.Rows(i)("gmKodu").ToString(),
                             dt.Rows(i)("durumu").ToString(), dt.Rows(i)("sahibi").ToString(), dt.Rows(i)("fiyat").ToString(),
           dt.Rows(i)("kayTarihi").ToString(), dt.Rows(i)("turu").ToString(),
           dt.Rows(i)("sinifi").ToString(), dt.Rows(i)("katSayisi").ToString(), dt.Rows(i)("isinmaSekli").ToString(),
                              dt.Rows(i)("cephe").ToString(), dt.Rows(i)("odaSayisi").ToString(),
                             dt.Rows(i)("buyuklugu").ToString(), dt.Rows(i)("kiraSat").ToString(),
                              dt.Rows(i)("diger").ToString(), dt.Rows(i)("apAdi").ToString(),
                             dt.Rows(i)("binaNo").ToString(), dt.Rows(i)("cadde").ToString(), dt.Rows(i)("semt").ToString(),
                             dt.Rows(i)("mahalle").ToString(), dt.Rows(i)("ilce").ToString(), dt.Rows(i)("il").ToString(), dt.Rows(i)("acikAdres").ToString())
        Next
        kontrol()
    End Sub
    Public Sub arsaGetir()
        DGarsa.Rows.Clear()
        Dim dt As DataTable = dtGetir("select * from arsalar order by gmKodu")
        For i = 0 To dt.Rows.Count - 1
            Dim fotoYol As String = dt.Rows(i)("fotoYol").ToString()
            If Not File.Exists(Application.StartupPath & "/Resimler/" & fotoYol) Then
                fotoYol = "resimyok.png"
            End If
            DGarsa.Rows.Add(Image.FromFile(Application.StartupPath & "/Resimler/" & fotoYol), dt.Rows(i)("gmKodu").ToString(), dt.Rows(i)("durumu").ToString(), dt.Rows(i)("sahibi").ToString(),
           dt.Rows(i)("fiyat").ToString(), dt.Rows(i)("kayTarihi").ToString(), dt.Rows(i)("ada").ToString(), dt.Rows(i)("pafta").ToString(), dt.Rows(i)("parsel").ToString(), dt.Rows(i)("semt").ToString(), dt.Rows(i)("mahalle").ToString(), dt.Rows(i)("ilce").ToString(), dt.Rows(i)("il").ToString(), dt.Rows(i)("alan").ToString(), dt.Rows(i)("imarDurumu").ToString(), dt.Rows(i)("acikadres").ToString())
        Next
        kontrol()
    End Sub
    Public Sub isyeriGetir()
        DGisyeri.Rows.Clear()
        Dim dt As DataTable = dtGetir("select * from isyerleri order by gmKodu")
        For i = 0 To dt.Rows.Count - 1
            Dim fotoYol As String = dt.Rows(i)("fotoYol").ToString()
            If Not File.Exists(Application.StartupPath & "/Resimler/" & fotoYol) Then
                fotoYol = "resimyok.png"
            End If
            DGisyeri.Rows.Add(Image.FromFile(Application.StartupPath & "/Resimler/" & fotoYol), dt.Rows(i)("gmKodu").ToString(), dt.Rows(i)("durumu").ToString(), dt.Rows(i)("sahibi").ToString(), dt.Rows(i)("fiyat").ToString(),
           dt.Rows(i)("kayTarihi").ToString(), dt.Rows(i)("turu").ToString(),
           dt.Rows(i)("sinifi").ToString(), dt.Rows(i)("katSayisi").ToString(), dt.Rows(i)("isinmaSekli").ToString(), dt.Rows(i)("cephe").ToString(),
                              dt.Rows(i)("buyuklugu").ToString(), dt.Rows(i)("odaSayisi").ToString(),
                              dt.Rows(i)("diger").ToString(), dt.Rows(i)("apAdi").ToString(), dt.Rows(i)("binaNo").ToString(),
                              dt.Rows(i)("cadde").ToString(), dt.Rows(i)("semt").ToString(), dt.Rows(i)("mahalle").ToString(),
                              dt.Rows(i)("ilce").ToString(), dt.Rows(i)("il").ToString(),
                              dt.Rows(i)("acikAdres").ToString())
        Next
        kontrol()
    End Sub
    Public Sub musteriGetir()
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
        kontrol()
    End Sub

    Private Sub btnKonutGoster_Click(sender As Object, e As EventArgs) Handles btnKonutGoster.Click
        konutGetir()
    End Sub

    Private Sub txtKonutAra_TextChanged(sender As Object, e As EventArgs) Handles txtKonutAra.TextChanged
        DGkonut.Rows.Clear()
        Dim dt As DataTable = dtGetir("select * from konutlar where sahibi like '%" & txtKonutAra.Text & "%' or turu like '%" & txtKonutAra.Text & "%' or sinifi like '%" & txtKonutAra.Text & "%' or isinmaSekli like '%" & txtKonutAra.Text & "%' or cephe like '%" & txtKonutAra.Text & "%' or il like '%" & txtKonutAra.Text & "%' or ilce like '%" & txtKonutAra.Text & "%' or fiyat like '%" & txtKonutAra.Text & "%' or buyuklugu like '%" & txtKonutAra.Text & "%' order by gmKodu")
        For i = 0 To dt.Rows.Count - 1
            Dim fotoYol As String = dt.Rows(i)("fotoYol").ToString()
            If Not File.Exists(Application.StartupPath & "/Resimler/" & fotoYol) Then
                fotoYol = "resimyok.png"
            End If
            DGkonut.Rows.Add(Image.FromFile(Application.StartupPath & "/Resimler/" & fotoYol), dt.Rows(i)("gmKodu").ToString(),
                             dt.Rows(i)("durumu").ToString(), dt.Rows(i)("sahibi").ToString(), dt.Rows(i)("fiyat").ToString(),
           dt.Rows(i)("kayTarihi").ToString(), dt.Rows(i)("turu").ToString(),
           dt.Rows(i)("sinifi").ToString(), dt.Rows(i)("katSayisi").ToString(), dt.Rows(i)("isinmaSekli").ToString(),
                              dt.Rows(i)("cephe").ToString(), dt.Rows(i)("odaSayisi").ToString(),
                             dt.Rows(i)("buyuklugu").ToString(), dt.Rows(i)("kiraSat").ToString(),
                              dt.Rows(i)("diger").ToString(), dt.Rows(i)("apAdi").ToString(),
                             dt.Rows(i)("binaNo").ToString(), dt.Rows(i)("cadde").ToString(), dt.Rows(i)("semt").ToString(),
                             dt.Rows(i)("mahalle").ToString(), dt.Rows(i)("ilce").ToString(), dt.Rows(i)("il").ToString(), dt.Rows(i)("acikAdres").ToString())
        Next
    End Sub

    Private Sub btnKonutEkle_Click(sender As Object, e As EventArgs) Handles btnKonutEkle.Click
        konutKayit.txtSahibi.Text = 0
        konutKayit.txtGmKodu.Text = 0
        konutKayit.txtdurumu.Text = "Boşta"
        konutKayit.btnGuncelle.Enabled = False
        konutKayit.Show()
    End Sub

    Private Sub btnKonutDuzenle_Click(sender As Object, e As EventArgs) Handles btnKonutDuzenle.Click
        If DGkonut.CurrentRow.Cells(1).Value = 0 Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        Dim dt As DataTable = dtGetir("select * from konutlar where gmKodu=" & Convert.ToDouble(DGkonut.CurrentRow.Cells(1).Value.ToString()))
        konutKayit.Show()
        konutKayit.txtGmKodu.Enabled = False
        konutKayit.btnKaydet.Enabled = False
        For i = 0 To dt.Rows.Count - 1
            Dim fotoYol As String = dt.Rows(i)("fotoYol").ToString()
            If Not File.Exists(Application.StartupPath & "/Resimler/" & fotoYol) Then
                fotoYol = "resimyok.png"
            End If
            konutKayit.txtGmKodu.Text = dt.Rows(i)("gmKodu").ToString()
            konutKayit.txtDurumu.Text = dt.Rows(i)("durumu").ToString()
            konutKayit.cbTuru.Text = dt.Rows(i)("turu").ToString()
            konutKayit.cbSinifi.Text = dt.Rows(i)("sinifi").ToString()
            konutKayit.cbKatSayisi.Text = dt.Rows(i)("katSayisi").ToString()
            konutKayit.cbIsinma.Text = dt.Rows(i)("isinmaSekli").ToString()
            konutKayit.cbCephe.Text = dt.Rows(i)("cephe").ToString()
            konutKayit.cbOdaSayisi.Text = dt.Rows(i)("odaSayisi").ToString()
            konutKayit.txtBuyuklugu.Text = dt.Rows(i)("buyuklugu").ToString()
            konutKayit.cbKiraSat.Text = dt.Rows(i)("kiraSat").ToString()
            konutKayit.txtFiyat.Text = dt.Rows(i)("fiyat").ToString()
            konutKayit.txtSahibi.Text = dt.Rows(i)("sahibi").ToString()
            konutKayit.txtDiger.Text = dt.Rows(i)("diger").ToString()
            konutKayit.txtApAdi.Text = dt.Rows(i)("apAdi").ToString()
            konutKayit.txtBinaNo.Text = dt.Rows(i)("binaNo").ToString()
            konutKayit.txtCadde.Text = dt.Rows(i)("cadde").ToString()
            konutKayit.txtSemt.Text = dt.Rows(i)("semt").ToString()
            konutKayit.txtMahalle.Text = dt.Rows(i)("mahalle").ToString()
            konutKayit.cbILce.Text = dt.Rows(i)("ilce").ToString()
            konutKayit.cbIL.Text = dt.Rows(i)("il").ToString()
            konutKayit.txtAcikAdres.Text = dt.Rows(i)("acikAdres").ToString()
            konutKayit.pbFoto.Image = Image.FromFile(Application.StartupPath & "/Resimler/" & fotoYol)
        Next
    End Sub

    Private Sub btnKonutSil_Click(sender As Object, e As EventArgs) Handles btnKonutSil.Click
        Dim gmKodu As Integer = DGkonut.CurrentRow.Cells(1).Value
        If DGkonut.CurrentRow.Cells(1).Value = 0 Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        If MsgBox("Konut Kaydı Silinecektir! Onaylıyor musunuz?", vbYesNo, "Konut Kaydı Silme") = MsgBoxResult.No Then
            Return
        End If
        sqlCalistir("delete from konutlar where gmKodu=" & gmKodu)
        MsgBox("Konut Silindi", MsgBoxStyle.Information, "İşlem Tamam")
        konutGetir()
    End Sub

    Private Sub btnArsaGoster_Click(sender As Object, e As EventArgs) Handles btnArsaGoster.Click
        arsaGetir()
    End Sub

    Private Sub txtArsaAra_TextChanged(sender As Object, e As EventArgs) Handles txtArsaAra.TextChanged
        DGarsa.Rows.Clear()
        Dim dt As DataTable = dtGetir("select * from arsalar where semt like '%" & txtArsaAra.Text & "%' or fiyat like '%" & txtArsaAra.Text & "%' or mahalle like '%" & txtArsaAra.Text & "%' or il like '%" & txtArsaAra.Text & "%' or ilce like '%" & txtArsaAra.Text & "%' or alan like '%" & txtArsaAra.Text & "%' order by gmKodu")
        For i = 0 To dt.Rows.Count - 1
            Dim fotoYol As String = dt.Rows(i)("fotoYol").ToString()
            If Not File.Exists(Application.StartupPath & "/Resimler/" & fotoYol) Then
                fotoYol = "resimyok.png"
            End If
            DGarsa.Rows.Add(Image.FromFile(Application.StartupPath & "/Resimler/" & fotoYol), dt.Rows(i)("gmKodu").ToString(), dt.Rows(i)("durumu").ToString(), dt.Rows(i)("sahibi").ToString(),
           dt.Rows(i)("fiyat").ToString(), dt.Rows(i)("kayTarihi").ToString(), dt.Rows(i)("ada").ToString(), dt.Rows(i)("pafta").ToString(), dt.Rows(i)("parsel").ToString(), dt.Rows(i)("semt").ToString(), dt.Rows(i)("mahalle").ToString(), dt.Rows(i)("ilce").ToString(), dt.Rows(i)("il").ToString(), dt.Rows(i)("alan").ToString(), dt.Rows(i)("imarDurumu").ToString(), dt.Rows(i)("acikadres").ToString())
        Next
    End Sub

    Private Sub btnArsaEkle_Click(sender As Object, e As EventArgs) Handles btnArsaEkle.Click
        arsaKayit.txtSahibi.Text = 0
        arsaKayit.txtGmKodu.Text = 0
        arsaKayit.txtDurumu.Text = "Boşta"
        arsaKayit.btnGuncelle.Enabled = False
        arsaKayit.Show()
    End Sub

    Private Sub btnArsaDuzenle_Click(sender As Object, e As EventArgs) Handles btnArsaDuzenle.Click
        If DGarsa.CurrentRow.Cells(1).Value = 0 Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        Dim dt As DataTable = dtGetir("select * from arsalar where gmKodu=" & Convert.ToDouble(DGarsa.CurrentRow.Cells(1).Value.ToString()))
        arsaKayit.Show()
        arsaKayit.txtGmKodu.Enabled = False
        arsaKayit.btnKaydet.Enabled = False
        For i = 0 To dt.Rows.Count - 1
            Dim fotoYol As String = dt.Rows(i)("fotoYol").ToString()
            If Not File.Exists(Application.StartupPath & "/Resimler/" & fotoYol) Then
                fotoYol = "resimyok.png"
            End If
            arsaKayit.txtGmKodu.Text = dt.Rows(i)("gmKodu").ToString()
            arsaKayit.txtDurumu.Text = dt.Rows(i)("durumu").ToString()
            arsaKayit.txtAda.Text = dt.Rows(i)("ada").ToString()
            arsaKayit.txtPafta.Text = dt.Rows(i)("pafta").ToString()
            arsaKayit.txtParsel.Text = dt.Rows(i)("parsel").ToString()
            arsaKayit.txtSemt.Text = dt.Rows(i)("semt").ToString()
            arsaKayit.txtMahalle.Text = dt.Rows(i)("mahalle").ToString()
            arsaKayit.cbILce.Text = dt.Rows(i)("ilce").ToString()
            arsaKayit.cbIL.Text = dt.Rows(i)("il").ToString()
            arsaKayit.txtAlan.Text = dt.Rows(i)("alan").ToString()
            arsaKayit.txtAcikAdres.Text = dt.Rows(i)("imarDurumu").ToString()
            arsaKayit.cbImar.Text = dt.Rows(i)("acikadres").ToString()
            arsaKayit.txtFiyat.Text = dt.Rows(i)("fiyat").ToString()
            arsaKayit.txtSahibi.Text = dt.Rows(i)("sahibi").ToString()
            arsaKayit.pbFoto.Image = Image.FromFile(Application.StartupPath & "/Resimler/" & fotoYol)
        Next
    End Sub

    Private Sub btnArsaSil_Click(sender As Object, e As EventArgs) Handles btnArsaSil.Click
        Dim gmKodu As Integer = DGarsa.CurrentRow.Cells(1).Value
        If DGarsa.CurrentRow.Cells(1).Value = 0 Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        If MsgBox("Arsa Kaydı Silinecektir! Onaylıyor musunuz?", vbYesNo, "Arsa Kaydı Silme") = MsgBoxResult.No Then
            Return
        End If
        sqlCalistir("delete from arsalar where gmKodu=" & gmKodu)
        MsgBox("Arsa Silindi", MsgBoxStyle.Information, "İşlem Tamam")
        arsaGetir()
    End Sub

    Private Sub btnIsyeriGoster_Click(sender As Object, e As EventArgs) Handles btnIsyeriGoster.Click
        isyeriGetir()
    End Sub

    Private Sub txtIsyeriAra_TextChanged(sender As Object, e As EventArgs) Handles txtIsyeriAra.TextChanged
        DGisyeri.Rows.Clear()
        Dim dt As DataTable = dtGetir("select * from isyerleri where sahibi like '%" & txtIsyeriAra.Text & "%' or turu like '%" & txtIsyeriAra.Text & "%' or sinifi like '%" & txtIsyeriAra.Text & "%' or isinmaSekli like '%" & txtIsyeriAra.Text & "%' or cephe like '%" & txtIsyeriAra.Text & "%' or il like '%" & txtIsyeriAra.Text & "%' or ilce like '%" & txtIsyeriAra.Text & "%' or fiyat like '%" & txtIsyeriAra.Text & "%' or buyuklugu like '%" & txtIsyeriAra.Text & "%' order by gmKodu")
        For i = 0 To dt.Rows.Count - 1
            Dim fotoYol As String = dt.Rows(i)("fotoYol").ToString()
            If Not File.Exists(Application.StartupPath & "/Resimler/" & fotoYol) Then
                fotoYol = "resimyok.png"
            End If
            DGisyeri.Rows.Add(Image.FromFile(Application.StartupPath & "/Resimler/" & fotoYol), dt.Rows(i)("gmKodu").ToString(), dt.Rows(i)("durumu").ToString(), dt.Rows(i)("sahibi").ToString(), dt.Rows(i)("fiyat").ToString(),
           dt.Rows(i)("kayTarihi").ToString(), dt.Rows(i)("turu").ToString(),
           dt.Rows(i)("sinifi").ToString(), dt.Rows(i)("katSayisi").ToString(), dt.Rows(i)("isinmaSekli").ToString(), dt.Rows(i)("cephe").ToString(),
                              dt.Rows(i)("buyuklugu").ToString(), dt.Rows(i)("odaSayisi").ToString(),
                              dt.Rows(i)("diger").ToString(), dt.Rows(i)("apAdi").ToString(), dt.Rows(i)("binaNo").ToString(),
                              dt.Rows(i)("cadde").ToString(), dt.Rows(i)("semt").ToString(), dt.Rows(i)("mahalle").ToString(),
                              dt.Rows(i)("ilce").ToString(), dt.Rows(i)("il").ToString(),
                              dt.Rows(i)("acikAdres").ToString())
        Next
    End Sub

    Private Sub btnIsyeriEkle_Click(sender As Object, e As EventArgs) Handles btnIsyeriEkle.Click
        isyeriKayit.txtSahibi.Text = 0
        isyeriKayit.txtGmKodu.Text = 0
        isyeriKayit.txtDurumu.Text = "Boşta"
        isyeriKayit.btnGuncelle.Enabled = False
        isyeriKayit.Show()
    End Sub

    Private Sub btnIsyeriDuzenle_Click(sender As Object, e As EventArgs) Handles btnIsyeriDuzenle.Click
        If DGisyeri.CurrentRow.Cells(1).Value = 0 Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        Dim dt As DataTable = dtGetir("select * from isyerleri where gmKodu=" & Convert.ToDouble(DGisyeri.CurrentRow.Cells(1).Value.ToString()))
        isyeriKayit.Show()
        isyeriKayit.txtGmKodu.Enabled = False
        isyeriKayit.btnKaydet.Enabled = False
        For i = 0 To dt.Rows.Count - 1
            Dim fotoYol As String = dt.Rows(i)("fotoYol").ToString()
            If Not File.Exists(Application.StartupPath & "/Resimler/" & fotoYol) Then
                fotoYol = "resimyok.png"
            End If
            isyeriKayit.txtGmKodu.Text = dt.Rows(i)("gmKodu").ToString()
            isyeriKayit.txtDurumu.Text = dt.Rows(i)("durumu").ToString()
            isyeriKayit.cbTuru.Text = dt.Rows(i)("turu").ToString()
            isyeriKayit.cbSinifi.Text = dt.Rows(i)("sinifi").ToString()
            isyeriKayit.cbKatSayisi.Text = dt.Rows(i)("katSayisi").ToString()
            isyeriKayit.cbIsinma.Text = dt.Rows(i)("isinmaSekli").ToString()
            isyeriKayit.cbCephe.Text = dt.Rows(i)("cephe").ToString()
            isyeriKayit.txtBuyuklugu.Text = dt.Rows(i)("buyuklugu").ToString()
            isyeriKayit.cbOdaSayisi.Text = dt.Rows(i)("odaSayisi").ToString()
            isyeriKayit.txtDiger.Text = dt.Rows(i)("diger").ToString()
            isyeriKayit.txtApAdi.Text = dt.Rows(i)("apAdi").ToString()
            isyeriKayit.txtSemt.Text = dt.Rows(i)("semt").ToString()
            isyeriKayit.txtMahalle.Text = dt.Rows(i)("mahalle").ToString()
            isyeriKayit.txtCadde.Text = dt.Rows(i)("cadde").ToString()
            isyeriKayit.txtBinaNo.Text = dt.Rows(i)("binaNo").ToString()
            isyeriKayit.cbILce.Text = dt.Rows(i)("ilce").ToString()
            isyeriKayit.cbIL.Text = dt.Rows(i)("il").ToString()
            isyeriKayit.txtFiyat.Text = dt.Rows(i)("fiyat").ToString()
            isyeriKayit.txtSahibi.Text = dt.Rows(i)("sahibi").ToString()
            isyeriKayit.txtAcikAdres.Text = dt.Rows(i)("acikAdres").ToString()
            isyeriKayit.pbFoto.Image = Image.FromFile(Application.StartupPath & "/Resimler/" & fotoYol)
        Next
    End Sub

    Private Sub btnIsyeriSil_Click(sender As Object, e As EventArgs) Handles btnIsyeriSil.Click
        Dim gmKodu As Integer = DGisyeri.CurrentRow.Cells(1).Value
        If DGisyeri.CurrentRow.Cells(1).Value = 0 Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        If MsgBox("İşyeri Kaydı Silinecektir! Onaylıyor musunuz?", vbYesNo, "İşyeri Kaydı Silme") = MsgBoxResult.No Then
            Return
        End If
        sqlCalistir("delete from isyerleri where gmKodu=" & gmKodu)
        MsgBox("İşyeri Silindi", MsgBoxStyle.Information, "İşlem Tamam")
        isyeriGetir()
    End Sub

    Private Sub btnMusteriGoster_Click(sender As Object, e As EventArgs) Handles btnMusteriGoster.Click
        musteriGetir()
    End Sub

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

    Private Sub btnKisiEkle_Click(sender As Object, e As EventArgs) Handles btnKisiEkle.Click
        musteriKayit.btnGuncelle.Enabled = False
        musteriKayit.Show()
    End Sub

    Private Sub btnKisiDuzenle_Click(sender As Object, e As EventArgs) Handles btnKisiDuzenle.Click
        If DGmusteri.CurrentRow.Cells(1).Value = 0 Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        Dim dt As DataTable = dtGetir("select * from musteriler where TC=" & Convert.ToDouble(DGmusteri.CurrentRow.Cells(1).Value.ToString()))
        musteriKayit.Show()
        musteriKayit.txtTc.Enabled = False
        musteriKayit.btnKaydet.Enabled = False
        For i = 0 To dt.Rows.Count - 1
            Dim fotoYol As String = dt.Rows(i)("fotoYol").ToString()
            If Not File.Exists(Application.StartupPath & "/Resimler/" & fotoYol) Then
                fotoYol = "resimyok.png"
            End If
            musteriKayit.txtTc.Text = dt.Rows(i)("TC").ToString()
            musteriKayit.txtAdi.Text = dt.Rows(i)("ad").ToString()
            musteriKayit.txtSoyadi.Text = dt.Rows(i)("soyad").ToString()
            musteriKayit.txtCep.Text = dt.Rows(i)("tel").ToString()
            musteriKayit.txtMail.Text = dt.Rows(i)("e_posta").ToString()
            musteriKayit.txtAdres.Text = dt.Rows(i)("adres").ToString()
            musteriKayit.pbFoto.Image = Image.FromFile(Application.StartupPath & "/Resimler/" & fotoYol)
        Next
    End Sub

    Private Sub btnKisiSil_Click(sender As Object, e As EventArgs) Handles btnKisiSil.Click
        Dim TC As Double = DGmusteri.CurrentRow.Cells(1).Value
        If DGmusteri.CurrentRow.Cells(1).Value = 0 Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        If MsgBox("Müşteri Kaydı Silinecektir! Onaylıyor musunuz?", vbYesNo, "Müşteri Kaydı Silme") = MsgBoxResult.No Then
            Return
        End If
        sqlCalistir("delete from musteriler where TC=" & TC)
        MsgBox("Müşteri Silindi", MsgBoxStyle.Information, "İşlem Tamam")
        musteriGetir()
    End Sub
    Private Sub kontrol()
        If DGkonut.Rows.Count < 1 Then
            btnKonutDuzenle.Enabled = False
            txtKonutAra.Enabled = False
            btnKonutSil.Enabled = False
            btnKonutSat.Enabled = False
            btnKonutBosalt.Enabled = False
        Else
            btnKonutDuzenle.Enabled = True
            txtKonutAra.Enabled = True
            btnKonutSil.Enabled = True
            btnKonutSat.Enabled = True
            btnKonutBosalt.Enabled = True
        End If
        If DGarsa.Rows.Count < 1 Then
            btnArsaDuzenle.Enabled = False
            txtArsaAra.Enabled = False
            btnArsaSil.Enabled = False
            btnArsaSat.Enabled = False
            btnArsaBosalt.Enabled = False
        Else
            btnArsaDuzenle.Enabled = True
            txtArsaAra.Enabled = True
            btnArsaSil.Enabled = True
            btnArsaSat.Enabled = True
            btnArsaBosalt.Enabled = True
        End If
        If DGisyeri.Rows.Count < 1 Then
            btnIsyeriDuzenle.Enabled = False
            txtIsyeriAra.Enabled = False
            btnIsyeriSil.Enabled = False
            btnIsyeriSat.Enabled = False
            btnIsyeriBosalt.Enabled = False
        Else
            btnIsyeriDuzenle.Enabled = True
            txtIsyeriAra.Enabled = True
            btnIsyeriSil.Enabled = True
            btnIsyeriSat.Enabled = True
            btnIsyeriBosalt.Enabled = True
        End If
        If DGmusteri.Rows.Count < 1 Then
            btnKisiDuzenle.Enabled = False
            txtMusteriAra.Enabled = False
            btnKisiSil.Enabled = False
        Else
            btnKisiDuzenle.Enabled = True
            txtMusteriAra.Enabled = True
            btnKisiSil.Enabled = True
        End If
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kontrol()
    End Sub

    Private Sub btnKonutSat_Click(sender As Object, e As EventArgs) Handles btnKonutSat.Click
        If DGkonut.CurrentRow.Cells(3).Value > 0 Then
            If MsgBox("Gayrimenkulun sahibi vardır! Devam Etmek İstiyor musunuz?", vbYesNo, "Onay Mesajı") = MsgBoxResult.No Then
                Return
            End If
        End If
        konutBilgileri()
    End Sub

    Private Sub btnArsaSat_Click(sender As Object, e As EventArgs) Handles btnArsaSat.Click
        If DGarsa.CurrentRow.Cells(3).Value > 0 Then
            If MsgBox("Gayrimenkulun sahibi vardır! Devam Etmek İstiyor musunuz?", vbYesNo, "Onay Mesajı") = MsgBoxResult.No Then
                Return
            End If
        End If
        ArsaBilgileri()
    End Sub

    Private Sub btnIsyeriSat_Click(sender As Object, e As EventArgs) Handles btnIsyeriSat.Click
        If DGisyeri.CurrentRow.Cells(3).Value > 0 Then
            If MsgBox("Gayrimenkulun sahibi vardır! Devam Etmek İstiyor musunuz?", vbYesNo, "Onay Mesajı") = MsgBoxResult.No Then
                Return
            End If
        End If
        isyeriBilgileri()
    End Sub
    Public Sub ArsaBilgileri()
        If DGarsa.CurrentRow.Cells(1).Value = 0 Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        Dim dt As DataTable = dtGetir("select * from arsalar where gmKodu=" & Convert.ToDouble(DGarsa.CurrentRow.Cells(1).Value.ToString()))
        gmSat.Show()
        gmSat.Label28.Text = "Arsa Bilgileri"
        For i = 0 To dt.Rows.Count - 1
            Dim fotoYol As String = dt.Rows(i)("fotoYol").ToString()
            If Not File.Exists(Application.StartupPath & "/Resimler/" & fotoYol) Then
                fotoYol = "resimyok.png"
            End If
            gmSat.txtGmKodu.Text = dt.Rows(i)("gmKodu").ToString()
            gmSat.txtKayitTarihi.Text = dt.Rows(i)("kayTarihi").ToString()
            gmSat.txtAda.Text = dt.Rows(i)("ada").ToString()
            gmSat.txtPafta.Text = dt.Rows(i)("pafta").ToString()
            gmSat.txtParsel.Text = dt.Rows(i)("parsel").ToString()
            gmSat.cbImar.Text = dt.Rows(i)("imarDurumu").ToString()
            gmSat.cbILce.Text = dt.Rows(i)("ilce").ToString()
            gmSat.cbIL.Text = dt.Rows(i)("il").ToString()
            gmSat.txtAcikAdres.Text = dt.Rows(i)("acikadres").ToString()
            gmSat.pbGmFoto.Image = Image.FromFile(Application.StartupPath & "/Resimler/" & fotoYol)
        Next
    End Sub

    Public Sub konutBilgileri()
        If DGkonut.CurrentRow.Cells(1).Value = 0 Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        Dim dt As DataTable = dtGetir("select * from konutlar where gmKodu=" & Convert.ToDouble(DGkonut.CurrentRow.Cells(1).Value.ToString()))
        gmSat.Show()
        gmSat.Label28.Text = "Konut Bilgileri"
        For i = 0 To dt.Rows.Count - 1
            Dim fotoYol As String = dt.Rows(i)("fotoYol").ToString()
            If Not File.Exists(Application.StartupPath & "/Resimler/" & fotoYol) Then
                fotoYol = "resimyok.png"
            End If
            gmSat.txtGmKodu.Text = dt.Rows(i)("gmKodu").ToString()
            gmSat.txtKayitTarihi.Text = dt.Rows(i)("kayTarihi").ToString()
            gmSat.cbTuru.Text = dt.Rows(i)("turu").ToString()
            gmSat.cbSinifi.Text = dt.Rows(i)("sinifi").ToString()
            gmSat.cbKatSayisi.Text = dt.Rows(i)("katSayisi").ToString()
            gmSat.cbIsinma.Text = dt.Rows(i)("isinmaSekli").ToString()
            gmSat.cbCephe.Text = dt.Rows(i)("cephe").ToString()
            gmSat.cbOdaSayisi.Text = dt.Rows(i)("odaSayisi").ToString()
            gmSat.txtBuyuklugu.Text = dt.Rows(i)("buyuklugu").ToString()
            gmSat.txtFiyat.Text = dt.Rows(i)("fiyat").ToString()
            gmSat.cbILce.Text = dt.Rows(i)("ilce").ToString()
            gmSat.cbIL.Text = dt.Rows(i)("il").ToString()
            gmSat.txtAcikAdres.Text = dt.Rows(i)("acikAdres").ToString()
            gmSat.pbGmFoto.Image = Image.FromFile(Application.StartupPath & "/Resimler/" & fotoYol)
        Next
    End Sub

    Public Sub isyeriBilgileri()
        If DGisyeri.CurrentRow.Cells(1).Value = 0 Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        Dim dt As DataTable = dtGetir("select * from isyerleri where gmKodu=" & Convert.ToDouble(DGisyeri.CurrentRow.Cells(1).Value.ToString()))
        gmSat.Show()
        gmSat.Label28.Text = "İşyeri Bilgileri"
        For i = 0 To dt.Rows.Count - 1
            Dim fotoYol As String = dt.Rows(i)("fotoYol").ToString()
            If Not File.Exists(Application.StartupPath & "/Resimler/" & fotoYol) Then
                fotoYol = "resimyok.png"
            End If
            gmSat.txtGmKodu.Text = dt.Rows(i)("gmKodu").ToString()
            gmSat.txtKayitTarihi.Text = dt.Rows(i)("kayTarihi").ToString()
            gmSat.cbTuru.Text = dt.Rows(i)("turu").ToString()
            gmSat.cbSinifi.Text = dt.Rows(i)("sinifi").ToString()
            gmSat.cbKatSayisi.Text = dt.Rows(i)("katSayisi").ToString()
            gmSat.cbIsinma.Text = dt.Rows(i)("isinmaSekli").ToString()
            gmSat.cbCephe.Text = dt.Rows(i)("cephe").ToString()
            gmSat.cbOdaSayisi.Text = dt.Rows(i)("odaSayisi").ToString()
            gmSat.txtBuyuklugu.Text = dt.Rows(i)("buyuklugu").ToString()
            gmSat.txtFiyat.Text = dt.Rows(i)("fiyat").ToString()
            gmSat.cbILce.Text = dt.Rows(i)("ilce").ToString()
            gmSat.cbIL.Text = dt.Rows(i)("il").ToString()
            gmSat.txtAcikAdres.Text = dt.Rows(i)("acikAdres").ToString()
            gmSat.pbGmFoto.Image = Image.FromFile(Application.StartupPath & "/Resimler/" & fotoYol)
        Next
    End Sub
    Private Sub btnArsaBosalt_Click(sender As Object, e As EventArgs) Handles btnArsaBosalt.Click
        If DGarsa.CurrentRow.Cells(1).Value = 0 Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        If MsgBox("Arsa Boşaltılacaktır! Onaylıyor musunuz?", vbYesNo, "Arsa Kaydı Boşaltma") = MsgBoxResult.No Then
            Return
        End If
        sqlCalistir("update arsalar set sahibi='" & 0 & "' where gmKodu=" & Convert.ToDouble(DGarsa.CurrentRow.Cells(1).Value.ToString()))
        sqlCalistir("update arsalar set durumu='" & "Boşta" & "' where gmKodu=" & Convert.ToDouble(DGarsa.CurrentRow.Cells(1).Value.ToString()))
        MsgBox("Arsa Boşaltıldı", MsgBoxStyle.Information, "İşlem Tamam")
        arsaGetir()
    End Sub

    Private Sub btnIsyeriBosalt_Click(sender As Object, e As EventArgs) Handles btnIsyeriBosalt.Click
        If DGkonut.CurrentRow.Cells(1).Value = 0 Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        If MsgBox("İşyeri Boşaltılacaktır! Onaylıyor musunuz?", vbYesNo, "İşyeri Kaydı Boşaltma") = MsgBoxResult.No Then
            Return
        End If
        sqlCalistir("update isyerleri set sahibi='" & 0 & "' where gmKodu=" & Convert.ToDouble(DGisyeri.CurrentRow.Cells(1).Value.ToString()))
        sqlCalistir("update isyerleri set durumu='" & "Boşta" & "' where gmKodu=" & Convert.ToDouble(DGisyeri.CurrentRow.Cells(1).Value.ToString()))
        MsgBox("İşyeri Boşaltıldı", MsgBoxStyle.Information, "İşlem Tamam")
        isyeriGetir()
    End Sub

    Private Sub btnKonutBosalt_Click(sender As Object, e As EventArgs) Handles btnKonutBosalt.Click
        If DGkonut.CurrentRow.Cells(1).Value = 0 Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        If MsgBox("Konut Boşaltılacaktır! Onaylıyor musunuz?", vbYesNo, "Konut Kaydı Boşaltma") = MsgBoxResult.No Then
            Return
        End If
        sqlCalistir("update konutlar set sahibi='" & 0 & "' where gmKodu=" & Convert.ToDouble(DGkonut.CurrentRow.Cells(1).Value.ToString()))
        sqlCalistir("update konutlar set durumu='" & "Boşta" & "' where gmKodu=" & Convert.ToDouble(DGkonut.CurrentRow.Cells(1).Value.ToString()))
        MsgBox("Konut Boşaltıldı", MsgBoxStyle.Information, "İşlem Tamam")
        konutGetir()
    End Sub
End Class
