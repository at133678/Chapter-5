Public Class Menu

    Private Sub CoinToss_Click(sender As Object, e As EventArgs) Handles CoinToss.Click
        Dim Box = New CoinToss()
        Box.Show()
    End Sub

    Private Sub btnSumOfNumbers_Click(sender As Object, e As EventArgs) Handles btnSumOfNumbers.Click
        Dim Box = New SumOfNumbers()
        Box.Show()
    End Sub

    Private Sub CarRace_Click(sender As Object, e As EventArgs) Handles CarRace.Click
        Dim Box = New CarRace()
        Box.Show()
    End Sub

    Private Sub RockPaperSissors_Click(sender As Object, e As EventArgs) Handles RockPaperSissors.Click
        Dim Box = New RockPaperSissors()
        Box.Show()
    End Sub
End Class
