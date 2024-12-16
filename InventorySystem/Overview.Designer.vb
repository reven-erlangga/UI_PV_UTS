<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Overview
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
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MT_Cashier = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(29, 63)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(150, 150)
        Me.MetroTile1.TabIndex = 0
        Me.MetroTile1.Text = "Absen Monitoring"
        Me.MetroTile1.UseSelectable = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.Location = New System.Drawing.Point(185, 63)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(150, 150)
        Me.MetroTile2.TabIndex = 1
        Me.MetroTile2.Text = "Admin Panel"
        Me.MetroTile2.UseSelectable = True
        '
        'MT_Cashier
        '
        Me.MT_Cashier.ActiveControl = Nothing
        Me.MT_Cashier.Location = New System.Drawing.Point(341, 63)
        Me.MT_Cashier.Name = "MT_Cashier"
        Me.MT_Cashier.Size = New System.Drawing.Size(150, 150)
        Me.MT_Cashier.TabIndex = 2
        Me.MT_Cashier.Text = "Cashier"
        Me.MT_Cashier.UseSelectable = True
        '
        'Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MT_Cashier)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.MetroTile1)
        Me.Name = "Overview"
        Me.Text = "Overview"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MT_Cashier As MetroFramework.Controls.MetroTile
End Class
