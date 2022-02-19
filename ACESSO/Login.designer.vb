<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Imagens = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAsenha = New System.Windows.Forms.Button()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnexec = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.imgBarra = New System.Windows.Forms.ImageList(Me.components)
        Me.cabecalho = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnMini = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNormal = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelSenha = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lvdados = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbReg001 = New System.Windows.Forms.Label()
        Me.tbSenha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.imgNet = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.frmBase = New System.Windows.Forms.Panel()
        Me.Exibe_con = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OPC = New System.Windows.Forms.Label()
        Me.cabecalho.SuspendLayout()
        Me.PanelSenha.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgNet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmBase.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Imagens
        '
        Me.Imagens.ImageStream = CType(resources.GetObject("Imagens.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Imagens.TransparentColor = System.Drawing.Color.Transparent
        Me.Imagens.Images.SetKeyName(0, "conexao ativa.png")
        Me.Imagens.Images.SetKeyName(1, "conexao inativa.png")
        Me.Imagens.Images.SetKeyName(2, "conexao verificando.png")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.BackColor = System.Drawing.Color.White
        Me.ToolTip1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'btnAsenha
        '
        Me.btnAsenha.BackColor = System.Drawing.Color.Transparent
        Me.btnAsenha.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAsenha.FlatAppearance.BorderSize = 0
        Me.btnAsenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAsenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAsenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsenha.ForeColor = System.Drawing.Color.White
        Me.btnAsenha.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAsenha.ImageIndex = 0
        Me.btnAsenha.ImageList = Me.ImageList2
        Me.btnAsenha.Location = New System.Drawing.Point(17, 4)
        Me.btnAsenha.Name = "btnAsenha"
        Me.btnAsenha.Size = New System.Drawing.Size(46, 50)
        Me.btnAsenha.TabIndex = 264
        Me.btnAsenha.Tag = ""
        Me.btnAsenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btnAsenha, "Acesso para alteração da senha do usuário")
        Me.btnAsenha.UseVisualStyleBackColor = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "cadeado.png")
        Me.ImageList2.Images.SetKeyName(1, "cadeado.png")
        '
        'btnexec
        '
        Me.btnexec.BackColor = System.Drawing.Color.Transparent
        Me.btnexec.BackgroundImage = CType(resources.GetObject("btnexec.BackgroundImage"), System.Drawing.Image)
        Me.btnexec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnexec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexec.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.btnexec.FlatAppearance.BorderSize = 0
        Me.btnexec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnexec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnexec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexec.ForeColor = System.Drawing.Color.DimGray
        Me.btnexec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnexec.ImageKey = "raio_executar.png"
        Me.btnexec.Location = New System.Drawing.Point(61, 222)
        Me.btnexec.Name = "btnexec"
        Me.btnexec.Size = New System.Drawing.Size(238, 44)
        Me.btnexec.TabIndex = 236
        Me.btnexec.Tag = ""
        Me.btnexec.Text = "ACESSAR"
        Me.ToolTip1.SetToolTip(Me.btnexec, "Validar Usuário e Senha")
        Me.btnexec.UseVisualStyleBackColor = False
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
        'cabecalho
        '
        Me.cabecalho.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.cabecalho.Controls.Add(Me.Label4)
        Me.cabecalho.Controls.Add(Me.btnMini)
        Me.cabecalho.Controls.Add(Me.btnMax)
        Me.cabecalho.Controls.Add(Me.btnClose)
        Me.cabecalho.Controls.Add(Me.btnNormal)
        Me.cabecalho.Dock = System.Windows.Forms.DockStyle.Top
        Me.cabecalho.Location = New System.Drawing.Point(0, 0)
        Me.cabecalho.Name = "cabecalho"
        Me.cabecalho.Size = New System.Drawing.Size(1258, 35)
        Me.cabecalho.TabIndex = 250
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(6, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(427, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Versão:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnMini
        '
        Me.btnMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMini.FlatAppearance.BorderSize = 0
        Me.btnMini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMini.ImageKey = "emblemremove_93481.png"
        Me.btnMini.ImageList = Me.imgBarra
        Me.btnMini.Location = New System.Drawing.Point(1152, 2)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.Size = New System.Drawing.Size(30, 30)
        Me.btnMini.TabIndex = 5
        Me.btnMini.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.Enabled = False
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.ImageKey = "max.png"
        Me.btnMax.ImageList = Me.imgBarra
        Me.btnMax.Location = New System.Drawing.Point(1188, 2)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(30, 30)
        Me.btnMax.TabIndex = 4
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ImageKey = "1486395882-close_80604.png"
        Me.btnClose.ImageList = Me.imgBarra
        Me.btnClose.Location = New System.Drawing.Point(1224, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 3
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnNormal
        '
        Me.btnNormal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNormal.FlatAppearance.BorderSize = 0
        Me.btnNormal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNormal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNormal.ImageKey = "1486395883-edit_80608.png"
        Me.btnNormal.ImageList = Me.imgBarra
        Me.btnNormal.Location = New System.Drawing.Point(1188, 2)
        Me.btnNormal.Name = "btnNormal"
        Me.btnNormal.Size = New System.Drawing.Size(30, 30)
        Me.btnNormal.TabIndex = 6
        Me.btnNormal.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(544, 662)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 12)
        Me.Label9.TabIndex = 263
        Me.Label9.Text = "[ESC] - Encerra o Sistema"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelSenha
        '
        Me.PanelSenha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSenha.BackColor = System.Drawing.Color.Transparent
        Me.PanelSenha.BackgroundImage = CType(resources.GetObject("PanelSenha.BackgroundImage"), System.Drawing.Image)
        Me.PanelSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelSenha.Controls.Add(Me.btnAsenha)
        Me.PanelSenha.Controls.Add(Me.Panel1)
        Me.PanelSenha.Controls.Add(Me.Label6)
        Me.PanelSenha.Controls.Add(Me.btnexec)
        Me.PanelSenha.Controls.Add(Me.tbReg001)
        Me.PanelSenha.Controls.Add(Me.tbSenha)
        Me.PanelSenha.Controls.Add(Me.Label3)
        Me.PanelSenha.Controls.Add(Me.Label1)
        Me.PanelSenha.Location = New System.Drawing.Point(220, 66)
        Me.PanelSenha.Name = "PanelSenha"
        Me.PanelSenha.Size = New System.Drawing.Size(360, 360)
        Me.PanelSenha.TabIndex = 262
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lvdados)
        Me.Panel1.Location = New System.Drawing.Point(61, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 23)
        Me.Panel1.TabIndex = 249
        '
        'lvdados
        '
        Me.lvdados.BackColor = System.Drawing.Color.White
        Me.lvdados.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lvdados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvdados.ForeColor = System.Drawing.Color.DarkBlue
        Me.lvdados.FormattingEnabled = True
        Me.lvdados.Location = New System.Drawing.Point(-1, -1)
        Me.lvdados.Name = "lvdados"
        Me.lvdados.Size = New System.Drawing.Size(238, 24)
        Me.lvdados.TabIndex = 248
        Me.lvdados.Tag = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(95, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Label6.Size = New System.Drawing.Size(173, 38)
        Me.Label6.TabIndex = 248
        Me.Label6.Text = "Acesso"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbReg001
        '
        Me.tbReg001.BackColor = System.Drawing.Color.Transparent
        Me.tbReg001.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbReg001.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.tbReg001.Location = New System.Drawing.Point(143, 236)
        Me.tbReg001.Name = "tbReg001"
        Me.tbReg001.Size = New System.Drawing.Size(74, 23)
        Me.tbReg001.TabIndex = 201
        Me.tbReg001.Text = "000000"
        Me.tbReg001.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbSenha
        '
        Me.tbSenha.BackColor = System.Drawing.Color.White
        Me.tbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSenha.ForeColor = System.Drawing.Color.DimGray
        Me.tbSenha.Location = New System.Drawing.Point(61, 177)
        Me.tbSenha.MaxLength = 100
        Me.tbSenha.Name = "tbSenha"
        Me.tbSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9824)
        Me.tbSenha.Size = New System.Drawing.Size(238, 24)
        Me.tbSenha.TabIndex = 0
        Me.tbSenha.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(64, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 245
        Me.Label3.Text = "Usuário:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(64, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 244
        Me.Label1.Text = "Senha:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(0, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1254, 43)
        Me.Label2.TabIndex = 261
        Me.Label2.Text = "Gestor de Portaria"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1151, 678)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(107, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 260
        Me.PictureBox2.TabStop = False
        '
        'imgNet
        '
        Me.imgNet.Image = CType(resources.GetObject("imgNet.Image"), System.Drawing.Image)
        Me.imgNet.Location = New System.Drawing.Point(0, 719)
        Me.imgNet.Name = "imgNet"
        Me.imgNet.Size = New System.Drawing.Size(44, 44)
        Me.imgNet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgNet.TabIndex = 263
        Me.imgNet.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(48, 734)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 15)
        Me.Label5.TabIndex = 262
        '
        'frmBase
        '
        Me.frmBase.Controls.Add(Me.PanelSenha)
        Me.frmBase.Location = New System.Drawing.Point(230, 136)
        Me.frmBase.Name = "frmBase"
        Me.frmBase.Size = New System.Drawing.Size(800, 492)
        Me.frmBase.TabIndex = 264
        '
        'Exibe_con
        '
        Me.Exibe_con.AutoSize = True
        Me.Exibe_con.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Exibe_con.ForeColor = System.Drawing.Color.Gray
        Me.Exibe_con.Location = New System.Drawing.Point(48, 735)
        Me.Exibe_con.Name = "Exibe_con"
        Me.Exibe_con.Size = New System.Drawing.Size(0, 13)
        Me.Exibe_con.TabIndex = 265
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.OPC)
        Me.Panel2.Location = New System.Drawing.Point(112, 773)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(130, 100)
        Me.Panel2.TabIndex = 266
        '
        'OPC
        '
        Me.OPC.AutoSize = True
        Me.OPC.Location = New System.Drawing.Point(16, 23)
        Me.OPC.Name = "OPC"
        Me.OPC.Size = New System.Drawing.Size(25, 13)
        Me.OPC.TabIndex = 0
        Me.OPC.Text = "opc"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1258, 763)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Exibe_con)
        Me.Controls.Add(Me.frmBase)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.imgNet)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.cabecalho)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.cabecalho.ResumeLayout(False)
        Me.PanelSenha.ResumeLayout(False)
        Me.PanelSenha.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgNet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmBase.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Imagens As ImageList
    Friend WithEvents ToolTip1 As ToolTip
    Protected WithEvents Timer1 As Timer
    Friend WithEvents imgBarra As ImageList
    Friend WithEvents cabecalho As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnMini As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNormal As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelSenha As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lvdados As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnexec As Button
    Friend WithEvents tbReg001 As Label
    Friend WithEvents tbSenha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents imgNet As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAsenha As System.Windows.Forms.Button
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents frmBase As Panel
    Friend WithEvents Exibe_con As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents OPC As Label
End Class
