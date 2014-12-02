Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intNumber As Integer = Val(Me.txtNumber.Text)
        Dim lngSum As Long

        Dim intC As Integer
        For intC = 1 To intNumber
            If intC Mod 2 <> 0 Then
                lngSum = lngSum + intC
            End If
        Next intC
        Me.lblSum.Text = "The sum of the odd numbers is " & lngSum
    End Sub
End Class
