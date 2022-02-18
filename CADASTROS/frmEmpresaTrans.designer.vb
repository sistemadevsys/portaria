<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresaTrans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpresaTrans))
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.imgBarra = New System.Windows.Forms.ImageList(Me.components)
        Me.tarja = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EMP002 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EMP003 = New System.Windows.Forms.TextBox()
        Me.R1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.R3 = New System.Windows.Forms.RadioButton()
        Me.R2 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lvDados = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.tbPesquisa = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        'tarja
        '
        Me.tarja.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tarja.Dock = System.Windows.Forms.DockStyle.Top
        Me.tarja.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tarja.ForeColor = System.Drawing.Color.White
        Me.tarja.Location = New System.Drawing.Point(0, 0)
        Me.tarja.Name = "tarja"
        Me.tarja.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.tarja.Size = New System.Drawing.Size(528, 25)
        Me.tarja.TabIndex = 249
        Me.tarja.Text = "Transferência de Cadastro entre empresas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.EMP002)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.EMP003)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(521, 45)
        Me.GroupBox2.TabIndex = 213
        Me.GroupBox2.TabStop = False
        '
        'EMP002
        '
        Me.EMP002.BackColor = System.Drawing.Color.White
        Me.EMP002.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EMP002.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMP002.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.EMP002.Location = New System.Drawing.Point(9, 15)
        Me.EMP002.MaxLength = 6
        Me.EMP002.Name = "EMP002"
        Me.EMP002.Size = New System.Drawing.Size(76, 22)
        Me.EMP002.TabIndex = 32
        Me.EMP002.Text = "000000"
        Me.EMP002.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, -3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 14)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Dados da Empresa Anterior:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EMP003
        '
        Me.EMP003.BackColor = System.Drawing.Color.White
        Me.EMP003.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EMP003.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMP003.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.EMP003.Location = New System.Drawing.Point(87, 15)
        Me.EMP003.MaxLength = 50
        Me.EMP003.Name = "EMP003"
        Me.EMP003.Size = New System.Drawing.Size(428, 22)
        Me.EMP003.TabIndex = 21
        '
        'R1
        '
        Me.R1.AutoSize = True
        Me.R1.BackColor = System.Drawing.Color.Transparent
        Me.R1.Checked = True
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Location = New System.Drawing.Point(9, 19)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(148, 17)
        Me.R1.TabIndex = 0
        Me.R1.TabStop = True
        Me.R1.Text = "Empresas e Fornecedores"
        Me.R1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.R3)
        Me.GroupBox1.Controls.Add(Me.R2)
        Me.GroupBox1.Controls.Add(Me.R1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 49)
        Me.GroupBox1.TabIndex = 312
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Destino do cadastro:"
        '
        'R3
        '
        Me.R3.AutoSize = True
        Me.R3.BackColor = System.Drawing.Color.Transparent
        Me.R3.ForeColor = System.Drawing.Color.Black
        Me.R3.Location = New System.Drawing.Point(287, 19)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(135, 17)
        Me.R3.TabIndex = 2
        Me.R3.Text = "Prestadores de Serviço"
        Me.R3.UseVisualStyleBackColor = False
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.BackColor = System.Drawing.Color.Transparent
        Me.R2.ForeColor = System.Drawing.Color.Black
        Me.R2.Location = New System.Drawing.Point(170, 19)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(104, 17)
        Me.R2.TabIndex = 1
        Me.R2.Text = "Empreendimento"
        Me.R2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(412, 537)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 36)
        Me.Button1.TabIndex = 314
        Me.Button1.Text = "Gravar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.btnhome.Location = New System.Drawing.Point(291, 537)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(115, 36)
        Me.btnhome.TabIndex = 313
        Me.btnhome.Text = " Voltar"
        Me.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(7, 134)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 25)
        Me.Button2.TabIndex = 255
        Me.Button2.Text = "Registro"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lvDados
        '
        Me.lvDados.AllowColumnReorder = True
        Me.lvDados.BackColor = System.Drawing.Color.White
        Me.lvDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvDados.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lvDados.FullRowSelect = True
        Me.lvDados.GridLines = True
        Me.lvDados.HideSelection = False
        Me.lvDados.Location = New System.Drawing.Point(7, 134)
        Me.lvDados.MultiSelect = False
        Me.lvDados.Name = "lvDados"
        Me.lvDados.Size = New System.Drawing.Size(521, 332)
        Me.lvDados.TabIndex = 117
        Me.lvDados.UseCompatibleStateImageBehavior = False
        Me.lvDados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "REGISTRO"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "EMPRESAS E FORNECEDORES"
        Me.ColumnHeader2.Width = 421
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Width = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(88, 134)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(422, 25)
        Me.Button3.TabIndex = 333
        Me.Button3.Text = "Cadastro Disponivel"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Location = New System.Drawing.Point(-1, 531)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 1)
        Me.Panel1.TabIndex = 334
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnVoltar)
        Me.Panel2.Controls.Add(Me.tbPesquisa)
        Me.Panel2.Location = New System.Drawing.Point(1, 470)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(532, 59)
        Me.Panel2.TabIndex = 335
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.TabIndex = 335
        Me.Label3.Text = "Pesquisa:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.Transparent
        Me.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnVoltar.FlatAppearance.BorderSize = 0
        Me.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnVoltar.Image = CType(resources.GetObject("btnVoltar.Image"), System.Drawing.Image)
        Me.btnVoltar.Location = New System.Drawing.Point(433, 11)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(93, 42)
        Me.btnVoltar.TabIndex = 334
        Me.btnVoltar.Text = "Todos"
        Me.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'tbPesquisa
        '
        Me.tbPesquisa.BackColor = System.Drawing.Color.Snow
        Me.tbPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPesquisa.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPesquisa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbPesquisa.Location = New System.Drawing.Point(5, 22)
        Me.tbPesquisa.MaxLength = 50
        Me.tbPesquisa.Name = "tbPesquisa"
        Me.tbPesquisa.Size = New System.Drawing.Size(422, 22)
        Me.tbPesquisa.TabIndex = 333
        '
        'frmEmpresaTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(528, 578)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lvDados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tarja)
        Me.ForeColor = System.Drawing.Color.DarkGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmpresaTrans"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Protected WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents imgBarra As System.Windows.Forms.ImageList
    Friend WithEvents tarja As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents EMP002 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents EMP003 As TextBox
    Friend WithEvents R1 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents R3 As RadioButton
    Friend WithEvents R2 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents btnhome As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lvDados As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnVoltar As Button
    Friend WithEvents tbPesquisa As TextBox
    Friend WithEvents ColumnHeader3 As ColumnHeader
End Class
