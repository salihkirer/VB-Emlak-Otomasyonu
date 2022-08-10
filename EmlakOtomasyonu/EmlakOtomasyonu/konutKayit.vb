Imports System.IO

Public Class konutKayit
    Private Sub btnFotoEkle_Click(sender As Object, e As EventArgs) Handles btnFotoEkle.Click
        OpenFileDialog1.Filter = "JPG Dosyaları|*.jpg|GIF Dosyaları|*.gif|PNG Dosyaları|*.png"
        If OpenFileDialog1.ShowDialog = DialogResult.Cancel Then
            Return
        End If
        pbFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub
    Private Sub btnSat_Click(sender As Object, e As EventArgs) Handles btnSat.Click
        If (Convert.ToDouble(txtSahibi.Text) > 0) Then
            If MsgBox("Gayrimenkulun sahibi vardır! Devam Etmek İstiyor musunuz?", vbYesNo, "Onay Mesajı") = MsgBoxResult.No Then
                Return
            End If
        End If
        MDIParent1.konutBilgileri()
        Me.Close()

    End Sub

    Private Sub txtBuyuklugu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuyuklugu.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtFiyat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiyat.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtBinaNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBinaNo.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnGoster_Click(sender As Object, e As EventArgs) Handles btnGoster.Click
        Dim dt As DataTable = dtGetir("select * from musteriler where TC=" & Convert.ToDouble(txtSahibi.Text))
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
    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        For Each kontrol As Control In Me.Controls
            If TypeOf kontrol Is TextBox Then
                If kontrol.Text = String.Empty Then
                    MessageBox.Show(Convert.ToString(DirectCast(kontrol, TextBox).Tag + "Lütfen Tüm Alanları Doldurunuz!"))
                End If
            End If
        Next
        If pbFoto.Image Is Nothing Then
            MsgBox("Lütfen Resim Seçiniz!", MsgBoxStyle.Critical, "Hata")
            Return
        End If
        Dim uzanti As String = Path.GetExtension(OpenFileDialog1.FileName)
        Dim dosyaAdi As String = String.Format("{0:yyyyMMddHHmmss}", Now) & uzanti
        pbFoto.Image.Save(Application.StartupPath & "/Resimler/" & dosyaAdi)
        sqlCalistir("insert into konutlar (kayTarihi,turu,sinifi,katSayisi,isinmaSekli,cephe,odaSayisi,buyuklugu,kiraSat,fiyat,sahibi,diger,apAdi,binaNo,cadde,semt,mahalle,ilce,il,acikAdres,fotoYol,durumu) values ('" & DateTime.Now & "','" & cbTuru.Text & "','" & cbSinifi.Text & "','" & cbKatSayisi.Text & "','" & cbIsinma.Text & "','" & cbCephe.Text & "','" & cbOdaSayisi.Text & "','" & txtBuyuklugu.Text & "','" & cbKiraSat.Text & "','" & txtFiyat.Text & "','" & txtSahibi.Text & "','" & txtDiger.Text & "','" & txtApAdi.Text & "','" & txtBinaNo.Text & "','" & txtCadde.Text & "','" & txtSemt.Text & "','" & txtMahalle.Text & "','" & cbILce.Text & "','" & cbIL.Text & "','" & txtAcikAdres.Text & "','" & dosyaAdi & "','" & "Boşta" & "')")
        MDIParent1.konutGetir()
        Me.Close()
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        For Each kontrol As Control In Me.Controls
            If TypeOf kontrol Is TextBox Then
                If kontrol.Text = String.Empty Then
                    MessageBox.Show(Convert.ToString(DirectCast(kontrol, TextBox).Tag + "Lütfen Tüm Alanları Doldurunuz!"))
                End If
            End If
        Next
        If pbFoto.Image Is Nothing Then
            MsgBox("Lütfen Resim Seçiniz!", MsgBoxStyle.Critical, "Hata")
            Return
        End If
        Dim uzanti As String = Path.GetExtension(OpenFileDialog1.FileName)
        Dim dosyaAdi As String = String.Format("{0:yyyyMMddHHmmss}", Now) & uzanti
        pbFoto.Image.Save(Application.StartupPath & "/Resimler/" & dosyaAdi)
        If MsgBox("Konut Bilgileri Güncellenecektir! Onaylıyor musunuz?", vbYesNo, "Konut Kaydı Güncelleme") = MsgBoxResult.No Then
            Return
        End If
        sqlCalistir("update konutlar set turu='" & cbTuru.Text & "',sinifi='" & cbSinifi.Text & "',katSayisi='" & cbKatSayisi.Text & "',isinmaSekli='" & cbIsinma.Text & "',cephe='" & cbCephe.Text & "',odaSayisi='" & cbOdaSayisi.Text & "',buyuklugu='" & txtBuyuklugu.Text & "',kiraSat='" & cbKiraSat.Text & "',fiyat='" & txtFiyat.Text & "',sahibi='" & txtSahibi.Text & "',diger='" & txtDiger.Text & "',apAdi='" & txtApAdi.Text & "',binaNo='" & txtBinaNo.Text & "',cadde='" & txtCadde.Text & "',semt='" & txtSemt.Text & "',mahalle='" & txtMahalle.Text & "',ilce='" & cbILce.Text & "',il='" & cbIL.Text & "',acikAdres='" & txtAcikAdres.Text & "',fotoYol='" & dosyaAdi & "' where gmKodu=" & Convert.ToDouble(txtGmKodu.Text))
        MsgBox("Konut Güncellendi", MsgBoxStyle.Information, "İşlem Tamam")
        MDIParent1.konutGetir()
        Me.Close()
    End Sub
End Class