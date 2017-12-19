Public Class RunningTotal

    Private Sub btnEnterSales_Click(sender As Object, e As EventArgs) Handles btnEnterSales.Click

        Const intNUM_DAYS As Integer = 5 'Number of days
        Dim IntCount As Integer = 1     ' Loop counter
        Dim decSales As Decimal = 0     ' To hold daily sales
        Dim decTotal As Decimal = 0     ' To hold the total sales
        Dim strinput As String          ' To hold string input

        Do While IntCount <= intNUM_DAYS

            ' Get a daily sales amount from the user.
            strinput = InputBox("Enter the sales for day" & IntCount.ToString())

            ' Convert the input to a Decmal.
            If Decimal.TryParse(strinput, decSales) Then
                'Add the daily sales to the total sales.
                decTotal += decSales
                'Add 1 to the loop counter.
                IntCount += 1
            Else
                'Desplay an error message for invalid input.

            End If
        Loop
    End Sub
End Class
