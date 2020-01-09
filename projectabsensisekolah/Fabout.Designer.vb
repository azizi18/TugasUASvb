<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fabout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fabout))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_kmbout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(201, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "KELOMPOK 1"
        '
        'Btn_kmbout
        '
        Me.Btn_kmbout.BackColor = System.Drawing.Color.White
        Me.Btn_kmbout.BackgroundImage = CType(resources.GetObject("Btn_kmbout.BackgroundImage"), System.Drawing.Image)
        Me.Btn_kmbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_kmbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_kmbout.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Btn_kmbout.Location = New System.Drawing.Point(254, 319)
        Me.Btn_kmbout.Name = "Btn_kmbout"
        Me.Btn_kmbout.Size = New System.Drawing.Size(39, 23)
        Me.Btn_kmbout.TabIndex = 2
        Me.Btn_kmbout.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Btn_kmbout.UseVisualStyleBackColor = False
        '
        'Fabout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(526, 354)
        Me.Controls.Add(Me.Btn_kmbout)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fabout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fabout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_kmbout As System.Windows.Forms.Button
End Class
