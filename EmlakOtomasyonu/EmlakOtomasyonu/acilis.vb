Public Class acilis
    Dim t As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        t += 5
        Label1.Text = "Yükleniyor ... % " & t.ToString()

        ProgressBar1.Value = t
        If t >= 100 Then
            Timer1.Enabled = False
            login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub acilis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class