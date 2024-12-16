Public Class IncomingPurchaseOrder
    Dim PurchaseOrderID As Integer
    Private IsHaveData As Boolean

    Private PurchaseOrder As String

    Private Sub IncomingPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IncomingPurchaseOrder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If IsHaveData Then
            Return
        End If

        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)) Then


            PurchaseOrder = Nothing
        Else
            PurchaseOrder += e.KeyChar
        End If
    End Sub

    Private Sub MTB_VPurchaseOrderNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MTB_VPurchaseOrderNumber.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            Try
                DGV_PurchaseOrderList.Rows.Clear()

                Dim products = PurchaseOrderDB.FindByPONumber(MTB_VPurchaseOrderNumber.Text)
                If products IsNot Nothing Then
                    PurchaseOrderID = products.ID

                    Dim purchaseOrderLists = PurchaseOrderListDB.FetchByPurchaseOrderID(products.ID)

                    For Each division In purchaseOrderLists
                        Dim product = ProductDB.FindByID(division.ProductID)

                        DGV_PurchaseOrderList.Rows.Add(division.ID, product.ID, product.Name, product.Price, division.Qty, division.Qty * product.Price)
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connection.Disconnect()
            End Try

        End If
    End Sub

    Private Sub MB_Save_Click(sender As Object, e As EventArgs) Handles MB_Save.Click
        Dim purchaseOrder = PurchaseOrderDB.FindByID(PurchaseOrderID)

        Dim PurchaseOrderModel As New PurchaseOrderModel()

        If purchaseOrder.Status = "Progress" Then
            PurchaseOrderModel.ID = purchaseOrder.ID

            If DGV_PurchaseOrderList.Rows.Count > 0 Then
                Dim PurchaseOrderLists As List(Of PurchaseOrderListModel)

                For Each row As DataGridViewRow In DGV_PurchaseOrderList.Rows
                    If Not row.IsNewRow Then
                        Dim PurchaseOrderListModel As New PurchaseOrderListModel()

                        PurchaseOrderListModel.ID = row.Cells("C_ID").Value
                        PurchaseOrderListModel.ProductID = row.Cells("C_ProductID").Value
                        PurchaseOrderListModel.Qty = row.Cells("C_Qty").Value

                        If PurchaseOrderModel.PurchaseOrderLists Is Nothing Then
                            PurchaseOrderModel.PurchaseOrderLists = New List(Of PurchaseOrderListModel)()
                        End If

                        PurchaseOrderModel.PurchaseOrderLists.Add(PurchaseOrderListModel)
                    End If
                Next
                Dim PurchaseOrderIncoming = PurchaseOrderDB.Receive(PurchaseOrderModel)

                If PurchaseOrderIncoming Then
                    MsgBox("Incoming success")
                End If
            End If

        Else
            MsgBox("Purchase Order Already Completed")
        End If


    End Sub
End Class