<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OverviewProduct
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
        Me.MB_Delete = New MetroFramework.Controls.MetroButton()
        Me.MTB_VID = New MetroFramework.Controls.MetroTextBox()
        Me.MB_Save = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MCB_VCategory = New MetroFramework.Controls.MetroComboBox()
        Me.MTB_VDescription = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MTB_VName = New MetroFramework.Controls.MetroTextBox()
        Me.ML_TName = New MetroFramework.Controls.MetroLabel()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.MTB_VPrice = New MetroFramework.Controls.MetroTextBox()
        Me.ML_Price = New MetroFramework.Controls.MetroLabel()
        Me.C_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MB_Back = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MB_Delete
        '
        Me.MB_Delete.Location = New System.Drawing.Point(610, 280)
        Me.MB_Delete.Name = "MB_Delete"
        Me.MB_Delete.Size = New System.Drawing.Size(75, 23)
        Me.MB_Delete.TabIndex = 12
        Me.MB_Delete.Text = "Delete"
        Me.MB_Delete.UseSelectable = True
        Me.MB_Delete.Visible = False
        '
        'MTB_VID
        '
        '
        '
        '
        Me.MTB_VID.CustomButton.Image = Nothing
        Me.MTB_VID.CustomButton.Location = New System.Drawing.Point(11, 1)
        Me.MTB_VID.CustomButton.Name = ""
        Me.MTB_VID.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MTB_VID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VID.CustomButton.TabIndex = 1
        Me.MTB_VID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VID.CustomButton.UseSelectable = True
        Me.MTB_VID.CustomButton.Visible = False
        Me.MTB_VID.Lines = New String(-1) {}
        Me.MTB_VID.Location = New System.Drawing.Point(727, -1)
        Me.MTB_VID.MaxLength = 32767
        Me.MTB_VID.Name = "MTB_VID"
        Me.MTB_VID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VID.SelectedText = ""
        Me.MTB_VID.SelectionLength = 0
        Me.MTB_VID.SelectionStart = 0
        Me.MTB_VID.ShortcutsEnabled = True
        Me.MTB_VID.Size = New System.Drawing.Size(33, 23)
        Me.MTB_VID.TabIndex = 11
        Me.MTB_VID.UseSelectable = True
        Me.MTB_VID.Visible = False
        Me.MTB_VID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MB_Save
        '
        Me.MB_Save.Location = New System.Drawing.Point(702, 280)
        Me.MB_Save.Name = "MB_Save"
        Me.MB_Save.Size = New System.Drawing.Size(75, 23)
        Me.MB_Save.TabIndex = 10
        Me.MB_Save.Text = "Save"
        Me.MB_Save.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.ML_Price)
        Me.MetroPanel1.Controls.Add(Me.MTB_VPrice)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel1.Controls.Add(Me.MCB_VCategory)
        Me.MetroPanel1.Controls.Add(Me.MTB_VDescription)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.MTB_VName)
        Me.MetroPanel1.Controls.Add(Me.ML_TName)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(23, 63)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(754, 211)
        Me.MetroPanel1.TabIndex = 9
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(358, 15)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel5.TabIndex = 15
        Me.MetroLabel5.Text = "Category"
        '
        'MCB_VCategory
        '
        Me.MCB_VCategory.FormattingEnabled = True
        Me.MCB_VCategory.ItemHeight = 23
        Me.MCB_VCategory.Location = New System.Drawing.Point(358, 46)
        Me.MCB_VCategory.Name = "MCB_VCategory"
        Me.MCB_VCategory.Size = New System.Drawing.Size(307, 29)
        Me.MCB_VCategory.TabIndex = 14
        Me.MCB_VCategory.UseSelectable = True
        '
        'MTB_VDescription
        '
        '
        '
        '
        Me.MTB_VDescription.CustomButton.Image = Nothing
        Me.MTB_VDescription.CustomButton.Location = New System.Drawing.Point(244, 2)
        Me.MTB_VDescription.CustomButton.Name = ""
        Me.MTB_VDescription.CustomButton.Size = New System.Drawing.Size(75, 75)
        Me.MTB_VDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VDescription.CustomButton.TabIndex = 1
        Me.MTB_VDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VDescription.CustomButton.UseSelectable = True
        Me.MTB_VDescription.CustomButton.Visible = False
        Me.MTB_VDescription.Lines = New String(-1) {}
        Me.MTB_VDescription.Location = New System.Drawing.Point(24, 115)
        Me.MTB_VDescription.MaxLength = 32767
        Me.MTB_VDescription.Name = "MTB_VDescription"
        Me.MTB_VDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VDescription.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VDescription.SelectedText = ""
        Me.MTB_VDescription.SelectionLength = 0
        Me.MTB_VDescription.SelectionStart = 0
        Me.MTB_VDescription.ShortcutsEnabled = True
        Me.MTB_VDescription.Size = New System.Drawing.Size(322, 80)
        Me.MTB_VDescription.TabIndex = 5
        Me.MTB_VDescription.UseSelectable = True
        Me.MTB_VDescription.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VDescription.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(24, 84)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Description"
        '
        'MTB_VName
        '
        '
        '
        '
        Me.MTB_VName.CustomButton.Image = Nothing
        Me.MTB_VName.CustomButton.Location = New System.Drawing.Point(300, 1)
        Me.MTB_VName.CustomButton.Name = ""
        Me.MTB_VName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MTB_VName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VName.CustomButton.TabIndex = 1
        Me.MTB_VName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VName.CustomButton.UseSelectable = True
        Me.MTB_VName.CustomButton.Visible = False
        Me.MTB_VName.Lines = New String(-1) {}
        Me.MTB_VName.Location = New System.Drawing.Point(24, 46)
        Me.MTB_VName.MaxLength = 32767
        Me.MTB_VName.Name = "MTB_VName"
        Me.MTB_VName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VName.SelectedText = ""
        Me.MTB_VName.SelectionLength = 0
        Me.MTB_VName.SelectionStart = 0
        Me.MTB_VName.ShortcutsEnabled = True
        Me.MTB_VName.Size = New System.Drawing.Size(322, 23)
        Me.MTB_VName.TabIndex = 3
        Me.MTB_VName.UseSelectable = True
        Me.MTB_VName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ML_TName
        '
        Me.ML_TName.AutoSize = True
        Me.ML_TName.Location = New System.Drawing.Point(24, 15)
        Me.ML_TName.Name = "ML_TName"
        Me.ML_TName.Size = New System.Drawing.Size(45, 19)
        Me.ML_TName.TabIndex = 2
        Me.ML_TName.Text = "Name"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_ID, Me.C_Name, Me.C_Description, Me.C_Price})
        Me.DGV.Location = New System.Drawing.Point(23, 309)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(754, 147)
        Me.DGV.TabIndex = 8
        '
        'MTB_VPrice
        '
        '
        '
        '
        Me.MTB_VPrice.CustomButton.Image = Nothing
        Me.MTB_VPrice.CustomButton.Location = New System.Drawing.Point(285, 1)
        Me.MTB_VPrice.CustomButton.Name = ""
        Me.MTB_VPrice.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MTB_VPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VPrice.CustomButton.TabIndex = 1
        Me.MTB_VPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VPrice.CustomButton.UseSelectable = True
        Me.MTB_VPrice.CustomButton.Visible = False
        Me.MTB_VPrice.Lines = New String(-1) {}
        Me.MTB_VPrice.Location = New System.Drawing.Point(358, 115)
        Me.MTB_VPrice.MaxLength = 32767
        Me.MTB_VPrice.Name = "MTB_VPrice"
        Me.MTB_VPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VPrice.SelectedText = ""
        Me.MTB_VPrice.SelectionLength = 0
        Me.MTB_VPrice.SelectionStart = 0
        Me.MTB_VPrice.ShortcutsEnabled = True
        Me.MTB_VPrice.Size = New System.Drawing.Size(307, 23)
        Me.MTB_VPrice.TabIndex = 16
        Me.MTB_VPrice.UseSelectable = True
        Me.MTB_VPrice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VPrice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ML_Price
        '
        Me.ML_Price.AutoSize = True
        Me.ML_Price.Location = New System.Drawing.Point(358, 84)
        Me.ML_Price.Name = "ML_Price"
        Me.ML_Price.Size = New System.Drawing.Size(38, 19)
        Me.ML_Price.TabIndex = 17
        Me.ML_Price.Text = "Price"
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
        'C_Description
        '
        Me.C_Description.HeaderText = "Description"
        Me.C_Description.Name = "C_Description"
        Me.C_Description.ReadOnly = True
        '
        'C_Price
        '
        Me.C_Price.HeaderText = "Price"
        Me.C_Price.Name = "C_Price"
        Me.C_Price.ReadOnly = True
        '
        'MB_Back
        '
        Me.MB_Back.Location = New System.Drawing.Point(702, 34)
        Me.MB_Back.Name = "MB_Back"
        Me.MB_Back.Size = New System.Drawing.Size(75, 23)
        Me.MB_Back.TabIndex = 13
        Me.MB_Back.Text = "Back"
        Me.MB_Back.UseSelectable = True
        '
        'OverviewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 481)
        Me.Controls.Add(Me.MB_Back)
        Me.Controls.Add(Me.MTB_VID)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.MB_Save)
        Me.Controls.Add(Me.MB_Delete)
        Me.Name = "OverviewProduct"
        Me.Text = "Overview"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MB_Delete As MetroFramework.Controls.MetroButton
    Friend WithEvents MTB_VID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MB_Save As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MTB_VDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MTB_VName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ML_TName As MetroFramework.Controls.MetroLabel
    Friend WithEvents DGV As DataGridView
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MCB_VCategory As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ML_Price As MetroFramework.Controls.MetroLabel
    Friend WithEvents MTB_VPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents C_ID As DataGridViewTextBoxColumn
    Friend WithEvents C_Name As DataGridViewTextBoxColumn
    Friend WithEvents C_Description As DataGridViewTextBoxColumn
    Friend WithEvents C_Price As DataGridViewTextBoxColumn
    Friend WithEvents MB_Back As MetroFramework.Controls.MetroButton
End Class
