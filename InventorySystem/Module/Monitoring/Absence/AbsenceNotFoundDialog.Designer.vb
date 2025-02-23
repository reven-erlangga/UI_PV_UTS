<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbsenceNotFoundDialog
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
        Me.components = New System.ComponentModel.Container()
        Me.T_CloseDialog = New System.Windows.Forms.Timer(Me.components)
        Me.HtmlLabel1 = New MetroFramework.Drawing.Html.HtmlLabel()
        Me.SuspendLayout()
        '
        'T_CloseDialog
        '
        Me.T_CloseDialog.Enabled = True
        Me.T_CloseDialog.Interval = 1000
        '
        'HtmlLabel1
        '
        Me.HtmlLabel1.AutoScroll = True
        Me.HtmlLabel1.AutoScrollMinSize = New System.Drawing.Size(249, 48)
        Me.HtmlLabel1.AutoSize = False
        Me.HtmlLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.HtmlLabel1.Location = New System.Drawing.Point(66, 75)
        Me.HtmlLabel1.Name = "HtmlLabel1"
        Me.HtmlLabel1.Size = New System.Drawing.Size(294, 78)
        Me.HtmlLabel1.TabIndex = 0
        Me.HtmlLabel1.Text = "Data Not Found!"
        Me.HtmlLabel1.UseWaitCursor = True
        '
        'AbsenceNotFoundDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 213)
        Me.Controls.Add(Me.HtmlLabel1)
        Me.Name = "AbsenceNotFoundDialog"
        Me.Text = "AbsenceNotFoundDialog"
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents T_CloseDialog As Timer
    Friend WithEvents HtmlLabel1 As MetroFramework.Drawing.Html.HtmlLabel
End Class
