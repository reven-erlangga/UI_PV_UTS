Public Class Product_GenerateBarcode
    Private Sub HL_Barcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HL_Barcode.KeyPress
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)) Then
            Dim ProductObj As New Product()
            ProductObj.Barcode = HL_Barcode.Text
            ProductObj.PB_Barcode.Load("https://quickchart.io/barcode?type=code128&text=" + HL_Barcode.Text)
            ProductObj.Refresh()
            ProductObj.Show()

            ProductObj.MTB_Name.ReadOnly = False


            Me.Close()

        Else
            HL_Barcode.Text += e.KeyChar
        End If
    End Sub
End Class