<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aviso08
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aviso08))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CADP003 = New System.Windows.Forms.TextBox()
        Me.CADP002 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCapIMG = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.btnCaptura = New System.Windows.Forms.Button()
        Me.btnimporta = New System.Windows.Forms.Button()
        Me.imgbanco = New System.Windows.Forms.PictureBox()
        Me.lvFotos = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CADP026 = New System.Windows.Forms.Label()
        Me.imgLimpo = New System.Windows.Forms.PictureBox()
        Me.imgCam = New System.Windows.Forms.PictureBox()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.op1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CADP001 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.imgbanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLimpo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label1.Text = " Imagem"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CADP003)
        Me.GroupBox1.Controls.Add(Me.CADP002)
        Me.GroupBox1.Location = New System.Drawing.Point(77, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 45)
        Me.GroupBox1.TabIndex = 252
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identificação:"
        '
        'CADP003
        '
        Me.CADP003.BackColor = System.Drawing.Color.White
        Me.CADP003.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CADP003.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CADP003.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CADP003.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CADP003.Location = New System.Drawing.Point(90, 18)
        Me.CADP003.MaxLength = 50
        Me.CADP003.Name = "CADP003"
        Me.CADP003.Size = New System.Drawing.Size(371, 16)
        Me.CADP003.TabIndex = 208
        '
        'CADP002
        '
        Me.CADP002.BackColor = System.Drawing.Color.White
        Me.CADP002.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CADP002.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CADP002.Location = New System.Drawing.Point(9, 18)
        Me.CADP002.Name = "CADP002"
        Me.CADP002.Size = New System.Drawing.Size(80, 16)
        Me.CADP002.TabIndex = 209
        Me.CADP002.Text = "000000"
        Me.CADP002.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnCapIMG)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.btnPerfil)
        Me.Panel1.Controls.Add(Me.btnCaptura)
        Me.Panel1.Controls.Add(Me.btnimporta)
        Me.Panel1.Controls.Add(Me.imgbanco)
        Me.Panel1.Controls.Add(Me.lvFotos)
        Me.Panel1.Controls.Add(Me.CADP026)
        Me.Panel1.Controls.Add(Me.imgLimpo)
        Me.Panel1.Controls.Add(Me.imgCam)
        Me.Panel1.Location = New System.Drawing.Point(77, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(471, 490)
        Me.Panel1.TabIndex = 253
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(11, 354)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 65)
        Me.btnCancel.TabIndex = 358
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Captura imagem de uma webcam")
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnCapIMG
        '
        Me.btnCapIMG.BackColor = System.Drawing.Color.White
        Me.btnCapIMG.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnCapIMG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCapIMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCapIMG.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapIMG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnCapIMG.Image = CType(resources.GetObject("btnCapIMG.Image"), System.Drawing.Image)
        Me.btnCapIMG.Location = New System.Drawing.Point(11, 288)
        Me.btnCapIMG.Name = "btnCapIMG"
        Me.btnCapIMG.Size = New System.Drawing.Size(100, 65)
        Me.btnCapIMG.TabIndex = 357
        Me.btnCapIMG.Text = "Arquivar"
        Me.btnCapIMG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btnCapIMG, "Captura imagem de uma webcam")
        Me.btnCapIMG.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Gray
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(289, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(151, 24)
        Me.Button7.TabIndex = 354
        Me.Button7.Text = "Registrado Por"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Gray
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(199, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(92, 24)
        Me.Button6.TabIndex = 353
        Me.Button6.Text = "Hora"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Gray
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(109, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(92, 24)
        Me.Button5.TabIndex = 352
        Me.Button5.Text = "Data"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gray
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(8, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 24)
        Me.Button4.TabIndex = 351
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
        Me.btnPerfil.Location = New System.Drawing.Point(11, 420)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(100, 65)
        Me.btnPerfil.TabIndex = 350
        Me.btnPerfil.Text = "Exibir no Perfil"
        Me.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btnPerfil, "Seleciona a imagem para exibir no perfil  do cadastro")
        Me.btnPerfil.UseVisualStyleBackColor = False
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
        Me.btnCaptura.Location = New System.Drawing.Point(12, 222)
        Me.btnCaptura.Name = "btnCaptura"
        Me.btnCaptura.Size = New System.Drawing.Size(100, 65)
        Me.btnCaptura.TabIndex = 348
        Me.btnCaptura.Text = "Captura Imagem"
        Me.btnCaptura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btnCaptura, "Captura imagem de uma webcam")
        Me.btnCaptura.UseVisualStyleBackColor = False
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
        Me.btnimporta.Location = New System.Drawing.Point(12, 155)
        Me.btnimporta.Name = "btnimporta"
        Me.btnimporta.Size = New System.Drawing.Size(100, 65)
        Me.btnimporta.TabIndex = 347
        Me.btnimporta.Text = "Importa Imagem"
        Me.btnimporta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btnimporta, "Importa imagem armazenada neste computador")
        Me.btnimporta.UseVisualStyleBackColor = False
        '
        'imgbanco
        '
        Me.imgbanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.imgbanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgbanco.Location = New System.Drawing.Point(117, 155)
        Me.imgbanco.Name = "imgbanco"
        Me.imgbanco.Size = New System.Drawing.Size(342, 328)
        Me.imgbanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgbanco.TabIndex = 346
        Me.imgbanco.TabStop = False
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
        Me.lvFotos.Location = New System.Drawing.Point(8, 5)
        Me.lvFotos.MultiSelect = False
        Me.lvFotos.Name = "lvFotos"
        Me.lvFotos.Size = New System.Drawing.Size(452, 138)
        Me.lvFotos.TabIndex = 349
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
        'CADP026
        '
        Me.CADP026.AutoSize = True
        Me.CADP026.Location = New System.Drawing.Point(49, 87)
        Me.CADP026.Name = "CADP026"
        Me.CADP026.Size = New System.Drawing.Size(39, 13)
        Me.CADP026.TabIndex = 356
        Me.CADP026.Text = "Label2"
        '
        'imgLimpo
        '
        Me.imgLimpo.Image = CType(resources.GetObject("imgLimpo.Image"), System.Drawing.Image)
        Me.imgLimpo.Location = New System.Drawing.Point(147, 73)
        Me.imgLimpo.Name = "imgLimpo"
        Me.imgLimpo.Size = New System.Drawing.Size(37, 27)
        Me.imgLimpo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLimpo.TabIndex = 355
        Me.imgLimpo.TabStop = False
        '
        'imgCam
        '
        Me.imgCam.Image = CType(resources.GetObject("imgCam.Image"), System.Drawing.Image)
        Me.imgCam.Location = New System.Drawing.Point(117, 155)
        Me.imgCam.Name = "imgCam"
        Me.imgCam.Size = New System.Drawing.Size(342, 328)
        Me.imgCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCam.TabIndex = 359
        Me.imgCam.TabStop = False
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.Transparent
        Me.btnhome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnhome.FlatAppearance.BorderSize = 0
        Me.btnhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhome.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.ForeColor = System.Drawing.Color.DimGray
        Me.btnhome.Image = CType(resources.GetObject("btnhome.Image"), System.Drawing.Image)
        Me.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhome.Location = New System.Drawing.Point(547, 614)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(79, 36)
        Me.btnhome.TabIndex = 348
        Me.btnhome.Text = "Voltar"
        Me.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhome.UseVisualStyleBackColor = False
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
        'CADP001
        '
        Me.CADP001.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CADP001.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CADP001.ForeColor = System.Drawing.Color.White
        Me.CADP001.Location = New System.Drawing.Point(501, 4)
        Me.CADP001.Name = "CADP001"
        Me.CADP001.Size = New System.Drawing.Size(125, 16)
        Me.CADP001.TabIndex = 210
        Me.CADP001.Text = "000000"
        Me.CADP001.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Aviso08
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(631, 656)
        Me.ControlBox = False
        Me.Controls.Add(Me.CADP001)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Aviso08"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.imgbanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLimpo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CADP003 As System.Windows.Forms.TextBox
    Friend WithEvents CADP002 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnPerfil As System.Windows.Forms.Button
    Friend WithEvents lvFotos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCaptura As System.Windows.Forms.Button
    Friend WithEvents btnimporta As System.Windows.Forms.Button
    Friend WithEvents btnhome As System.Windows.Forms.Button
    Friend WithEvents op1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents imgLimpo As System.Windows.Forms.PictureBox
    Friend WithEvents CADP026 As System.Windows.Forms.Label
    Friend WithEvents imgbanco As System.Windows.Forms.PictureBox
    Friend WithEvents btnCapIMG As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents imgCam As System.Windows.Forms.PictureBox
    Friend WithEvents CADP001 As Label



End Class
