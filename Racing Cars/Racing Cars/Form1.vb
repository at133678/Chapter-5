Public Class CarRace
    Dim FireSkullTotal As Double
    Dim RealCarTotal As Double
    Dim ColorCarTotal As Double
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim intCount As Integer ' Loop Counter
        Dim rand As New Random ' Random number generator
        'Move the image across the form.
        For intCount = 16 To rand.Next(328)
            FireSkull.Left = intCount
            FireSkullTotal = FireSkullTotal + 1
        Next
        For intCount = 16 To rand.Next(328)
            RealCar.Left = intCount
            RealCarTotal = RealCarTotal + 1
        Next
        For intCount = 16 To rand.Next(328)
            ColorCar.Left = intCount
            ColorCarTotal = ColorCarTotal + 1
        Next
        ResultforFireSkull.Text = FireSkullTotal.ToString
        ResultforRealCar.Text = RealCarTotal.ToString
        ResultforColorCar.Text = ColorCarTotal.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
