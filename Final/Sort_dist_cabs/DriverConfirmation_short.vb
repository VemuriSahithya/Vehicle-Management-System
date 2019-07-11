Imports Sort_dist_cabs.ShortDist_driversDataSetTableAdapters
Imports System.Data.OleDb
Imports System.Text.RegularExpressions


' Form is Used to confirm the details of the user , so that the user can book a cab for somones else too . 
' Then if the data is valid adds a column in the bookings table , signifying that the booking is done and makes the driver unavailable 


Public Class DriverConfirmation_short

    'Global properties it recieves from the calling form (Reccohome or ShortHome)
    Public Property fare As String
    Public Property driverName As String
    Public Property otherDetils As String
    Public Property locationTo As String
    Public Property locationFrom As String

    'Global Connection string
    Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
    Dim cn As OleDbConnection = New OleDbConnection(connectString)

    'Button to Close the form 
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
        Home.Reset()
        Home.Show()
    End Sub

    ' First Checks if the user is logged in as a Customer , if not then closes the form and opens the login page.
    ' if Loaded then Prints the data it recieves from the previous form and also searches the users table for the current user to print their details 
    Private Sub DriverConfirmation_short_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFarePrint.Text = fare
        lblDriName.Text = driverName
        lbldetails.Text = otherDetils
        If Home.loggedin = False Then
            MsgBox("Please Log in to Book a Cab!")
            Login.Show()
            Me.Close()
            Exit Sub
        End If
        If Home.UserType <> "Customer" Then
            MsgBox("Please Log in to Book a Cab!")
            Login.Show()
            Me.Close()
            Exit Sub
        End If
        cn.Open()
        Dim selectString As String = "SELECT * FROM Users WHERE User = '" & Home.UserName & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        reader.Read()
        txtUsername.Text = reader("FullName")
        txtPhno.Text = reader("PhoneNumber")
        cn.Close()
        'declaring parents
        lblFare.Parent = PictureBox1
        lbldetails.Parent = PictureBox1
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        lblDriName.Parent = PictureBox1
        lblFarePrint.Parent = PictureBox1
        btnback.Parent = PictureBox1
    End Sub

    ' Main Function to check the details , then if the data is valid adds a column in the bookings table , signifying that the booking is done and makes the driver unavailable 
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If txtUsername.Text = "" Or txtPhno.Text.Length <> 10 Or Not (Regex.IsMatch(txtPhno.Text, "^[0-9]+$")) Then
            MsgBox("Enter Valid details")
        Else
            cn.Open()
            'Adding a column into Bookings using the driver and user details and current date and time
            Dim selectString As String = "INSERT INTO Bookings ([Date_time],[Driver],[Short/Long_Dist],[Source],[Destination],[User],[FullName],[UserPhNo]) VALUES (@date,@driver,@short,@src,@des,@usr,@full,@num);"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            cmd.CreateParameter()
            Dim date_time As OleDbParameter = cmd.CreateParameter()
            cmd.Parameters.AddWithValue("@date", CStr(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")))
            cmd.Parameters.AddWithValue("@driver", lblDriName.Text)
            cmd.Parameters.AddWithValue("@short", "Short")
            cmd.Parameters.AddWithValue("@src", locationFrom)
            cmd.Parameters.AddWithValue("@dsc", locationTo)
            cmd.Parameters.AddWithValue("@usr", Home.UserName)
            cmd.Parameters.AddWithValue("@full", txtUsername.Text)
            cmd.Parameters.AddWithValue("@num", txtPhno.Text)

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                txtPhno.Clear()
                txtUsername.Clear()
                ' Changing availibilty of driver 
                Dim selectString2 As String = "UPDATE Drivers_shortDist SET Available=@avail WHERE FirstName = '" & lblDriName.Text & "'"
                MsgBox("Booking Done!")
                ReccoHome.Close()
                ShortHome.Close()
                Dim cmd2 As OleDbCommand = New OleDbCommand(selectString2, cn)
                cmd2.Parameters.AddWithValue("@avail", False)
                Try
                    cmd2.ExecuteNonQuery()
                Catch ex2 As Exception
                    MsgBox(ex2.Message)
                End Try
                Me.Close()

            Catch ex As Exception
                cn.Close()
                MsgBox(ex.Message)
            End Try
            cn.Close()
        End If

    End Sub
    'Buttons to  clear the name and phone number 
    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        txtUsername.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtPhno.Clear()
    End Sub
End Class