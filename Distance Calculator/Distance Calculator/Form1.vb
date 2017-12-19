Public Class DistanceCalculator

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblX As Double = 0
        Dim dblXDistanceTraveled As Double
        Do While dblX < CDbl(txtHours.Text)
            dblX = dblX + 1
            dblXDistanceTraveled = CDbl(txtSpeed.Text) * dblX
            ListResult.Items.Add(dblX.ToString & "       " & dblXDistanceTraveled.ToString)
        Loop
        ListResult.Items.Add("Total Distance: " & dblXDistanceTraveled)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
