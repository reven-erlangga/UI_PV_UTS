Imports MySql.Data.MySqlClient

Public Class Attendance
    Public Property ID As Integer
    Public Property AttendStart As TimeSpan
    Public Property AttendEnd As TimeSpan?
    Public Property EmployeeName As String
    Public Property Status As String

End Class

Module AttendanceDB
    Function Insert(EmployeeID As Integer) As Boolean
        Connection.Connect()
        Dim cmd As New MySqlCommand("INSERT INTO `attendances` (`employee_id`, `date`, `start`, `status`) VALUES (@employee_id, @date, @start, @status)", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@employee_id", EmployeeID)
        cmd.Parameters.AddWithValue("@date", DateTime.Now)
        cmd.Parameters.AddWithValue("@start", DateTime.Now.ToString("HH:mm:ss"))
        cmd.Parameters.AddWithValue("@status", "IN")

        Dim i = cmd.ExecuteNonQuery
        Connection.Disconnect()
        If i > 0 Then
            Return True
        End If

        Return False
    End Function

    Function Out(ID As Integer) As Boolean
        Connection.Connect()
        Dim cmd As New MySqlCommand("UPDATE `attendances` SET `end` = @end, `status` = @status WHERE `id` = @id", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@id", ID)
        cmd.Parameters.AddWithValue("@end", DateTime.Now.ToString("HH:mm:ss"))
        cmd.Parameters.AddWithValue("@status", "OUT")

        Dim i = cmd.ExecuteNonQuery
        Connection.Disconnect()
        If i > 0 Then
            Return True
        End If

        Return False
    End Function

    Function FindByDate(EmployeeID As Integer, AttendDate As Date) As Attendance
        Connection.Connect()

        Dim cmd As New MySqlCommand("SELECT * FROM `attendances` WHERE `employee_id` = @employee_id AND `date` = @date LIMIT 1", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@employee_id", EmployeeID)
        cmd.Parameters.AddWithValue("@date", AttendDate.ToString("yyyy-MM-dd"))

        Dim reader = cmd.ExecuteReader()
        If (reader.Read()) Then

            Dim attendance As New Attendance

            attendance.ID = reader("id")
            attendance.AttendStart = reader("start")
            attendance.Status = reader("status")

            Connection.Disconnect()

            Return attendance
        End If

        Connection.Disconnect()

        Return Nothing
    End Function

    Function ListToday() As List(Of Attendance)
        Connection.Connect()

        Dim cmd As New MySqlCommand("SELECT attendances.id as id, attendances.start as start, attendances.end as end, employees.name as employee_name, attendances.status as status FROM `attendances` INNER JOIN `employees` ON `attendances`.employee_id=`employees`.id", Connection.conn)

        Dim attendances As New List(Of Attendance)
        Dim reader = cmd.ExecuteReader
        While reader.Read
            Dim attendance As New Attendance

            Dim attendEnd As TimeSpan
            If reader.IsDBNull(2) Then
                attendEnd = Nothing
            Else
                attendEnd = reader.Item("end")
            End If

            attendance.ID = reader.Item("id")
            attendance.AttendStart = reader.Item("start")
            attendance.AttendEnd = attendEnd
            attendance.EmployeeName = reader.Item("employee_name")
            attendance.Status = reader.Item("status")

            attendances.Add(attendance)
        End While
        reader.Dispose()

        Connection.Disconnect()

        If attendances.Count() > 0 Then
            Return attendances
        End If

        Return Nothing
    End Function
End Module
