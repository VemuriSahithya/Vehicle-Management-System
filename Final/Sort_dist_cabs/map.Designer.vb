<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class map
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
        Me.RichTextBoxTo = New System.Windows.Forms.TextBox()
        Me.RichTextBoxFrom = New System.Windows.Forms.TextBox()
        Me.radioStadium = New System.Windows.Forms.RadioButton()
        Me.radioKamakhya = New System.Windows.Forms.RadioButton()
        Me.radioGanesh = New System.Windows.Forms.RadioButton()
        Me.radioJalukbari = New System.Windows.Forms.RadioButton()
        Me.radioAirport = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtboxCurrentSelection = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnTo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFrom = New System.Windows.Forms.Button()
        Me.radioBeltola = New System.Windows.Forms.RadioButton()
        Me.radioPaltan = New System.Windows.Forms.RadioButton()
        Me.radioIITG = New System.Windows.Forms.RadioButton()
        Me.picMap = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picMap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBoxTo
        '
        Me.RichTextBoxTo.BackColor = System.Drawing.Color.Linen
        Me.RichTextBoxTo.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxTo.Location = New System.Drawing.Point(1126, 132)
        Me.RichTextBoxTo.Name = "RichTextBoxTo"
        Me.RichTextBoxTo.ReadOnly = True
        Me.RichTextBoxTo.Size = New System.Drawing.Size(175, 28)
        Me.RichTextBoxTo.TabIndex = 105
        Me.RichTextBoxTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RichTextBoxFrom
        '
        Me.RichTextBoxFrom.BackColor = System.Drawing.Color.Linen
        Me.RichTextBoxFrom.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxFrom.Location = New System.Drawing.Point(1126, 71)
        Me.RichTextBoxFrom.Name = "RichTextBoxFrom"
        Me.RichTextBoxFrom.ReadOnly = True
        Me.RichTextBoxFrom.Size = New System.Drawing.Size(175, 28)
        Me.RichTextBoxFrom.TabIndex = 104
        Me.RichTextBoxFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'radioStadium
        '
        Me.radioStadium.AutoSize = True
        Me.radioStadium.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioStadium.Location = New System.Drawing.Point(749, 431)
        Me.radioStadium.Name = "radioStadium"
        Me.radioStadium.Size = New System.Drawing.Size(162, 24)
        Me.radioStadium.TabIndex = 102
        Me.radioStadium.TabStop = True
        Me.radioStadium.Text = "IGA STADIUM"
        Me.radioStadium.UseVisualStyleBackColor = True
        '
        'radioKamakhya
        '
        Me.radioKamakhya.AutoSize = True
        Me.radioKamakhya.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioKamakhya.Location = New System.Drawing.Point(532, 232)
        Me.radioKamakhya.Name = "radioKamakhya"
        Me.radioKamakhya.Size = New System.Drawing.Size(138, 24)
        Me.radioKamakhya.TabIndex = 101
        Me.radioKamakhya.TabStop = True
        Me.radioKamakhya.Text = "KAMAKHYA"
        Me.radioKamakhya.UseVisualStyleBackColor = True
        '
        'radioGanesh
        '
        Me.radioGanesh.AutoSize = True
        Me.radioGanesh.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioGanesh.Location = New System.Drawing.Point(834, 265)
        Me.radioGanesh.Name = "radioGanesh"
        Me.radioGanesh.Size = New System.Drawing.Size(159, 24)
        Me.radioGanesh.TabIndex = 100
        Me.radioGanesh.TabStop = True
        Me.radioGanesh.Text = "GANESHGURI"
        Me.radioGanesh.UseVisualStyleBackColor = True
        '
        'radioJalukbari
        '
        Me.radioJalukbari.AutoSize = True
        Me.radioJalukbari.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioJalukbari.Location = New System.Drawing.Point(446, 265)
        Me.radioJalukbari.Name = "radioJalukbari"
        Me.radioJalukbari.Size = New System.Drawing.Size(138, 24)
        Me.radioJalukbari.TabIndex = 99
        Me.radioJalukbari.TabStop = True
        Me.radioJalukbari.Text = "JALUKBARI"
        Me.radioJalukbari.UseVisualStyleBackColor = True
        '
        'radioAirport
        '
        Me.radioAirport.AutoSize = True
        Me.radioAirport.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioAirport.Location = New System.Drawing.Point(143, 408)
        Me.radioAirport.Name = "radioAirport"
        Me.radioAirport.Size = New System.Drawing.Size(116, 24)
        Me.radioAirport.TabIndex = 98
        Me.radioAirport.TabStop = True
        Me.radioAirport.Text = "AIRPORT"
        Me.radioAirport.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1126, 338)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(175, 48)
        Me.btnClear.TabIndex = 97
        Me.btnClear.Text = "Clear Choices?"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtboxCurrentSelection
        '
        Me.txtboxCurrentSelection.BackColor = System.Drawing.Color.Azure
        Me.txtboxCurrentSelection.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxCurrentSelection.ForeColor = System.Drawing.Color.DarkGray
        Me.txtboxCurrentSelection.Location = New System.Drawing.Point(815, 46)
        Me.txtboxCurrentSelection.Name = "txtboxCurrentSelection"
        Me.txtboxCurrentSelection.ReadOnly = True
        Me.txtboxCurrentSelection.Size = New System.Drawing.Size(228, 32)
        Me.txtboxCurrentSelection.TabIndex = 96
        Me.txtboxCurrentSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Teal
        Me.btnConfirm.FlatAppearance.BorderSize = 2
        Me.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfirm.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnConfirm.Location = New System.Drawing.Point(1126, 408)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(175, 81)
        Me.btnConfirm.TabIndex = 95
        Me.btnConfirm.Text = "Confirm?"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnTo
        '
        Me.btnTo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnTo.BackgroundImage = Global.Sort_dist_cabs.My.Resources.Resources.MyDestinationIcon
        Me.btnTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTo.FlatAppearance.BorderSize = 0
        Me.btnTo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.btnTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTo.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTo.ForeColor = System.Drawing.Color.Snow
        Me.btnTo.Location = New System.Drawing.Point(1126, 177)
        Me.btnTo.Name = "btnTo"
        Me.btnTo.Size = New System.Drawing.Size(175, 155)
        Me.btnTo.TabIndex = 94
        Me.ToolTip1.SetToolTip(Me.btnTo, "My Destination")
        Me.btnTo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1123, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 17)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Your Location as :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1123, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 17)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Your Destination as :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1122, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 20)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "You have selected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnFrom
        '
        Me.btnFrom.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnFrom.BackgroundImage = Global.Sort_dist_cabs.My.Resources.Resources.myLocationIcon
        Me.btnFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFrom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFrom.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnFrom.FlatAppearance.BorderSize = 0
        Me.btnFrom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.btnFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFrom.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrom.ForeColor = System.Drawing.Color.Snow
        Me.btnFrom.Location = New System.Drawing.Point(1126, 177)
        Me.btnFrom.Name = "btnFrom"
        Me.btnFrom.Size = New System.Drawing.Size(175, 155)
        Me.btnFrom.TabIndex = 90
        Me.ToolTip1.SetToolTip(Me.btnFrom, "My Location")
        Me.btnFrom.UseVisualStyleBackColor = False
        '
        'radioBeltola
        '
        Me.radioBeltola.AutoSize = True
        Me.radioBeltola.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioBeltola.Location = New System.Drawing.Point(856, 377)
        Me.radioBeltola.Name = "radioBeltola"
        Me.radioBeltola.Size = New System.Drawing.Size(116, 24)
        Me.radioBeltola.TabIndex = 89
        Me.radioBeltola.TabStop = True
        Me.radioBeltola.Text = "BELTOLA"
        Me.radioBeltola.UseVisualStyleBackColor = True
        '
        'radioPaltan
        '
        Me.radioPaltan.AutoSize = True
        Me.radioPaltan.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioPaltan.Location = New System.Drawing.Point(675, 172)
        Me.radioPaltan.Name = "radioPaltan"
        Me.radioPaltan.Size = New System.Drawing.Size(175, 24)
        Me.radioPaltan.TabIndex = 88
        Me.radioPaltan.TabStop = True
        Me.radioPaltan.Text = "PALTAN BAZAR"
        Me.radioPaltan.UseVisualStyleBackColor = True
        '
        'radioIITG
        '
        Me.radioIITG.AutoSize = True
        Me.radioIITG.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioIITG.Location = New System.Drawing.Point(484, 71)
        Me.radioIITG.Name = "radioIITG"
        Me.radioIITG.Size = New System.Drawing.Size(174, 24)
        Me.radioIITG.TabIndex = 87
        Me.radioIITG.TabStop = True
        Me.radioIITG.Text = "IIT GUWAHATI"
        Me.radioIITG.UseVisualStyleBackColor = True
        '
        'picMap
        '
        Me.picMap.BackColor = System.Drawing.Color.Transparent
        Me.picMap.BackgroundImage = Global.Sort_dist_cabs.My.Resources.Resources.Guw_map_shrt_cabs
        Me.picMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picMap.InitialImage = Global.Sort_dist_cabs.My.Resources.Resources.Guw_map_shrt_cabs
        Me.picMap.Location = New System.Drawing.Point(27, 26)
        Me.picMap.MaximumSize = New System.Drawing.Size(1044, 494)
        Me.picMap.Name = "picMap"
        Me.picMap.Size = New System.Drawing.Size(1044, 494)
        Me.picMap.TabIndex = 86
        Me.picMap.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Sort_dist_cabs.My.Resources.Resources.form_bg
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1347, 558)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 103
        Me.PictureBox1.TabStop = False
        '
        'map
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1347, 558)
        Me.Controls.Add(Me.RichTextBoxTo)
        Me.Controls.Add(Me.RichTextBoxFrom)
        Me.Controls.Add(Me.radioStadium)
        Me.Controls.Add(Me.radioKamakhya)
        Me.Controls.Add(Me.radioGanesh)
        Me.Controls.Add(Me.radioJalukbari)
        Me.Controls.Add(Me.radioAirport)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtboxCurrentSelection)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnTo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFrom)
        Me.Controls.Add(Me.radioBeltola)
        Me.Controls.Add(Me.radioPaltan)
        Me.Controls.Add(Me.radioIITG)
        Me.Controls.Add(Me.picMap)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1365, 605)
        Me.Name = "map"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Map"
        CType(Me.picMap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBoxTo As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBoxFrom As System.Windows.Forms.TextBox
    Friend WithEvents radioStadium As System.Windows.Forms.RadioButton
    Friend WithEvents radioKamakhya As System.Windows.Forms.RadioButton
    Friend WithEvents radioGanesh As System.Windows.Forms.RadioButton
    Friend WithEvents radioJalukbari As System.Windows.Forms.RadioButton
    Friend WithEvents radioAirport As System.Windows.Forms.RadioButton
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtboxCurrentSelection As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnTo As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFrom As System.Windows.Forms.Button
    Friend WithEvents radioBeltola As System.Windows.Forms.RadioButton
    Friend WithEvents radioPaltan As System.Windows.Forms.RadioButton
    Friend WithEvents radioIITG As System.Windows.Forms.RadioButton
    Friend WithEvents picMap As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
