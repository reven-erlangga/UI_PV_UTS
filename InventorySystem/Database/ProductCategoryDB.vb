Imports MySql.Data.MySqlClient

Public Class ProductCategoryModel
    Public Property ID As Integer
    Public Property Name As String
    Public Property Description As String
    Public Property Product As ProductModel

End Class

Module ProductCategoryDB
    Function Fetch() As List(Of ProductCategoryModel)
        Connection.Connect()

        Dim productCategories As New List(Of ProductCategoryModel)
        Dim cmd As New MySqlCommand("SELECT * FROM `product_categories`", Connection.conn)

        Dim reader = cmd.ExecuteReader()
        While reader.Read
            Dim productCategory As New ProductCategoryModel

            productCategory.ID = reader.Item("id")
            productCategory.Name = reader.Item("name")
            productCategory.Description = reader.Item("description")

            productCategories.Add(productCategory)
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


    Function FindByID(ID As Integer) As ProductCategoryModel
        Connection.Connect()

        Dim cmd As New MySqlCommand("SELECT * FROM `product_categories` WHERE `id` = @id LIMIT 1", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@id", ID)

        Dim reader = cmd.ExecuteReader()
        If (reader.Read()) Then

            Dim productCategory As New ProductCategoryModel

            productCategory.ID = reader("id")
            productCategory.Name = reader("name")
            productCategory.Description = reader("description")

            Connection.Disconnect()

            Return productCategory
        End If

        Connection.Disconnect()

        Return Nothing
    End Function

    Function Insert(Name As String, Description As String) As Boolean
        Connection.Connect()
        Dim cmd As New MySqlCommand("INSERT INTO `product_categories` (`name`, `description`) VALUES (@name, @description)", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@name", Name)
        cmd.Parameters.AddWithValue("@description", Description)

        Dim i = cmd.ExecuteNonQuery
        Connection.Disconnect()
        If i > 0 Then
            Return True
        End If

        Return False
    End Function

    Function Update(ID As Integer, Name As String, Description As String) As Boolean
        Connection.Connect()
        Dim cmd As New MySqlCommand("UPDATE `product_categories` SET `name` = @name, `description` = @description WHERE `id` = @id", Connection.conn)

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
        Dim cmd As New MySqlCommand("DELETE FROM `product_categories` WHERE `id` = @id", Connection.conn)

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
