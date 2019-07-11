<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.UsernameBox = New System.Windows.Forms.TextBox()
        Me.ClearPass = New System.Windows.Forms.Button()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnReveal = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.linkSignup = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.SkyBlue
        Me.ClearBtn.FlatAppearance.BorderSize = 0
        Me.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.Location = New System.Drawing.Point(397, 167)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(39, 40)
        Me.ClearBtn.TabIndex = 32
        Me.ClearBtn.Text = "<"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'UsernameBox
        '
        Me.UsernameBox.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameBox.Location = New System.Drawing.Point(109, 167)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(290, 40)
        Me.UsernameBox.TabIndex = 35
        '
        'ClearPass
        '
        Me.ClearPass.BackColor = System.Drawing.Color.SkyBlue
        Me.ClearPass.FlatAppearance.BorderSize = 0
        Me.ClearPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearPass.Location = New System.Drawing.Point(397, 266)
        Me.ClearPass.Name = "ClearPass"
        Me.ClearPass.Size = New System.Drawing.Size(39, 33)
        Me.ClearPass.TabIndex = 33
        Me.ClearPass.Text = "<"
        Me.ClearPass.UseVisualStyleBackColor = False
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LoginButton.FlatAppearance.BorderSize = 0
        Me.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginButton.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.LightGray
        Me.LoginButton.Location = New System.Drawing.Point(105, 346)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(349, 60)
        Me.LoginButton.TabIndex = 31
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'PasswordBox
        '
        Me.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordBox.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordBox.Location = New System.Drawing.Point(109, 266)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.Size = New System.Drawing.Size(290, 33)
        Me.PasswordBox.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 25)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "UserName"
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Transparent
        Me.CloseBtn.BackgroundImage = Global.Sort_dist_cabs.My.Resources.Resources.Backbutton
        Me.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloseBtn.FlatAppearance.BorderSize = 0
        Me.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.ForeColor = System.Drawing.Color.Transparent
        Me.CloseBtn.Location = New System.Drawing.Point(434, 3)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(78, 60)
        Me.CloseBtn.TabIndex = 22
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CloseBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(542, 65)
        Me.Panel1.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(214, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 55)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Login"
        '
        'BtnReveal
        '
        Me.BtnReveal.BackColor = System.Drawing.Color.Transparent
        Me.BtnReveal.BackgroundImage = Global.Sort_dist_cabs.My.Resources.Resources.pass_hide_show
        Me.BtnReveal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReveal.FlatAppearance.BorderSize = 0
        Me.BtnReveal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReveal.Location = New System.Drawing.Point(359, 266)
        Me.BtnReveal.Name = "BtnReveal"
        Me.BtnReveal.Size = New System.Drawing.Size(41, 33)
        Me.BtnReveal.TabIndex = 30
        Me.BtnReveal.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Sort_dist_cabs.My.Resources.Resources.form_bg
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(542, 453)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'linkSignup
        '
        Me.linkSignup.AutoSize = True
        Me.linkSignup.BackColor = System.Drawing.Color.Transparent
        Me.linkSignup.Font = New System.Drawing.Font("Verdana", 7.8!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkSignup.Location = New System.Drawing.Point(275, 418)
        Me.linkSignup.Name = "linkSignup"
        Me.linkSignup.Size = New System.Drawing.Size(193, 17)
        Me.linkSignup.TabIndex = 39
        Me.linkSignup.TabStop = True
        Me.linkSignup.Text = "Don't Have an account?"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 453)
        Me.Controls.Add(Me.linkSignup)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.UsernameBox)
        Me.Controls.Add(Me.ClearPass)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnReveal)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(542, 453)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents UsernameBox As System.Windows.Forms.TextBox
    Friend WithEvents ClearPass As System.Windows.Forms.Button
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents PasswordBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnReveal As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents linkSignup As System.Windows.Forms.LinkLabel
End Class
