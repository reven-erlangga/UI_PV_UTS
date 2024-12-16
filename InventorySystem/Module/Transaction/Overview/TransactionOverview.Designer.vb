<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransactionOverview
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
        Me.DGV_Transaction = New System.Windows.Forms.DataGridView()
        Me.C_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_InvoiceNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_GrandTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MB_Order = New MetroFramework.Controls.MetroButton()
        CType(Me.DGV_Transaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Transaction
        '
        Me.DGV_Transaction.AllowUserToAddRows = False
        Me.DGV_Transaction.AllowUserToDeleteRows = False
        Me.DGV_Transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Transaction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_ID, Me.C_InvoiceNumber, Me.C_CustomerName, Me.C_Note, Me.C_GrandTotal})
        Me.DGV_Transaction.Location = New System.Drawing.Point(0, 92)
        Me.DGV_Transaction.Name = "DGV_Transaction"
        Me.DGV_Transaction.ReadOnly = True
        Me.DGV_Transaction.Size = New System.Drawing.Size(800, 358)
        Me.DGV_Transaction.TabIndex = 0
        '
        'C_ID
        '
        Me.C_ID.HeaderText = "ID"
        Me.C_ID.Name = "C_ID"
        Me.C_ID.ReadOnly = True
        Me.C_ID.Visible = False
        '
        'C_InvoiceNumber
        '
        Me.C_InvoiceNumber.HeaderText = "Invoice Number"
        Me.C_InvoiceNumber.Name = "C_InvoiceNumber"
        Me.C_InvoiceNumber.ReadOnly = True
        '
        'C_CustomerName
        '
        Me.C_CustomerName.HeaderText = "Customer Name"
        Me.C_CustomerName.Name = "C_CustomerName"
        Me.C_CustomerName.ReadOnly = True
        '
        'C_Note
        '
        Me.C_Note.HeaderText = "Note"
        Me.C_Note.Name = "C_Note"
        Me.C_Note.ReadOnly = True
        '
        'C_GrandTotal
        '
        Me.C_GrandTotal.HeaderText = "Grand Total"
        Me.C_GrandTotal.Name = "C_GrandTotal"
        Me.C_GrandTotal.ReadOnly = True
        '
        'MB_Order
        '
        Me.MB_Order.Location = New System.Drawing.Point(702, 54)
        Me.MB_Order.Name = "MB_Order"
        Me.MB_Order.Size = New System.Drawing.Size(75, 23)
        Me.MB_Order.TabIndex = 1
        Me.MB_Order.Text = "Order"
        Me.MB_Order.UseSelectable = True
        '
        'TransactionOverview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MB_Order)
        Me.Controls.Add(Me.DGV_Transaction)
        Me.Name = "TransactionOverview"
        Me.Text = "Transaction"
        CType(Me.DGV_Transaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_Transaction As DataGridView
    Friend WithEvents C_ID As DataGridViewTextBoxColumn
    Friend WithEvents C_InvoiceNumber As DataGridViewTextBoxColumn
    Friend WithEvents C_CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents C_Note As DataGridViewTextBoxColumn
    Friend WithEvents C_GrandTotal As DataGridViewTextBoxColumn
    Friend WithEvents MB_Order As MetroFramework.Controls.MetroButton
End Class
