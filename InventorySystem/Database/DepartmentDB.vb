Imports MySql.Data.MySqlClient

Public Class DepartmentModel
    Public Property ID As Integer
    Public Property Name As String
End Class

Module DepartmentDB
    Function Fetch() As List(Of DepartmentModel)
        Connection.Connect()

        Dim departments As New List(Of DepartmentModel)
        Dim cmd As New MySqlCommand("SELECT * FROM `departments`", Connection.conn)

        Dim reader = cmd.ExecuteReader()
        While reader.Read
            Dim department As New DepartmentModel

            department.ID = reader.Item("id")
            department.Name = reader.Item("name")

            departments.Add(department)
        End While
        reader.Dispose()

        Connection.Disconnect()

        If departments Is Nothing Then
            Return Nothing
        End If

        If departments.Count() > 0 Then
            Return departments
        End If

        Return Nothing
    End Function


    Function FindByID(ID As Integer) As DepartmentModel
        Connection.Connect()

        Dim cmd As New MySqlCommand("SELECT * FROM `attendances` WHERE `id` = @id LIMIT 1", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@id", ID)

        Dim reader = cmd.ExecuteReader()
        If (reader.Read()) Then

            Dim department As New DepartmentModel

            department.ID = reader("id")
            department.Name = reader("name")

            Connection.Disconnect()

            Return department
        End If

        Connection.Disconnect()

        Return Nothing
    End Function

    Function Insert(DepartmentModel As DepartmentModel) As Boolean
        Connection.Connect()
        Dim cmd As New MySqlCommand("INSERT INTO `departments` (`name`) VALUES (@name)", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@name", DepartmentModel.Name)

        Dim i = cmd.ExecuteNonQuery
        Connection.Disconnect()
        If i > 0 Then
            Return True
        End If

        Return False
    End Function

    Function Update(DepartmentModel As DepartmentModel) As Boolean
        Connection.Connect()
        Dim cmd As New MySqlCommand("UPDATE `departments` SET `name` = @name WHERE `id` = @id", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@id", DepartmentModel.ID)
        cmd.Parameters.AddWithValue("@name", DepartmentModel.Name)

        Dim i = cmd.ExecuteNonQuery
        Connection.Disconnect()
        If i > 0 Then
            Return True
        End If

        Return False
    End Function

    Function Delete(ID As Integer) As Boolean
        Connection.Connect()
        Dim cmd As New MySqlCommand("DELETE FROM `departments` WHERE `id` = @id", Connection.conn)

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
