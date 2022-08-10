<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class musteriKayit
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
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.txtAdres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.txtSoyadi = New System.Windows.Forms.TextBox()
        Me.txtAdi = New System.Windows.Forms.TextBox()
        Me.txtTc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dgKiraladiklari = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGmleri = New System.Windows.Forms.Button()
        Me.dgAldiklari = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgKiraladiklari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgAldiklari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFotoEkle
        '
        Me.btnFotoEkle.BackColor = System.Drawing.Color.Silver
        Me.btnFotoEkle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnFotoEkle.Location = New System.Drawing.Point(278, 168)
        Me.btnFotoEkle.Name = "btnFotoEkle"
        Me.btnFotoEkle.Size = New System.Drawing.Size(129, 23)
        Me.btnFotoEkle.TabIndex = 38
        Me.btnFotoEkle.Text = "Fotoğraf Ekle"
        Me.btnFotoEkle.UseVisualStyleBackColor = False
        '
        'pbFoto
        '
        Me.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbFoto.Location = New System.Drawing.Point(278, 13)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(129, 149)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFoto.TabIndex = 37
        Me.pbFoto.TabStop = False
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.Color.Silver
        Me.btnKapat.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKapat.ForeColor = System.Drawing.Color.Red
        Me.btnKapat.Location = New System.Drawing.Point(252, 285)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(89, 42)
        Me.btnKapat.TabIndex = 36
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'btnGuncelle
        '
        Me.btnGuncelle.BackColor = System.Drawing.Color.Silver
        Me.btnGuncelle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGuncelle.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnGuncelle.Location = New System.Drawing.Point(157, 285)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(89, 42)
        Me.btnGuncelle.TabIndex = 35
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.UseVisualStyleBackColor = False
        '
        'txtAdres
        '
        Me.txtAdres.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAdres.Location = New System.Drawing.Point(92, 157)
        Me.txtAdres.Multiline = True
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(171, 93)
        Me.txtAdres.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Adres :"
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.Color.Silver
        Me.btnKaydet.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKaydet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKaydet.Location = New System.Drawing.Point(65, 285)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(86, 42)
        Me.btnKaydet.TabIndex = 30
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtMail.Location = New System.Drawing.Point(92, 128)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(171, 23)
        Me.txtMail.TabIndex = 29
        '
        'txtCep
        '
        Me.txtCep.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCep.Location = New System.Drawing.Point(92, 99)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(171, 23)
        Me.txtCep.TabIndex = 28
        '
        'txtSoyadi
        '
        Me.txtSoyadi.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSoyadi.Location = New System.Drawing.Point(92, 70)
        Me.txtSoyadi.Name = "txtSoyadi"
        Me.txtSoyadi.Size = New System.Drawing.Size(171, 23)
        Me.txtSoyadi.TabIndex = 27
        '
        'txtAdi
        '
        Me.txtAdi.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAdi.Location = New System.Drawing.Point(92, 41)
        Me.txtAdi.Name = "txtAdi"
        Me.txtAdi.Size = New System.Drawing.Size(171, 23)
        Me.txtAdi.TabIndex = 26
        '
        'txtTc
        '
        Me.txtTc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTc.Location = New System.Drawing.Point(92, 12)
        Me.txtTc.Name = "txtTc"
        Me.txtTc.Size = New System.Drawing.Size(171, 23)
        Me.txtTc.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 129)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "E-Posta :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 71)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Soyadı :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Cep Tel :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 13)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "TC :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Adı :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dgKiraladiklari
        '
        Me.dgKiraladiklari.AllowUserToAddRows = False
        Me.dgKiraladiklari.AllowUserToDeleteRows = False
        Me.dgKiraladiklari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKiraladiklari.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1})
        Me.dgKiraladiklari.Location = New System.Drawing.Point(652, 42)
        Me.dgKiraladiklari.Name = "dgKiraladiklari"
        Me.dgKiraladiklari.ReadOnly = True
        Me.dgKiraladiklari.RowHeadersWidth = 4
        Me.dgKiraladiklari.Size = New System.Drawing.Size(198, 246)
        Me.dgKiraladiklari.TabIndex = 39
        '
        'Column2
        '
        Me.Column2.HeaderText = "Gm Kodu"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 75
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kiraladığı Tarih"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 115
        '
        'btnGmleri
        '
        Me.btnGmleri.BackColor = System.Drawing.Color.Silver
        Me.btnGmleri.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGmleri.Location = New System.Drawing.Point(278, 209)
        Me.btnGmleri.Name = "btnGmleri"
        Me.btnGmleri.Size = New System.Drawing.Size(129, 32)
        Me.btnGmleri.TabIndex = 40
        Me.btnGmleri.Text = "Gayrimenkulleri"
        Me.btnGmleri.UseVisualStyleBackColor = False
        '
        'dgAldiklari
        '
        Me.dgAldiklari.AllowUserToAddRows = False
        Me.dgAldiklari.AllowUserToDeleteRows = False
        Me.dgAldiklari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAldiklari.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgAldiklari.Location = New System.Drawing.Point(447, 42)
        Me.dgAldiklari.Name = "dgAldiklari"
        Me.dgAldiklari.ReadOnly = True
        Me.dgAldiklari.RowHeadersWidth = 4
        Me.dgAldiklari.Size = New System.Drawing.Size(199, 246)
        Me.dgAldiklari.TabIndex = 39
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Gm Kodu"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Aldığı Tarih"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 115
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(498, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Satın Aldıkları"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(709, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Kiraladıkları"
        '
        'musteriKayit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 376)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGmleri)
        Me.Controls.Add(Me.dgAldiklari)
        Me.Controls.Add(Me.dgKiraladiklari)
        Me.Controls.Add(Me.btnFotoEkle)
        Me.Controls.Add(Me.pbFoto)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.txtAdres)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.txtSoyadi)
        Me.Controls.Add(Me.txtAdi)
        Me.Controls.Add(Me.txtTc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "musteriKayit"
        Me.Text = "musteriKayit"
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgKiraladiklari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgAldiklari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFotoEkle As Button
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btnKapat As Button
    Friend WithEvents btnGuncelle As Button
    Friend WithEvents txtAdres As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnKaydet As Button
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtCep As TextBox
    Friend WithEvents txtSoyadi As TextBox
    Friend WithEvents txtAdi As TextBox
    Friend WithEvents txtTc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents dgKiraladiklari As DataGridView
    Friend WithEvents btnGmleri As Button
    Friend WithEvents dgAldiklari As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
