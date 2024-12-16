Public Class OverviewProduct
    Dim SelectedID As Integer
    Private Sub OverviewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim QueryProductCategory = ProductCategoryDB.Fetch()

        If QueryProductCategory IsNot Nothing Then
            For Each QueryDivision In QueryProductCategory
                MCB_VCategory.Items.Add(New MyListItem(QueryDivision.Name, QueryDivision.ID))
            Next
        End If

        DGV_Load()
    End Sub
    Private Sub DGV_Load()
        Try
            DGV.Rows.Clear()

            Dim products = ProductDB.Fetch()

            If products IsNot Nothing Then
                For Each division In products
                    DGV.Rows.Add(division.ID, division.Name, division.Description, division.Price)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Disconnect()
        End Try
    End Sub

    Private Sub MB_Save_Click(sender As Object, e As EventArgs) Handles MB_Save.Click
        Try
            Dim ID = MTB_VID.Text
            Dim Name = MTB_VName.Text
            Dim Description = MTB_VDescription.Text
            Dim price = MTB_VPrice.Text
            Dim ProductCategory As MyListItem = CType(MCB_VCategory.SelectedItem, MyListItem)
            Dim ProductCategoryID As Integer = Convert.ToInt32(ProductCategory.Value)

            Dim ProductModel As New ProductModel()

            ProductModel.Name = Name
            ProductModel.Description = Description
            ProductModel.ProductCategoryID = ProductCategoryID
            ProductModel.Price = price

            Dim product = ProductDB.Insert(ProductModel)

            If product Then
                MsgBox("Success create data")
            End If

            Clear_Date()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Clear_Date()
        MTB_VID.Text = ""
        MTB_VName.Text = ""
        MTB_VDescription.Text = ""

        MB_Save.Text = "Save"
        MB_Delete.Visible = False

        DGV_Load()
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGV.Rows(e.RowIndex)

            SelectedID = Convert.ToInt32(selectedRow.Cells("C_ID").Value)
            MTB_VName.Text = selectedRow.Cells("C_Name").Value
            MTB_VDescription.Text = selectedRow.Cells("C_Description").Value
            MTB_VPrice.Text = selectedRow.Cells("C_Price").Value

            MB_Delete.Visible = True
        End If

        'MTB_VID.Text = DGV.CurrentRow.Cells(0).Value
        'MTB_VName.Text = DGV.CurrentRow.Cells(1).Value
        'MTB_VDescription.Text = DGV.CurrentRow.Cells(2).Value
        'MCB_VCategory.SelectedItem = New MyListItem("Sample", 6)

        MB_Save.Text = "Update"
        MB_Delete.Visible = True
    End Sub

    Private Sub MB_Back_Click(sender As Object, e As EventArgs) Handles MB_Back.Click
        Homepage.Show()

        Me.Hide()
    End Sub
End Class