<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductCategory
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
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MTB_VDescription = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MTB_VName = New MetroFramework.Controls.MetroTextBox()
        Me.ML_TName = New MetroFramework.Controls.MetroLabel()
        Me.MB_Clear = New MetroFramework.Controls.MetroButton()
        Me.MB_Back = New MetroFramework.Controls.MetroButton()
        Me.MB_Delete = New MetroFramework.Controls.MetroButton()
        Me.MB_Save = New MetroFramework.Controls.MetroButton()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TID, Me.TName, Me.TDescription})
        Me.DGV.Location = New System.Drawing.Point(23, 277)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(754, 235)
        Me.DGV.TabIndex = 10
        '
        'TID
        '
        Me.TID.HeaderText = "ID"
        Me.TID.Name = "TID"
        Me.TID.ReadOnly = True
        Me.TID.Visible = False
        '
        'TName
        '
        Me.TName.HeaderText = "Name"
        Me.TName.Name = "TName"
        Me.TName.ReadOnly = True
        '
        'TDescription
        '
        Me.TDescription.HeaderText = "Description"
        Me.TDescription.Name = "TDescription"
        Me.TDescription.ReadOnly = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.MTB_VDescription)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.MTB_VName)
        Me.MetroPanel1.Controls.Add(Me.ML_TName)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(23, 97)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(754, 134)
        Me.MetroPanel1.TabIndex = 11
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
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
        Me.MTB_VDescription.Location = New System.Drawing.Point(415, 36)
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
        Me.MetroLabel1.Location = New System.Drawing.Point(415, 14)
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
        'MB_Clear
        '
        Me.MB_Clear.Location = New System.Drawing.Point(23, 237)
        Me.MB_Clear.Name = "MB_Clear"
        Me.MB_Clear.Size = New System.Drawing.Size(75, 23)
        Me.MB_Clear.TabIndex = 15
        Me.MB_Clear.Text = "Clear"
        Me.MB_Clear.UseSelectable = True
        '
        'MB_Back
        '
        Me.MB_Back.Location = New System.Drawing.Point(702, 68)
        Me.MB_Back.Name = "MB_Back"
        Me.MB_Back.Size = New System.Drawing.Size(75, 23)
        Me.MB_Back.TabIndex = 14
        Me.MB_Back.Text = "Back"
        Me.MB_Back.UseSelectable = True
        '
        'MB_Delete
        '
        Me.MB_Delete.Location = New System.Drawing.Point(620, 238)
        Me.MB_Delete.Name = "MB_Delete"
        Me.MB_Delete.Size = New System.Drawing.Size(75, 23)
        Me.MB_Delete.TabIndex = 13
        Me.MB_Delete.Text = "Delete"
        Me.MB_Delete.UseSelectable = True
        Me.MB_Delete.Visible = False
        '
        'MB_Save
        '
        Me.MB_Save.Location = New System.Drawing.Point(701, 238)
        Me.MB_Save.Name = "MB_Save"
        Me.MB_Save.Size = New System.Drawing.Size(75, 23)
        Me.MB_Save.TabIndex = 12
        Me.MB_Save.Text = "Save"
        Me.MB_Save.UseSelectable = True
        '
        'ProductCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 535)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MB_Clear)
        Me.Controls.Add(Me.MB_Back)
        Me.Controls.Add(Me.MB_Delete)
        Me.Controls.Add(Me.MB_Save)
        Me.Name = "ProductCategory"
        Me.Text = "ProductCategoroy"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents TID As DataGridViewTextBoxColumn
    Friend WithEvents TName As DataGridViewTextBoxColumn
    Friend WithEvents TDescription As DataGridViewTextBoxColumn
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MTB_VDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MTB_VName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ML_TName As MetroFramework.Controls.MetroLabel
    Friend WithEvents MB_Clear As MetroFramework.Controls.MetroButton
    Friend WithEvents MB_Back As MetroFramework.Controls.MetroButton
    Friend WithEvents MB_Delete As MetroFramework.Controls.MetroButton
    Friend WithEvents MB_Save As MetroFramework.Controls.MetroButton
End Class
