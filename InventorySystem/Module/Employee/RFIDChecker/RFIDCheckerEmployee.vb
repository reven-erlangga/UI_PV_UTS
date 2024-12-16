Public Class RFIDCheckerEmployee
    Private IsHaveData As Boolean

    Private RFIDValue As String

    Private Sub RFIDCheckerEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearData()
    End Sub

    Private Sub RFIDCheckerEmployee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If IsHaveData Then
            Return
        End If

        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)) Then
            MPS_FetchData.Visible = True

            Dim employee = EmployeeDB.FindByRFID(RFIDValue)

            If employee IsNot Nothing Then
                SetDate(employee)
            End If

            RFIDValue = Nothing
            MPS_FetchData.Visible = False
        Else
            RFIDValue += e.KeyChar
        End If
    End Sub

    Private Sub SetDate(Employee As EmployeeModel)
        IsHaveData = True

        ML_Information1.Visible = False
        ML_Information2.Visible = True
        MLI_ResetRFID.Visible = True

        ML_VName.Text = Employee.Name
        ML_VNIK.Text = ""
        ML_VGender.Text = ""
        ML_VDepartment.Text = ""
        ML_VDivision.Text = ""
    End Sub

    Private Sub ClearData()
        IsHaveData = False

        ML_Information1.Visible = True
        ML_Information2.Visible = False
        MLI_ResetRFID.Visible = False

        PB_EmployeePicture.Load("https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_640.png")
        ML_VName.Text = ""
        ML_VNIK.Text = ""
        ML_VGender.Text = ""
        ML_VDepartment.Text = ""
        ML_VDivision.Text = ""
    End Sub

    Private Sub MLI_ResetRFID_Click(sender As Object, e As EventArgs) Handles MLI_ResetRFID.Click
        ClearData()
    End Sub
End Class