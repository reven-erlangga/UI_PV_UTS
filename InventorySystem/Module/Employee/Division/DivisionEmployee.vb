Public Class DivisionEmployee
    Dim SelectedID As Integer

    Private Sub DivisionEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_Load()
    End Sub
    Private Sub DGV_Load()
        Try
            DGV.Rows.Clear()

            Dim divisions = DivisionDB.Fetch()

            If divisions IsNot Nothing Then
                For Each division In divisions
                    DGV.Rows.Add(division.ID, division.Name, division.Description)
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
            Dim Name = MTB_VName.Text
            Dim Description = MTB_VDescription.Text

            If SelectedID Then
                Dim division = DivisionDB.Update(SelectedID, Name, Description)

                If division Then
                    MsgBox("Success update data")

                End If
            Else
                Dim division = DivisionDB.Insert(Name, Description)

                If division Then
                    MsgBox("Success create data")

                End If
            End If

            Clear_Date()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Clear_Date()
        SelectedID = Nothing
        MTB_VName.Text = ""
        MTB_VDescription.Text = ""

        MB_Save.Text = "Save"
        MB_Delete.Visible = False

        DGV_Load()
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        SelectedID = DGV.CurrentRow.Cells(0).Value
        MTB_VName.Text = DGV.CurrentRow.Cells(1).Value
        MTB_VDescription.Text = DGV.CurrentRow.Cells(2).Value

        MB_Save.Text = "Update"
        MB_Delete.Visible = True
    End Sub

    Private Sub MB_Delete_Click(sender As Object, e As EventArgs) Handles MB_Delete.Click
        Try
            Dim ID = SelectedID
            Dim division = DivisionDB.Delete(ID)

            If division Then
                MsgBox("Delete success")
            End If

            Clear_Date()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MB_Back_Click(sender As Object, e As EventArgs) Handles MB_Back.Click
        Homepage.Show()

        Me.Hide()
    End Sub

    Private Sub MB_Clear_Click(sender As Object, e As EventArgs) Handles MB_Clear.Click
        Clear_Date()
    End Sub
End Class