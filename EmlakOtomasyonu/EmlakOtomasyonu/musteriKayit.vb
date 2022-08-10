Imports System.IO

Public Class musteriKayit
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
        sqlCalistir("insert into musteriler (TC,ad,soyad,tel,e_posta,adres,fotoYol) values ('" & txtTc.Text & "','" & txtAdi.Text & "','" & txtSoyadi.Text & "','" & txtCep.Text & "','" & txtMail.Text & "','" & txtAdres.Text & "','" & dosyaAdi & "')")
        MDIParent1.musteriGetir()
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
        If MsgBox("Müşteri Bilgileri Güncellenecektir! Onaylıyor musunuz?", vbYesNo, "Müşteri Kaydı Güncelleme") = MsgBoxResult.No Then
            Return
        End If
        sqlCalistir("update musteriler set ad='" & txtAdi.Text & "',soyad='" & txtSoyadi.Text & "',tel='" & txtCep.Text & "',e_posta='" & txtMail.Text & "',adres='" & txtAdres.Text & "',fotoYol='" & dosyaAdi & "' where TC=" & Convert.ToDouble(txtTc.Text))
        MsgBox("Müşteri Güncellendi", MsgBoxStyle.Information, "İşlem Tamam")
        MDIParent1.musteriGetir()
        Me.Close()
    End Sub

    Private Sub btnVazgec_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub

    Private Sub txtTc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTc.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtCep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCep.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnGmleri_Click(sender As Object, e As EventArgs) Handles btnGmleri.Click
        dgKiraladiklari.Rows.Clear()
        dgAldiklari.Rows.Clear()
        Me.Width = 900
        Dim dt As DataTable = dtGetir("select * from satis where TC like '%" & txtTc.Text & "%' order by tarih desc")
        For i = 0 To dt.Rows.Count - 1
            dgAldiklari.Rows.Add(dt.Rows(i)("gmKodu").ToString(), dt.Rows(i)("tarih").ToString())
        Next
        Dim ds As DataTable = dtGetir("select * from kiralama where TC like '%" & txtTc.Text & "%'order by tarih desc")
        For i = 0 To ds.Rows.Count - 1
            dgKiraladiklari.Rows.Add(ds.Rows(i)("gmKodu").ToString(), ds.Rows(i)("tarih").ToString())
        Next
    End Sub
End Class