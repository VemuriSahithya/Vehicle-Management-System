Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class UserDetails

    ' Profile form for users to Edit their details . Contains a tab Control to choose which type of user it is displays details to 
    ' Allows user to edit his details . and also view theier current bookings 
    Dim original As String
    Dim TabChoice As Integer = 1
    Dim userType As String = Home.UserType
    Dim username As String = Home.UserName
    ' Utility function to choose which tab to display depending on the usertyoe and also call the correct loading function
    Public Sub selection()
        If userType.ToLower = "customer" Then
            TabChoice = 0
            CustLoad()
        ElseIf userType.ToLower = "erickshawdriver" Then
            TabChoice = 3
            ErickshawLoad()
        ElseIf userType.ToLower = "shortdistancedriver" Then
            TabChoice = 1
            ShortDriverLoad()
        ElseIf userType.ToLower = "longdistancedriver" Then
            TabChoice = 2
            LongDriverLoad()
        Else
            MsgBox("User Not logged in")
            Me.Close()
        End If
    End Sub

    Private Sub UserDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Home.Reset()
        Home.Show()
    End Sub


    Private Sub UserDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        selection()
        tabs.SelectedIndex = TabChoice

    End Sub

    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tabs.Selecting
        ' Doeesnt allow the user to switch tabs
        If e.TabPageIndex <> TabChoice Then
            e.Cancel = True
        End If

    End Sub
    ' Fucntion to read data from user table and load into form by searching using the username for Customer
    Public Sub CustLoad()
        Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
        Dim cn As OleDbConnection = New OleDbConnection(connectString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Users WHERE User = '" & username & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            CustUser.Text = reader("User")
            CustPass.Text = reader("Password")
            CustPass.PasswordChar = "*"
            CustPhone.Text = reader("PhoneNumber")
            Custfull.Text = reader("FullName")
            cn.Close()
        End If
    End Sub
    ' Fucntion to read data from user table and load into form by searching using the username , and firstname in Driver_shortDistfor ShortDistance Driver

    Public Sub ShortDriverLoad()
        Dim userfullname As String
        Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
        Dim cn As OleDbConnection = New OleDbConnection(connectString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Users WHERE User = '" & username & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        reader.Read()
        ShortUser.Text = reader("User")
        ShortPass.Text = reader("Password")
        ShortPass.PasswordChar = "*"
        ShortPhone.Text = reader("PhoneNumber")
        ShortFull.Text = reader("FullName")
        userfullname = reader("FullName")
        cn.Close()
        cn.Open()
        selectString = "SELECT * FROM Drivers_shortDist WHERE FirstName = '" & userfullname & "'"
        cmd = New OleDbCommand(selectString, cn)
        reader = cmd.ExecuteReader()
        reader.Read()

        ShortCar.Text = reader("CarModel").ToString
        ShortPlate.Text = reader("NumberPlate").ToString
        ShortFare.Text = reader("Fare").ToString
        ShortLocation.Text = reader("Location").ToString
        ShortAvail.Checked = reader("Available")
        cn.Close()
        original = ShortFull.Text
    End Sub
    ' Fucntion to read data from user table and load into form by searching using the username , and f_name in Driver_longDistfor LongDistance Driver
    Public Sub LongDriverLoad()
        Dim userfullname As String
        Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
        Dim cn As OleDbConnection = New OleDbConnection(connectString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Users WHERE User = '" & username & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        reader.Read()
        LongUser.Text = reader("User")
        LongPass.Text = reader("Password")
        LongPass.PasswordChar = "*"
        LongPhone.Text = reader("PhoneNumber")
        LongFull.Text = reader("FullName")
        userfullname = reader("FullName")
        cn.Close()
        cn.Open()
        selectString = "SELECT * FROM Drivers_LongDistance WHERE f_name = '" & userfullname & "'"
        cmd = New OleDbCommand(selectString, cn)
        reader = cmd.ExecuteReader()
        reader.Read()
        LongPlate.Text = reader("car_n0")
        LongFare.Text = reader("price")
        ComboBox1.Text = reader("will_go")
        LongAvail.Checked = reader("status")
        cn.Close()
        original = LongFull.Text
    End Sub
    ' Fucntion to read data from user table and load into form by searching using the username , and Driver Name in Erickshaw driver for ERickshaw Driver
    Public Sub ErickshawLoad()
        Dim userfullname As String
        Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
        Dim cn As OleDbConnection = New OleDbConnection(connectString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Users WHERE User = '" & username & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        reader.Read()
        EUser.Text = reader("User")
        EPass.Text = reader("Password")
        EPass.PasswordChar = "*"
        EPhone.Text = reader("PhoneNumber")
        EFull.Text = reader("FullName")
        userfullname = reader("FullName")
        cn.Close()
        cn.Open()
        selectString = "SELECT * FROM Drivers_Erickshaw WHERE Driver_Name = '" & userfullname & "'"
        cmd = New OleDbCommand(selectString, cn)
        reader = cmd.ExecuteReader()
        reader.Read()
        ELocation.Text = reader("Location")
        EAvail.Checked = reader("Availability")
        cn.Close()
        original = EFull.Text
    End Sub
    ' Saves the changes into the Users table 
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles picbtnCustomer.Click
        If CustPhone.TextLength <> 10 Or Not (Regex.IsMatch(CustPhone.Text, "^[0-9]+$")) Then
            MsgBox("Enter Valid Number")
        ElseIf CustUser.TextLength = 0 Or Not (Regex.IsMatch(CustUser.Text, "^[a-zA-Z0-9_]*$")) Then
            MsgBox("Username Field is empty")
        ElseIf CustPass.TextLength = 0 Then
            MsgBox("Password Field is empty")
        ElseIf Custfull.TextLength = 0 Then
            MsgBox("FullName Field is empty")
        Else
            Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectString)
            cn.Open()
            Dim selectString As String = "UPDATE Users SET [User]=@usr,[Password]=@pass,PhoneNumber=@num,FullName=@full WHERE User = '" & username & "'"

            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            cmd.Parameters.AddWithValue("@usr", CustUser.Text)
            cmd.Parameters.AddWithValue("@pass", CustPass.Text)
            cmd.Parameters.AddWithValue("@num", CustPhone.Text)
            cmd.Parameters.AddWithValue("@full", Custfull.Text)
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("UserName alrady Exists , Please use another UserName.")
                Exit Sub
            Finally
                cn.Close()
            End Try
            MsgBox("Details Updated")
        End If
        Home.UserName = CustUser.Text
    End Sub
    ' Saves the changes into the Users table and Driver_shortDist
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles picbtnShort.Click

        If ShortPhone.TextLength <> 10 Or Not (Regex.IsMatch(ShortPhone.Text, "^[0-9]+$")) Then
            MsgBox("Enter Valid Number")
        ElseIf ShortUser.TextLength = 0 Then
            MsgBox("Username Field is empty")
        ElseIf ShortPass.TextLength = 0 Then
            MsgBox("Password Field is empty")
        ElseIf ShortFull.TextLength = 0 Then
            MsgBox("FullName Field is empty")
        Else
            Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectString)
            cn.Open()
            Dim selectString As String = "UPDATE Users SET [User]=@usr,[Password]=@pass,PhoneNumber=@num,FullName=@full WHERE User = '" & username & "'"

            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            cmd.Parameters.AddWithValue("@usr", ShortUser.Text)
            cmd.Parameters.AddWithValue("@pass", ShortPass.Text)
            cmd.Parameters.AddWithValue("@num", ShortPhone.Text)
            cmd.Parameters.AddWithValue("@full", ShortFull.Text)
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("UserName alrady Exists , Please use another UserName.")
                Exit Sub
            Finally
            End Try

            selectString = "UPDATE Drivers_shortDist SET FirstName=@full,PhoneNumber=@number,CarModel=@car,NumberPlate=@num,Fare=@fare,Location=@loc,Available=@avail WHERE FirstName = '" & original & "'"
            MsgBox(original)
            Dim cmd2 As OleDbCommand = New OleDbCommand(selectString, cn)
            cmd2.Parameters.AddWithValue("@full", ShortFull.Text)
            cmd2.Parameters.AddWithValue("@number", ShortPhone.Text)

            cmd2.Parameters.AddWithValue("@car", ShortCar.Text)
            cmd2.Parameters.AddWithValue("@num", ShortPlate.Text)
            cmd2.Parameters.AddWithValue("@fare", ShortFare.Text)
            cmd2.Parameters.AddWithValue("@loc", ShortLocation.Text)
            cmd2.Parameters.AddWithValue("@avail", ShortAvail.Checked)

            Try
                cmd2.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            Finally
                cn.Close()
            End Try
            MsgBox("Details Updated")
        End If
        Home.UserName = ShortUser.Text
    End Sub
    ' Saves the changes into the Users table and Driver_longDist

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles picbtnLong.Click
        If LongPhone.TextLength <> 10 Or Not (Regex.IsMatch(LongPhone.Text, "^[0-9]+$")) Then
            MsgBox("Enter Valid Number")
        ElseIf LongUser.TextLength = 0 Then
            MsgBox("Username Field is empty")
        ElseIf LongPass.TextLength = 0 Then
            MsgBox("Password Field is empty")
        ElseIf LongFull.TextLength = 0 Then
            MsgBox("FullName Field is empty")
        Else
            Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectString)
            cn.Open()
            Dim selectString As String = "UPDATE Users SET [User]=@usr,[Password]=@pass,PhoneNumber=@num,FullName=@full WHERE User = '" & username & "'"

            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            cmd.Parameters.AddWithValue("@usr", LongUser.Text)
            cmd.Parameters.AddWithValue("@pass", LongPass.Text)
            cmd.Parameters.AddWithValue("@num", LongPhone.Text)
            cmd.Parameters.AddWithValue("@full", LongFull.Text)
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("UserName alrady Exists , Please use another UserName.")
                Exit Sub
            Finally
            End Try

            selectString = "UPDATE Drivers_LongDistance SET f_name=@name,ph_no=@num,car_n0=@car,status=@avail,will_go=@loc,price=@fare WHERE f_name= '" & original & "'"

            Dim cmd2 As OleDbCommand = New OleDbCommand(selectString, cn)
            cmd2.Parameters.AddWithValue("@name", LongFull.Text)
            cmd2.Parameters.AddWithValue("@num", LongPhone.Text)
            cmd2.Parameters.AddWithValue("@car", LongPlate.Text)
            cmd2.Parameters.AddWithValue("@avail", LongAvail.Checked)
            cmd2.Parameters.AddWithValue("@loc", ComboBox1.Text)
            cmd2.Parameters.AddWithValue("@fare", LongFare.Text)

            Try
                cmd2.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            Finally
                cn.Close()
            End Try
            MsgBox("Details Updated")
        End If
        Home.UserName = LongUser.Text
    End Sub
    ' Saves the changes into the Users table and Erickshaw
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picbtnErick.Click
        If EPhone.TextLength <> 10 Or Not (Regex.IsMatch(EPhone.Text, "^[0-9]+$")) Then
            MsgBox("Enter Valid Number")
        ElseIf EUser.TextLength = 0 Then
            MsgBox("Username Field is empty")
        ElseIf EPass.TextLength = 0 Then
            MsgBox("Password Field is empty")
        ElseIf EFull.TextLength = 0 Then
            MsgBox("FullName Field is empty")
        Else
            Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectString)
            cn.Open()
            Dim selectString As String = "UPDATE Users SET [User]=@usr,[Password]=@pass,PhoneNumber=@num,FullName=@full WHERE User = '" & username & "'"

            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            cmd.Parameters.AddWithValue("@usr", EUser.Text)
            cmd.Parameters.AddWithValue("@pass", EPass.Text)
            cmd.Parameters.AddWithValue("@num", EPhone.Text)
            cmd.Parameters.AddWithValue("@full", EFull.Text)
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("UserName alrady Exists , Please use another UserName.")
                Exit Sub
            Finally
            End Try

            selectString = "UPDATE Drivers_Erickshaw SET Driver_Name=@name,Phone_No=@num,Availability=@avail,Location=@loc WHERE Driver_Name= '" & original & "'"

            Dim cmd2 As OleDbCommand = New OleDbCommand(selectString, cn)
            cmd2.Parameters.AddWithValue("@name", EFull.Text)
            cmd2.Parameters.AddWithValue("@num", EPhone.Text)
            cmd2.Parameters.AddWithValue("@avail", EAvail.Checked)
            cmd2.Parameters.AddWithValue("@loc", ELocation.Text)
            Try
                cmd2.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            Finally
                cn.Close()
            End Try
            MsgBox("Details Updated")
        End If
        Home.UserName = EUser.Text
    End Sub

    ' Displays the bookings table for the current user
    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click, PictureBox3.Click, PictureBox4.Click
        BookingsDisplay.Show()
    End Sub

End Class