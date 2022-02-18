<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Licenca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Licenca))
        Me.op1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnF5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.REG002 = New System.Windows.Forms.TextBox()
        Me.REG009 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.REG014 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.REG011 = New System.Windows.Forms.MaskedTextBox()
        Me.REG004 = New System.Windows.Forms.TextBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.REG008 = New System.Windows.Forms.TextBox()
        Me.REG006 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.REG007 = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.REG005 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.REG012 = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.REG003 = New System.Windows.Forms.TextBox()
        Me.REG010 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.tbcp120 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'op1
        '
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.ForeColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(236, 181)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(677, 371)
        Me.Panel1.TabIndex = 218
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.btnF5)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.ForeColor = System.Drawing.Color.Gray
        Me.Panel2.Location = New System.Drawing.Point(0, 304)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(675, 65)
        Me.Panel2.TabIndex = 218
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
        Me.btnF5.Location = New System.Drawing.Point(601, 6)
        Me.btnF5.Name = "btnF5"
        Me.btnF5.Size = New System.Drawing.Size(65, 52)
        Me.btnF5.TabIndex = 311
        Me.btnF5.Text = "Gravar"
        Me.btnF5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnF5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gray
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.ImageKey = "btn05.png"
        Me.Button1.Location = New System.Drawing.Point(3, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(428, 24)
        Me.Button1.TabIndex = 266
        Me.Button1.Text = "[ESC] - Fecha o Formulário"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.REG002)
        Me.GroupBox4.Controls.Add(Me.REG009)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox4.Location = New System.Drawing.Point(11, 26)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(652, 57)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.Gray
        Me.Label15.Location = New System.Drawing.Point(500, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "CNPJ/MF:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(7, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Nome da empresa:"
        '
        'REG002
        '
        Me.REG002.BackColor = System.Drawing.Color.White
        Me.REG002.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.REG002.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG002.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.REG002.Location = New System.Drawing.Point(8, 27)
        Me.REG002.MaxLength = 50
        Me.REG002.Name = "REG002"
        Me.REG002.ReadOnly = True
        Me.REG002.Size = New System.Drawing.Size(488, 22)
        Me.REG002.TabIndex = 29
        '
        'REG009
        '
        Me.REG009.BackColor = System.Drawing.Color.White
        Me.REG009.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG009.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.REG009.Location = New System.Drawing.Point(502, 28)
        Me.REG009.Mask = "00,000,000/0000-00"
        Me.REG009.Name = "REG009"
        Me.REG009.ReadOnly = True
        Me.REG009.Size = New System.Drawing.Size(144, 21)
        Me.REG009.TabIndex = 36
        Me.REG009.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.REG014)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.REG011)
        Me.GroupBox5.Controls.Add(Me.REG004)
        Me.GroupBox5.Controls.Add(Me.pb1)
        Me.GroupBox5.Controls.Add(Me.REG008)
        Me.GroupBox5.Controls.Add(Me.REG006)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.REG007)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.REG005)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.REG012)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.REG003)
        Me.GroupBox5.Controls.Add(Me.REG010)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox5.Location = New System.Drawing.Point(11, 89)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(652, 202)
        Me.GroupBox5.TabIndex = 38
        Me.GroupBox5.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(53, 166)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 14)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Email:"
        '
        'REG014
        '
        Me.REG014.BackColor = System.Drawing.Color.White
        Me.REG014.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.REG014.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.REG014.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.REG014.Location = New System.Drawing.Point(98, 162)
        Me.REG014.MaxLength = 100
        Me.REG014.Name = "REG014"
        Me.REG014.Size = New System.Drawing.Size(415, 21)
        Me.REG014.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(21, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 14)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Complemento:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Silver
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(519, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Label14.Size = New System.Drawing.Size(127, 26)
        Me.Label14.TabIndex = 201
        Me.Label14.Text = "Logomarca  [F8]"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'REG011
        '
        Me.REG011.BackColor = System.Drawing.Color.White
        Me.REG011.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG011.ForeColor = System.Drawing.Color.Black
        Me.REG011.Location = New System.Drawing.Point(10, 27)
        Me.REG011.Mask = "(99)00000-0000"
        Me.REG011.Name = "REG011"
        Me.REG011.Size = New System.Drawing.Size(127, 21)
        Me.REG011.TabIndex = 52
        Me.REG011.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REG004
        '
        Me.REG004.BackColor = System.Drawing.Color.White
        Me.REG004.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.REG004.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.REG004.ForeColor = System.Drawing.Color.Black
        Me.REG004.Location = New System.Drawing.Point(98, 81)
        Me.REG004.MaxLength = 40
        Me.REG004.Name = "REG004"
        Me.REG004.Size = New System.Drawing.Size(165, 21)
        Me.REG004.TabIndex = 1
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.White
        Me.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb1.Location = New System.Drawing.Point(519, 54)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(127, 129)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1.TabIndex = 0
        Me.pb1.TabStop = False
        '
        'REG008
        '
        Me.REG008.BackColor = System.Drawing.Color.White
        Me.REG008.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.REG008.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.REG008.ForeColor = System.Drawing.Color.Black
        Me.REG008.Location = New System.Drawing.Point(97, 135)
        Me.REG008.MaxLength = 50
        Me.REG008.Name = "REG008"
        Me.REG008.Size = New System.Drawing.Size(416, 21)
        Me.REG008.TabIndex = 35
        '
        'REG006
        '
        Me.REG006.BackColor = System.Drawing.Color.White
        Me.REG006.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.REG006.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.REG006.ForeColor = System.Drawing.Color.Black
        Me.REG006.Location = New System.Drawing.Point(97, 108)
        Me.REG006.MaxLength = 2
        Me.REG006.Name = "REG006"
        Me.REG006.Size = New System.Drawing.Size(40, 21)
        Me.REG006.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(279, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Inscrição Estadual:"
        '
        'REG007
        '
        Me.REG007.BackColor = System.Drawing.Color.White
        Me.REG007.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG007.ForeColor = System.Drawing.Color.Black
        Me.REG007.Location = New System.Drawing.Point(189, 108)
        Me.REG007.Mask = "00000-000"
        Me.REG007.Name = "REG007"
        Me.REG007.Size = New System.Drawing.Size(74, 21)
        Me.REG007.TabIndex = 34
        Me.REG007.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.ForeColor = System.Drawing.Color.Gray
        Me.Label17.Location = New System.Drawing.Point(145, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Telefone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(158, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 14)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Cep:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(71, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 14)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "UF:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(275, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 14)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Cidade:"
        '
        'REG005
        '
        Me.REG005.BackColor = System.Drawing.Color.White
        Me.REG005.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.REG005.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.REG005.ForeColor = System.Drawing.Color.Black
        Me.REG005.Location = New System.Drawing.Point(321, 81)
        Me.REG005.MaxLength = 40
        Me.REG005.Name = "REG005"
        Me.REG005.Size = New System.Drawing.Size(192, 21)
        Me.REG005.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(56, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 14)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Bairro:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.Gray
        Me.Label16.Location = New System.Drawing.Point(12, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Telefone"
        '
        'REG012
        '
        Me.REG012.BackColor = System.Drawing.Color.White
        Me.REG012.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REG012.ForeColor = System.Drawing.Color.Black
        Me.REG012.Location = New System.Drawing.Point(143, 27)
        Me.REG012.Mask = "(99)00000-0000"
        Me.REG012.Name = "REG012"
        Me.REG012.Size = New System.Drawing.Size(127, 21)
        Me.REG012.TabIndex = 50
        Me.REG012.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(39, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 14)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Endereço:"
        '
        'REG003
        '
        Me.REG003.BackColor = System.Drawing.Color.White
        Me.REG003.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.REG003.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.REG003.ForeColor = System.Drawing.Color.Black
        Me.REG003.Location = New System.Drawing.Point(98, 54)
        Me.REG003.MaxLength = 50
        Me.REG003.Name = "REG003"
        Me.REG003.Size = New System.Drawing.Size(415, 21)
        Me.REG003.TabIndex = 0
        '
        'REG010
        '
        Me.REG010.BackColor = System.Drawing.Color.White
        Me.REG010.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.REG010.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.REG010.ForeColor = System.Drawing.Color.Black
        Me.REG010.Location = New System.Drawing.Point(276, 27)
        Me.REG010.MaxLength = 20
        Me.REG010.Name = "REG010"
        Me.REG010.Size = New System.Drawing.Size(237, 21)
        Me.REG010.TabIndex = 38
        Me.REG010.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(236, 554)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(677, 26)
        Me.Label2.TabIndex = 300
        Me.Label2.Text = "O nome da empresa e o CNPJ não serão alterados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnhome.Location = New System.Drawing.Point(5, 5)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(115, 46)
        Me.btnhome.TabIndex = 302
        Me.btnhome.Text = "Voltar"
        Me.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'tbcp120
        '
        Me.tbcp120.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tbcp120.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcp120.ForeColor = System.Drawing.Color.Gray
        Me.tbcp120.Location = New System.Drawing.Point(236, 151)
        Me.tbcp120.Name = "tbcp120"
        Me.tbcp120.Size = New System.Drawing.Size(676, 25)
        Me.tbcp120.TabIndex = 303
        Me.tbcp120.Text = "  Registro do sistema"
        Me.tbcp120.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Licenca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 714)
        Me.Controls.Add(Me.tbcp120)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Licenca"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents op1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents REG002 As System.Windows.Forms.TextBox
    Friend WithEvents REG009 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents REG014 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents REG011 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents REG004 As System.Windows.Forms.TextBox
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents REG008 As System.Windows.Forms.TextBox
    Friend WithEvents REG006 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents REG007 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents REG005 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents REG012 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents REG003 As System.Windows.Forms.TextBox
    Friend WithEvents REG010 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnF5 As Button
    Friend WithEvents btnhome As System.Windows.Forms.Button
    Friend WithEvents tbcp120 As Label


End Class
