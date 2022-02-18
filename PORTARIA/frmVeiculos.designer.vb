<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVeiculos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVeiculos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VEI002 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VEI004 = New System.Windows.Forms.TextBox()
        Me.VEI003 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VEI007 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VEI006 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.VEI005 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.VEI008 = New System.Windows.Forms.PictureBox()
        Me.Tabela01 = New System.Windows.Forms.TabControl()
        Me.Tab1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.imgLimpo = New System.Windows.Forms.PictureBox()
        Me.Tab2 = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.lvFotos = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnCaptura = New System.Windows.Forms.Button()
        Me.imgbanco = New System.Windows.Forms.PictureBox()
        Me.btnimporta = New System.Windows.Forms.Button()
        Me.op1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.VEI008, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabela01.SuspendLayout()
        Me.Tab1.SuspendLayout()
        CType(Me.imgLimpo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab2.SuspendLayout()
        CType(Me.imgbanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(483, 25)
        Me.Label1.TabIndex = 249
        Me.Label1.Text = " Veículos"
        '
        'VEI002
        '
        Me.VEI002.BackColor = System.Drawing.Color.White
        Me.VEI002.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VEI002.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VEI002.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.VEI002.Location = New System.Drawing.Point(8, 15)
        Me.VEI002.MaxLength = 7
        Me.VEI002.Name = "VEI002"
        Me.VEI002.Size = New System.Drawing.Size(100, 26)
        Me.VEI002.TabIndex = 330
        Me.VEI002.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.VEI002)
        Me.GroupBox1.Controls.Add(Me.VEI004)
        Me.GroupBox1.Controls.Add(Me.VEI003)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 47)
        Me.GroupBox1.TabIndex = 331
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(111, -2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 14)
        Me.Label7.TabIndex = 345
        Me.Label7.Text = "Marca:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, -2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 14)
        Me.Label2.TabIndex = 344
        Me.Label2.Text = "Placas:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VEI004
        '
        Me.VEI004.BackColor = System.Drawing.Color.White
        Me.VEI004.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VEI004.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VEI004.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VEI004.Location = New System.Drawing.Point(284, 18)
        Me.VEI004.MaxLength = 30
        Me.VEI004.Name = "VEI004"
        Me.VEI004.Size = New System.Drawing.Size(170, 21)
        Me.VEI004.TabIndex = 338
        '
        'VEI003
        '
        Me.VEI003.BackColor = System.Drawing.Color.White
        Me.VEI003.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VEI003.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VEI003.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VEI003.Location = New System.Drawing.Point(111, 18)
        Me.VEI003.MaxLength = 40
        Me.VEI003.Name = "VEI003"
        Me.VEI003.Size = New System.Drawing.Size(170, 21)
        Me.VEI003.TabIndex = 334
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.VEI007)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.VEI006)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.VEI005)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 62)
        Me.Panel1.TabIndex = 332
        '
        'VEI007
        '
        Me.VEI007.BackColor = System.Drawing.Color.White
        Me.VEI007.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VEI007.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VEI007.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VEI007.Location = New System.Drawing.Point(325, 18)
        Me.VEI007.MaxLength = 2
        Me.VEI007.Name = "VEI007"
        Me.VEI007.Size = New System.Drawing.Size(45, 21)
        Me.VEI007.TabIndex = 340
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(299, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 14)
        Me.Label5.TabIndex = 341
        Me.Label5.Text = "UF:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VEI006
        '
        Me.VEI006.BackColor = System.Drawing.Color.White
        Me.VEI006.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VEI006.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VEI006.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VEI006.Location = New System.Drawing.Point(82, 33)
        Me.VEI006.MaxLength = 30
        Me.VEI006.Name = "VEI006"
        Me.VEI006.Size = New System.Drawing.Size(211, 21)
        Me.VEI006.TabIndex = 342
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(31, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 14)
        Me.Label4.TabIndex = 343
        Me.Label4.Text = "Cidade:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VEI005
        '
        Me.VEI005.BackColor = System.Drawing.Color.White
        Me.VEI005.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VEI005.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VEI005.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VEI005.Location = New System.Drawing.Point(82, 3)
        Me.VEI005.MaxLength = 30
        Me.VEI005.Name = "VEI005"
        Me.VEI005.Size = New System.Drawing.Size(211, 21)
        Me.VEI005.TabIndex = 340
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(49, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 14)
        Me.Label3.TabIndex = 341
        Me.Label3.Text = "Cor:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnhome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnhome.FlatAppearance.BorderSize = 0
        Me.btnhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhome.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.ForeColor = System.Drawing.Color.DimGray
        Me.btnhome.Image = CType(resources.GetObject("btnhome.Image"), System.Drawing.Image)
        Me.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhome.Location = New System.Drawing.Point(383, 608)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(79, 36)
        Me.btnhome.TabIndex = 333
        Me.btnhome.Text = "Voltar"
        Me.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'VEI008
        '
        Me.VEI008.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.VEI008.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VEI008.Location = New System.Drawing.Point(6, 74)
        Me.VEI008.Name = "VEI008"
        Me.VEI008.Size = New System.Drawing.Size(448, 387)
        Me.VEI008.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VEI008.TabIndex = 334
        Me.VEI008.TabStop = False
        '
        'Tabela01
        '
        Me.Tabela01.Controls.Add(Me.Tab1)
        Me.Tabela01.Controls.Add(Me.Tab2)
        Me.Tabela01.Location = New System.Drawing.Point(6, 85)
        Me.Tabela01.Name = "Tabela01"
        Me.Tabela01.SelectedIndex = 0
        Me.Tabela01.Size = New System.Drawing.Size(472, 516)
        Me.Tabela01.TabIndex = 337
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.Label6)
        Me.Tab1.Controls.Add(Me.Panel1)
        Me.Tab1.Controls.Add(Me.VEI008)
        Me.Tab1.Controls.Add(Me.imgLimpo)
        Me.Tab1.Location = New System.Drawing.Point(4, 22)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1.Size = New System.Drawing.Size(464, 490)
        Me.Tab1.TabIndex = 0
        Me.Tab1.Text = "Cadastro"
        Me.Tab1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 464)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(210, 13)
        Me.Label6.TabIndex = 335
        Me.Label6.Text = "Duplo click na imagem seleciona o veículo"
        '
        'imgLimpo
        '
        Me.imgLimpo.Image = CType(resources.GetObject("imgLimpo.Image"), System.Drawing.Image)
        Me.imgLimpo.Location = New System.Drawing.Point(172, 184)
        Me.imgLimpo.Name = "imgLimpo"
        Me.imgLimpo.Size = New System.Drawing.Size(121, 123)
        Me.imgLimpo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLimpo.TabIndex = 336
        Me.imgLimpo.TabStop = False
        '
        'Tab2
        '
        Me.Tab2.Controls.Add(Me.Button7)
        Me.Tab2.Controls.Add(Me.Button6)
        Me.Tab2.Controls.Add(Me.Button5)
        Me.Tab2.Controls.Add(Me.Button4)
        Me.Tab2.Controls.Add(Me.btnPerfil)
        Me.Tab2.Controls.Add(Me.lvFotos)
        Me.Tab2.Controls.Add(Me.btnCaptura)
        Me.Tab2.Controls.Add(Me.imgbanco)
        Me.Tab2.Controls.Add(Me.btnimporta)
        Me.Tab2.Location = New System.Drawing.Point(4, 22)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2.Size = New System.Drawing.Size(464, 490)
        Me.Tab2.TabIndex = 1
        Me.Tab2.Text = "Banco de Imagem"
        Me.Tab2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(291, 6)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(151, 24)
        Me.Button7.TabIndex = 345
        Me.Button7.Text = "Registrado Por"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(201, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(92, 24)
        Me.Button6.TabIndex = 344
        Me.Button6.Text = "Hora"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(111, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(92, 24)
        Me.Button5.TabIndex = 343
        Me.Button5.Text = "Data"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(10, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 24)
        Me.Button4.TabIndex = 342
        Me.Button4.Text = "Registro"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnPerfil
        '
        Me.btnPerfil.BackColor = System.Drawing.Color.White
        Me.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerfil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnPerfil.Image = CType(resources.GetObject("btnPerfil.Image"), System.Drawing.Image)
        Me.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPerfil.Location = New System.Drawing.Point(11, 419)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(100, 65)
        Me.btnPerfil.TabIndex = 341
        Me.btnPerfil.Text = "Exibir no Perfil"
        Me.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPerfil.UseVisualStyleBackColor = False
        '
        'lvFotos
        '
        Me.lvFotos.AllowColumnReorder = True
        Me.lvFotos.BackColor = System.Drawing.Color.White
        Me.lvFotos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvFotos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvFotos.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvFotos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lvFotos.FullRowSelect = True
        Me.lvFotos.GridLines = True
        Me.lvFotos.HideSelection = False
        Me.lvFotos.Location = New System.Drawing.Point(10, 6)
        Me.lvFotos.MultiSelect = False
        Me.lvFotos.Name = "lvFotos"
        Me.lvFotos.Size = New System.Drawing.Size(452, 138)
        Me.lvFotos.TabIndex = 340
        Me.lvFotos.UseCompatibleStateImageBehavior = False
        Me.lvFotos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Registro"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Data"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Hora"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Arquivo"
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Width = 0
        '
        'btnCaptura
        '
        Me.btnCaptura.BackColor = System.Drawing.Color.White
        Me.btnCaptura.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnCaptura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCaptura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaptura.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaptura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnCaptura.Image = CType(resources.GetObject("btnCaptura.Image"), System.Drawing.Image)
        Me.btnCaptura.Location = New System.Drawing.Point(10, 227)
        Me.btnCaptura.Name = "btnCaptura"
        Me.btnCaptura.Size = New System.Drawing.Size(100, 65)
        Me.btnCaptura.TabIndex = 339
        Me.btnCaptura.Text = "Captura Imagem"
        Me.btnCaptura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCaptura.UseVisualStyleBackColor = False
        '
        'imgbanco
        '
        Me.imgbanco.BackColor = System.Drawing.Color.White
        Me.imgbanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgbanco.Location = New System.Drawing.Point(116, 156)
        Me.imgbanco.Name = "imgbanco"
        Me.imgbanco.Size = New System.Drawing.Size(342, 328)
        Me.imgbanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgbanco.TabIndex = 337
        Me.imgbanco.TabStop = False
        '
        'btnimporta
        '
        Me.btnimporta.BackColor = System.Drawing.Color.White
        Me.btnimporta.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnimporta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnimporta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimporta.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimporta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnimporta.Image = CType(resources.GetObject("btnimporta.Image"), System.Drawing.Image)
        Me.btnimporta.Location = New System.Drawing.Point(10, 156)
        Me.btnimporta.Name = "btnimporta"
        Me.btnimporta.Size = New System.Drawing.Size(100, 65)
        Me.btnimporta.TabIndex = 338
        Me.btnimporta.Text = "Importa Imagem"
        Me.btnimporta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnimporta.UseVisualStyleBackColor = False
        '
        'op1
        '
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(289, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 14)
        Me.Label8.TabIndex = 346
        Me.Label8.Text = "Modelo:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.DimGray
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(16, 608)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(178, 36)
        Me.btnSave.TabIndex = 347
        Me.btnSave.Text = "Gravar Informações"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(8, 603)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(465, 45)
        Me.Panel2.TabIndex = 348
        '
        'frmVeiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(483, 654)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Tabela01)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVeiculos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.VEI008, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabela01.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        CType(Me.imgLimpo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab2.ResumeLayout(False)
        CType(Me.imgbanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VEI002 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnhome As System.Windows.Forms.Button
    Friend WithEvents VEI007 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents VEI006 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents VEI005 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents VEI004 As System.Windows.Forms.TextBox
    Friend WithEvents VEI003 As System.Windows.Forms.TextBox
    Friend WithEvents VEI008 As System.Windows.Forms.PictureBox
    Friend WithEvents Tabela01 As System.Windows.Forms.TabControl
    Friend WithEvents Tab1 As System.Windows.Forms.TabPage
    Friend WithEvents Tab2 As System.Windows.Forms.TabPage
    Friend WithEvents op1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnCaptura As System.Windows.Forms.Button
    Friend WithEvents imgbanco As System.Windows.Forms.PictureBox
    Friend WithEvents btnimporta As System.Windows.Forms.Button
    Friend WithEvents lvFotos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPerfil As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents imgLimpo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As Panel



End Class
