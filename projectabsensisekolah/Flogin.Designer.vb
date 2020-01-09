<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Flogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Flogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Text_username = New System.Windows.Forms.TextBox()
        Me.Text_password = New System.Windows.Forms.TextBox()
        Me.Btn_login = New System.Windows.Forms.Button()
        Me.Btn_cancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cbx_tamppas = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(156, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Text_username
        '
        Me.Text_username.Location = New System.Drawing.Point(157, 82)
        Me.Text_username.Name = "Text_username"
        Me.Text_username.Size = New System.Drawing.Size(163, 20)
        Me.Text_username.TabIndex = 2
        '
        'Text_password
        '
        Me.Text_password.Location = New System.Drawing.Point(157, 135)
        Me.Text_password.Name = "Text_password"
        Me.Text_password.Size = New System.Drawing.Size(163, 20)
        Me.Text_password.TabIndex = 3
        '
        'Btn_login
        '
        Me.Btn_login.BackColor = System.Drawing.Color.Peru
        Me.Btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_login.ForeColor = System.Drawing.Color.Black
        Me.Btn_login.Location = New System.Drawing.Point(159, 171)
        Me.Btn_login.Name = "Btn_login"
        Me.Btn_login.Size = New System.Drawing.Size(66, 25)
        Me.Btn_login.TabIndex = 4
        Me.Btn_login.Text = "Login"
        Me.Btn_login.UseVisualStyleBackColor = False
        '
        'Btn_cancel
        '
        Me.Btn_cancel.BackColor = System.Drawing.Color.Peru
        Me.Btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancel.Location = New System.Drawing.Point(235, 211)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(66, 23)
        Me.Btn_cancel.TabIndex = 5
        Me.Btn_cancel.Text = "Cancel"
        Me.Btn_cancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(153, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "LOGIN"
        '
        'Cbx_tamppas
        '
        Me.Cbx_tamppas.AutoSize = True
        Me.Cbx_tamppas.Location = New System.Drawing.Point(259, 161)
        Me.Cbx_tamppas.Name = "Cbx_tamppas"
        Me.Cbx_tamppas.Size = New System.Drawing.Size(124, 17)
        Me.Cbx_tamppas.TabIndex = 7
        Me.Cbx_tamppas.Text = "Tampilkan Password"
        Me.Cbx_tamppas.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Flogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(392, 263)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Cbx_tamppas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.Btn_login)
        Me.Controls.Add(Me.Text_password)
        Me.Controls.Add(Me.Text_username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Flogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Text_username As System.Windows.Forms.TextBox
    Friend WithEvents Text_password As System.Windows.Forms.TextBox
    Friend WithEvents Btn_login As System.Windows.Forms.Button
    Friend WithEvents Btn_cancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cbx_tamppas As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
