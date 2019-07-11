Imports System.Data.OleDb

Public Class BusHome
    'Declaration of variables
    Dim counter As Integer = 1
    Dim x As Integer
    Private Sub BusHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GUI code
        Label2.Parent = PictureBox1
        Label3.Parent = PictureBox1
        Button1.Parent = PictureBox1
        Button3.Parent = PictureBox1
        ComboBox1.SelectedIndex = 2
        ComboBox2.SelectedIndex = 25
    End Sub
    Sub setupListView()
        'add columns to the listview
        ListView1.Columns.Add("Bus Time", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Bus No", 50, HorizontalAlignment.Left)
        ListView1.Columns.Add("Starting Point", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Intermediate Stops", 50, HorizontalAlignment.Left)
        ListView1.Columns.Add("To", 70, HorizontalAlignment.Left)
        ListView1.Columns.Add("Pick Up Points", 200, HorizontalAlignment.Left)

        'Display listview in details view
        ListView1.View = View.Details
        'display grid lines
        ListView1.GridLines = True
        'allow full row selection
        ListView1.FullRowSelect = True
    End Sub
    'function to find the buses 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clr()
        'Create dictionary to relate the input names to that in database in which shortforms of the locations are present
        Dim dict As New Dictionary(Of String, String)

        dict.Add("Assam Bengal Carriers", "ABC")
        dict.Add("Academic Complex IITG", "AC")
        dict.Add("Administrative Building", "Admn")
        dict.Add("Amingaon", "AG")
        dict.Add("Ambari", "AM")
        dict.Add("Anuradha Cinama", "ARC")
        dict.Add("Adabari Tiniali", "AT")
        dict.Add("Beltola", "B")
        dict.Add("Bhanga Garh", "BG")
        dict.Add("Bamuni Maidan", "BM")
        dict.Add("Bharalumukh", "BHM")
        dict.Add("Chandmari Auto Stand", "CAS")
        dict.Add("Commerce College", "CC")
        dict.Add("Chandmari Police Point", "CPP")
        dict.Add("Commercial Complex", "Com C")
        dict.Add("Dhigali Pukhuri", "DP")
        dict.Add("Down Town Hospital", "DT")
        dict.Add("Guwahati Collage", "GC")
        dict.Add("Ganesh Guri", "GG")
        dict.Add("Ganesh Mandir", "GM")
        dict.Add("Guest House", "GH")
        dict.Add("Hatigaon Assembly Hostel", "HAH")
        dict.Add("Jalukbari", "JB")
        dict.Add("Jayguru", "JG")
        dict.Add("Kamakhya", "KM")
        dict.Add("Lachit Nagar", "LN")
        dict.Add("Maligaon", "MG")
        dict.Add("Noonmati", "NM")
        dict.Add("Pan Bazar", "PB")
        dict.Add("Panbazar Over Bridge", "PBOB")
        dict.Add("Panbazar Water Tank", "PBWT")
        dict.Add("Paltanbazar", "PLB")
        dict.Add("Sarab Bhati", "SB")
        dict.Add("Subansiri Hostel", "SH")
        dict.Add("Silpukhuri Gandhibasti Link", "SGL")
        dict.Add("Sixmile", "SM")
        dict.Add("Sundarpur", "SP")
        dict.Add("Super Market", "SUM")
        dict.Add("State Zoo", "SZ")
        dict.Add("Ulubari", "UB")
        dict.Add("Uzanbazar Latasil field", "UBL")

        'Declaration of variables 
        'Access connection strings
        Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
        Dim cn As OleDbConnection = New OleDbConnection(connectString)
        cn.Open()
        'select all those strings which matches the input pattern from the database
        Dim selectString As String = "SELECT * FROM BusTimings WHERE Pick_up_points LIKE '%" & dict.Item(ComboBox1.Text) & "%' AND Pick_up_points LIKE '%" & dict.Item(ComboBox2.Text) & "%' ORDER BY Bus_Time"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        'setup listview
        setupListView()
        While reader.Read
            Dim newitem As New ListViewItem()

            Dim myTime = DateTime.Parse(reader("Bus_Time"))
            Dim result = myTime.TimeOfDay - TimeOfDay.TimeOfDay
            'if the time difference is less than half and hour then highlight that row with light green color
            If result.Hours >= 0 And result.Hours < 1 And result.Minutes >= 0 And result.Minutes < 60 Then
                newitem.BackColor = Color.LightGreen
            Else
                newitem.BackColor = Color.AliceBlue
            End If

            Dim strArr As String()
            strArr = reader("Pick_up_points").ToString.Split("-")
            Dim ind1 As Integer = Array.IndexOf(strArr, dict.Item(ComboBox1.Text))
            Dim ind2 As Integer = Array.IndexOf(strArr, dict.Item(ComboBox2.Text))
            'Display the output only if the destination given as input comes after the input given for FROM else don't print
            If ind1 <> -1 And ind2 <> -1 And ind1 < ind2 Then

                newitem.Text = reader.GetValue(2) 'first column
                newitem.SubItems.Add(reader.GetValue(3)) 'second column

                For Each key In dict.Keys
                    If dict(key) = reader.GetValue(4) Then
                        newitem.SubItems.Add(key) 'third column
                        Exit For
                    End If
                Next

                Dim diff As Integer = ind2 - ind1 - 1
                newitem.SubItems.Add(diff) 'fourth column

                For Each key In dict.Keys
                    If dict(key) = reader.GetValue(6) Then
                        newitem.SubItems.Add(key) 'fifth column
                        Exit For
                    End If
                Next

                newitem.SubItems.Add(reader("Pick_up_points").ToString)
                ListView1.Items.Add(newitem)
                counter = counter + 1
            End If
        End While
        If counter = 1 Then MessageBox.Show("Buses are not available") 'if Number of rows is one then show the message
    End Sub
    'Function to clear the content displayed in the listview
    Private Sub Clr()
        counter = 1
        ListView1.Clear()
        'deleting dynamically allocated controls
        For i As Integer = 2 To counter - 1
            Me.Controls.Remove(Me.Controls.Find("ComboBox1.Text" & CStr(i), True)(0))
            Me.Controls.Remove(Me.Controls.Find("ComboBox2.Text" & CStr(i), True)(0))
        Next
    End Sub
    'Function to exit the application
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class