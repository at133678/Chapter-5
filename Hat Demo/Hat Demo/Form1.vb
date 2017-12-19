Public Class HatDemo

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim intCount As Integer ' Loop Counter

        'Move the image across the form.
        For intCount = 16 To 328
            Cap.Left = intCount
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
