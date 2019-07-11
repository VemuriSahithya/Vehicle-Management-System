Imports System.Data.OleDb

Public Class ShortHome
    ' Form for Finding short distance cabs 
    ' Public and global variables 
    Public Property SourceLocation As String
    Public Property DestinationLocation As String
    Dim counter As Integer = 1
    Dim x As Integer
    Dim choice As Integer = -1
    Dim curdis As Decimal
    Dim Driverlist(100) As String

    'Reseting the displays and deleting dynamically allocated controls
    Private Sub Clr()
        txtOutput1.Clear()
        btnFindCabs.Hide()
        rad1.Hide()
        txtOutput1.Hide()
        btnConfirm.Hide()
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

    ' Main Function to Find Cabs 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFindCabs.Click
        curdis = Home.DistanceCalc(txtboxFrom.Text, txtboxTo.Text)
        Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
        Dim cn As OleDbConnection = New OleDbConnection(connectString)
        cn.Open()
        ' Takes in location of the Pick up and then searches the database for cabs near that location and Prints them Dynamically in increasing order of price
        Dim selectString As String = "SELECT * FROM Drivers_shortDist WHERE Location = '" & txtboxFrom.Text & "' AND Available=TRUE ORDER BY Fare"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        Dim boolflag As Boolean = False
        While reader.Read
            boolflag = True

            Dim tmp As String = "Name: " & reader("FirstName") & Environment.NewLine
            tmp = tmp & "Curent Location = " & reader("Location") & Environment.NewLine
            tmp = tmp & "Estimated Fare = " & curdis * reader("Fare")
            Driverlist(counter) = reader("FirstName")
            If counter = 1 Then
                txtOutput1.Text = tmp
            Else
                outTextAdder(counter, tmp)
            End If
            counter = counter + 1
        End While

        If boolflag = False Then
            MsgBox("Sorry No Cabs available")

        Else
            Me.Size = New Size(696, 50 + Me.Size.Height)
            btnConfirm.Show()
            btnFindCabs.Hide()
            txtOutput1.Show()
            rad1.Show()
        End If

        cn.Close()
    End Sub
    'Prints the Source and Destination after Closing the map
    Public Sub printSourceAndDest()
        If SourceLocation.Length > 0 And DestinationLocation.Length > 0 Then
            txtboxFrom.Text = SourceLocation
            txtboxTo.Text = DestinationLocation
            btnFindCabs.Show()
        End If

    End Sub

    Private Sub ShortHome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Home.Reset()
        Home.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GUI purposes
        x = txtOutput1.Location.X
        btnFindCabs.Hide()
        txtOutput1.ReadOnly = True
        txtOutput1.Hide()
        btnConfirm.Hide()
        rad1.Hide()

        btnMap.Parent = PictureBox1
        picArrow.Parent = PictureBox1
        btnBack.Parent = PictureBox1
        rad1.Parent = PictureBox1
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
        Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
        Dim cn As OleDbConnection = New OleDbConnection(connectString)
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


            textfare = "Estimated Fare = " & curdis * reader("Fare") & Environment.NewLine


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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
