<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisitante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisitante))
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.imgBarra = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.g02 = New System.Windows.Forms.GroupBox()
        Me.FUN025 = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gb01 = New System.Windows.Forms.GroupBox()
        Me.FUN002 = New System.Windows.Forms.Label()
        Me.FUN003 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gb07 = New System.Windows.Forms.GroupBox()
        Me.opcao = New System.Windows.Forms.Label()
        Me.btnFoto = New System.Windows.Forms.Button()
        Me.FUN020 = New System.Windows.Forms.MaskedTextBox()
        Me.FUN009 = New System.Windows.Forms.MaskedTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.FUN012 = New System.Windows.Forms.MaskedTextBox()
        Me.FUN011 = New System.Windows.Forms.MaskedTextBox()
        Me.FUN008 = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.FUN016 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.FUN017 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.FUN010 = New System.Windows.Forms.TextBox()
        Me.FUN018 = New System.Windows.Forms.TextBox()
        Me.FUN019 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.FUN021 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnmail = New System.Windows.Forms.Button()
        Me.img = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.g02.SuspendLayout()
        Me.gb01.SuspendLayout()
        Me.gb07.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(631, 25)
        Me.Label1.TabIndex = 249
        Me.Label1.Text = " Manutenção de Visitantes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(498, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 14)
        Me.Label2.TabIndex = 259
        Me.Label2.Text = "Data do Cadastro:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'g02
        '
        Me.g02.BackColor = System.Drawing.Color.WhiteSmoke
        Me.g02.Controls.Add(Me.FUN025)
        Me.g02.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.g02.ForeColor = System.Drawing.Color.Black
        Me.g02.Location = New System.Drawing.Point(498, 102)
        Me.g02.Name = "g02"
        Me.g02.Size = New System.Drawing.Size(116, 44)
        Me.g02.TabIndex = 258
        Me.g02.TabStop = False
        '
        'FUN025
        '
        Me.FUN025.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FUN025.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FUN025.CalendarMonthBackground = System.Drawing.Color.White
        Me.FUN025.CalendarTitleBackColor = System.Drawing.Color.Blue
        Me.FUN025.CalendarTitleForeColor = System.Drawing.Color.White
        Me.FUN025.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.FUN025.CustomFormat = ""
        Me.FUN025.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.FUN025.Enabled = False
        Me.FUN025.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FUN025.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FUN025.Location = New System.Drawing.Point(9, 14)
        Me.FUN025.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.FUN025.MaxDate = New Date(2090, 12, 31, 0, 0, 0, 0)
        Me.FUN025.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.FUN025.Name = "FUN025"
        Me.FUN025.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FUN025.Size = New System.Drawing.Size(94, 21)
        Me.FUN025.TabIndex = 223
        Me.FUN025.Value = New Date(2009, 10, 17, 0, 0, 0, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(107, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 14)
        Me.Label15.TabIndex = 255
        Me.Label15.Text = "Nome:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb01
        '
        Me.gb01.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gb01.Controls.Add(Me.FUN002)
        Me.gb01.Controls.Add(Me.FUN003)
        Me.gb01.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb01.Location = New System.Drawing.Point(17, 102)
        Me.gb01.Name = "gb01"
        Me.gb01.Size = New System.Drawing.Size(475, 44)
        Me.gb01.TabIndex = 257
        Me.gb01.TabStop = False
        '
        'FUN002
        '
        Me.FUN002.BackColor = System.Drawing.Color.White
        Me.FUN002.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FUN002.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FUN002.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FUN002.Location = New System.Drawing.Point(6, 12)
        Me.FUN002.Name = "FUN002"
        Me.FUN002.Size = New System.Drawing.Size(80, 22)
        Me.FUN002.TabIndex = 196
        Me.FUN002.Text = "000000"
        Me.FUN002.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FUN003
        '
        Me.FUN003.BackColor = System.Drawing.Color.White
        Me.FUN003.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FUN003.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FUN003.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FUN003.Location = New System.Drawing.Point(87, 12)
        Me.FUN003.MaxLength = 50
        Me.FUN003.Name = "FUN003"
        Me.FUN003.Size = New System.Drawing.Size(385, 22)
        Me.FUN003.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(31, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 14)
        Me.Label10.TabIndex = 254
        Me.Label10.Text = "Registro:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb07
        '
        Me.gb07.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gb07.Controls.Add(Me.opcao)
        Me.gb07.Controls.Add(Me.btnFoto)
        Me.gb07.Controls.Add(Me.FUN020)
        Me.gb07.Controls.Add(Me.FUN009)
        Me.gb07.Controls.Add(Me.Panel4)
        Me.gb07.Controls.Add(Me.FUN008)
        Me.gb07.Controls.Add(Me.Label16)
        Me.gb07.Controls.Add(Me.FUN016)
        Me.gb07.Controls.Add(Me.Label17)
        Me.gb07.Controls.Add(Me.FUN017)
        Me.gb07.Controls.Add(Me.Label19)
        Me.gb07.Controls.Add(Me.FUN010)
        Me.gb07.Controls.Add(Me.FUN018)
        Me.gb07.Controls.Add(Me.FUN019)
        Me.gb07.Controls.Add(Me.Label21)
        Me.gb07.Controls.Add(Me.Label22)
        Me.gb07.Controls.Add(Me.Label20)
        Me.gb07.Controls.Add(Me.Label23)
        Me.gb07.Controls.Add(Me.Label24)
        Me.gb07.Controls.Add(Me.Label25)
        Me.gb07.Controls.Add(Me.FUN021)
        Me.gb07.Controls.Add(Me.Label26)
        Me.gb07.Controls.Add(Me.btnmail)
        Me.gb07.Controls.Add(Me.img)
        Me.gb07.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb07.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gb07.Location = New System.Drawing.Point(17, 152)
        Me.gb07.Name = "gb07"
        Me.gb07.Size = New System.Drawing.Size(597, 492)
        Me.gb07.TabIndex = 256
        Me.gb07.TabStop = False
        '
        'opcao
        '
        Me.opcao.AutoSize = True
        Me.opcao.ForeColor = System.Drawing.Color.White
        Me.opcao.Location = New System.Drawing.Point(90, 202)
        Me.opcao.Name = "opcao"
        Me.opcao.Size = New System.Drawing.Size(39, 14)
        Me.opcao.TabIndex = 317
        Me.opcao.Text = "Label3"
        '
        'btnFoto
        '
        Me.btnFoto.BackColor = System.Drawing.Color.Gray
        Me.btnFoto.FlatAppearance.BorderSize = 0
        Me.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFoto.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoto.ForeColor = System.Drawing.Color.White
        Me.btnFoto.Location = New System.Drawing.Point(429, 192)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(155, 24)
        Me.btnFoto.TabIndex = 316
        Me.btnFoto.Text = "Foto - [F7]"
        Me.btnFoto.UseVisualStyleBackColor = False
        '
        'FUN020
        '
        Me.FUN020.BackColor = System.Drawing.Color.White
        Me.FUN020.Font = New System.Drawing.Font("Arial", 9.25!)
        Me.FUN020.ForeColor = System.Drawing.Color.Blue
        Me.FUN020.Location = New System.Drawing.Point(508, 61)
        Me.FUN020.Mask = "99999-999"
        Me.FUN020.Name = "FUN020"
        Me.FUN020.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.FUN020.Size = New System.Drawing.Size(76, 22)
        Me.FUN020.TabIndex = 220
        Me.FUN020.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FUN009
        '
        Me.FUN009.BackColor = System.Drawing.Color.White
        Me.FUN009.Font = New System.Drawing.Font("Arial", 9.25!)
        Me.FUN009.ForeColor = System.Drawing.Color.Blue
        Me.FUN009.Location = New System.Drawing.Point(293, 10)
        Me.FUN009.Name = "FUN009"
        Me.FUN009.Size = New System.Drawing.Size(136, 22)
        Me.FUN009.TabIndex = 219
        Me.FUN009.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.FUN012)
        Me.Panel4.Controls.Add(Me.FUN011)
        Me.Panel4.Location = New System.Drawing.Point(93, 112)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(491, 23)
        Me.Panel4.TabIndex = 218
        '
        'FUN012
        '
        Me.FUN012.BackColor = System.Drawing.Color.White
        Me.FUN012.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FUN012.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FUN012.ForeColor = System.Drawing.Color.Blue
        Me.FUN012.Location = New System.Drawing.Point(123, 3)
        Me.FUN012.Mask = "(99)00000-0000"
        Me.FUN012.Name = "FUN012"
        Me.FUN012.Size = New System.Drawing.Size(117, 15)
        Me.FUN012.TabIndex = 42
        Me.FUN012.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FUN011
        '
        Me.FUN011.BackColor = System.Drawing.Color.White
        Me.FUN011.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FUN011.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FUN011.ForeColor = System.Drawing.Color.Blue
        Me.FUN011.Location = New System.Drawing.Point(2, 3)
        Me.FUN011.Mask = "(99)00000-0000"
        Me.FUN011.Name = "FUN011"
        Me.FUN011.Size = New System.Drawing.Size(117, 15)
        Me.FUN011.TabIndex = 41
        Me.FUN011.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FUN008
        '
        Me.FUN008.BackColor = System.Drawing.Color.White
        Me.FUN008.Font = New System.Drawing.Font("Arial", 9.25!)
        Me.FUN008.ForeColor = System.Drawing.Color.Blue
        Me.FUN008.Location = New System.Drawing.Point(93, 10)
        Me.FUN008.Mask = "###,###,###-##"
        Me.FUN008.Name = "FUN008"
        Me.FUN008.Size = New System.Drawing.Size(125, 22)
        Me.FUN008.TabIndex = 217
        Me.FUN008.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(26, 116)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 14)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Telefones:"
        '
        'FUN016
        '
        Me.FUN016.BackColor = System.Drawing.Color.White
        Me.FUN016.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FUN016.Font = New System.Drawing.Font("Arial", 9.25!)
        Me.FUN016.ForeColor = System.Drawing.Color.Blue
        Me.FUN016.Location = New System.Drawing.Point(93, 36)
        Me.FUN016.MaxLength = 40
        Me.FUN016.Name = "FUN016"
        Me.FUN016.Size = New System.Drawing.Size(286, 22)
        Me.FUN016.TabIndex = 25
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(36, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 14)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Endereço:"
        '
        'FUN017
        '
        Me.FUN017.BackColor = System.Drawing.Color.White
        Me.FUN017.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FUN017.Font = New System.Drawing.Font("Arial", 9.25!)
        Me.FUN017.ForeColor = System.Drawing.Color.Blue
        Me.FUN017.Location = New System.Drawing.Point(442, 36)
        Me.FUN017.MaxLength = 20
        Me.FUN017.Name = "FUN017"
        Me.FUN017.Size = New System.Drawing.Size(142, 22)
        Me.FUN017.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(399, 39)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 14)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Bairro:"
        '
        'FUN010
        '
        Me.FUN010.BackColor = System.Drawing.Color.White
        Me.FUN010.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.FUN010.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FUN010.ForeColor = System.Drawing.Color.Red
        Me.FUN010.Location = New System.Drawing.Point(93, 139)
        Me.FUN010.MaxLength = 7000
        Me.FUN010.Multiline = True
        Me.FUN010.Name = "FUN010"
        Me.FUN010.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FUN010.Size = New System.Drawing.Size(491, 47)
        Me.FUN010.TabIndex = 83
        '
        'FUN018
        '
        Me.FUN018.BackColor = System.Drawing.Color.White
        Me.FUN018.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FUN018.Font = New System.Drawing.Font("Arial", 9.25!)
        Me.FUN018.ForeColor = System.Drawing.Color.Blue
        Me.FUN018.Location = New System.Drawing.Point(93, 61)
        Me.FUN018.MaxLength = 40
        Me.FUN018.Name = "FUN018"
        Me.FUN018.Size = New System.Drawing.Size(286, 22)
        Me.FUN018.TabIndex = 29
        '
        'FUN019
        '
        Me.FUN019.BackColor = System.Drawing.Color.White
        Me.FUN019.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FUN019.Font = New System.Drawing.Font("Arial", 9.25!)
        Me.FUN019.ForeColor = System.Drawing.Color.Blue
        Me.FUN019.Location = New System.Drawing.Point(442, 61)
        Me.FUN019.MaxLength = 2
        Me.FUN019.Name = "FUN019"
        Me.FUN019.Size = New System.Drawing.Size(26, 22)
        Me.FUN019.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(42, 14)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 14)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "CPF/MF:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(477, 64)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(28, 14)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Cep:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(245, 14)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 14)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "RG n°:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(12, 90)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(79, 14)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "Complemento:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(48, 64)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 14)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "Cidade:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(415, 64)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(24, 14)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "UF:"
        '
        'FUN021
        '
        Me.FUN021.BackColor = System.Drawing.Color.White
        Me.FUN021.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FUN021.Font = New System.Drawing.Font("Arial", 9.25!)
        Me.FUN021.ForeColor = System.Drawing.Color.Blue
        Me.FUN021.Location = New System.Drawing.Point(93, 86)
        Me.FUN021.MaxLength = 150
        Me.FUN021.Name = "FUN021"
        Me.FUN021.Size = New System.Drawing.Size(491, 22)
        Me.FUN021.TabIndex = 34
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Teal
        Me.Label26.Location = New System.Drawing.Point(14, 143)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(42, 14)
        Me.Label26.TabIndex = 42
        Me.Label26.Text = "E-Mail:"
        '
        'btnmail
        '
        Me.btnmail.BackColor = System.Drawing.Color.White
        Me.btnmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmail.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.btnmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmail.Image = CType(resources.GetObject("btnmail.Image"), System.Drawing.Image)
        Me.btnmail.Location = New System.Drawing.Point(47, 136)
        Me.btnmail.Name = "btnmail"
        Me.btnmail.Size = New System.Drawing.Size(40, 50)
        Me.btnmail.TabIndex = 194
        Me.btnmail.UseVisualStyleBackColor = False
        '
        'img
        '
        Me.img.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img.ErrorImage = CType(resources.GetObject("img.ErrorImage"), System.Drawing.Image)
        Me.img.InitialImage = CType(resources.GetObject("img.InitialImage"), System.Drawing.Image)
        Me.img.Location = New System.Drawing.Point(429, 217)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(155, 171)
        Me.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img.TabIndex = 315
        Me.img.TabStop = False
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
        Me.btnSave.Location = New System.Drawing.Point(145, 36)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(178, 36)
        Me.btnSave.TabIndex = 350
        Me.btnSave.Text = "Gravar Informações"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
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
        Me.btnhome.Location = New System.Drawing.Point(11, 35)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(115, 36)
        Me.btnhome.TabIndex = 349
        Me.btnhome.Text = "Voltar"
        Me.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(6, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(620, 45)
        Me.Panel1.TabIndex = 351
        '
        'frmVisitante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(631, 656)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.g02)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.gb01)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.gb07)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVisitante"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.g02.ResumeLayout(False)
        Me.gb01.ResumeLayout(False)
        Me.gb01.PerformLayout()
        Me.gb07.ResumeLayout(False)
        Me.gb07.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Protected WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents imgBarra As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents g02 As GroupBox
    Protected WithEvents FUN025 As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents gb01 As GroupBox
    Friend WithEvents FUN002 As Label
    Friend WithEvents FUN003 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents gb07 As GroupBox
    Friend WithEvents FUN020 As MaskedTextBox
    Friend WithEvents FUN009 As MaskedTextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents FUN012 As MaskedTextBox
    Friend WithEvents FUN011 As MaskedTextBox
    Friend WithEvents FUN008 As MaskedTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents FUN016 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents FUN017 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents FUN010 As TextBox
    Friend WithEvents FUN018 As TextBox
    Friend WithEvents FUN019 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents FUN021 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents btnmail As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnhome As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnFoto As Button
    Friend WithEvents img As PictureBox
    Friend WithEvents opcao As Label
End Class
