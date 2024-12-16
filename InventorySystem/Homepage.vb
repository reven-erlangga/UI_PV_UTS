Imports System.Windows.Forms.DataVisualization.Charting

Public Class Homepage

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MT_Clock.Text = DateTime.Now().ToString("dd MMM yyyy")

        C_Attendance.Series.Clear()

        Dim attendanceCharts = AttendanceChartDB.ChartByDepartment(Date.Now().AddDays(-7), Date.Now())

        If (attendanceCharts IsNot Nothing) Then
            For Each attendanceChart In attendanceCharts
                If C_Attendance.Series.IsUniqueName(attendanceChart.Department) Then
                    C_Attendance.Series.Add(attendanceChart.Department)
                End If

                C_Attendance.Series(attendanceChart.Department).Points.AddXY(attendanceChart.AttendanceDate.ToString("dd MMM yyyy"), attendanceChart.TotalAttendance)
            Next
        End If
    End Sub

    Private Sub MetroTabPage1_Click(sender As Object, e As EventArgs) Handles MTP_Overview.Click

    End Sub

    Private Sub Incoming_Click(sender As Object, e As EventArgs) Handles MT_Department.Click
        DepartmentEmployee.Show()

        Me.Hide()
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MT_Employee.Click
        StaffEmployee.Show()
        Me.Hide()
    End Sub

    Private Sub MT_AttendanceToday_Click(sender As Object, e As EventArgs) Handles MT_AttendanceToday.Click
        TodayAttendance.Show()

        Me.Hide()
    End Sub

    Private Sub MT_RFIDChecker_Click(sender As Object, e As EventArgs) Handles MT_RFIDChecker.Click
        RFIDCheckerEmployee.Show()
    End Sub

    Private Sub MT_Division_Click(sender As Object, e As EventArgs) Handles MT_Division.Click
        DivisionEmployee.Show()

        Me.Hide()
    End Sub

    Private Sub MTC_TabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTC_TabControl.SelectedIndexChanged
        If MTC_TabControl.SelectedTab Is MTP_Product Then
            Dim QueryProducts = ProductDB.Fetch()

            If QueryProducts IsNot Nothing Then
                MT_TotalProduct.Text = QueryProducts.Count().ToString() + " Products"
            End If

        ElseIf MTC_TabControl.SelectedTab Is MTP_Employee Then
            Dim employees = EmployeeDB.Fetch()

            If employees IsNot Nothing Then
                MT_TotalEmployee.Text = employees.Count().ToString() + " Employees"
            End If

        ElseIf MTC_TabControl.SelectedTab Is MTP_Transaction Then

            Dim TotalTransaction = TransactionDB.TotalTransaction()
            Dim TotalCustomer = TransactionDB.TotalCustomer()

            MT_TotalTransaction.Text = TotalTransaction.ToString() + " Transactions"
            MT_TotalCustomer.Text = TotalCustomer.ToString() + " Customers"

        ElseIf MTC_TabControl.SelectedTab Is MTP_PO Then
            Dim QueryPO = PurchaseOrderDB.TotalPO()
            Dim TotalProgressPO = PurchaseOrderDB.TotalPOByStatus("Progress")
            Dim TotalCompletedPO = PurchaseOrderDB.TotalPOByStatus("Completed")

            MT_TotalPO.Text = QueryPO.ToString() + " Purchase Orders"
            MT_TotalPOProgress.Text = TotalProgressPO.ToString() + " Purchase Orders Progress"
            MT_TotalPOCompleted.Text = TotalCompletedPO.ToString() + " Purchase Orders Completed"
        End If
    End Sub

    Public Sub DrawPieChart(ByVal percents() As Integer, ByVal colors() As Color,
ByVal surface As Graphics, ByVal location As Point, ByVal pieSize As Size)
        Dim sum As Integer = 0
        For Each percent As Integer In percents
            sum += percent
        Next
        Dim percentTotal As Integer = 0
        For percent As Integer = 0 To percents.Length() - 1
            surface.FillPie(
            New SolidBrush(colors(percent)),
            New Rectangle(location, pieSize), CType(percentTotal * 360 / 100, Single),
            CType(percents(percent) * 360 / 100, Single))
            percentTotal += percents(percent)
        Next
        Return
    End Sub

    Private Sub MetroTile1_Click_1(sender As Object, e As EventArgs) Handles MT_Product.Click
        OverviewProduct.Show()
        Me.Hide()
    End Sub

    Private Sub MetroTile11_Click(sender As Object, e As EventArgs) Handles MetroTile11.Click
        OverviewPurchaseOrder.Show()

        Me.Hide()
    End Sub

    Private Sub MT_Incoming_Click(sender As Object, e As EventArgs) Handles MT_Incoming.Click
        IncomingPurchaseOrder.Show()

        Me.Hide()
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        ProductCategory.Show()

        Me.Hide()
    End Sub
End Class
