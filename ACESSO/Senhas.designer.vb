<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Senhas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Senhas))
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.imgBarra = New System.Windows.Forms.ImageList(Me.components)
        Me.imgMenu = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnF5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSenha = New System.Windows.Forms.TextBox()
        Me.tbUSU002 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.controle = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbnovasenha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbconfirma = New System.Windows.Forms.TextBox()
        Me.USU001 = New System.Windows.Forms.Label()
        Me.ConfSenha = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.controle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'imgMenu
        '
        Me.imgMenu.ImageStream = CType(resources.GetObject("imgMenu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgMenu.TransparentColor = System.Drawing.Color.Transparent
        Me.imgMenu.Images.SetKeyName(0, "Cancela.png")
        Me.imgMenu.Images.SetKeyName(1, "Editar.png")
        Me.imgMenu.Images.SetKeyName(2, "excluir.png")
        Me.imgMenu.Images.SetKeyName(3, "gravar.png")
        Me.imgMenu.Images.SetKeyName(4, "novo_Registro.png")
        Me.imgMenu.Images.SetKeyName(5, "editar01.png")
        Me.imgMenu.Images.SetKeyName(6, "sair.png")
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.btnF5)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.controle)
        Me.Panel3.Location = New System.Drawing.Point(245, 140)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(289, 283)
        Me.Panel3.TabIndex = 247
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(193, 199)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(65, 52)
        Me.btnClose.TabIndex = 311
        Me.btnClose.Text = "Cancela"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnF5
        '
        Me.btnF5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnF5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnF5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnF5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnF5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnF5.Image = CType(resources.GetObject("btnF5.Image"), System.Drawing.Image)
        Me.btnF5.Location = New System.Drawing.Point(126, 199)
        Me.btnF5.Name = "btnF5"
        Me.btnF5.Size = New System.Drawing.Size(65, 52)
        Me.btnF5.TabIndex = 310
        Me.btnF5.Text = "Gravar"
        Me.btnF5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnF5.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbSenha)
        Me.GroupBox1.Controls.Add(Me.tbUSU002)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox1.Location = New System.Drawing.Point(30, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 75)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuário"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Senha Anterior:"
        '
        'tbSenha
        '
        Me.tbSenha.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbSenha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSenha.ForeColor = System.Drawing.Color.Black
        Me.tbSenha.Location = New System.Drawing.Point(108, 41)
        Me.tbSenha.MaxLength = 12
        Me.tbSenha.Name = "tbSenha"
        Me.tbSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.tbSenha.Size = New System.Drawing.Size(112, 20)
        Me.tbSenha.TabIndex = 1
        '
        'tbUSU002
        '
        Me.tbUSU002.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbUSU002.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbUSU002.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUSU002.ForeColor = System.Drawing.Color.Black
        Me.tbUSU002.Location = New System.Drawing.Point(15, 17)
        Me.tbUSU002.Name = "tbUSU002"
        Me.tbUSU002.Size = New System.Drawing.Size(205, 20)
        Me.tbUSU002.TabIndex = 0
        Me.tbUSU002.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(3, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 12)
        Me.Label9.TabIndex = 216
        Me.Label9.Text = "[ESC] - Fecha formulário"
        '
        'controle
        '
        Me.controle.BackColor = System.Drawing.Color.Transparent
        Me.controle.Controls.Add(Me.Label3)
        Me.controle.Controls.Add(Me.tbnovasenha)
        Me.controle.Controls.Add(Me.Label4)
        Me.controle.Controls.Add(Me.tbconfirma)
        Me.controle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.controle.ForeColor = System.Drawing.Color.Gray
        Me.controle.Location = New System.Drawing.Point(30, 116)
        Me.controle.Name = "controle"
        Me.controle.Size = New System.Drawing.Size(228, 77)
        Me.controle.TabIndex = 3
        Me.controle.TabStop = False
        Me.controle.Text = "Alteração de Senha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nova Senha:"
        '
        'tbnovasenha
        '
        Me.tbnovasenha.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbnovasenha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnovasenha.ForeColor = System.Drawing.Color.Black
        Me.tbnovasenha.Location = New System.Drawing.Point(108, 19)
        Me.tbnovasenha.MaxLength = 12
        Me.tbnovasenha.Name = "tbnovasenha"
        Me.tbnovasenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.tbnovasenha.Size = New System.Drawing.Size(112, 20)
        Me.tbnovasenha.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Confirmação:"
        '
        'tbconfirma
        '
        Me.tbconfirma.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbconfirma.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbconfirma.ForeColor = System.Drawing.Color.Black
        Me.tbconfirma.Location = New System.Drawing.Point(108, 49)
        Me.tbconfirma.MaxLength = 12
        Me.tbconfirma.Name = "tbconfirma"
        Me.tbconfirma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.tbconfirma.Size = New System.Drawing.Size(112, 20)
        Me.tbconfirma.TabIndex = 1
        '
        'USU001
        '
        Me.USU001.AutoSize = True
        Me.USU001.ForeColor = System.Drawing.Color.White
        Me.USU001.Location = New System.Drawing.Point(102, 554)
        Me.USU001.Name = "USU001"
        Me.USU001.Size = New System.Drawing.Size(39, 13)
        Me.USU001.TabIndex = 249
        Me.USU001.Text = "Label5"
        '
        'ConfSenha
        '
        Me.ConfSenha.AutoSize = True
        Me.ConfSenha.ForeColor = System.Drawing.Color.White
        Me.ConfSenha.Location = New System.Drawing.Point(102, 583)
        Me.ConfSenha.Name = "ConfSenha"
        Me.ConfSenha.Size = New System.Drawing.Size(60, 13)
        Me.ConfSenha.TabIndex = 248
        Me.ConfSenha.Text = "ConfSenha"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(678, 698)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 258
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(780, 43)
        Me.Label2.TabIndex = 260
        Me.Label2.Text = "Alteração de Senha"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Senhas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(780, 472)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.USU001)
        Me.Controls.Add(Me.ConfSenha)
        Me.Controls.Add(Me.Panel3)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Senhas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.controle.ResumeLayout(False)
        Me.controle.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Protected WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents imgBarra As System.Windows.Forms.ImageList
    Friend WithEvents imgMenu As System.Windows.Forms.ImageList
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbSenha As System.Windows.Forms.TextBox
    Friend WithEvents tbUSU002 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents controle As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbnovasenha As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbconfirma As System.Windows.Forms.TextBox
    Friend WithEvents USU001 As System.Windows.Forms.Label
    Friend WithEvents ConfSenha As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnF5 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label




End Class
