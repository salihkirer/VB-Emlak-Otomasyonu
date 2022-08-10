Public Class login
    Private Sub btngiris_Click(sender As Object, e As EventArgs) Handles btngiris.Click
        If kulad.Text = "admin" And sifre.Text = "1234" Then
            MDIParent1.Show()
            Me.Hide()
        Else
            MsgBox(" Tekrar Deneyiniz... ", MsgBoxStyle.Critical)

        End If
    End Sub

    Private Sub btncıkıs_Click(sender As Object, e As EventArgs) Handles btncıkıs.Click
        Application.Exit()

    End Sub


End Class