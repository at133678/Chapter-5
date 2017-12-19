Public Class FormPopulation

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim dblDays As Double = 0

        Dim dblIncreasePercentageThisOne As Double
        Dim dblApproximatePopulation As Double
        Do While dblDays < 10
            dblDays = dblDays + 1
            dblIncreasePercentageThisOne = ((CDbl(txtIncrease.Text) / 100) + 1) + dblIncreasePercentageThisOne
            dblApproximatePopulation = dblIncreasePercentageThisOne * CDbl(txtOrganisms.Text)
            lstPopulation.Items.Add(dblDays.ToString & "       " & dblApproximatePopulation.ToString)
        Loop


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtIncrease.Clear()
        txtOrganisms.Clear()
    End Sub
End Class
