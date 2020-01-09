<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fviewabsen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fviewabsen))
        Me.DGVlihatke = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_kemsis = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_jam = New System.Windows.Forms.Label()
        Me.Label_tanggal = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DGVlihatke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVlihatke
        '
        Me.DGVlihatke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVlihatke.Location = New System.Drawing.Point(28, 139)
        Me.DGVlihatke.Name = "DGVlihatke"
        Me.DGVlihatke.Size = New System.Drawing.Size(480, 170)
        Me.DGVlihatke.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "KEHADIRAN SISWA"
        '
        'btn_kemsis
        '
        Me.btn_kemsis.BackColor = System.Drawing.Color.White
        Me.btn_kemsis.BackgroundImage = CType(resources.GetObject("btn_kemsis.BackgroundImage"), System.Drawing.Image)
        Me.btn_kemsis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_kemsis.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_kemsis.Location = New System.Drawing.Point(440, 99)
        Me.btn_kemsis.Name = "btn_kemsis"
        Me.btn_kemsis.Size = New System.Drawing.Size(68, 23)
        Me.btn_kemsis.TabIndex = 2
        Me.btn_kemsis.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.PaleGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Jam"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.PaleGreen
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal"
        '
        'Lbl_jam
        '
        Me.Lbl_jam.BackColor = System.Drawing.Color.LightGreen
        Me.Lbl_jam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_jam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_jam.Location = New System.Drawing.Point(130, 55)
        Me.Lbl_jam.Name = "Lbl_jam"
        Me.Lbl_jam.Size = New System.Drawing.Size(65, 23)
        Me.Lbl_jam.TabIndex = 5
        '
        'Label_tanggal
        '
        Me.Label_tanggal.BackColor = System.Drawing.Color.LightGreen
        Me.Label_tanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_tanggal.Location = New System.Drawing.Point(130, 90)
        Me.Label_tanggal.Name = "Label_tanggal"
        Me.Label_tanggal.Size = New System.Drawing.Size(65, 23)
        Me.Label_tanggal.TabIndex = 6
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Fviewabsen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(539, 334)
        Me.Controls.Add(Me.Label_tanggal)
        Me.Controls.Add(Me.Lbl_jam)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_kemsis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVlihatke)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fviewabsen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Absen"
        CType(Me.DGVlihatke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVlihatke As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_kemsis As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_jam As System.Windows.Forms.Label
    Friend WithEvents Label_tanggal As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
