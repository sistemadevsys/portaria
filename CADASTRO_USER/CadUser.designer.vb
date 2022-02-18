<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadUser))
        Me.tbcp120 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExcluirRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnF8 = New System.Windows.Forms.Button()
        Me.btnF6 = New System.Windows.Forms.Button()
        Me.btnF3 = New System.Windows.Forms.Button()
        Me.btnF5 = New System.Windows.Forms.Button()
        Me.btnF4 = New System.Windows.Forms.Button()
        Me.btnF2 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.USU007 = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.USU005 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.USU002 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.USU003 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.USU001 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lvdados = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnhome = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcp120
        '
        Me.tbcp120.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tbcp120.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcp120.ForeColor = System.Drawing.Color.Gray
        Me.tbcp120.Location = New System.Drawing.Point(308, 134)
        Me.tbcp120.Name = "tbcp120"
        Me.tbcp120.Size = New System.Drawing.Size(534, 25)
        Me.tbcp120.TabIndex = 215
        Me.tbcp120.Text = "Cadastro e manutenção de usuários"
        Me.tbcp120.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "btnEditar.png")
        Me.ImageList1.Images.SetKeyName(1, "btnExcluir.png")
        Me.ImageList1.Images.SetKeyName(2, "btnNovo.png")
        Me.ImageList1.Images.SetKeyName(3, "btnSair.png")
        Me.ImageList1.Images.SetKeyName(4, "btnSalvar.png")
        Me.ImageList1.Images.SetKeyName(5, "btnVoltar.png")
        '
        'ToolTip2
        '
        Me.ToolTip2.AutoPopDelay = 4000
        Me.ToolTip2.BackColor = System.Drawing.Color.AliceBlue
        Me.ToolTip2.ForeColor = System.Drawing.Color.Black
        Me.ToolTip2.InitialDelay = 1
        Me.ToolTip2.IsBalloon = True
        Me.ToolTip2.ReshowDelay = 5
        Me.ToolTip2.ShowAlways = True
        Me.ToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcluirRegistroToolStripMenuItem, Me.ToolStripSeparator1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(163, 40)
        '
        'ExcluirRegistroToolStripMenuItem
        '
        Me.ExcluirRegistroToolStripMenuItem.Image = CType(resources.GetObject("ExcluirRegistroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExcluirRegistroToolStripMenuItem.Name = "ExcluirRegistroToolStripMenuItem"
        Me.ExcluirRegistroToolStripMenuItem.Size = New System.Drawing.Size(162, 30)
        Me.ExcluirRegistroToolStripMenuItem.Text = "Excluir Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Controls.Add(Me.GroupBox6)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Location = New System.Drawing.Point(308, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(534, 401)
        Me.Panel2.TabIndex = 219
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btnF8)
        Me.Panel4.Controls.Add(Me.btnF6)
        Me.Panel4.Controls.Add(Me.btnF3)
        Me.Panel4.Controls.Add(Me.btnF5)
        Me.Panel4.Controls.Add(Me.btnF4)
        Me.Panel4.Controls.Add(Me.btnF2)
        Me.Panel4.Location = New System.Drawing.Point(442, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(83, 374)
        Me.Panel4.TabIndex = 211
        '
        'btnF8
        '
        Me.btnF8.BackColor = System.Drawing.Color.Transparent
        Me.btnF8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnF8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnF8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnF8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnF8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnF8.Image = CType(resources.GetObject("btnF8.Image"), System.Drawing.Image)
        Me.btnF8.Location = New System.Drawing.Point(8, 287)
        Me.btnF8.Name = "btnF8"
        Me.btnF8.Size = New System.Drawing.Size(65, 52)
        Me.btnF8.TabIndex = 312
        Me.btnF8.Text = "Perfil"
        Me.btnF8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnF8.UseVisualStyleBackColor = False
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
        Me.btnF6.Location = New System.Drawing.Point(8, 230)
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
        Me.btnF3.Location = New System.Drawing.Point(8, 60)
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
        Me.btnF5.Location = New System.Drawing.Point(8, 173)
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
        Me.btnF4.Location = New System.Drawing.Point(8, 116)
        Me.btnF4.Name = "btnF4"
        Me.btnF4.Size = New System.Drawing.Size(65, 52)
        Me.btnF4.TabIndex = 311
        Me.btnF4.Text = "Cancela"
        Me.btnF4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnF4.UseVisualStyleBackColor = False
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
        Me.btnF2.Location = New System.Drawing.Point(8, 5)
        Me.btnF2.Name = "btnF2"
        Me.btnF2.Size = New System.Drawing.Size(65, 52)
        Me.btnF2.TabIndex = 307
        Me.btnF2.Text = "Incluir"
        Me.btnF2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnF2.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.USU007)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox5.Location = New System.Drawing.Point(7, 341)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(430, 46)
        Me.GroupBox5.TabIndex = 217
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Email do usuário:"
        '
        'USU007
        '
        Me.USU007.BackColor = System.Drawing.Color.White
        Me.USU007.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.USU007.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USU007.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.USU007.Location = New System.Drawing.Point(12, 18)
        Me.USU007.MaxLength = 30
        Me.USU007.Name = "USU007"
        Me.USU007.Size = New System.Drawing.Size(409, 21)
        Me.USU007.TabIndex = 133
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.USU005)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox6.Location = New System.Drawing.Point(7, 289)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(233, 46)
        Me.GroupBox6.TabIndex = 218
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Cargo ocupado:"
        '
        'USU005
        '
        Me.USU005.BackColor = System.Drawing.Color.White
        Me.USU005.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.USU005.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USU005.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.USU005.Location = New System.Drawing.Point(12, 18)
        Me.USU005.MaxLength = 40
        Me.USU005.Name = "USU005"
        Me.USU005.Size = New System.Drawing.Size(213, 21)
        Me.USU005.TabIndex = 133
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.USU002)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox4.Location = New System.Drawing.Point(246, 289)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(191, 46)
        Me.GroupBox4.TabIndex = 219
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Login de acesso:"
        '
        'USU002
        '
        Me.USU002.BackColor = System.Drawing.Color.White
        Me.USU002.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.USU002.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USU002.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.USU002.Location = New System.Drawing.Point(12, 18)
        Me.USU002.MaxLength = 30
        Me.USU002.Name = "USU002"
        Me.USU002.Size = New System.Drawing.Size(170, 21)
        Me.USU002.TabIndex = 133
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.USU003)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox3.Location = New System.Drawing.Point(80, 237)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(357, 46)
        Me.GroupBox3.TabIndex = 216
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Nome do usuário:"
        '
        'USU003
        '
        Me.USU003.BackColor = System.Drawing.Color.White
        Me.USU003.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.USU003.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USU003.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.USU003.Location = New System.Drawing.Point(12, 18)
        Me.USU003.MaxLength = 30
        Me.USU003.Name = "USU003"
        Me.USU003.Size = New System.Drawing.Size(335, 21)
        Me.USU003.TabIndex = 133
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.USU001)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox1.Location = New System.Drawing.Point(7, 237)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(72, 46)
        Me.GroupBox1.TabIndex = 215
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Código"
        '
        'USU001
        '
        Me.USU001.BackColor = System.Drawing.Color.White
        Me.USU001.Enabled = False
        Me.USU001.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USU001.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.USU001.Location = New System.Drawing.Point(12, 18)
        Me.USU001.MaxLength = 4
        Me.USU001.Name = "USU001"
        Me.USU001.ReadOnly = True
        Me.USU001.Size = New System.Drawing.Size(46, 21)
        Me.USU001.TabIndex = 133
        Me.USU001.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.lvdados)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 208)
        Me.GroupBox2.TabIndex = 212
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(10, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(397, 24)
        Me.Button1.TabIndex = 220
        Me.Button1.Text = "Relação de Usuários"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lvdados
        '
        Me.lvdados.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvdados.AllowColumnReorder = True
        Me.lvdados.BackColor = System.Drawing.Color.White
        Me.lvdados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvdados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvdados.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lvdados.ForeColor = System.Drawing.Color.Black
        Me.lvdados.FullRowSelect = True
        Me.lvdados.GridLines = True
        Me.lvdados.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvdados.HideSelection = False
        Me.lvdados.Location = New System.Drawing.Point(9, 12)
        Me.lvdados.MultiSelect = False
        Me.lvdados.Name = "lvdados"
        Me.lvdados.Size = New System.Drawing.Size(412, 188)
        Me.lvdados.TabIndex = 206
        Me.lvdados.UseCompatibleStateImageBehavior = False
        Me.lvdados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Código"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Descrição"
        Me.ColumnHeader3.Width = 396
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Width = 0
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
        Me.btnhome.Location = New System.Drawing.Point(5, 6)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(115, 46)
        Me.btnhome.TabIndex = 301
        Me.btnhome.Text = "Voltar"
        Me.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'CadUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 714)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.tbcp120)
        Me.ForeColor = System.Drawing.Color.DarkGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "CadUser"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbcp120 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExcluirRegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents USU007 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents USU005 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents USU002 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents USU003 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents USU001 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lvdados As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnhome As System.Windows.Forms.Button
    Friend WithEvents btnF8 As Button
    Friend WithEvents btnF6 As Button
    Friend WithEvents btnF3 As Button
    Friend WithEvents btnF5 As Button
    Friend WithEvents btnF4 As Button
    Friend WithEvents btnF2 As Button



End Class
