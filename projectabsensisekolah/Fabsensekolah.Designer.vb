<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAbsensekolah
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Ms_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mi_login = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mi_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Mi_user = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mi_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ms_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mi_abssiswa = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ms_laporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mi_laporkehdiran = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ms_utility = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mi_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Slabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Slabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Slabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Slabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Slabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Slabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Slabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Slabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Slabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Slabel10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ms_file, Me.Ms_menu, Me.Ms_laporan, Me.Ms_utility})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(519, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Ms_file
        '
        Me.Ms_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mi_login, Me.Mi_logout, Me.ToolStripMenuItem1, Me.Mi_user, Me.Mi_exit})
        Me.Ms_file.Name = "Ms_file"
        Me.Ms_file.Size = New System.Drawing.Size(37, 20)
        Me.Ms_file.Text = "File"
        '
        'Mi_login
        '
        Me.Mi_login.Name = "Mi_login"
        Me.Mi_login.Size = New System.Drawing.Size(152, 22)
        Me.Mi_login.Text = "Log in"
        '
        'Mi_logout
        '
        Me.Mi_logout.Name = "Mi_logout"
        Me.Mi_logout.Size = New System.Drawing.Size(152, 22)
        Me.Mi_logout.Text = "Log Out"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'Mi_user
        '
        Me.Mi_user.Name = "Mi_user"
        Me.Mi_user.Size = New System.Drawing.Size(152, 22)
        Me.Mi_user.Text = "User"
        '
        'Mi_exit
        '
        Me.Mi_exit.Name = "Mi_exit"
        Me.Mi_exit.Size = New System.Drawing.Size(152, 22)
        Me.Mi_exit.Text = "Exit"
        '
        'Ms_menu
        '
        Me.Ms_menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mi_abssiswa})
        Me.Ms_menu.Name = "Ms_menu"
        Me.Ms_menu.Size = New System.Drawing.Size(50, 20)
        Me.Ms_menu.Text = "Menu"
        '
        'Mi_abssiswa
        '
        Me.Mi_abssiswa.Name = "Mi_abssiswa"
        Me.Mi_abssiswa.Size = New System.Drawing.Size(147, 22)
        Me.Mi_abssiswa.Text = "Absensi Siswa"
        '
        'Ms_laporan
        '
        Me.Ms_laporan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mi_laporkehdiran})
        Me.Ms_laporan.Name = "Ms_laporan"
        Me.Ms_laporan.Size = New System.Drawing.Size(62, 20)
        Me.Ms_laporan.Text = "Laporan"
        '
        'Mi_laporkehdiran
        '
        Me.Mi_laporkehdiran.Name = "Mi_laporkehdiran"
        Me.Mi_laporkehdiran.Size = New System.Drawing.Size(173, 22)
        Me.Mi_laporkehdiran.Text = "Laporan Kehadiran"
        '
        'Ms_utility
        '
        Me.Ms_utility.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mi_about})
        Me.Ms_utility.Name = "Ms_utility"
        Me.Ms_utility.Size = New System.Drawing.Size(50, 20)
        Me.Ms_utility.Text = "Utility"
        '
        'Mi_about
        '
        Me.Mi_about.Name = "Mi_about"
        Me.Mi_about.Size = New System.Drawing.Size(105, 22)
        Me.Mi_about.Text = "about"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Slabel1, Me.Slabel2, Me.Slabel3, Me.Slabel4, Me.Slabel5, Me.Slabel6, Me.Slabel7, Me.Slabel8, Me.Slabel9, Me.Slabel10})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 253)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(519, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Slabel1
        '
        Me.Slabel1.AccessibleName = "Slabel1"
        Me.Slabel1.Name = "Slabel1"
        Me.Slabel1.Size = New System.Drawing.Size(40, 17)
        Me.Slabel1.Text = "Kode :"
        '
        'Slabel2
        '
        Me.Slabel2.AccessibleName = "Slabel"
        Me.Slabel2.Name = "Slabel2"
        Me.Slabel2.Size = New System.Drawing.Size(0, 17)
        '
        'Slabel3
        '
        Me.Slabel3.AccessibleName = "Slabel3"
        Me.Slabel3.Name = "Slabel3"
        Me.Slabel3.Size = New System.Drawing.Size(39, 17)
        Me.Slabel3.Text = "Nama"
        '
        'Slabel4
        '
        Me.Slabel4.AccessibleName = "Slabel4"
        Me.Slabel4.Name = "Slabel4"
        Me.Slabel4.Size = New System.Drawing.Size(0, 17)
        '
        'Slabel5
        '
        Me.Slabel5.AccessibleName = "Slabel5"
        Me.Slabel5.Name = "Slabel5"
        Me.Slabel5.Size = New System.Drawing.Size(34, 17)
        Me.Slabel5.Text = "Level"
        '
        'Slabel6
        '
        Me.Slabel6.AccessibleName = "Slabel6"
        Me.Slabel6.Name = "Slabel6"
        Me.Slabel6.Size = New System.Drawing.Size(0, 17)
        '
        'Slabel7
        '
        Me.Slabel7.AccessibleName = "Slabel7"
        Me.Slabel7.Name = "Slabel7"
        Me.Slabel7.Size = New System.Drawing.Size(50, 17)
        Me.Slabel7.Text = "Tanggal"
        '
        'Slabel8
        '
        Me.Slabel8.AccessibleName = "Slabel8"
        Me.Slabel8.Name = "Slabel8"
        Me.Slabel8.Size = New System.Drawing.Size(0, 17)
        '
        'Slabel9
        '
        Me.Slabel9.AccessibleName = "Slabel9"
        Me.Slabel9.Name = "Slabel9"
        Me.Slabel9.Size = New System.Drawing.Size(41, 17)
        Me.Slabel9.Text = "Waktu"
        '
        'Slabel10
        '
        Me.Slabel10.AccessibleName = "Slabel10"
        Me.Slabel10.Name = "Slabel10"
        Me.Slabel10.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FAbsensekolah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(519, 275)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FAbsensekolah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Absen Sekolah"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Ms_file As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mi_login As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mi_logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ms_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mi_abssiswa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ms_laporan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mi_laporkehdiran As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Mi_user As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mi_exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Ms_utility As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mi_about As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Slabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Slabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Slabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Slabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Slabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Slabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Slabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Slabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Slabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Slabel10 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
