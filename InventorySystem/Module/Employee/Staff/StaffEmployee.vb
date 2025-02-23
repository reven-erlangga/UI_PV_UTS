Imports System.IO
Imports System.Drawing.Imaging

Public Class StaffEmployee
    Dim IsRFIDScan As Boolean
    Dim RFID As String
    Dim EncodeType As ImageFormat = ImageFormat.Jpeg
    Dim EncodeTypeString As String = String.Empty

    Private Sub StaffEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsRFIDScan = False

        Dim QueryDepartments = DepartmentDB.Fetch()

        If QueryDepartments IsNot Nothing Then
            For Each QueryDepartment In QueryDepartments
                MCB_VDept.Items.Add(New MyListItem(QueryDepartment.Name, QueryDepartment.ID))
            Next
        End If

        Dim QueryDivisions = DivisionDB.Fetch()

        If QueryDivisions IsNot Nothing Then
            For Each QueryDivision In QueryDivisions
                MCB_VDivision.Items.Add(New MyListItem(QueryDivision.Name, QueryDivision.ID))
            Next
        End If
    End Sub

    Private Sub MB_ChangeRFIDScan_Click(sender As Object, e As EventArgs) Handles MB_ChangeRFIDScan.Click
        ChangeScanValue(IsRFIDScan)

        If IsRFIDScan Then
            MB_ChangeRFIDScan.Text = "Insert RFID"
        Else
            MB_ChangeRFIDScan.Text = "Stop Scanning"
            RFID = ""
        End If

        HL_RFID.Select()
    End Sub

    ' ByRef
    Private Sub ChangeScanValue(ByRef status As Boolean)
        status = Not status
    End Sub

    Private Sub HL_RFID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HL_RFID.KeyPress

        If IsRFIDScan Then
            If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)) Then
                PB_RFID.Load("https://quickchart.io/barcode?type=code128&text=" + RFID)

                MB_ChangeRFIDScan.Text = "Insert RFID"
            Else
                RFID += e.KeyChar
            End If
        End If
    End Sub

    Private Sub PB_Profile_Click(sender As Object, e As EventArgs) Handles PB_Profile.Click
        Dim newOpenFileDial As New OpenFileDialog
        newOpenFileDial.Filter = "Images(*.jpg; *.png) | *.jpg; *.png"

        If newOpenFileDial.ShowDialog = Windows.Forms.DialogResult.OK Then
            PB_Profile.ImageLocation = newOpenFileDial.FileName
        End If
    End Sub

    Private Sub MB_Save_Click(sender As Object, e As EventArgs) Handles MB_Save.Click
        Dim encodingTypeString As String = String.Empty
        If PB_Profile.ImageLocation.ToLower.EndsWith(".jpg") Then
            EncodeType = ImageFormat.Jpeg
            EncodeTypeString = "data:image/jpeg;base64,"
        Else
            EncodeType = ImageFormat.Png
            EncodeTypeString = "data:image/png;base64,"
        End If

        Dim dItem As MyListItem = CType(MCB_VDept.SelectedItem, MyListItem)
        Dim divisionItem As MyListItem = CType(MCB_VDivision.SelectedItem, MyListItem)

        EmployeeDB.Insert(MTB_VNIK.Text, MTB_VName.Text, RFID, MCB_VGender.Text, dItem.Value, divisionItem.Value, encodingTypeString & ImageToBase64(PB_Profile.Image, EncodeType))
    End Sub

    Public Function ImageToBase64(ByVal image As Image, ByVal format As ImageFormat) As String
        Using ms As New MemoryStream()
            image.Save(ms, format)
            Dim imageBytes As Byte() = ms.ToArray()
            Dim base64String As String = Convert.ToBase64String(imageBytes)

            Return base64String
        End Using
    End Function

    Private Sub MB_Back_Click(sender As Object, e As EventArgs) Handles MB_Back.Click
        Homepage.Show()

        Me.Hide()
    End Sub
End Class