<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReccoHome
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
        Me.rad1 = New System.Windows.Forms.RadioButton()
        Me.txtOutput1 = New System.Windows.Forms.RichTextBox()
        Me.txtboxTo = New System.Windows.Forms.TextBox()
        Me.txtboxFrom = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnMap = New System.Windows.Forms.Button()
        Me.btnFindCabs = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.picArrow = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rad1
        '
        Me.rad1.AutoSize = True
        Me.rad1.BackColor = System.Drawing.Color.Transparent
        Me.rad1.Location = New System.Drawing.Point(796, 470)
        Me.rad1.Name = "rad1"
        Me.rad1.Size = New System.Drawing.Size(17, 16)
        Me.rad1.TabIndex = 42
        Me.rad1.TabStop = True
        Me.rad1.UseVisualStyleBackColor = False
        '
        'txtOutput1
        '
        Me.txtOutput1.BackColor = System.Drawing.Color.AliceBlue
        Me.txtOutput1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput1.ForeColor = System.Drawing.Color.DimGray
        Me.txtOutput1.Location = New System.Drawing.Point(237, 417)
        Me.txtOutput1.Name = "txtOutput1"
        Me.txtOutput1.Size = New System.Drawing.Size(532, 118)
        Me.txtOutput1.TabIndex = 41
        Me.txtOutput1.Text = ""
        '
        'txtboxTo
        '
        Me.txtboxTo.BackColor = System.Drawing.Color.LightCyan
        Me.txtboxTo.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxTo.ForeColor = System.Drawing.Color.LightCoral
        Me.txtboxTo.Location = New System.Drawing.Point(557, 249)
        Me.txtboxTo.Name = "txtboxTo"
        Me.txtboxTo.ReadOnly = True
        Me.txtboxTo.Size = New System.Drawing.Size(237, 35)
        Me.txtboxTo.TabIndex = 40
        '
        'txtboxFrom
        '
        Me.txtboxFrom.BackColor = System.Drawing.Color.LightCyan
        Me.txtboxFrom.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxFrom.ForeColor = System.Drawing.Color.LightCoral
        Me.txtboxFrom.Location = New System.Drawing.Point(218, 249)
        Me.txtboxFrom.Name = "txtboxFrom"
        Me.txtboxFrom.ReadOnly = True
        Me.txtboxFrom.Size = New System.Drawing.Size(237, 35)
        Me.txtboxFrom.TabIndex = 39
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Sort_dist_cabs.My.Resources.Resources.form_bg
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1006, 721)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'btnMap
        '
        Me.btnMap.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnMap.BackgroundImage = Global.Sort_dist_cabs.My.Resources.Resources.map_cropped
        Me.btnMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMap.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin
        Me.btnMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMap.Location = New System.Drawing.Point(440, 112)
        Me.btnMap.Name = "btnMap"
        Me.btnMap.Size = New System.Drawing.Size(142, 114)
        Me.btnMap.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.btnMap, "Open Map")
        Me.btnMap.UseVisualStyleBackColor = False
        '
        'btnFindCabs
        '
        Me.btnFindCabs.BackColor = System.Drawing.Color.White
        Me.btnFindCabs.BackgroundImage = Global.Sort_dist_cabs.My.Resources.Resources.findCabsIcon
        Me.btnFindCabs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFindCabs.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin
        Me.btnFindCabs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.btnFindCabs.Location = New System.Drawing.Point(440, 298)
        Me.btnFindCabs.Name = "btnFindCabs"
        Me.btnFindCabs.Size = New System.Drawing.Size(142, 114)
        Me.btnFindCabs.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.btnFindCabs, "Find Cabs")
        Me.btnFindCabs.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.White
        Me.btnConfirm.BackgroundImage = Global.Sort_dist_cabs.My.Resources.Resources.confirmDriver
        Me.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin
        Me.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.btnConfirm.Location = New System.Drawing.Point(440, 298)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(142, 114)
        Me.btnConfirm.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.btnConfirm, "Confirm Driver?")
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'picArrow
        '
        Me.picArrow.BackColor = System.Drawing.Color.Transparent
        Me.picArrow.Image = Global.Sort_dist_cabs.My.Resources.Resources.arrow
        Me.picArrow.Location = New System.Drawing.Point(477, 249)
        Me.picArrow.Name = "picArrow"
        Me.picArrow.Size = New System.Drawing.Size(63, 35)
        Me.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picArrow.TabIndex = 45
        Me.picArrow.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.Sort_dist_cabs.My.Resources.Resources.Backbutton
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(944, 112)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(50, 46)
        Me.btnBack.TabIndex = 38
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Sort_dist_cabs.My.Resources.Resources.background2
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 84)
        Me.Panel1.TabIndex = 78
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(348, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(356, 56)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Recommendations"
        '
        'ReccoHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnFindCabs)
        Me.Controls.Add(Me.btnMap)
        Me.Controls.Add(Me.rad1)
        Me.Controls.Add(Me.txtOutput1)
        Me.Controls.Add(Me.txtboxTo)
        Me.Controls.Add(Me.txtboxFrom)
        Me.Controls.Add(Me.picArrow)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "ReccoHome"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReccoHome"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rad1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtOutput1 As System.Windows.Forms.RichTextBox
    Friend WithEvents txtboxTo As System.Windows.Forms.TextBox
    Friend WithEvents txtboxFrom As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents picArrow As System.Windows.Forms.PictureBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnMap As System.Windows.Forms.Button
    Friend WithEvents btnFindCabs As System.Windows.Forms.Button
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
