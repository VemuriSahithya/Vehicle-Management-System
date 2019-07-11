<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusHome
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShortDist_driversDataSet = New Sort_dist_cabs.ShortDist_driversDataSet()
        Me.BusTimingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BusTimingsTableAdapter = New Sort_dist_cabs.ShortDist_driversDataSetTableAdapters.BusTimingsTableAdapter()
        Me.ShortDist_driversDataSet1 = New Sort_dist_cabs.ShortDist_driversDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ShortDist_driversDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusTimingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShortDist_driversDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(570, 211)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 46)
        Me.Button3.TabIndex = 72
        Me.Button3.Text = "BACK"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.Color.Navy
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Assam Bengal Carriers", "Academic Complex IITG", "Administrative Building", "Amingaon", "Ambari", "Adabari Tiniali", "Bhanga Garh", "Bharalumukh", "Bamuni Maidan", "Commerce College", "Chandmari Police Point", "Commercial Complex", "Dighali Pukhuri", "Down Town Hospital", "Guwahati Collage", "Ganesh Guri", "Ganesh Mandir", "Hatigaon Assembly Hostel", "Jalukbari", "Jayguru", "Kamakhya", "Lachit Nagar", "Maligaon", "Noonmati", "Panbazar Over Bridge", "Pan Bazar", "Paltanbazar", "Sarab Bhati", "Subansiri Hostel", "Silpukhuri Gandhibasti Link", "Sixmile", "Sundarpur", "State Zoo", "Ulubari", "Uzanbazar Latasil field"})
        Me.ComboBox2.Location = New System.Drawing.Point(628, 154)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(206, 33)
        Me.ComboBox2.TabIndex = 71
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Navy
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Assam Bengal Carriers", "Academic Complex IITG", "Administrative Building", "Amingaon", "Ambari", "Adabari Tiniali", "Bhanga Garh", "Bharalumukh", "Bamuni Maidan", "Commerce College", "Chandmari Police Point", "Commercial Complex", "Dhigali Pukhuri", "Down Town Hospital", "Guwahati Collage", "Ganesh Guri", "Ganesh Mandir", "Hatigaon Assembly Hostel", "Jalukbari", "Jayguru", "Kamakhya", "Lachit Nagar", "Maligaon", "Noonmati", "Panbazar Over Bridge", "Pan Bazar", "Paltanbazar", "Sarab Bhati", "Subansiri Hostel", "Silpukhuri Gandhibasti Link", "Sixmile", "Sundarpur", "State Zoo", "Ulubari", "Uzanbazar Latasil field"})
        Me.ComboBox1.Location = New System.Drawing.Point(339, 151)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(206, 33)
        Me.ComboBox1.TabIndex = 70
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.DarkBlue
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(125, 275)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListView1.MinimumSize = New System.Drawing.Size(468, 198)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(884, 533)
        Me.ListView1.TabIndex = 69
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(433, 211)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 45)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "FIND"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(566, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 26)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "TO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(245, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 26)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "FROM"
        '
        'ShortDist_driversDataSet
        '
        Me.ShortDist_driversDataSet.DataSetName = "ShortDist_driversDataSet"
        Me.ShortDist_driversDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BusTimingsBindingSource
        '
        Me.BusTimingsBindingSource.DataMember = "BusTimings"
        Me.BusTimingsBindingSource.DataSource = Me.ShortDist_driversDataSet
        '
        'BusTimingsTableAdapter
        '
        Me.BusTimingsTableAdapter.ClearBeforeFill = True
        '
        'ShortDist_driversDataSet1
        '
        Me.ShortDist_driversDataSet1.DataSetName = "ShortDist_driversDataSet"
        Me.ShortDist_driversDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Sort_dist_cabs.My.Resources.Resources.background2
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1132, 105)
        Me.Panel1.TabIndex = 74
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sort_dist_cabs.My.Resources.Resources.bus
        Me.PictureBox2.Location = New System.Drawing.Point(125, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(135, 105)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 54
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(267, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(380, 68)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "BUS TIMINGS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Sort_dist_cabs.My.Resources.Resources.form_bg
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(1152, 960)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1152, 960)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'BusHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1132, 901)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1149, 946)
        Me.Name = "BusHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BusHome"
        CType(Me.ShortDist_driversDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusTimingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShortDist_driversDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShortDist_driversDataSet As Sort_dist_cabs.ShortDist_driversDataSet
    Friend WithEvents BusTimingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BusTimingsTableAdapter As Sort_dist_cabs.ShortDist_driversDataSetTableAdapters.BusTimingsTableAdapter
    Friend WithEvents ShortDist_driversDataSet1 As Sort_dist_cabs.ShortDist_driversDataSet
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
