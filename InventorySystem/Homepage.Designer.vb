<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Homepage
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.MTC_TabControl = New MetroFramework.Controls.MetroTabControl()
        Me.MTP_Overview = New MetroFramework.Controls.MetroTabPage()
        Me.C_Attendance = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.MTP_Employee = New MetroFramework.Controls.MetroTabPage()
        Me.MT_TotalEmployee = New MetroFramework.Controls.MetroTile()
        Me.MT_Division = New MetroFramework.Controls.MetroTile()
        Me.MT_RFIDChecker = New MetroFramework.Controls.MetroTile()
        Me.MT_Department = New MetroFramework.Controls.MetroTile()
        Me.MT_Employee = New MetroFramework.Controls.MetroTile()
        Me.MTP_Attendance = New MetroFramework.Controls.MetroTabPage()
        Me.MT_Clock = New MetroFramework.Controls.MetroTile()
        Me.MT_AttendanceToday = New MetroFramework.Controls.MetroTile()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MTP_Product = New MetroFramework.Controls.MetroTabPage()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MT_TotalProduct = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MT_Product = New MetroFramework.Controls.MetroTile()
        Me.MTP_Transaction = New MetroFramework.Controls.MetroTabPage()
        Me.MT_TotalCustomer = New MetroFramework.Controls.MetroTile()
        Me.MT_TotalTransaction = New MetroFramework.Controls.MetroTile()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MTP_PO = New MetroFramework.Controls.MetroTabPage()
        Me.MT_Incoming = New MetroFramework.Controls.MetroTile()
        Me.MetroTile11 = New MetroFramework.Controls.MetroTile()
        Me.MT_TotalPOProgress = New MetroFramework.Controls.MetroTile()
        Me.MT_TotalPOCompleted = New MetroFramework.Controls.MetroTile()
        Me.MT_TotalPO = New MetroFramework.Controls.MetroTile()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MTC_TabControl.SuspendLayout()
        Me.MTP_Overview.SuspendLayout()
        CType(Me.C_Attendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MTP_Employee.SuspendLayout()
        Me.MTP_Attendance.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MTP_Product.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MTP_Transaction.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MTP_PO.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MTC_TabControl
        '
        Me.MTC_TabControl.Controls.Add(Me.MTP_Overview)
        Me.MTC_TabControl.Controls.Add(Me.MTP_Employee)
        Me.MTC_TabControl.Controls.Add(Me.MTP_Attendance)
        Me.MTC_TabControl.Controls.Add(Me.MTP_Product)
        Me.MTC_TabControl.Controls.Add(Me.MTP_Transaction)
        Me.MTC_TabControl.Controls.Add(Me.MTP_PO)
        Me.MTC_TabControl.Location = New System.Drawing.Point(23, 63)
        Me.MTC_TabControl.Name = "MTC_TabControl"
        Me.MTC_TabControl.SelectedIndex = 3
        Me.MTC_TabControl.Size = New System.Drawing.Size(754, 364)
        Me.MTC_TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.MTC_TabControl.TabIndex = 0
        Me.MTC_TabControl.UseSelectable = True
        '
        'MTP_Overview
        '
        Me.MTP_Overview.Controls.Add(Me.C_Attendance)
        Me.MTP_Overview.HorizontalScrollbarBarColor = True
        Me.MTP_Overview.HorizontalScrollbarHighlightOnWheel = False
        Me.MTP_Overview.HorizontalScrollbarSize = 10
        Me.MTP_Overview.Location = New System.Drawing.Point(4, 38)
        Me.MTP_Overview.Name = "MTP_Overview"
        Me.MTP_Overview.Size = New System.Drawing.Size(746, 322)
        Me.MTP_Overview.TabIndex = 0
        Me.MTP_Overview.Text = "Overview"
        Me.MTP_Overview.VerticalScrollbarBarColor = True
        Me.MTP_Overview.VerticalScrollbarHighlightOnWheel = False
        Me.MTP_Overview.VerticalScrollbarSize = 10
        '
        'C_Attendance
        '
        ChartArea1.Name = "ChartArea1"
        Me.C_Attendance.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.C_Attendance.Legends.Add(Legend1)
        Me.C_Attendance.Location = New System.Drawing.Point(-4, 19)
        Me.C_Attendance.Name = "C_Attendance"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.C_Attendance.Series.Add(Series1)
        Me.C_Attendance.Size = New System.Drawing.Size(754, 300)
        Me.C_Attendance.TabIndex = 2
        Me.C_Attendance.Text = "Chart1"
        '
        'MTP_Employee
        '
        Me.MTP_Employee.Controls.Add(Me.MT_TotalEmployee)
        Me.MTP_Employee.Controls.Add(Me.MT_Division)
        Me.MTP_Employee.Controls.Add(Me.MT_RFIDChecker)
        Me.MTP_Employee.Controls.Add(Me.MT_Department)
        Me.MTP_Employee.Controls.Add(Me.MT_Employee)
        Me.MTP_Employee.HorizontalScrollbarBarColor = True
        Me.MTP_Employee.HorizontalScrollbarHighlightOnWheel = False
        Me.MTP_Employee.HorizontalScrollbarSize = 10
        Me.MTP_Employee.Location = New System.Drawing.Point(4, 38)
        Me.MTP_Employee.Name = "MTP_Employee"
        Me.MTP_Employee.Size = New System.Drawing.Size(746, 322)
        Me.MTP_Employee.TabIndex = 2
        Me.MTP_Employee.Text = "Employee"
        Me.MTP_Employee.VerticalScrollbarBarColor = True
        Me.MTP_Employee.VerticalScrollbarHighlightOnWheel = False
        Me.MTP_Employee.VerticalScrollbarSize = 10
        '
        'MT_TotalEmployee
        '
        Me.MT_TotalEmployee.ActiveControl = Nothing
        Me.MT_TotalEmployee.Enabled = False
        Me.MT_TotalEmployee.Location = New System.Drawing.Point(560, 15)
        Me.MT_TotalEmployee.Name = "MT_TotalEmployee"
        Me.MT_TotalEmployee.Size = New System.Drawing.Size(183, 264)
        Me.MT_TotalEmployee.TabIndex = 6
        Me.MT_TotalEmployee.Text = "130 Employee"
        Me.MT_TotalEmployee.UseSelectable = True
        '
        'MT_Division
        '
        Me.MT_Division.ActiveControl = Nothing
        Me.MT_Division.Location = New System.Drawing.Point(424, 149)
        Me.MT_Division.Name = "MT_Division"
        Me.MT_Division.Size = New System.Drawing.Size(130, 130)
        Me.MT_Division.TabIndex = 5
        Me.MT_Division.Text = "Division"
        Me.MT_Division.UseSelectable = True
        '
        'MT_RFIDChecker
        '
        Me.MT_RFIDChecker.ActiveControl = Nothing
        Me.MT_RFIDChecker.Location = New System.Drawing.Point(288, 15)
        Me.MT_RFIDChecker.Name = "MT_RFIDChecker"
        Me.MT_RFIDChecker.Size = New System.Drawing.Size(266, 130)
        Me.MT_RFIDChecker.TabIndex = 4
        Me.MT_RFIDChecker.Text = "RFID Checker"
        Me.MT_RFIDChecker.UseSelectable = True
        '
        'MT_Department
        '
        Me.MT_Department.ActiveControl = Nothing
        Me.MT_Department.Location = New System.Drawing.Point(288, 149)
        Me.MT_Department.Name = "MT_Department"
        Me.MT_Department.Size = New System.Drawing.Size(130, 130)
        Me.MT_Department.TabIndex = 3
        Me.MT_Department.Text = "Department"
        Me.MT_Department.UseSelectable = True
        '
        'MT_Employee
        '
        Me.MT_Employee.ActiveControl = Nothing
        Me.MT_Employee.Location = New System.Drawing.Point(3, 15)
        Me.MT_Employee.Name = "MT_Employee"
        Me.MT_Employee.Size = New System.Drawing.Size(279, 264)
        Me.MT_Employee.TabIndex = 2
        Me.MT_Employee.Text = "Employee"
        Me.MT_Employee.UseSelectable = True
        '
        'MTP_Attendance
        '
        Me.MTP_Attendance.Controls.Add(Me.MT_Clock)
        Me.MTP_Attendance.Controls.Add(Me.MT_AttendanceToday)
        Me.MTP_Attendance.Controls.Add(Me.PictureBox1)
        Me.MTP_Attendance.HorizontalScrollbarBarColor = True
        Me.MTP_Attendance.HorizontalScrollbarHighlightOnWheel = False
        Me.MTP_Attendance.HorizontalScrollbarSize = 10
        Me.MTP_Attendance.Location = New System.Drawing.Point(4, 38)
        Me.MTP_Attendance.Name = "MTP_Attendance"
        Me.MTP_Attendance.Size = New System.Drawing.Size(746, 322)
        Me.MTP_Attendance.TabIndex = 3
        Me.MTP_Attendance.Text = "Attendances"
        Me.MTP_Attendance.VerticalScrollbarBarColor = True
        Me.MTP_Attendance.VerticalScrollbarHighlightOnWheel = False
        Me.MTP_Attendance.VerticalScrollbarSize = 10
        '
        'MT_Clock
        '
        Me.MT_Clock.ActiveControl = Nothing
        Me.MT_Clock.Enabled = False
        Me.MT_Clock.Location = New System.Drawing.Point(3, 177)
        Me.MT_Clock.Name = "MT_Clock"
        Me.MT_Clock.Size = New System.Drawing.Size(448, 149)
        Me.MT_Clock.TabIndex = 6
        Me.MT_Clock.Text = "10 January 2024"
        Me.MT_Clock.UseSelectable = True
        '
        'MT_AttendanceToday
        '
        Me.MT_AttendanceToday.ActiveControl = Nothing
        Me.MT_AttendanceToday.Location = New System.Drawing.Point(3, 26)
        Me.MT_AttendanceToday.Name = "MT_AttendanceToday"
        Me.MT_AttendanceToday.Size = New System.Drawing.Size(448, 145)
        Me.MT_AttendanceToday.TabIndex = 5
        Me.MT_AttendanceToday.Text = "Overview"
        Me.MT_AttendanceToday.UseSelectable = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.InventorySystem.My.Resources.Resources.img_attendance
        Me.PictureBox1.Location = New System.Drawing.Point(474, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(276, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MTP_Product
        '
        Me.MTP_Product.Controls.Add(Me.PictureBox4)
        Me.MTP_Product.Controls.Add(Me.MT_TotalProduct)
        Me.MTP_Product.Controls.Add(Me.MetroTile2)
        Me.MTP_Product.Controls.Add(Me.MT_Product)
        Me.MTP_Product.HorizontalScrollbarBarColor = True
        Me.MTP_Product.HorizontalScrollbarHighlightOnWheel = False
        Me.MTP_Product.HorizontalScrollbarSize = 10
        Me.MTP_Product.Location = New System.Drawing.Point(4, 38)
        Me.MTP_Product.Name = "MTP_Product"
        Me.MTP_Product.Size = New System.Drawing.Size(746, 322)
        Me.MTP_Product.TabIndex = 4
        Me.MTP_Product.Text = "Product"
        Me.MTP_Product.VerticalScrollbarBarColor = True
        Me.MTP_Product.VerticalScrollbarHighlightOnWheel = False
        Me.MTP_Product.VerticalScrollbarSize = 10
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.InventorySystem.My.Resources.Resources.gadget_store_logo_ed065341_38e5_4c50_9ce2_83f9c8c21b0a
        Me.PictureBox4.Location = New System.Drawing.Point(474, 16)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(276, 300)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'MT_TotalProduct
        '
        Me.MT_TotalProduct.ActiveControl = Nothing
        Me.MT_TotalProduct.Location = New System.Drawing.Point(154, 16)
        Me.MT_TotalProduct.Name = "MT_TotalProduct"
        Me.MT_TotalProduct.Size = New System.Drawing.Size(314, 296)
        Me.MT_TotalProduct.TabIndex = 4
        Me.MT_TotalProduct.Text = "-"
        Me.MT_TotalProduct.UseSelectable = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.Location = New System.Drawing.Point(3, 167)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(145, 145)
        Me.MetroTile2.TabIndex = 3
        Me.MetroTile2.Text = "Product Category"
        Me.MetroTile2.UseSelectable = True
        '
        'MT_Product
        '
        Me.MT_Product.ActiveControl = Nothing
        Me.MT_Product.Location = New System.Drawing.Point(3, 16)
        Me.MT_Product.Name = "MT_Product"
        Me.MT_Product.Size = New System.Drawing.Size(145, 145)
        Me.MT_Product.TabIndex = 2
        Me.MT_Product.Text = "Product"
        Me.MT_Product.UseSelectable = True
        '
        'MTP_Transaction
        '
        Me.MTP_Transaction.Controls.Add(Me.MT_TotalCustomer)
        Me.MTP_Transaction.Controls.Add(Me.MT_TotalTransaction)
        Me.MTP_Transaction.Controls.Add(Me.PictureBox2)
        Me.MTP_Transaction.HorizontalScrollbarBarColor = True
        Me.MTP_Transaction.HorizontalScrollbarHighlightOnWheel = False
        Me.MTP_Transaction.HorizontalScrollbarSize = 10
        Me.MTP_Transaction.Location = New System.Drawing.Point(4, 38)
        Me.MTP_Transaction.Name = "MTP_Transaction"
        Me.MTP_Transaction.Size = New System.Drawing.Size(746, 322)
        Me.MTP_Transaction.TabIndex = 5
        Me.MTP_Transaction.Text = "Transaction"
        Me.MTP_Transaction.VerticalScrollbarBarColor = True
        Me.MTP_Transaction.VerticalScrollbarHighlightOnWheel = False
        Me.MTP_Transaction.VerticalScrollbarSize = 10
        '
        'MT_TotalCustomer
        '
        Me.MT_TotalCustomer.ActiveControl = Nothing
        Me.MT_TotalCustomer.Location = New System.Drawing.Point(377, 165)
        Me.MT_TotalCustomer.Name = "MT_TotalCustomer"
        Me.MT_TotalCustomer.Size = New System.Drawing.Size(366, 145)
        Me.MT_TotalCustomer.TabIndex = 4
        Me.MT_TotalCustomer.Text = "Total Customer"
        Me.MT_TotalCustomer.UseSelectable = True
        '
        'MT_TotalTransaction
        '
        Me.MT_TotalTransaction.ActiveControl = Nothing
        Me.MT_TotalTransaction.Location = New System.Drawing.Point(377, 14)
        Me.MT_TotalTransaction.Name = "MT_TotalTransaction"
        Me.MT_TotalTransaction.Size = New System.Drawing.Size(366, 145)
        Me.MT_TotalTransaction.TabIndex = 3
        Me.MT_TotalTransaction.Text = "Total Transaction"
        Me.MT_TotalTransaction.UseSelectable = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.InventorySystem.My.Resources.Resources.transaction
        Me.PictureBox2.Location = New System.Drawing.Point(0, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(371, 296)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'MTP_PO
        '
        Me.MTP_PO.Controls.Add(Me.MT_Incoming)
        Me.MTP_PO.Controls.Add(Me.MetroTile11)
        Me.MTP_PO.Controls.Add(Me.MT_TotalPOProgress)
        Me.MTP_PO.Controls.Add(Me.MT_TotalPOCompleted)
        Me.MTP_PO.Controls.Add(Me.MT_TotalPO)
        Me.MTP_PO.Controls.Add(Me.PictureBox3)
        Me.MTP_PO.HorizontalScrollbarBarColor = True
        Me.MTP_PO.HorizontalScrollbarHighlightOnWheel = False
        Me.MTP_PO.HorizontalScrollbarSize = 10
        Me.MTP_PO.Location = New System.Drawing.Point(4, 38)
        Me.MTP_PO.Name = "MTP_PO"
        Me.MTP_PO.Size = New System.Drawing.Size(746, 322)
        Me.MTP_PO.TabIndex = 6
        Me.MTP_PO.Text = "Purchase Order"
        Me.MTP_PO.VerticalScrollbarBarColor = True
        Me.MTP_PO.VerticalScrollbarHighlightOnWheel = False
        Me.MTP_PO.VerticalScrollbarSize = 10
        '
        'MT_Incoming
        '
        Me.MT_Incoming.ActiveControl = Nothing
        Me.MT_Incoming.Location = New System.Drawing.Point(379, 164)
        Me.MT_Incoming.Name = "MT_Incoming"
        Me.MT_Incoming.Size = New System.Drawing.Size(145, 145)
        Me.MT_Incoming.TabIndex = 7
        Me.MT_Incoming.Text = "Incoming"
        Me.MT_Incoming.UseSelectable = True
        '
        'MetroTile11
        '
        Me.MetroTile11.ActiveControl = Nothing
        Me.MetroTile11.Location = New System.Drawing.Point(228, 164)
        Me.MetroTile11.Name = "MetroTile11"
        Me.MetroTile11.Size = New System.Drawing.Size(145, 145)
        Me.MetroTile11.TabIndex = 5
        Me.MetroTile11.Text = "PO"
        Me.MetroTile11.UseSelectable = True
        '
        'MT_TotalPOProgress
        '
        Me.MT_TotalPOProgress.ActiveControl = Nothing
        Me.MT_TotalPOProgress.Location = New System.Drawing.Point(379, 13)
        Me.MT_TotalPOProgress.Name = "MT_TotalPOProgress"
        Me.MT_TotalPOProgress.Size = New System.Drawing.Size(145, 145)
        Me.MT_TotalPOProgress.TabIndex = 4
        Me.MT_TotalPOProgress.Text = "-"
        Me.MT_TotalPOProgress.UseSelectable = True
        '
        'MT_TotalPOCompleted
        '
        Me.MT_TotalPOCompleted.ActiveControl = Nothing
        Me.MT_TotalPOCompleted.Location = New System.Drawing.Point(228, 13)
        Me.MT_TotalPOCompleted.Name = "MT_TotalPOCompleted"
        Me.MT_TotalPOCompleted.Size = New System.Drawing.Size(145, 145)
        Me.MT_TotalPOCompleted.TabIndex = 3
        Me.MT_TotalPOCompleted.Text = "-"
        Me.MT_TotalPOCompleted.UseSelectable = True
        '
        'MT_TotalPO
        '
        Me.MT_TotalPO.ActiveControl = Nothing
        Me.MT_TotalPO.Location = New System.Drawing.Point(0, 13)
        Me.MT_TotalPO.Name = "MT_TotalPO"
        Me.MT_TotalPO.Size = New System.Drawing.Size(222, 296)
        Me.MT_TotalPO.TabIndex = 2
        Me.MT_TotalPO.Text = "-"
        Me.MT_TotalPO.UseSelectable = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.InventorySystem.My.Resources.Resources.po
        Me.PictureBox3.Location = New System.Drawing.Point(530, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(220, 296)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 446)
        Me.Controls.Add(Me.MTC_TabControl)
        Me.Name = "Homepage"
        Me.Text = "Homepage"
        Me.MTC_TabControl.ResumeLayout(False)
        Me.MTP_Overview.ResumeLayout(False)
        CType(Me.C_Attendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MTP_Employee.ResumeLayout(False)
        Me.MTP_Attendance.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MTP_Product.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MTP_Transaction.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MTP_PO.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MTC_TabControl As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MTP_Overview As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MTP_Employee As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MT_Employee As MetroFramework.Controls.MetroTile
    Friend WithEvents MT_Department As MetroFramework.Controls.MetroTile
    Friend WithEvents MT_RFIDChecker As MetroFramework.Controls.MetroTile
    Friend WithEvents MT_Division As MetroFramework.Controls.MetroTile
    Friend WithEvents MTP_Attendance As MetroFramework.Controls.MetroTabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MT_AttendanceToday As MetroFramework.Controls.MetroTile
    Friend WithEvents MT_TotalEmployee As MetroFramework.Controls.MetroTile
    Friend WithEvents MT_Clock As MetroFramework.Controls.MetroTile
    Friend WithEvents C_Attendance As DataVisualization.Charting.Chart
    Friend WithEvents MTP_Product As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MT_TotalProduct As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MT_Product As MetroFramework.Controls.MetroTile
    Friend WithEvents MTP_Transaction As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MTP_PO As MetroFramework.Controls.MetroTabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents MT_TotalCustomer As MetroFramework.Controls.MetroTile
    Friend WithEvents MT_TotalTransaction As MetroFramework.Controls.MetroTile
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MetroTile11 As MetroFramework.Controls.MetroTile
    Friend WithEvents MT_TotalPOProgress As MetroFramework.Controls.MetroTile
    Friend WithEvents MT_TotalPO As MetroFramework.Controls.MetroTile
    Friend WithEvents MT_TotalPOCompleted As MetroFramework.Controls.MetroTile
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents MT_Incoming As MetroFramework.Controls.MetroTile
End Class
