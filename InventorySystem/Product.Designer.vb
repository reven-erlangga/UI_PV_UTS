<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
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
        Me.PB_Barcode = New System.Windows.Forms.PictureBox()
        Me.MB_Generate = New MetroFramework.Controls.MetroButton()
        Me.ML_Name = New MetroFramework.Controls.MetroLabel()
        Me.MTB_Name = New MetroFramework.Controls.MetroTextBox()
        Me.MCB_Gender = New MetroFramework.Controls.MetroComboBox()
        Me.ML_Gender = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        CType(Me.PB_Barcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB_Barcode
        '
        Me.PB_Barcode.Location = New System.Drawing.Point(603, 22)
        Me.PB_Barcode.Name = "PB_Barcode"
        Me.PB_Barcode.Size = New System.Drawing.Size(167, 62)
        Me.PB_Barcode.TabIndex = 0
        Me.PB_Barcode.TabStop = False
        '
        'MB_Generate
        '
        Me.MB_Generate.Location = New System.Drawing.Point(507, 61)
        Me.MB_Generate.Name = "MB_Generate"
        Me.MB_Generate.Size = New System.Drawing.Size(75, 23)
        Me.MB_Generate.TabIndex = 1
        Me.MB_Generate.Text = "Generate"
        Me.MB_Generate.UseSelectable = True
        '
        'ML_Name
        '
        Me.ML_Name.AutoSize = True
        Me.ML_Name.Location = New System.Drawing.Point(23, 22)
        Me.ML_Name.Name = "ML_Name"
        Me.ML_Name.Size = New System.Drawing.Size(45, 19)
        Me.ML_Name.TabIndex = 2
        Me.ML_Name.Text = "Name"
        '
        'MTB_Name
        '
        '
        '
        '
        Me.MTB_Name.CustomButton.Image = Nothing
        Me.MTB_Name.CustomButton.Location = New System.Drawing.Point(286, 1)
        Me.MTB_Name.CustomButton.Name = ""
        Me.MTB_Name.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MTB_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MTB_Name.CustomButton.TabIndex = 1
        Me.MTB_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MTB_Name.CustomButton.UseSelectable = True
        Me.MTB_Name.CustomButton.Visible = False
        Me.MTB_Name.Lines = New String(-1) {}
        Me.MTB_Name.Location = New System.Drawing.Point(23, 49)
        Me.MTB_Name.MaxLength = 32767
        Me.MTB_Name.Name = "MTB_Name"
        Me.MTB_Name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MTB_Name.ReadOnly = True
        Me.MTB_Name.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MTB_Name.SelectedText = ""
        Me.MTB_Name.SelectionLength = 0
        Me.MTB_Name.SelectionStart = 0
        Me.MTB_Name.ShortcutsEnabled = True
        Me.MTB_Name.Size = New System.Drawing.Size(314, 29)
        Me.MTB_Name.TabIndex = 3
        Me.MTB_Name.UseSelectable = True
        Me.MTB_Name.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MTB_Name.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MCB_Gender
        '
        Me.MCB_Gender.FormattingEnabled = True
        Me.MCB_Gender.ItemHeight = 23
        Me.MCB_Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.MCB_Gender.Location = New System.Drawing.Point(23, 138)
        Me.MCB_Gender.Name = "MCB_Gender"
        Me.MCB_Gender.Size = New System.Drawing.Size(314, 29)
        Me.MCB_Gender.TabIndex = 4
        Me.MCB_Gender.UseSelectable = True
        '
        'ML_Gender
        '
        Me.ML_Gender.AutoSize = True
        Me.ML_Gender.Location = New System.Drawing.Point(23, 105)
        Me.ML_Gender.Name = "ML_Gender"
        Me.ML_Gender.Size = New System.Drawing.Size(52, 19)
        Me.ML_Gender.TabIndex = 5
        Me.ML_Gender.Text = "Gender"
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(286, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(366, 138)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ReadOnly = True
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(314, 29)
        Me.MetroTextBox1.TabIndex = 6
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(366, 105)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "Current Stock"
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(609, 2)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(45, 45)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.Lines = New String() {"MetroTextBox2"}
        Me.MetroTextBox2.Location = New System.Drawing.Point(23, 217)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.ShortcutsEnabled = True
        Me.MetroTextBox2.Size = New System.Drawing.Size(657, 50)
        Me.MetroTextBox2.TabIndex = 8
        Me.MetroTextBox2.Text = "MetroTextBox2"
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 186)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel3.TabIndex = 9
        Me.MetroLabel3.Text = "Notes"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(603, 303)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 10
        Me.MetroButton1.Text = "MetroButton1"
        Me.MetroButton1.UseSelectable = True
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.ML_Gender)
        Me.Controls.Add(Me.MCB_Gender)
        Me.Controls.Add(Me.MTB_Name)
        Me.Controls.Add(Me.ML_Name)
        Me.Controls.Add(Me.MB_Generate)
        Me.Controls.Add(Me.PB_Barcode)
        Me.Name = "Product"
        Me.Text = "Product"
        CType(Me.PB_Barcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PB_Barcode As PictureBox
    Friend WithEvents MB_Generate As MetroFramework.Controls.MetroButton
    Friend WithEvents ML_Name As MetroFramework.Controls.MetroLabel
    Friend WithEvents MTB_Name As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MCB_Gender As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ML_Gender As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
