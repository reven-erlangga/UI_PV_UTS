Public Class AbsenceNotFoundDialog
    Private randomStrings() As String = {"Data Not Found!", "Check Your Card!", "Sorry, Try Again", "You Dont Registered to Our System"}
    Private rnd As New Random()
    Private Sub T_CloseDialog_Tick(sender As Object, e As EventArgs) Handles T_CloseDialog.Tick
        Me.Close()
    End Sub

    Private Sub AbsenceNotFoundDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim randomString As String = GenerateRandomString()

        HtmlLabel1.Text = randomString
    End Sub

    Private Function GenerateRandomString() As String
        Dim randomIndex As Integer = rnd.Next(randomStrings.Length)

        Return randomStrings(randomIndex)
    End Function
End Class