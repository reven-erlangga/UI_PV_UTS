<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OverviewPurchaseOrder
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
        Me.MTB_VHandphone = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MTB_VFax = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MTB_VEmail = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MTB_VAddress = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MTB_VName = New MetroFramework.Controls.MetroTextBox()
        Me.ML_TName = New MetroFramework.Controls.MetroLabel()
        Me.MB_PurchaseOrderItem = New MetroFramework.Controls.MetroButton()
        Me.MB_Save = New MetroFramework.Controls.MetroButton()
        Me.PB_Barcode = New System.Windows.Forms.PictureBox()
        Me.DGV_PO = New System.Windows.Forms.DataGridView()
        Me.C_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_PONumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MB_Back = New MetroFramework.Controls.MetroButton()
        Me.C_SupplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Reason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PB_Barcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_PO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MTB_VHandphone
        '
        '
        '
        '
        Me.MTB_VHandphone.CustomButton.Image = Nothing
        Me.MTB_VHandphone.CustomButton.Location = New System.Drawing.Point(285, 1)
        Me.MTB_VHandphone.CustomButton.Name = ""
        Me.MTB_VHandphone.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MTB_VHandphone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VHandphone.CustomButton.TabIndex = 1
        Me.MTB_VHandphone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VHandphone.CustomButton.UseSelectable = True
        Me.MTB_VHandphone.CustomButton.Visible = False
        Me.MTB_VHandphone.Lines = New String(-1) {}
        Me.MTB_VHandphone.Location = New System.Drawing.Point(470, 214)
        Me.MTB_VHandphone.MaxLength = 32767
        Me.MTB_VHandphone.Name = "MTB_VHandphone"
        Me.MTB_VHandphone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VHandphone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VHandphone.SelectedText = ""
        Me.MTB_VHandphone.SelectionLength = 0
        Me.MTB_VHandphone.SelectionStart = 0
        Me.MTB_VHandphone.ShortcutsEnabled = True
        Me.MTB_VHandphone.Size = New System.Drawing.Size(307, 23)
        Me.MTB_VHandphone.TabIndex = 18
        Me.MTB_VHandphone.UseSelectable = True
        Me.MTB_VHandphone.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VHandphone.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(470, 183)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(77, 19)
        Me.MetroLabel5.TabIndex = 17
        Me.MetroLabel5.Text = "Handphone"
        '
        'MTB_VFax
        '
        '
        '
        '
        Me.MTB_VFax.CustomButton.Image = Nothing
        Me.MTB_VFax.CustomButton.Location = New System.Drawing.Point(285, 1)
        Me.MTB_VFax.CustomButton.Name = ""
        Me.MTB_VFax.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MTB_VFax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VFax.CustomButton.TabIndex = 1
        Me.MTB_VFax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VFax.CustomButton.UseSelectable = True
        Me.MTB_VFax.CustomButton.Visible = False
        Me.MTB_VFax.Lines = New String(-1) {}
        Me.MTB_VFax.Location = New System.Drawing.Point(28, 214)
        Me.MTB_VFax.MaxLength = 32767
        Me.MTB_VFax.Name = "MTB_VFax"
        Me.MTB_VFax.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VFax.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VFax.SelectedText = ""
        Me.MTB_VFax.SelectionLength = 0
        Me.MTB_VFax.SelectionStart = 0
        Me.MTB_VFax.ShortcutsEnabled = True
        Me.MTB_VFax.Size = New System.Drawing.Size(307, 23)
        Me.MTB_VFax.TabIndex = 16
        Me.MTB_VFax.UseSelectable = True
        Me.MTB_VFax.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VFax.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(28, 183)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(32, 19)
        Me.MetroLabel4.TabIndex = 15
        Me.MetroLabel4.Text = "FAX"
        '
        'MTB_VEmail
        '
        '
        '
        '
        Me.MTB_VEmail.CustomButton.Image = Nothing
        Me.MTB_VEmail.CustomButton.Location = New System.Drawing.Point(285, 1)
        Me.MTB_VEmail.CustomButton.Name = ""
        Me.MTB_VEmail.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MTB_VEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VEmail.CustomButton.TabIndex = 1
        Me.MTB_VEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VEmail.CustomButton.UseSelectable = True
        Me.MTB_VEmail.CustomButton.Visible = False
        Me.MTB_VEmail.Lines = New String(-1) {}
        Me.MTB_VEmail.Location = New System.Drawing.Point(470, 134)
        Me.MTB_VEmail.MaxLength = 32767
        Me.MTB_VEmail.Name = "MTB_VEmail"
        Me.MTB_VEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VEmail.SelectedText = ""
        Me.MTB_VEmail.SelectionLength = 0
        Me.MTB_VEmail.SelectionStart = 0
        Me.MTB_VEmail.ShortcutsEnabled = True
        Me.MTB_VEmail.Size = New System.Drawing.Size(307, 23)
        Me.MTB_VEmail.TabIndex = 14
        Me.MTB_VEmail.UseSelectable = True
        Me.MTB_VEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(470, 103)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel2.TabIndex = 13
        Me.MetroLabel2.Text = "Email"
        '
        'MTB_VAddress
        '
        '
        '
        '
        Me.MTB_VAddress.CustomButton.Image = Nothing
        Me.MTB_VAddress.CustomButton.Location = New System.Drawing.Point(671, 2)
        Me.MTB_VAddress.CustomButton.Name = ""
        Me.MTB_VAddress.CustomButton.Size = New System.Drawing.Size(75, 75)
        Me.MTB_VAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VAddress.CustomButton.TabIndex = 1
        Me.MTB_VAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VAddress.CustomButton.UseSelectable = True
        Me.MTB_VAddress.CustomButton.Visible = False
        Me.MTB_VAddress.Lines = New String(-1) {}
        Me.MTB_VAddress.Location = New System.Drawing.Point(28, 286)
        Me.MTB_VAddress.MaxLength = 32767
        Me.MTB_VAddress.Name = "MTB_VAddress"
        Me.MTB_VAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VAddress.SelectedText = ""
        Me.MTB_VAddress.SelectionLength = 0
        Me.MTB_VAddress.SelectionStart = 0
        Me.MTB_VAddress.ShortcutsEnabled = True
        Me.MTB_VAddress.Size = New System.Drawing.Size(749, 80)
        Me.MTB_VAddress.TabIndex = 5
        Me.MTB_VAddress.UseSelectable = True
        Me.MTB_VAddress.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VAddress.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(28, 255)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Address"
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
        Me.MTB_VName.Location = New System.Drawing.Point(28, 134)
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
        Me.ML_TName.Location = New System.Drawing.Point(28, 103)
        Me.ML_TName.Name = "ML_TName"
        Me.ML_TName.Size = New System.Drawing.Size(45, 19)
        Me.ML_TName.TabIndex = 2
        Me.ML_TName.Text = "Name"
        '
        'MB_PurchaseOrderItem
        '
        Me.MB_PurchaseOrderItem.Location = New System.Drawing.Point(28, 372)
        Me.MB_PurchaseOrderItem.Name = "MB_PurchaseOrderItem"
        Me.MB_PurchaseOrderItem.Size = New System.Drawing.Size(75, 23)
        Me.MB_PurchaseOrderItem.TabIndex = 20
        Me.MB_PurchaseOrderItem.Text = "Item"
        Me.MB_PurchaseOrderItem.UseSelectable = True
        '
        'MB_Save
        '
        Me.MB_Save.Location = New System.Drawing.Point(702, 372)
        Me.MB_Save.Name = "MB_Save"
        Me.MB_Save.Size = New System.Drawing.Size(75, 23)
        Me.MB_Save.TabIndex = 21
        Me.MB_Save.Text = "Save"
        Me.MB_Save.UseSelectable = True
        '
        'PB_Barcode
        '
        Me.PB_Barcode.Location = New System.Drawing.Point(559, 25)
        Me.PB_Barcode.Name = "PB_Barcode"
        Me.PB_Barcode.Size = New System.Drawing.Size(218, 50)
        Me.PB_Barcode.TabIndex = 19
        Me.PB_Barcode.TabStop = False
        Me.PB_Barcode.Visible = False
        '
        'DGV_PO
        '
        Me.DGV_PO.AllowUserToAddRows = False
        Me.DGV_PO.AllowUserToDeleteRows = False
        Me.DGV_PO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_ID, Me.C_PONumber, Me.C_SupplierName, Me.C_Reason, Me.C_Status})
        Me.DGV_PO.Location = New System.Drawing.Point(24, 421)
        Me.DGV_PO.Name = "DGV_PO"
        Me.DGV_PO.ReadOnly = True
        Me.DGV_PO.Size = New System.Drawing.Size(754, 280)
        Me.DGV_PO.TabIndex = 22
        '
        'C_ID
        '
        Me.C_ID.HeaderText = "ID"
        Me.C_ID.Name = "C_ID"
        Me.C_ID.ReadOnly = True
        Me.C_ID.Visible = False
        '
        'C_PONumber
        '
        Me.C_PONumber.HeaderText = "PO Number"
        Me.C_PONumber.Name = "C_PONumber"
        Me.C_PONumber.ReadOnly = True
        '
        'MB_Back
        '
        Me.MB_Back.Location = New System.Drawing.Point(621, 372)
        Me.MB_Back.Name = "MB_Back"
        Me.MB_Back.Size = New System.Drawing.Size(75, 23)
        Me.MB_Back.TabIndex = 23
        Me.MB_Back.Text = "Back"
        Me.MB_Back.UseSelectable = True
        '
        'C_SupplierName
        '
        Me.C_SupplierName.HeaderText = "Supplier Name"
        Me.C_SupplierName.Name = "C_SupplierName"
        Me.C_SupplierName.ReadOnly = True
        '
        'C_Reason
        '
        Me.C_Reason.HeaderText = "Reason"
        Me.C_Reason.Name = "C_Reason"
        Me.C_Reason.ReadOnly = True
        '
        'C_Status
        '
        Me.C_Status.HeaderText = "Status"
        Me.C_Status.Name = "C_Status"
        Me.C_Status.ReadOnly = True
        '
        'OverviewPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 737)
        Me.Controls.Add(Me.MB_Back)
        Me.Controls.Add(Me.DGV_PO)
        Me.Controls.Add(Me.MB_Save)
        Me.Controls.Add(Me.MTB_VHandphone)
        Me.Controls.Add(Me.MB_PurchaseOrderItem)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.PB_Barcode)
        Me.Controls.Add(Me.MTB_VFax)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MTB_VEmail)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.ML_TName)
        Me.Controls.Add(Me.MTB_VAddress)
        Me.Controls.Add(Me.MTB_VName)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "OverviewPurchaseOrder"
        Me.Text = "Overview"
        CType(Me.PB_Barcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_PO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MTB_VHandphone As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MTB_VFax As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MTB_VEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MTB_VAddress As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MTB_VName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ML_TName As MetroFramework.Controls.MetroLabel
    Friend WithEvents PB_Barcode As PictureBox
    Friend WithEvents MB_PurchaseOrderItem As MetroFramework.Controls.MetroButton
    Friend WithEvents MB_Save As MetroFramework.Controls.MetroButton
    Friend WithEvents DGV_PO As DataGridView
    Friend WithEvents C_ID As DataGridViewTextBoxColumn
    Friend WithEvents C_PONumber As DataGridViewTextBoxColumn
    Friend WithEvents MB_Back As MetroFramework.Controls.MetroButton
    Friend WithEvents C_SupplierName As DataGridViewTextBoxColumn
    Friend WithEvents C_Reason As DataGridViewTextBoxColumn
    Friend WithEvents C_Status As DataGridViewTextBoxColumn
End Class
