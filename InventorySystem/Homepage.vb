Imports System.Windows.Forms.DataVisualization.Charting

Public Class Homepage

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MT_Clock.Text = DateTime.Now().ToString("dd MMM yyyy")

        ' Contoh penggunaan My.Application
        Console.WriteLine("Nama Aplikasi: " & My.Application.Info.Title)

        ' Contoh penggunaan My.Computer.FileSystem
        If Not My.Computer.FileSystem.DirectoryExists("C:\Temp") Then
            My.Computer.FileSystem.CreateDirectory("C:\Temp")
        End If

        ' Contoh penggunaan My.Settings
        My.Settings.Reload()
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
        Select Case MTC_TabControl.SelectedTab.Name
            Case "MTP_Product"
                Dim QueryProducts = ProductDB.Fetch()
                If QueryProducts IsNot Nothing Then
                    MT_TotalProduct.Text = QueryProducts.Count().ToString() + " Products"
                End If

            Case "MTP_Employee"
                Dim employees = EmployeeDB.Fetch()
                If employees IsNot Nothing Then
                    MT_TotalEmployee.Text = employees.Count().ToString() + " Employees"
                End If

            Case "MTP_Transaction"
                Dim TotalTransaction = TransactionDB.TotalTransaction()
                Dim TotalCustomer = TransactionDB.TotalCustomer()

                MT_TotalTransaction.Text = TotalTransaction.ToString() + " Transactions"
                MT_TotalCustomer.Text = TotalCustomer.ToString() + " Customers"

            Case "MTP_PO"
                Dim QueryPO = PurchaseOrderDB.TotalPO()
                Dim TotalProgressPO = PurchaseOrderDB.TotalPOByStatus("Progress")
                Dim TotalCompletedPO = PurchaseOrderDB.TotalPOByStatus("Completed")

                MT_TotalPO.Text = QueryPO.ToString() + " Purchase Orders"
                MT_TotalPOProgress.Text = TotalProgressPO.ToString() + " Purchase Orders Progress"
                MT_TotalPOCompleted.Text = TotalCompletedPO.ToString() + " Purchase Orders Completed"
        End Select

    End Sub

    Public Sub DrawPieChart(ByVal percents() As Integer, ByVal colors() As Color,
ByVal surface As Graphics, ByVal location As Point, ByVal pieSize As Size, ByRef total As Integer)

        total = 0
        For Each percent As Integer In percents
            total += percent
        Next

        Dim percentTotal As Integer = 0
        For percent As Integer = 0 To percents.Length() - 1
            surface.FillPie(
        New SolidBrush(colors(percent)),
        New Rectangle(location, pieSize), CType(percentTotal * 360 / 100, Single),
        CType(percents(percent) * 360 / 100, Single))
            percentTotal += percents(percent)
        Next
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
