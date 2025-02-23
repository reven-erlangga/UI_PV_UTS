Imports MySql.Data.MySqlClient

Public Class AttendanceChart
    Public Property Department As String
    Public Property TotalAttendance As Integer
    Public Property AttendanceDate As Date

End Class

' While Loop
' Function
Module AttendanceChartDB
    Function ChartByDepartment(FromDate As Date, ToDate As Date) As List(Of AttendanceChart)
        Dim attendanceCharts As New List(Of AttendanceChart)

        Connection.Connect()
        Dim cmd As New MySqlCommand("SELECT * FROM `attendance_charts` WHERE `date` >= @from_date AND `date` <= @to_date", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@from_date", FromDate)
        cmd.Parameters.AddWithValue("@to_date", ToDate)
        Dim reader = cmd.ExecuteReader
        While reader.Read
            Dim attendanceChart As New AttendanceChart

            attendanceChart.Department = reader.Item("name")
            attendanceChart.TotalAttendance = reader.Item("total_attendance")
            attendanceChart.AttendanceDate = reader.Item("date")

            attendanceCharts.Add(attendanceChart)
        End While

        reader.Dispose()

        Connection.Disconnect()

        If attendanceCharts.Count() > 0 Then
            Return attendanceCharts
        End If

        Return Nothing

    End Function
End Module
