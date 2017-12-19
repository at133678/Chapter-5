Public Class RockPaperSissors
   

    Private Sub btnRock_Click(sender As Object, e As EventArgs) Handles btnRock.Click
        Dim intShoot As Integer
        Dim rand As New Random
        intShoot = rand.Next(1)

        If 1 = intShoot Then
            lblResult.Text = "You Win against Scissors"
        ElseIf 3 = intShoot Then
            lblResult.Text = "You Lose agenst Paper"
        ElseIf 1 = intShoot Then
            lblResult.Text = "You Tie agenst Rock"
        End If
    End Sub

    Private Sub btnPaper_Click(sender As Object, e As EventArgs) Handles btnPaper.Click
        Dim intShoot As Integer
        Dim rand As New Random
        intShoot = rand.Next(3)

        If 1 = intShoot Then
            lblResult.Text = "You Win against Rock"
        ElseIf 2 = intShoot Then
            lblResult.Text = "You Lose agenst Sissors"
        ElseIf 3 = intShoot Then
            lblResult.Text = "You Tie agenst Paper"
        End If
    End Sub

    Private Sub btnSissors_Click(sender As Object, e As EventArgs) Handles btnSissors.Click
        Dim intShoot As Integer
        Dim rand As New Random
        intShoot = rand.Next(2)

        If 3 = intShoot Then
            lblResult.Text = "You Win against Paper"
        ElseIf 1 = intShoot Then
            lblResult.Text = "You Lose agenst Rock"
        ElseIf 2 = intShoot Then
            lblResult.Text = "You Tie agenst Sissors"
        End If
    End Sub
End Class
