<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Freguser
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
        Me.DGVdatuser = New System.Windows.Forms.DataGridView()
        Me.Btn_update = New System.Windows.Forms.Button()
        Me.Btn_simpan = New System.Windows.Forms.Button()
        Me.Btn_bersih = New System.Windows.Forms.Button()
        Me.Btn_hapus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Text_leveluser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Text_email = New System.Windows.Forms.TextBox()
        Me.Text_passworduser = New System.Windows.Forms.TextBox()
        Me.Text_username = New System.Windows.Forms.TextBox()
        Me.Text_Nama = New System.Windows.Forms.TextBox()
        Me.Btn_kembali = New System.Windows.Forms.Button()
        CType(Me.DGVdatuser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVdatuser
        '
        Me.DGVdatuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVdatuser.Location = New System.Drawing.Point(21, 183)
        Me.DGVdatuser.Name = "DGVdatuser"
        Me.DGVdatuser.Size = New System.Drawing.Size(451, 114)
        Me.DGVdatuser.TabIndex = 0
        '
        'Btn_update
        '
        Me.Btn_update.BackColor = System.Drawing.Color.Peru
        Me.Btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_update.Location = New System.Drawing.Point(21, 142)
        Me.Btn_update.Name = "Btn_update"
        Me.Btn_update.Size = New System.Drawing.Size(63, 23)
        Me.Btn_update.TabIndex = 1
        Me.Btn_update.Text = "Update"
        Me.Btn_update.UseVisualStyleBackColor = False
        '
        'Btn_simpan
        '
        Me.Btn_simpan.BackColor = System.Drawing.Color.Peru
        Me.Btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_simpan.Location = New System.Drawing.Point(107, 142)
        Me.Btn_simpan.Name = "Btn_simpan"
        Me.Btn_simpan.Size = New System.Drawing.Size(69, 23)
        Me.Btn_simpan.TabIndex = 2
        Me.Btn_simpan.Text = "Simpan"
        Me.Btn_simpan.UseVisualStyleBackColor = False
        '
        'Btn_bersih
        '
        Me.Btn_bersih.BackColor = System.Drawing.Color.Peru
        Me.Btn_bersih.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_bersih.Location = New System.Drawing.Point(202, 142)
        Me.Btn_bersih.Name = "Btn_bersih"
        Me.Btn_bersih.Size = New System.Drawing.Size(68, 23)
        Me.Btn_bersih.TabIndex = 3
        Me.Btn_bersih.Text = "Bersih"
        Me.Btn_bersih.UseVisualStyleBackColor = False
        '
        'Btn_hapus
        '
        Me.Btn_hapus.BackColor = System.Drawing.Color.Peru
        Me.Btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_hapus.Location = New System.Drawing.Point(412, 142)
        Me.Btn_hapus.Name = "Btn_hapus"
        Me.Btn_hapus.Size = New System.Drawing.Size(60, 23)
        Me.Btn_hapus.TabIndex = 4
        Me.Btn_hapus.Text = "Hapus"
        Me.Btn_hapus.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(240, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Password"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Text_leveluser)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Text_email)
        Me.GroupBox1.Controls.Add(Me.Text_passworduser)
        Me.GroupBox1.Controls.Add(Me.Text_username)
        Me.GroupBox1.Controls.Add(Me.Text_Nama)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 129)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Register User"
        '
        'Text_leveluser
        '
        Me.Text_leveluser.Location = New System.Drawing.Point(70, 100)
        Me.Text_leveluser.Name = "Text_leveluser"
        Me.Text_leveluser.Size = New System.Drawing.Size(114, 20)
        Me.Text_leveluser.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Level"
        '
        'Text_email
        '
        Me.Text_email.Location = New System.Drawing.Point(299, 22)
        Me.Text_email.Name = "Text_email"
        Me.Text_email.Size = New System.Drawing.Size(127, 20)
        Me.Text_email.TabIndex = 12
        '
        'Text_passworduser
        '
        Me.Text_passworduser.Location = New System.Drawing.Point(299, 57)
        Me.Text_passworduser.Name = "Text_passworduser"
        Me.Text_passworduser.Size = New System.Drawing.Size(127, 20)
        Me.Text_passworduser.TabIndex = 11
        '
        'Text_username
        '
        Me.Text_username.Location = New System.Drawing.Point(70, 66)
        Me.Text_username.Name = "Text_username"
        Me.Text_username.Size = New System.Drawing.Size(112, 20)
        Me.Text_username.TabIndex = 10
        '
        'Text_Nama
        '
        Me.Text_Nama.Location = New System.Drawing.Point(70, 22)
        Me.Text_Nama.Name = "Text_Nama"
        Me.Text_Nama.Size = New System.Drawing.Size(112, 20)
        Me.Text_Nama.TabIndex = 9
        '
        'Btn_kembali
        '
        Me.Btn_kembali.BackColor = System.Drawing.Color.Peru
        Me.Btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_kembali.Location = New System.Drawing.Point(307, 142)
        Me.Btn_kembali.Name = "Btn_kembali"
        Me.Btn_kembali.Size = New System.Drawing.Size(68, 23)
        Me.Btn_kembali.TabIndex = 10
        Me.Btn_kembali.Text = "Kembali"
        Me.Btn_kembali.UseVisualStyleBackColor = False
        '
        'Freguser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(487, 309)
        Me.Controls.Add(Me.Btn_kembali)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_hapus)
        Me.Controls.Add(Me.Btn_bersih)
        Me.Controls.Add(Me.Btn_simpan)
        Me.Controls.Add(Me.Btn_update)
        Me.Controls.Add(Me.DGVdatuser)
        Me.Name = "Freguser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        CType(Me.DGVdatuser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVdatuser As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_update As System.Windows.Forms.Button
    Friend WithEvents Btn_simpan As System.Windows.Forms.Button
    Friend WithEvents Btn_bersih As System.Windows.Forms.Button
    Friend WithEvents Btn_hapus As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Text_email As System.Windows.Forms.TextBox
    Friend WithEvents Text_passworduser As System.Windows.Forms.TextBox
    Friend WithEvents Text_username As System.Windows.Forms.TextBox
    Friend WithEvents Text_Nama As System.Windows.Forms.TextBox
    Friend WithEvents Text_leveluser As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Btn_kembali As System.Windows.Forms.Button
End Class
