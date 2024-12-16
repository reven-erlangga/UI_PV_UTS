Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Module PurchaseOrderListDB
    Function FetchByPurchaseOrderID(PurchaseOrderID As Integer) As List(Of PurchaseOrderListModel)
        Connection.Connect()

        Dim productCategories As New List(Of PurchaseOrderListModel)
        Dim cmd As New MySqlCommand("SELECT * FROM `purchase_order_lists` WHERE `purchase_order_id` = @purchase_order_id;", Connection.conn)
        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@purchase_order_id", PurchaseOrderID)

        Dim reader = cmd.ExecuteReader()
        While reader.Read
            Dim purchaseOrder As New PurchaseOrderListModel

            purchaseOrder.ID = reader.Item("id")
            purchaseOrder.Qty = reader.Item("qty")
            purchaseOrder.ProductID = reader.Item("product_id")

            'Dim transactionLists As New List(Of TransactionListModel)

            'purchaseOrder.PurchaseOrderLists = reader.Item("purchase_order_lists")

            productCategories.Add(purchaseOrder)
        End While
        reader.Dispose()

        Connection.Disconnect()

        If productCategories Is Nothing Then
            Return Nothing
        End If

        If productCategories.Count() > 0 Then
            Return productCategories
        End If

        Return Nothing
    End Function
End Module
