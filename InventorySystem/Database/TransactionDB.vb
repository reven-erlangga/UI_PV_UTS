Imports MySql.Data.MySqlClient

Public Class TransactionModel
    Public Property ID As Integer
    Public Property InvoiceNumber As String
    Public Property CustName As String
    Public Property Note As String
    Public Property GrandTotal As Double
    Public Property TransactionLists As List(Of TransactionListModel)

End Class

Module TransactionDB
    Function Fetch() As List(Of TransactionModel)
        Connection.Connect()

        Dim productCategories As New List(Of TransactionModel)
        Dim cmd As New MySqlCommand("SELECT * FROM `transactions`;", Connection.conn)

        Dim reader = cmd.ExecuteReader()
        While reader.Read
            Dim transaction As New TransactionModel

            transaction.ID = reader.Item("id")
            transaction.InvoiceNumber = reader.Item("invoice_number")
            transaction.CustName = reader.Item("cust_name")
            transaction.GrandTotal = reader.Item("grand_total")

            productCategories.Add(transaction)
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
    Function TotalTransaction() As Integer
        Connection.Connect()

        Dim cmd As New MySqlCommand("SELECT * FROM `transactions`", Connection.conn)

        Dim i As Integer = cmd.ExecuteScalar()

        Connection.Disconnect()

        Return i
    End Function
    Function TotalCustomer() As Integer
        Connection.Connect()

        Dim cmd As New MySqlCommand("SELECT * FROM `transactions` GROUP BY `cust_name`", Connection.conn)

        Dim i As Integer = cmd.ExecuteScalar()

        Connection.Disconnect()

        Return i
    End Function


    Function FindByID(ID As Integer) As TransactionModel
        Connection.Connect()

        Dim cmd As New MySqlCommand("SELECT * FROM `transactions` WHERE `id` = @id LIMIT 1", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@id", ID)

        Dim reader = cmd.ExecuteReader()
        If (reader.Read()) Then

            Dim transaction As New TransactionModel

            transaction.ID = reader("id")
            transaction.InvoiceNumber = reader("invoice_number")
            transaction.CustName = reader("cust_name")

            Connection.Disconnect()

            Return transaction
        End If

        Connection.Disconnect()

        Return Nothing
    End Function

    Function MakeInvoiceNumber() As String
        Connection.Connect()

        Dim cmd As New MySqlCommand("SELECT * FROM `transactions` ORDER BY `id` DESC LIMIT 1", Connection.conn)

        cmd.Parameters.Clear()

        Dim reader = cmd.ExecuteReader()
        If (reader.Read()) Then
            Dim generate As Generate = New Generate()
            Dim purchaseOrderNumber = reader("invoice_number")

            Connection.Disconnect()

            Return generate.InvoiceNumber(purchaseOrderNumber)
        End If

        Connection.Disconnect()

        Return Nothing
    End Function

    Function Insert(TransactionModel As TransactionModel) As Boolean
        Dim invoiceNumber As String

        invoiceNumber = MakeInvoiceNumber()

        Connection.Connect()

        Dim cmd As New MySqlCommand("INSERT INTO `transactions` (`invoice_number`, `cust_name`, `grand_total`) VALUES (@name, @cust_name, @grand_total)", Connection.conn)

        cmd.Parameters.Clear()

        Dim generate As Generate = New Generate()
        cmd.Parameters.AddWithValue("@name", invoiceNumber)
        cmd.Parameters.AddWithValue("@cust_name", TransactionModel.CustName)
        cmd.Parameters.AddWithValue("@grand_total", TransactionModel.GrandTotal)

        Dim i = cmd.ExecuteNonQuery

        If i > 0 Then
            Dim lastInsertId As Long = cmd.LastInsertedId

            For Each item As TransactionListModel In TransactionModel.TransactionLists
                Dim itemCmd As New MySqlCommand("INSERT INTO `transaction_lists` (`transaction_id`, `product_id`, `qty`, `price`) VALUES (@transaction_id, @product_id, @qty, @price)", Connection.conn)

                itemCmd.Parameters.Clear()

                itemCmd.Parameters.AddWithValue("@transaction_id", lastInsertId)
                itemCmd.Parameters.AddWithValue("@product_id", item.ProductID)
                itemCmd.Parameters.AddWithValue("@qty", item.Qty)
                itemCmd.Parameters.AddWithValue("@price", item.Price)

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
        Dim cmd As New MySqlCommand("UPDATE `transactions` SET `name` = @name, `description` = @description WHERE `id` = @id", Connection.conn)

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
        Dim cmd As New MySqlCommand("DELETE FROM `transactions` WHERE `id` = @id", Connection.conn)

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
