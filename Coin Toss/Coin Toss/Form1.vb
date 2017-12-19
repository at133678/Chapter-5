Public Class CoinToss
    Dim TailsTotal As Double
    Dim HeadsTotal As Double
    Private Sub btnTosstheCoin_Click(sender As Object, e As EventArgs) Handles btnTosstheCoin.Click
        Dim intsideup As Integer 'TO indicate which side is up
        Dim rand As New Random 'Random number generator

        'Get a random number in th range of 0 through 1
        '0 means tails up, and 1 means heads up.
        intsideup = rand.Next(2)

        'Display the side that is up.
        If intsideup = 0 Then
            '0 means tails up, so display the tails
            'Image and hide the head image.
            picTails.Visible = True
            picHeads.Visible = False
            TailsTotal = TailsTotal + 1
        Else
            '1 means Heads is up, so display the heads
            'image and hide the tails image.
            picHeads.Visible = True
            picTails.Visible = False
            HeadsTotal = HeadsTotal + 1
        End If
        ResultforTails.Text = TailsTotal.ToString
        ResultforHeads.Text = HeadsTotal.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
