<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Finputabsen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Text_nisn = New System.Windows.Forms.TextBox()
        Me.Text_namasis = New System.Windows.Forms.TextBox()
        Me.Text_kelas = New System.Windows.Forms.TextBox()
        Me.Text_jurusan = New System.Windows.Forms.TextBox()
        Me.Text_ket = New System.Windows.Forms.TextBox()
        Me.DGVsis = New System.Windows.Forms.DataGridView()
        Me.Btn_tambah = New System.Windows.Forms.Button()
        Me.Btn_hapus = New System.Windows.Forms.Button()
        Me.Btn_upgrade = New System.Windows.Forms.Button()
        Me.Btn_closesis = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Text_notlp = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Text_hadir = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Text_sakit = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Text_izin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DGVsis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT ABSEN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NISN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kelas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(334, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jurusan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tanpa.Ket"
        '
        'Text_nisn
        '
        Me.Text_nisn.Location = New System.Drawing.Point(142, 47)
        Me.Text_nisn.Name = "Text_nisn"
        Me.Text_nisn.Size = New System.Drawing.Size(135, 20)
        Me.Text_nisn.TabIndex = 6
        '
        'Text_namasis
        '
        Me.Text_namasis.Location = New System.Drawing.Point(142, 73)
        Me.Text_namasis.Name = "Text_namasis"
        Me.Text_namasis.Size = New System.Drawing.Size(135, 20)
        Me.Text_namasis.TabIndex = 7
        '
        'Text_kelas
        '
        Me.Text_kelas.Location = New System.Drawing.Point(142, 104)
        Me.Text_kelas.Name = "Text_kelas"
        Me.Text_kelas.Size = New System.Drawing.Size(135, 20)
        Me.Text_kelas.TabIndex = 8
        '
        'Text_jurusan
        '
        Me.Text_jurusan.Location = New System.Drawing.Point(410, 46)
        Me.Text_jurusan.Name = "Text_jurusan"
        Me.Text_jurusan.Size = New System.Drawing.Size(145, 20)
        Me.Text_jurusan.TabIndex = 9
        '
        'Text_ket
        '
        Me.Text_ket.Location = New System.Drawing.Point(103, 19)
        Me.Text_ket.Name = "Text_ket"
        Me.Text_ket.Size = New System.Drawing.Size(52, 20)
        Me.Text_ket.TabIndex = 10
        '
        'DGVsis
        '
        Me.DGVsis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVsis.Location = New System.Drawing.Point(60, 279)
        Me.DGVsis.Name = "DGVsis"
        Me.DGVsis.Size = New System.Drawing.Size(526, 147)
        Me.DGVsis.TabIndex = 11
        '
        'Btn_tambah
        '
        Me.Btn_tambah.BackColor = System.Drawing.Color.Peru
        Me.Btn_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_tambah.Location = New System.Drawing.Point(60, 243)
        Me.Btn_tambah.Name = "Btn_tambah"
        Me.Btn_tambah.Size = New System.Drawing.Size(58, 23)
        Me.Btn_tambah.TabIndex = 12
        Me.Btn_tambah.Text = "Tambah"
        Me.Btn_tambah.UseVisualStyleBackColor = False
        '
        'Btn_hapus
        '
        Me.Btn_hapus.BackColor = System.Drawing.Color.Peru
        Me.Btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_hapus.Location = New System.Drawing.Point(147, 243)
        Me.Btn_hapus.Name = "Btn_hapus"
        Me.Btn_hapus.Size = New System.Drawing.Size(56, 23)
        Me.Btn_hapus.TabIndex = 13
        Me.Btn_hapus.Text = "Hapus"
        Me.Btn_hapus.UseVisualStyleBackColor = False
        '
        'Btn_upgrade
        '
        Me.Btn_upgrade.BackColor = System.Drawing.Color.Peru
        Me.Btn_upgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_upgrade.Location = New System.Drawing.Point(230, 243)
        Me.Btn_upgrade.Name = "Btn_upgrade"
        Me.Btn_upgrade.Size = New System.Drawing.Size(58, 23)
        Me.Btn_upgrade.TabIndex = 15
        Me.Btn_upgrade.Text = "Upgrade"
        Me.Btn_upgrade.UseVisualStyleBackColor = False
        '
        'Btn_closesis
        '
        Me.Btn_closesis.BackColor = System.Drawing.Color.Peru
        Me.Btn_closesis.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_closesis.Location = New System.Drawing.Point(523, 238)
        Me.Btn_closesis.Name = "Btn_closesis"
        Me.Btn_closesis.Size = New System.Drawing.Size(63, 23)
        Me.Btn_closesis.TabIndex = 16
        Me.Btn_closesis.Text = "Close"
        Me.Btn_closesis.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(334, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "No.tlp"
        '
        'Text_notlp
        '
        Me.Text_notlp.Location = New System.Drawing.Point(410, 80)
        Me.Text_notlp.Name = "Text_notlp"
        Me.Text_notlp.Size = New System.Drawing.Size(145, 20)
        Me.Text_notlp.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Text_hadir)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Text_sakit)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Text_izin)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Text_ket)
        Me.GroupBox1.Location = New System.Drawing.Point(66, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 86)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'Text_hadir
        '
        Me.Text_hadir.Location = New System.Drawing.Point(303, 51)
        Me.Text_hadir.Name = "Text_hadir"
        Me.Text_hadir.Size = New System.Drawing.Size(64, 20)
        Me.Text_hadir.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(250, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Hadir"
        '
        'Text_sakit
        '
        Me.Text_sakit.Location = New System.Drawing.Point(303, 16)
        Me.Text_sakit.Name = "Text_sakit"
        Me.Text_sakit.Size = New System.Drawing.Size(64, 20)
        Me.Text_sakit.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(250, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Sakit"
        '
        'Text_izin
        '
        Me.Text_izin.Location = New System.Drawing.Point(103, 54)
        Me.Text_izin.Name = "Text_izin"
        Me.Text_izin.Size = New System.Drawing.Size(52, 20)
        Me.Text_izin.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Izin"
        '
        'Finputabsen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(632, 428)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Text_notlp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btn_closesis)
        Me.Controls.Add(Me.Btn_upgrade)
        Me.Controls.Add(Me.Btn_hapus)
        Me.Controls.Add(Me.Btn_tambah)
        Me.Controls.Add(Me.DGVsis)
        Me.Controls.Add(Me.Text_jurusan)
        Me.Controls.Add(Me.Text_kelas)
        Me.Controls.Add(Me.Text_namasis)
        Me.Controls.Add(Me.Text_nisn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Finputabsen"
        Me.Text = "Fabsensi"
        CType(Me.DGVsis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Text_nisn As System.Windows.Forms.TextBox
    Friend WithEvents Text_namasis As System.Windows.Forms.TextBox
    Friend WithEvents Text_kelas As System.Windows.Forms.TextBox
    Friend WithEvents Text_jurusan As System.Windows.Forms.TextBox
    Friend WithEvents Text_ket As System.Windows.Forms.TextBox
    Friend WithEvents DGVsis As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_tambah As System.Windows.Forms.Button
    Friend WithEvents Btn_hapus As System.Windows.Forms.Button
    Friend WithEvents Btn_upgrade As System.Windows.Forms.Button
    Friend WithEvents Btn_closesis As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Text_notlp As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Text_hadir As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Text_sakit As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Text_izin As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
