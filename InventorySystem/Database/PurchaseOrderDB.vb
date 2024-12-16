Imports MySql.Data.MySqlClient

Module PurchaseOrderDB
    Function Fetch() As List(Of PurchaseOrderModel)
        Connection.Connect()

        Dim productCategories As New List(Of PurchaseOrderModel)
        Dim cmd As New MySqlCommand("SELECT * FROM `purchase_orders`;", Connection.conn)

        Dim reader = cmd.ExecuteReader()
        While reader.Read
            Dim purchaseOrder As New PurchaseOrderModel

            purchaseOrder.ID = reader.Item("id")
            purchaseOrder.PONumber = reader.Item("po_number")
            purchaseOrder.SupplierName = reader.Item("supplier_name")
            purchaseOrder.SupplierEmail = reader.Item("supplier_email")
            purchaseOrder.Status = reader.Item("status")

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
    Function TotalPO() As Integer
        Connection.Connect()

        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM `purchase_orders`", Connection.conn)

        Dim i As Integer = cmd.ExecuteScalar()

        Connection.Disconnect()

        Return i
    End Function

    Function TotalPOByStatus(Status As String) As Integer
        Connection.Connect()

        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM `purchase_orders` WHERE `status` = @status", Connection.conn)
        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@status", Status)

        Dim i As Integer = cmd.ExecuteScalar()

        Connection.Disconnect()

        Return i
    End Function

    Function FindByID(ID As Integer) As PurchaseOrderModel
        Connection.Connect()

        Dim cmd As New MySqlCommand("SELECT * FROM `purchase_orders` WHERE `id` = @id LIMIT 1", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@id", ID)

        Dim reader = cmd.ExecuteReader()
        If (reader.Read()) Then

            Dim transaction As New PurchaseOrderModel

            transaction.ID = reader("id")
            transaction.PONumber = reader("po_number")
            transaction.SupplierName = reader("supplier_name")
            transaction.SupplierEmail = reader("supplier_email")
            transaction.SupplierFax = reader("supplier_fax")
            transaction.SupplierHandphone = reader("supplier_handphone")
            transaction.SupplierAddress = reader("supplier_address")
            transaction.Status = reader("status")

            Connection.Disconnect()

            Return transaction
        End If

        Connection.Disconnect()

        Return Nothing
    End Function

    Function FindByPONumber(PONumber As String) As PurchaseOrderModel
        Connection.Connect()

        Dim cmd As New MySqlCommand("SELECT * FROM `purchase_orders` WHERE `po_number` = @po_number LIMIT 1", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@po_number", PONumber)

        Dim reader = cmd.ExecuteReader()
        If (reader.Read()) Then

            Dim transaction As New PurchaseOrderModel

            transaction.ID = reader("id")
            transaction.PONumber = reader("po_number")
            transaction.SupplierName = reader("supplier_name")

            Connection.Disconnect()

            Return transaction
        End If

        Connection.Disconnect()

        Return Nothing
    End Function

    Function MakeInvoiceNumber() As String
        Connection.Connect()

        Dim cmd As New MySqlCommand("SELECT * FROM `purchase_orders` ORDER BY `id` DESC LIMIT 1", Connection.conn)

        cmd.Parameters.Clear()

        Dim reader = cmd.ExecuteReader()
        If (reader.Read()) Then
            Dim generate As Generate = New Generate()
            Dim purchaseOrderNumber = reader("po_number")

            Connection.Disconnect()

            Return generate.InvoiceNumber(purchaseOrderNumber)
        End If

        Connection.Disconnect()

        Return Nothing
    End Function

    Function Receive(PurchaseOrderModel As PurchaseOrderModel) As Boolean
        Connection.Connect()

        If PurchaseOrderModel.PurchaseOrderLists IsNot Nothing Then
            For Each item As PurchaseOrderListModel In PurchaseOrderModel.PurchaseOrderLists
                Dim cmd As New MySqlCommand("UPDATE `products` SET `qty` = `qty` + @qty WHERE `id` = @id", Connection.conn)

                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@id", item.ProductID)
                cmd.Parameters.AddWithValue("@qty", item.Qty)

                cmd.ExecuteNonQuery()
            Next
        End If

        Dim cmdPO As New MySqlCommand("UPDATE `purchase_orders` SET `status` = @status WHERE `id` = @id", Connection.conn)

        cmdPO.Parameters.Clear()

        cmdPO.Parameters.AddWithValue("@id", PurchaseOrderModel.ID)
        cmdPO.Parameters.AddWithValue("@status", "Completed")

        Dim i = cmdPO.ExecuteNonQuery
        Connection.Disconnect()
        If i > 0 Then
            Return True
        End If

        Connection.Disconnect()
        Return True
    End Function

    Function Insert(PurchaseOrderModel As PurchaseOrderModel) As Boolean
        Dim purchaseOrderNumber As String

        purchaseOrderNumber = MakeInvoiceNumber()

        Connection.Connect()

        Dim cmd As New MySqlCommand("INSERT INTO `purchase_orders` (`po_number`, `supplier_name`, `supplier_email`, `supplier_fax`, `supplier_handphone`, `supplier_address`) VALUES (@po_number, @supplier_name, @supplier_email, @supplier_fax, @supplier_handphone, @supplier_address)", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@po_number", purchaseOrderNumber)
        cmd.Parameters.AddWithValue("@supplier_name", PurchaseOrderModel.SupplierName)
        cmd.Parameters.AddWithValue("@supplier_email", PurchaseOrderModel.SupplierEmail)
        cmd.Parameters.AddWithValue("@supplier_fax", PurchaseOrderModel.SupplierFax)
        cmd.Parameters.AddWithValue("@supplier_handphone", PurchaseOrderModel.SupplierHandphone)
        cmd.Parameters.AddWithValue("@supplier_address", PurchaseOrderModel.SupplierAddress)

        Dim i = cmd.ExecuteNonQuery

        If i > 0 Then
            Dim lastInsertId As Long = cmd.LastInsertedId

            For Each item As PurchaseOrderListModel In PurchaseOrderModel.PurchaseOrderLists
                Dim itemCmd As New MySqlCommand("INSERT INTO `purchase_order_lists` (`purchase_order_id`, `product_id`, `qty`) VALUES (@purchase_order_id, @product_id, @qty)", Connection.conn)

                itemCmd.Parameters.Clear()

                itemCmd.Parameters.AddWithValue("@purchase_order_id", lastInsertId)
                itemCmd.Parameters.AddWithValue("@product_id", item.ProductID)
                itemCmd.Parameters.AddWithValue("@qty", item.Qty)

                itemCmd.ExecuteNonQuery()
            Next

            Connection.Disconnect()

            Return True
        End If

        Connection.Disconnect()

        Return False
    End Function

    Function Update(ID As Integer, Name As String, Description As String) As Boolean
        Connection.Connect()
        Dim cmd As New MySqlCommand("UPDATE `purchase_orders` SET `name` = @name, `description` = @description WHERE `id` = @id", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@id", ID)
        cmd.Parameters.AddWithValue("@invoice_number", Name)
        cmd.Parameters.AddWithValue("@cust_name", Description)

        Dim i = cmd.ExecuteNonQuery
        Connection.Disconnect()
        If i > 0 Then
            Return True
        End If

        Return False
    End Function

    Function Delete(ID As Integer) As Boolean
        Connection.Connect()
        Dim cmd As New MySqlCommand("DELETE FROM `purchase_orders` WHERE `id` = @id", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@id", ID)

        Dim i = cmd.ExecuteNonQuery
        Connection.Disconnect()
        If i > 0 Then
            Return True
        End If

        Return False
    End Function

End Module
