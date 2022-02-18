<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiltro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFiltro))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLivre = New System.Windows.Forms.Button()
        Me.brnOcupado = New System.Windows.Forms.Button()
        Me.btnBloqueado = New System.Windows.Forms.Button()
        Me.btnReservado = New System.Windows.Forms.Button()
        Me.BtnManutencao = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GAR003 = New System.Windows.Forms.ComboBox()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "livres.png")
        Me.ImageList1.Images.SetKeyName(1, "Lotado.png")
        Me.ImageList1.Images.SetKeyName(2, "Bloqueado01.png")
        Me.ImageList1.Images.SetKeyName(3, "BaseReservado01.png")
        Me.ImageList1.Images.SetKeyName(4, "ManutencaoBase.png")
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
        Me.Label1.Size = New System.Drawing.Size(325, 25)
        Me.Label1.TabIndex = 249
        Me.Label1.Text = "Filtro"
        '
        'btnLivre
        '
        Me.btnLivre.BackColor = System.Drawing.Color.Transparent
        Me.btnLivre.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnLivre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLivre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLivre.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLivre.ForeColor = System.Drawing.Color.DimGray
        Me.btnLivre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLivre.ImageKey = "livres.png"
        Me.btnLivre.ImageList = Me.ImageList1
        Me.btnLivre.Location = New System.Drawing.Point(9, 154)
        Me.btnLivre.Name = "btnLivre"
        Me.btnLivre.Size = New System.Drawing.Size(151, 70)
        Me.btnLivre.TabIndex = 306
        Me.btnLivre.Text = "Livre"
        Me.btnLivre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLivre.UseVisualStyleBackColor = False
        '
        'brnOcupado
        '
        Me.brnOcupado.BackColor = System.Drawing.Color.Transparent
        Me.brnOcupado.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.brnOcupado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.brnOcupado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brnOcupado.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brnOcupado.ForeColor = System.Drawing.Color.DimGray
        Me.brnOcupado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.brnOcupado.ImageKey = "Lotado.png"
        Me.brnOcupado.ImageList = Me.ImageList1
        Me.brnOcupado.Location = New System.Drawing.Point(166, 154)
        Me.brnOcupado.Name = "brnOcupado"
        Me.brnOcupado.Size = New System.Drawing.Size(151, 70)
        Me.brnOcupado.TabIndex = 307
        Me.brnOcupado.Text = "Ocupado"
        Me.brnOcupado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.brnOcupado.UseVisualStyleBackColor = False
        '
        'btnBloqueado
        '
        Me.btnBloqueado.BackColor = System.Drawing.Color.Transparent
        Me.btnBloqueado.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBloqueado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBloqueado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBloqueado.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBloqueado.ForeColor = System.Drawing.Color.DimGray
        Me.btnBloqueado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBloqueado.ImageKey = "Bloqueado01.png"
        Me.btnBloqueado.ImageList = Me.ImageList1
        Me.btnBloqueado.Location = New System.Drawing.Point(9, 230)
        Me.btnBloqueado.Name = "btnBloqueado"
        Me.btnBloqueado.Size = New System.Drawing.Size(151, 70)
        Me.btnBloqueado.TabIndex = 308
        Me.btnBloqueado.Text = "Bloqueado"
        Me.btnBloqueado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBloqueado.UseVisualStyleBackColor = False
        '
        'btnReservado
        '
        Me.btnReservado.BackColor = System.Drawing.Color.Transparent
        Me.btnReservado.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnReservado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReservado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservado.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservado.ForeColor = System.Drawing.Color.DimGray
        Me.btnReservado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservado.ImageKey = "BaseReservado01.png"
        Me.btnReservado.ImageList = Me.ImageList1
        Me.btnReservado.Location = New System.Drawing.Point(166, 230)
        Me.btnReservado.Name = "btnReservado"
        Me.btnReservado.Size = New System.Drawing.Size(151, 70)
        Me.btnReservado.TabIndex = 309
        Me.btnReservado.Text = "Reservado"
        Me.btnReservado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReservado.UseVisualStyleBackColor = False
        '
        'BtnManutencao
        '
        Me.BtnManutencao.BackColor = System.Drawing.Color.Transparent
        Me.BtnManutencao.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnManutencao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnManutencao.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManutencao.ForeColor = System.Drawing.Color.DimGray
        Me.BtnManutencao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnManutencao.ImageKey = "ManutencaoBase.png"
        Me.BtnManutencao.ImageList = Me.ImageList1
        Me.BtnManutencao.Location = New System.Drawing.Point(9, 306)
        Me.BtnManutencao.Name = "BtnManutencao"
        Me.BtnManutencao.Size = New System.Drawing.Size(308, 70)
        Me.BtnManutencao.TabIndex = 310
        Me.BtnManutencao.Text = "Manutenção"
        Me.BtnManutencao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnManutencao.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GAR003)
        Me.GroupBox6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 100)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(308, 44)
        Me.GroupBox6.TabIndex = 311
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Localização:"
        '
        'GAR003
        '
        Me.GAR003.BackColor = System.Drawing.Color.White
        Me.GAR003.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GAR003.FormattingEnabled = True
        Me.GAR003.Items.AddRange(New Object() {"Todos"})
        Me.GAR003.Location = New System.Drawing.Point(6, 16)
        Me.GAR003.Name = "GAR003"
        Me.GAR003.Size = New System.Drawing.Size(296, 22)
        Me.GAR003.TabIndex = 76
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
        Me.btnhome.Location = New System.Drawing.Point(3, 29)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(115, 36)
        Me.btnhome.TabIndex = 312
        Me.btnhome.Text = "Voltar"
        Me.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'frmFiltro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(325, 382)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.BtnManutencao)
        Me.Controls.Add(Me.btnReservado)
        Me.Controls.Add(Me.btnBloqueado)
        Me.Controls.Add(Me.brnOcupado)
        Me.Controls.Add(Me.btnLivre)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFiltro"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLivre As System.Windows.Forms.Button
    Friend WithEvents brnOcupado As System.Windows.Forms.Button
    Friend WithEvents btnBloqueado As System.Windows.Forms.Button
    Friend WithEvents btnReservado As System.Windows.Forms.Button
    Friend WithEvents BtnManutencao As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GAR003 As System.Windows.Forms.ComboBox
    Friend WithEvents btnhome As System.Windows.Forms.Button




End Class
