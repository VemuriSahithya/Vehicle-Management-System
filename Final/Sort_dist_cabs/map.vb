Public Class map

    ' Form to Select two of the 8 Locations on the map of guwahati and send the data back to calling forms 
    Private Sub map_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Gui
        btnTo.Hide()

        btnClear.Hide()
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label3.Parent = PictureBox1
        btnClear.Parent = PictureBox1
        btnFrom.Parent = PictureBox1
        btnTo.Parent = PictureBox1

    End Sub
    ' Functions for functionality of radio buttons, clear and source and destination buttons
    Private Sub btnFrom_Click(sender As Object, e As EventArgs) Handles btnFrom.Click
        RichTextBoxFrom.Text = txtboxCurrentSelection.Text
        btnFrom.Hide()

        btnTo.Show()

        btnClear.Show()
    End Sub

    Private Sub radioIITG_CheckedChanged(sender As Object, e As EventArgs) Handles radioIITG.CheckedChanged
        If radioIITG.Checked Then
            txtboxCurrentSelection.Text = radioIITG.Text
        End If
    End Sub

    Private Sub radioPaltan_CheckedChanged(sender As Object, e As EventArgs) Handles radioPaltan.CheckedChanged
        If radioPaltan.Checked Then
            txtboxCurrentSelection.Text = radioPaltan.Text
        End If
    End Sub

    Private Sub radioBeltola_CheckedChanged(sender As Object, e As EventArgs) Handles radioBeltola.CheckedChanged
        If radioBeltola.Checked Then
            txtboxCurrentSelection.Text = radioBeltola.Text
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles radioGanesh.CheckedChanged
        If radioGanesh.Checked Then
            txtboxCurrentSelection.Text = radioGanesh.Text
        End If
    End Sub

    Private Sub radioStadium_CheckedChanged(sender As Object, e As EventArgs) Handles radioStadium.CheckedChanged
        If radioStadium.Checked Then
            txtboxCurrentSelection.Text = radioStadium.Text
        End If
    End Sub

    Private Sub radioKamakhya_CheckedChanged(sender As Object, e As EventArgs) Handles radioKamakhya.CheckedChanged
        If radioKamakhya.Checked Then
            txtboxCurrentSelection.Text = radioKamakhya.Text
        End If
    End Sub

    Private Sub radioJalukbari_CheckedChanged(sender As Object, e As EventArgs) Handles radioJalukbari.CheckedChanged
        If radioJalukbari.Checked Then
            txtboxCurrentSelection.Text = radioJalukbari.Text
        End If
    End Sub

    Private Sub radioAirport_CheckedChanged(sender As Object, e As EventArgs) Handles radioAirport.CheckedChanged
        If radioAirport.Checked Then
            txtboxCurrentSelection.Text = radioAirport.Text
        End If
    End Sub

    Private Sub btnTo_Click(sender As Object, e As EventArgs) Handles btnTo.Click
        RichTextBoxTo.Text = txtboxCurrentSelection.Text
        btnTo.Hide()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        RichTextBoxFrom.Text = ""
        RichTextBoxTo.Text = ""
        btnClear.Hide()
        btnTo.Hide()

        btnFrom.Show()

    End Sub

    ' On Confirmation sends the data back to calling forms 
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If RichTextBoxFrom.Text = RichTextBoxTo.Text Then
            MsgBox("Enter Different Locations")
        ElseIf RichTextBoxFrom.Text <> "" And RichTextBoxTo.Text <> "" Then

            ShortHome.SourceLocation = RichTextBoxFrom.Text
            ShortHome.DestinationLocation = RichTextBoxTo.Text
            ShortHome.printSourceAndDest()
            ReccoHome.SourceLocation = RichTextBoxFrom.Text
            ReccoHome.DestinationLocation = RichTextBoxTo.Text
            ReccoHome.printSourceAndDest()

            Me.Close()
        Else
            MsgBox("Enter Both Locations ")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class