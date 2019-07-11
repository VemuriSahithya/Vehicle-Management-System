<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class e_rick_driver_reco
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.L_location = New System.Windows.Forms.Label()
        Me.L_phone = New System.Windows.Forms.Label()
        Me.L_name = New System.Windows.Forms.Label()
        Me.Label_name = New System.Windows.Forms.Label()
        Me.Label_location = New System.Windows.Forms.Label()
        Me.Label_phone = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ERick_GridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.ERick_GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'L_location
        '
        Me.L_location.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.L_location.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_location.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_location.Location = New System.Drawing.Point(276, 261)
        Me.L_location.Name = "L_location"
        Me.L_location.Size = New System.Drawing.Size(348, 35)
        Me.L_location.TabIndex = 74
        Me.L_location.Text = "Name"
        Me.L_location.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_phone
        '
        Me.L_phone.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.L_phone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_phone.Location = New System.Drawing.Point(276, 205)
        Me.L_phone.Name = "L_phone"
        Me.L_phone.Size = New System.Drawing.Size(348, 35)
        Me.L_phone.TabIndex = 73
        Me.L_phone.Text = "Name"
        Me.L_phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_name
        '
        Me.L_name.BackColor = System.Drawing.Color.White
        Me.L_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_name.Location = New System.Drawing.Point(276, 147)
        Me.L_name.Name = "L_name"
        Me.L_name.Size = New System.Drawing.Size(348, 34)
        Me.L_name.TabIndex = 72
        Me.L_name.Text = "Name"
        Me.L_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_name
        '
        Me.Label_name.AutoSize = True
        Me.Label_name.BackColor = System.Drawing.Color.Transparent
        Me.Label_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_name.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_name.ForeColor = System.Drawing.Color.Black
        Me.Label_name.Location = New System.Drawing.Point(111, 155)
        Me.Label_name.Name = "Label_name"
        Me.Label_name.Size = New System.Drawing.Size(90, 29)
        Me.Label_name.TabIndex = 71
        Me.Label_name.Text = "Name"
        '
        'Label_location
        '
        Me.Label_location.AutoSize = True
        Me.Label_location.BackColor = System.Drawing.Color.Transparent
        Me.Label_location.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_location.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_location.ForeColor = System.Drawing.Color.Black
        Me.Label_location.Location = New System.Drawing.Point(111, 270)
        Me.Label_location.Name = "Label_location"
        Me.Label_location.Size = New System.Drawing.Size(126, 29)
        Me.Label_location.TabIndex = 70
        Me.Label_location.Text = "Location"
        '
        'Label_phone
        '
        Me.Label_phone.AutoSize = True
        Me.Label_phone.BackColor = System.Drawing.Color.Transparent
        Me.Label_phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_phone.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_phone.ForeColor = System.Drawing.Color.Black
        Me.Label_phone.Location = New System.Drawing.Point(111, 214)
        Me.Label_phone.Name = "Label_phone"
        Me.Label_phone.Size = New System.Drawing.Size(141, 29)
        Me.Label_phone.TabIndex = 69
        Me.Label_phone.Text = "Phone No"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkRed
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(102, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 32)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Other Available Drivers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ERick_GridView
        '
        Me.ERick_GridView.AllowUserToAddRows = False
        Me.ERick_GridView.AllowUserToDeleteRows = False
        Me.ERick_GridView.AllowUserToResizeColumns = False
        Me.ERick_GridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.ERick_GridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ERick_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ERick_GridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ERick_GridView.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.ERick_GridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ERick_GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ERick_GridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ERick_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ERick_GridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.ERick_GridView.Location = New System.Drawing.Point(91, 377)
        Me.ERick_GridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ERick_GridView.Name = "ERick_GridView"
        Me.ERick_GridView.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ERick_GridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ERick_GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.ERick_GridView.RowTemplate.Height = 28
        Me.ERick_GridView.Size = New System.Drawing.Size(813, 306)
        Me.ERick_GridView.TabIndex = 66
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Sort_dist_cabs.My.Resources.Resources.background2
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 84)
        Me.Panel1.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(106, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(664, 56)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "E-rickshaw Driver Closest to you"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(690, 119)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(207, 206)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.Sort_dist_cabs.My.Resources.Resources.form_bg
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1006, 721)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 75
        Me.PictureBox2.TabStop = False
        '
        'e_rick_driver_reco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.L_location)
        Me.Controls.Add(Me.L_phone)
        Me.Controls.Add(Me.L_name)
        Me.Controls.Add(Me.Label_name)
        Me.Controls.Add(Me.Label_location)
        Me.Controls.Add(Me.Label_phone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ERick_GridView)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "e_rick_driver_reco"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "e_rick_driver_reco"
        CType(Me.ERick_GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents L_location As System.Windows.Forms.Label
    Friend WithEvents L_phone As System.Windows.Forms.Label
    Friend WithEvents L_name As System.Windows.Forms.Label
    Friend WithEvents Label_name As System.Windows.Forms.Label
    Friend WithEvents Label_location As System.Windows.Forms.Label
    Friend WithEvents Label_phone As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ERick_GridView As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
