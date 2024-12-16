<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_GenerateBarcode
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
        Me.HL_Barcode = New MetroFramework.Drawing.Html.HtmlLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'HL_Barcode
        '
        Me.HL_Barcode.AutoScroll = True
        Me.HL_Barcode.AutoScrollMinSize = New System.Drawing.Size(10, 0)
        Me.HL_Barcode.AutoSize = False
        Me.HL_Barcode.BackColor = System.Drawing.SystemColors.Window
        Me.HL_Barcode.Location = New System.Drawing.Point(12, 40)
        Me.HL_Barcode.Name = "HL_Barcode"
        Me.HL_Barcode.Size = New System.Drawing.Size(776, 71)
        Me.HL_Barcode.TabIndex = 0
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 126)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(418, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "You can add manually with press the key and press button to generate"
        '
        'Product_GenerateBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 165)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.HL_Barcode)
        Me.Name = "Product_GenerateBarcode"
        Me.Text = "Product_GenerateBarcode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HL_Barcode As MetroFramework.Drawing.Html.HtmlLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
