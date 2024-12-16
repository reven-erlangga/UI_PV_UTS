Imports MySql.Data.MySqlClient

Public Class Division
    Public Property ID As Integer

    Public Property Name As String

    Public Property Description As String

End Class

Module DivisionDB
    Function Fetch() As List(Of Division)
        Connection.Connect()

        Dim divisions As New List(Of Division)
        Dim cmd As New MySqlCommand("SELECT * FROM `divisions`", Connection.conn)

        Dim reader = cmd.ExecuteReader()
        While reader.Read
            Dim division As New Division

            division.ID = reader.Item("id")
            division.Name = reader.Item("name")
            division.Description = reader.Item("description")

            divisions.Add(division)
        End While
        reader.Dispose()

        Connection.Disconnect()

        If divisions Is Nothing Then
            Return Nothing
        End If

        If divisions.Count() > 0 Then
            Return divisions
        End If

        Return Nothing
    End Function


    Function FindByID(ID As Integer) As Division
        Connection.Connect()

        Dim cmd As New MySqlCommand("SELECT * FROM `attendances` WHERE `id` = @id LIMIT 1", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@id", ID)

        Dim reader = cmd.ExecuteReader()
        If (reader.Read()) Then

            Dim division As New Division

            division.ID = reader("id")
            division.Name = reader("name")
            division.Description = reader("description")

            Connection.Disconnect()

            Return division
        End If

        Connection.Disconnect()

        Return Nothing
    End Function

    Function Insert(Name As String, Description As String) As Boolean
        Connection.Connect()
        Dim cmd As New MySqlCommand("INSERT INTO `divisions` (`name`, `description`) VALUES (@name, @description)", Connection.conn)

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
        Dim cmd As New MySqlCommand("UPDATE `divisions` SET `name` = @name, `description` = @description WHERE `id` = @id", Connection.conn)

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
        Dim cmd As New MySqlCommand("DELETE FROM `divisions` WHERE `id` = @id", Connection.conn)

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
