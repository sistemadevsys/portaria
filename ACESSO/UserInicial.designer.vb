<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserInicial))
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.imgBarra = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.imgMenu = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnF7 = New System.Windows.Forms.Button()
        Me.btnF2 = New System.Windows.Forms.Button()
        Me.btnF6 = New System.Windows.Forms.Button()
        Me.btnF3 = New System.Windows.Forms.Button()
        Me.btnF5 = New System.Windows.Forms.Button()
        Me.btnF4 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnvolta = New System.Windows.Forms.Button()
        Me.txtpesquisar = New System.Windows.Forms.TextBox()
        Me.lvdados = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbUSU001 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbUSU003 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbUSU002 = New System.Windows.Forms.TextBox()
        Me.gbsenha = New System.Windows.Forms.GroupBox()
        Me.tbUSU004 = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.tbUSU007 = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.tbUSU005 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbsenha.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ToolTip2
        '
        Me.ToolTip2.AutoPopDelay = 5000
        Me.ToolTip2.InitialDelay = 100
        Me.ToolTip2.ReshowDelay = 100
        Me.ToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'imgMenu
        '
        Me.imgMenu.ImageStream = CType(resources.GetObject("imgMenu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgMenu.TransparentColor = System.Drawing.Color.Transparent
        Me.imgMenu.Images.SetKeyName(0, "Cancela.png")
        Me.imgMenu.Images.SetKeyName(1, "Editar.png")
        Me.imgMenu.Images.SetKeyName(2, "excluir.png")
        Me.imgMenu.Images.SetKeyName(3, "gravar.png")
        Me.imgMenu.Images.SetKeyName(4, "novo_Registro.png")
        Me.imgMenu.Images.SetKeyName(5, "editar01.png")
        Me.imgMenu.Images.SetKeyName(6, "sair.png")
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Controls.Add(Me.gbsenha)
        Me.Panel3.Controls.Add(Me.GroupBox5)
        Me.Panel3.Controls.Add(Me.GroupBox6)
        Me.Panel3.Location = New System.Drawing.Point(128, 73)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(523, 379)
        Me.Panel3.TabIndex = 247
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.btnF7)
        Me.Panel1.Controls.Add(Me.btnF2)
        Me.Panel1.Controls.Add(Me.btnF6)
        Me.Panel1.Controls.Add(Me.btnF3)
        Me.Panel1.Controls.Add(Me.btnF5)
        Me.Panel1.Controls.Add(Me.btnF4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(445, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(76, 377)
        Me.Panel1.TabIndex = 217
        '
        'btnF7
        '
        Me.btnF7.BackColor = System.Drawing.Color.Transparent
        Me.btnF7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnF7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnF7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnF7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnF7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnF7.Image = CType(resources.GetObject("btnF7.Image"), System.Drawing.Image)
        Me.btnF7.Location = New System.Drawing.Point(6, 296)
        Me.btnF7.Name = "btnF7"
        Me.btnF7.Size = New System.Drawing.Size(65, 52)
        Me.btnF7.TabIndex = 312
        Me.btnF7.Text = "Sair"
        Me.btnF7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnF7.UseVisualStyleBackColor = False
        '
        'btnF2
        '
        Me.btnF2.BackColor = System.Drawing.Color.Transparent
        Me.btnF2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnF2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnF2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnF2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnF2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnF2.Image = CType(resources.GetObject("btnF2.Image"), System.Drawing.Image)
        Me.btnF2.Location = New System.Drawing.Point(6, 6)
        Me.btnF2.Name = "btnF2"
        Me.btnF2.Size = New System.Drawing.Size(65, 52)
        Me.btnF2.TabIndex = 307
        Me.btnF2.Text = "Incluir"
        Me.btnF2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnF2.UseVisualStyleBackColor = False
        '
        'btnF6
        '
        Me.btnF6.BackColor = System.Drawing.Color.Transparent
        Me.btnF6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnF6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnF6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnF6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnF6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnF6.Image = CType(resources.GetObject("btnF6.Image"), System.Drawing.Image)
        Me.btnF6.Location = New System.Drawing.Point(6, 238)
        Me.btnF6.Name = "btnF6"
        Me.btnF6.Size = New System.Drawing.Size(65, 52)
        Me.btnF6.TabIndex = 309
        Me.btnF6.Text = "Excluir"
        Me.btnF6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnF6.UseVisualStyleBackColor = False
        '
        'btnF3
        '
        Me.btnF3.BackColor = System.Drawing.Color.Transparent
        Me.btnF3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnF3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnF3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnF3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnF3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnF3.Image = CType(resources.GetObject("btnF3.Image"), System.Drawing.Image)
        Me.btnF3.Location = New System.Drawing.Point(6, 64)
        Me.btnF3.Name = "btnF3"
        Me.btnF3.Size = New System.Drawing.Size(65, 52)
        Me.btnF3.TabIndex = 308
        Me.btnF3.Text = "Editar"
        Me.btnF3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnF3.UseVisualStyleBackColor = False
        '
        'btnF5
        '
        Me.btnF5.BackColor = System.Drawing.Color.Transparent
        Me.btnF5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnF5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnF5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnF5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnF5.Image = CType(resources.GetObject("btnF5.Image"), System.Drawing.Image)
        Me.btnF5.Location = New System.Drawing.Point(6, 180)
        Me.btnF5.Name = "btnF5"
        Me.btnF5.Size = New System.Drawing.Size(65, 52)
        Me.btnF5.TabIndex = 310
        Me.btnF5.Text = "Gravar"
        Me.btnF5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnF5.UseVisualStyleBackColor = False
        '
        'btnF4
        '
        Me.btnF4.BackColor = System.Drawing.Color.Transparent
        Me.btnF4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnF4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnF4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnF4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnF4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnF4.Image = CType(resources.GetObject("btnF4.Image"), System.Drawing.Image)
        Me.btnF4.Location = New System.Drawing.Point(6, 122)
        Me.btnF4.Name = "btnF4"
        Me.btnF4.Size = New System.Drawing.Size(65, 52)
        Me.btnF4.TabIndex = 311
        Me.btnF4.Text = "Cancela"
        Me.btnF4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnF4.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(12, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 12)
        Me.Label9.TabIndex = 216
        Me.Label9.Text = "[ESC] - Fecha formulário"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnvolta)
        Me.GroupBox2.Controls.Add(Me.txtpesquisar)
        Me.GroupBox2.Controls.Add(Me.lvdados)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(428, 150)
        Me.GroupBox2.TabIndex = 132
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(9, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 196
        Me.Label1.Text = "Pesquisa:"
        '
        'btnvolta
        '
        Me.btnvolta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnvolta.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.btnvolta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnvolta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnvolta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvolta.Image = CType(resources.GetObject("btnvolta.Image"), System.Drawing.Image)
        Me.btnvolta.Location = New System.Drawing.Point(386, 110)
        Me.btnvolta.Name = "btnvolta"
        Me.btnvolta.Size = New System.Drawing.Size(32, 32)
        Me.btnvolta.TabIndex = 197
        Me.btnvolta.UseVisualStyleBackColor = True
        '
        'txtpesquisar
        '
        Me.txtpesquisar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtpesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpesquisar.ForeColor = System.Drawing.Color.Black
        Me.txtpesquisar.Location = New System.Drawing.Point(71, 113)
        Me.txtpesquisar.MaxLength = 50
        Me.txtpesquisar.Name = "txtpesquisar"
        Me.txtpesquisar.Size = New System.Drawing.Size(312, 21)
        Me.txtpesquisar.TabIndex = 195
        '
        'lvdados
        '
        Me.lvdados.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvdados.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvdados.BackgroundImageTiled = True
        Me.lvdados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvdados.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvdados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lvdados.FullRowSelect = True
        Me.lvdados.HideSelection = False
        Me.lvdados.Location = New System.Drawing.Point(8, 14)
        Me.lvdados.MultiSelect = False
        Me.lvdados.Name = "lvdados"
        Me.lvdados.Size = New System.Drawing.Size(410, 94)
        Me.lvdados.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvdados.TabIndex = 1
        Me.lvdados.UseCompatibleStateImageBehavior = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.tbUSU001)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox1.Location = New System.Drawing.Point(8, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(72, 46)
        Me.GroupBox1.TabIndex = 134
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Código"
        '
        'tbUSU001
        '
        Me.tbUSU001.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbUSU001.Enabled = False
        Me.tbUSU001.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUSU001.ForeColor = System.Drawing.Color.Black
        Me.tbUSU001.Location = New System.Drawing.Point(12, 18)
        Me.tbUSU001.MaxLength = 4
        Me.tbUSU001.Name = "tbUSU001"
        Me.tbUSU001.ReadOnly = True
        Me.tbUSU001.Size = New System.Drawing.Size(46, 21)
        Me.tbUSU001.TabIndex = 133
        Me.tbUSU001.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.tbUSU003)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox3.Location = New System.Drawing.Point(79, 160)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(357, 46)
        Me.GroupBox3.TabIndex = 135
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Nome do usuário:"
        '
        'tbUSU003
        '
        Me.tbUSU003.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbUSU003.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbUSU003.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUSU003.ForeColor = System.Drawing.Color.Black
        Me.tbUSU003.Location = New System.Drawing.Point(12, 18)
        Me.tbUSU003.MaxLength = 30
        Me.tbUSU003.Name = "tbUSU003"
        Me.tbUSU003.Size = New System.Drawing.Size(335, 21)
        Me.tbUSU003.TabIndex = 133
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbUSU002)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox4.Location = New System.Drawing.Point(8, 259)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(208, 46)
        Me.GroupBox4.TabIndex = 136
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Login de acesso:"
        '
        'tbUSU002
        '
        Me.tbUSU002.BackColor = System.Drawing.Color.White
        Me.tbUSU002.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbUSU002.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUSU002.ForeColor = System.Drawing.Color.Black
        Me.tbUSU002.Location = New System.Drawing.Point(12, 18)
        Me.tbUSU002.MaxLength = 30
        Me.tbUSU002.Name = "tbUSU002"
        Me.tbUSU002.Size = New System.Drawing.Size(190, 21)
        Me.tbUSU002.TabIndex = 133
        '
        'gbsenha
        '
        Me.gbsenha.Controls.Add(Me.tbUSU004)
        Me.gbsenha.ForeColor = System.Drawing.Color.Gray
        Me.gbsenha.Location = New System.Drawing.Point(222, 259)
        Me.gbsenha.Name = "gbsenha"
        Me.gbsenha.Size = New System.Drawing.Size(214, 46)
        Me.gbsenha.TabIndex = 137
        Me.gbsenha.TabStop = False
        Me.gbsenha.Text = "Senha de acesso:"
        '
        'tbUSU004
        '
        Me.tbUSU004.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbUSU004.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUSU004.ForeColor = System.Drawing.Color.Black
        Me.tbUSU004.Location = New System.Drawing.Point(12, 18)
        Me.tbUSU004.MaxLength = 20
        Me.tbUSU004.Name = "tbUSU004"
        Me.tbUSU004.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.tbUSU004.Size = New System.Drawing.Size(192, 21)
        Me.tbUSU004.TabIndex = 133
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.tbUSU007)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox5.Location = New System.Drawing.Point(8, 311)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(428, 46)
        Me.GroupBox5.TabIndex = 136
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Email do usuário:"
        '
        'tbUSU007
        '
        Me.tbUSU007.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbUSU007.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbUSU007.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUSU007.ForeColor = System.Drawing.Color.Black
        Me.tbUSU007.Location = New System.Drawing.Point(12, 18)
        Me.tbUSU007.MaxLength = 30
        Me.tbUSU007.Name = "tbUSU007"
        Me.tbUSU007.Size = New System.Drawing.Size(406, 21)
        Me.tbUSU007.TabIndex = 133
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.tbUSU005)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox6.Location = New System.Drawing.Point(8, 209)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(260, 46)
        Me.GroupBox6.TabIndex = 136
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Cargo ocupado:"
        '
        'tbUSU005
        '
        Me.tbUSU005.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbUSU005.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbUSU005.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUSU005.ForeColor = System.Drawing.Color.Black
        Me.tbUSU005.Location = New System.Drawing.Point(12, 18)
        Me.tbUSU005.MaxLength = 40
        Me.tbUSU005.Name = "tbUSU005"
        Me.tbUSU005.Size = New System.Drawing.Size(243, 21)
        Me.tbUSU005.TabIndex = 133
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(677, 698)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 248
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(780, 43)
        Me.Label2.TabIndex = 260
        Me.Label2.Text = "Usuários do Sistema"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(780, 472)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "UserInicial"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbsenha.ResumeLayout(False)
        Me.gbsenha.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Protected WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents imgBarra As System.Windows.Forms.ImageList
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents imgMenu As System.Windows.Forms.ImageList
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnvolta As System.Windows.Forms.Button
    Friend WithEvents txtpesquisar As System.Windows.Forms.TextBox
    Friend WithEvents lvdados As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbUSU001 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbUSU003 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tbUSU002 As System.Windows.Forms.TextBox
    Friend WithEvents gbsenha As System.Windows.Forms.GroupBox
    Friend WithEvents tbUSU004 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents tbUSU007 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents tbUSU005 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnF7 As System.Windows.Forms.Button
    Friend WithEvents btnF2 As System.Windows.Forms.Button
    Friend WithEvents btnF6 As System.Windows.Forms.Button
    Friend WithEvents btnF3 As System.Windows.Forms.Button
    Friend WithEvents btnF5 As System.Windows.Forms.Button
    Friend WithEvents btnF4 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label




End Class
