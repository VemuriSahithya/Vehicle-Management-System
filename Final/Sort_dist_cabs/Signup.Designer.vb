<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.CaptchaInput = New System.Windows.Forms.TextBox()
        Me.BtnReveal = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.FullNameBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberBox = New System.Windows.Forms.TextBox()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.UsernameBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PicCaptcha = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PicCaptcha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(241, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 55)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Sign Up"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CloseBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(673, 74)
        Me.Panel1.TabIndex = 56
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Transparent
        Me.CloseBtn.BackgroundImage = Global.Sort_dist_cabs.My.Resources.Resources.Backbutton
        Me.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CloseBtn.FlatAppearance.BorderSize = 0
        Me.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.Location = New System.Drawing.Point(593, 4)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(68, 60)
        Me.CloseBtn.TabIndex = 24
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'CaptchaInput
        '
        Me.CaptchaInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CaptchaInput.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaptchaInput.Location = New System.Drawing.Point(271, 488)
        Me.CaptchaInput.Name = "CaptchaInput"
        Me.CaptchaInput.Size = New System.Drawing.Size(336, 33)
        Me.CaptchaInput.TabIndex = 55
        '
        'BtnReveal
        '
        Me.BtnReveal.BackColor = System.Drawing.Color.Transparent
        Me.BtnReveal.BackgroundImage = Global.Sort_dist_cabs.My.Resources.Resources.pass_hide_show
        Me.BtnReveal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReveal.FlatAppearance.BorderSize = 0
        Me.BtnReveal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.BtnReveal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReveal.Location = New System.Drawing.Point(608, 154)
        Me.BtnReveal.Name = "BtnReveal"
        Me.BtnReveal.Size = New System.Drawing.Size(41, 33)
        Me.BtnReveal.TabIndex = 49
        Me.BtnReveal.UseVisualStyleBackColor = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.BtnRefresh.BackgroundImage = Global.Sort_dist_cabs.My.Resources.Resources.refreshButton
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRefresh.FlatAppearance.BorderSize = 0
        Me.BtnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Location = New System.Drawing.Point(608, 381)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(44, 39)
        Me.BtnRefresh.TabIndex = 43
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'FullNameBox
        '
        Me.FullNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FullNameBox.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullNameBox.Location = New System.Drawing.Point(273, 266)
        Me.FullNameBox.Name = "FullNameBox"
        Me.FullNameBox.Size = New System.Drawing.Size(331, 33)
        Me.FullNameBox.TabIndex = 54
        '
        'PhoneNumberBox
        '
        Me.PhoneNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PhoneNumberBox.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumberBox.Location = New System.Drawing.Point(273, 209)
        Me.PhoneNumberBox.Name = "PhoneNumberBox"
        Me.PhoneNumberBox.Size = New System.Drawing.Size(331, 33)
        Me.PhoneNumberBox.TabIndex = 53
        '
        'PasswordBox
        '
        Me.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordBox.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordBox.Location = New System.Drawing.Point(273, 154)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.Size = New System.Drawing.Size(331, 33)
        Me.PasswordBox.TabIndex = 52
        '
        'UsernameBox
        '
        Me.UsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsernameBox.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameBox.Location = New System.Drawing.Point(273, 96)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(331, 33)
        Me.UsernameBox.TabIndex = 51
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Customer", "LongDistanceDriver", "ShortDistanceDriver", "ErickshawDriver"})
        Me.ComboBox1.Location = New System.Drawing.Point(273, 324)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(331, 33)
        Me.ComboBox1.TabIndex = 48
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClearBtn.FlatAppearance.BorderSize = 0
        Me.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearBtn.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.Color.LightGray
        Me.ClearBtn.Location = New System.Drawing.Point(66, 559)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(111, 60)
        Me.ClearBtn.TabIndex = 46
        Me.ClearBtn.Text = "Clear All"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 29)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "User Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 29)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Captcha"
        '
        'PicCaptcha
        '
        Me.PicCaptcha.Location = New System.Drawing.Point(271, 381)
        Me.PicCaptcha.Name = "PicCaptcha"
        Me.PicCaptcha.Size = New System.Drawing.Size(336, 89)
        Me.PicCaptcha.TabIndex = 44
        Me.PicCaptcha.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightGray
        Me.Button1.Location = New System.Drawing.Point(311, 559)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(262, 60)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Signup"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 29)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Full name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 29)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Phonenumber"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 29)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 29)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "UserName"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Sort_dist_cabs.My.Resources.Resources.form_bg
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(673, 637)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 637)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CaptchaInput)
        Me.Controls.Add(Me.BtnReveal)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.FullNameBox)
        Me.Controls.Add(Me.PhoneNumberBox)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.UsernameBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PicCaptcha)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(691, 684)
        Me.Name = "Signup"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PicCaptcha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents CaptchaInput As System.Windows.Forms.TextBox
    Friend WithEvents BtnReveal As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents FullNameBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PicCaptcha As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
