<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.cabecalho = New System.Windows.Forms.Panel()
        Me.TextoCabecalho = New System.Windows.Forms.Label()
        Me.btnMini = New System.Windows.Forms.Button()
        Me.imgBarra = New System.Windows.Forms.ImageList(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbConecta = New System.Windows.Forms.Label()
        Me.tbData = New System.Windows.Forms.Label()
        Me.tbTerminal = New System.Windows.Forms.Label()
        Me.tbUsuario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.relogio = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnEncerra = New System.Windows.Forms.Button()
        Me.btnTrocaUser = New System.Windows.Forms.Button()
        Me.menus = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.menu_1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menu_1_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_1_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_1_3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_1_4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_1_5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_1_6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_1_7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_1_9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_1_8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_1_8_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_1_8_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menu_2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.menu_3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menu_3_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.menu_4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menu_4_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_4_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_4_3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_4_4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_4_6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.btnDasboard = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.frmBase = New System.Windows.Forms.Panel()
        Me.cabecalho.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.menus.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cabecalho
        '
        Me.cabecalho.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.cabecalho.Controls.Add(Me.TextoCabecalho)
        Me.cabecalho.Controls.Add(Me.btnMini)
        Me.cabecalho.Controls.Add(Me.btnClose)
        Me.cabecalho.Dock = System.Windows.Forms.DockStyle.Top
        Me.cabecalho.Location = New System.Drawing.Point(0, 0)
        Me.cabecalho.Name = "cabecalho"
        Me.cabecalho.Size = New System.Drawing.Size(1258, 29)
        Me.cabecalho.TabIndex = 250
        '
        'TextoCabecalho
        '
        Me.TextoCabecalho.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoCabecalho.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextoCabecalho.Location = New System.Drawing.Point(2, 3)
        Me.TextoCabecalho.Name = "TextoCabecalho"
        Me.TextoCabecalho.Size = New System.Drawing.Size(1144, 24)
        Me.TextoCabecalho.TabIndex = 255
        Me.TextoCabecalho.Text = "***"
        Me.TextoCabecalho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnMini
        '
        Me.btnMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMini.FlatAppearance.BorderSize = 0
        Me.btnMini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMini.ImageKey = "emblemremove_93481.png"
        Me.btnMini.ImageList = Me.imgBarra
        Me.btnMini.Location = New System.Drawing.Point(1187, 2)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.Size = New System.Drawing.Size(30, 30)
        Me.btnMini.TabIndex = 5
        Me.btnMini.UseVisualStyleBackColor = True
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
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ImageKey = "1486395882-close_80604.png"
        Me.btnClose.ImageList = Me.imgBarra
        Me.btnClose.Location = New System.Drawing.Point(1224, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 3
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(48, 734)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 15)
        Me.Label5.TabIndex = 262
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbConecta)
        Me.Panel2.Controls.Add(Me.tbData)
        Me.Panel2.Controls.Add(Me.tbTerminal)
        Me.Panel2.Controls.Add(Me.tbUsuario)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.relogio)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 743)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1258, 20)
        Me.Panel2.TabIndex = 268
        '
        'lbConecta
        '
        Me.lbConecta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbConecta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConecta.ForeColor = System.Drawing.Color.Gray
        Me.lbConecta.Location = New System.Drawing.Point(897, 2)
        Me.lbConecta.Name = "lbConecta"
        Me.lbConecta.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.lbConecta.Size = New System.Drawing.Size(238, 17)
        Me.lbConecta.TabIndex = 261
        Me.lbConecta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbData
        '
        Me.tbData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbData.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbData.ForeColor = System.Drawing.Color.Gray
        Me.tbData.Location = New System.Drawing.Point(580, 2)
        Me.tbData.Name = "tbData"
        Me.tbData.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.tbData.Size = New System.Drawing.Size(292, 17)
        Me.tbData.TabIndex = 260
        Me.tbData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbTerminal
        '
        Me.tbTerminal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTerminal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTerminal.ForeColor = System.Drawing.Color.Gray
        Me.tbTerminal.Location = New System.Drawing.Point(427, 2)
        Me.tbTerminal.Name = "tbTerminal"
        Me.tbTerminal.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.tbTerminal.Size = New System.Drawing.Size(144, 17)
        Me.tbTerminal.TabIndex = 259
        Me.tbTerminal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbUsuario
        '
        Me.tbUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsuario.ForeColor = System.Drawing.Color.Gray
        Me.tbUsuario.Location = New System.Drawing.Point(194, 2)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.tbUsuario.Size = New System.Drawing.Size(171, 17)
        Me.tbUsuario.TabIndex = 258
        Me.tbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(110, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 253
        Me.Label3.Text = "Usuário logado:"
        '
        'relogio
        '
        Me.relogio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.relogio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.relogio.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.relogio.Location = New System.Drawing.Point(1194, 2)
        Me.relogio.Name = "relogio"
        Me.relogio.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.relogio.Size = New System.Drawing.Size(62, 17)
        Me.relogio.TabIndex = 257
        Me.relogio.Text = "00:00:00"
        Me.relogio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(371, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 254
        Me.Label4.Text = "Terminal:"
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnEncerra)
        Me.PanelMenu.Controls.Add(Me.btnTrocaUser)
        Me.PanelMenu.Controls.Add(Me.menus)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.panelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 29)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(108, 714)
        Me.PanelMenu.TabIndex = 270
        '
        'btnEncerra
        '
        Me.btnEncerra.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnEncerra.FlatAppearance.BorderSize = 0
        Me.btnEncerra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnEncerra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnEncerra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEncerra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncerra.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEncerra.Image = CType(resources.GetObject("btnEncerra.Image"), System.Drawing.Image)
        Me.btnEncerra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEncerra.Location = New System.Drawing.Point(57, 673)
        Me.btnEncerra.Name = "btnEncerra"
        Me.btnEncerra.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnEncerra.Size = New System.Drawing.Size(40, 30)
        Me.btnEncerra.TabIndex = 271
        Me.btnEncerra.Text = "          "
        Me.btnEncerra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEncerra.UseVisualStyleBackColor = True
        '
        'btnTrocaUser
        '
        Me.btnTrocaUser.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnTrocaUser.FlatAppearance.BorderSize = 0
        Me.btnTrocaUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnTrocaUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnTrocaUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrocaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrocaUser.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnTrocaUser.Image = CType(resources.GetObject("btnTrocaUser.Image"), System.Drawing.Image)
        Me.btnTrocaUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrocaUser.Location = New System.Drawing.Point(12, 673)
        Me.btnTrocaUser.Name = "btnTrocaUser"
        Me.btnTrocaUser.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnTrocaUser.Size = New System.Drawing.Size(40, 30)
        Me.btnTrocaUser.TabIndex = 271
        Me.btnTrocaUser.Text = "         "
        Me.btnTrocaUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrocaUser.UseVisualStyleBackColor = True
        '
        'menus
        '
        Me.menus.AllowItemReorder = True
        Me.menus.AllowMerge = False
        Me.menus.AutoSize = False
        Me.menus.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.menus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menus.Dock = System.Windows.Forms.DockStyle.Left
        Me.menus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.menus.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.menu_1, Me.ToolStripSeparator1, Me.menu_2, Me.ToolStripSeparator2, Me.menu_3, Me.ToolStripSeparator3, Me.menu_4, Me.ToolStripSeparator4})
        Me.menus.Location = New System.Drawing.Point(0, 116)
        Me.menus.Name = "menus"
        Me.menus.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menus.Size = New System.Drawing.Size(105, 598)
        Me.menus.TabIndex = 241
        Me.menus.Text = "ToolStrip1"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(103, 6)
        '
        'menu_1
        '
        Me.menu_1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_1_1, Me.menu_1_2, Me.menu_1_3, Me.menu_1_4, Me.menu_1_5, Me.menu_1_6, Me.menu_1_7, Me.menu_1_9, Me.menu_1_8})
        Me.menu_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_1.ForeColor = System.Drawing.Color.Gainsboro
        Me.menu_1.Image = CType(resources.GetObject("menu_1.Image"), System.Drawing.Image)
        Me.menu_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.menu_1.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.menu_1.Name = "menu_1"
        Me.menu_1.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.menu_1.Size = New System.Drawing.Size(103, 24)
        Me.menu_1.Text = "         &Cadastros"
        Me.menu_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.menu_1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'menu_1_1
        '
        Me.menu_1_1.BackgroundImage = Global.GsPortaria.My.Resources.Resources.barra_menu_02
        Me.menu_1_1.ForeColor = System.Drawing.Color.Black
        Me.menu_1_1.Name = "menu_1_1"
        Me.menu_1_1.Size = New System.Drawing.Size(260, 22)
        Me.menu_1_1.Text = "Proprietários"
        '
        'menu_1_2
        '
        Me.menu_1_2.BackgroundImage = Global.GsPortaria.My.Resources.Resources.barra_menu_02
        Me.menu_1_2.ForeColor = System.Drawing.Color.Black
        Me.menu_1_2.Name = "menu_1_2"
        Me.menu_1_2.Size = New System.Drawing.Size(260, 22)
        Me.menu_1_2.Text = "Locatários"
        '
        'menu_1_3
        '
        Me.menu_1_3.BackgroundImage = Global.GsPortaria.My.Resources.Resources.barra_menu_02
        Me.menu_1_3.ForeColor = System.Drawing.Color.Black
        Me.menu_1_3.Name = "menu_1_3"
        Me.menu_1_3.Size = New System.Drawing.Size(260, 22)
        Me.menu_1_3.Text = "Hospedes do pool de locação"
        '
        'menu_1_4
        '
        Me.menu_1_4.BackgroundImage = Global.GsPortaria.My.Resources.Resources.barra_menu_02
        Me.menu_1_4.ForeColor = System.Drawing.Color.Black
        Me.menu_1_4.Name = "menu_1_4"
        Me.menu_1_4.Size = New System.Drawing.Size(260, 22)
        Me.menu_1_4.Text = "Funcionários do empreendimento"
        '
        'menu_1_5
        '
        Me.menu_1_5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.menu_1_5.BackgroundImage = Global.GsPortaria.My.Resources.Resources.barra_menu_02
        Me.menu_1_5.ForeColor = System.Drawing.Color.Black
        Me.menu_1_5.Name = "menu_1_5"
        Me.menu_1_5.Size = New System.Drawing.Size(260, 22)
        Me.menu_1_5.Text = "Prestadores de serviço"
        '
        'menu_1_6
        '
        Me.menu_1_6.BackgroundImage = Global.GsPortaria.My.Resources.Resources.barra_menu_02
        Me.menu_1_6.ForeColor = System.Drawing.Color.Black
        Me.menu_1_6.Name = "menu_1_6"
        Me.menu_1_6.Size = New System.Drawing.Size(260, 22)
        Me.menu_1_6.Text = "Empresas / Fornecedores"
        '
        'menu_1_7
        '
        Me.menu_1_7.BackgroundImage = Global.GsPortaria.My.Resources.Resources.barra_menu_02
        Me.menu_1_7.ForeColor = System.Drawing.Color.Black
        Me.menu_1_7.Name = "menu_1_7"
        Me.menu_1_7.Size = New System.Drawing.Size(260, 22)
        Me.menu_1_7.Text = "Vagas no estacionamento"
        '
        'menu_1_9
        '
        Me.menu_1_9.BackgroundImage = Global.GsPortaria.My.Resources.Resources.barra_menu_02
        Me.menu_1_9.ForeColor = System.Drawing.Color.Black
        Me.menu_1_9.Name = "menu_1_9"
        Me.menu_1_9.Size = New System.Drawing.Size(260, 22)
        Me.menu_1_9.Text = "Armário rotativo"
        '
        'menu_1_8
        '
        Me.menu_1_8.BackgroundImage = Global.GsPortaria.My.Resources.Resources.barra_menu_02
        Me.menu_1_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menu_1_8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_1_8_1, Me.menu_1_8_2})
        Me.menu_1_8.ForeColor = System.Drawing.Color.Black
        Me.menu_1_8.Name = "menu_1_8"
        Me.menu_1_8.Size = New System.Drawing.Size(260, 22)
        Me.menu_1_8.Text = "Usuários do Sistema"
        '
        'menu_1_8_1
        '
        Me.menu_1_8_1.BackgroundImage = Global.GsPortaria.My.Resources.Resources.barra_menu_02
        Me.menu_1_8_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.menu_1_8_1.Name = "menu_1_8_1"
        Me.menu_1_8_1.Size = New System.Drawing.Size(199, 22)
        Me.menu_1_8_1.Text = "Cadastro de Usuários"
        '
        'menu_1_8_2
        '
        Me.menu_1_8_2.BackgroundImage = Global.GsPortaria.My.Resources.Resources.barra_menu_02
        Me.menu_1_8_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.menu_1_8_2.Name = "menu_1_8_2"
        Me.menu_1_8_2.Size = New System.Drawing.Size(199, 22)
        Me.menu_1_8_2.Text = "Manutenção de Senha"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(103, 6)
        '
        'menu_2
        '
        Me.menu_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_2.ForeColor = System.Drawing.Color.Gainsboro
        Me.menu_2.Image = CType(resources.GetObject("menu_2.Image"), System.Drawing.Image)
        Me.menu_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.menu_2.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.menu_2.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.menu_2.Name = "menu_2"
        Me.menu_2.Size = New System.Drawing.Size(103, 24)
        Me.menu_2.Text = "         &Portaria"
        Me.menu_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.menu_2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(103, 6)
        '
        'menu_3
        '
        Me.menu_3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_3_1})
        Me.menu_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_3.ForeColor = System.Drawing.Color.Gainsboro
        Me.menu_3.Image = CType(resources.GetObject("menu_3.Image"), System.Drawing.Image)
        Me.menu_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.menu_3.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.menu_3.Name = "menu_3"
        Me.menu_3.Size = New System.Drawing.Size(103, 24)
        Me.menu_3.Text = "         C&onsultas"
        Me.menu_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.menu_3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'menu_3_1
        '
        Me.menu_3_1.BackgroundImage = Global.GsPortaria.My.Resources.Resources.barra_menu_02
        Me.menu_3_1.ForeColor = System.Drawing.Color.Black
        Me.menu_3_1.Name = "menu_3_1"
        Me.menu_3_1.Size = New System.Drawing.Size(157, 22)
        Me.menu_3_1.Text = "Terminais Ativo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(103, 6)
        '
        'menu_4
        '
        Me.menu_4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_4_1, Me.menu_4_2, Me.menu_4_3, Me.menu_4_4, Me.menu_4_6})
        Me.menu_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_4.ForeColor = System.Drawing.Color.Gainsboro
        Me.menu_4.Image = CType(resources.GetObject("menu_4.Image"), System.Drawing.Image)
        Me.menu_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.menu_4.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.menu_4.Name = "menu_4"
        Me.menu_4.Size = New System.Drawing.Size(103, 24)
        Me.menu_4.Text = "         &Sistema"
        Me.menu_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.menu_4.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'menu_4_1
        '
        Me.menu_4_1.BackgroundImage = Global.GsPortaria.My.Resources.Resources.barra_menu_02
        Me.menu_4_1.ForeColor = System.Drawing.Color.Black
        Me.menu_4_1.Name = "menu_4_1"
        Me.menu_4_1.Size = New System.Drawing.Size(185, 22)
        Me.menu_4_1.Text = "Registro do Sistema"
        '
        'menu_4_2
        '
        Me.menu_4_2.BackgroundImage = Global.GsPortaria.My.Resources.Resources.barra_menu_02
        Me.menu_4_2.ForeColor = System.Drawing.Color.Black
        Me.menu_4_2.Name = "menu_4_2"
        Me.menu_4_2.Size = New System.Drawing.Size(185, 22)
        Me.menu_4_2.Text = "Parâmetros"
        '
        'menu_4_3
        '
        Me.menu_4_3.BackgroundImage = Global.GsPortaria.My.Resources.Resources.barra_menu_02
        Me.menu_4_3.ForeColor = System.Drawing.Color.Black
        Me.menu_4_3.Name = "menu_4_3"
        Me.menu_4_3.Size = New System.Drawing.Size(185, 22)
        Me.menu_4_3.Text = "Habilita Terminal"
        '
        'menu_4_4
        '
        Me.menu_4_4.BackgroundImage = Global.GsPortaria.My.Resources.Resources.barra_menu_02
        Me.menu_4_4.ForeColor = System.Drawing.Color.Black
        Me.menu_4_4.Name = "menu_4_4"
        Me.menu_4_4.Size = New System.Drawing.Size(185, 22)
        Me.menu_4_4.Text = "Provedor de Email"
        '
        'menu_4_6
        '
        Me.menu_4_6.BackgroundImage = Global.GsPortaria.My.Resources.Resources.barra_menu_02
        Me.menu_4_6.ForeColor = System.Drawing.Color.Black
        Me.menu_4_6.Name = "menu_4_6"
        Me.menu_4_6.Size = New System.Drawing.Size(185, 22)
        Me.menu_4_6.Text = "Sobre o Sistema"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(103, 6)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(108, 24)
        Me.Panel1.TabIndex = 1
        '
        'panelLogo
        '
        Me.panelLogo.Controls.Add(Me.btnDasboard)
        Me.panelLogo.Controls.Add(Me.PictureBox2)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(108, 92)
        Me.panelLogo.TabIndex = 0
        '
        'btnDasboard
        '
        Me.btnDasboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDasboard.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnDasboard.FlatAppearance.BorderSize = 0
        Me.btnDasboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnDasboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDasboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDasboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDasboard.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDasboard.Image = CType(resources.GetObject("btnDasboard.Image"), System.Drawing.Image)
        Me.btnDasboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDasboard.Location = New System.Drawing.Point(-7, -2)
        Me.btnDasboard.Name = "btnDasboard"
        Me.btnDasboard.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnDasboard.Size = New System.Drawing.Size(30, 25)
        Me.btnDasboard.TabIndex = 12
        Me.btnDasboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDasboard.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(4, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(101, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 263
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'frmBase
        '
        Me.frmBase.BackColor = System.Drawing.Color.Transparent
        Me.frmBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.frmBase.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.frmBase.Location = New System.Drawing.Point(108, 29)
        Me.frmBase.Name = "frmBase"
        Me.frmBase.Size = New System.Drawing.Size(1150, 714)
        Me.frmBase.TabIndex = 271
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1258, 763)
        Me.ControlBox = False
        Me.Controls.Add(Me.frmBase)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cabecalho)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Principal"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.cabecalho.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.menus.ResumeLayout(False)
        Me.menus.PerformLayout()
        Me.panelLogo.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cabecalho As Panel
    Friend WithEvents btnMini As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextoCabecalho As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbData As Label
    Friend WithEvents tbTerminal As Label
    Friend WithEvents tbUsuario As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents relogio As Label
    Friend WithEvents Label4 As Label
    Private WithEvents PanelMenu As Panel
    Private WithEvents panelLogo As Panel
    Private WithEvents btnDasboard As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Private WithEvents btnEncerra As System.Windows.Forms.Button
    Private WithEvents btnTrocaUser As System.Windows.Forms.Button
    Friend WithEvents lbConecta As Label
    Friend WithEvents imgBarra As ImageList
    Friend WithEvents menus As ToolStrip
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents menu_1 As ToolStripDropDownButton
    Friend WithEvents menu_1_1 As ToolStripMenuItem
    Friend WithEvents menu_1_2 As ToolStripMenuItem
    Friend WithEvents menu_1_3 As ToolStripMenuItem
    Friend WithEvents menu_1_4 As ToolStripMenuItem
    Friend WithEvents menu_1_5 As ToolStripMenuItem
    Friend WithEvents menu_1_6 As ToolStripMenuItem
    Friend WithEvents menu_1_7 As ToolStripMenuItem
    Friend WithEvents menu_1_9 As ToolStripMenuItem
    Friend WithEvents menu_1_8 As ToolStripMenuItem
    Friend WithEvents menu_1_8_1 As ToolStripMenuItem
    Friend WithEvents menu_1_8_2 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents menu_2 As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents menu_3 As ToolStripDropDownButton
    Friend WithEvents menu_3_1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents menu_4 As ToolStripDropDownButton
    Friend WithEvents menu_4_1 As ToolStripMenuItem
    Friend WithEvents menu_4_2 As ToolStripMenuItem
    Friend WithEvents menu_4_3 As ToolStripMenuItem
    Friend WithEvents menu_4_4 As ToolStripMenuItem
    Friend WithEvents menu_4_6 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Protected WithEvents Timer1 As Timer
    Protected WithEvents Timer2 As Timer
    Friend WithEvents frmBase As Panel
End Class
