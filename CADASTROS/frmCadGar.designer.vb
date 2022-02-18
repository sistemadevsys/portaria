<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadGar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadGar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tabela = New System.Windows.Forms.TabControl()
        Me.Tab1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.referencial = New System.Windows.Forms.TextBox()
        Me.pEdicao = New System.Windows.Forms.Panel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.tbgar002 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbgar004 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbgar006 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbgar008 = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.tbgar003 = New System.Windows.Forms.ComboBox()
        Me.gList = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbgar001 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lvDados = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.menuopc = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbFiltro = New System.Windows.Forms.ComboBox()
        Me.todos = New System.Windows.Forms.CheckBox()
        Me.Tab2 = New System.Windows.Forms.TabPage()
        Me.PainelMovimento = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.btnhome = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Strip1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Strip2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Strip3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPrinter = New System.Windows.Forms.Button()
        Me.btnaltera = New System.Windows.Forms.Button()
        Me.btnnovo = New System.Windows.Forms.Button()
        Me.btnexcluir = New System.Windows.Forms.Button()
        Me.btncancela = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.tarja = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Tabela.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pEdicao.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.gList.SuspendLayout()
        Me.menuopc.SuspendLayout()
        Me.Tab2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tabela)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.ForeColor = System.Drawing.Color.DimGray
        Me.Panel1.Location = New System.Drawing.Point(275, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(604, 602)
        Me.Panel1.TabIndex = 251
        '
        'Tabela
        '
        Me.Tabela.Controls.Add(Me.Tab1)
        Me.Tabela.Controls.Add(Me.Tab2)
        Me.Tabela.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Tabela.Location = New System.Drawing.Point(7, 10)
        Me.Tabela.Name = "Tabela"
        Me.Tabela.SelectedIndex = 0
        Me.Tabela.Size = New System.Drawing.Size(588, 526)
        Me.Tabela.TabIndex = 215
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.Panel2)
        Me.Tab1.Controls.Add(Me.pEdicao)
        Me.Tab1.Controls.Add(Me.gList)
        Me.Tab1.Location = New System.Drawing.Point(4, 24)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1.Size = New System.Drawing.Size(580, 498)
        Me.Tab1.TabIndex = 0
        Me.Tab1.Text = "Cadastro"
        Me.Tab1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.referencial)
        Me.Panel2.Location = New System.Drawing.Point(92, 670)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(410, 49)
        Me.Panel2.TabIndex = 264
        '
        'referencial
        '
        Me.referencial.BackColor = System.Drawing.Color.Snow
        Me.referencial.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.referencial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.referencial.Location = New System.Drawing.Point(80, 8)
        Me.referencial.MaxLength = 70000
        Me.referencial.Multiline = True
        Me.referencial.Name = "referencial"
        Me.referencial.ReadOnly = True
        Me.referencial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.referencial.Size = New System.Drawing.Size(138, 33)
        Me.referencial.TabIndex = 84
        '
        'pEdicao
        '
        Me.pEdicao.Controls.Add(Me.GroupBox8)
        Me.pEdicao.Controls.Add(Me.GroupBox4)
        Me.pEdicao.Controls.Add(Me.GroupBox2)
        Me.pEdicao.Controls.Add(Me.GroupBox3)
        Me.pEdicao.Controls.Add(Me.GroupBox6)
        Me.pEdicao.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pEdicao.Location = New System.Drawing.Point(3, 336)
        Me.pEdicao.Name = "pEdicao"
        Me.pEdicao.Size = New System.Drawing.Size(574, 159)
        Me.pEdicao.TabIndex = 263
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.tbgar002)
        Me.GroupBox8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox8.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(181, 44)
        Me.GroupBox8.TabIndex = 260
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Identificação:"
        '
        'tbgar002
        '
        Me.tbgar002.BackColor = System.Drawing.Color.White
        Me.tbgar002.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbgar002.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbgar002.ForeColor = System.Drawing.Color.Blue
        Me.tbgar002.Location = New System.Drawing.Point(10, 16)
        Me.tbgar002.MaxLength = 20
        Me.tbgar002.Name = "tbgar002"
        Me.tbgar002.Size = New System.Drawing.Size(163, 21)
        Me.tbgar002.TabIndex = 259
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbgar004)
        Me.GroupBox4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 55)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(568, 98)
        Me.GroupBox4.TabIndex = 261
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Observações"
        '
        'tbgar004
        '
        Me.tbgar004.BackColor = System.Drawing.Color.White
        Me.tbgar004.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbgar004.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbgar004.Location = New System.Drawing.Point(10, 16)
        Me.tbgar004.MaxLength = 70000
        Me.tbgar004.Multiline = True
        Me.tbgar004.Name = "tbgar004"
        Me.tbgar004.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbgar004.Size = New System.Drawing.Size(548, 72)
        Me.tbgar004.TabIndex = 83
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbgar006)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(190, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(77, 44)
        Me.GroupBox2.TabIndex = 261
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "N° Vagas"
        '
        'tbgar006
        '
        Me.tbgar006.BackColor = System.Drawing.Color.White
        Me.tbgar006.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbgar006.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbgar006.ForeColor = System.Drawing.Color.Blue
        Me.tbgar006.Location = New System.Drawing.Point(11, 16)
        Me.tbgar006.MaxLength = 20
        Me.tbgar006.Name = "tbgar006"
        Me.tbgar006.Size = New System.Drawing.Size(56, 21)
        Me.tbgar006.TabIndex = 259
        Me.tbgar006.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbgar008)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(496, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(76, 44)
        Me.GroupBox3.TabIndex = 262
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Especial:"
        '
        'tbgar008
        '
        Me.tbgar008.AutoSize = True
        Me.tbgar008.Location = New System.Drawing.Point(16, 20)
        Me.tbgar008.Name = "tbgar008"
        Me.tbgar008.Size = New System.Drawing.Size(46, 18)
        Me.tbgar008.TabIndex = 263
        Me.tbgar008.Text = "Não"
        Me.tbgar008.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.tbgar003)
        Me.GroupBox6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.Location = New System.Drawing.Point(272, 5)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(221, 44)
        Me.GroupBox6.TabIndex = 262
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Localização:"
        '
        'tbgar003
        '
        Me.tbgar003.BackColor = System.Drawing.Color.White
        Me.tbgar003.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbgar003.FormattingEnabled = True
        Me.tbgar003.Location = New System.Drawing.Point(6, 16)
        Me.tbgar003.Name = "tbgar003"
        Me.tbgar003.Size = New System.Drawing.Size(178, 22)
        Me.tbgar003.TabIndex = 76
        '
        'gList
        '
        Me.gList.Controls.Add(Me.Label10)
        Me.gList.Controls.Add(Me.tbgar001)
        Me.gList.Controls.Add(Me.Button5)
        Me.gList.Controls.Add(Me.Button4)
        Me.gList.Controls.Add(Me.Button3)
        Me.gList.Controls.Add(Me.Button2)
        Me.gList.Controls.Add(Me.Label23)
        Me.gList.Controls.Add(Me.lvDados)
        Me.gList.Controls.Add(Me.tbFiltro)
        Me.gList.Controls.Add(Me.todos)
        Me.gList.Location = New System.Drawing.Point(6, 5)
        Me.gList.Name = "gList"
        Me.gList.Size = New System.Drawing.Size(570, 329)
        Me.gList.TabIndex = 258
        Me.gList.TabStop = False
        Me.gList.Text = "Relação das Garagens:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(213, 303)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 14)
        Me.Label10.TabIndex = 264
        Me.Label10.Text = "Referência:"
        '
        'tbgar001
        '
        Me.tbgar001.BackColor = System.Drawing.Color.White
        Me.tbgar001.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbgar001.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tbgar001.Location = New System.Drawing.Point(281, 299)
        Me.tbgar001.Name = "tbgar001"
        Me.tbgar001.Size = New System.Drawing.Size(56, 21)
        Me.tbgar001.TabIndex = 0
        Me.tbgar001.Text = "0"
        Me.tbgar001.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Gray
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(443, 20)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 24)
        Me.Button5.TabIndex = 263
        Me.Button5.Text = "N° Vagas"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gray
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(323, 20)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(130, 24)
        Me.Button4.TabIndex = 262
        Me.Button4.Text = "Status"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(203, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 24)
        Me.Button3.TabIndex = 261
        Me.Button3.Text = "Localização"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(10, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(196, 24)
        Me.Button2.TabIndex = 260
        Me.Button2.Text = "Identificação"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(343, 302)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 14)
        Me.Label23.TabIndex = 259
        Me.Label23.Text = "Filtro:"
        '
        'lvDados
        '
        Me.lvDados.AllowColumnReorder = True
        Me.lvDados.BackColor = System.Drawing.Color.White
        Me.lvDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvDados.CheckBoxes = True
        Me.lvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvDados.ContextMenuStrip = Me.menuopc
        Me.lvDados.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lvDados.ForeColor = System.Drawing.Color.Black
        Me.lvDados.FullRowSelect = True
        Me.lvDados.GridLines = True
        Me.lvDados.HideSelection = False
        Me.lvDados.Location = New System.Drawing.Point(10, 20)
        Me.lvDados.MultiSelect = False
        Me.lvDados.Name = "lvDados"
        Me.lvDados.Size = New System.Drawing.Size(550, 273)
        Me.lvDados.TabIndex = 256
        Me.lvDados.UseCompatibleStateImageBehavior = False
        Me.lvDados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 192
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Width = 0
        '
        'menuopc
        '
        Me.menuopc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menuopc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuopc.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.menuopc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Strip1, Me.Strip2, Me.ToolStripSeparator1, Me.Strip3})
        Me.menuopc.Name = "ContextMenuStrip1"
        Me.menuopc.Size = New System.Drawing.Size(211, 118)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(207, 6)
        '
        'tbFiltro
        '
        Me.tbFiltro.BackColor = System.Drawing.Color.White
        Me.tbFiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbFiltro.FormattingEnabled = True
        Me.tbFiltro.Items.AddRange(New Object() {"TODAS AS GARAGENS", "LIVRE", "OCUPADO", "BLOQUEADO", "RESERVADO", "MANUTENCAO", "______________________________"})
        Me.tbFiltro.Location = New System.Drawing.Point(382, 299)
        Me.tbFiltro.Name = "tbFiltro"
        Me.tbFiltro.Size = New System.Drawing.Size(178, 23)
        Me.tbFiltro.TabIndex = 76
        '
        'todos
        '
        Me.todos.AutoSize = True
        Me.todos.Location = New System.Drawing.Point(16, 299)
        Me.todos.Name = "todos"
        Me.todos.Size = New System.Drawing.Size(178, 21)
        Me.todos.TabIndex = 257
        Me.todos.Text = "Selecionar todas as vagas"
        Me.todos.UseVisualStyleBackColor = True
        '
        'Tab2
        '
        Me.Tab2.Controls.Add(Me.PainelMovimento)
        Me.Tab2.Location = New System.Drawing.Point(4, 24)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2.Size = New System.Drawing.Size(580, 498)
        Me.Tab2.TabIndex = 1
        Me.Tab2.Text = "Movimentação"
        Me.Tab2.UseVisualStyleBackColor = True
        '
        'PainelMovimento
        '
        Me.PainelMovimento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PainelMovimento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PainelMovimento.Location = New System.Drawing.Point(3, 3)
        Me.PainelMovimento.Name = "PainelMovimento"
        Me.PainelMovimento.Size = New System.Drawing.Size(574, 492)
        Me.PainelMovimento.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.btnPrinter)
        Me.Panel3.Controls.Add(Me.btnaltera)
        Me.Panel3.Controls.Add(Me.btnnovo)
        Me.Panel3.Controls.Add(Me.btnexcluir)
        Me.Panel3.Controls.Add(Me.btncancela)
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 538)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(602, 62)
        Me.Panel3.TabIndex = 214
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "adiciona.png")
        Me.ImageList1.Images.SetKeyName(1, "adiciona1.png")
        Me.ImageList1.Images.SetKeyName(2, "close.png")
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "livres.png")
        Me.ImageList.Images.SetKeyName(1, "Lotado.png")
        Me.ImageList.Images.SetKeyName(2, "Bloqueado01.png")
        Me.ImageList.Images.SetKeyName(3, "BaseReservado01.png")
        Me.ImageList.Images.SetKeyName(4, "ManutencaoBase.png")
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.Transparent
        Me.btnhome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnhome.FlatAppearance.BorderSize = 0
        Me.btnhome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhome.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.ForeColor = System.Drawing.Color.DimGray
        Me.btnhome.Image = CType(resources.GetObject("btnhome.Image"), System.Drawing.Image)
        Me.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhome.Location = New System.Drawing.Point(5, 6)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(115, 46)
        Me.btnhome.TabIndex = 313
        Me.btnhome.Text = "Voltar"
        Me.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(186, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 32)
        Me.Button1.TabIndex = 207
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Strip1
        '
        Me.Strip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Strip1.Image = CType(resources.GetObject("Strip1.Image"), System.Drawing.Image)
        Me.Strip1.Name = "Strip1"
        Me.Strip1.Size = New System.Drawing.Size(210, 36)
        Me.Strip1.Text = "Bloqueio da garagem"
        '
        'Strip2
        '
        Me.Strip2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Strip2.Image = CType(resources.GetObject("Strip2.Image"), System.Drawing.Image)
        Me.Strip2.Name = "Strip2"
        Me.Strip2.Size = New System.Drawing.Size(210, 36)
        Me.Strip2.Text = "Garagem em manutenção"
        '
        'Strip3
        '
        Me.Strip3.Image = CType(resources.GetObject("Strip3.Image"), System.Drawing.Image)
        Me.Strip3.Name = "Strip3"
        Me.Strip3.Size = New System.Drawing.Size(210, 36)
        Me.Strip3.Text = "Libera garagem"
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
        Me.btnPrinter.Location = New System.Drawing.Point(529, 5)
        Me.btnPrinter.Name = "btnPrinter"
        Me.btnPrinter.Size = New System.Drawing.Size(65, 52)
        Me.btnPrinter.TabIndex = 281
        Me.btnPrinter.Text = "Relatório"
        Me.btnPrinter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnPrinter.UseVisualStyleBackColor = False
        '
        'btnaltera
        '
        Me.btnaltera.BackColor = System.Drawing.Color.Transparent
        Me.btnaltera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnaltera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaltera.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnaltera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnaltera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnaltera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaltera.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnaltera.Image = CType(resources.GetObject("btnaltera.Image"), System.Drawing.Image)
        Me.btnaltera.Location = New System.Drawing.Point(72, 5)
        Me.btnaltera.Name = "btnaltera"
        Me.btnaltera.Size = New System.Drawing.Size(65, 52)
        Me.btnaltera.TabIndex = 189
        Me.btnaltera.Text = "Editar"
        Me.btnaltera.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnaltera.UseVisualStyleBackColor = False
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
        Me.btnnovo.TabIndex = 188
        Me.btnnovo.Text = "Incluir"
        Me.btnnovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnnovo.UseVisualStyleBackColor = False
        '
        'btnexcluir
        '
        Me.btnexcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnexcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnexcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnexcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnexcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexcluir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnexcluir.Image = CType(resources.GetObject("btnexcluir.Image"), System.Drawing.Image)
        Me.btnexcluir.Location = New System.Drawing.Point(273, 5)
        Me.btnexcluir.Name = "btnexcluir"
        Me.btnexcluir.Size = New System.Drawing.Size(65, 52)
        Me.btnexcluir.TabIndex = 190
        Me.btnexcluir.Text = "Excluir"
        Me.btnexcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnexcluir.UseVisualStyleBackColor = False
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
        Me.btncancela.Location = New System.Drawing.Point(139, 5)
        Me.btncancela.Name = "btncancela"
        Me.btncancela.Size = New System.Drawing.Size(65, 52)
        Me.btncancela.TabIndex = 193
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
        Me.btnsave.Location = New System.Drawing.Point(206, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(65, 52)
        Me.btnsave.TabIndex = 192
        Me.btnsave.Text = "Gravar"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'tarja
        '
        Me.tarja.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tarja.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tarja.ForeColor = System.Drawing.Color.Gray
        Me.tarja.Location = New System.Drawing.Point(275, 55)
        Me.tarja.Name = "tarja"
        Me.tarja.Size = New System.Drawing.Size(604, 25)
        Me.tarja.TabIndex = 314
        Me.tarja.Text = "Vagas no estacionamento"
        Me.tarja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmCadGar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1154, 714)
        Me.Controls.Add(Me.tarja)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmCadGar"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.Panel1.ResumeLayout(False)
        Me.Tabela.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pEdicao.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.gList.ResumeLayout(False)
        Me.gList.PerformLayout()
        Me.menuopc.ResumeLayout(False)
        Me.Tab2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnPrinter As System.Windows.Forms.Button
    Friend WithEvents btnaltera As System.Windows.Forms.Button
    Friend WithEvents btnnovo As System.Windows.Forms.Button
    Friend WithEvents btnexcluir As System.Windows.Forms.Button
    Friend WithEvents btncancela As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Tabela As System.Windows.Forms.TabControl
    Friend WithEvents Tab1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents referencial As System.Windows.Forms.TextBox
    Friend WithEvents pEdicao As System.Windows.Forms.Panel
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents tbgar002 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tbgar004 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbgar006 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbgar008 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents tbgar003 As System.Windows.Forms.ComboBox
    Friend WithEvents gList As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbgar001 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lvDados As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents menuopc As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Strip1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Strip2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Strip3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents todos As System.Windows.Forms.CheckBox
    Friend WithEvents Tab2 As System.Windows.Forms.TabPage
    Friend WithEvents PainelMovimento As System.Windows.Forms.Panel
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents btnhome As Button
    Friend WithEvents tarja As Label


End Class
