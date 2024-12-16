Public Class TodayAttendance
    Private Sub TodayAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MPS_FetchTodayAttendance.Visible = True

        DGV_TodayAttendance.Rows.Clear()

        Dim attendances = AttendanceDB.ListToday()

        If attendances IsNot Nothing Then
            For Each attendance In attendances
                DGV_TodayAttendance.Rows.Add(attendance.ID, attendance.EmployeeName, attendance.AttendStart, attendance.AttendEnd, attendance.Status)

                If attendance.Status = "IN" Then
                    DGV_TodayAttendance.Rows(attendances.IndexOf(attendance)).Cells(4).Style.BackColor = Color.Green
                Else
                    DGV_TodayAttendance.Rows(attendances.IndexOf(attendance)).Cells(4).Style.BackColor = Color.Red
                End If
            Next
        End If

        MPS_FetchTodayAttendance.Visible = False
    End Sub

    Private Sub MT_Back_Click(sender As Object, e As EventArgs) Handles MT_Back.Click
        Homepage.Show()

        Me.Close()
    End Sub
End Class