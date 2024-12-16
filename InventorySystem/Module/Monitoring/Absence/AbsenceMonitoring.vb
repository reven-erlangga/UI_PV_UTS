Imports System.IO
Imports System.Drawing.Imaging

Public Class AbsenceMonitoring

    Private Sub HL_RFID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HL_RFID.KeyPress
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)) Then
            Dim employee = EmployeeDB.FindByRFID(HL_RFID.Text)
            HL_RFID.Text = ""

            MPS_Loading.Show()

            If employee IsNot Nothing Then
                Data_Set(employee)

                Dim attendance = AttendanceDB.FindByDate(employee.ID, Date.Now())

                If (attendance IsNot Nothing) Then
                    If attendance.Status = "OUT" Then
                        AbsenceNotFoundDialog.ShowDialog()

                        GoTo LineFinish
                    End If
                    AttendanceDB.Out(attendance.ID)
                    HL_VAttendanceTime.Text = "Absence out at " + Date.Now.ToString("HH:m:s")
                Else
                    AttendanceDB.Insert(employee.ID)
                    HL_VAttendanceTime.Text = "Absence in at " + Date.Now.ToString("HH:m:s")
                End If
            End If

LineFinish:

            MPS_Loading.Hide()
        Else
            HL_RFID.Text += e.KeyChar
        End If
    End Sub

    Private Sub AbsenceMonitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Data_Clear()
    End Sub

    Private Sub Data_Clear()
        ML_VName.Text = "-"
        ML_VNIK.Text = "-"
        ML_VGender.Text = "-"
        ML_VDepartment.Text = "-"
        ML_VDivision.Text = "-"
        HL_VAttendanceTime.Text = ""

        PB_EmployeePicture.Image = My.Resources.profile_dummy

        T_AutoClear.Enabled = False
    End Sub

    Private Sub Data_Set(Employee As EmployeeModel)
        If Employee.Image IsNot Nothing Then
            PB_EmployeePicture.Image = Base64ToImage(Employee.Image)
        End If

        ML_VName.Text = Employee.Name
        ML_VNIK.Text = Employee.NIK
        ML_VGender.Text = Employee.Gender
        ML_VDepartment.Text = Employee.Department.Name
        ML_VDivision.Text = Employee.Division.Name

        T_AutoClear.Enabled = True
    End Sub

    Private Sub T_AutoClear_Tick(sender As Object, e As EventArgs) Handles T_AutoClear.Tick
        Data_Clear()
    End Sub

    Public Function Base64ToImage(ByVal base64string As String) As Image
        Dim imageBytes As Byte() = Convert.FromBase64String(base64string)
        Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
        Dim temp As Image = Image.FromStream(ms, True)

        Return temp
    End Function
End Class