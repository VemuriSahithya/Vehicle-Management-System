Public Class Emergency

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub Emergency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBack.Parent = PictureBox2
    End Sub
End Class