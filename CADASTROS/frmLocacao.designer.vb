<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocacao))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPesq = New System.Windows.Forms.Button()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.REGL002 = New System.Windows.Forms.Label()
        Me.gb4 = New System.Windows.Forms.GroupBox()
        Me.CADL003 = New System.Windows.Forms.Label()
        Me.gb3 = New System.Windows.Forms.GroupBox()
        Me.CADL002 = New System.Windows.Forms.TextBox()
        Me.gb5 = New System.Windows.Forms.GroupBox()
        Me.CADP002 = New System.Windows.Forms.Label()
        Me.gb6 = New System.Windows.Forms.GroupBox()
        Me.CADP003 = New System.Windows.Forms.Label()
        Me.gb7 = New System.Windows.Forms.GroupBox()
        Me.REGL003 = New System.Windows.Forms.DateTimePicker()
        Me.gb8 = New System.Windows.Forms.GroupBox()
        Me.REGL004 = New System.Windows.Forms.DateTimePicker()
        Me.gb9 = New System.Windows.Forms.GroupBox()
        Me.gbEnc = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.REGL005 = New System.Windows.Forms.Label()
        Me.gb2 = New System.Windows.Forms.GroupBox()
        Me.acao = New System.Windows.Forms.Label()
        Me.gb10 = New System.Windows.Forms.GroupBox()
        Me.REGL007 = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnEncerraLoc = New System.Windows.Forms.Button()
        Me.btnPrinter = New System.Windows.Forms.Button()
        Me.btnnovo = New System.Windows.Forms.Button()
        Me.btncancela = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.gb11 = New System.Windows.Forms.GroupBox()
        Me.REGL008 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PBaixa = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.iREGL008 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.img = New System.Windows.Forms.PictureBox()
        Me.imgLimpa = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvReloc = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gb1.SuspendLayout()
        Me.gb4.SuspendLayout()
        Me.gb3.SuspendLayout()
        Me.gb5.SuspendLayout()
        Me.gb6.SuspendLayout()
        Me.gb7.SuspendLayout()
        Me.gb8.SuspendLayout()
        Me.gb9.SuspendLayout()
        Me.gbEnc.SuspendLayout()
        Me.gb2.SuspendLayout()
        Me.gb10.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gb11.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PBaixa.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLimpa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'btnPesq
        '
        Me.btnPesq.BackColor = System.Drawing.Color.White
        Me.btnPesq.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnPesq.FlatAppearance.BorderSize = 0
        Me.btnPesq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesq.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesq.ForeColor = System.Drawing.Color.Red
        Me.btnPesq.Image = CType(resources.GetObject("btnPesq.Image"), System.Drawing.Image)
        Me.btnPesq.Location = New System.Drawing.Point(85, 11)
        Me.btnPesq.Name = "btnPesq"
        Me.btnPesq.Size = New System.Drawing.Size(30, 30)
        Me.btnPesq.TabIndex = 329
        Me.btnPesq.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.btnPesq, "Consulta Locatários")
        Me.btnPesq.UseVisualStyleBackColor = False
        '
        'gb1
        '
        Me.gb1.BackColor = System.Drawing.Color.Transparent
        Me.gb1.Controls.Add(Me.REGL002)
        Me.gb1.Location = New System.Drawing.Point(5, 5)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(121, 46)
        Me.gb1.TabIndex = 335
        Me.gb1.TabStop = False
        Me.gb1.Text = "Registro Sistema:"
        '
        'REGL002
        '
        Me.REGL002.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGL002.Location = New System.Drawing.Point(10, 17)
        Me.REGL002.Name = "REGL002"
        Me.REGL002.Size = New System.Drawing.Size(94, 21)
        Me.REGL002.TabIndex = 0
        Me.REGL002.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb4
        '
        Me.gb4.BackColor = System.Drawing.Color.Transparent
        Me.gb4.Controls.Add(Me.CADL003)
        Me.gb4.Location = New System.Drawing.Point(127, 108)
        Me.gb4.Name = "gb4"
        Me.gb4.Size = New System.Drawing.Size(413, 46)
        Me.gb4.TabIndex = 338
        Me.gb4.TabStop = False
        Me.gb4.Text = "Nome do Locatário:"
        '
        'CADL003
        '
        Me.CADL003.BackColor = System.Drawing.Color.White
        Me.CADL003.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CADL003.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CADL003.Location = New System.Drawing.Point(14, 16)
        Me.CADL003.Name = "CADL003"
        Me.CADL003.Size = New System.Drawing.Size(390, 22)
        Me.CADL003.TabIndex = 0
        Me.CADL003.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gb3
        '
        Me.gb3.BackColor = System.Drawing.Color.Transparent
        Me.gb3.Controls.Add(Me.CADL002)
        Me.gb3.Controls.Add(Me.btnPesq)
        Me.gb3.Location = New System.Drawing.Point(5, 108)
        Me.gb3.Name = "gb3"
        Me.gb3.Size = New System.Drawing.Size(121, 46)
        Me.gb3.TabIndex = 337
        Me.gb3.TabStop = False
        Me.gb3.Text = "Código Locatário:"
        '
        'CADL002
        '
        Me.CADL002.BackColor = System.Drawing.Color.White
        Me.CADL002.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CADL002.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CADL002.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CADL002.Location = New System.Drawing.Point(14, 17)
        Me.CADL002.MaxLength = 6
        Me.CADL002.Name = "CADL002"
        Me.CADL002.ReadOnly = True
        Me.CADL002.Size = New System.Drawing.Size(63, 22)
        Me.CADL002.TabIndex = 326
        Me.CADL002.Text = "000000"
        Me.CADL002.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gb5
        '
        Me.gb5.BackColor = System.Drawing.Color.Transparent
        Me.gb5.Controls.Add(Me.CADP002)
        Me.gb5.Location = New System.Drawing.Point(5, 56)
        Me.gb5.Name = "gb5"
        Me.gb5.Size = New System.Drawing.Size(121, 46)
        Me.gb5.TabIndex = 336
        Me.gb5.TabStop = False
        Me.gb5.Text = "Apartamento/Casa:"
        '
        'CADP002
        '
        Me.CADP002.BackColor = System.Drawing.Color.White
        Me.CADP002.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CADP002.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CADP002.Location = New System.Drawing.Point(14, 16)
        Me.CADP002.Name = "CADP002"
        Me.CADP002.Size = New System.Drawing.Size(93, 22)
        Me.CADP002.TabIndex = 1
        Me.CADP002.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb6
        '
        Me.gb6.BackColor = System.Drawing.Color.Transparent
        Me.gb6.Controls.Add(Me.CADP003)
        Me.gb6.Location = New System.Drawing.Point(127, 56)
        Me.gb6.Name = "gb6"
        Me.gb6.Size = New System.Drawing.Size(413, 46)
        Me.gb6.TabIndex = 339
        Me.gb6.TabStop = False
        Me.gb6.Text = "Nome do proprietário da unidade:"
        '
        'CADP003
        '
        Me.CADP003.BackColor = System.Drawing.Color.White
        Me.CADP003.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CADP003.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CADP003.Location = New System.Drawing.Point(14, 16)
        Me.CADP003.Name = "CADP003"
        Me.CADP003.Size = New System.Drawing.Size(390, 22)
        Me.CADP003.TabIndex = 1
        Me.CADP003.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gb7
        '
        Me.gb7.BackColor = System.Drawing.Color.Transparent
        Me.gb7.Controls.Add(Me.REGL003)
        Me.gb7.Location = New System.Drawing.Point(5, 157)
        Me.gb7.Name = "gb7"
        Me.gb7.Size = New System.Drawing.Size(152, 46)
        Me.gb7.TabIndex = 341
        Me.gb7.TabStop = False
        Me.gb7.Text = "Inicio da locação:"
        '
        'REGL003
        '
        Me.REGL003.CalendarForeColor = System.Drawing.Color.Magenta
        Me.REGL003.CalendarMonthBackground = System.Drawing.Color.LavenderBlush
        Me.REGL003.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.REGL003.CalendarTitleForeColor = System.Drawing.Color.Red
        Me.REGL003.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGL003.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.REGL003.Location = New System.Drawing.Point(23, 17)
        Me.REGL003.MaxDate = New Date(2040, 12, 31, 0, 0, 0, 0)
        Me.REGL003.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.REGL003.Name = "REGL003"
        Me.REGL003.Size = New System.Drawing.Size(108, 21)
        Me.REGL003.TabIndex = 309
        '
        'gb8
        '
        Me.gb8.BackColor = System.Drawing.Color.Transparent
        Me.gb8.Controls.Add(Me.REGL004)
        Me.gb8.Location = New System.Drawing.Point(163, 157)
        Me.gb8.Name = "gb8"
        Me.gb8.Size = New System.Drawing.Size(152, 46)
        Me.gb8.TabIndex = 342
        Me.gb8.TabStop = False
        Me.gb8.Text = "Previsão Encerramento:"
        '
        'REGL004
        '
        Me.REGL004.CalendarForeColor = System.Drawing.Color.Magenta
        Me.REGL004.CalendarMonthBackground = System.Drawing.Color.LavenderBlush
        Me.REGL004.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.REGL004.CalendarTitleForeColor = System.Drawing.Color.Red
        Me.REGL004.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGL004.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.REGL004.Location = New System.Drawing.Point(23, 17)
        Me.REGL004.MaxDate = New Date(2040, 12, 31, 0, 0, 0, 0)
        Me.REGL004.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.REGL004.Name = "REGL004"
        Me.REGL004.Size = New System.Drawing.Size(108, 21)
        Me.REGL004.TabIndex = 310
        '
        'gb9
        '
        Me.gb9.BackColor = System.Drawing.Color.Transparent
        Me.gb9.Controls.Add(Me.gbEnc)
        Me.gb9.Controls.Add(Me.REGL005)
        Me.gb9.Location = New System.Drawing.Point(320, 157)
        Me.gb9.Name = "gb9"
        Me.gb9.Size = New System.Drawing.Size(220, 151)
        Me.gb9.TabIndex = 343
        Me.gb9.TabStop = False
        Me.gb9.Text = "Observação:"
        '
        'gbEnc
        '
        Me.gbEnc.BackColor = System.Drawing.Color.Transparent
        Me.gbEnc.Controls.Add(Me.TextBox2)
        Me.gbEnc.Location = New System.Drawing.Point(33, 73)
        Me.gbEnc.Name = "gbEnc"
        Me.gbEnc.Size = New System.Drawing.Size(152, 46)
        Me.gbEnc.TabIndex = 336
        Me.gbEnc.TabStop = False
        Me.gbEnc.Text = "Data do Encerramento:"
        Me.gbEnc.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(17, 20)
        Me.TextBox2.MaxLength = 6
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(117, 15)
        Me.TextBox2.TabIndex = 327
        Me.TextBox2.Text = "99/99/9999"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGL005
        '
        Me.REGL005.BackColor = System.Drawing.Color.White
        Me.REGL005.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.REGL005.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGL005.ForeColor = System.Drawing.Color.Red
        Me.REGL005.Location = New System.Drawing.Point(14, 36)
        Me.REGL005.Name = "REGL005"
        Me.REGL005.Size = New System.Drawing.Size(195, 21)
        Me.REGL005.TabIndex = 1
        Me.REGL005.Text = "LOCAÇÃO MENSAL"
        Me.REGL005.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb2
        '
        Me.gb2.Controls.Add(Me.acao)
        Me.gb2.Location = New System.Drawing.Point(127, 5)
        Me.gb2.Name = "gb2"
        Me.gb2.Size = New System.Drawing.Size(413, 46)
        Me.gb2.TabIndex = 340
        Me.gb2.TabStop = False
        '
        'acao
        '
        Me.acao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.acao.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acao.Image = CType(resources.GetObject("acao.Image"), System.Drawing.Image)
        Me.acao.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.acao.Location = New System.Drawing.Point(17, 16)
        Me.acao.Name = "acao"
        Me.acao.Size = New System.Drawing.Size(387, 21)
        Me.acao.TabIndex = 1
        Me.acao.Text = "REGISTRO DE CONTRATO DE LOCAÇÃO DE UNIDADE"
        Me.acao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb10
        '
        Me.gb10.BackColor = System.Drawing.Color.Transparent
        Me.gb10.Controls.Add(Me.REGL007)
        Me.gb10.Location = New System.Drawing.Point(233, 187)
        Me.gb10.Name = "gb10"
        Me.gb10.Size = New System.Drawing.Size(152, 46)
        Me.gb10.TabIndex = 335
        Me.gb10.TabStop = False
        Me.gb10.Text = "Data do Encerramento:"
        '
        'REGL007
        '
        Me.REGL007.CalendarForeColor = System.Drawing.Color.Magenta
        Me.REGL007.CalendarMonthBackground = System.Drawing.Color.LavenderBlush
        Me.REGL007.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.REGL007.CalendarTitleForeColor = System.Drawing.Color.Red
        Me.REGL007.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGL007.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.REGL007.Location = New System.Drawing.Point(23, 17)
        Me.REGL007.MaxDate = New Date(2040, 12, 31, 0, 0, 0, 0)
        Me.REGL007.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.REGL007.Name = "REGL007"
        Me.REGL007.Size = New System.Drawing.Size(108, 21)
        Me.REGL007.TabIndex = 309
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.btnEncerraLoc)
        Me.Panel3.Controls.Add(Me.btnPrinter)
        Me.Panel3.Controls.Add(Me.btnnovo)
        Me.Panel3.Controls.Add(Me.btncancela)
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Location = New System.Drawing.Point(1, 331)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(950, 62)
        Me.Panel3.TabIndex = 250
        '
        'btnEncerraLoc
        '
        Me.btnEncerraLoc.BackColor = System.Drawing.Color.Transparent
        Me.btnEncerraLoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEncerraLoc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEncerraLoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEncerraLoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnEncerraLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEncerraLoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnEncerraLoc.Image = CType(resources.GetObject("btnEncerraLoc.Image"), System.Drawing.Image)
        Me.btnEncerraLoc.Location = New System.Drawing.Point(283, 5)
        Me.btnEncerraLoc.Name = "btnEncerraLoc"
        Me.btnEncerraLoc.Size = New System.Drawing.Size(180, 52)
        Me.btnEncerraLoc.TabIndex = 313
        Me.btnEncerraLoc.Text = "Baixa Locação"
        Me.btnEncerraLoc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnEncerraLoc.UseVisualStyleBackColor = False
        '
        'btnPrinter
        '
        Me.btnPrinter.BackColor = System.Drawing.Color.Transparent
        Me.btnPrinter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrinter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPrinter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPrinter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrinter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnPrinter.Image = CType(resources.GetObject("btnPrinter.Image"), System.Drawing.Image)
        Me.btnPrinter.Location = New System.Drawing.Point(212, 5)
        Me.btnPrinter.Name = "btnPrinter"
        Me.btnPrinter.Size = New System.Drawing.Size(65, 52)
        Me.btnPrinter.TabIndex = 312
        Me.btnPrinter.Text = "Relatório"
        Me.btnPrinter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnPrinter.UseVisualStyleBackColor = False
        '
        'btnnovo
        '
        Me.btnnovo.BackColor = System.Drawing.Color.Transparent
        Me.btnnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnnovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnnovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnnovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnovo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnnovo.Image = CType(resources.GetObject("btnnovo.Image"), System.Drawing.Image)
        Me.btnnovo.Location = New System.Drawing.Point(5, 5)
        Me.btnnovo.Name = "btnnovo"
        Me.btnnovo.Size = New System.Drawing.Size(65, 52)
        Me.btnnovo.TabIndex = 307
        Me.btnnovo.Text = "Incluir"
        Me.btnnovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnnovo.UseVisualStyleBackColor = False
        '
        'btncancela
        '
        Me.btncancela.BackColor = System.Drawing.Color.Transparent
        Me.btncancela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancela.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancela.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btncancela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btncancela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btncancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancela.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btncancela.Image = CType(resources.GetObject("btncancela.Image"), System.Drawing.Image)
        Me.btncancela.Location = New System.Drawing.Point(75, 5)
        Me.btncancela.Name = "btncancela"
        Me.btncancela.Size = New System.Drawing.Size(65, 52)
        Me.btncancela.TabIndex = 311
        Me.btncancela.Text = "Cancela"
        Me.btncancela.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btncancela.UseVisualStyleBackColor = False
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
        Me.btnsave.Location = New System.Drawing.Point(143, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(65, 52)
        Me.btnsave.TabIndex = 310
        Me.btnsave.Text = "Gravar"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'gb11
        '
        Me.gb11.BackColor = System.Drawing.Color.Transparent
        Me.gb11.Controls.Add(Me.REGL008)
        Me.gb11.Location = New System.Drawing.Point(5, 209)
        Me.gb11.Name = "gb11"
        Me.gb11.Size = New System.Drawing.Size(310, 99)
        Me.gb11.TabIndex = 336
        Me.gb11.TabStop = False
        Me.gb11.Text = "Observação sobre o contrato de locação:"
        '
        'REGL008
        '
        Me.REGL008.BackColor = System.Drawing.Color.White
        Me.REGL008.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.REGL008.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGL008.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.REGL008.Location = New System.Drawing.Point(9, 19)
        Me.REGL008.MaxLength = 70000
        Me.REGL008.Multiline = True
        Me.REGL008.Name = "REGL008"
        Me.REGL008.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.REGL008.Size = New System.Drawing.Size(295, 71)
        Me.REGL008.TabIndex = 311
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PBaixa)
        Me.Panel1.Controls.Add(Me.gb11)
        Me.Panel1.Controls.Add(Me.gb2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.gb9)
        Me.Panel1.Controls.Add(Me.gb8)
        Me.Panel1.Controls.Add(Me.gb7)
        Me.Panel1.Controls.Add(Me.gb6)
        Me.Panel1.Controls.Add(Me.gb5)
        Me.Panel1.Controls.Add(Me.gb3)
        Me.Panel1.Controls.Add(Me.gb4)
        Me.Panel1.Controls.Add(Me.gb1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 331)
        Me.Panel1.TabIndex = 312
        '
        'PBaixa
        '
        Me.PBaixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBaixa.Controls.Add(Me.Button1)
        Me.PBaixa.Controls.Add(Me.Label2)
        Me.PBaixa.Controls.Add(Me.gb10)
        Me.PBaixa.Controls.Add(Me.iREGL008)
        Me.PBaixa.Location = New System.Drawing.Point(545, 11)
        Me.PBaixa.Name = "PBaixa"
        Me.PBaixa.Size = New System.Drawing.Size(397, 297)
        Me.PBaixa.TabIndex = 313
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(0, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(395, 52)
        Me.Button1.TabIndex = 314
        Me.Button1.Text = "Gravar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(395, 23)
        Me.Label2.TabIndex = 349
        Me.Label2.Text = "Informações adicionais"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'iREGL008
        '
        Me.iREGL008.BackColor = System.Drawing.Color.White
        Me.iREGL008.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.iREGL008.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iREGL008.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.iREGL008.Location = New System.Drawing.Point(14, 32)
        Me.iREGL008.MaxLength = 70000
        Me.iREGL008.Multiline = True
        Me.iREGL008.Name = "iREGL008"
        Me.iREGL008.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.iREGL008.Size = New System.Drawing.Size(371, 149)
        Me.iREGL008.TabIndex = 312
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.img)
        Me.Panel2.Controls.Add(Me.imgLimpa)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lvReloc)
        Me.Panel2.Location = New System.Drawing.Point(545, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(397, 297)
        Me.Panel2.TabIndex = 313
        '
        'img
        '
        Me.img.BackColor = System.Drawing.Color.White
        Me.img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img.ErrorImage = CType(resources.GetObject("img.ErrorImage"), System.Drawing.Image)
        Me.img.InitialImage = CType(resources.GetObject("img.InitialImage"), System.Drawing.Image)
        Me.img.Location = New System.Drawing.Point(145, 30)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(248, 259)
        Me.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img.TabIndex = 345
        Me.img.TabStop = False
        '
        'imgLimpa
        '
        Me.imgLimpa.Image = CType(resources.GetObject("imgLimpa.Image"), System.Drawing.Image)
        Me.imgLimpa.Location = New System.Drawing.Point(214, 86)
        Me.imgLimpa.Name = "imgLimpa"
        Me.imgLimpa.Size = New System.Drawing.Size(121, 123)
        Me.imgLimpa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLimpa.TabIndex = 348
        Me.imgLimpa.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(3, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 25)
        Me.Button2.TabIndex = 346
        Me.Button2.Text = " Protrocolo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 23)
        Me.Label1.TabIndex = 348
        Me.Label1.Text = "Histórico de locações"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvReloc
        '
        Me.lvReloc.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvReloc.AllowColumnReorder = True
        Me.lvReloc.BackColor = System.Drawing.Color.White
        Me.lvReloc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvReloc.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader1})
        Me.lvReloc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvReloc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lvReloc.FullRowSelect = True
        Me.lvReloc.GridLines = True
        Me.lvReloc.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvReloc.HideSelection = False
        Me.lvReloc.Location = New System.Drawing.Point(3, 30)
        Me.lvReloc.MultiSelect = False
        Me.lvReloc.Name = "lvReloc"
        Me.lvReloc.Size = New System.Drawing.Size(140, 259)
        Me.lvReloc.TabIndex = 344
        Me.lvReloc.UseCompatibleStateImageBehavior = False
        Me.lvReloc.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Registro"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'frmLocacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(953, 395)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLocacao"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gb1.ResumeLayout(False)
        Me.gb4.ResumeLayout(False)
        Me.gb3.ResumeLayout(False)
        Me.gb3.PerformLayout()
        Me.gb5.ResumeLayout(False)
        Me.gb6.ResumeLayout(False)
        Me.gb7.ResumeLayout(False)
        Me.gb8.ResumeLayout(False)
        Me.gb9.ResumeLayout(False)
        Me.gbEnc.ResumeLayout(False)
        Me.gbEnc.PerformLayout()
        Me.gb2.ResumeLayout(False)
        Me.gb10.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.gb11.ResumeLayout(False)
        Me.gb11.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.PBaixa.ResumeLayout(False)
        Me.PBaixa.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLimpa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents REGL002 As System.Windows.Forms.Label
    Friend WithEvents gb4 As System.Windows.Forms.GroupBox
    Friend WithEvents CADL003 As System.Windows.Forms.Label
    Friend WithEvents gb3 As System.Windows.Forms.GroupBox
    Friend WithEvents CADL002 As System.Windows.Forms.TextBox
    Friend WithEvents btnPesq As System.Windows.Forms.Button
    Friend WithEvents gb5 As System.Windows.Forms.GroupBox
    Friend WithEvents CADP002 As System.Windows.Forms.Label
    Friend WithEvents gb6 As System.Windows.Forms.GroupBox
    Friend WithEvents CADP003 As System.Windows.Forms.Label
    Friend WithEvents gb7 As System.Windows.Forms.GroupBox
    Friend WithEvents REGL003 As System.Windows.Forms.DateTimePicker
    Friend WithEvents gb8 As System.Windows.Forms.GroupBox
    Friend WithEvents REGL004 As System.Windows.Forms.DateTimePicker
    Friend WithEvents gb9 As System.Windows.Forms.GroupBox
    Friend WithEvents REGL005 As System.Windows.Forms.Label
    Friend WithEvents gb2 As System.Windows.Forms.GroupBox
    Friend WithEvents acao As System.Windows.Forms.Label
    Friend WithEvents gb10 As System.Windows.Forms.GroupBox
    Friend WithEvents REGL007 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnnovo As System.Windows.Forms.Button
    Friend WithEvents btncancela As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents gb11 As System.Windows.Forms.GroupBox
    Friend WithEvents REGL008 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPrinter As System.Windows.Forms.Button
    Friend WithEvents btnEncerraLoc As System.Windows.Forms.Button
    Friend WithEvents PBaixa As System.Windows.Forms.Panel
    Friend WithEvents gbEnc As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents iREGL008 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents img As System.Windows.Forms.PictureBox
    Friend WithEvents imgLimpa As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvReloc As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader



End Class
