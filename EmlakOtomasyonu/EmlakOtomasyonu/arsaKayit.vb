Imports System.IO

Public Class arsaKayit
    Private Sub btnFotoEkle_Click(sender As Object, e As EventArgs) Handles btnFotoEkle.Click
        OpenFileDialog1.Filter = "JPG Dosyaları|*.jpg|GIF Dosyaları|*.gif|PNG Dosyaları|*.png"
        If OpenFileDialog1.ShowDialog = DialogResult.Cancel Then
            Return
        End If
        pbFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        For Each kontrol As Control In Me.Controls
            If TypeOf kontrol Is TextBox Then
                If kontrol.Text = String.Empty Then
                    MessageBox.Show(Convert.ToString(DirectCast(kontrol, TextBox).Tag + "Lütfen Tüm Alanları Doldurunuz!"))
                    Return
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
        sqlCalistir("insert into arsalar (kayTarihi,ada,pafta,parsel,semt,mahalle,ilce,il,alan,imarDurumu,acikadres,fotoYol,durumu,sahibi) Values ('" & DateTime.Now & "','" & txtAda.Text & "','" & txtPafta.Text & "','" & txtParsel.Text & "','" & txtSemt.Text & "','" & txtMahalle.Text & "','" & cbILce.Text & "','" & cbIL.Text & "','" & txtAlan.Text & "','" & txtAcikAdres.Text & "','" & cbImar.Text & "','" & dosyaAdi & "','" & "Boşta" & "','" & txtSahibi.Text & "')")
        MDIParent1.arsaGetir()
        Me.Close()
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        For Each kontrol As Control In Me.Controls
            If TypeOf kontrol Is TextBox Then
                If kontrol.Text = String.Empty Then
                    MessageBox.Show(Convert.ToString(DirectCast(kontrol, TextBox).Tag + "Lütfen Tüm Alanları Doldurunuz!"))
                    Return
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
        If MsgBox("Arsa Bilgileri Güncellenecektir! Onaylıyor musunuz?", vbYesNo, "Arsa Kaydı Güncelleme") = MsgBoxResult.No Then
            Return
        End If
        sqlCalistir("update arsalar set ada='" & txtAda.Text & "',pafta='" & txtPafta.Text & "',parsel='" & txtParsel.Text & "',semt='" & txtSemt.Text & "',mahalle='" & txtMahalle.Text & "',ilce='" & cbILce.Text & "',il='" & cbIL.Text & "',alan='" & txtAlan.Text & "',imarDurumu='" & cbImar.Text & "',acikadres='" & txtAcikAdres.Text & "',fotoYol='" & dosyaAdi & "' where gmKodu=" & Convert.ToInt32(txtGmKodu.Text))
        MsgBox("Arsa Güncellendi", MsgBoxStyle.Information, "İşlem Tamam")
        MDIParent1.arsaGetir()
        Me.Close()
    End Sub

    Private Sub btnVazgec_Click(sender As Object, e As EventArgs) Handles btnVazgec.Click
        Me.Close()
    End Sub

    Private Sub txtAda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAda.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtPafta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPafta.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtParsel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtParsel.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAlan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlan.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

    End Sub
    Private Sub txtFiyat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiyat.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSat_Click(sender As Object, e As EventArgs) Handles btnSat.Click
        If (Convert.ToDouble(txtSahibi.Text) > 0) Then
            If MsgBox("Gayrimenkulun Sahibi Vardır! Devam Etmek İstiyor Musunuz?", vbYesNo, "Onay Mesajı") = MsgBoxResult.No Then
                Return
            End If
        End If
        MDIParent1.ArsaBilgileri()
        Me.Close()
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
End Class