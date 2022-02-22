<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Portaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Portaria))
        Me.imgBarra = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageGrid = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnChaves = New System.Windows.Forms.Button()
        Me.btnAcesso = New System.Windows.Forms.Button()
        Me.btnTodos = New System.Windows.Forms.Button()
        Me.btnReservas = New System.Windows.Forms.Button()
        Me.btnAusentes = New System.Windows.Forms.Button()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.btnFiltro = New System.Windows.Forms.Button()
        Me.btnOcupados = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TimeGatilho = New System.Windows.Forms.Timer(Me.components)
        Me.frmBase = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PainelVagas = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.lvDados = New System.Windows.Forms.ListView()
        Me.COL00 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COL01 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COL02 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COL03 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COL04 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COL05 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COL06 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COL07 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer_Movim = New System.Windows.Forms.Timer(Me.components)
        Me.frmBase.SuspendLayout()
        Me.PainelVagas.SuspendLayout()
        Me.SuspendLayout()
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ImageGrid
        '
        Me.ImageGrid.ImageStream = CType(resources.GetObject("ImageGrid.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageGrid.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageGrid.Images.SetKeyName(0, "Livre01.png")
        Me.ImageGrid.Images.SetKeyName(1, "Livre02.png")
        Me.ImageGrid.Images.SetKeyName(2, "Livre03.png")
        Me.ImageGrid.Images.SetKeyName(3, "Livre04.png")
        Me.ImageGrid.Images.SetKeyName(4, "Livre05.png")
        Me.ImageGrid.Images.SetKeyName(5, "Livre06.png")
        Me.ImageGrid.Images.SetKeyName(6, "Livre07.png")
        Me.ImageGrid.Images.SetKeyName(7, "Livre08.png")
        Me.ImageGrid.Images.SetKeyName(8, "Livre09.png")
        Me.ImageGrid.Images.SetKeyName(9, "Ocupado01.png")
        Me.ImageGrid.Images.SetKeyName(10, "Ocupado02.png")
        Me.ImageGrid.Images.SetKeyName(11, "Ocupado03.png")
        Me.ImageGrid.Images.SetKeyName(12, "Ocupado04.png")
        Me.ImageGrid.Images.SetKeyName(13, "Ocupado05.png")
        Me.ImageGrid.Images.SetKeyName(14, "Ocupado06.png")
        Me.ImageGrid.Images.SetKeyName(15, "Ocupado07.png")
        Me.ImageGrid.Images.SetKeyName(16, "Ocupado08.png")
        Me.ImageGrid.Images.SetKeyName(17, "Ocupado09.png")
        Me.ImageGrid.Images.SetKeyName(18, "Lotado.png")
        Me.ImageGrid.Images.SetKeyName(19, "Bloqueado01.png")
        Me.ImageGrid.Images.SetKeyName(20, "BaseReservado01.png")
        Me.ImageGrid.Images.SetKeyName(21, "ManutencaoBase.png")
        Me.ImageGrid.Images.SetKeyName(22, "prancheta002.png")
        Me.ImageGrid.Images.SetKeyName(23, "prancheta001.png")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'btnChaves
        '
        Me.btnChaves.BackColor = System.Drawing.Color.Transparent
        Me.btnChaves.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnChaves.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnChaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChaves.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChaves.ForeColor = System.Drawing.Color.DimGray
        Me.btnChaves.Image = CType(resources.GetObject("btnChaves.Image"), System.Drawing.Image)
        Me.btnChaves.Location = New System.Drawing.Point(1187, 649)
        Me.btnChaves.Name = "btnChaves"
        Me.btnChaves.Size = New System.Drawing.Size(50, 54)
        Me.btnChaves.TabIndex = 345
        Me.btnChaves.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnChaves, "Controle de Chaves")
        Me.btnChaves.UseVisualStyleBackColor = False
        '
        'btnAcesso
        '
        Me.btnAcesso.BackColor = System.Drawing.Color.Transparent
        Me.btnAcesso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAcesso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcesso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcesso.ForeColor = System.Drawing.Color.DimGray
        Me.btnAcesso.Image = CType(resources.GetObject("btnAcesso.Image"), System.Drawing.Image)
        Me.btnAcesso.Location = New System.Drawing.Point(1134, 649)
        Me.btnAcesso.Name = "btnAcesso"
        Me.btnAcesso.Size = New System.Drawing.Size(50, 54)
        Me.btnAcesso.TabIndex = 344
        Me.btnAcesso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnAcesso, "Planilha de controle de acessos geral")
        Me.btnAcesso.UseVisualStyleBackColor = False
        '
        'btnTodos
        '
        Me.btnTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnTodos.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnTodos.FlatAppearance.BorderSize = 0
        Me.btnTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTodos.ForeColor = System.Drawing.Color.DimGray
        Me.btnTodos.Image = CType(resources.GetObject("btnTodos.Image"), System.Drawing.Image)
        Me.btnTodos.Location = New System.Drawing.Point(9, 659)
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.Size = New System.Drawing.Size(35, 35)
        Me.btnTodos.TabIndex = 335
        Me.btnTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnTodos, "Todos os Registros")
        Me.btnTodos.UseVisualStyleBackColor = False
        '
        'btnReservas
        '
        Me.btnReservas.BackColor = System.Drawing.Color.Transparent
        Me.btnReservas.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnReservas.FlatAppearance.BorderSize = 0
        Me.btnReservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservas.ForeColor = System.Drawing.Color.DimGray
        Me.btnReservas.Image = CType(resources.GetObject("btnReservas.Image"), System.Drawing.Image)
        Me.btnReservas.Location = New System.Drawing.Point(214, 659)
        Me.btnReservas.Name = "btnReservas"
        Me.btnReservas.Size = New System.Drawing.Size(35, 35)
        Me.btnReservas.TabIndex = 342
        Me.btnReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnReservas, "Reservas previstas")
        Me.btnReservas.UseVisualStyleBackColor = False
        Me.btnReservas.Visible = False
        '
        'btnAusentes
        '
        Me.btnAusentes.BackColor = System.Drawing.Color.Transparent
        Me.btnAusentes.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAusentes.FlatAppearance.BorderSize = 0
        Me.btnAusentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAusentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAusentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAusentes.ForeColor = System.Drawing.Color.DimGray
        Me.btnAusentes.Image = CType(resources.GetObject("btnAusentes.Image"), System.Drawing.Image)
        Me.btnAusentes.Location = New System.Drawing.Point(91, 659)
        Me.btnAusentes.Name = "btnAusentes"
        Me.btnAusentes.Size = New System.Drawing.Size(35, 35)
        Me.btnAusentes.TabIndex = 337
        Me.btnAusentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnAusentes, "Usuários fora do empreendimento")
        Me.btnAusentes.UseVisualStyleBackColor = False
        '
        'btnPesquisa
        '
        Me.btnPesquisa.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisa.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnPesquisa.FlatAppearance.BorderSize = 0
        Me.btnPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisa.ForeColor = System.Drawing.Color.DimGray
        Me.btnPesquisa.Image = CType(resources.GetObject("btnPesquisa.Image"), System.Drawing.Image)
        Me.btnPesquisa.Location = New System.Drawing.Point(132, 659)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(35, 35)
        Me.btnPesquisa.TabIndex = 340
        Me.btnPesquisa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnPesquisa, "Pesquisa geral por nome")
        Me.btnPesquisa.UseVisualStyleBackColor = False
        Me.btnPesquisa.Visible = False
        '
        'btnFiltro
        '
        Me.btnFiltro.BackColor = System.Drawing.Color.Transparent
        Me.btnFiltro.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnFiltro.FlatAppearance.BorderSize = 0
        Me.btnFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltro.ForeColor = System.Drawing.Color.DimGray
        Me.btnFiltro.Image = CType(resources.GetObject("btnFiltro.Image"), System.Drawing.Image)
        Me.btnFiltro.Location = New System.Drawing.Point(50, 659)
        Me.btnFiltro.Name = "btnFiltro"
        Me.btnFiltro.Size = New System.Drawing.Size(35, 35)
        Me.btnFiltro.TabIndex = 336
        Me.btnFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnFiltro, "Filtra ocupação das garagens")
        Me.btnFiltro.UseVisualStyleBackColor = False
        '
        'btnOcupados
        '
        Me.btnOcupados.BackColor = System.Drawing.Color.Transparent
        Me.btnOcupados.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnOcupados.FlatAppearance.BorderSize = 0
        Me.btnOcupados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnOcupados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOcupados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcupados.ForeColor = System.Drawing.Color.DimGray
        Me.btnOcupados.Image = CType(resources.GetObject("btnOcupados.Image"), System.Drawing.Image)
        Me.btnOcupados.Location = New System.Drawing.Point(173, 659)
        Me.btnOcupados.Name = "btnOcupados"
        Me.btnOcupados.Size = New System.Drawing.Size(35, 35)
        Me.btnOcupados.TabIndex = 341
        Me.btnOcupados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnOcupados, "Unidades ocupadas")
        Me.btnOcupados.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Silver
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(571, 649)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(133, 54)
        Me.Button1.TabIndex = 346
        Me.Button1.Text = "Movimento Empregados"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "portaria_25_25.png")
        Me.ImageList1.Images.SetKeyName(1, "entregue_25_25.png")
        Me.ImageList1.Images.SetKeyName(2, "devolvido_25_25.png")
        Me.ImageList1.Images.SetKeyName(3, "entregar_30_30.png")
        Me.ImageList1.Images.SetKeyName(4, "pesquisa_30_30.png")
        Me.ImageList1.Images.SetKeyName(5, "semImagem.png")
        '
        'TimeGatilho
        '
        Me.TimeGatilho.Enabled = True
        Me.TimeGatilho.Interval = 1
        '
        'frmBase
        '
        Me.frmBase.Controls.Add(Me.Panel5)
        Me.frmBase.Controls.Add(Me.Panel4)
        Me.frmBase.Controls.Add(Me.Panel1)
        Me.frmBase.Controls.Add(Me.Button4)
        Me.frmBase.Controls.Add(Me.Button3)
        Me.frmBase.Controls.Add(Me.Button2)
        Me.frmBase.Controls.Add(Me.Button1)
        Me.frmBase.Controls.Add(Me.Panel3)
        Me.frmBase.Controls.Add(Me.btnChaves)
        Me.frmBase.Controls.Add(Me.btnAcesso)
        Me.frmBase.Controls.Add(Me.Panel2)
        Me.frmBase.Controls.Add(Me.btnTodos)
        Me.frmBase.Controls.Add(Me.btnReservas)
        Me.frmBase.Controls.Add(Me.PainelVagas)
        Me.frmBase.Controls.Add(Me.btnAusentes)
        Me.frmBase.Controls.Add(Me.btnPesquisa)
        Me.frmBase.Controls.Add(Me.btnFiltro)
        Me.frmBase.Controls.Add(Me.btnOcupados)
        Me.frmBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmBase.Location = New System.Drawing.Point(0, 0)
        Me.frmBase.Name = "frmBase"
        Me.frmBase.Size = New System.Drawing.Size(1260, 714)
        Me.frmBase.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(571, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(680, 320)
        Me.Panel5.TabIndex = 339
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(571, 328)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(680, 318)
        Me.Panel4.TabIndex = 343
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Location = New System.Drawing.Point(9, 645)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1242, 1)
        Me.Panel1.TabIndex = 334
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Silver
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(973, 649)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(133, 54)
        Me.Button4.TabIndex = 349
        Me.Button4.Text = "Correios / Encomendas"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Silver
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(839, 649)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(133, 54)
        Me.Button3.TabIndex = 348
        Me.Button3.Text = "Ocorrências Portaria"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Silver
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(705, 649)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(133, 54)
        Me.Button2.TabIndex = 347
        Me.Button2.Text = "Visitantes / Convidados"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Location = New System.Drawing.Point(1109, 645)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 67)
        Me.Panel3.TabIndex = 334
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Location = New System.Drawing.Point(567, 645)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 67)
        Me.Panel2.TabIndex = 333
        '
        'PainelVagas
        '
        Me.PainelVagas.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.PainelVagas.Controls.Add(Me.Panel12)
        Me.PainelVagas.Controls.Add(Me.Button8)
        Me.PainelVagas.Controls.Add(Me.Button7)
        Me.PainelVagas.Controls.Add(Me.Button6)
        Me.PainelVagas.Controls.Add(Me.Button5)
        Me.PainelVagas.Controls.Add(Me.lvDados)
        Me.PainelVagas.Location = New System.Drawing.Point(9, 2)
        Me.PainelVagas.Name = "PainelVagas"
        Me.PainelVagas.Size = New System.Drawing.Size(556, 644)
        Me.PainelVagas.TabIndex = 338
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Gray
        Me.Panel12.Location = New System.Drawing.Point(9, 31)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(520, 1)
        Me.Panel12.TabIndex = 247
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Silver
        Me.Button8.Location = New System.Drawing.Point(432, 5)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(97, 24)
        Me.Button8.TabIndex = 264
        Me.Button8.Text = "Referência"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Silver
        Me.Button7.Location = New System.Drawing.Point(312, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(121, 24)
        Me.Button7.TabIndex = 265
        Me.Button7.Text = "Status"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Silver
        Me.Button6.Location = New System.Drawing.Point(192, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(121, 24)
        Me.Button6.TabIndex = 263
        Me.Button6.Text = "Localização"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Silver
        Me.Button5.Location = New System.Drawing.Point(6, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(188, 24)
        Me.Button5.TabIndex = 262
        Me.Button5.Text = "Descrição"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'lvDados
        '
        Me.lvDados.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lvDados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.COL00, Me.COL01, Me.COL02, Me.COL03, Me.COL04, Me.COL05, Me.COL06, Me.COL07, Me.ColumnHeader27})
        Me.lvDados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDados.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lvDados.GridLines = True
        Me.lvDados.HideSelection = False
        Me.lvDados.Location = New System.Drawing.Point(7, 7)
        Me.lvDados.Name = "lvDados"
        Me.lvDados.Size = New System.Drawing.Size(540, 637)
        Me.lvDados.TabIndex = 244
        Me.lvDados.UseCompatibleStateImageBehavior = False
        Me.lvDados.View = System.Windows.Forms.View.Details
        '
        'COL00
        '
        Me.COL00.Text = "COL01"
        Me.COL00.Width = 185
        '
        'COL01
        '
        Me.COL01.Text = "COL02"
        Me.COL01.Width = 120
        '
        'COL02
        '
        Me.COL02.Text = "COL03"
        Me.COL02.Width = 120
        '
        'COL03
        '
        Me.COL03.Text = "COL04"
        Me.COL03.Width = 95
        '
        'COL04
        '
        Me.COL04.Text = "COL05"
        Me.COL04.Width = 0
        '
        'COL05
        '
        Me.COL05.Text = "COL06"
        Me.COL05.Width = 0
        '
        'COL06
        '
        Me.COL06.Text = "COL07"
        Me.COL06.Width = 0
        '
        'COL07
        '
        Me.COL07.Width = 0
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "COL08"
        Me.ColumnHeader27.Width = 0
        '
        'Timer_Movim
        '
        Me.Timer_Movim.Enabled = True
        Me.Timer_Movim.Interval = 1000
        '
        'Portaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1260, 714)
        Me.Controls.Add(Me.frmBase)
        Me.ForeColor = System.Drawing.Color.DarkGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Portaria"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.frmBase.ResumeLayout(False)
        Me.PainelVagas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgBarra As ImageList
    Protected WithEvents Timer1 As Timer
    Friend WithEvents ImageGrid As ImageList
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ImageList1 As ImageList
    Public WithEvents TimeGatilho As Timer
    Friend WithEvents frmBase As Panel
    Friend WithEvents btnChaves As Button
    Friend WithEvents btnAcesso As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnTodos As Button
    Friend WithEvents btnReservas As Button
    Friend WithEvents PainelVagas As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents lvDados As ListView
    Friend WithEvents COL00 As ColumnHeader
    Friend WithEvents COL01 As ColumnHeader
    Friend WithEvents COL02 As ColumnHeader
    Friend WithEvents COL03 As ColumnHeader
    Friend WithEvents COL04 As ColumnHeader
    Friend WithEvents COL05 As ColumnHeader
    Friend WithEvents COL06 As ColumnHeader
    Friend WithEvents COL07 As ColumnHeader
    Friend WithEvents ColumnHeader27 As ColumnHeader
    Friend WithEvents btnAusentes As Button
    Friend WithEvents btnPesquisa As Button
    Friend WithEvents btnFiltro As Button
    Friend WithEvents btnOcupados As Button

    Private Sub btnChaves_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAcesso_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnTodos_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnReservas_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAusentes_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnFiltro_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnOcupados_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Protected WithEvents Timer_Movim As Timer
End Class
