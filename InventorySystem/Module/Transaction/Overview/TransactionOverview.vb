Public Class TransactionOverview
    Private Sub TransactionOverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TransactionData_Load()
    End Sub

    Private Function TransactionData_Load()
        Try
            DGV_Transaction.Rows.Clear()

            Dim transactions = TransactionDB.Fetch()

            If transactions IsNot Nothing Then
                For Each transaction In transactions
                    DGV_Transaction.Rows.Add(transaction.ID, transaction.InvoiceNumber, transaction.CustName, transaction.Note, transaction.GrandTotal)

                    Dim transactionLists = TransactionListDB.FetchByTransactionID(transaction.ID)

                    If transactionLists IsNot Nothing Then
                        DGV_Transaction.Rows.Add("", "", "Product Name", "Qty", "Price")

                        Dim tableNumber = 1
                        Dim totalPrice = 0

                        For Each transactionList In transactionLists
                            Dim product = ProductDB.FindByID(transactionList.ProductID)

                            DGV_Transaction.Rows.Add("", "(" + tableNumber.ToString() + ")", product.Name, transactionList.Qty, transactionList.Price)

                            tableNumber += 1
                        Next

                        DGV_Transaction.Rows.Add("Total Price", "", "", "")
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Function

    Private Sub MB_Order_Click(sender As Object, e As EventArgs) Handles MB_Order.Click
        OrderTransaction.Show()

        Me.Hide()
    End Sub
End Class