Imports System.Data.OleDb

Public Class e_rick_driver_reco
    Private Access As New DBControl ' Object for querying access database 
    Public Property Source As String
        'The dist array stores the distance between groups of locations (All 13 locations
    'have been distributed into 8 groups where nearby locations belong to the
    'same group) These distances have been obtained using google maps

    Private Sub e_rick_driver_reco_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dist(8, 8) As Decimal

        dist(1, 2) = 0.7
        dist(2, 1) = 0.7

        dist(1, 3) = 1.4
        dist(3, 1) = 1.4

        dist(1, 4) = 1.4
        dist(4, 1) = 1.4

        dist(1, 5) = 1.9
        dist(5, 1) = 1.9

        dist(1, 6) = 1.4
        dist(6, 1) = 1.4

        dist(1, 7) = 1.0
        dist(7, 1) = 1.0

        dist(1, 8) = 1.1
        dist(8, 1) = 1.1

        dist(2, 3) = 1.0
        dist(3, 2) = 1.0

        dist(2, 4) = 1.0
        dist(4, 2) = 1.0

        dist(2, 5) = 1.5
        dist(5, 2) = 1.5

        dist(2, 6) = 1.0
        dist(6, 2) = 1.0

        dist(2, 7) = 0.65
        dist(7, 2) = 0.65

        dist(2, 8) = 1.2
        dist(8, 2) = 1.2

        dist(3, 4) = 0.65
        dist(4, 3) = 0.65

        dist(3, 5) = 1.7
        dist(5, 3) = 1.7

        dist(3, 6) = 1.8
        dist(6, 3) = 1.8

        dist(3, 7) = 1.4
        dist(7, 3) = 1.4

        dist(3, 8) = 1.9
        dist(8, 3) = 1.9

        dist(4, 5) = 1.2
        dist(5, 4) = 1.2

        dist(4, 6) = 0.85
        dist(6, 4) = 0.85

        dist(4, 7) = 0.75
        dist(7, 4) = 0.75

        dist(4, 8) = 1.3
        dist(8, 4) = 1.3

        dist(5, 6) = 1.3
        dist(6, 5) = 1.3

        dist(5, 7) = 1.2
        dist(7, 5) = 1.2

        dist(5, 8) = 1.7
        dist(8, 5) = 1.7

        dist(6, 7) = 0.65
        dist(7, 6) = 0.65

        dist(6, 8) = 0.7
        dist(8, 6) = 0.7

        dist(7, 8) = 0.85
        dist(8, 7) = 0.85

        'Define the group no of each location by making a dictionary

        Dim group As New Dictionary(Of String, Integer)
        group.Add("Kameng", 1)
        group.Add("Barak", 1)
        group.Add("Umium", 1)
        group.Add("Dihing", 2)
        group.Add("Dibang", 2)
        group.Add("Brahma", 2)
        group.Add("Siang", 2)
        group.Add("Acad Complex", 3)
        group.Add("Library", 4)
        group.Add("Mkt Complex", 5)
        group.Add("Guest House", 6)
        group.Add("Subansiri", 7)
        group.Add("Dhansiri", 8)
        'Get available drivers' info from the database

        Access.ExecQuery("SELECT Driver_Name, Phone_No, Location, Photo FROM Drivers_Erickshaw WHERE Availability = True")

        'Add a new column - Distance, which stores the distance of each driver from the
        'user's current location
        Access.DBDT.Columns.Add("Distance(km)", GetType(Decimal))

        For Each row As DataRow In Access.DBDT.Rows
            'Use dist array to calculate the distance for each driver

            row.Item(4) = dist(group(row.Item(2)), group(Source))
        Next
        'Find the availabe driver that is nearest to the user


        Dim min_row As DataRow = Access.DBDT.Rows(0)
        Dim min_dis As Decimal = min_row.Item(4)
        For Each row As DataRow In Access.DBDT.Rows
            If row.Item(4) < min_dis Then
                min_dis = row.Item(4)
                min_row = row
            End If
        Next
        'Display the details of the closest available driver on the top(recommend it)

        L_name.Text = min_row.Item(0)
        L_phone.Text = min_row.Item(1)
        L_location.Text = min_row.Item(2)
        PictureBox1.Image = My.Resources.ResourceManager.GetObject(min_row.Item(3))


        Access.DBDT.Rows.Remove(min_row)  ' Remove the recommended driver from the table
        Access.DBDT.Columns.Remove("Photo") ' Remove the column photo
        Access.DBDT.DefaultView.Sort = "Distance(km)" ' Sort according to distance
        ERick_GridView.DataSource = Access.DBDT ' Set this table as the source of the data grid view

        'setting Parent of controls
        Label_name.Parent = PictureBox2
        Label_location.Parent = PictureBox2
        Label_phone.Parent = PictureBox2

    End Sub

End Class