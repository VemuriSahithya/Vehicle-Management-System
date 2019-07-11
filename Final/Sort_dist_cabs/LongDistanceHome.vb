Imports System.Data.OleDb
Imports System.ComponentModel


Public Class LongDistanceHome

    Dim cnt As Integer = 1
    Dim x As Integer
    Dim driverList(100) As String
    Dim choice As Integer = -1



    'create textbox dynamically
    Private Sub outTextAdder(i As Integer, tmp As String)
        Dim txtName As String
        Dim radName As String

        radName = "rad" & CStr(i)
        txtName = "output_Box" & CStr(i)
        Dim yt As Integer = output_Box1.Location.Y + output_Box1.Height * (i - 1)
        Dim yr As Integer = yt + output_Box1.Height / 2
        Dim xr As Integer = x + output_Box1.Width + 10
        Dim txt1 As New RichTextBox
        txt1.Name = txtName
        txt1.Width = output_Box1.Width
        txt1.Height = output_Box1.Height
        txt1.ReadOnly = True
        Me.Controls.Add(txt1)
        txt1.BringToFront()
        txt1.Location = New Point(output_Box1.Left, yt)
        txt1.Text = tmp
        txt1.Visible = True
        txt1.BackColor = Color.Cornsilk

        Dim rad As New RadioButton
        Me.Controls.Add(rad)
        rad.BringToFront()
        rad.Parent = PictureBox1
        rad.BackColor = Color.Transparent
        rad.Name = radName
        rad.Location = New Point(rad1.Left, yr)
        rad.Checked = False

    End Sub

    'clear function
    Private Sub Clr()
        output_Box1.Clear()
        output_Box1.Hide()
        rad1.Hide()
        'deleting dynamically allocated controls
        For i As Integer = 2 To cnt - 1
            Me.Controls.Remove(Me.Controls.Find("output_Box" & CStr(i), True)(0))
            Me.Controls.Remove(Me.Controls.Find("rad" & CStr(i), True)(0))
            Me.Controls.Find("rad" & CStr(i), True)(0).Hide()
        Next
        rad1.Checked = False
        cnt = 1
        choice = -1
        output_Box1.Hide()
        Label2.Hide()
        ComboBox1.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        output_Box1.Hide()
        Label2.Hide()
        ComboBox1.Text = ""
        Clr()
    End Sub

    Private Sub bck_btn_Click(sender As Object, e As EventArgs) Handles bck_btn.Click
        'back button
        Me.Close()
    End Sub

    Private Sub srch_btn_Click(sender As Object, e As EventArgs) Handles srch_btn.Click
        If ComboBox1.Text = "" Then
            MsgBox("Search Box is empty ")
            Exit Sub
        End If
        Clr()

        Label2.Show()
        output_Box1.Show()
        rad1.Show()
        Dim con As String
        Dim sql As String
        con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb"
        Dim connection As OleDbConnection = New OleDbConnection(con)

        'make connection with the data base.
        connection.Open()

        'sql string for search
        sql = "Select * from Drivers_LongDistance where will_go LIKE '%" & ComboBox1.Text & "%' AND status = True Order by price"
        Dim cmd As OleDbCommand = New OleDbCommand(sql, connection)
        Dim rdr As OleDbDataReader = cmd.ExecuteReader()

        'search in the data tables
        While rdr.Read


            Dim temp As String = "Driver name :" & rdr("f_name") & " " & rdr("l_name") & Environment.NewLine
            temp = temp & "Avalability :" & rdr("status") & Environment.NewLine
            temp = temp & "Price per day:" & rdr("price") & " RUPEES"
            driverList(cnt) = rdr("f_name")
            If cnt = 1 Then
                output_Box1.Text = temp
            Else
                outTextAdder(cnt, temp)
            End If
            cnt = cnt + 1
        End While

        'no drivers found
        If cnt = 1 Then
            Me.Hide()
            MessageBox.Show("No services to " & ComboBox1.Text & "!")
            Me.Show()
            ComboBox1.TabIndex = 1
            Label2.Hide()
            output_Box1.Hide()
            rad1.Hide()
        End If
        Me.Size = New Size(696, 50 + Me.Size.Height)
        connection.Close()
    End Sub

    Private Sub LongDistanceHome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Home.Reset()
        Home.Show()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rad As New RadioButton
        Label2.Hide()
        rad1.Hide()
        output_Box1.Hide()
        ComboBox1.Select()
        AcceptButton = srch_btn

        'setting parent of controls to picturebox for UI purposes
        Label4.Parent = PictureBox1
        Label3.Parent = PictureBox1
        Label5.Parent = PictureBox1
        Label2.Parent = PictureBox1
        rad1.Parent = PictureBox1
        bck_btn.Parent = PictureBox1
    End Sub

    Private Sub cnfrmBtn_Click(sender As Object, e As EventArgs) Handles cnfrmBtn.Click

        For i As Integer = 1 To cnt - 1
            Dim rad As RadioButton = (Me.Controls.Find("rad" & CStr(i), True)(0))
            If rad.Checked = True Then
                choice = i
            End If
        Next
        If choice = -1 Then
            MsgBox("Please Select a Cab")
            Exit Sub
        End If

        Dim cForm As New longDiscRec
        Dim DriverName As String = driverList(choice)
        cForm.drivername = DriverName
        cForm.Show()

    End Sub

End Class
