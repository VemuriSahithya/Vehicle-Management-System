Public Class Home
    'Base Form For Entire Software, Stays active at all times
    'Has buttons to access all direct forms 
    ' Stores the user details of current user 
    ' Also has function to calculate distance between two points for short distance and recco Home 

    Public Property loggedin As Boolean
    Public Property UserName As String = ""
    Public Property UserType As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles picShortCab.Click, btnShort.Click

        Me.Reset()
        ShortHome.Show()
    End Sub

    Private Sub LongDistance_Click(sender As Object, e As EventArgs) Handles picLongcab.Click, btnLong.Click

        Me.Reset()
        LongDistanceHome.Show()
    End Sub

    Private Sub Erickshaw_Click(sender As Object, e As EventArgs) Handles picErick.Click, btnerick.Click

        Me.Reset()
        ErickshawHome.Show()
    End Sub

    Private Sub Bus_Click(sender As Object, e As EventArgs) Handles picBus.Click, btnBus.Click

        Me.Reset()
        BusHome.Show()
    End Sub

    Private Sub Reccobtn_Click(sender As Object, e As EventArgs) Handles Reccobtn.Click

        Me.Reset()
        ReccoHome.Show()
    End Sub

    Public Function DistanceCalc(source As String, destination As String)
        ' function to calculate distance between two points for short distance and recco Home 
        Dim distance(7, 8) As Decimal
        'key -
        '0 ->IITG
        '1->Paltan Baḍzar
        '2->Beltola
        '3->Kamakhya
        '4->Jalukbari
        '5->Airport
        '6->Ganeshguri
        '7->IGA Stadium
        distance(0, 0) = 0
        distance(0, 1) = 19.1
        distance(0, 2) = 28.3
        distance(1, 1) = 0
        distance(1, 2) = 8.3
        distance(2, 2) = 0
        distance(2, 1) = 8.3
        distance(2, 0) = 28.3
        distance(1, 0) = 19.1
        distance(0, 3) = 16.8
        distance(0, 4) = 16.8
        distance(0, 5) = 23.4
        distance(0, 6) = 23.1
        distance(0, 7) = 22.8
        distance(1, 3) = 9.5
        distance(1, 4) = 17.0
        distance(1, 5) = 23.5
        distance(1, 6) = 4.3
        distance(1, 7) = 11.6
        distance(2, 3) = 15.7
        distance(2, 4) = 25.0
        distance(2, 5) = 31.5
        distance(2, 6) = 5.0
        distance(2, 7) = 7.3
        distance(3, 3) = 0
        distance(3, 4) = 14.3
        distance(3, 5) = 20.8
        distance(3, 6) = 12.1
        distance(3, 7) = 20.6
        distance(4, 4) = 0
        distance(4, 5) = 11.6
        distance(4, 6) = 17.4
        distance(4, 7) = 18.5
        distance(5, 5) = 0
        distance(5, 6) = 26.7
        distance(5, 7) = 27.7
        distance(6, 6) = 0
        distance(6, 7) = 7.6
        distance(7, 7) = 0
        Dim dictionary As New Dictionary(Of String, Integer)
        dictionary.Add("IIT GUWAHATI", 0)
        dictionary.Add("PALTAN BAZAR", 1)
        dictionary.Add("BELTOLA", 2)
        dictionary.Add("KAMAKHYA", 3)
        dictionary.Add("JALUKBARI", 4)
        dictionary.Add("AIRPORT", 5)
        dictionary.Add("GANESHGURI", 6)
        dictionary.Add("IGA STADIUM", 7)
        Dim fromnumber As Integer = dictionary.Item(source)
        Dim tonumber As Integer = dictionary.Item(destination)
        ' first number is always smaller than second , ensures we only have to store upper half matrix
        If fromnumber < tonumber Then
            Return distance(fromnumber, tonumber)
        Else
            Return distance(tonumber, fromnumber)
        End If
    End Function

    Private Sub Home_Loead(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim myTime = DateTime.Parse("9:30:00 PM")

        'Dim result = TimeOfDay.TimeOfDay - myTime.TimeOfDay
        'MsgBox(result.ToString)
        'for UI purposes
        picLogin.Parent = PictureBox1
        picSignup.Parent = PictureBox1
        LoginBtn.Parent = PictureBox1
        SignupBtn.Parent = PictureBox1
        Reccobtn.Parent = PictureBox1
        PictureBox3.Parent = PictureBox1
        btnBus.Parent = PictureBox1
        btnShort.Parent = PictureBox1
        btnLong.Parent = PictureBox1
        btnerick.Parent = PictureBox1
        Usernamelabel.Parent = PictureBox1
        Profile.Parent = PictureBox1
        profilePic.Parent = PictureBox1
        picLogout.Parent = PictureBox1
        Logoutbtn.Parent = PictureBox1
        EmergencyBTn.Parent = PictureBox1
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click

        Me.Reset()
        Login.Show()
    End Sub
    Public Sub Reset()
        ' Checks if the User is now logged in , if yes then does the required changes
        If loggedin = True Then
            Usernamelabel.Text = "Welcome " & UserName & " !"
            picLogin.Hide()
            LoginBtn.Hide()
            picSignup.Hide()
            SignupBtn.Hide()
            Logoutbtn.Show()
            picLogout.Show()
            Profile.Show()
        End If
    End Sub

    Private Sub SignupBtn_Click(sender As Object, e As EventArgs) Handles SignupBtn.Click

        Me.Reset()
        Signup.Show()
    End Sub

    Private Sub picSignup_Click(sender As Object, e As EventArgs) Handles picSignup.Click
        Signup.Show()

        Me.Reset()
    End Sub

    Private Sub picLogin_Click(sender As Object, e As EventArgs) Handles picLogin.Click
        Login.Show()

        Me.Reset()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Reset()
        ReccoHome.Show()
    End Sub
    ' Logout Function
    Private Sub Logoutbtn_Click(sender As Object, e As EventArgs) Handles Logoutbtn.Click, picLogout.Click
        loggedin = False
        UserType = ""
        UserName = ""
        picLogin.Show()
        LoginBtn.Show()
        picSignup.Show()
        SignupBtn.Show()
        Logoutbtn.Hide()
        picLogout.Hide()
        Usernamelabel.Text = ""
        Profile.Hide()
    End Sub

    Private Sub UserDetails_Click(sender As Object, e As EventArgs) Handles Profile.Click, profilePic.Click
        Me.Reset()
        UserDetails.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Emergency_Click(sender As Object, e As EventArgs) Handles EmergencyBTn.Click
        Emergency.Show()
    End Sub
End Class