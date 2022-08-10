<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class arsaKayit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnFotoEkle = New System.Windows.Forms.Button()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.txtAcikAdres = New System.Windows.Forms.TextBox()
        Me.btnVazgec = New System.Windows.Forms.Button()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.txtAlan = New System.Windows.Forms.TextBox()
        Me.txtParsel = New System.Windows.Forms.TextBox()
        Me.txtPafta = New System.Windows.Forms.TextBox()
        Me.txtAda = New System.Windows.Forms.TextBox()
        Me.txtMahalle = New System.Windows.Forms.TextBox()
        Me.txtSemt = New System.Windows.Forms.TextBox()
        Me.cbImar = New System.Windows.Forms.ComboBox()
        Me.cbILce = New System.Windows.Forms.ComboBox()
        Me.cbIL = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtSahibi = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtFiyat = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGmKodu = New System.Windows.Forms.TextBox()
        Me.btnSat = New System.Windows.Forms.Button()
        Me.txtDurumu = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnGoster = New System.Windows.Forms.Button()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFotoEkle
        '
        Me.btnFotoEkle.BackColor = System.Drawing.Color.Silver
        Me.btnFotoEkle.Location = New System.Drawing.Point(443, 373)
        Me.btnFotoEkle.Name = "btnFotoEkle"
        Me.btnFotoEkle.Size = New System.Drawing.Size(405, 23)
        Me.btnFotoEkle.TabIndex = 53
        Me.btnFotoEkle.Text = "Fotoğraf Ekle"
        Me.btnFotoEkle.UseVisualStyleBackColor = False
        '
        'pbFoto
        '
        Me.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbFoto.Location = New System.Drawing.Point(443, 12)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(405, 352)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFoto.TabIndex = 52
        Me.pbFoto.TabStop = False
        '
        'btnGuncelle
        '
        Me.btnGuncelle.BackColor = System.Drawing.Color.Silver
        Me.btnGuncelle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGuncelle.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnGuncelle.Location = New System.Drawing.Point(606, 417)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(95, 42)
        Me.btnGuncelle.TabIndex = 50
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.UseVisualStyleBackColor = False
        '
        'txtAcikAdres
        '
        Me.txtAcikAdres.BackColor = System.Drawing.SystemColors.Window
        Me.txtAcikAdres.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAcikAdres.Location = New System.Drawing.Point(138, 235)
        Me.txtAcikAdres.Multiline = True
        Me.txtAcikAdres.Name = "txtAcikAdres"
        Me.txtAcikAdres.Size = New System.Drawing.Size(179, 94)
        Me.txtAcikAdres.TabIndex = 49
        '
        'btnVazgec
        '
        Me.btnVazgec.BackColor = System.Drawing.Color.Silver
        Me.btnVazgec.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnVazgec.ForeColor = System.Drawing.Color.Red
        Me.btnVazgec.Location = New System.Drawing.Point(726, 417)
        Me.btnVazgec.Name = "btnVazgec"
        Me.btnVazgec.Size = New System.Drawing.Size(95, 42)
        Me.btnVazgec.TabIndex = 48
        Me.btnVazgec.Text = "Kapat"
        Me.btnVazgec.UseVisualStyleBackColor = False
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.Color.Silver
        Me.btnKaydet.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKaydet.ForeColor = System.Drawing.Color.Navy
        Me.btnKaydet.Location = New System.Drawing.Point(485, 417)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(95, 42)
        Me.btnKaydet.TabIndex = 47
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'txtAlan
        '
        Me.txtAlan.BackColor = System.Drawing.SystemColors.Window
        Me.txtAlan.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAlan.Location = New System.Drawing.Point(311, 12)
        Me.txtAlan.Name = "txtAlan"
        Me.txtAlan.Size = New System.Drawing.Size(88, 22)
        Me.txtAlan.TabIndex = 46
        '
        'txtParsel
        '
        Me.txtParsel.BackColor = System.Drawing.SystemColors.Window
        Me.txtParsel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtParsel.Location = New System.Drawing.Point(138, 124)
        Me.txtParsel.Name = "txtParsel"
        Me.txtParsel.Size = New System.Drawing.Size(88, 22)
        Me.txtParsel.TabIndex = 45
        '
        'txtPafta
        '
        Me.txtPafta.BackColor = System.Drawing.SystemColors.Window
        Me.txtPafta.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtPafta.Location = New System.Drawing.Point(138, 96)
        Me.txtPafta.Name = "txtPafta"
        Me.txtPafta.Size = New System.Drawing.Size(88, 22)
        Me.txtPafta.TabIndex = 44
        '
        'txtAda
        '
        Me.txtAda.BackColor = System.Drawing.SystemColors.Window
        Me.txtAda.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAda.Location = New System.Drawing.Point(138, 68)
        Me.txtAda.Name = "txtAda"
        Me.txtAda.Size = New System.Drawing.Size(88, 22)
        Me.txtAda.TabIndex = 43
        '
        'txtMahalle
        '
        Me.txtMahalle.BackColor = System.Drawing.SystemColors.Window
        Me.txtMahalle.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtMahalle.Location = New System.Drawing.Point(311, 68)
        Me.txtMahalle.Name = "txtMahalle"
        Me.txtMahalle.Size = New System.Drawing.Size(88, 22)
        Me.txtMahalle.TabIndex = 42
        '
        'txtSemt
        '
        Me.txtSemt.BackColor = System.Drawing.SystemColors.Window
        Me.txtSemt.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSemt.Location = New System.Drawing.Point(311, 40)
        Me.txtSemt.Name = "txtSemt"
        Me.txtSemt.Size = New System.Drawing.Size(88, 22)
        Me.txtSemt.TabIndex = 41
        '
        'cbImar
        '
        Me.cbImar.BackColor = System.Drawing.SystemColors.Window
        Me.cbImar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbImar.FormattingEnabled = True
        Me.cbImar.Items.AddRange(New Object() {"Var ", "Yok"})
        Me.cbImar.Location = New System.Drawing.Point(138, 152)
        Me.cbImar.Name = "cbImar"
        Me.cbImar.Size = New System.Drawing.Size(106, 21)
        Me.cbImar.TabIndex = 39
        '
        'cbILce
        '
        Me.cbILce.BackColor = System.Drawing.SystemColors.Window
        Me.cbILce.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbILce.FormattingEnabled = True
        Me.cbILce.Items.AddRange(New Object() {"Konyaaltı", "Kaş", "Alanya"})
        Me.cbILce.Location = New System.Drawing.Point(311, 96)
        Me.cbILce.Name = "cbILce"
        Me.cbILce.Size = New System.Drawing.Size(106, 21)
        Me.cbILce.TabIndex = 38
        '
        'cbIL
        '
        Me.cbIL.BackColor = System.Drawing.SystemColors.Window
        Me.cbIL.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbIL.FormattingEnabled = True
        Me.cbIL.Items.AddRange(New Object() {"İzmir", "Antalya", "İstanbul"})
        Me.cbIL.Location = New System.Drawing.Point(311, 123)
        Me.cbIL.Name = "cbIL"
        Me.cbIL.Size = New System.Drawing.Size(106, 21)
        Me.cbIL.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(31, 152)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 17)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "İmar Durumu :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 96)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Pafta :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(237, 96)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 17)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "İlçe :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(237, 12)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 17)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Alan :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(237, 68)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Mahalle :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 235)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 17)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Açık Adres :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 68)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Ada :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(237, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "İl :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(31, 124)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Parsel :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(237, 40)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Semt :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtSahibi
        '
        Me.txtSahibi.BackColor = System.Drawing.SystemColors.Window
        Me.txtSahibi.Enabled = False
        Me.txtSahibi.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSahibi.Location = New System.Drawing.Point(138, 207)
        Me.txtSahibi.Name = "txtSahibi"
        Me.txtSahibi.Size = New System.Drawing.Size(116, 22)
        Me.txtSahibi.TabIndex = 188
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label21.Location = New System.Drawing.Point(31, 207)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 17)
        Me.Label21.TabIndex = 187
        Me.Label21.Text = "Arsa Sahibi"
        '
        'txtFiyat
        '
        Me.txtFiyat.BackColor = System.Drawing.SystemColors.Window
        Me.txtFiyat.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtFiyat.Location = New System.Drawing.Point(138, 179)
        Me.txtFiyat.Name = "txtFiyat"
        Me.txtFiyat.Size = New System.Drawing.Size(116, 22)
        Me.txtFiyat.TabIndex = 186
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label20.Location = New System.Drawing.Point(31, 179)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 17)
        Me.Label20.TabIndex = 185
        Me.Label20.Text = "Fiyat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "GM Kodu :"
        '
        'txtGmKodu
        '
        Me.txtGmKodu.BackColor = System.Drawing.SystemColors.Window
        Me.txtGmKodu.Enabled = False
        Me.txtGmKodu.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtGmKodu.Location = New System.Drawing.Point(138, 12)
        Me.txtGmKodu.Name = "txtGmKodu"
        Me.txtGmKodu.Size = New System.Drawing.Size(88, 22)
        Me.txtGmKodu.TabIndex = 40
        '
        'btnSat
        '
        Me.btnSat.BackColor = System.Drawing.Color.Silver
        Me.btnSat.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSat.Location = New System.Drawing.Point(123, 354)
        Me.btnSat.Name = "btnSat"
        Me.btnSat.Size = New System.Drawing.Size(207, 42)
        Me.btnSat.TabIndex = 189
        Me.btnSat.Text = "Sat/Kirala"
        Me.btnSat.UseVisualStyleBackColor = False
        '
        'txtDurumu
        '
        Me.txtDurumu.BackColor = System.Drawing.SystemColors.Window
        Me.txtDurumu.Enabled = False
        Me.txtDurumu.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtDurumu.Location = New System.Drawing.Point(138, 40)
        Me.txtDurumu.Name = "txtDurumu"
        Me.txtDurumu.Size = New System.Drawing.Size(88, 22)
        Me.txtDurumu.TabIndex = 191
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.Location = New System.Drawing.Point(31, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 17)
        Me.Label13.TabIndex = 190
        Me.Label13.Text = "Durumu:"
        '
        'btnGoster
        '
        Me.btnGoster.BackColor = System.Drawing.Color.Silver
        Me.btnGoster.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGoster.Location = New System.Drawing.Point(260, 207)
        Me.btnGoster.Name = "btnGoster"
        Me.btnGoster.Size = New System.Drawing.Size(57, 22)
        Me.btnGoster.TabIndex = 192
        Me.btnGoster.Text = "Göster"
        Me.btnGoster.UseVisualStyleBackColor = False
        '
        'arsaKayit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 516)
        Me.Controls.Add(Me.btnGoster)
        Me.Controls.Add(Me.txtDurumu)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnSat)
        Me.Controls.Add(Me.txtSahibi)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtFiyat)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btnFotoEkle)
        Me.Controls.Add(Me.pbFoto)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.txtAcikAdres)
        Me.Controls.Add(Me.btnVazgec)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.txtAlan)
        Me.Controls.Add(Me.txtParsel)
        Me.Controls.Add(Me.txtPafta)
        Me.Controls.Add(Me.txtAda)
        Me.Controls.Add(Me.txtMahalle)
        Me.Controls.Add(Me.txtSemt)
        Me.Controls.Add(Me.txtGmKodu)
        Me.Controls.Add(Me.cbImar)
        Me.Controls.Add(Me.cbILce)
        Me.Controls.Add(Me.cbIL)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "arsaKayit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "arsaKayit"
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFotoEkle As Button
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btnGuncelle As Button
    Friend WithEvents txtAcikAdres As TextBox
    Friend WithEvents btnVazgec As Button
    Friend WithEvents btnKaydet As Button
    Friend WithEvents txtAlan As TextBox
    Friend WithEvents txtParsel As TextBox
    Friend WithEvents txtPafta As TextBox
    Friend WithEvents txtAda As TextBox
    Friend WithEvents txtMahalle As TextBox
    Friend WithEvents txtSemt As TextBox
    Friend WithEvents cbImar As ComboBox
    Friend WithEvents cbILce As ComboBox
    Friend WithEvents cbIL As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtSahibi As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtFiyat As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGmKodu As TextBox
    Friend WithEvents btnSat As Button
    Friend WithEvents txtDurumu As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnGoster As Button
End Class
