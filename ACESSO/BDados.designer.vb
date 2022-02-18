<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BDados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BDados))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnF7 = New System.Windows.Forms.Button()
        Me.btnF5 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PanelCloud = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.iMacSistema = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbPage = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbPorta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbHost = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbbanco = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbTerminal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbPort = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbHostname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbDatabase = New System.Windows.Forms.TextBox()
        Me.imgMenu = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnAsenha = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanelCloud.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(780, 43)
        Me.Label2.TabIndex = 246
        Me.Label2.Text = "Configuração do Banco de Dados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.btnF7)
        Me.Panel3.Controls.Add(Me.btnF5)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Location = New System.Drawing.Point(126, 65)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(527, 369)
        Me.Panel3.TabIndex = 247
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 351)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 13)
        Me.Label9.TabIndex = 251
        Me.Label9.Text = "[ESC] - Fecha formulário"
        '
        'btnF7
        '
        Me.btnF7.BackColor = System.Drawing.Color.White
        Me.btnF7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnF7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnF7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnF7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnF7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF7.ForeColor = System.Drawing.Color.Black
        Me.btnF7.Image = CType(resources.GetObject("btnF7.Image"), System.Drawing.Image)
        Me.btnF7.Location = New System.Drawing.Point(443, 286)
        Me.btnF7.Name = "btnF7"
        Me.btnF7.Size = New System.Drawing.Size(65, 52)
        Me.btnF7.TabIndex = 311
        Me.btnF7.Text = "Cancela"
        Me.btnF7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnF7.UseVisualStyleBackColor = False
        '
        'btnF5
        '
        Me.btnF5.BackColor = System.Drawing.Color.White
        Me.btnF5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnF5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnF5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnF5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF5.ForeColor = System.Drawing.Color.Black
        Me.btnF5.Image = CType(resources.GetObject("btnF5.Image"), System.Drawing.Image)
        Me.btnF5.Location = New System.Drawing.Point(373, 286)
        Me.btnF5.Name = "btnF5"
        Me.btnF5.Size = New System.Drawing.Size(65, 52)
        Me.btnF5.TabIndex = 310
        Me.btnF5.Text = "Gravar"
        Me.btnF5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnF5.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.PanelCloud)
        Me.GroupBox2.Controls.Add(Me.tbCodigo)
        Me.GroupBox2.Controls.Add(Me.tbUser)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.tbPage)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tbPorta)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tbHost)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.tbbanco)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox2.Location = New System.Drawing.Point(8, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(500, 152)
        Me.GroupBox2.TabIndex = 207
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Configuração Cloud:"
        '
        'PanelCloud
        '
        Me.PanelCloud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCloud.Controls.Add(Me.btnSave)
        Me.PanelCloud.Controls.Add(Me.iMacSistema)
        Me.PanelCloud.Controls.Add(Me.Label6)
        Me.PanelCloud.Location = New System.Drawing.Point(142, 6)
        Me.PanelCloud.Name = "PanelCloud"
        Me.PanelCloud.Size = New System.Drawing.Size(242, 93)
        Me.PanelCloud.TabIndex = 313
        Me.PanelCloud.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(194, 34)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(34, 39)
        Me.btnSave.TabIndex = 312
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'iMacSistema
        '
        Me.iMacSistema.BackColor = System.Drawing.Color.White
        Me.iMacSistema.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iMacSistema.ForeColor = System.Drawing.Color.Black
        Me.iMacSistema.Location = New System.Drawing.Point(20, 44)
        Me.iMacSistema.MaxLength = 30
        Me.iMacSistema.Name = "iMacSistema"
        Me.iMacSistema.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.iMacSistema.Size = New System.Drawing.Size(158, 22)
        Me.iMacSistema.TabIndex = 196
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(240, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Acesso Cloud"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbCodigo
        '
        Me.tbCodigo.BackColor = System.Drawing.Color.White
        Me.tbCodigo.Font = New System.Drawing.Font("Arial", 10.25!, System.Drawing.FontStyle.Bold)
        Me.tbCodigo.ForeColor = System.Drawing.Color.Navy
        Me.tbCodigo.Location = New System.Drawing.Point(390, 81)
        Me.tbCodigo.MaxLength = 4
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.ReadOnly = True
        Me.tbCodigo.Size = New System.Drawing.Size(97, 23)
        Me.tbCodigo.TabIndex = 312
        Me.tbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbUser
        '
        Me.tbUser.BackColor = System.Drawing.Color.White
        Me.tbUser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUser.ForeColor = System.Drawing.Color.Black
        Me.tbUser.Location = New System.Drawing.Point(108, 81)
        Me.tbUser.MaxLength = 30
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(219, 22)
        Me.tbUser.TabIndex = 211
        Me.tbUser.Text = "devsys01_devsys"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(51, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 210
        Me.Label14.Text = "Usuário:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 209
        Me.Label13.Text = "Url de Teste:"
        '
        'tbPage
        '
        Me.tbPage.BackColor = System.Drawing.Color.Snow
        Me.tbPage.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbPage.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPage.ForeColor = System.Drawing.Color.Black
        Me.tbPage.Location = New System.Drawing.Point(108, 112)
        Me.tbPage.MaxLength = 20
        Me.tbPage.Name = "tbPage"
        Me.tbPage.Size = New System.Drawing.Size(379, 22)
        Me.tbPage.TabIndex = 207
        Me.tbPage.Text = "http://www.devsys.com.br"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(886, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 201
        Me.Label8.Text = "Senha:"
        '
        'tbPorta
        '
        Me.tbPorta.BackColor = System.Drawing.Color.White
        Me.tbPorta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPorta.ForeColor = System.Drawing.Color.Black
        Me.tbPorta.Location = New System.Drawing.Point(389, 25)
        Me.tbPorta.MaxLength = 4
        Me.tbPorta.Name = "tbPorta"
        Me.tbPorta.Size = New System.Drawing.Size(97, 22)
        Me.tbPorta.TabIndex = 197
        Me.tbPorta.Text = "3306"
        Me.tbPorta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(339, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 196
        Me.Label10.Text = "Porta :"
        '
        'tbHost
        '
        Me.tbHost.BackColor = System.Drawing.Color.White
        Me.tbHost.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHost.ForeColor = System.Drawing.Color.Black
        Me.tbHost.Location = New System.Drawing.Point(108, 53)
        Me.tbHost.MaxLength = 30
        Me.tbHost.Name = "tbHost"
        Me.tbHost.Size = New System.Drawing.Size(378, 22)
        Me.tbHost.TabIndex = 195
        Me.tbHost.Text = "177.85.97.191"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 194
        Me.Label11.Text = "IP do Servidor:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Banco Nuvem:"
        '
        'tbbanco
        '
        Me.tbbanco.BackColor = System.Drawing.Color.White
        Me.tbbanco.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbbanco.ForeColor = System.Drawing.Color.Black
        Me.tbbanco.Location = New System.Drawing.Point(108, 25)
        Me.tbbanco.MaxLength = 30
        Me.tbbanco.Name = "tbbanco"
        Me.tbbanco.Size = New System.Drawing.Size(219, 22)
        Me.tbbanco.TabIndex = 0
        Me.tbbanco.Text = "devsys01_portaria"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbTerminal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbPort)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbHostname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbDatabase)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 102)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configurações local:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 204
        Me.Label7.Text = "Nome Estação:"
        '
        'tbTerminal
        '
        Me.tbTerminal.BackColor = System.Drawing.Color.White
        Me.tbTerminal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTerminal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTerminal.ForeColor = System.Drawing.Color.Black
        Me.tbTerminal.Location = New System.Drawing.Point(108, 72)
        Me.tbTerminal.MaxLength = 20
        Me.tbTerminal.Name = "tbTerminal"
        Me.tbTerminal.ReadOnly = True
        Me.tbTerminal.Size = New System.Drawing.Size(371, 22)
        Me.tbTerminal.TabIndex = 203
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(886, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 201
        Me.Label5.Text = "Senha:"
        '
        'tbPort
        '
        Me.tbPort.BackColor = System.Drawing.Color.White
        Me.tbPort.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPort.ForeColor = System.Drawing.Color.Black
        Me.tbPort.Location = New System.Drawing.Point(382, 44)
        Me.tbPort.MaxLength = 4
        Me.tbPort.Name = "tbPort"
        Me.tbPort.Size = New System.Drawing.Size(97, 22)
        Me.tbPort.TabIndex = 197
        Me.tbPort.Text = "3306"
        Me.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(272, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 196
        Me.Label3.Text = "Porta de Acesso:"
        '
        'tbHostname
        '
        Me.tbHostname.BackColor = System.Drawing.Color.White
        Me.tbHostname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHostname.ForeColor = System.Drawing.Color.Black
        Me.tbHostname.Location = New System.Drawing.Point(108, 44)
        Me.tbHostname.MaxLength = 30
        Me.tbHostname.Name = "tbHostname"
        Me.tbHostname.Size = New System.Drawing.Size(158, 22)
        Me.tbHostname.TabIndex = 195
        Me.tbHostname.Text = "localhost"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 194
        Me.Label1.Text = "IP do Servidor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Banco de dados:"
        '
        'tbDatabase
        '
        Me.tbDatabase.BackColor = System.Drawing.Color.White
        Me.tbDatabase.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDatabase.ForeColor = System.Drawing.Color.Black
        Me.tbDatabase.Location = New System.Drawing.Point(108, 19)
        Me.tbDatabase.MaxLength = 200
        Me.tbDatabase.Name = "tbDatabase"
        Me.tbDatabase.Size = New System.Drawing.Size(371, 22)
        Me.tbDatabase.TabIndex = 0
        Me.tbDatabase.Text = "gstec"
        '
        'imgMenu
        '
        Me.imgMenu.ImageStream = CType(resources.GetObject("imgMenu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgMenu.TransparentColor = System.Drawing.Color.Transparent
        Me.imgMenu.Images.SetKeyName(0, "gravar.png")
        Me.imgMenu.Images.SetKeyName(1, "sair.png")
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(672, 657)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(107, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 312
        Me.PictureBox2.TabStop = False
        '
        'btnAsenha
        '
        Me.btnAsenha.BackColor = System.Drawing.Color.Transparent
        Me.btnAsenha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAsenha.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray
        Me.btnAsenha.FlatAppearance.BorderSize = 0
        Me.btnAsenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAsenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAsenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsenha.Image = CType(resources.GetObject("btnAsenha.Image"), System.Drawing.Image)
        Me.btnAsenha.Location = New System.Drawing.Point(728, 430)
        Me.btnAsenha.Name = "btnAsenha"
        Me.btnAsenha.Size = New System.Drawing.Size(40, 40)
        Me.btnAsenha.TabIndex = 313
        Me.btnAsenha.UseVisualStyleBackColor = False
        '
        'BDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(780, 472)
        Me.Controls.Add(Me.btnAsenha)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "BDados"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanelCloud.ResumeLayout(False)
        Me.PanelCloud.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbPage As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbPorta As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbHost As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbbanco As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbTerminal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbPort As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbHostname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbDatabase As System.Windows.Forms.TextBox
    Friend WithEvents imgMenu As System.Windows.Forms.ImageList
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbUser As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnF7 As System.Windows.Forms.Button
    Friend WithEvents btnF5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents PanelCloud As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents iMacSistema As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAsenha As Button
End Class
