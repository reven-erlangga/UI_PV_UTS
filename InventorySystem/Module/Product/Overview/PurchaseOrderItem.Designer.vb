<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrderItem
    Inherits System.Windows.Forms.Form

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
        Me.MGV_PurchaseOrderItem = New System.Windows.Forms.DataGridView()
        Me.C_PID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_PName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_AdjustQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_APrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_ListProduct = New System.Windows.Forms.DataGridView()
        Me.CID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MTB_VName = New MetroFramework.Controls.MetroTextBox()
        Me.ML_TName = New MetroFramework.Controls.MetroLabel()
        Me.MTB_VQty = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MB_AddToListProduct = New MetroFramework.Controls.MetroButton()
        Me.MTB_VID = New MetroFramework.Controls.MetroTextBox()
        Me.MTB_VPrice = New MetroFramework.Controls.MetroTextBox()
        CType(Me.MGV_PurchaseOrderItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_ListProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MGV_PurchaseOrderItem
        '
        Me.MGV_PurchaseOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MGV_PurchaseOrderItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_PID, Me.C_PName, Me.C_AdjustQty, Me.C_APrice})
        Me.MGV_PurchaseOrderItem.Location = New System.Drawing.Point(12, 286)
        Me.MGV_PurchaseOrderItem.Name = "MGV_PurchaseOrderItem"
        Me.MGV_PurchaseOrderItem.ReadOnly = True
        Me.MGV_PurchaseOrderItem.Size = New System.Drawing.Size(776, 152)
        Me.MGV_PurchaseOrderItem.TabIndex = 0
        '
        'C_PID
        '
        Me.C_PID.HeaderText = "ID"
        Me.C_PID.Name = "C_PID"
        Me.C_PID.ReadOnly = True
        Me.C_PID.Visible = False
        '
        'C_PName
        '
        Me.C_PName.HeaderText = "Name"
        Me.C_PName.Name = "C_PName"
        Me.C_PName.ReadOnly = True
        '
        'C_AdjustQty
        '
        Me.C_AdjustQty.HeaderText = "Adjust Qty"
        Me.C_AdjustQty.Name = "C_AdjustQty"
        Me.C_AdjustQty.ReadOnly = True
        '
        'C_APrice
        '
        Me.C_APrice.HeaderText = "Price"
        Me.C_APrice.Name = "C_APrice"
        Me.C_APrice.ReadOnly = True
        '
        'DGV_ListProduct
        '
        Me.DGV_ListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ListProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CID, Me.CName, Me.C_Qty, Me.C_Price})
        Me.DGV_ListProduct.Location = New System.Drawing.Point(12, 12)
        Me.DGV_ListProduct.Name = "DGV_ListProduct"
        Me.DGV_ListProduct.ReadOnly = True
        Me.DGV_ListProduct.Size = New System.Drawing.Size(337, 220)
        Me.DGV_ListProduct.TabIndex = 1
        '
        'CID
        '
        Me.CID.HeaderText = "ID"
        Me.CID.Name = "CID"
        Me.CID.ReadOnly = True
        Me.CID.Visible = False
        '
        'CName
        '
        Me.CName.HeaderText = "Name"
        Me.CName.Name = "CName"
        Me.CName.ReadOnly = True
        '
        'C_Qty
        '
        Me.C_Qty.HeaderText = "Qty"
        Me.C_Qty.Name = "C_Qty"
        Me.C_Qty.ReadOnly = True
        '
        'C_Price
        '
        Me.C_Price.HeaderText = "Price"
        Me.C_Price.Name = "C_Price"
        Me.C_Price.ReadOnly = True
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
        Me.MTB_VName.Location = New System.Drawing.Point(376, 43)
        Me.MTB_VName.MaxLength = 32767
        Me.MTB_VName.Name = "MTB_VName"
        Me.MTB_VName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VName.SelectedText = ""
        Me.MTB_VName.SelectionLength = 0
        Me.MTB_VName.SelectionStart = 0
        Me.MTB_VName.ShortcutsEnabled = True
        Me.MTB_VName.Size = New System.Drawing.Size(307, 23)
        Me.MTB_VName.TabIndex = 5
        Me.MTB_VName.UseSelectable = True
        Me.MTB_VName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ML_TName
        '
        Me.ML_TName.AutoSize = True
        Me.ML_TName.Location = New System.Drawing.Point(376, 12)
        Me.ML_TName.Name = "ML_TName"
        Me.ML_TName.Size = New System.Drawing.Size(55, 19)
        Me.ML_TName.TabIndex = 4
        Me.ML_TName.Text = "Product"
        '
        'MTB_VQty
        '
        '
        '
        '
        Me.MTB_VQty.CustomButton.Image = Nothing
        Me.MTB_VQty.CustomButton.Location = New System.Drawing.Point(285, 1)
        Me.MTB_VQty.CustomButton.Name = ""
        Me.MTB_VQty.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MTB_VQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VQty.CustomButton.TabIndex = 1
        Me.MTB_VQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VQty.CustomButton.UseSelectable = True
        Me.MTB_VQty.CustomButton.Visible = False
        Me.MTB_VQty.Lines = New String(-1) {}
        Me.MTB_VQty.Location = New System.Drawing.Point(376, 124)
        Me.MTB_VQty.MaxLength = 32767
        Me.MTB_VQty.Name = "MTB_VQty"
        Me.MTB_VQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VQty.SelectedText = ""
        Me.MTB_VQty.SelectionLength = 0
        Me.MTB_VQty.SelectionStart = 0
        Me.MTB_VQty.ShortcutsEnabled = True
        Me.MTB_VQty.Size = New System.Drawing.Size(307, 23)
        Me.MTB_VQty.TabIndex = 7
        Me.MTB_VQty.UseSelectable = True
        Me.MTB_VQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(376, 93)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(34, 19)
        Me.MetroLabel1.TabIndex = 6
        Me.MetroLabel1.Text = "QTY"
        '
        'MB_AddToListProduct
        '
        Me.MB_AddToListProduct.Location = New System.Drawing.Point(562, 209)
        Me.MB_AddToListProduct.Name = "MB_AddToListProduct"
        Me.MB_AddToListProduct.Size = New System.Drawing.Size(121, 23)
        Me.MB_AddToListProduct.TabIndex = 8
        Me.MB_AddToListProduct.Text = "Add To List Product"
        Me.MB_AddToListProduct.UseSelectable = True
        '
        'MTB_VID
        '
        '
        '
        '
        Me.MTB_VID.CustomButton.Image = Nothing
        Me.MTB_VID.CustomButton.Location = New System.Drawing.Point(21, 1)
        Me.MTB_VID.CustomButton.Name = ""
        Me.MTB_VID.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MTB_VID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VID.CustomButton.TabIndex = 1
        Me.MTB_VID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VID.CustomButton.UseSelectable = True
        Me.MTB_VID.CustomButton.Visible = False
        Me.MTB_VID.Lines = New String(-1) {}
        Me.MTB_VID.Location = New System.Drawing.Point(12, 238)
        Me.MTB_VID.MaxLength = 32767
        Me.MTB_VID.Name = "MTB_VID"
        Me.MTB_VID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VID.SelectedText = ""
        Me.MTB_VID.SelectionLength = 0
        Me.MTB_VID.SelectionStart = 0
        Me.MTB_VID.ShortcutsEnabled = True
        Me.MTB_VID.Size = New System.Drawing.Size(43, 23)
        Me.MTB_VID.TabIndex = 9
        Me.MTB_VID.UseSelectable = True
        Me.MTB_VID.Visible = False
        Me.MTB_VID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MTB_VPrice
        '
        '
        '
        '
        Me.MTB_VPrice.CustomButton.Image = Nothing
        Me.MTB_VPrice.CustomButton.Location = New System.Drawing.Point(21, 1)
        Me.MTB_VPrice.CustomButton.Name = ""
        Me.MTB_VPrice.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MTB_VPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VPrice.CustomButton.TabIndex = 1
        Me.MTB_VPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VPrice.CustomButton.UseSelectable = True
        Me.MTB_VPrice.CustomButton.Visible = False
        Me.MTB_VPrice.Lines = New String(-1) {}
        Me.MTB_VPrice.Location = New System.Drawing.Point(61, 238)
        Me.MTB_VPrice.MaxLength = 32767
        Me.MTB_VPrice.Name = "MTB_VPrice"
        Me.MTB_VPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VPrice.SelectedText = ""
        Me.MTB_VPrice.SelectionLength = 0
        Me.MTB_VPrice.SelectionStart = 0
        Me.MTB_VPrice.ShortcutsEnabled = True
        Me.MTB_VPrice.Size = New System.Drawing.Size(43, 23)
        Me.MTB_VPrice.TabIndex = 10
        Me.MTB_VPrice.UseSelectable = True
        Me.MTB_VPrice.Visible = False
        Me.MTB_VPrice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VPrice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PurchaseOrderItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MTB_VPrice)
        Me.Controls.Add(Me.MTB_VID)
        Me.Controls.Add(Me.MB_AddToListProduct)
        Me.Controls.Add(Me.MTB_VQty)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MTB_VName)
        Me.Controls.Add(Me.ML_TName)
        Me.Controls.Add(Me.DGV_ListProduct)
        Me.Controls.Add(Me.MGV_PurchaseOrderItem)
        Me.Name = "PurchaseOrderItem"
        Me.Text = "PurchaseOrderItem"
        CType(Me.MGV_PurchaseOrderItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_ListProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MGV_PurchaseOrderItem As DataGridView
    Friend WithEvents DGV_ListProduct As DataGridView
    Friend WithEvents MTB_VName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ML_TName As MetroFramework.Controls.MetroLabel
    Friend WithEvents MTB_VQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MB_AddToListProduct As MetroFramework.Controls.MetroButton
    Friend WithEvents CID As DataGridViewTextBoxColumn
    Friend WithEvents CName As DataGridViewTextBoxColumn
    Friend WithEvents MTB_VID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents C_Qty As DataGridViewTextBoxColumn
    Friend WithEvents C_Price As DataGridViewTextBoxColumn
    Friend WithEvents C_PID As DataGridViewTextBoxColumn
    Friend WithEvents C_PName As DataGridViewTextBoxColumn
    Friend WithEvents C_AdjustQty As DataGridViewTextBoxColumn
    Friend WithEvents MTB_VPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents C_APrice As DataGridViewTextBoxColumn
End Class
