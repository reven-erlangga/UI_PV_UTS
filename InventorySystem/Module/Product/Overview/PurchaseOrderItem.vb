Public Class PurchaseOrderItem
    Dim overviewPOForm As New OverviewPurchaseOrder()

    Private Sub PurchaseOrderItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_Load()
    End Sub

    Private Sub DGV_Load()
        Try
            DGV_ListProduct.Rows.Clear()

            Dim products = ProductDB.Fetch()

            If products IsNot Nothing Then
                For Each division In products
                    DGV_ListProduct.Rows.Add(division.ID, division.Name, division.Qty, division.Price)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Disconnect()
        End Try
    End Sub

    Private Sub DGV_ListProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ListProduct.CellClick
        MTB_VID.Text = DGV_ListProduct.CurrentRow.Cells(0).Value
        MTB_VName.Text = DGV_ListProduct.CurrentRow.Cells(1).Value
        MTB_VQty.Text = "0"
        MTB_VPrice.Text = Convert.ToInt64(DGV_ListProduct.CurrentRow.Cells(3).Value)
    End Sub

    Private Sub MB_AddToListProduct_Click(sender As Object, e As EventArgs) Handles MB_AddToListProduct.Click
        Dim purchaseOrderModel As New PurchaseOrderModel
        Dim item As New PurchaseOrderListModel

        item.ProductID = MTB_VID.Text
        item.Qty = MTB_VQty.Text


        MGV_PurchaseOrderItem.Rows.Add(item.ID, MTB_VName.Text, item.Qty, Convert.ToInt64(MTB_VPrice.Text) * item.Qty)

        PurchaseOrderTemp.Items.Add(item)
    End Sub
End Class