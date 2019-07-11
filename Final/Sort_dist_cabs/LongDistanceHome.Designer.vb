<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LongDistanceHome
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
        Me.cnfrmBtn = New System.Windows.Forms.Button()
        Me.rad1 = New System.Windows.Forms.RadioButton()
        Me.output_Box1 = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShortDist_driversDataSet = New Sort_dist_cabs.ShortDist_driversDataSet()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.srch_btn = New System.Windows.Forms.Button()
        Me.DriversLongDistanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DriversLongDistanceBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.bck_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.ShortDist_driversDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriversLongDistanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriversLongDistanceBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cnfrmBtn
        '
        Me.cnfrmBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cnfrmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cnfrmBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnfrmBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.cnfrmBtn.Location = New System.Drawing.Point(469, 321)
        Me.cnfrmBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cnfrmBtn.Name = "cnfrmBtn"
        Me.cnfrmBtn.Size = New System.Drawing.Size(111, 55)
        Me.cnfrmBtn.TabIndex = 73
        Me.cnfrmBtn.Text = "confirm?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cnfrmBtn.UseVisualStyleBackColor = False
        '
        'rad1
        '
        Me.rad1.AutoSize = True
        Me.rad1.BackColor = System.Drawing.Color.Transparent
        Me.rad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad1.Location = New System.Drawing.Point(898, 496)
        Me.rad1.Margin = New System.Windows.Forms.Padding(4)
        Me.rad1.Name = "rad1"
        Me.rad1.Size = New System.Drawing.Size(17, 16)
        Me.rad1.TabIndex = 72
        Me.rad1.TabStop = True
        Me.rad1.UseVisualStyleBackColor = False
        '
        'output_Box1
        '
        Me.output_Box1.BackColor = System.Drawing.Color.Cornsilk
        Me.output_Box1.Location = New System.Drawing.Point(150, 449)
        Me.output_Box1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.output_Box1.Name = "output_Box1"
        Me.output_Box1.Size = New System.Drawing.Size(673, 96)
        Me.output_Box1.TabIndex = 71
        Me.output_Box1.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(411, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 34)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "IIT Guwahati"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Brown
        Me.Label4.Location = New System.Drawing.Point(297, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 34)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Brown
        Me.Label3.Location = New System.Drawing.Point(340, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 34)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(378, 387)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 34)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Available drivers"
        '
        'ShortDist_driversDataSet
        '
        Me.ShortDist_driversDataSet.DataSetName = "ShortDist_driversDataSet"
        Me.ShortDist_driversDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Location = New System.Drawing.Point(543, 266)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 51)
        Me.Button2.TabIndex = 64
        Me.Button2.Text = "cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'srch_btn
        '
        Me.srch_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.srch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.srch_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srch_btn.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.srch_btn.Location = New System.Drawing.Point(416, 266)
        Me.srch_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.srch_btn.Name = "srch_btn"
        Me.srch_btn.Size = New System.Drawing.Size(91, 51)
        Me.srch_btn.TabIndex = 63
        Me.srch_btn.Text = "Search"
        Me.srch_btn.UseVisualStyleBackColor = False
        '
        'DriversLongDistanceBindingSource
        '
        Me.DriversLongDistanceBindingSource.DataMember = "Drivers_LongDistance"
        Me.DriversLongDistanceBindingSource.DataSource = Me.ShortDist_driversDataSet
        '
        'DriversLongDistanceBindingSource1
        '
        Me.DriversLongDistanceBindingSource1.DataMember = "Drivers_LongDistance"
        Me.DriversLongDistanceBindingSource1.DataSource = Me.ShortDist_driversDataSet
        '
        'bck_btn
        '
        Me.bck_btn.BackColor = System.Drawing.Color.Transparent
        Me.bck_btn.BackgroundImage = Global.Sort_dist_cabs.My.Resources.Resources.Backbutton
        Me.bck_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bck_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.bck_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.bck_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bck_btn.ForeColor = System.Drawing.Color.Yellow
        Me.bck_btn.Location = New System.Drawing.Point(914, 89)
        Me.bck_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bck_btn.Name = "bck_btn"
        Me.bck_btn.Size = New System.Drawing.Size(80, 73)
        Me.bck_btn.TabIndex = 65
        Me.bck_btn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Sort_dist_cabs.My.Resources.Resources.background2
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 84)
        Me.Panel1.TabIndex = 75
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(107, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(790, 56)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Welcome To Long Distance Cab Service"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Sort_dist_cabs.My.Resources.Resources.form_bg
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1006, 721)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Verdana", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"shillong", "sikkim", "dzukou", "kaziranga", "shivsagar"})
        Me.ComboBox1.Location = New System.Drawing.Point(409, 211)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(227, 40)
        Me.ComboBox1.TabIndex = 76
        '
        'LongDistanceHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cnfrmBtn)
        Me.Controls.Add(Me.bck_btn)
        Me.Controls.Add(Me.rad1)
        Me.Controls.Add(Me.output_Box1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.srch_btn)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "LongDistanceHome"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Long Distance Cabs Home"
        CType(Me.ShortDist_driversDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriversLongDistanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriversLongDistanceBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cnfrmBtn As System.Windows.Forms.Button
    Friend WithEvents bck_btn As System.Windows.Forms.Button
    Friend WithEvents rad1 As System.Windows.Forms.RadioButton
    Friend WithEvents output_Box1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ShortDist_driversDataSet As Sort_dist_cabs.ShortDist_driversDataSet
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents srch_btn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DriversLongDistanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DriversLongDistanceBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
