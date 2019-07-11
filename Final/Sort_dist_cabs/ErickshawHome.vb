Public Class ErickshawHome

    Private Sub ErickshawHome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Home.Reset()
        Home.Show()
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox2
        Me.Height = 550 ' Sets the height of the form on loading it

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'RadioButton1.Parent = Me

    End Sub


    Private Sub Button_from_Click(sender As Object, e As EventArgs) Handles Button_from.Click
        ' If the "from" button was clicked, check which radio button was selected
        ' and display text accordingly
        If (RadioButton1.Checked = True) Then
            Text_from.Text = "Kameng"
        ElseIf (RadioButton2.Checked = True) Then
            Text_from.Text = "Barak"
        ElseIf (RadioButton3.Checked = True) Then
            Text_from.Text = "Umium"
        ElseIf (RadioButton4.Checked = True) Then
            Text_from.Text = "Siang"
        ElseIf (RadioButton5.Checked = True) Then
            Text_from.Text = "Dibang"
        ElseIf (RadioButton6.Checked = True) Then
            Text_from.Text = "Dihing"
        ElseIf (RadioButton7.Checked = True) Then
            Text_from.Text = "Brahma"
        ElseIf (RadioButton8.Checked = True) Then
            Text_from.Text = "Dhansiri"
        ElseIf (RadioButton9.Checked = True) Then
            Text_from.Text = "Subansiri"
        ElseIf (RadioButton10.Checked = True) Then
            Text_from.Text = "Acad Complex"
        ElseIf (RadioButton11.Checked = True) Then
            Text_from.Text = "Library"
        ElseIf (RadioButton12.Checked = True) Then
            Text_from.Text = "Guest House"
        ElseIf (RadioButton13.Checked = True) Then
            Text_from.Text = "Mkt Complex"
        End If
    End Sub

    Private Sub Button_to_Click(sender As Object, e As EventArgs) Handles Button_to.Click
        ' If the "to" button was clicked, check which radio button was selected
        ' and display text accordingly
        If (RadioButton1.Checked = True) Then
            Text_to.Text = "Kameng"
        ElseIf (RadioButton2.Checked = True) Then
            Text_to.Text = "Barak"
        ElseIf (RadioButton3.Checked = True) Then
            Text_to.Text = "Umium"
        ElseIf (RadioButton4.Checked = True) Then
            Text_to.Text = "Siang"
        ElseIf (RadioButton5.Checked = True) Then
            Text_to.Text = "Dibang"
        ElseIf (RadioButton6.Checked = True) Then
            Text_to.Text = "Dihing"
        ElseIf (RadioButton7.Checked = True) Then
            Text_to.Text = "Brahma"
        ElseIf (RadioButton8.Checked = True) Then
            Text_to.Text = "Dhansiri"
        ElseIf (RadioButton9.Checked = True) Then
            Text_to.Text = "Subansiri"
        ElseIf (RadioButton10.Checked = True) Then
            Text_to.Text = "Acad Complex"
        ElseIf (RadioButton11.Checked = True) Then
            Text_to.Text = "Library"
        ElseIf (RadioButton12.Checked = True) Then
            Text_to.Text = "Guest House"
        ElseIf (RadioButton13.Checked = True) Then
            Text_to.Text = "Mkt Complex"
        End If
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If (Text_from.Text = "") Then ' Current location was not entered
            MessageBox.Show("Select your Source Location first!", "Error")
        ElseIf (Text_to.Text = "") Then ' Destination was not entered
            MessageBox.Show("Select your Destination first!", "Error")
        ElseIf (Text_to.Text = Text_from.Text) Then ' Source = Destination
            MessageBox.Show("Souce and Destination can't be the same!", "Error")
        Else

            Dim driver_reco As New e_rick_driver_reco ' Form for showing driver recommendation
            driver_reco.Source = Text_from.Text ' Source is the current location of the user
            driver_reco.Show()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class

