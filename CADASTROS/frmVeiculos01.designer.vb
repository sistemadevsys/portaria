<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVeiculos01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVeiculos01))
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.imgBarra = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VEI002 = New System.Windows.Forms.TextBox()
        Me.VEI004 = New System.Windows.Forms.TextBox()
        Me.VEI003 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lvFotos = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.imgbanco = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.registro = New System.Windows.Forms.Label()
        Me.porteiro = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imgbanco, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(695, 25)
        Me.Label1.TabIndex = 249
        Me.Label1.Text = " Detalhes do veículo registrado"
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
        Me.btnhome.Location = New System.Drawing.Point(591, 9)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(79, 36)
        Me.btnhome.TabIndex = 334
        Me.btnhome.Text = "Voltar"
        Me.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.VEI002)
        Me.GroupBox1.Controls.Add(Me.VEI004)
        Me.GroupBox1.Controls.Add(Me.btnhome)
        Me.GroupBox1.Controls.Add(Me.VEI003)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(676, 51)
        Me.GroupBox1.TabIndex = 335
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
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
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, -2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 14)
        Me.Label2.TabIndex = 344
        Me.Label2.Text = "Placas:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VEI002
        '
        Me.VEI002.BackColor = System.Drawing.Color.White
        Me.VEI002.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VEI002.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VEI002.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VEI002.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.VEI002.Location = New System.Drawing.Point(8, 15)
        Me.VEI002.MaxLength = 7
        Me.VEI002.Name = "VEI002"
        Me.VEI002.ReadOnly = True
        Me.VEI002.Size = New System.Drawing.Size(100, 26)
        Me.VEI002.TabIndex = 330
        Me.VEI002.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VEI004
        '
        Me.VEI004.BackColor = System.Drawing.Color.White
        Me.VEI004.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VEI004.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VEI004.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VEI004.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VEI004.Location = New System.Drawing.Point(275, 18)
        Me.VEI004.MaxLength = 30
        Me.VEI004.Name = "VEI004"
        Me.VEI004.ReadOnly = True
        Me.VEI004.Size = New System.Drawing.Size(170, 21)
        Me.VEI004.TabIndex = 338
        '
        'VEI003
        '
        Me.VEI003.BackColor = System.Drawing.Color.White
        Me.VEI003.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VEI003.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VEI003.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VEI003.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VEI003.Location = New System.Drawing.Point(109, 18)
        Me.VEI003.MaxLength = 40
        Me.VEI003.Name = "VEI003"
        Me.VEI003.ReadOnly = True
        Me.VEI003.Size = New System.Drawing.Size(165, 21)
        Me.VEI003.TabIndex = 334
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(294, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 14)
        Me.Label8.TabIndex = 347
        Me.Label8.Text = "Modelo:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvFotos
        '
        Me.lvFotos.AllowColumnReorder = True
        Me.lvFotos.BackColor = System.Drawing.Color.White
        Me.lvFotos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvFotos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvFotos.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvFotos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lvFotos.FullRowSelect = True
        Me.lvFotos.GridLines = True
        Me.lvFotos.HideSelection = False
        Me.lvFotos.Location = New System.Drawing.Point(7, 121)
        Me.lvFotos.MultiSelect = False
        Me.lvFotos.Name = "lvFotos"
        Me.lvFotos.Size = New System.Drawing.Size(201, 426)
        Me.lvFotos.TabIndex = 348
        Me.lvFotos.UseCompatibleStateImageBehavior = False
        Me.lvFotos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Registro"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Data"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 91
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Hora"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 91
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Arquivo"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Width = 0
        '
        'imgbanco
        '
        Me.imgbanco.BackColor = System.Drawing.Color.White
        Me.imgbanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgbanco.Location = New System.Drawing.Point(214, 89)
        Me.imgbanco.Name = "imgbanco"
        Me.imgbanco.Size = New System.Drawing.Size(470, 470)
        Me.imgbanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgbanco.TabIndex = 349
        Me.imgbanco.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(214, 558)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(470, 20)
        Me.Label3.TabIndex = 350
        Me.Label3.Text = "Referências:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'registro
        '
        Me.registro.Location = New System.Drawing.Point(284, 561)
        Me.registro.Name = "registro"
        Me.registro.Size = New System.Drawing.Size(180, 15)
        Me.registro.TabIndex = 351
        Me.registro.Text = "Label4"
        Me.registro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'porteiro
        '
        Me.porteiro.Location = New System.Drawing.Point(500, 561)
        Me.porteiro.Name = "porteiro"
        Me.porteiro.Size = New System.Drawing.Size(180, 15)
        Me.porteiro.TabIndex = 352
        Me.porteiro.Text = "Label4"
        Me.porteiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(9, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 15)
        Me.Label4.TabIndex = 353
        Me.Label4.Text = "Relação de registros:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gray
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(7, 121)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 25)
        Me.Button4.TabIndex = 354
        Me.Button4.Text = "DATA"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(99, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 25)
        Me.Button1.TabIndex = 355
        Me.Button1.Text = "HORÁRIO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmVeiculos01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(695, 589)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.porteiro)
        Me.Controls.Add(Me.registro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.imgbanco)
        Me.Controls.Add(Me.lvFotos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVeiculos01"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.imgbanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Protected WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents imgBarra As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnhome As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents VEI002 As System.Windows.Forms.TextBox
    Friend WithEvents VEI004 As System.Windows.Forms.TextBox
    Friend WithEvents VEI003 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lvFotos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents imgbanco As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents registro As System.Windows.Forms.Label
    Friend WithEvents porteiro As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button




End Class
