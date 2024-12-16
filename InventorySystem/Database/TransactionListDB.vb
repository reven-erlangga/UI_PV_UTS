Imports MySql.Data.MySqlClient

Public Class TransactionListModel
    Public Property ID As Integer
    Public Property ProductID As Integer
    Public Property Qty As Integer
    Public Property Price As Double
    Public Property Transaction As TransactionModel
    Public Property Name As String
    Public Property Description As String

End Class

Module TransactionListDB
    Function FetchByTransactionID(TransactionID As Integer) As List(Of TransactionListModel)
        Connection.Connect()

        Dim transactionLists As New List(Of TransactionListModel)
        Dim cmd As New MySqlCommand("SELECT * FROM `transaction_lists` where `transaction_id` = @transaction_id;", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@transaction_id", TransactionID)

        Dim reader = cmd.ExecuteReader()
        While reader.Read
            Dim transactionList As New TransactionListModel

            transactionList.ID = reader.Item("id")
            transactionList.ProductID = reader.Item("product_id")
            transactionList.Qty = reader.Item("qty")
            transactionList.Price = reader.Item("price")

            transactionLists.Add(transactionList)
        End While
        reader.Dispose()

        Connection.Disconnect()

        If transactionLists Is Nothing Then
            Return Nothing
        End If

        If transactionLists.Count() > 0 Then
            Return transactionLists
        End If

        Return Nothing
    End Function
End Module
