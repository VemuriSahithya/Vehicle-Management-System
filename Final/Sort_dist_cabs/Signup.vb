Imports System.Data.OleDb
Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions

Public Class Signup
    ' Form to Signup new users. First it validates the data inputed and then enters a new row into the users coulmn 
    ' Depending on the usertype it also inserts a row witht he required table into the respective driver table 
    Dim Str As String ' Used to check captcha
    Dim revealed As Boolean = False
    ' Driver Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validates the captcha and data
        If CaptchaInput.Text <> Str Then
            MsgBox("Wrong Captcha")
        ElseIf PhoneNumberBox.TextLength <> 10 Or Not (Regex.IsMatch(PhoneNumberBox.Text, "^[0-9]+$")) Then
            MsgBox("Enter Valid Number")
        ElseIf UsernameBox.TextLength = 0 Or Not (Regex.IsMatch(UsernameBox.Text, "^[a-zA-Z0-9_]*$")) Then
            MsgBox("Enter Valid UserNmae, Only AlphaNum,or _")
        ElseIf PasswordBox.TextLength = 0 Then
            MsgBox("Password Field is empty")
        ElseIf FullNameBox.TextLength = 0 Or Not (Regex.IsMatch(UsernameBox.Text, "^[a-zA-Z]*$")) Then
            MsgBox("FullName Field is empty")
        Else
            ' Inserts a row into the users table 
            Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectString)
            cn.Open()
            Dim sqlQry As String = "INSERT INTO Users([User], [Password],[Fullname],[PhoneNumber],[Type])  VALUES (@usernme, @passwrd,@full,@num,@type)"
            Dim cmd As New OleDbCommand(sqlQry, cn)
            cmd.Parameters.AddWithValue("@usernme", UsernameBox.Text)
            cmd.Parameters.AddWithValue("@passwrd", PasswordBox.Text)
            cmd.Parameters.AddWithValue("@full", FullNameBox.Text)
            cmd.Parameters.AddWithValue("@num", PhoneNumberBox.Text)
            cmd.Parameters.AddWithValue("@type", ComboBox1.Text)

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)

                Exit Sub
            Finally
                cn.Close()
            End Try
            ' Automatically logs in the user
            Home.UserName = UsernameBox.Text
            Home.loggedin = True
            Home.UserType = ComboBox1.Text
            ' Depending on the user type inserts a row with the data into the respective column 
            If ComboBox1.Text <> "Customer" Then
                Dim sqlQry2 As String
                Dim cmd2 As OleDbCommand
                cn.Open()
                If ComboBox1.Text = "ShortDistanceDriver" Then
                    sqlQry2 = "INSERT INTO Drivers_shortDist(FirstName,PhoneNumber,CarModel,NumberPlate,Fare,Location)  VALUES(@full,@num,' ',' ',' ',' ')"
                    cmd2 = New OleDbCommand(sqlQry2, cn)
                    cmd2.Parameters.AddWithValue("@full", FullNameBox.Text)
                    cmd2.Parameters.AddWithValue("@num", PhoneNumberBox.Text)
                ElseIf ComboBox1.Text = "LongDistanceDriver" Then
                    sqlQry2 = "INSERT INTO Drivers_LongDistance(f_name,ph_no,car_n0,will_go,price)  VALUES(@full,@num,' ',' ',' ')"
                    cmd2 = New OleDbCommand(sqlQry2, cn)
                    cmd2.Parameters.AddWithValue("@full", FullNameBox.Text)
                    cmd2.Parameters.AddWithValue("@num", PhoneNumberBox.Text)
                ElseIf ComboBox1.Text = "ErickshawDriver" Then
                    sqlQry2 = "INSERT INTO Drivers_Erickshaw(Driver_Name,Phone_No,Location,Photo)  VALUES(@full,@num,' ',' ')"
                    cmd2 = New OleDbCommand(sqlQry2, cn)
                    cmd2.Parameters.AddWithValue("@full", FullNameBox.Text)
                    cmd2.Parameters.AddWithValue("@num", PhoneNumberBox.Text)
                End If
                Try
                    cmd2.ExecuteNonQuery()
                Catch ex2 As Exception
                    MsgBox(ex2.Message)
                    BtnRefresh.PerformClick()
                    Exit Sub
                Finally
                    cn.Close()
                End Try
            End If
            BtnRefresh.PerformClick()
            Me.Close()
        End If
        BtnRefresh.PerformClick()
    End Sub
    ' Function to randomly select 6 alphanumeric characters and create a bit image for captcha 
    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Dim NumCaptcha As String = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Str = ""
        Dim R As New Random
        For i As Integer = 0 To 5
            Str = Str + NumCaptcha(R.Next(0, 60))
        Next
        Dim b As New Bitmap(274, 71, Imaging.PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(b)
        Dim Hb As New HatchBrush(HatchStyle.DottedDiamond, Color.FromArgb(255, 128, 0), Color.Black)
        g.DrawString(Str, New Font("Monotype Corsiva", 40, FontStyle.Strikeout, GraphicsUnit.Point), Brushes.Black, 5, 5)
        PicCaptcha.Image = b
    End Sub

    Private Sub Signup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Home.Reset()
        Home.Show()
    End Sub

    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' masks the passwords and other utilities
        BtnRefresh.PerformClick()
        PasswordBox.PasswordChar = "*"
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.SelectedIndex = 0
        UsernameBox.Focus() 'addedby paul
        'setting parent parameters for UI
        BtnReveal.Parent = PictureBox1
        BtnRefresh.Parent = PictureBox1
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label3.Parent = PictureBox1
        Label4.Parent = PictureBox1
        Label5.Parent = PictureBox1
        Label6.Parent = PictureBox1
        CloseBtn.Parent = Panel1
    End Sub
    Private Sub BtnReveal_Click(sender As Object, e As EventArgs) Handles BtnReveal.Click
        ' revealing and masking the password
        If revealed = False Then
            PasswordBox.PasswordChar = ""
            revealed = True
        Else
            PasswordBox.PasswordChar = "*"
            revealed = False
        End If
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        PasswordBox.Clear()
        UsernameBox.Clear()
        PhoneNumberBox.Clear()
        CaptchaInput.Clear()
        FullNameBox.Clear()

    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub
End Class