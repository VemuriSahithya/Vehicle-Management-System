Imports System.Data.OleDb

Public Class BookingsDisplay
    ' Used to simply display the details of the bookings of the current user .
    Private Access As New DBControl ' Object for querying access database
    ' Driving function for printing data 
    Private Sub BookingsDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Checks if user type is Customer , if yes then searches by users username in the users column of Bookings 
        ' If not then searches for Drivers full name in Drivers column of bookings by finding the dullname of driver from user table .
        If Home.UserType <> "Customer" Then
            Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Users WHERE User = '" & Home.UserName & "' "
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            reader.Read()
            Dim full_name As String = reader("FullName")
            cn.Close()

            Access.ExecQuery("SELECT * FROM Bookings WHERE Driver = '" & full_name & "'")
        Else

            Access.ExecQuery("SELECT * FROM Bookings WHERE User = '" & Home.UserName & "'")
        End If
        ' Outputting the data to Data Grid View
        DataGridView1.DataSource = Access.DBDT

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class