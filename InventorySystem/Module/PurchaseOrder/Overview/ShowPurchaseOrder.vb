
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports QRCoder
Imports System.Drawing
Imports ZXing
Imports ZXing.Common
Imports ZXing.Rendering

' For Tugas
' Control Printing
' Report Printing
' Alignement Printed Text
' Calculate Text
' For-Loop

Public Class ShowPurchaseOrder
    Public PurchaseOrderID As Integer

    Private Sub ShowPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PurchaseOrder_Load()
        DGV_Load()
    End Sub
    Private Sub DGV_Load()
        Try
            DGV_POList.Rows.Clear()

            Dim products = PurchaseOrderListDB.FetchByPurchaseOrderID(PurchaseOrderID)

            If products IsNot Nothing Then ' If Else Statement
                For Each division In products
                    Dim product = ProductDB.FindByID(division.ProductID)

                    DGV_POList.Rows.Add(division.ID, product.Name, product.Qty, product.Price, product.Qty * product.Price)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Disconnect()
        End Try
    End Sub

    Private Sub PurchaseOrder_Load()
        Try
            Dim purchaseOrder = PurchaseOrderDB.FindByID(PurchaseOrderID)

            Dim barcodeWriter As New BarcodeWriter() With {.Format = BarcodeFormat.CODE_128, .Options = New EncodingOptions() With {.Width = 200, .Height = 60, .Margin = 10}}
            Dim barcodeBitmap As Bitmap = barcodeWriter.Write(purchaseOrder.PONumber)

            PB_Barcode.Image = barcodeBitmap

            MTB_VPurchaseOrder.Text = purchaseOrder.PONumber
            MTB_VName.Text = purchaseOrder.SupplierName
            MTB_VEmail.Text = purchaseOrder.SupplierEmail
            MTB_VFax.Text = purchaseOrder.SupplierFax
            MTB_VAddress.Text = purchaseOrder.SupplierAddress
        Catch ex As Exception
            MsgBox("Something error")
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim pdf As PdfDocument = New PdfDocument()
        pdf.Info.Title = "Purchase Order"

        Dim page As PdfPage = pdf.AddPage()
        Dim gfx As XGraphics = XGraphics.FromPdfPage(page)

        Dim titleFont As XFont = New XFont("Arial", 24, XFontStyleEx.Bold)
        Dim headerFont As XFont = New XFont("Arial", 12, XFontStyleEx.Bold)
        Dim textFont As XFont = New XFont("Arial", 12, XFontStyleEx.Regular)

        gfx.DrawString("Purchase Order", titleFont, XBrushes.Black, New XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.TopCenter) ' Alignment Printed Text

        Dim purchaseOrder = PurchaseOrderDB.FindByID(PurchaseOrderID)

        gfx.DrawString("PO Number: " + purchaseOrder.PONumber, headerFont, XBrushes.Black, New XPoint(50, 100))
        gfx.DrawString("Supplier Name: " + purchaseOrder.SupplierName, headerFont, XBrushes.Black, New XPoint(50, 120))
        gfx.DrawString("Supplier Email: " + purchaseOrder.SupplierEmail, headerFont, XBrushes.Black, New XPoint(50, 140))
        'gfx.DrawString("Date: " & DateTime.Now.ToString("dd/MM/yyyy"), headerFont, XBrushes.Black, New XPoint(50, 140))

        Dim yPoint As Double = 180
        gfx.DrawString("Item", headerFont, XBrushes.Black, New XPoint(50, yPoint))
        gfx.DrawString("Quantity", headerFont, XBrushes.Black, New XPoint(200, yPoint))
        gfx.DrawString("Price", headerFont, XBrushes.Black, New XPoint(300, yPoint))
        gfx.DrawString("Total", headerFont, XBrushes.Black, New XPoint(400, yPoint))

        Dim barcodeWriter As New BarcodeWriter() With {.Format = BarcodeFormat.CODE_128, .Options = New EncodingOptions() With {.Width = 200, .Height = 60, .Margin = 10}}
        Dim barcodeBitmap As Bitmap = barcodeWriter.Write(purchaseOrder.PONumber)

        Using ms As New System.IO.MemoryStream()
            barcodeBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            ms.Position = 0
            Dim xImage As XImage = XImage.FromStream(ms)
            gfx.DrawImage(xImage, 400, 60, 200, 60) ' Adjust the position and size as needed End Using
        End Using

        yPoint += 20
            Dim items As New List(Of (String, Integer, Double)) From {
            ("Item 1", 10, 5.0),
            ("Item 2", 20, 3.5),
            ("Item 3", 15, 8.0)
        }

        Dim grandTotal As Double = 0

        Dim purchaseOrderLists = PurchaseOrderListDB.FetchByPurchaseOrderID(PurchaseOrderID)
        For Each item In purchaseOrderLists
            Dim product = ProductDB.FindByID(item.ProductID)

            gfx.DrawString(product.Name, textFont, XBrushes.Black, New XPoint(50, yPoint))
            gfx.DrawString(item.Qty, textFont, XBrushes.Black, New XPoint(200, yPoint))
            gfx.DrawString(product.Price.ToString("F2"), textFont, XBrushes.Black, New XPoint(300, yPoint))
            Dim itemTotal As Double = product.Price * item.Qty ' Calculate
            gfx.DrawString(itemTotal.ToString("F2"), textFont, XBrushes.Black, New XPoint(400, yPoint))
            grandTotal += itemTotal
            yPoint += 20
        Next

        gfx.DrawString("Grand Total: " & grandTotal.ToString("F2"), headerFont, XBrushes.Black, New XPoint(50, yPoint + 20))

        Dim filename As String = "PurchaseOrderTemplate.pdf"
            pdf.Save(filename)

            Process.Start(filename)
    End Sub
End Class