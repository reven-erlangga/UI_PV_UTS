Public Class Product
    Public Barcode As String

    Private Sub MB_Generate_Click(sender As Object, e As EventArgs) Handles MB_Generate.Click
        Product_GenerateBarcode.Show()

        Me.Hide()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            'Dim query = EmployeeDB.Insert("Sample", Barcode, MCB_Gender.Text)

            'If query Then
            '    MessageBox.Show("Success saved data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Else
            '    MessageBox.Show("Failed saved data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class