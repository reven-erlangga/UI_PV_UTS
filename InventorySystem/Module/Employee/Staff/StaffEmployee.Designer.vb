<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffEmployee
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MTB_VNIK = New MetroFramework.Controls.MetroTextBox()
        Me.MCB_VDivision = New MetroFramework.Controls.MetroComboBox()
        Me.PB_Profile = New System.Windows.Forms.PictureBox()
        Me.PB_RFID = New System.Windows.Forms.PictureBox()
        Me.MB_ChangeRFIDScan = New MetroFramework.Controls.MetroButton()
        Me.HL_RFID = New MetroFramework.Drawing.Html.HtmlLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MCB_VDept = New MetroFramework.Controls.MetroComboBox()
        Me.MTB_VName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MCB_VGender = New MetroFramework.Controls.MetroComboBox()
        Me.MB_Save = New MetroFramework.Controls.MetroButton()
        Me.MB_Back = New MetroFramework.Controls.MetroButton()
        CType(Me.PB_Profile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_RFID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(24, 74)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(29, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "NIK"
        '
        'MTB_VNIK
        '
        '
        '
        '
        Me.MTB_VNIK.CustomButton.Image = Nothing
        Me.MTB_VNIK.CustomButton.Location = New System.Drawing.Point(501, 1)
        Me.MTB_VNIK.CustomButton.Name = ""
        Me.MTB_VNIK.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MTB_VNIK.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VNIK.CustomButton.TabIndex = 1
        Me.MTB_VNIK.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VNIK.CustomButton.UseSelectable = True
        Me.MTB_VNIK.CustomButton.Visible = False
        Me.MTB_VNIK.Lines = New String(-1) {}
        Me.MTB_VNIK.Location = New System.Drawing.Point(23, 109)
        Me.MTB_VNIK.MaxLength = 32767
        Me.MTB_VNIK.Name = "MTB_VNIK"
        Me.MTB_VNIK.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VNIK.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VNIK.SelectedText = ""
        Me.MTB_VNIK.SelectionLength = 0
        Me.MTB_VNIK.SelectionStart = 0
        Me.MTB_VNIK.ShortcutsEnabled = True
        Me.MTB_VNIK.Size = New System.Drawing.Size(529, 29)
        Me.MTB_VNIK.TabIndex = 1
        Me.MTB_VNIK.UseSelectable = True
        Me.MTB_VNIK.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VNIK.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MCB_VDivision
        '
        Me.MCB_VDivision.FormattingEnabled = True
        Me.MCB_VDivision.ItemHeight = 23
        Me.MCB_VDivision.Location = New System.Drawing.Point(309, 271)
        Me.MCB_VDivision.Name = "MCB_VDivision"
        Me.MCB_VDivision.Size = New System.Drawing.Size(241, 29)
        Me.MCB_VDivision.TabIndex = 2
        Me.MCB_VDivision.UseSelectable = True
        '
        'PB_Profile
        '
        Me.PB_Profile.Image = Global.InventorySystem.My.Resources.Resources.profile_dummy
        Me.PB_Profile.Location = New System.Drawing.Point(645, 74)
        Me.PB_Profile.Name = "PB_Profile"
        Me.PB_Profile.Size = New System.Drawing.Size(132, 147)
        Me.PB_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Profile.TabIndex = 3
        Me.PB_Profile.TabStop = False
        '
        'PB_RFID
        '
        Me.PB_RFID.Location = New System.Drawing.Point(24, 333)
        Me.PB_RFID.Name = "PB_RFID"
        Me.PB_RFID.Size = New System.Drawing.Size(239, 50)
        Me.PB_RFID.TabIndex = 4
        Me.PB_RFID.TabStop = False
        '
        'MB_ChangeRFIDScan
        '
        Me.MB_ChangeRFIDScan.Location = New System.Drawing.Point(621, 360)
        Me.MB_ChangeRFIDScan.Name = "MB_ChangeRFIDScan"
        Me.MB_ChangeRFIDScan.Size = New System.Drawing.Size(75, 23)
        Me.MB_ChangeRFIDScan.TabIndex = 5
        Me.MB_ChangeRFIDScan.Text = "Insert RFID"
        Me.MB_ChangeRFIDScan.UseSelectable = True
        '
        'HL_RFID
        '
        Me.HL_RFID.AutoScroll = True
        Me.HL_RFID.AutoScrollMinSize = New System.Drawing.Size(10, 0)
        Me.HL_RFID.AutoSize = False
        Me.HL_RFID.BackColor = System.Drawing.SystemColors.Window
        Me.HL_RFID.Location = New System.Drawing.Point(24, 389)
        Me.HL_RFID.Name = "HL_RFID"
        Me.HL_RFID.Size = New System.Drawing.Size(75, 23)
        Me.HL_RFID.TabIndex = 6
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(309, 240)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "Division"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(22, 240)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel3.TabIndex = 9
        Me.MetroLabel3.Text = "Dept"
        '
        'MCB_VDept
        '
        Me.MCB_VDept.FormattingEnabled = True
        Me.MCB_VDept.ItemHeight = 23
        Me.MCB_VDept.Location = New System.Drawing.Point(22, 271)
        Me.MCB_VDept.Name = "MCB_VDept"
        Me.MCB_VDept.Size = New System.Drawing.Size(241, 29)
        Me.MCB_VDept.TabIndex = 8
        Me.MCB_VDept.UseSelectable = True
        '
        'MTB_VName
        '
        '
        '
        '
        Me.MTB_VName.CustomButton.Image = Nothing
        Me.MTB_VName.CustomButton.Location = New System.Drawing.Point(212, 1)
        Me.MTB_VName.CustomButton.Name = ""
        Me.MTB_VName.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MTB_VName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VName.CustomButton.TabIndex = 1
        Me.MTB_VName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VName.CustomButton.UseSelectable = True
        Me.MTB_VName.CustomButton.Visible = False
        Me.MTB_VName.Lines = New String(-1) {}
        Me.MTB_VName.Location = New System.Drawing.Point(23, 193)
        Me.MTB_VName.MaxLength = 32767
        Me.MTB_VName.Name = "MTB_VName"
        Me.MTB_VName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VName.SelectedText = ""
        Me.MTB_VName.SelectionLength = 0
        Me.MTB_VName.SelectionStart = 0
        Me.MTB_VName.ShortcutsEnabled = True
        Me.MTB_VName.Size = New System.Drawing.Size(240, 29)
        Me.MTB_VName.TabIndex = 11
        Me.MTB_VName.UseSelectable = True
        Me.MTB_VName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(24, 158)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel4.TabIndex = 10
        Me.MetroLabel4.Text = "Name"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(309, 158)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel5.TabIndex = 13
        Me.MetroLabel5.Text = "Gender"
        '
        'MCB_VGender
        '
        Me.MCB_VGender.FormattingEnabled = True
        Me.MCB_VGender.ItemHeight = 23
        Me.MCB_VGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.MCB_VGender.Location = New System.Drawing.Point(309, 189)
        Me.MCB_VGender.Name = "MCB_VGender"
        Me.MCB_VGender.Size = New System.Drawing.Size(241, 29)
        Me.MCB_VGender.TabIndex = 12
        Me.MCB_VGender.UseSelectable = True
        '
        'MB_Save
        '
        Me.MB_Save.Location = New System.Drawing.Point(702, 360)
        Me.MB_Save.Name = "MB_Save"
        Me.MB_Save.Size = New System.Drawing.Size(75, 23)
        Me.MB_Save.TabIndex = 14
        Me.MB_Save.Text = "Save"
        Me.MB_Save.UseSelectable = True
        '
        'MB_Back
        '
        Me.MB_Back.Location = New System.Drawing.Point(540, 360)
        Me.MB_Back.Name = "MB_Back"
        Me.MB_Back.Size = New System.Drawing.Size(75, 23)
        Me.MB_Back.TabIndex = 15
        Me.MB_Back.Text = "Back"
        Me.MB_Back.UseSelectable = True
        '
        'StaffEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MB_Back)
        Me.Controls.Add(Me.MB_Save)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MCB_VGender)
        Me.Controls.Add(Me.MTB_VName)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MCB_VDept)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.HL_RFID)
        Me.Controls.Add(Me.MB_ChangeRFIDScan)
        Me.Controls.Add(Me.PB_RFID)
        Me.Controls.Add(Me.PB_Profile)
        Me.Controls.Add(Me.MCB_VDivision)
        Me.Controls.Add(Me.MTB_VNIK)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "StaffEmployee"
        Me.Text = "Employee"
        CType(Me.PB_Profile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_RFID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MTB_VNIK As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MCB_VDivision As MetroFramework.Controls.MetroComboBox
    Friend WithEvents PB_Profile As PictureBox
    Friend WithEvents PB_RFID As PictureBox
    Friend WithEvents MB_ChangeRFIDScan As MetroFramework.Controls.MetroButton
    Friend WithEvents HL_RFID As MetroFramework.Drawing.Html.HtmlLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MCB_VDept As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MTB_VName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MCB_VGender As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MB_Save As MetroFramework.Controls.MetroButton
    Friend WithEvents MB_Back As MetroFramework.Controls.MetroButton
End Class
