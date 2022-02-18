<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogMovim
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogMovim))
        Me.lvDados = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CADP003 = New System.Windows.Forms.Label()
        Me.CON04 = New System.Windows.Forms.DateTimePicker()
        Me.CON11 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CADP002 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnProc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CON14 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.VEI002 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.gOcup = New System.Windows.Forms.GroupBox()
        Me.CON07 = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CON10 = New System.Windows.Forms.TextBox()
        Me.CON09 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CON08 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ImageGrid = New System.Windows.Forms.ImageList(Me.components)
        Me.imgStatus = New System.Windows.Forms.PictureBox()
        Me.gVei = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.VEI004 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VEI003 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VEI005 = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.lvAcesso = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gOcup.SuspendLayout()
        CType(Me.CON07, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CON09, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CON08, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gVei.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvDados
        '
        Me.lvDados.AllowColumnReorder = True
        Me.lvDados.BackColor = System.Drawing.Color.White
        Me.lvDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvDados.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lvDados.FullRowSelect = True
        Me.lvDados.GridLines = True
        Me.lvDados.HideSelection = False
        Me.lvDados.Location = New System.Drawing.Point(5, 65)
        Me.lvDados.MultiSelect = False
        Me.lvDados.Name = "lvDados"
        Me.lvDados.Size = New System.Drawing.Size(622, 142)
        Me.lvDados.TabIndex = 362
        Me.lvDados.UseCompatibleStateImageBehavior = False
        Me.lvDados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CON01"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "CON02"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "CON04"
        Me.ColumnHeader3.Width = 88
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "CON05"
        Me.ColumnHeader4.Width = 65
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "CON06"
        Me.ColumnHeader5.Width = 148
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "CON11"
        Me.ColumnHeader6.Width = 88
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "CON12"
        Me.ColumnHeader7.Width = 65
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "CON13"
        Me.ColumnHeader8.Width = 148
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "CADP001"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "CADP003"
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "CADP002"
        Me.ColumnHeader11.Width = 0
        '
        'CADP003
        '
        Me.CADP003.ForeColor = System.Drawing.Color.Red
        Me.CADP003.Location = New System.Drawing.Point(6, 14)
        Me.CADP003.Name = "CADP003"
        Me.CADP003.Size = New System.Drawing.Size(302, 21)
        Me.CADP003.TabIndex = 365
        Me.CADP003.Text = "Label2"
        Me.CADP003.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CON04
        '
        Me.CON04.CalendarForeColor = System.Drawing.Color.Magenta
        Me.CON04.CalendarMonthBackground = System.Drawing.Color.LavenderBlush
        Me.CON04.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.CON04.CalendarTitleForeColor = System.Drawing.Color.Red
        Me.CON04.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CON04.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CON04.Location = New System.Drawing.Point(6, 14)
        Me.CON04.MaxDate = New Date(2040, 12, 31, 0, 0, 0, 0)
        Me.CON04.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.CON04.Name = "CON04"
        Me.CON04.Size = New System.Drawing.Size(100, 21)
        Me.CON04.TabIndex = 366
        '
        'CON11
        '
        Me.CON11.CalendarForeColor = System.Drawing.Color.Magenta
        Me.CON11.CalendarMonthBackground = System.Drawing.Color.LavenderBlush
        Me.CON11.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.CON11.CalendarTitleForeColor = System.Drawing.Color.Red
        Me.CON11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CON11.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CON11.Location = New System.Drawing.Point(140, 14)
        Me.CON11.MaxDate = New Date(2040, 12, 31, 0, 0, 0, 0)
        Me.CON11.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.CON11.Name = "CON11"
        Me.CON11.Size = New System.Drawing.Size(100, 21)
        Me.CON11.TabIndex = 367
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CADP003)
        Me.GroupBox1.Controls.Add(Me.CADP002)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 42)
        Me.GroupBox1.TabIndex = 368
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identificação                       :"
        '
        'CADP002
        '
        Me.CADP002.BackColor = System.Drawing.Color.White
        Me.CADP002.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CADP002.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CADP002.Enabled = False
        Me.CADP002.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CADP002.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CADP002.Location = New System.Drawing.Point(76, -3)
        Me.CADP002.MaxLength = 30
        Me.CADP002.Name = "CADP002"
        Me.CADP002.ReadOnly = True
        Me.CADP002.Size = New System.Drawing.Size(62, 21)
        Me.CADP002.TabIndex = 328
        Me.CADP002.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnProc)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CON04)
        Me.GroupBox2.Controls.Add(Me.CON11)
        Me.GroupBox2.Location = New System.Drawing.Point(327, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 42)
        Me.GroupBox2.TabIndex = 369
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Periodo da seleção:"
        '
        'btnProc
        '
        Me.btnProc.BackColor = System.Drawing.Color.White
        Me.btnProc.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnProc.FlatAppearance.BorderSize = 0
        Me.btnProc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnProc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProc.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProc.ForeColor = System.Drawing.Color.Red
        Me.btnProc.Image = CType(resources.GetObject("btnProc.Image"), System.Drawing.Image)
        Me.btnProc.Location = New System.Drawing.Point(248, 8)
        Me.btnProc.Name = "btnProc"
        Me.btnProc.Size = New System.Drawing.Size(30, 30)
        Me.btnProc.TabIndex = 370
        Me.btnProc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.btnProc, "Processa periodo registro selecionado")
        Me.btnProc.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 370
        Me.Label1.Text = "até"
        '
        'CON14
        '
        Me.CON14.BackColor = System.Drawing.Color.White
        Me.CON14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CON14.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.CON14.ForeColor = System.Drawing.Color.Black
        Me.CON14.Location = New System.Drawing.Point(535, 234)
        Me.CON14.MaxLength = 1000
        Me.CON14.Multiline = True
        Me.CON14.Name = "CON14"
        Me.CON14.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CON14.Size = New System.Drawing.Size(398, 142)
        Me.CON14.TabIndex = 370
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 372
        Me.Label2.Text = "Registro inicial portaria:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(537, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 373
        Me.Label3.Text = "Registro de Ocorrências"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(865, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 371
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.Button1, "Volta registro inicial")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(901, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 30)
        Me.Button2.TabIndex = 372
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.Button2, "Processa todos os registros no periodo")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'VEI002
        '
        Me.VEI002.BackColor = System.Drawing.Color.White
        Me.VEI002.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.VEI002.FlatAppearance.BorderSize = 0
        Me.VEI002.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.VEI002.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VEI002.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VEI002.ForeColor = System.Drawing.Color.Black
        Me.VEI002.Image = CType(resources.GetObject("VEI002.Image"), System.Drawing.Image)
        Me.VEI002.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VEI002.Location = New System.Drawing.Point(8, 16)
        Me.VEI002.Name = "VEI002"
        Me.VEI002.Size = New System.Drawing.Size(106, 32)
        Me.VEI002.TabIndex = 323
        Me.VEI002.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VEI002.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.VEI002, "Registro do veículo")
        Me.VEI002.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.White
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.Red
        Me.Button14.Image = CType(resources.GetObject("Button14.Image"), System.Drawing.Image)
        Me.Button14.Location = New System.Drawing.Point(226, 10)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(30, 30)
        Me.Button14.TabIndex = 371
        Me.Button14.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.Button14, "Acompanhantes")
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.White
        Me.Button15.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.Red
        Me.Button15.Image = CType(resources.GetObject("Button15.Image"), System.Drawing.Image)
        Me.Button15.Location = New System.Drawing.Point(262, 10)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(30, 30)
        Me.Button15.TabIndex = 372
        Me.Button15.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.Button15, "Exibe imagem principal")
        Me.Button15.UseVisualStyleBackColor = False
        '
        'gOcup
        '
        Me.gOcup.Controls.Add(Me.Button15)
        Me.gOcup.Controls.Add(Me.Button14)
        Me.gOcup.Controls.Add(Me.CON07)
        Me.gOcup.Controls.Add(Me.Label10)
        Me.gOcup.Controls.Add(Me.CON10)
        Me.gOcup.Controls.Add(Me.CON09)
        Me.gOcup.Controls.Add(Me.Label7)
        Me.gOcup.Controls.Add(Me.CON08)
        Me.gOcup.Controls.Add(Me.Label6)
        Me.gOcup.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gOcup.Location = New System.Drawing.Point(631, 49)
        Me.gOcup.Name = "gOcup"
        Me.gOcup.Size = New System.Drawing.Size(302, 73)
        Me.gOcup.TabIndex = 374
        Me.gOcup.TabStop = False
        Me.gOcup.Text = "Ocupação:"
        '
        'CON07
        '
        Me.CON07.BackColor = System.Drawing.Color.White
        Me.CON07.Enabled = False
        Me.CON07.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CON07.Location = New System.Drawing.Point(62, 16)
        Me.CON07.Name = "CON07"
        Me.CON07.Size = New System.Drawing.Size(44, 22)
        Me.CON07.TabIndex = 321
        Me.CON07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(5, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 14)
        Me.Label10.TabIndex = 325
        Me.Label10.Text = "Adultos:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CON10
        '
        Me.CON10.BackColor = System.Drawing.Color.White
        Me.CON10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CON10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CON10.Enabled = False
        Me.CON10.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.CON10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CON10.Location = New System.Drawing.Point(112, 42)
        Me.CON10.MaxLength = 30
        Me.CON10.Name = "CON10"
        Me.CON10.Size = New System.Drawing.Size(182, 21)
        Me.CON10.TabIndex = 324
        '
        'CON09
        '
        Me.CON09.BackColor = System.Drawing.Color.White
        Me.CON09.Enabled = False
        Me.CON09.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CON09.Location = New System.Drawing.Point(62, 42)
        Me.CON09.Name = "CON09"
        Me.CON09.Size = New System.Drawing.Size(44, 22)
        Me.CON09.TabIndex = 323
        Me.CON09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(4, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 14)
        Me.Label7.TabIndex = 327
        Me.Label7.Text = "Animais:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CON08
        '
        Me.CON08.BackColor = System.Drawing.Color.White
        Me.CON08.Enabled = False
        Me.CON08.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CON08.Location = New System.Drawing.Point(174, 16)
        Me.CON08.Name = "CON08"
        Me.CON08.Size = New System.Drawing.Size(44, 22)
        Me.CON08.TabIndex = 322
        Me.CON08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(113, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 14)
        Me.Label6.TabIndex = 326
        Me.Label6.Text = "Crianças:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Gray
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(5, 65)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(91, 24)
        Me.Button7.TabIndex = 375
        Me.Button7.Text = "Abertura"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(94, 65)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 24)
        Me.Button3.TabIndex = 376
        Me.Button3.Text = "Hora"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gray
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(159, 65)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 24)
        Me.Button4.TabIndex = 377
        Me.Button4.Text = "Porteiro"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Gray
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(307, 65)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 24)
        Me.Button5.TabIndex = 378
        Me.Button5.Text = "Encerramento"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Gray
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(395, 65)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(69, 24)
        Me.Button6.TabIndex = 379
        Me.Button6.Text = "Hora"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Gray
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(460, 65)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(149, 24)
        Me.Button8.TabIndex = 380
        Me.Button8.Text = "Porteiro"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'ImageGrid
        '
        Me.ImageGrid.ImageStream = CType(resources.GetObject("ImageGrid.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageGrid.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageGrid.Images.SetKeyName(0, "casa_ocupadas_100_100_green.png")
        Me.ImageGrid.Images.SetKeyName(1, "casa_ocupadas_100_100_red01.png")
        Me.ImageGrid.Images.SetKeyName(2, "fechado01_100_100.png")
        '
        'imgStatus
        '
        Me.imgStatus.Location = New System.Drawing.Point(639, 9)
        Me.imgStatus.Name = "imgStatus"
        Me.imgStatus.Size = New System.Drawing.Size(38, 38)
        Me.imgStatus.TabIndex = 381
        Me.imgStatus.TabStop = False
        '
        'gVei
        '
        Me.gVei.BackColor = System.Drawing.Color.White
        Me.gVei.Controls.Add(Me.Label9)
        Me.gVei.Controls.Add(Me.VEI004)
        Me.gVei.Controls.Add(Me.Label8)
        Me.gVei.Controls.Add(Me.VEI003)
        Me.gVei.Controls.Add(Me.Label5)
        Me.gVei.Controls.Add(Me.VEI005)
        Me.gVei.Controls.Add(Me.VEI002)
        Me.gVei.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gVei.Location = New System.Drawing.Point(630, 123)
        Me.gVei.Name = "gVei"
        Me.gVei.Size = New System.Drawing.Size(302, 92)
        Me.gVei.TabIndex = 375
        Me.gVei.TabStop = False
        Me.gVei.Text = "Dados do veículo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(155, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 14)
        Me.Label9.TabIndex = 393
        Me.Label9.Text = "Modelo:"
        '
        'VEI004
        '
        Me.VEI004.BackColor = System.Drawing.Color.White
        Me.VEI004.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VEI004.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VEI004.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VEI004.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VEI004.Location = New System.Drawing.Point(152, 65)
        Me.VEI004.MaxLength = 30
        Me.VEI004.Name = "VEI004"
        Me.VEI004.ReadOnly = True
        Me.VEI004.Size = New System.Drawing.Size(139, 21)
        Me.VEI004.TabIndex = 392
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 14)
        Me.Label8.TabIndex = 391
        Me.Label8.Text = "Marca:"
        '
        'VEI003
        '
        Me.VEI003.BackColor = System.Drawing.Color.White
        Me.VEI003.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VEI003.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VEI003.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VEI003.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VEI003.Location = New System.Drawing.Point(8, 65)
        Me.VEI003.MaxLength = 30
        Me.VEI003.Name = "VEI003"
        Me.VEI003.ReadOnly = True
        Me.VEI003.Size = New System.Drawing.Size(138, 21)
        Me.VEI003.TabIndex = 390
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(155, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 14)
        Me.Label5.TabIndex = 389
        Me.Label5.Text = "Cor predominante:"
        '
        'VEI005
        '
        Me.VEI005.BackColor = System.Drawing.Color.White
        Me.VEI005.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VEI005.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VEI005.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VEI005.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VEI005.Location = New System.Drawing.Point(152, 26)
        Me.VEI005.MaxLength = 30
        Me.VEI005.Name = "VEI005"
        Me.VEI005.ReadOnly = True
        Me.VEI005.Size = New System.Drawing.Size(139, 21)
        Me.VEI005.TabIndex = 340
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Gray
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(381, 234)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(131, 24)
        Me.Button9.TabIndex = 387
        Me.Button9.Text = "Garagem"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Gray
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(291, 234)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(93, 24)
        Me.Button10.TabIndex = 386
        Me.Button10.Text = "Entrada/Saída"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Gray
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Location = New System.Drawing.Point(151, 234)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(145, 24)
        Me.Button11.TabIndex = 385
        Me.Button11.Text = "Porteiro"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Gray
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button12.ForeColor = System.Drawing.Color.White
        Me.Button12.Location = New System.Drawing.Point(91, 234)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(62, 24)
        Me.Button12.TabIndex = 384
        Me.Button12.Text = "Hora"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Gray
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button13.ForeColor = System.Drawing.Color.White
        Me.Button13.Location = New System.Drawing.Point(5, 234)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(90, 24)
        Me.Button13.TabIndex = 383
        Me.Button13.Text = "Data"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'lvAcesso
        '
        Me.lvAcesso.AllowColumnReorder = True
        Me.lvAcesso.BackColor = System.Drawing.Color.White
        Me.lvAcesso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvAcesso.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16})
        Me.lvAcesso.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAcesso.ForeColor = System.Drawing.Color.Black
        Me.lvAcesso.FullRowSelect = True
        Me.lvAcesso.GridLines = True
        Me.lvAcesso.HideSelection = False
        Me.lvAcesso.Location = New System.Drawing.Point(5, 234)
        Me.lvAcesso.MultiSelect = False
        Me.lvAcesso.Name = "lvAcesso"
        Me.lvAcesso.Size = New System.Drawing.Size(524, 142)
        Me.lvAcesso.TabIndex = 382
        Me.lvAcesso.UseCompatibleStateImageBehavior = False
        Me.lvAcesso.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "DATA"
        Me.ColumnHeader12.Width = 85
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "HORA"
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "PORTEIRO"
        Me.ColumnHeader14.Width = 140
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "STATUS"
        Me.ColumnHeader15.Width = 90
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "GARAGEM"
        Me.ColumnHeader16.Width = 130
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(6, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 13)
        Me.Label4.TabIndex = 388
        Me.Label4.Text = "Movimento de  Entrada e Saída do registro"
        '
        'frmLogMovim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(937, 379)
        Me.ControlBox = False
        Me.Controls.Add(Me.CON14)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.lvAcesso)
        Me.Controls.Add(Me.imgStatus)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.gVei)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.gOcup)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lvDados)
        Me.ForeColor = System.Drawing.Color.DarkGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogMovim"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gOcup.ResumeLayout(False)
        Me.gOcup.PerformLayout()
        CType(Me.CON07, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CON09, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CON08, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gVei.ResumeLayout(False)
        Me.gVei.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvDados As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents CADP003 As Label
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents CON04 As DateTimePicker
    Friend WithEvents CON11 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnProc As Button
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents CON14 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents gOcup As GroupBox
    Friend WithEvents CON07 As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents CON10 As TextBox
    Friend WithEvents CON09 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents CON08 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents CADP002 As TextBox
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ImageGrid As ImageList
    Friend WithEvents imgStatus As PictureBox
    Friend WithEvents gVei As GroupBox
    Friend WithEvents VEI002 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents lvAcesso As ListView
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents Button14 As Button
    Friend WithEvents VEI005 As TextBox
    Friend WithEvents Button15 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents VEI004 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents VEI003 As TextBox
    Friend WithEvents Label5 As Label
End Class
