<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArmarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArmarios))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tabela = New System.Windows.Forms.TabControl()
        Me.Tab1 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbArm001 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tbFiltro = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lvDados = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.menuopc = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Strip1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Strip3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.tbArm002 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbArm008 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnPrinter = New System.Windows.Forms.Button()
        Me.btnaltera = New System.Windows.Forms.Button()
        Me.btnnovo = New System.Windows.Forms.Button()
        Me.btnexcluir = New System.Windows.Forms.Button()
        Me.btncancela = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.btnhome = New System.Windows.Forms.Button()
        Me.tarja = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Tabela.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.menuopc.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tabela)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(282, 126)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(590, 455)
        Me.Panel1.TabIndex = 251
        '
        'Tabela
        '
        Me.Tabela.Controls.Add(Me.Tab1)
        Me.Tabela.Location = New System.Drawing.Point(6, 9)
        Me.Tabela.Name = "Tabela"
        Me.Tabela.SelectedIndex = 0
        Me.Tabela.Size = New System.Drawing.Size(574, 377)
        Me.Tabela.TabIndex = 215
        '
        'Tab1
        '
        Me.Tab1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Tab1.Controls.Add(Me.Panel4)
        Me.Tab1.Controls.Add(Me.GroupBox8)
        Me.Tab1.Controls.Add(Me.GroupBox1)
        Me.Tab1.Location = New System.Drawing.Point(4, 22)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1.Size = New System.Drawing.Size(566, 351)
        Me.Tab1.TabIndex = 0
        Me.Tab1.Text = "Cadastro"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.tbArm001)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.tbFiltro)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.lvDados)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(560, 286)
        Me.Panel4.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(179, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 14)
        Me.Label10.TabIndex = 271
        Me.Label10.Text = "Referência:"
        '
        'tbArm001
        '
        Me.tbArm001.BackColor = System.Drawing.Color.White
        Me.tbArm001.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbArm001.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tbArm001.Location = New System.Drawing.Point(247, 252)
        Me.tbArm001.Name = "tbArm001"
        Me.tbArm001.Size = New System.Drawing.Size(56, 21)
        Me.tbArm001.TabIndex = 270
        Me.tbArm001.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(316, 255)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 14)
        Me.Label23.TabIndex = 268
        Me.Label23.Text = "Filtro:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(245, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(290, 24)
        Me.Button3.TabIndex = 269
        Me.Button3.Text = "Observações"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'tbFiltro
        '
        Me.tbFiltro.BackColor = System.Drawing.Color.White
        Me.tbFiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbFiltro.FormattingEnabled = True
        Me.tbFiltro.Items.AddRange(New Object() {"TODOS OS REGISTROS", "LIVRE", "OCUPADO", "BLOQUEADO"})
        Me.tbFiltro.Location = New System.Drawing.Point(355, 252)
        Me.tbFiltro.Name = "tbFiltro"
        Me.tbFiltro.Size = New System.Drawing.Size(178, 21)
        Me.tbFiltro.TabIndex = 267
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(4, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 24)
        Me.Button2.TabIndex = 267
        Me.Button2.Text = "Número"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(124, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 24)
        Me.Button1.TabIndex = 268
        Me.Button1.Text = "Status"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lvDados
        '
        Me.lvDados.AllowColumnReorder = True
        Me.lvDados.BackColor = System.Drawing.Color.White
        Me.lvDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvDados.ContextMenuStrip = Me.menuopc
        Me.lvDados.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lvDados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lvDados.FullRowSelect = True
        Me.lvDados.GridLines = True
        Me.lvDados.HideSelection = False
        Me.lvDados.Location = New System.Drawing.Point(4, 10)
        Me.lvDados.MultiSelect = False
        Me.lvDados.Name = "lvDados"
        Me.lvDados.Size = New System.Drawing.Size(550, 236)
        Me.lvDados.TabIndex = 264
        Me.lvDados.UseCompatibleStateImageBehavior = False
        Me.lvDados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Width = 290
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Width = 0
        '
        'menuopc
        '
        Me.menuopc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menuopc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuopc.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.menuopc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Strip1, Me.ToolStripSeparator1, Me.Strip3})
        Me.menuopc.Name = "ContextMenuStrip1"
        Me.menuopc.Size = New System.Drawing.Size(184, 82)
        '
        'Strip1
        '
        Me.Strip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Strip1.Image = CType(resources.GetObject("Strip1.Image"), System.Drawing.Image)
        Me.Strip1.Name = "Strip1"
        Me.Strip1.Size = New System.Drawing.Size(183, 36)
        Me.Strip1.Text = "Bloqueio do Armário"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(180, 6)
        '
        'Strip3
        '
        Me.Strip3.Image = CType(resources.GetObject("Strip3.Image"), System.Drawing.Image)
        Me.Strip3.Name = "Strip3"
        Me.Strip3.Size = New System.Drawing.Size(183, 36)
        Me.Strip3.Text = "Liberar o uso"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.tbArm002)
        Me.GroupBox8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox8.Location = New System.Drawing.Point(15, 295)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(97, 44)
        Me.GroupBox8.TabIndex = 265
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Numeração:"
        '
        'tbArm002
        '
        Me.tbArm002.BackColor = System.Drawing.Color.White
        Me.tbArm002.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbArm002.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbArm002.ForeColor = System.Drawing.Color.Blue
        Me.tbArm002.Location = New System.Drawing.Point(21, 16)
        Me.tbArm002.MaxLength = 4
        Me.tbArm002.Name = "tbArm002"
        Me.tbArm002.Size = New System.Drawing.Size(57, 21)
        Me.tbArm002.TabIndex = 259
        Me.tbArm002.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbArm008)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(116, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 44)
        Me.GroupBox1.TabIndex = 266
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Observação:"
        '
        'tbArm008
        '
        Me.tbArm008.BackColor = System.Drawing.Color.White
        Me.tbArm008.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbArm008.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbArm008.ForeColor = System.Drawing.Color.Blue
        Me.tbArm008.Location = New System.Drawing.Point(10, 16)
        Me.tbArm008.MaxLength = 20
        Me.tbArm008.Name = "tbArm008"
        Me.tbArm008.Size = New System.Drawing.Size(423, 21)
        Me.tbArm008.TabIndex = 259
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.btnPrinter)
        Me.Panel3.Controls.Add(Me.btnaltera)
        Me.Panel3.Controls.Add(Me.btnnovo)
        Me.Panel3.Controls.Add(Me.btnexcluir)
        Me.Panel3.Controls.Add(Me.btncancela)
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 391)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(588, 62)
        Me.Panel3.TabIndex = 214
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
        Me.btnPrinter.Location = New System.Drawing.Point(889, 5)
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
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "armario livre_200_200.png")
        Me.ImageList.Images.SetKeyName(1, "armario ocupado_200_200.png")
        Me.ImageList.Images.SetKeyName(2, "armario bloqueado_200_200.png")
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
        Me.btnhome.TabIndex = 314
        Me.btnhome.Text = "Voltar"
        Me.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'tarja
        '
        Me.tarja.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tarja.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tarja.ForeColor = System.Drawing.Color.Gray
        Me.tarja.Location = New System.Drawing.Point(280, 94)
        Me.tarja.Name = "tarja"
        Me.tarja.Size = New System.Drawing.Size(590, 25)
        Me.tarja.TabIndex = 315
        Me.tarja.Text = "Armários rotativo de uso comum"
        Me.tarja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmArmarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1154, 714)
        Me.Controls.Add(Me.tarja)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmArmarios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.Panel1.ResumeLayout(False)
        Me.Tabela.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.menuopc.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbArm001 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents tbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lvDados As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents tbArm002 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbArm008 As System.Windows.Forms.TextBox
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents menuopc As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Strip1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Strip3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnhome As Button
    Friend WithEvents tarja As Label

End Class
