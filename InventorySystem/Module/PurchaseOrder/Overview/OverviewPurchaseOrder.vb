Public Class OverviewPurchaseOrder
    Public Property PurchaseOrderItems As Integer


    Private Sub MB_PurchaseOrderItem_Click(sender As Object, e As EventArgs) Handles MB_PurchaseOrderItem.Click
        PurchaseOrderItem.ShowDialog()
    End Sub

    Private Sub OverviewPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PurchaseOrderTemp.Number = "X"
        DGV_Load()
    End Sub
    Private Sub DGV_Load()
        Try
            DGV_PO.Rows.Clear()

            Dim divisions = PurchaseOrderDB.Fetch()

            If divisions IsNot Nothing Then
                For Each division In divisions
                    DGV_PO.Rows.Add(division.ID, division.PONumber, division.SupplierName, division.Reason, division.Status)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Disconnect()
        End Try
    End Sub

    Private Sub MB_Save_Click(sender As Object, e As EventArgs) Handles MB_Save.Click
        Dim purchaseOrderModel As New PurchaseOrderModel()

        purchaseOrderModel.SupplierName = MTB_VName.Text
        purchaseOrderModel.SupplierEmail = MTB_VEmail.Text
        purchaseOrderModel.SupplierFax = MTB_VFax.Text
        purchaseOrderModel.SupplierHandphone = MTB_VHandphone.Text
        purchaseOrderModel.SupplierAddress = MTB_VAddress.Text
        purchaseOrderModel.PurchaseOrderLists = PurchaseOrderTemp.Items

        PurchaseOrderDB.Insert(purchaseOrderModel)

        DGV_Load()
    End Sub

    Private Sub DGV_PO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_PO.CellClick
        Dim selectedRow As DataGridViewRow = DGV_PO.Rows(e.RowIndex)

        Dim purchaseOrderID As Integer = Convert.ToInt32(selectedRow.Cells("C_ID").Value)

        Dim PO As New ShowPurchaseOrder()

        PO.PurchaseOrderID = purchaseOrderID

        PO.ShowDialog()
    End Sub

    Private Sub MB_Back_Click(sender As Object, e As EventArgs) Handles MB_Back.Click
        Homepage.Show()

        Me.Hide()
    End Sub
End Class