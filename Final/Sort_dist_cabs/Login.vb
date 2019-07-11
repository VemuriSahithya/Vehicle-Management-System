Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Login

    'Basic login form for user of any type , just asks for username and password, has a button to reveal or hide the password written 
    'Also has a button to go to signup page if user doesnt have an account 

    Dim revealed As Boolean = False
    Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
    Dim cn As OleDbConnection = New OleDbConnection(connectString)

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        ' Accesses the user database and checks if the given combination exists , if yes then sets the details in the home form 
        cn.Open()
        Dim selectString As String = "SELECT * FROM Users WHERE User = @user "
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        cmd.Parameters.AddWithValue("@use", UsernameBox.Text)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read Then
            If reader("Password") = PasswordBox.Text Then

                Home.UserName = UsernameBox.Text
                Home.loggedin = True
                Home.UserType = reader("Type")
                Me.Close()
            Else
                MsgBox(UsernameBox.Text & " is a valid Username, however the password is incorrect . Please try Again! ")
                PasswordBox.Clear()
            End If
        Else
            MsgBox("Invalid UserName. Please try Again!")
            PasswordBox.Clear()
        End If
        cn.Close()
    End Sub
    ' Reaveals or Hides the Password
    Private Sub BtnReveal_Click(sender As Object, e As EventArgs) Handles BtnReveal.Click
        If revealed = False Then
            PasswordBox.PasswordChar = ""
            revealed = True
        Else
            PasswordBox.PasswordChar = "*"
            revealed = False
        End If
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Home.Reset()
        Home.Show()
    End Sub

    'Hides the Password and does Gui necessary changes 
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordBox.PasswordChar = "*"
        BtnReveal.Parent = Me
        CloseBtn.Parent = Panel1
        ClearBtn.Parent = PictureBox1
        ClearPass.Parent = PictureBox1
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        linkSignup.Parent = PictureBox1
        UsernameBox.Focus()
    End Sub
    'Clearing and closing Functions
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        UsernameBox.Clear()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ClearPass.Click
        PasswordBox.Clear()
    End Sub
    ' Link to go to Signup
    Private Sub linkSignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSignup.LinkClicked
        Me.Close()
        Signup.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class