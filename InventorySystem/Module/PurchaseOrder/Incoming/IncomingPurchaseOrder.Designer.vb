<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IncomingPurchaseOrder
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
        Me.MTB_VPurchaseOrderNumber = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.DGV_PurchaseOrderList = New System.Windows.Forms.DataGridView()
        Me.MB_Save = New MetroFramework.Controls.MetroButton()
        Me.C_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_TotalPrice = New System.Windows.Forms.DataGridViewLinkColumn()
        CType(Me.DGV_PurchaseOrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MTB_VPurchaseOrderNumber
        '
        '
        '
        '
        Me.MTB_VPurchaseOrderNumber.CustomButton.Image = Nothing
        Me.MTB_VPurchaseOrderNumber.CustomButton.Location = New System.Drawing.Point(295, 1)
        Me.MTB_VPurchaseOrderNumber.CustomButton.Name = ""
        Me.MTB_VPurchaseOrderNumber.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MTB_VPurchaseOrderNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VPurchaseOrderNumber.CustomButton.TabIndex = 1
        Me.MTB_VPurchaseOrderNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VPurchaseOrderNumber.CustomButton.UseSelectable = True
        Me.MTB_VPurchaseOrderNumber.CustomButton.Visible = False
        Me.MTB_VPurchaseOrderNumber.Lines = New String(-1) {}
        Me.MTB_VPurchaseOrderNumber.Location = New System.Drawing.Point(31, 102)
        Me.MTB_VPurchaseOrderNumber.MaxLength = 32767
        Me.MTB_VPurchaseOrderNumber.Name = "MTB_VPurchaseOrderNumber"
        Me.MTB_VPurchaseOrderNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VPurchaseOrderNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VPurchaseOrderNumber.SelectedText = ""
        Me.MTB_VPurchaseOrderNumber.SelectionLength = 0
        Me.MTB_VPurchaseOrderNumber.SelectionStart = 0
        Me.MTB_VPurchaseOrderNumber.ShortcutsEnabled = True
        Me.MTB_VPurchaseOrderNumber.Size = New System.Drawing.Size(317, 23)
        Me.MTB_VPurchaseOrderNumber.TabIndex = 0
        Me.MTB_VPurchaseOrderNumber.UseSelectable = True
        Me.MTB_VPurchaseOrderNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VPurchaseOrderNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(31, 71)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(154, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Purchase Order Number"
        '
        'DGV_PurchaseOrderList
        '
        Me.DGV_PurchaseOrderList.AllowUserToAddRows = False
        Me.DGV_PurchaseOrderList.AllowUserToDeleteRows = False
        Me.DGV_PurchaseOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PurchaseOrderList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_ID, Me.C_ProductID, Me.C_Name, Me.C_Qty, Me.C_UnitPrice, Me.C_TotalPrice})
        Me.DGV_PurchaseOrderList.Location = New System.Drawing.Point(31, 181)
        Me.DGV_PurchaseOrderList.Name = "DGV_PurchaseOrderList"
        Me.DGV_PurchaseOrderList.Size = New System.Drawing.Size(726, 240)
        Me.DGV_PurchaseOrderList.TabIndex = 2
        '
        'MB_Save
        '
        Me.MB_Save.Location = New System.Drawing.Point(682, 152)
        Me.MB_Save.Name = "MB_Save"
        Me.MB_Save.Size = New System.Drawing.Size(75, 23)
        Me.MB_Save.TabIndex = 3
        Me.MB_Save.Text = "Save"
        Me.MB_Save.UseSelectable = True
        '
        'C_ID
        '
        Me.C_ID.HeaderText = "ID"
        Me.C_ID.Name = "C_ID"
        Me.C_ID.Visible = False
        '
        'C_ProductID
        '
        Me.C_ProductID.HeaderText = "Product ID"
        Me.C_ProductID.Name = "C_ProductID"
        Me.C_ProductID.Visible = False
        '
        'C_Name
        '
        Me.C_Name.HeaderText = "Name"
        Me.C_Name.Name = "C_Name"
        '
        'C_Qty
        '
        Me.C_Qty.HeaderText = "Qty"
        Me.C_Qty.Name = "C_Qty"
        '
        'C_UnitPrice
        '
        Me.C_UnitPrice.HeaderText = "Unit Price"
        Me.C_UnitPrice.Name = "C_UnitPrice"
        '
        'C_TotalPrice
        '
        Me.C_TotalPrice.HeaderText = "Total Price"
        Me.C_TotalPrice.Name = "C_TotalPrice"
        '
        'IncomingPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MB_Save)
        Me.Controls.Add(Me.DGV_PurchaseOrderList)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MTB_VPurchaseOrderNumber)
        Me.Name = "IncomingPurchaseOrder"
        Me.Text = "IncomingPurchaseOrder"
        CType(Me.DGV_PurchaseOrderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MTB_VPurchaseOrderNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DGV_PurchaseOrderList As DataGridView
    Friend WithEvents MB_Save As MetroFramework.Controls.MetroButton
    Friend WithEvents C_ID As DataGridViewTextBoxColumn
    Friend WithEvents C_ProductID As DataGridViewTextBoxColumn
    Friend WithEvents C_Name As DataGridViewTextBoxColumn
    Friend WithEvents C_Qty As DataGridViewTextBoxColumn
    Friend WithEvents C_UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents C_TotalPrice As DataGridViewLinkColumn
End Class
