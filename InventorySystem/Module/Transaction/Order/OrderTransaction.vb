Public Class OrderTransaction
    Private Sub OrderTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Product_Dropdown()
    End Sub

    Private Sub Product_Dropdown()
        Try
            Dim divisions = ProductDB.Fetch()

            If divisions IsNot Nothing Then
                For Each division In divisions
                    MCB_Product.Items.Add(New MyListItem(division.Name, division.ID))
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OrderData_Clear()
        DGV_ProductList.Rows.Clear()

        MTB_VCustomerName.Clear()
        MTB_VNote.Clear()
        MTB_Qty.Clear()
    End Sub

    Private Sub MB_AddProduct_Click(sender As Object, e As EventArgs) Handles MB_AddProduct.Click
        Dim productItem As MyListItem = CType(MCB_Product.SelectedItem, MyListItem)

        Dim ProductModel = ProductDB.FindByID(productItem.Value)
        Dim productQty As Integer = MTB_Qty.Text
        Dim Price = ProductModel.Price * productQty

        DGV_ProductList.Rows.Add(productItem.Value, productItem.Text, productQty, Price)

        ML_TotalPrice.Text = Convert.ToDouble(ML_TotalPrice.Text) + Price

        MTB_Qty.Clear()
    End Sub

    Private Sub MB_Order_Click(sender As Object, e As EventArgs) Handles MB_Order.Click
        Dim TransactionModel As New TransactionModel()
        Dim TransactionLists As New List(Of TransactionListModel)()
        Dim grandTotal As String ' Identification String

        grandTotal = Convert.ToDouble(ML_TotalPrice.Text)

        TransactionModel.CustName = MTB_VCustomerName.Text
        TransactionModel.Note = MTB_VNote.Text
        TransactionModel.GrandTotal = grandTotal

        For Each row As DataGridViewRow In DGV_ProductList.Rows
            If Not row.IsNewRow Then
                Dim TransactionListModel As New TransactionListModel()

                Dim ProductID As Integer = Convert.ToInt32(row.Cells("C_ProductID").Value)
                Dim Qty As Integer = Convert.ToInt32(row.Cells("C_Qty").Value)
                Dim Price As Integer = Convert.ToInt32(row.Cells("C_Price").Value)

                TransactionListModel.ProductID = ProductID
                TransactionListModel.Qty = Qty
                TransactionListModel.Price = Price

                TransactionLists.Add(TransactionListModel)
            End If
        Next

        TransactionModel.TransactionLists = TransactionLists

        TransactionDB.Insert(TransactionModel)
    End Sub
End Class