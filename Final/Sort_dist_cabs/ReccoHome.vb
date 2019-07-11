Imports System.Data.OleDb

Public Class ReccoHome
    ' Form for the recommending the optimal route fro source to destination.
    ' Public and global variables 
    Public Property SourceLocation As String
    Public Property DestinationLocation As String
    Dim counter As Integer = 1
    Dim x As Integer
    Dim choice As Integer = -1
    Dim curdis As Decimal
    Dim Driverlist(100) As String
    Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
    Dim cn As OleDbConnection = New OleDbConnection(connectString)
    Dim busstops() As String = {"PALTAN BAZAR", "KAMAKHYA", "JALUKBARI", "IIT GUWAHATI"}
    Dim convert As New Dictionary(Of String, String)
    Dim farelist(100) As Decimal

    'Reseting the displays and deleting dynamically allocated controls
    Private Sub Clr()
        txtOutput1.Clear()
        'deleting dynamically allocated controls
        btnFindCabs.Hide()
        rad1.Hide()
        txtOutput1.Hide()
        btnConfirm.Hide()
        txtboxFrom.Clear()
        txtboxTo.Clear()
        For i As Integer = 2 To counter - 1
            Me.Controls.Remove(Me.Controls.Find("txtOutput" & CStr(i), True)(0))
            Me.Controls.Remove(Me.Controls.Find("rad" & CStr(i), True)(0))
        Next
        counter = 1
        choice = -1
        rad1.Checked = False
    End Sub

    'Function to dynamically allocate new richtextboxes'
    Private Sub outTextAdder(i As Integer, tmp As String)
        Dim txtName As String
        Dim radName As String
        radName = "rad" & CStr(i)
        txtName = "txtOutput" & CStr(i)
        Dim yt As Integer = txtOutput1.Location.Y + txtOutput1.Height * (i - 1)
        Dim yr As Integer = yt + txtOutput1.Height / 2
        Dim xr As Integer = x + txtOutput1.Width + 20
        Dim txt1 As New RichTextBox
        txt1.Name = txtName
        txt1.Width = txtOutput1.Width
        txt1.Height = txtOutput1.Height
        txt1.ReadOnly = True
        Me.Controls.Add(txt1)
        txt1.BringToFront()
        txt1.Font = txtOutput1.Font
        txt1.Location = New Point(x, yt)
        txt1.Text = tmp
        txt1.BackColor = Color.AliceBlue
        txt1.ForeColor = Color.DimGray
        Dim rad As New RadioButton
        Me.Controls.Add(rad)
        rad.BackColor = Color.Transparent
        rad.Parent = PictureBox1
        rad.Name = radName
        rad.Location = New Point(xr, yr)
        rad.BringToFront()
    End Sub


    ' Button to open the map
    Private Sub btnMap_Click(sender As Object, e As EventArgs) Handles btnMap.Click
        Clr()
        map.Show()


    End Sub
    'Driver Function to Find the optimal route . The algo has been discussed in the Technical Documentation.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFindCabs.Click

        curdis = Home.DistanceCalc(txtboxFrom.Text, txtboxTo.Text)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Drivers_shortDist WHERE Location = '" & txtboxFrom.Text & "' AND Available=TRUE ORDER BY Fare"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim boolflag As Boolean = False

        ' Checks if the from location is o a bus route 
        Dim totaldistance As Decimal = Home.DistanceCalc(txtboxFrom.Text, txtboxTo.Text)
        If busstops.Contains(txtboxFrom.Text) Then
            Dim tempdis As Decimal
            Dim mintemp As Decimal = 100
            Dim j As Integer = 0
            Dim index As Integer = -1
            While j < 4
                ' then finds the stops with the minimum distance from the destination which has a available cab
                tempdis = Home.DistanceCalc(busstops(j), txtboxTo.Text)
                If tempdis < (mintemp) And tempdis < (totaldistance) Then
                    Dim selectStringbus As String = "SELECT * FROM BusTimings WHERE Pick_up_points LIKE '%" & convert.Item(txtboxFrom.Text) & "%' AND Pick_up_points LIKE  '%" & convert.Item(busstops(j)) & "%' ORDER BY Bus_Time "
                    Dim cmd2 As OleDbCommand = New OleDbCommand(selectStringbus, cn)
                    Dim readerbus As OleDbDataReader = cmd2.ExecuteReader()

                    While readerbus.Read

                        Dim myTime = DateTime.Parse(readerbus("Bus_Time"))
                        Dim result = myTime.TimeOfDay - TimeOfDay.TimeOfDay
                        If (result.Hours >= 0 And result.Hours < 1) Then

                            If (result.Minutes > 0) And readerbus("Pick_up_points").ToString.IndexOf(convert.Item(txtboxFrom.Text)) < readerbus("Pick_up_points").ToString.IndexOf(convert.Item(busstops(j))) Then
                                If tempdis > 0 Then

                                    Dim selectStringlocation As String = "SELECT * FROM Drivers_shortDist WHERE Location = '" & busstops(j) & "' AND Available=TRUE ORDER BY Fare"
                                    Dim cmdlocation As OleDbCommand = New OleDbCommand(selectStringlocation, cn)
                                    Dim readerlocation As OleDbDataReader = cmdlocation.ExecuteReader()
                                    If readerlocation.Read Then
                                        mintemp = tempdis
                                        index = j
                                        Exit While
                                    End If
                                Else
                                    mintemp = tempdis
                                    index = j
                                End If
                            End If
                        End If
                    End While
                End If
                j = j + 1
            End While
            ' Now we know which is the stop we will be using then its simply printing all the buses and cabs available from those parameters 
            If index > -1 Then
                Dim selectStringbus As String = "SELECT * FROM BusTimings WHERE Pick_up_points LIKE '%" & convert.Item(txtboxFrom.Text) & "%' AND Pick_up_points LIKE  '%" & convert.Item(busstops(index)) & "%' ORDER BY Bus_Time "
                Dim cmd2 As OleDbCommand = New OleDbCommand(selectStringbus, cn)
                Dim readerbus As OleDbDataReader = cmd2.ExecuteReader()

                While readerbus.Read
                    Dim myTime = DateTime.Parse(readerbus("Bus_Time"))
                    Dim result = myTime.TimeOfDay - TimeOfDay.TimeOfDay
                    If (result.Hours >= 0 And result.Hours < 1) Then

                        If (result.Minutes > 0) And readerbus("Pick_up_points").ToString.IndexOf(convert.Item(txtboxFrom.Text)) < readerbus("Pick_up_points").ToString.IndexOf(convert.Item(busstops(index))) Then

                            If mintemp = 0 Then
                                ' If both source and destination lie on bus route
                                Dim tmp As String = "You can take a Direct Bus :" & Environment.NewLine
                                tmp = tmp & "Bus No: " & readerbus("Bus_no") & " Time: " & readerbus("Bus_Time") & Environment.NewLine
                                tmp = tmp & "Bus Starting Location = " & readerbus("Starting_Point") & Environment.NewLine
                                tmp = tmp & "Pick up  = " & txtboxFrom.Text & "   Drop off  = " & txtboxTo.Text
                                Driverlist(counter) = "Bus"
                                farelist(counter) = 0
                                If counter = 1 Then
                                    txtOutput1.Text = tmp
                                Else
                                    outTextAdder(counter, tmp)
                                End If
                                counter = counter + 1
                                boolflag = True
                            Else
                                'If destinaion is not on bus route
                                If mintemp > 0 Then

                                    Dim selectStringlocation As String = "SELECT * FROM Drivers_shortDist WHERE Location = '" & busstops(index) & "' AND Available=TRUE ORDER BY Fare"
                                    Dim cmdlocation As OleDbCommand = New OleDbCommand(selectStringlocation, cn)
                                    Dim readerlocation As OleDbDataReader = cmdlocation.ExecuteReader()

                                    While readerlocation.Read

                                        Dim dis As Decimal = Home.DistanceCalc(busstops(index), txtboxTo.Text)
                                        Dim tmp As String = "First take the following Bus :" & Environment.NewLine
                                        tmp = tmp & "Bus No: " & readerbus("Bus_no") & " Time: " & readerbus("Bus_Time") & Environment.NewLine
                                        tmp = tmp & "Bus Starting Location = " & readerbus("Starting_Point") & Environment.NewLine
                                        tmp = tmp & "Pick up  = " & txtboxFrom.Text & "   Drop off  = " & busstops(index) & Environment.NewLine & Environment.NewLine
                                        tmp = tmp & "Then Take the following Cab :" & Environment.NewLine
                                        tmp = tmp & "Name: " & readerlocation("FirstName") & Environment.NewLine
                                        tmp = tmp & "Pick up  = " & busstops(index) & "   Drop off  = " & txtboxTo.Text & Environment.NewLine
                                        tmp = tmp & "Estimated Fare = " & dis * readerlocation("Fare")
                                        Driverlist(counter) = readerlocation("FirstName")
                                        farelist(counter) = dis * readerlocation("Fare")
                                        If counter = 1 Then
                                            txtOutput1.Text = tmp
                                        Else
                                            outTextAdder(counter, tmp)
                                        End If
                                        counter = counter + 1
                                        boolflag = True
                                    End While

                                End If

                            End If

                        End If

                    End If

                End While

            End If
            ' Checks if Destination is on bus route 
        ElseIf busstops.Contains(txtboxTo.Text) Then
            Dim tempdis As Decimal
            Dim mintemp As Decimal = 100
            Dim j As Integer = 0
            Dim index As Integer = -1
            While j < 4
                ' then finds the stops with the minimum distance from the source which has a bus

                tempdis = Home.DistanceCalc(txtboxFrom.Text, busstops(j))
                If tempdis < (mintemp) And tempdis < (totaldistance) Then
                    Dim selectStringbus As String = "SELECT * FROM BusTimings WHERE Pick_up_points LIKE '%" & convert.Item(txtboxTo.Text) & "%' AND Pick_up_points LIKE  '%" & convert.Item(busstops(j)) & "%' ORDER BY Bus_Time "
                    Dim cmd2 As OleDbCommand = New OleDbCommand(selectStringbus, cn)
                    Dim readerbus As OleDbDataReader = cmd2.ExecuteReader()

                    While readerbus.Read

                        Dim myTime = DateTime.Parse(readerbus("Bus_Time"))
                        Dim result = myTime.TimeOfDay - TimeOfDay.TimeOfDay
                        If (result.Hours >= 0 And result.Hours < 1) Then
                            If (result.Minutes > 15) And readerbus("Pick_up_points").ToString.IndexOf(convert.Item(busstops(j))) < readerbus("Pick_up_points").ToString.IndexOf(convert.Item(txtboxTo.Text)) Then

                                Dim selectStringlocation As String = "SELECT * FROM Drivers_shortDist WHERE Location = '" & txtboxFrom.Text & "' AND Available=TRUE ORDER BY Fare"
                                Dim cmdlocation As OleDbCommand = New OleDbCommand(selectStringlocation, cn)
                                Dim readerlocation As OleDbDataReader = cmdlocation.ExecuteReader()
                                If readerlocation.Read Then
                                    mintemp = tempdis
                                    index = j
                                    Exit While
                                End If
                            End If
                        End If
                    End While
                End If
                j = j + 1

            End While
            ' Now we know which is the stop we will be using then its simply printing all the buses and cabs available from those parameters 

            If index > -1 Then
                Dim selectStringbus As String = "SELECT * FROM BusTimings WHERE Pick_up_points LIKE '%" & convert.Item(txtboxTo.Text) & "%' AND Pick_up_points LIKE  '%" & convert.Item(busstops(index)) & "%' ORDER BY Bus_Time "
                Dim cmd2 As OleDbCommand = New OleDbCommand(selectStringbus, cn)
                Dim readerbus As OleDbDataReader = cmd2.ExecuteReader()

                While readerbus.Read
                    Dim myTime = DateTime.Parse(readerbus("Bus_Time"))
                    Dim result = myTime.TimeOfDay - TimeOfDay.TimeOfDay
                    If (result.Hours >= 0 And result.Hours < 1) Then

                        If (result.Minutes > 15) And readerbus("Pick_up_points").ToString.IndexOf(convert.Item(busstops(index))) < readerbus("Pick_up_points").ToString.IndexOf(convert.Item(txtboxTo.Text)) Then

                            Dim selectStringlocation As String = "SELECT * FROM Drivers_shortDist WHERE Location = '" & txtboxFrom.Text & "' AND Available=TRUE ORDER BY Fare"
                            Dim cmdlocation As OleDbCommand = New OleDbCommand(selectStringlocation, cn)
                            Dim readerlocation As OleDbDataReader = cmdlocation.ExecuteReader()

                            While readerlocation.Read

                                Dim dis As Decimal = Home.DistanceCalc(txtboxFrom.Text, busstops(index))
                                Dim tmp As String = "First Take the following Cab :" & Environment.NewLine
                                tmp = tmp & "Name: " & readerlocation("FirstName") & Environment.NewLine
                                tmp = tmp & "Pick up  = " & txtboxFrom.Text & "   Drop off  = " & busstops(index) & Environment.NewLine
                                tmp = tmp & "Estimated Fare = " & dis * readerlocation("Fare") & Environment.NewLine & Environment.NewLine
                                tmp = tmp & "Then take the following Bus :" & Environment.NewLine
                                tmp = tmp & "Bus No: " & readerbus("Bus_no") & " Time: " & readerbus("Bus_Time") & Environment.NewLine
                                tmp = tmp & "Bus Starting Location = " & readerbus("Starting_Point") & Environment.NewLine
                                tmp = tmp & "Pick up  = " & busstops(index) & "   Drop off  = " & txtboxTo.Text

                                Driverlist(counter) = readerlocation("FirstName")
                                farelist(counter) = dis * readerlocation("Fare")
                                If counter = 1 Then
                                    txtOutput1.Text = tmp
                                Else
                                    outTextAdder(counter, tmp)
                                End If
                                counter = counter + 1
                                boolflag = True

                            End While

                        End If

                    End If

                End While

            End If
        End If

        ' Takes in location of the Pick up and then searches the database for cabs near that location and Prints them Dynamically in increasing order of price

        While reader.Read
            Dim tmp As String = "Name: " & reader("FirstName") & Environment.NewLine
            tmp = tmp & "Curent Location = " & reader("Location") & Environment.NewLine
            tmp = tmp & "Estimated Fare = " & curdis * reader("Fare")
            Driverlist(counter) = reader("FirstName")
            farelist(counter) = curdis * reader("Fare")
            If counter = 1 Then
                txtOutput1.Text = tmp
            Else
                outTextAdder(counter, tmp)
            End If
            counter = counter + 1
            boolflag = True
        End While
        Me.Size = New Size(696, 50 + Me.Size.Height)
        cn.Close()
        For i As Integer = 1 To counter - 1
            Dim rad As RadioButton = (Me.Controls.Find("rad" & CStr(i), True)(0))
            If Driverlist(i) = "Bus" Then
                rad.Enabled = False
            Else
                rad.Enabled = True
            End If
        Next
        If boolflag = False Then
            MsgBox("Sorry No Reccomended routes Due to Lack of Cabs or Buses")
        Else
            btnConfirm.Show()
            btnFindCabs.Hide()
            txtOutput1.Show()
            rad1.Show()
        End If
    End Sub
    'Prints the Source and Destination after Closing the map

    Public Sub printSourceAndDest()
        If SourceLocation.Length > 0 And DestinationLocation.Length > 0 Then
            txtboxFrom.Text = SourceLocation
            txtboxTo.Text = DestinationLocation
            btnFindCabs.Show()
        End If
    End Sub

    Private Sub ReccoHome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Home.Reset()
        Home.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GUI purposes
        x = txtOutput1.Location.X
        btnFindCabs.Hide()
        txtOutput1.Hide()
        txtOutput1.ReadOnly = True
        btnConfirm.Hide()
        rad1.Hide()

        'assigning parents for UI purposes
        btnMap.Parent = PictureBox1
        picArrow.Parent = PictureBox1
        rad1.Parent = PictureBox1
        btnBack.Parent = PictureBox1
        'Utility dictionary
        convert.Add("PALTAN BAZAR", "PBWT")
        convert.Add("KAMAKHYA", "KM")
        convert.Add("JALUKBARI", "JB")
        convert.Add("IIT GUWAHATI", "Admn")
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnConfirm.Click

        For i As Integer = 1 To counter - 1
            Dim rad As RadioButton = (Me.Controls.Find("rad" & CStr(i), True)(0))
            If rad.Checked = True Then
                choice = i
            End If
        Next
        If choice = -1 Then
            MsgBox("Please Select a Cab")
            Exit Sub
        End If
        Dim DriverName As String = Driverlist(choice)
        Dim fare As String = farelist(choice)
        cn.Open()
        'The code below extracts info of the first instance of FirstName in the tabl Drivers_shortDist,
        ' therefore Drivers with Identical names will create wrong output.
        'So right now, the database consists of drivers with different FirstName field
        Dim selectString As String = "SELECT * FROM Drivers_shortDist WHERE FirstName = '" & DriverName & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim textName As String = ""
        Dim textfare As String = ""
        Dim textDetails As String = ""
        While reader.Read
            textName = "Driver: " & reader("FirstName") & Environment.NewLine


            textfare = "₹" & fare & Environment.NewLine


            textDetails = "Current Location = " & reader("Location") & Environment.NewLine
            textDetails = textDetails & "Your Ride = " & reader("CarModel") & " " & reader("NumberPlate") & Environment.NewLine
            textDetails = textDetails & "Driver is currently in " & reader("Location").ToString.ToUpper & Environment.NewLine
        End While
        Dim cForm As New DriverConfirmation_short
        cForm.fare = textfare
        cForm.driverName = DriverName
        cForm.otherDetils = textDetails
        cForm.locationTo = txtboxTo.Text
        cForm.locationFrom = txtboxFrom.Text
        cForm.Show()
        cn.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub


End Class
