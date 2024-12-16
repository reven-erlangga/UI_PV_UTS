Imports MySql.Data.MySqlClient

Module Connection
    Public conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=db_inventory")

    Sub Connect()
        conn.Open()
    End Sub

    Sub Disconnect()
        conn.Close()
    End Sub
End Module
