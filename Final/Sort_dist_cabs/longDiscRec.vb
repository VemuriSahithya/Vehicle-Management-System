Imports System.Data.OleDb
Imports Sort_dist_cabs.ShortDist_driversDataSetTableAdapters


Public Class longDiscRec
    ' Form for Confirming the Driver Chosen by the user and also finding the number of days for which the user wants the Driver
    ' After getting the details books the driver by adding a Column in the Bookings table and changing availibility
    Public Property drivername As String
    Dim radNum As Integer
    Dim des As String
    Dim price As String
    Dim FullName As String
    Dim PhoneNumber As String
    Dim days As String
    Dim dict As New Dictionary(Of String, Integer)

    Private Sub longDiscRec_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Home.loggedin = False Then
            MsgBox("Please Log in to Book a Cab")
            Login.Show()
            Me.Close()
        End If

        If Home.UserType <> "Customer" Then
            MsgBox("Please Log in to Book a Cab")
            Login.Show()
            Me.Close()
        End If
        'setting parent for UI beautification
        Label1.Parent = PictureBox1
        Button1.Parent = PictureBox1
        Button2.Parent = PictureBox1
        Button3.Parent = PictureBox1
        rad1.Parent = PictureBox1
        ''''''''''''''''''
        Label3.Hide()
        dict.Add("shillong", 3)
        dict.Add("shivsagar", 2)
        dict.Add("kaziranga", 5)
        dict.Add("sikkim", 8)
        dict.Add("dzukou", 4)
        ' Dim radNum As Integer
        Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
        Dim cn As OleDbConnection = New OleDbConnection(connectString)
        cn.Open()
        'The code below extracts info of the first instance of FirstName in the tabl Drivers_shortDist,
        ' therefore Drivers with Identical names will create wrong output.
        'So right now, the database consists of drivers with different FirstName field
        Dim selectString As String = "Select * from Drivers_LongDistance where f_name like '" & drivername & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim textName As String = ""
        Dim textfare As String = ""
        Dim textDetails As String = ""
        While reader.Read

            If dict.ContainsKey(reader("will_go")) Then
                radNum = dict.Item(reader("will_go"))
                des = reader("will_go")
            End If
            price = reader("price")
            For i As Integer = 2 To radNum
                Dim radName As String
                radName = "rad" & CStr(i)
                Dim rad As New RadioButton
                Dim y As Integer = rad1.Location.Y + (i - 1) * rad1.Height
                Me.Controls.Add(rad)
                rad.Name = radName
                rad.Location = New Point(rad1.Left, y)
                rad.Visible = True
                rad.Font = rad1.Font
                rad.Text = (i) & " days "
                rad.Checked = False
                rad.BringToFront()
                rad.Parent = PictureBox1
                rad.BackColor = Color.Transparent
            Next
        End While
        cn.Close()

    End Sub
    ' Function to calculate the total cost
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tmp As Integer = -1
        Label1.Hide()
        If rad1.Checked = True Then
            tmp = 1
        Else
            For i As Integer = 2 To radNum
                Dim rad As RadioButton = (Me.Controls.Find("rad" & CStr(i), True)(0))
                If rad.Checked = True Then
                    tmp = i
                End If
            Next
        End If
        rad1.Hide()
        For cnt As Integer = 2 To radNum
            Me.Controls.Remove(Me.Controls.Find("rad" & CStr(cnt), True)(0))
            Me.Controls.Find("rad" & CStr(cnt), True)(0).Hide()
        Next

        Label3.Show()
        Label3.BackColor = Color.Transparent
        Label3.Parent = PictureBox1
        days = tmp
        Label3.Text = "Driver will charge " & Environment.NewLine & "₹" & tmp * CInt(price) & " for " & tmp & " days "
        Button1.Hide()
        Button3.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
    ' Main Function to check the details , then if the data is valid adds a column in the bookings table , signifying that the booking is done and makes the driver unavailable 
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
        Dim cn As OleDbConnection = New OleDbConnection(connectString)
        cn.Open()
        'Adding a column into Bookings using the driver and user details and current date and time

        Dim selectString As String = "SELECT * FROM Users WHERE User = '" & Home.UserName & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        reader.Read()
        FullName = reader("FullName")
        PhoneNumber = reader("PhoneNumber")
        cn.Close()

        cn.Open()
        selectString = "INSERT INTO Bookings ([Date_time],[Driver],[Short/Long_Dist],[Source],[Destination],[User],[FullName],[UserPhNo],[Days]) VALUES (@date,@driver,@short,@src,@des,@usr,@full,@num,@days);"
        cmd = New OleDbCommand(selectString, cn)

        cmd.CreateParameter()
        Dim date_time As OleDbParameter = cmd.CreateParameter()
        cmd.Parameters.AddWithValue("@date", CStr(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")))
        cmd.Parameters.AddWithValue("@driver", drivername)
        cmd.Parameters.AddWithValue("@short", "Long")
        cmd.Parameters.AddWithValue("@src", "IIT Guwahati")
        cmd.Parameters.AddWithValue("@dec", des)
        cmd.Parameters.AddWithValue("@usr", Home.UserName)
        cmd.Parameters.AddWithValue("@full", FullName)
        cmd.Parameters.AddWithValue("@num", PhoneNumber)
        cmd.Parameters.AddWithValue("@days", days)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            ' Changing availibilty of driver 

            Dim selectString2 As String = "UPDATE Drivers_LongDistance SET status=@avail WHERE f_name = '" & drivername & "'"
            MsgBox("Booking Done!")
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
    End Sub
End Class