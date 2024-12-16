Imports MySql.Data.MySqlClient

Public Class ProductModel
    Public Property ID As Integer
    Public Property Name As String
    Public Property Description As String
    Public Property Price As Double
    Public Property Qty As Integer
    Public Property ProductCategoryID As Integer
    Public Property ProductCategory As ProductCategoryModel

End Class
Module ProductDB
    Function Fetch() As List(Of ProductModel)
        Connection.Connect()

        Dim products As New List(Of ProductModel)
        Dim cmd As New MySqlCommand("SELECT * FROM `products`", Connection.conn)

        Dim reader = cmd.ExecuteReader()
        While reader.Read
            Dim product As New ProductModel

            product.ID = reader.Item("id")
            product.Name = reader.Item("name")
            product.Description = reader.Item("description")
            product.Price = reader.Item("price")

            products.Add(product)
        End While
        reader.Dispose()

        Connection.Disconnect()

        If products Is Nothing Then
            Return Nothing
        End If

        If products.Count() > 0 Then
            Return products
        End If

        Return Nothing
    End Function

    Function TotalByProductCategory(ProductCategoryID As Integer) As Integer
        Connection.Connect()

        Dim cmd As New MySqlCommand("SELECT * FROM `products` WHERE `product_category_id` = @product_category_id", Connection.conn)
        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@product_category_id", ProductCategoryID)

        Dim i As Integer = cmd.ExecuteScalar()

        Connection.Disconnect()

        Return i
    End Function


    Function FindByID(ID As Integer) As ProductModel
        Connection.Connect()

        Dim cmd As New MySqlCommand("SELECT * FROM `products` WHERE `id` = @id LIMIT 1", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@id", ID)

        Dim reader = cmd.ExecuteReader()
        If (reader.Read()) Then

            Dim product As New ProductModel

            product.ID = reader("id")
            product.Name = reader("name")
            product.Description = reader("description")
            product.Price = reader("price")

            Connection.Disconnect()

            Return product
        End If

        Connection.Disconnect()

        Return Nothing
    End Function

    Function Insert(ProductModel As ProductModel) As Boolean
        Connection.Connect()

        Dim cmd As New MySqlCommand("INSERT INTO `products` (`product_category_id`, `name`, `description`, `price`) VALUES (@product_category_id, @name, @description, @price);", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@product_category_id", ProductModel.ProductCategoryID)
        cmd.Parameters.AddWithValue("@name", ProductModel.Name)
        cmd.Parameters.AddWithValue("@description", ProductModel.Description)
        cmd.Parameters.AddWithValue("@price", ProductModel.Price)

        Dim i = cmd.ExecuteNonQuery
        Connection.Disconnect()
        If i > 0 Then
            Return True
        End If

        Return False
    End Function

    Function Update(ID As Integer, Name As String, Description As String) As Boolean
        Connection.Connect()
        Dim cmd As New MySqlCommand("UPDATE `products` SET `name` = @name, `description` = @description WHERE `id` = @id", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@id", ID)
        cmd.Parameters.AddWithValue("@name", Name)
        cmd.Parameters.AddWithValue("@description", Description)

        Dim i = cmd.ExecuteNonQuery
        Connection.Disconnect()
        If i > 0 Then
            Return True
        End If

        Return False
    End Function

    Function Delete(ID As Integer) As Boolean
        Connection.Connect()
        Dim cmd As New MySqlCommand("DELETE FROM `products` WHERE `id` = @id", Connection.conn)

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
