<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TodayAttendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TodayAttendance))
        Me.DGV_TodayAttendance = New System.Windows.Forms.DataGridView()
        Me.PC_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.V_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.V_Start = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.V_End = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.V_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPS_FetchTodayAttendance = New MetroFramework.Controls.MetroProgressSpinner()
        Me.MT_Back = New MetroFramework.Controls.MetroTile()
        CType(Me.DGV_TodayAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_TodayAttendance
        '
        Me.DGV_TodayAttendance.AllowUserToAddRows = False
        Me.DGV_TodayAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_TodayAttendance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PC_ID, Me.V_Name, Me.V_Start, Me.V_End, Me.V_Status})
        Me.DGV_TodayAttendance.Location = New System.Drawing.Point(25, 220)
        Me.DGV_TodayAttendance.Name = "DGV_TodayAttendance"
        Me.DGV_TodayAttendance.ReadOnly = True
        Me.DGV_TodayAttendance.Size = New System.Drawing.Size(752, 353)
        Me.DGV_TodayAttendance.TabIndex = 0
        '
        'PC_ID
        '
        Me.PC_ID.HeaderText = "ID"
        Me.PC_ID.Name = "PC_ID"
        Me.PC_ID.ReadOnly = True
        Me.PC_ID.Visible = False
        '
        'V_Name
        '
        Me.V_Name.HeaderText = "Employee Name"
        Me.V_Name.Name = "V_Name"
        Me.V_Name.ReadOnly = True
        '
        'V_Start
        '
        Me.V_Start.HeaderText = "Start"
        Me.V_Start.Name = "V_Start"
        Me.V_Start.ReadOnly = True
        '
        'V_End
        '
        Me.V_End.HeaderText = "End"
        Me.V_End.Name = "V_End"
        Me.V_End.ReadOnly = True
        '
        'V_Status
        '
        Me.V_Status.HeaderText = "Status"
        Me.V_Status.Name = "V_Status"
        Me.V_Status.ReadOnly = True
        '
        'MPS_FetchTodayAttendance
        '
        Me.MPS_FetchTodayAttendance.Location = New System.Drawing.Point(761, 583)
        Me.MPS_FetchTodayAttendance.Maximum = 100
        Me.MPS_FetchTodayAttendance.Name = "MPS_FetchTodayAttendance"
        Me.MPS_FetchTodayAttendance.Size = New System.Drawing.Size(16, 16)
        Me.MPS_FetchTodayAttendance.TabIndex = 1
        Me.MPS_FetchTodayAttendance.UseSelectable = True
        Me.MPS_FetchTodayAttendance.Visible = False
        '
        'MT_Back
        '
        Me.MT_Back.ActiveControl = Nothing
        Me.MT_Back.Location = New System.Drawing.Point(23, 63)
        Me.MT_Back.Name = "MT_Back"
        Me.MT_Back.Size = New System.Drawing.Size(80, 80)
        Me.MT_Back.TabIndex = 2
        Me.MT_Back.Text = "Back"
        Me.MT_Back.TileImage = CType(resources.GetObject("MT_Back.TileImage"), System.Drawing.Image)
        Me.MT_Back.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MT_Back.UseSelectable = True
        '
        'TodayAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 622)
        Me.Controls.Add(Me.MT_Back)
        Me.Controls.Add(Me.MPS_FetchTodayAttendance)
        Me.Controls.Add(Me.DGV_TodayAttendance)
        Me.Name = "TodayAttendance"
        Me.Text = "Today Attendance"
        CType(Me.DGV_TodayAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_TodayAttendance As DataGridView
    Friend WithEvents PC_ID As DataGridViewTextBoxColumn
    Friend WithEvents V_Name As DataGridViewTextBoxColumn
    Friend WithEvents V_Start As DataGridViewTextBoxColumn
    Friend WithEvents V_End As DataGridViewTextBoxColumn
    Friend WithEvents V_Status As DataGridViewTextBoxColumn
    Friend WithEvents MPS_FetchTodayAttendance As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents MT_Back As MetroFramework.Controls.MetroTile
End Class
