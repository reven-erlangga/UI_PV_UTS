<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RFIDCheckerEmployee
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
        Me.PB_EmployeePicture = New System.Windows.Forms.PictureBox()
        Me.ML_TName = New MetroFramework.Controls.MetroLabel()
        Me.ML_TNIK = New MetroFramework.Controls.MetroLabel()
        Me.ML_TGender = New MetroFramework.Controls.MetroLabel()
        Me.ML_TDepartment = New MetroFramework.Controls.MetroLabel()
        Me.ML_TDivison = New MetroFramework.Controls.MetroLabel()
        Me.ML_Information1 = New MetroFramework.Controls.MetroLabel()
        Me.ML_VDivision = New MetroFramework.Controls.MetroLabel()
        Me.ML_VDepartment = New MetroFramework.Controls.MetroLabel()
        Me.ML_VGender = New MetroFramework.Controls.MetroLabel()
        Me.ML_VNIK = New MetroFramework.Controls.MetroLabel()
        Me.ML_VName = New MetroFramework.Controls.MetroLabel()
        Me.MPS_FetchData = New MetroFramework.Controls.MetroProgressSpinner()
        Me.ML_Information2 = New MetroFramework.Controls.MetroLabel()
        Me.MLI_ResetRFID = New MetroFramework.Controls.MetroLink()
        CType(Me.PB_EmployeePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB_EmployeePicture
        '
        Me.PB_EmployeePicture.Location = New System.Drawing.Point(23, 115)
        Me.PB_EmployeePicture.Name = "PB_EmployeePicture"
        Me.PB_EmployeePicture.Size = New System.Drawing.Size(137, 157)
        Me.PB_EmployeePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_EmployeePicture.TabIndex = 0
        Me.PB_EmployeePicture.TabStop = False
        '
        'ML_TName
        '
        Me.ML_TName.AutoSize = True
        Me.ML_TName.Location = New System.Drawing.Point(177, 115)
        Me.ML_TName.Name = "ML_TName"
        Me.ML_TName.Size = New System.Drawing.Size(45, 19)
        Me.ML_TName.TabIndex = 1
        Me.ML_TName.Text = "Name"
        '
        'ML_TNIK
        '
        Me.ML_TNIK.AutoSize = True
        Me.ML_TNIK.Location = New System.Drawing.Point(177, 145)
        Me.ML_TNIK.Name = "ML_TNIK"
        Me.ML_TNIK.Size = New System.Drawing.Size(29, 19)
        Me.ML_TNIK.TabIndex = 2
        Me.ML_TNIK.Text = "NIK"
        '
        'ML_TGender
        '
        Me.ML_TGender.AutoSize = True
        Me.ML_TGender.Location = New System.Drawing.Point(177, 175)
        Me.ML_TGender.Name = "ML_TGender"
        Me.ML_TGender.Size = New System.Drawing.Size(52, 19)
        Me.ML_TGender.TabIndex = 3
        Me.ML_TGender.Text = "Gender"
        '
        'ML_TDepartment
        '
        Me.ML_TDepartment.AutoSize = True
        Me.ML_TDepartment.Location = New System.Drawing.Point(177, 205)
        Me.ML_TDepartment.Name = "ML_TDepartment"
        Me.ML_TDepartment.Size = New System.Drawing.Size(80, 19)
        Me.ML_TDepartment.TabIndex = 4
        Me.ML_TDepartment.Text = "Department"
        '
        'ML_TDivison
        '
        Me.ML_TDivison.AutoSize = True
        Me.ML_TDivison.Location = New System.Drawing.Point(177, 235)
        Me.ML_TDivison.Name = "ML_TDivison"
        Me.ML_TDivison.Size = New System.Drawing.Size(53, 19)
        Me.ML_TDivison.TabIndex = 5
        Me.ML_TDivison.Text = "Division"
        '
        'ML_Information1
        '
        Me.ML_Information1.AutoSize = True
        Me.ML_Information1.Location = New System.Drawing.Point(23, 302)
        Me.ML_Information1.Name = "ML_Information1"
        Me.ML_Information1.Size = New System.Drawing.Size(251, 19)
        Me.ML_Information1.TabIndex = 6
        Me.ML_Information1.Text = "Please scan RFID to show employee data!"
        '
        'ML_VDivision
        '
        Me.ML_VDivision.AutoSize = True
        Me.ML_VDivision.Location = New System.Drawing.Point(276, 235)
        Me.ML_VDivision.Name = "ML_VDivision"
        Me.ML_VDivision.Size = New System.Drawing.Size(53, 19)
        Me.ML_VDivision.TabIndex = 11
        Me.ML_VDivision.Text = "Division"
        '
        'ML_VDepartment
        '
        Me.ML_VDepartment.AutoSize = True
        Me.ML_VDepartment.Location = New System.Drawing.Point(276, 205)
        Me.ML_VDepartment.Name = "ML_VDepartment"
        Me.ML_VDepartment.Size = New System.Drawing.Size(80, 19)
        Me.ML_VDepartment.TabIndex = 10
        Me.ML_VDepartment.Text = "Department"
        '
        'ML_VGender
        '
        Me.ML_VGender.AutoSize = True
        Me.ML_VGender.Location = New System.Drawing.Point(276, 175)
        Me.ML_VGender.Name = "ML_VGender"
        Me.ML_VGender.Size = New System.Drawing.Size(52, 19)
        Me.ML_VGender.TabIndex = 9
        Me.ML_VGender.Text = "Gender"
        '
        'ML_VNIK
        '
        Me.ML_VNIK.AutoSize = True
        Me.ML_VNIK.Location = New System.Drawing.Point(276, 145)
        Me.ML_VNIK.Name = "ML_VNIK"
        Me.ML_VNIK.Size = New System.Drawing.Size(29, 19)
        Me.ML_VNIK.TabIndex = 8
        Me.ML_VNIK.Text = "NIK"
        '
        'ML_VName
        '
        Me.ML_VName.AutoSize = True
        Me.ML_VName.Location = New System.Drawing.Point(276, 115)
        Me.ML_VName.Name = "ML_VName"
        Me.ML_VName.Size = New System.Drawing.Size(45, 19)
        Me.ML_VName.TabIndex = 7
        Me.ML_VName.Text = "Name"
        '
        'MPS_FetchData
        '
        Me.MPS_FetchData.Location = New System.Drawing.Point(470, 302)
        Me.MPS_FetchData.Maximum = 100
        Me.MPS_FetchData.Name = "MPS_FetchData"
        Me.MPS_FetchData.Size = New System.Drawing.Size(16, 16)
        Me.MPS_FetchData.TabIndex = 12
        Me.MPS_FetchData.UseSelectable = True
        Me.MPS_FetchData.Visible = False
        '
        'ML_Information2
        '
        Me.ML_Information2.AutoSize = True
        Me.ML_Information2.Location = New System.Drawing.Point(23, 302)
        Me.ML_Information2.Name = "ML_Information2"
        Me.ML_Information2.Size = New System.Drawing.Size(188, 19)
        Me.ML_Information2.TabIndex = 13
        Me.ML_Information2.Text = "Wanna reset the RFID checker?"
        Me.ML_Information2.Visible = False
        '
        'MLI_ResetRFID
        '
        Me.MLI_ResetRFID.Location = New System.Drawing.Point(208, 300)
        Me.MLI_ResetRFID.Name = "MLI_ResetRFID"
        Me.MLI_ResetRFID.Size = New System.Drawing.Size(75, 23)
        Me.MLI_ResetRFID.TabIndex = 14
        Me.MLI_ResetRFID.Text = "Click Here"
        Me.MLI_ResetRFID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MLI_ResetRFID.UseSelectable = True
        Me.MLI_ResetRFID.Visible = False
        '
        'RFIDCheckerEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 351)
        Me.Controls.Add(Me.MLI_ResetRFID)
        Me.Controls.Add(Me.ML_Information2)
        Me.Controls.Add(Me.MPS_FetchData)
        Me.Controls.Add(Me.ML_VDivision)
        Me.Controls.Add(Me.ML_VDepartment)
        Me.Controls.Add(Me.ML_VGender)
        Me.Controls.Add(Me.ML_VNIK)
        Me.Controls.Add(Me.ML_VName)
        Me.Controls.Add(Me.ML_Information1)
        Me.Controls.Add(Me.ML_TDivison)
        Me.Controls.Add(Me.ML_TDepartment)
        Me.Controls.Add(Me.ML_TGender)
        Me.Controls.Add(Me.ML_TNIK)
        Me.Controls.Add(Me.ML_TName)
        Me.Controls.Add(Me.PB_EmployeePicture)
        Me.Name = "RFIDCheckerEmployee"
        Me.Text = "RFID Checker"
        CType(Me.PB_EmployeePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PB_EmployeePicture As PictureBox
    Friend WithEvents ML_TName As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_TNIK As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_TGender As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_TDepartment As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_TDivison As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_Information1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_VDivision As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_VDepartment As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_VGender As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_VNIK As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_VName As MetroFramework.Controls.MetroLabel
    Friend WithEvents MPS_FetchData As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents ML_Information2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MLI_ResetRFID As MetroFramework.Controls.MetroLink
End Class
