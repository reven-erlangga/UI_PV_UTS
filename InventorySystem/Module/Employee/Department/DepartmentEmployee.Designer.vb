<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DepartmentEmployee
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
        Me.DGV_Employee = New System.Windows.Forms.DataGridView()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MTB_VName = New MetroFramework.Controls.MetroTextBox()
        Me.ML_TName = New MetroFramework.Controls.MetroLabel()
        Me.MB_Back = New MetroFramework.Controls.MetroButton()
        Me.MB_Delete = New MetroFramework.Controls.MetroButton()
        Me.MB_Save = New MetroFramework.Controls.MetroButton()
        Me.C_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MB_ClearData = New MetroFramework.Controls.MetroButton()
        CType(Me.DGV_Employee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Employee
        '
        Me.DGV_Employee.AllowUserToAddRows = False
        Me.DGV_Employee.AllowUserToDeleteRows = False
        Me.DGV_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Employee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_ID, Me.C_Name})
        Me.DGV_Employee.Location = New System.Drawing.Point(23, 232)
        Me.DGV_Employee.Name = "DGV_Employee"
        Me.DGV_Employee.ReadOnly = True
        Me.DGV_Employee.Size = New System.Drawing.Size(754, 195)
        Me.DGV_Employee.TabIndex = 1
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.MTB_VName)
        Me.MetroPanel1.Controls.Add(Me.ML_TName)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(23, 63)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(754, 134)
        Me.MetroPanel1.TabIndex = 2
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MTB_VName
        '
        '
        '
        '
        Me.MTB_VName.CustomButton.Image = Nothing
        Me.MTB_VName.CustomButton.Location = New System.Drawing.Point(285, 1)
        Me.MTB_VName.CustomButton.Name = ""
        Me.MTB_VName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MTB_VName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VName.CustomButton.TabIndex = 1
        Me.MTB_VName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VName.CustomButton.UseSelectable = True
        Me.MTB_VName.CustomButton.Visible = False
        Me.MTB_VName.Lines = New String(-1) {}
        Me.MTB_VName.Location = New System.Drawing.Point(17, 36)
        Me.MTB_VName.MaxLength = 32767
        Me.MTB_VName.Name = "MTB_VName"
        Me.MTB_VName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VName.SelectedText = ""
        Me.MTB_VName.SelectionLength = 0
        Me.MTB_VName.SelectionStart = 0
        Me.MTB_VName.ShortcutsEnabled = True
        Me.MTB_VName.Size = New System.Drawing.Size(307, 23)
        Me.MTB_VName.TabIndex = 3
        Me.MTB_VName.UseSelectable = True
        Me.MTB_VName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ML_TName
        '
        Me.ML_TName.AutoSize = True
        Me.ML_TName.Location = New System.Drawing.Point(17, 14)
        Me.ML_TName.Name = "ML_TName"
        Me.ML_TName.Size = New System.Drawing.Size(45, 19)
        Me.ML_TName.TabIndex = 2
        Me.ML_TName.Text = "Name"
        '
        'MB_Back
        '
        Me.MB_Back.Location = New System.Drawing.Point(702, 34)
        Me.MB_Back.Name = "MB_Back"
        Me.MB_Back.Size = New System.Drawing.Size(75, 23)
        Me.MB_Back.TabIndex = 11
        Me.MB_Back.Text = "Back"
        Me.MB_Back.UseSelectable = True
        '
        'MB_Delete
        '
        Me.MB_Delete.Location = New System.Drawing.Point(621, 203)
        Me.MB_Delete.Name = "MB_Delete"
        Me.MB_Delete.Size = New System.Drawing.Size(75, 23)
        Me.MB_Delete.TabIndex = 10
        Me.MB_Delete.Text = "Delete"
        Me.MB_Delete.UseSelectable = True
        Me.MB_Delete.Visible = False
        '
        'MB_Save
        '
        Me.MB_Save.Location = New System.Drawing.Point(702, 203)
        Me.MB_Save.Name = "MB_Save"
        Me.MB_Save.Size = New System.Drawing.Size(75, 23)
        Me.MB_Save.TabIndex = 9
        Me.MB_Save.Text = "Save"
        Me.MB_Save.UseSelectable = True
        '
        'C_ID
        '
        Me.C_ID.HeaderText = "ID"
        Me.C_ID.Name = "C_ID"
        Me.C_ID.ReadOnly = True
        Me.C_ID.Visible = False
        '
        'C_Name
        '
        Me.C_Name.HeaderText = "Name"
        Me.C_Name.Name = "C_Name"
        Me.C_Name.ReadOnly = True
        '
        'MB_ClearData
        '
        Me.MB_ClearData.Location = New System.Drawing.Point(23, 203)
        Me.MB_ClearData.Name = "MB_ClearData"
        Me.MB_ClearData.Size = New System.Drawing.Size(75, 23)
        Me.MB_ClearData.TabIndex = 12
        Me.MB_ClearData.Text = "Clear"
        Me.MB_ClearData.UseSelectable = True
        '
        'DepartmentEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MB_ClearData)
        Me.Controls.Add(Me.MB_Back)
        Me.Controls.Add(Me.MB_Delete)
        Me.Controls.Add(Me.MB_Save)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.DGV_Employee)
        Me.Name = "DepartmentEmployee"
        Me.Text = "Department"
        CType(Me.DGV_Employee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_Employee As DataGridView
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MTB_VName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ML_TName As MetroFramework.Controls.MetroLabel
    Friend WithEvents MB_Back As MetroFramework.Controls.MetroButton
    Friend WithEvents MB_Delete As MetroFramework.Controls.MetroButton
    Friend WithEvents MB_Save As MetroFramework.Controls.MetroButton
    Friend WithEvents C_ID As DataGridViewTextBoxColumn
    Friend WithEvents C_Name As DataGridViewTextBoxColumn
    Friend WithEvents MB_ClearData As MetroFramework.Controls.MetroButton
End Class
