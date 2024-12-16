<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShowPurchaseOrder
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
        Me.DGV_POList = New System.Windows.Forms.DataGridView()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.C_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ML_TPurchaseOrder = New MetroFramework.Controls.MetroLabel()
        Me.MTB_VPurchaseOrder = New MetroFramework.Controls.MetroTextBox()
        Me.MTB_VName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MTB_VEmail = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MTB_VHandphone = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MTB_VFax = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MTB_VAddress = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.PB_Barcode = New System.Windows.Forms.PictureBox()
        CType(Me.DGV_POList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Barcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_POList
        '
        Me.DGV_POList.AllowUserToAddRows = False
        Me.DGV_POList.AllowUserToDeleteRows = False
        Me.DGV_POList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_POList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_ID, Me.C_ProductName, Me.C_Qty, Me.C_UnitPrice, Me.C_Price})
        Me.DGV_POList.Location = New System.Drawing.Point(12, 534)
        Me.DGV_POList.Name = "DGV_POList"
        Me.DGV_POList.ReadOnly = True
        Me.DGV_POList.Size = New System.Drawing.Size(776, 168)
        Me.DGV_POList.TabIndex = 0
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(713, 12)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 1
        Me.MetroButton1.Text = "Export"
        Me.MetroButton1.UseSelectable = True
        '
        'C_ID
        '
        Me.C_ID.HeaderText = "ID"
        Me.C_ID.Name = "C_ID"
        Me.C_ID.ReadOnly = True
        Me.C_ID.Visible = False
        '
        'C_ProductName
        '
        Me.C_ProductName.HeaderText = "Product Name"
        Me.C_ProductName.Name = "C_ProductName"
        Me.C_ProductName.ReadOnly = True
        '
        'C_Qty
        '
        Me.C_Qty.HeaderText = "Qty"
        Me.C_Qty.Name = "C_Qty"
        Me.C_Qty.ReadOnly = True
        '
        'C_UnitPrice
        '
        Me.C_UnitPrice.HeaderText = "Unit Price"
        Me.C_UnitPrice.Name = "C_UnitPrice"
        Me.C_UnitPrice.ReadOnly = True
        '
        'C_Price
        '
        Me.C_Price.HeaderText = "Price"
        Me.C_Price.Name = "C_Price"
        Me.C_Price.ReadOnly = True
        '
        'ML_TPurchaseOrder
        '
        Me.ML_TPurchaseOrder.AutoSize = True
        Me.ML_TPurchaseOrder.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ML_TPurchaseOrder.Location = New System.Drawing.Point(12, 40)
        Me.ML_TPurchaseOrder.Name = "ML_TPurchaseOrder"
        Me.ML_TPurchaseOrder.Size = New System.Drawing.Size(101, 19)
        Me.ML_TPurchaseOrder.TabIndex = 2
        Me.ML_TPurchaseOrder.Text = "Purchase Order"
        '
        'MTB_VPurchaseOrder
        '
        '
        '
        '
        Me.MTB_VPurchaseOrder.CustomButton.Image = Nothing
        Me.MTB_VPurchaseOrder.CustomButton.Location = New System.Drawing.Point(322, 2)
        Me.MTB_VPurchaseOrder.CustomButton.Name = ""
        Me.MTB_VPurchaseOrder.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.MTB_VPurchaseOrder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VPurchaseOrder.CustomButton.TabIndex = 1
        Me.MTB_VPurchaseOrder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VPurchaseOrder.CustomButton.UseSelectable = True
        Me.MTB_VPurchaseOrder.CustomButton.Visible = False
        Me.MTB_VPurchaseOrder.Lines = New String(-1) {}
        Me.MTB_VPurchaseOrder.Location = New System.Drawing.Point(12, 72)
        Me.MTB_VPurchaseOrder.MaxLength = 32767
        Me.MTB_VPurchaseOrder.Name = "MTB_VPurchaseOrder"
        Me.MTB_VPurchaseOrder.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VPurchaseOrder.ReadOnly = True
        Me.MTB_VPurchaseOrder.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VPurchaseOrder.SelectedText = ""
        Me.MTB_VPurchaseOrder.SelectionLength = 0
        Me.MTB_VPurchaseOrder.SelectionStart = 0
        Me.MTB_VPurchaseOrder.ShortcutsEnabled = True
        Me.MTB_VPurchaseOrder.Size = New System.Drawing.Size(350, 30)
        Me.MTB_VPurchaseOrder.TabIndex = 3
        Me.MTB_VPurchaseOrder.UseSelectable = True
        Me.MTB_VPurchaseOrder.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VPurchaseOrder.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MTB_VName
        '
        '
        '
        '
        Me.MTB_VName.CustomButton.Image = Nothing
        Me.MTB_VName.CustomButton.Location = New System.Drawing.Point(322, 2)
        Me.MTB_VName.CustomButton.Name = ""
        Me.MTB_VName.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.MTB_VName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VName.CustomButton.TabIndex = 1
        Me.MTB_VName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VName.CustomButton.UseSelectable = True
        Me.MTB_VName.CustomButton.Visible = False
        Me.MTB_VName.Lines = New String(-1) {}
        Me.MTB_VName.Location = New System.Drawing.Point(12, 244)
        Me.MTB_VName.MaxLength = 32767
        Me.MTB_VName.Name = "MTB_VName"
        Me.MTB_VName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VName.ReadOnly = True
        Me.MTB_VName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VName.SelectedText = ""
        Me.MTB_VName.SelectionLength = 0
        Me.MTB_VName.SelectionStart = 0
        Me.MTB_VName.ShortcutsEnabled = True
        Me.MTB_VName.Size = New System.Drawing.Size(350, 30)
        Me.MTB_VName.TabIndex = 5
        Me.MTB_VName.UseSelectable = True
        Me.MTB_VName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 212)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Name"
        '
        'MTB_VEmail
        '
        '
        '
        '
        Me.MTB_VEmail.CustomButton.Image = Nothing
        Me.MTB_VEmail.CustomButton.Location = New System.Drawing.Point(322, 2)
        Me.MTB_VEmail.CustomButton.Name = ""
        Me.MTB_VEmail.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.MTB_VEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VEmail.CustomButton.TabIndex = 1
        Me.MTB_VEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VEmail.CustomButton.UseSelectable = True
        Me.MTB_VEmail.CustomButton.Visible = False
        Me.MTB_VEmail.Lines = New String(-1) {}
        Me.MTB_VEmail.Location = New System.Drawing.Point(438, 244)
        Me.MTB_VEmail.MaxLength = 32767
        Me.MTB_VEmail.Name = "MTB_VEmail"
        Me.MTB_VEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VEmail.ReadOnly = True
        Me.MTB_VEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VEmail.SelectedText = ""
        Me.MTB_VEmail.SelectionLength = 0
        Me.MTB_VEmail.SelectionStart = 0
        Me.MTB_VEmail.ShortcutsEnabled = True
        Me.MTB_VEmail.Size = New System.Drawing.Size(350, 30)
        Me.MTB_VEmail.TabIndex = 7
        Me.MTB_VEmail.UseSelectable = True
        Me.MTB_VEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MetroLabel2.Location = New System.Drawing.Point(438, 212)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel2.TabIndex = 6
        Me.MetroLabel2.Text = "Email"
        '
        'MTB_VHandphone
        '
        '
        '
        '
        Me.MTB_VHandphone.CustomButton.Image = Nothing
        Me.MTB_VHandphone.CustomButton.Location = New System.Drawing.Point(322, 2)
        Me.MTB_VHandphone.CustomButton.Name = ""
        Me.MTB_VHandphone.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.MTB_VHandphone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VHandphone.CustomButton.TabIndex = 1
        Me.MTB_VHandphone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VHandphone.CustomButton.UseSelectable = True
        Me.MTB_VHandphone.CustomButton.Visible = False
        Me.MTB_VHandphone.Lines = New String(-1) {}
        Me.MTB_VHandphone.Location = New System.Drawing.Point(438, 325)
        Me.MTB_VHandphone.MaxLength = 32767
        Me.MTB_VHandphone.Name = "MTB_VHandphone"
        Me.MTB_VHandphone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VHandphone.ReadOnly = True
        Me.MTB_VHandphone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VHandphone.SelectedText = ""
        Me.MTB_VHandphone.SelectionLength = 0
        Me.MTB_VHandphone.SelectionStart = 0
        Me.MTB_VHandphone.ShortcutsEnabled = True
        Me.MTB_VHandphone.Size = New System.Drawing.Size(350, 30)
        Me.MTB_VHandphone.TabIndex = 11
        Me.MTB_VHandphone.UseSelectable = True
        Me.MTB_VHandphone.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VHandphone.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MetroLabel3.Location = New System.Drawing.Point(438, 293)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(77, 19)
        Me.MetroLabel3.TabIndex = 10
        Me.MetroLabel3.Text = "Handphone"
        '
        'MTB_VFax
        '
        '
        '
        '
        Me.MTB_VFax.CustomButton.Image = Nothing
        Me.MTB_VFax.CustomButton.Location = New System.Drawing.Point(322, 2)
        Me.MTB_VFax.CustomButton.Name = ""
        Me.MTB_VFax.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.MTB_VFax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VFax.CustomButton.TabIndex = 1
        Me.MTB_VFax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VFax.CustomButton.UseSelectable = True
        Me.MTB_VFax.CustomButton.Visible = False
        Me.MTB_VFax.Lines = New String(-1) {}
        Me.MTB_VFax.Location = New System.Drawing.Point(12, 325)
        Me.MTB_VFax.MaxLength = 32767
        Me.MTB_VFax.Name = "MTB_VFax"
        Me.MTB_VFax.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VFax.ReadOnly = True
        Me.MTB_VFax.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VFax.SelectedText = ""
        Me.MTB_VFax.SelectionLength = 0
        Me.MTB_VFax.SelectionStart = 0
        Me.MTB_VFax.ShortcutsEnabled = True
        Me.MTB_VFax.Size = New System.Drawing.Size(350, 30)
        Me.MTB_VFax.TabIndex = 9
        Me.MTB_VFax.UseSelectable = True
        Me.MTB_VFax.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VFax.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MetroLabel4.Location = New System.Drawing.Point(12, 293)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(28, 19)
        Me.MetroLabel4.TabIndex = 8
        Me.MetroLabel4.Text = "Fax"
        '
        'MTB_VAddress
        '
        '
        '
        '
        Me.MTB_VAddress.CustomButton.Image = Nothing
        Me.MTB_VAddress.CustomButton.Location = New System.Drawing.Point(678, 2)
        Me.MTB_VAddress.CustomButton.Name = ""
        Me.MTB_VAddress.CustomButton.Size = New System.Drawing.Size(95, 95)
        Me.MTB_VAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_VAddress.CustomButton.TabIndex = 1
        Me.MTB_VAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_VAddress.CustomButton.UseSelectable = True
        Me.MTB_VAddress.CustomButton.Visible = False
        Me.MTB_VAddress.Lines = New String(-1) {}
        Me.MTB_VAddress.Location = New System.Drawing.Point(12, 407)
        Me.MTB_VAddress.MaxLength = 32767
        Me.MTB_VAddress.Name = "MTB_VAddress"
        Me.MTB_VAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_VAddress.ReadOnly = True
        Me.MTB_VAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_VAddress.SelectedText = ""
        Me.MTB_VAddress.SelectionLength = 0
        Me.MTB_VAddress.SelectionStart = 0
        Me.MTB_VAddress.ShortcutsEnabled = True
        Me.MTB_VAddress.Size = New System.Drawing.Size(776, 100)
        Me.MTB_VAddress.TabIndex = 13
        Me.MTB_VAddress.UseSelectable = True
        Me.MTB_VAddress.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_VAddress.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MetroLabel5.Location = New System.Drawing.Point(12, 375)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel5.TabIndex = 12
        Me.MetroLabel5.Text = "Address"
        '
        'PB_Barcode
        '
        Me.PB_Barcode.Location = New System.Drawing.Point(592, 52)
        Me.PB_Barcode.Name = "PB_Barcode"
        Me.PB_Barcode.Size = New System.Drawing.Size(196, 80)
        Me.PB_Barcode.TabIndex = 14
        Me.PB_Barcode.TabStop = False
        '
        'ShowPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 729)
        Me.Controls.Add(Me.PB_Barcode)
        Me.Controls.Add(Me.MTB_VAddress)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MTB_VHandphone)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MTB_VFax)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MTB_VEmail)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MTB_VName)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MTB_VPurchaseOrder)
        Me.Controls.Add(Me.ML_TPurchaseOrder)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.DGV_POList)
        Me.Name = "ShowPurchaseOrder"
        Me.Text = "ShowPurchaseOrder"
        CType(Me.DGV_POList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Barcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_POList As DataGridView
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents C_ID As DataGridViewTextBoxColumn
    Friend WithEvents C_ProductName As DataGridViewTextBoxColumn
    Friend WithEvents C_Qty As DataGridViewTextBoxColumn
    Friend WithEvents C_UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents C_Price As DataGridViewTextBoxColumn
    Friend WithEvents ML_TPurchaseOrder As MetroFramework.Controls.MetroLabel
    Friend WithEvents MTB_VPurchaseOrder As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MTB_VName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MTB_VEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MTB_VHandphone As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MTB_VFax As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MTB_VAddress As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PB_Barcode As PictureBox
End Class
