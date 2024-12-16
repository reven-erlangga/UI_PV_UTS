<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderTransaction
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
        Me.MTB_VCustomerName = New MetroFramework.Controls.MetroTextBox()
        Me.DGV_ProductList = New System.Windows.Forms.DataGridView()
        Me.C_ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MCB_Product = New MetroFramework.Controls.MetroComboBox()
        Me.MTB_Qty = New MetroFramework.Controls.MetroTextBox()
        Me.MB_AddProduct = New MetroFramework.Controls.MetroButton()
        Me.MB_Order = New MetroFramework.Controls.MetroButton()
        Me.ML_CustomerName = New MetroFramework.Controls.MetroLabel()
        Me.ML_Product = New MetroFramework.Controls.MetroLabel()
        Me.ML_Qty = New MetroFramework.Controls.MetroLabel()
        Me.ML_Note = New MetroFramework.Controls.MetroLabel()
        Me.MTB_VNote = New MetroFramework.Controls.MetroTextBox()
        Me.ML_TotalPrice = New MetroFramework.Controls.MetroLabel()
        Me.C_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV_ProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MTB_VCustomerName
        '
        '
        '
        '
        Me.MTB_VCustomerName.CustomButton.Image = Nothing
        Me.MTB_VCustomerName.CustomButton.Location = New System.Drawing.Point(218, 1)
        Me.MTB_VCustomerName.CustomButton.Name = ""
        Me.MTB_VCustomerName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MTB_VCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VCustomerName.CustomButton.TabIndex = 1
        Me.MTB_VCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VCustomerName.CustomButton.UseSelectable = True
        Me.MTB_VCustomerName.CustomButton.Visible = False
        Me.MTB_VCustomerName.Lines = New String(-1) {}
        Me.MTB_VCustomerName.Location = New System.Drawing.Point(15, 108)
        Me.MTB_VCustomerName.MaxLength = 32767
        Me.MTB_VCustomerName.Name = "MTB_VCustomerName"
        Me.MTB_VCustomerName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VCustomerName.SelectedText = ""
        Me.MTB_VCustomerName.SelectionLength = 0
        Me.MTB_VCustomerName.SelectionStart = 0
        Me.MTB_VCustomerName.ShortcutsEnabled = True
        Me.MTB_VCustomerName.Size = New System.Drawing.Size(240, 30)
        Me.MTB_VCustomerName.TabIndex = 0
        Me.MTB_VCustomerName.UseSelectable = True
        Me.MTB_VCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VCustomerName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'DGV_ProductList
        '
        Me.DGV_ProductList.AllowUserToAddRows = False
        Me.DGV_ProductList.AllowUserToDeleteRows = False
        Me.DGV_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ProductList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_ProductID, Me.C_Name, Me.C_Qty, Me.C_Price})
        Me.DGV_ProductList.Location = New System.Drawing.Point(15, 341)
        Me.DGV_ProductList.Name = "DGV_ProductList"
        Me.DGV_ProductList.ReadOnly = True
        Me.DGV_ProductList.Size = New System.Drawing.Size(776, 137)
        Me.DGV_ProductList.TabIndex = 1
        '
        'C_ProductID
        '
        Me.C_ProductID.HeaderText = "Product ID"
        Me.C_ProductID.Name = "C_ProductID"
        Me.C_ProductID.ReadOnly = True
        Me.C_ProductID.Visible = False
        '
        'C_Name
        '
        Me.C_Name.HeaderText = "Name"
        Me.C_Name.Name = "C_Name"
        Me.C_Name.ReadOnly = True
        '
        'C_Qty
        '
        Me.C_Qty.HeaderText = "Qty"
        Me.C_Qty.Name = "C_Qty"
        Me.C_Qty.ReadOnly = True
        '
        'MCB_Product
        '
        Me.MCB_Product.FormattingEnabled = True
        Me.MCB_Product.ItemHeight = 23
        Me.MCB_Product.Location = New System.Drawing.Point(15, 211)
        Me.MCB_Product.Name = "MCB_Product"
        Me.MCB_Product.Size = New System.Drawing.Size(240, 29)
        Me.MCB_Product.TabIndex = 2
        Me.MCB_Product.UseSelectable = True
        '
        'MTB_Qty
        '
        '
        '
        '
        Me.MTB_Qty.CustomButton.Image = Nothing
        Me.MTB_Qty.CustomButton.Location = New System.Drawing.Point(218, 1)
        Me.MTB_Qty.CustomButton.Name = ""
        Me.MTB_Qty.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MTB_Qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_Qty.CustomButton.TabIndex = 1
        Me.MTB_Qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_Qty.CustomButton.UseSelectable = True
        Me.MTB_Qty.CustomButton.Visible = False
        Me.MTB_Qty.Lines = New String(-1) {}
        Me.MTB_Qty.Location = New System.Drawing.Point(15, 287)
        Me.MTB_Qty.MaxLength = 32767
        Me.MTB_Qty.Name = "MTB_Qty"
        Me.MTB_Qty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_Qty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_Qty.SelectedText = ""
        Me.MTB_Qty.SelectionLength = 0
        Me.MTB_Qty.SelectionStart = 0
        Me.MTB_Qty.ShortcutsEnabled = True
        Me.MTB_Qty.Size = New System.Drawing.Size(240, 30)
        Me.MTB_Qty.TabIndex = 3
        Me.MTB_Qty.UseSelectable = True
        Me.MTB_Qty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_Qty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MB_AddProduct
        '
        Me.MB_AddProduct.Location = New System.Drawing.Point(276, 211)
        Me.MB_AddProduct.Name = "MB_AddProduct"
        Me.MB_AddProduct.Size = New System.Drawing.Size(99, 99)
        Me.MB_AddProduct.TabIndex = 4
        Me.MB_AddProduct.Text = "Add Product"
        Me.MB_AddProduct.UseSelectable = True
        '
        'MB_Order
        '
        Me.MB_Order.Location = New System.Drawing.Point(674, 108)
        Me.MB_Order.Name = "MB_Order"
        Me.MB_Order.Size = New System.Drawing.Size(117, 80)
        Me.MB_Order.TabIndex = 5
        Me.MB_Order.Text = "Order"
        Me.MB_Order.UseSelectable = True
        '
        'ML_CustomerName
        '
        Me.ML_CustomerName.AutoSize = True
        Me.ML_CustomerName.Location = New System.Drawing.Point(15, 76)
        Me.ML_CustomerName.Name = "ML_CustomerName"
        Me.ML_CustomerName.Size = New System.Drawing.Size(106, 19)
        Me.ML_CustomerName.TabIndex = 6
        Me.ML_CustomerName.Text = "Customer Name"
        '
        'ML_Product
        '
        Me.ML_Product.AutoSize = True
        Me.ML_Product.Location = New System.Drawing.Point(15, 179)
        Me.ML_Product.Name = "ML_Product"
        Me.ML_Product.Size = New System.Drawing.Size(55, 19)
        Me.ML_Product.TabIndex = 7
        Me.ML_Product.Text = "Product"
        '
        'ML_Qty
        '
        Me.ML_Qty.AutoSize = True
        Me.ML_Qty.Location = New System.Drawing.Point(15, 255)
        Me.ML_Qty.Name = "ML_Qty"
        Me.ML_Qty.Size = New System.Drawing.Size(30, 19)
        Me.ML_Qty.TabIndex = 8
        Me.ML_Qty.Text = "Qty"
        '
        'ML_Note
        '
        Me.ML_Note.AutoSize = True
        Me.ML_Note.Location = New System.Drawing.Point(276, 76)
        Me.ML_Note.Name = "ML_Note"
        Me.ML_Note.Size = New System.Drawing.Size(38, 19)
        Me.ML_Note.TabIndex = 10
        Me.ML_Note.Text = "Note"
        '
        'MTB_VNote
        '
        '
        '
        '
        Me.MTB_VNote.CustomButton.Image = Nothing
        Me.MTB_VNote.CustomButton.Location = New System.Drawing.Point(304, 2)
        Me.MTB_VNote.CustomButton.Name = ""
        Me.MTB_VNote.CustomButton.Size = New System.Drawing.Size(75, 75)
        Me.MTB_VNote.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VNote.CustomButton.TabIndex = 1
        Me.MTB_VNote.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VNote.CustomButton.UseSelectable = True
        Me.MTB_VNote.CustomButton.Visible = False
        Me.MTB_VNote.Lines = New String(-1) {}
        Me.MTB_VNote.Location = New System.Drawing.Point(276, 108)
        Me.MTB_VNote.MaxLength = 32767
        Me.MTB_VNote.Name = "MTB_VNote"
        Me.MTB_VNote.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VNote.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VNote.SelectedText = ""
        Me.MTB_VNote.SelectionLength = 0
        Me.MTB_VNote.SelectionStart = 0
        Me.MTB_VNote.ShortcutsEnabled = True
        Me.MTB_VNote.Size = New System.Drawing.Size(382, 80)
        Me.MTB_VNote.TabIndex = 9
        Me.MTB_VNote.UseSelectable = True
        Me.MTB_VNote.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VNote.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ML_TotalPrice
        '
        Me.ML_TotalPrice.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.ML_TotalPrice.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.ML_TotalPrice.Location = New System.Drawing.Point(676, 211)
        Me.ML_TotalPrice.Name = "ML_TotalPrice"
        Me.ML_TotalPrice.Size = New System.Drawing.Size(115, 52)
        Me.ML_TotalPrice.TabIndex = 11
        Me.ML_TotalPrice.Text = "0"
        '
        'C_Price
        '
        Me.C_Price.HeaderText = "Price"
        Me.C_Price.Name = "C_Price"
        Me.C_Price.ReadOnly = True
        '
        'OrderTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 510)
        Me.Controls.Add(Me.ML_TotalPrice)
        Me.Controls.Add(Me.ML_Note)
        Me.Controls.Add(Me.MTB_VNote)
        Me.Controls.Add(Me.ML_Qty)
        Me.Controls.Add(Me.ML_Product)
        Me.Controls.Add(Me.ML_CustomerName)
        Me.Controls.Add(Me.MB_Order)
        Me.Controls.Add(Me.MB_AddProduct)
        Me.Controls.Add(Me.MTB_Qty)
        Me.Controls.Add(Me.MCB_Product)
        Me.Controls.Add(Me.DGV_ProductList)
        Me.Controls.Add(Me.MTB_VCustomerName)
        Me.Name = "OrderTransaction"
        Me.Text = "Order"
        CType(Me.DGV_ProductList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MTB_VCustomerName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents DGV_ProductList As DataGridView
    Friend WithEvents MCB_Product As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MTB_Qty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MB_AddProduct As MetroFramework.Controls.MetroButton
    Friend WithEvents MB_Order As MetroFramework.Controls.MetroButton
    Friend WithEvents C_ProductID As DataGridViewTextBoxColumn
    Friend WithEvents C_Name As DataGridViewTextBoxColumn
    Friend WithEvents C_Qty As DataGridViewTextBoxColumn
    Friend WithEvents ML_CustomerName As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_Product As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_Qty As MetroFramework.Controls.MetroLabel
    Friend WithEvents ML_Note As MetroFramework.Controls.MetroLabel
    Friend WithEvents MTB_VNote As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ML_TotalPrice As MetroFramework.Controls.MetroLabel
    Friend WithEvents C_Price As DataGridViewTextBoxColumn
End Class
