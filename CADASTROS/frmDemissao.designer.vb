<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemissao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDemissao))
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.imgBarra = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnsair = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tab1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FUN002 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FUN003 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gpDemissao = New System.Windows.Forms.GroupBox()
        Me.FUN027 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.FUN007 = New System.Windows.Forms.DateTimePicker()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gpDemissao.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "cadeado.png")
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "word.png")
        Me.ImageList1.Images.SetKeyName(1, "word01.png")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'imgBarra
        '
        Me.imgBarra.ImageStream = CType(resources.GetObject("imgBarra.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgBarra.TransparentColor = System.Drawing.Color.Transparent
        Me.imgBarra.Images.SetKeyName(0, "1486395882-close_80604.png")
        Me.imgBarra.Images.SetKeyName(1, "1486395883-edit_80608.png")
        Me.imgBarra.Images.SetKeyName(2, "emblemremove_93481.png")
        Me.imgBarra.Images.SetKeyName(3, "max.png")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(521, 25)
        Me.Label1.TabIndex = 249
        Me.Label1.Text = "Informações Demissão do Funcionário"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.btnsair)
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 270)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(521, 62)
        Me.Panel3.TabIndex = 251
        '
        'btnsair
        '
        Me.btnsair.BackColor = System.Drawing.Color.Transparent
        Me.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnsair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnsair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnsair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnsair.Image = CType(resources.GetObject("btnsair.Image"), System.Drawing.Image)
        Me.btnsair.Location = New System.Drawing.Point(449, 5)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(65, 52)
        Me.btnsair.TabIndex = 192
        Me.btnsair.Text = "Fechar"
        Me.btnsair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnsair.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Transparent
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(378, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(65, 52)
        Me.btnsave.TabIndex = 192
        Me.btnsave.Text = "Gravar"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tab1)
        Me.TabControl1.Location = New System.Drawing.Point(8, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(500, 225)
        Me.TabControl1.TabIndex = 252
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.GroupBox2)
        Me.Tab1.Controls.Add(Me.gpDemissao)
        Me.Tab1.Controls.Add(Me.GroupBox7)
        Me.Tab1.Location = New System.Drawing.Point(4, 22)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1.Size = New System.Drawing.Size(492, 199)
        Me.Tab1.TabIndex = 0
        Me.Tab1.Text = "Informações"
        Me.Tab1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.FUN002)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.FUN003)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(475, 44)
        Me.GroupBox2.TabIndex = 227
        Me.GroupBox2.TabStop = False
        '
        'FUN002
        '
        Me.FUN002.BackColor = System.Drawing.Color.White
        Me.FUN002.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FUN002.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FUN002.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FUN002.Location = New System.Drawing.Point(6, 12)
        Me.FUN002.Name = "FUN002"
        Me.FUN002.Size = New System.Drawing.Size(80, 22)
        Me.FUN002.TabIndex = 196
        Me.FUN002.Text = "000000"
        Me.FUN002.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, -3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 14)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Registro:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FUN003
        '
        Me.FUN003.BackColor = System.Drawing.Color.White
        Me.FUN003.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FUN003.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FUN003.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FUN003.Location = New System.Drawing.Point(87, 12)
        Me.FUN003.MaxLength = 50
        Me.FUN003.Name = "FUN003"
        Me.FUN003.ReadOnly = True
        Me.FUN003.Size = New System.Drawing.Size(385, 22)
        Me.FUN003.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(90, -3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 14)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Nome:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gpDemissao
        '
        Me.gpDemissao.BackColor = System.Drawing.Color.White
        Me.gpDemissao.Controls.Add(Me.FUN027)
        Me.gpDemissao.Controls.Add(Me.Label31)
        Me.gpDemissao.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gpDemissao.ForeColor = System.Drawing.Color.Red
        Me.gpDemissao.Location = New System.Drawing.Point(8, 106)
        Me.gpDemissao.Name = "gpDemissao"
        Me.gpDemissao.Size = New System.Drawing.Size(475, 78)
        Me.gpDemissao.TabIndex = 226
        Me.gpDemissao.TabStop = False
        Me.gpDemissao.Text = "Observação sobre a demissão:"
        '
        'FUN027
        '
        Me.FUN027.BackColor = System.Drawing.Color.White
        Me.FUN027.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FUN027.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FUN027.ForeColor = System.Drawing.Color.Red
        Me.FUN027.Location = New System.Drawing.Point(7, 17)
        Me.FUN027.MaxLength = 70000
        Me.FUN027.Multiline = True
        Me.FUN027.Name = "FUN027"
        Me.FUN027.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FUN027.Size = New System.Drawing.Size(465, 50)
        Me.FUN027.TabIndex = 221
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(6, 17)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(140, 20)
        Me.Label31.TabIndex = 195
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.FUN007)
        Me.GroupBox7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(137, 44)
        Me.GroupBox7.TabIndex = 224
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Data de Demissão:"
        '
        'FUN007
        '
        Me.FUN007.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FUN007.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FUN007.CalendarMonthBackground = System.Drawing.Color.White
        Me.FUN007.CalendarTitleBackColor = System.Drawing.Color.Blue
        Me.FUN007.CalendarTitleForeColor = System.Drawing.Color.White
        Me.FUN007.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.FUN007.CustomFormat = ""
        Me.FUN007.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.FUN007.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FUN007.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FUN007.Location = New System.Drawing.Point(6, 17)
        Me.FUN007.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.FUN007.MaxDate = New Date(2090, 12, 31, 0, 0, 0, 0)
        Me.FUN007.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.FUN007.Name = "FUN007"
        Me.FUN007.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FUN007.Size = New System.Drawing.Size(111, 21)
        Me.FUN007.TabIndex = 222
        Me.FUN007.Value = New Date(2009, 10, 17, 0, 0, 0, 0)
        '
        'frmDemissao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(521, 332)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.DarkGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDemissao"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gpDemissao.ResumeLayout(False)
        Me.gpDemissao.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Protected WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents imgBarra As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnsair As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Tab1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents FUN002 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents FUN003 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents gpDemissao As System.Windows.Forms.GroupBox
    Friend WithEvents FUN027 As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Protected WithEvents FUN007 As System.Windows.Forms.DateTimePicker




End Class
