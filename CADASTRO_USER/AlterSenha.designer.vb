﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlterSenha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlterSenha))
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.imgBarra = New System.Windows.Forms.ImageList(Me.components)
        Me.imgMenu = New System.Windows.Forms.ImageList(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnF5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSenha = New System.Windows.Forms.TextBox()
        Me.USU002 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.controle = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbnovasenha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbconfirma = New System.Windows.Forms.TextBox()
        Me.tbcp120 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.controle.SuspendLayout()
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
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.DimGray
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(5, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(115, 46)
        Me.btnClose.TabIndex = 302
        Me.btnClose.Text = "Voltar"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnF5)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.controle)
        Me.Panel3.Location = New System.Drawing.Point(413, 225)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(289, 283)
        Me.Panel3.TabIndex = 304
        '
        'btnF5
        '
        Me.btnF5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btnF5.Size = New System.Drawing.Size(132, 52)
        Me.btnF5.TabIndex = 310
        Me.btnF5.Text = "Gravar"
        Me.btnF5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnF5.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbSenha)
        Me.GroupBox1.Controls.Add(Me.USU002)
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
        'USU002
        '
        Me.USU002.BackColor = System.Drawing.Color.WhiteSmoke
        Me.USU002.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.USU002.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USU002.ForeColor = System.Drawing.Color.Black
        Me.USU002.Location = New System.Drawing.Point(15, 17)
        Me.USU002.Name = "USU002"
        Me.USU002.Size = New System.Drawing.Size(205, 20)
        Me.USU002.TabIndex = 0
        Me.USU002.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.controle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'tbcp120
        '
        Me.tbcp120.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcp120.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tbcp120.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcp120.ForeColor = System.Drawing.Color.Gray
        Me.tbcp120.Location = New System.Drawing.Point(413, 195)
        Me.tbcp120.Name = "tbcp120"
        Me.tbcp120.Size = New System.Drawing.Size(289, 25)
        Me.tbcp120.TabIndex = 305
        Me.tbcp120.Text = "Alteração da senha do usuário atual"
        Me.tbcp120.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AlterSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 714)
        Me.Controls.Add(Me.tbcp120)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnClose)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "AlterSenha"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.controle.ResumeLayout(False)
        Me.controle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Protected WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents imgBarra As System.Windows.Forms.ImageList
    Friend WithEvents imgMenu As System.Windows.Forms.ImageList
    Friend WithEvents ConfSenha As System.Windows.Forms.Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnF5 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbSenha As TextBox
    Friend WithEvents USU002 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents controle As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbnovasenha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbconfirma As TextBox
    Friend WithEvents tbcp120 As Label
End Class
