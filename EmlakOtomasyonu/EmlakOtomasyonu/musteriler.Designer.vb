<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class musteriler
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMusteriAra = New System.Windows.Forms.TextBox()
        Me.DGmusteri = New System.Windows.Forms.DataGridView()
        Me.Column44 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DGmusteri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtMusteriAra)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(707, 45)
        Me.Panel1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Müşteri Arama:"
        '
        'txtMusteriAra
        '
        Me.txtMusteriAra.BackColor = System.Drawing.Color.Silver
        Me.txtMusteriAra.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtMusteriAra.Location = New System.Drawing.Point(128, 12)
        Me.txtMusteriAra.Name = "txtMusteriAra"
        Me.txtMusteriAra.Size = New System.Drawing.Size(497, 25)
        Me.txtMusteriAra.TabIndex = 9
        '
        'DGmusteri
        '
        Me.DGmusteri.AllowUserToAddRows = False
        Me.DGmusteri.AllowUserToDeleteRows = False
        Me.DGmusteri.BackgroundColor = System.Drawing.Color.Silver
        Me.DGmusteri.ColumnHeadersHeight = 30
        Me.DGmusteri.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column44, Me.Column2, Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DGmusteri.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGmusteri.Location = New System.Drawing.Point(0, 45)
        Me.DGmusteri.Name = "DGmusteri"
        Me.DGmusteri.ReadOnly = True
        Me.DGmusteri.RowHeadersWidth = 20
        Me.DGmusteri.RowTemplate.Height = 70
        Me.DGmusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGmusteri.Size = New System.Drawing.Size(707, 441)
        Me.DGmusteri.TabIndex = 12
        '
        'Column44
        '
        Me.Column44.HeaderText = "Fotoğraf"
        Me.Column44.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column44.Name = "Column44"
        Me.Column44.ReadOnly = True
        Me.Column44.Width = 75
        '
        'Column2
        '
        Me.Column2.HeaderText = "TC"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Ad"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Soyad"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "E - Posta"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Telefon"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Adres"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'musteriler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 486)
        Me.Controls.Add(Me.DGmusteri)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "musteriler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "musteriler"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGmusteri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMusteriAra As TextBox
    Friend WithEvents DGmusteri As DataGridView
    Friend WithEvents Column44 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
