<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AbsenceMonitoring
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.HL_RFID = New MetroFramework.Drawing.Html.HtmlLabel()
        Me.MPS_Loading = New MetroFramework.Controls.MetroProgressSpinner()
        Me.ML_VDivision = New MetroFramework.Controls.MetroLabel()
        Me.ML_VDepartment = New MetroFramework.Controls.MetroLabel()
        Me.ML_VGender = New MetroFramework.Controls.MetroLabel()
        Me.ML_VNIK = New MetroFramework.Controls.MetroLabel()
        Me.ML_VName = New MetroFramework.Controls.MetroLabel()
        Me.ML_TDivison = New MetroFramework.Controls.MetroLabel()
        Me.ML_TDepartment = New MetroFramework.Controls.MetroLabel()
        Me.ML_TGender = New MetroFramework.Controls.MetroLabel()
        Me.ML_TNIK = New MetroFramework.Controls.MetroLabel()
        Me.ML_TName = New MetroFramework.Controls.MetroLabel()
        Me.PB_EmployeePicture = New System.Windows.Forms.PictureBox()
        Me.T_AutoClear = New System.Windows.Forms.Timer(Me.components)
        Me.HL_VAttendanceTime = New MetroFramework.Drawing.Html.HtmlLabel()
        CType(Me.PB_EmployeePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HL_RFID
        '
        Me.HL_RFID.AutoScroll = True
        Me.HL_RFID.AutoScrollMinSize = New System.Drawing.Size(10, 0)
        Me.HL_RFID.AutoSize = False
        Me.HL_RFID.BackColor = System.Drawing.SystemColors.Window
        Me.HL_RFID.Location = New System.Drawing.Point(78, 355)
        Me.HL_RFID.Name = "HL_RFID"
        Me.HL_RFID.Size = New System.Drawing.Size(243, 37)
        Me.HL_RFID.TabIndex = 0
        '
        'MPS_Loading
        '
        Me.MPS_Loading.Location = New System.Drawing.Point(23, 355)
        Me.MPS_Loading.Maximum = 100
        Me.MPS_Loading.Name = "MPS_Loading"
        Me.MPS_Loading.Size = New System.Drawing.Size(37, 37)
        Me.MPS_Loading.Speed = 2.0!
        Me.MPS_Loading.TabIndex = 2
        Me.MPS_Loading.UseSelectable = True
        Me.MPS_Loading.Visible = False
        '
        'ML_VDivision
        '
        Me.ML_VDivision.AutoSize = True
        Me.ML_VDivision.Location = New System.Drawing.Point(276, 229)
        Me.ML_VDivision.Name = "ML_VDivision"
        Me.ML_VDivision.Size = New System.Drawing.Size(53, 19)
        Me.ML_VDivision.TabIndex = 22
        Me.ML_VDivision.Text = "Division"
        '
        'ML_VDepartment
        '
        Me.ML_VDepartment.AutoSize = True
        Me.ML_VDepartment.Location = New System.Drawing.Point(276, 199)
        Me.ML_VDepartment.Name = "ML_VDepartment"
        Me.ML_VDepartment.Size = New System.Drawing.Size(80, 19)
        Me.ML_VDepartment.TabIndex = 21
        Me.ML_VDepartment.Text = "Department"
        '
        'ML_VGender
        '
        Me.ML_VGender.AutoSize = True
        Me.ML_VGender.Location = New System.Drawing.Point(276, 169)
        Me.ML_VGender.Name = "ML_VGender"
        Me.ML_VGender.Size = New System.Drawing.Size(52, 19)
        Me.ML_VGender.TabIndex = 20
        Me.ML_VGender.Text = "Gender"
        '
        'ML_VNIK
        '
        Me.ML_VNIK.AutoSize = True
        Me.ML_VNIK.Location = New System.Drawing.Point(276, 139)
        Me.ML_VNIK.Name = "ML_VNIK"
        Me.ML_VNIK.Size = New System.Drawing.Size(29, 19)
        Me.ML_VNIK.TabIndex = 19
        Me.ML_VNIK.Text = "NIK"
        '
        'ML_VName
        '
        Me.ML_VName.AutoSize = True
        Me.ML_VName.Location = New System.Drawing.Point(276, 109)
        Me.ML_VName.Name = "ML_VName"
        Me.ML_VName.Size = New System.Drawing.Size(45, 19)
        Me.ML_VName.TabIndex = 18
        Me.ML_VName.Text = "Name"
        '
        'ML_TDivison
        '
        Me.ML_TDivison.AutoSize = True
        Me.ML_TDivison.Location = New System.Drawing.Point(177, 229)
        Me.ML_TDivison.Name = "ML_TDivison"
        Me.ML_TDivison.Size = New System.Drawing.Size(53, 19)
        Me.ML_TDivison.TabIndex = 17
        Me.ML_TDivison.Text = "Division"
        '
        'ML_TDepartment
        '
        Me.ML_TDepartment.AutoSize = True
        Me.ML_TDepartment.Location = New System.Drawing.Point(177, 199)
        Me.ML_TDepartment.Name = "ML_TDepartment"
        Me.ML_TDepartment.Size = New System.Drawing.Size(80, 19)
        Me.ML_TDepartment.TabIndex = 16
        Me.ML_TDepartment.Text = "Department"
        '
        'ML_TGender
        '
        Me.ML_TGender.AutoSize = True
        Me.ML_TGender.Location = New System.Drawing.Point(177, 169)
        Me.ML_TGender.Name = "ML_TGender"
        Me.ML_TGender.Size = New System.Drawing.Size(52, 19)
        Me.ML_TGender.TabIndex = 15
        Me.ML_TGender.Text = "Gender"
        '
        'ML_TNIK
        '
        Me.ML_TNIK.AutoSize = True
        Me.ML_TNIK.Location = New System.Drawing.Point(177, 139)
        Me.ML_TNIK.Name = "ML_TNIK"
        Me.ML_TNIK.Size = New System.Drawing.Size(29, 19)
        Me.ML_TNIK.TabIndex = 14
        Me.ML_TNIK.Text = "NIK"
        '
        'ML_TName
        '
        Me.ML_TName.AutoSize = True
        Me.ML_TName.Location = New System.Drawing.Point(177, 109)
        Me.ML_TName.Name = "ML_TName"
        Me.ML_TName.Size = New System.Drawing.Size(45, 19)
        Me.ML_TName.TabIndex = 13
        Me.ML_TName.Text = "Name"
        '
        'PB_EmployeePicture
        '
        Me.PB_EmployeePicture.Image = Global.InventorySystem.My.Resources.Resources.profile_dummy
        Me.PB_EmployeePicture.Location = New System.Drawing.Point(23, 109)
        Me.PB_EmployeePicture.Name = "PB_EmployeePicture"
        Me.PB_EmployeePicture.Size = New System.Drawing.Size(137, 157)
        Me.PB_EmployeePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_EmployeePicture.TabIndex = 12
        Me.PB_EmployeePicture.TabStop = False
        '
        'T_AutoClear
        '
        Me.T_AutoClear.Interval = 1000
        '
        'HL_VAttendanceTime
        '
        Me.HL_VAttendanceTime.AutoScroll = True
        Me.HL_VAttendanceTime.AutoScrollMinSize = New System.Drawing.Size(10, 10)
        Me.HL_VAttendanceTime.AutoSize = False
        Me.HL_VAttendanceTime.BackColor = System.Drawing.SystemColors.Window
        Me.HL_VAttendanceTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HL_VAttendanceTime.Location = New System.Drawing.Point(23, 283)
        Me.HL_VAttendanceTime.Name = "HL_VAttendanceTime"
        Me.HL_VAttendanceTime.Size = New System.Drawing.Size(456, 57)
        Me.HL_VAttendanceTime.TabIndex = 23
        '
        'AbsenceMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 450)
        Me.Controls.Add(Me.HL_VAttendanceTime)
        Me.Controls.Add(Me.MPS_Loading)
        Me.Controls.Add(Me.ML_VDivision)
        Me.Controls.Add(Me.ML_VDepartment)
        Me.Controls.Add(Me.ML_VGender)
        Me.Controls.Add(Me.ML_VNIK)
        Me.Controls.Add(Me.ML_VName)
        Me.Controls.Add(Me.ML_TDivison)
        Me.Controls.Add(Me.ML_TDepartment)
        Me.Controls.Add(Me.ML_TGender)
        Me.Controls.Add(Me.ML_TNIK)
        Me.Controls.Add(Me.ML_TName)
        Me.Controls.Add(Me.PB_EmployeePicture)
        Me.Controls.Add(Me.HL_RFID)
        Me.Name = "AbsenceMonitoring"
        Me.Text = "AbsenceMonitoring"
        CType(Me.PB_EmployeePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HL_RFID As MetroFramework.Drawing.Html.HtmlLabel
    Friend WithEvents MPS_Loading As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents ML_VDivision As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_VDepartment As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_VGender As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_VNIK As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_VName As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_TDivison As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_TDepartment As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_TGender As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_TNIK As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_TName As MetroFramework.Controls.MetroLabel
    Friend WithEvents PB_EmployeePicture As PictureBox
    Friend WithEvents T_AutoClear As Timer
    Friend WithEvents HL_VAttendanceTime As MetroFramework.Drawing.Html.HtmlLabel
End Class
