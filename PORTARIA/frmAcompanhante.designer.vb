<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcompanhante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcompanhante))
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.imgBarra = New System.Windows.Forms.ImageList(Me.components)
        Me.G2 = New System.Windows.Forms.GroupBox()
        Me.Soma = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CON08 = New System.Windows.Forms.TextBox()
        Me.CON07 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CADP003 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CON02 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnF7 = New System.Windows.Forms.Button()
        Me.btnF5 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lvdados = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnFoto = New System.Windows.Forms.Button()
        Me.img = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ACP04 = New System.Windows.Forms.TextBox()
        Me.ACP02 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.addCargo = New System.Windows.Forms.Button()
        Me.G2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        'G2
        '
        Me.G2.Controls.Add(Me.Soma)
        Me.G2.Controls.Add(Me.Label2)
        Me.G2.Controls.Add(Me.CON08)
        Me.G2.Controls.Add(Me.CON07)
        Me.G2.Controls.Add(Me.Label10)
        Me.G2.Controls.Add(Me.Label6)
        Me.G2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.G2.Location = New System.Drawing.Point(447, 30)
        Me.G2.Name = "G2"
        Me.G2.Size = New System.Drawing.Size(320, 45)
        Me.G2.TabIndex = 331
        Me.G2.TabStop = False
        Me.G2.Text = "Acompanhantes:"
        '
        'Soma
        '
        Me.Soma.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Soma.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Soma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Soma.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Soma.ForeColor = System.Drawing.Color.Black
        Me.Soma.Location = New System.Drawing.Point(270, 20)
        Me.Soma.MaxLength = 30
        Me.Soma.Name = "Soma"
        Me.Soma.ReadOnly = True
        Me.Soma.Size = New System.Drawing.Size(38, 14)
        Me.Soma.TabIndex = 335
        Me.Soma.Text = "00"
        Me.Soma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(230, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 14)
        Me.Label2.TabIndex = 334
        Me.Label2.Text = "Total:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CON08
        '
        Me.CON08.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CON08.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CON08.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CON08.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CON08.ForeColor = System.Drawing.Color.Black
        Me.CON08.Location = New System.Drawing.Point(177, 20)
        Me.CON08.MaxLength = 30
        Me.CON08.Name = "CON08"
        Me.CON08.ReadOnly = True
        Me.CON08.Size = New System.Drawing.Size(38, 14)
        Me.CON08.TabIndex = 333
        Me.CON08.Text = "00"
        Me.CON08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CON07
        '
        Me.CON07.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CON07.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CON07.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CON07.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CON07.ForeColor = System.Drawing.Color.Black
        Me.CON07.Location = New System.Drawing.Point(64, 20)
        Me.CON07.MaxLength = 30
        Me.CON07.Name = "CON07"
        Me.CON07.ReadOnly = True
        Me.CON07.Size = New System.Drawing.Size(38, 14)
        Me.CON07.TabIndex = 332
        Me.CON07.Text = "00"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CADP003)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 45)
        Me.GroupBox1.TabIndex = 336
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Responsável:"
        '
        'CADP003
        '
        Me.CADP003.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CADP003.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CADP003.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CADP003.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CADP003.ForeColor = System.Drawing.Color.Black
        Me.CADP003.Location = New System.Drawing.Point(6, 20)
        Me.CADP003.MaxLength = 30
        Me.CADP003.Name = "CADP003"
        Me.CADP003.ReadOnly = True
        Me.CADP003.Size = New System.Drawing.Size(421, 14)
        Me.CADP003.TabIndex = 332
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
        Me.Label1.Size = New System.Drawing.Size(775, 25)
        Me.Label1.TabIndex = 249
        Me.Label1.Text = "Cadastro e controle de acompanhantes"
        '
        'CON02
        '
        Me.CON02.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CON02.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CON02.ForeColor = System.Drawing.Color.White
        Me.CON02.Location = New System.Drawing.Point(688, 5)
        Me.CON02.Name = "CON02"
        Me.CON02.Size = New System.Drawing.Size(83, 14)
        Me.CON02.TabIndex = 340
        Me.CON02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(631, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 14)
        Me.Label4.TabIndex = 341
        Me.Label4.Text = "Ticket:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnF7.Location = New System.Drawing.Point(698, 397)
        Me.btnF7.Name = "btnF7"
        Me.btnF7.Size = New System.Drawing.Size(65, 52)
        Me.btnF7.TabIndex = 342
        Me.btnF7.Text = "Cancela"
        Me.btnF7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnF7.UseVisualStyleBackColor = False
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
        Me.btnF5.Location = New System.Drawing.Point(628, 397)
        Me.btnF5.Name = "btnF5"
        Me.btnF5.Size = New System.Drawing.Size(65, 52)
        Me.btnF5.TabIndex = 343
        Me.btnF5.Text = "Gravar"
        Me.btnF5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnF5.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.lvdados)
        Me.Panel3.Location = New System.Drawing.Point(8, 160)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(600, 196)
        Me.Panel3.TabIndex = 344
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(415, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 24)
        Me.Button1.TabIndex = 340
        Me.Button1.Text = "Classificação"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(413, 24)
        Me.Button2.TabIndex = 339
        Me.Button2.Text = "Nome"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lvdados
        '
        Me.lvdados.AllowColumnReorder = True
        Me.lvdados.BackColor = System.Drawing.Color.White
        Me.lvdados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvdados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvdados.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvdados.ForeColor = System.Drawing.Color.Black
        Me.lvdados.FullRowSelect = True
        Me.lvdados.GridLines = True
        Me.lvdados.HideSelection = False
        Me.lvdados.Location = New System.Drawing.Point(5, 3)
        Me.lvdados.MultiSelect = False
        Me.lvdados.Name = "lvdados"
        Me.lvdados.Size = New System.Drawing.Size(589, 176)
        Me.lvdados.TabIndex = 259
        Me.lvdados.UseCompatibleStateImageBehavior = False
        Me.lvdados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ACP02"
        Me.ColumnHeader1.Width = 410
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ACP04"
        Me.ColumnHeader2.Width = 160
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ACP01"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ACP05"
        Me.ColumnHeader4.Width = 0
        '
        'btnFoto
        '
        Me.btnFoto.BackColor = System.Drawing.Color.Gray
        Me.btnFoto.FlatAppearance.BorderSize = 0
        Me.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFoto.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoto.ForeColor = System.Drawing.Color.White
        Me.btnFoto.Location = New System.Drawing.Point(612, 160)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(155, 24)
        Me.btnFoto.TabIndex = 346
        Me.btnFoto.Text = "Foto - [F7]"
        Me.btnFoto.UseVisualStyleBackColor = False
        '
        'img
        '
        Me.img.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img.ErrorImage = CType(resources.GetObject("img.ErrorImage"), System.Drawing.Image)
        Me.img.InitialImage = CType(resources.GetObject("img.InitialImage"), System.Drawing.Image)
        Me.img.Location = New System.Drawing.Point(612, 185)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(155, 171)
        Me.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img.TabIndex = 345
        Me.img.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ACP04)
        Me.GroupBox2.Controls.Add(Me.ACP02)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(600, 42)
        Me.GroupBox2.TabIndex = 349
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(418, -1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 14)
        Me.Label7.TabIndex = 351
        Me.Label7.Text = "Classificação"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, -1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 14)
        Me.Label5.TabIndex = 350
        Me.Label5.Text = "Nome do acompanhante"
        '
        'ACP04
        '
        Me.ACP04.BackColor = System.Drawing.Color.White
        Me.ACP04.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ACP04.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACP04.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ACP04.Location = New System.Drawing.Point(416, 15)
        Me.ACP04.MaxLength = 50
        Me.ACP04.Name = "ACP04"
        Me.ACP04.Size = New System.Drawing.Size(161, 22)
        Me.ACP04.TabIndex = 22
        '
        'ACP02
        '
        Me.ACP02.BackColor = System.Drawing.Color.White
        Me.ACP02.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ACP02.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACP02.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ACP02.Location = New System.Drawing.Point(6, 15)
        Me.ACP02.MaxLength = 50
        Me.ACP02.Name = "ACP02"
        Me.ACP02.Size = New System.Drawing.Size(411, 22)
        Me.ACP02.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(8, 369)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(600, 112)
        Me.Label8.TabIndex = 350
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'addCargo
        '
        Me.addCargo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.addCargo.BackColor = System.Drawing.Color.Transparent
        Me.addCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addCargo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addCargo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.addCargo.FlatAppearance.BorderSize = 0
        Me.addCargo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow
        Me.addCargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.addCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addCargo.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold)
        Me.addCargo.Image = CType(resources.GetObject("addCargo.Image"), System.Drawing.Image)
        Me.addCargo.Location = New System.Drawing.Point(612, 100)
        Me.addCargo.Name = "addCargo"
        Me.addCargo.Size = New System.Drawing.Size(110, 30)
        Me.addCargo.TabIndex = 351
        Me.addCargo.Text = "Novo Registro"
        Me.addCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.addCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.addCargo.UseVisualStyleBackColor = False
        '
        'frmAcompanhante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(775, 493)
        Me.ControlBox = False
        Me.Controls.Add(Me.addCargo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnFoto)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnF5)
        Me.Controls.Add(Me.btnF7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CON02)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.G2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.img)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAcompanhante"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.G2.ResumeLayout(False)
        Me.G2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Protected WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents imgBarra As System.Windows.Forms.ImageList
    Friend WithEvents G2 As GroupBox
    Friend WithEvents Soma As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CON08 As TextBox
    Friend WithEvents CON07 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CADP003 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CON02 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnF7 As Button
    Friend WithEvents btnF5 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lvdados As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btnFoto As Button
    Friend WithEvents img As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ACP04 As TextBox
    Friend WithEvents ACP02 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents addCargo As Button
End Class
