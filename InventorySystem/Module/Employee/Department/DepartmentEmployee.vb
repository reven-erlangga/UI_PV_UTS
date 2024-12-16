Public Class DepartmentEmployee
    Dim SelectedID As Integer

    Private Sub DepartmentEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_Load()
    End Sub

    Private Sub DGV_Load()
        Try
            DGV_Employee.Rows.Clear()

            Dim departments = DepartmentDB.Fetch()

            If departments IsNot Nothing Then
                For Each department In departments
                    DGV_Employee.Rows.Add(department.ID, department.Name)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Disconnect()
        End Try
    End Sub

    Private Sub MB_Save_Click(sender As Object, e As EventArgs) Handles MB_Save.Click
        Try
            Dim ID = SelectedID
            Dim Name = MTB_VName.Text

            If ID Then
                Dim departmentModel As New DepartmentModel()

                departmentModel.ID = ID
                departmentModel.Name = Name

                Dim department = DepartmentDB.Update(departmentModel)

                If department Then
                    MsgBox("Success update data")

                End If
            Else
                Dim departmentModel As New DepartmentModel()

                departmentModel.Name = Name

                Dim department = DepartmentDB.Insert(departmentModel)

                If department Then
                    MsgBox("Success create data")
                End If
            End If

            Clear_Data()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Clear_Data()
        SelectedID = Nothing
        MTB_VName.Text = ""

        MB_Delete.Visible = False

        DGV_Load()
    End Sub

    Private Sub DGV_Employee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Employee.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGV_Employee.Rows(e.RowIndex)

            SelectedID = Convert.ToInt32(selectedRow.Cells("C_ID").Value)
            MTB_VName.Text = selectedRow.Cells("C_Name").Value

            MB_Delete.Visible = True
        End If
    End Sub

    Private Sub MB_ClearData_Click(sender As Object, e As EventArgs) Handles MB_ClearData.Click
        Clear_Data()
    End Sub

    Private Sub MB_Back_Click(sender As Object, e As EventArgs) Handles MB_Back.Click
        Homepage.Show()

        Me.Hide()
    End Sub

    Private Sub MB_Delete_Click(sender As Object, e As EventArgs) Handles MB_Delete.Click
        Try
            Dim division = DepartmentDB.Delete(SelectedID)

            If division Then
                MsgBox("Delete success")
            End If

            Clear_Data()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class