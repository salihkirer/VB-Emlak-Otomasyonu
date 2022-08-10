<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btncıkıs = New System.Windows.Forms.Button()
        Me.btngiris = New System.Windows.Forms.Button()
        Me.kulad = New System.Windows.Forms.TextBox()
        Me.sifre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncıkıs
        '
        Me.btncıkıs.BackColor = System.Drawing.Color.Silver
        Me.btncıkıs.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btncıkıs.ForeColor = System.Drawing.Color.Red
        Me.btncıkıs.Location = New System.Drawing.Point(184, 96)
        Me.btncıkıs.Name = "btncıkıs"
        Me.btncıkıs.Size = New System.Drawing.Size(78, 33)
        Me.btncıkıs.TabIndex = 10
        Me.btncıkıs.Text = "Çıkış"
        Me.btncıkıs.UseVisualStyleBackColor = False
        '
        'btngiris
        '
        Me.btngiris.BackColor = System.Drawing.Color.Silver
        Me.btngiris.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btngiris.ForeColor = System.Drawing.Color.Green
        Me.btngiris.Location = New System.Drawing.Point(99, 96)
        Me.btngiris.Name = "btngiris"
        Me.btngiris.Size = New System.Drawing.Size(69, 33)
        Me.btngiris.TabIndex = 9
        Me.btngiris.Text = "Giriş"
        Me.btngiris.UseVisualStyleBackColor = False
        '
        'kulad
        '
        Me.kulad.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.kulad.Location = New System.Drawing.Point(151, 28)
        Me.kulad.Name = "kulad"
        Me.kulad.Size = New System.Drawing.Size(100, 23)
        Me.kulad.TabIndex = 7
        '
        'sifre
        '
        Me.sifre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sifre.Location = New System.Drawing.Point(151, 57)
        Me.sifre.Name = "sifre"
        Me.sifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.sifre.Size = New System.Drawing.Size(100, 23)
        Me.sifre.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Şifre :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kullanıcı Adı :"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 156)
        Me.Controls.Add(Me.btncıkıs)
        Me.Controls.Add(Me.btngiris)
        Me.Controls.Add(Me.kulad)
        Me.Controls.Add(Me.sifre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncıkıs As Button
    Friend WithEvents btngiris As Button
    Friend WithEvents kulad As TextBox
    Friend WithEvents sifre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
