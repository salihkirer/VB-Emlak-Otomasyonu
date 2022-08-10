Public Class gmSat
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGozat.Click
        musteriler.Show()
    End Sub

    Private Sub btnSat_Click(sender As Object, e As EventArgs) Handles btnSat.Click
        If MsgBox(txtGmKodu.Text & " nolu Gayrimenkul " & txtAdi.Text & " isimli müşteriye satılıyor! Onaylıyor musunuz?", vbYesNo, "Satma Bilgisi Onayı") = MsgBoxResult.No Then
            Return
        End If
        sqlCalistir("insert into satis (gmKodu,Tc,tarih) values ('" & txtGmKodu.Text & "','" & txtTc.Text & "','" & DateTime.Now & "')")
        If Label28.Text = "Konut Bilgileri" Then
            sqlCalistir("update konutlar set sahibi='" & txtTc.Text & "' where gmKodu=" & Convert.ToDouble(txtGmKodu.Text))
            sqlCalistir("update konutlar set durumu='" & "Satılmış" & "' where gmKodu=" & Convert.ToDouble(txtGmKodu.Text))
            MDIParent1.konutGetir()
        End If
        If Label28.Text = "Arsa Bilgileri" Then
            sqlCalistir("update arsalar set sahibi='" & txtTc.Text & "' where gmKodu=" & Convert.ToDouble(txtGmKodu.Text))
            sqlCalistir("update arsalar set durumu='" & "Satılmış" & "' where gmKodu=" & Convert.ToDouble(txtGmKodu.Text))
            MDIParent1.arsaGetir()
        End If
        If Label28.Text = "İşyeri Bilgileri" Then
            sqlCalistir("update isyerleri set sahibi='" & txtTc.Text & "' where gmKodu=" & Convert.ToDouble(txtGmKodu.Text))
            sqlCalistir("update isyerleri set durumu='" & "Satılmış" & "' where gmKodu=" & Convert.ToDouble(txtGmKodu.Text))
            MDIParent1.isyeriGetir()
        End If
        MsgBox("Gayrimenkul Satıldı", MsgBoxStyle.Information, "İşlem Tamam")
        Me.Close()
    End Sub

    Private Sub btnKirala_Click(sender As Object, e As EventArgs) Handles btnKirala.Click
        If MsgBox(txtGmKodu.Text & " nolu Gayrimenkul " & txtAdi.Text & " isimli müşteriye kiralanıyor! Onaylıyor musunuz?", vbYesNo, "Kiralama Bilgisi Onayı") = MsgBoxResult.No Then
            Return
        End If
        sqlCalistir("insert into kiralama (gmKodu,Tc,tarih) values ('" & txtGmKodu.Text & "','" & txtTc.Text & "','" & DateTime.Now & "')")
        If Label28.Text = "Konut Bilgileri" Then
            sqlCalistir("update konutlar set sahibi='" & txtTc.Text & "' where gmKodu=" & Convert.ToDouble(txtGmKodu.Text))
            sqlCalistir("update konutlar set durumu='" & "Kiralanmış" & "' where gmKodu=" & Convert.ToDouble(txtGmKodu.Text))
            MDIParent1.konutGetir()
        End If
        If Label28.Text = "Arsa Bilgileri" Then
            sqlCalistir("update arsalar set sahibi='" & txtTc.Text & "' where gmKodu=" & Convert.ToDouble(txtGmKodu.Text))
            sqlCalistir("update arsalar set durumu='" & "Kiralanmış" & "' where gmKodu=" & Convert.ToDouble(txtGmKodu.Text))
            MDIParent1.arsaGetir()
        End If
        If Label28.Text = "İşyeri Bilgileri" Then
            sqlCalistir("update isyerleri set sahibi='" & txtTc.Text & "' where gmKodu=" & Convert.ToDouble(txtGmKodu.Text))
            sqlCalistir("update isyerleri set durumu='" & "Kiralanmış" & "' where gmKodu=" & Convert.ToDouble(txtGmKodu.Text))
            MDIParent1.isyeriGetir()
        End If
        MsgBox("Gayrimenkul Kiralandı", MsgBoxStyle.Information, "İşlem Tamam")
        Me.Close()
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub
End Class