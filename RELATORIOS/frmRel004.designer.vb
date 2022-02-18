<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRel004
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRel004))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.Gb1 = New System.Windows.Forms.GroupBox()
        Me.opc4 = New System.Windows.Forms.RadioButton()
        Me.opc3 = New System.Windows.Forms.RadioButton()
        Me.opc2 = New System.Windows.Forms.RadioButton()
        Me.opc1 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.gb2 = New System.Windows.Forms.GroupBox()
        Me.opc8 = New System.Windows.Forms.RadioButton()
        Me.opc7 = New System.Windows.Forms.RadioButton()
        Me.opc6 = New System.Windows.Forms.RadioButton()
        Me.opc5 = New System.Windows.Forms.RadioButton()
        Me.gb3 = New System.Windows.Forms.GroupBox()
        Me.CADP003 = New System.Windows.Forms.Label()
        Me.CADP002 = New System.Windows.Forms.Label()
        Me.Relatorio = New System.Drawing.Printing.PrintDocument()
        Me.visualizar = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button36 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.img = New System.Windows.Forms.PictureBox()
        Me.dtsaida = New System.Windows.Forms.Label()
        Me.dtentrada = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.barra = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.Gb1.SuspendLayout()
        Me.gb2.SuspendLayout()
        Me.gb3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rb3)
        Me.GroupBox2.Controls.Add(Me.Gb1)
        Me.GroupBox2.Controls.Add(Me.rb2)
        Me.GroupBox2.Controls.Add(Me.rb1)
        Me.GroupBox2.Controls.Add(Me.gb2)
        Me.GroupBox2.Controls.Add(Me.gb3)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(550, 126)
        Me.GroupBox2.TabIndex = 131
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opções de relatório:"
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rb3.ForeColor = System.Drawing.Color.Black
        Me.rb3.Location = New System.Drawing.Point(10, 77)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(155, 18)
        Me.rb3.TabIndex = 8
        Me.rb3.TabStop = True
        Me.rb3.Text = "Atualização de cadastro"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'Gb1
        '
        Me.Gb1.Controls.Add(Me.opc4)
        Me.Gb1.Controls.Add(Me.opc3)
        Me.Gb1.Controls.Add(Me.opc2)
        Me.Gb1.Controls.Add(Me.opc1)
        Me.Gb1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb1.ForeColor = System.Drawing.Color.Black
        Me.Gb1.Location = New System.Drawing.Point(194, 9)
        Me.Gb1.Name = "Gb1"
        Me.Gb1.Size = New System.Drawing.Size(347, 35)
        Me.Gb1.TabIndex = 2
        Me.Gb1.TabStop = False
        '
        'opc4
        '
        Me.opc4.AutoSize = True
        Me.opc4.Location = New System.Drawing.Point(248, 12)
        Me.opc4.Name = "opc4"
        Me.opc4.Size = New System.Drawing.Size(94, 18)
        Me.opc4.TabIndex = 6
        Me.opc4.TabStop = True
        Me.opc4.Text = "Subsidiários"
        Me.opc4.UseVisualStyleBackColor = True
        '
        'opc3
        '
        Me.opc3.AutoSize = True
        Me.opc3.Location = New System.Drawing.Point(167, 12)
        Me.opc3.Name = "opc3"
        Me.opc3.Size = New System.Drawing.Size(76, 18)
        Me.opc3.TabIndex = 5
        Me.opc3.TabStop = True
        Me.opc3.Text = "Poolistas"
        Me.opc3.UseVisualStyleBackColor = True
        '
        'opc2
        '
        Me.opc2.AutoSize = True
        Me.opc2.Location = New System.Drawing.Point(69, 12)
        Me.opc2.Name = "opc2"
        Me.opc2.Size = New System.Drawing.Size(98, 18)
        Me.opc2.TabIndex = 4
        Me.opc2.TabStop = True
        Me.opc2.Text = "Proprietários"
        Me.opc2.UseVisualStyleBackColor = True
        '
        'opc1
        '
        Me.opc1.AutoSize = True
        Me.opc1.Location = New System.Drawing.Point(6, 12)
        Me.opc1.Name = "opc1"
        Me.opc1.Size = New System.Drawing.Size(59, 18)
        Me.opc1.TabIndex = 3
        Me.opc1.TabStop = True
        Me.opc1.Text = "Todos"
        Me.opc1.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rb2.ForeColor = System.Drawing.Color.Black
        Me.rb2.Location = New System.Drawing.Point(10, 49)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(146, 18)
        Me.rb2.TabIndex = 1
        Me.rb2.TabStop = True
        Me.rb2.Text = "Relação geral simples"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb1.ForeColor = System.Drawing.Color.Black
        Me.rb1.Location = New System.Drawing.Point(10, 21)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(169, 18)
        Me.rb1.TabIndex = 0
        Me.rb1.TabStop = True
        Me.rb1.Text = "Cadastro geral endereços"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'gb2
        '
        Me.gb2.Controls.Add(Me.opc8)
        Me.gb2.Controls.Add(Me.opc7)
        Me.gb2.Controls.Add(Me.opc6)
        Me.gb2.Controls.Add(Me.opc5)
        Me.gb2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb2.ForeColor = System.Drawing.Color.Black
        Me.gb2.Location = New System.Drawing.Point(194, 38)
        Me.gb2.Name = "gb2"
        Me.gb2.Size = New System.Drawing.Size(347, 35)
        Me.gb2.TabIndex = 7
        Me.gb2.TabStop = False
        '
        'opc8
        '
        Me.opc8.AutoSize = True
        Me.opc8.Location = New System.Drawing.Point(248, 12)
        Me.opc8.Name = "opc8"
        Me.opc8.Size = New System.Drawing.Size(94, 18)
        Me.opc8.TabIndex = 6
        Me.opc8.TabStop = True
        Me.opc8.Text = "Subsidiários"
        Me.opc8.UseVisualStyleBackColor = True
        '
        'opc7
        '
        Me.opc7.AutoSize = True
        Me.opc7.Location = New System.Drawing.Point(167, 12)
        Me.opc7.Name = "opc7"
        Me.opc7.Size = New System.Drawing.Size(76, 18)
        Me.opc7.TabIndex = 5
        Me.opc7.TabStop = True
        Me.opc7.Text = "Poolistas"
        Me.opc7.UseVisualStyleBackColor = True
        '
        'opc6
        '
        Me.opc6.AutoSize = True
        Me.opc6.Location = New System.Drawing.Point(69, 12)
        Me.opc6.Name = "opc6"
        Me.opc6.Size = New System.Drawing.Size(98, 18)
        Me.opc6.TabIndex = 4
        Me.opc6.TabStop = True
        Me.opc6.Text = "Proprietários"
        Me.opc6.UseVisualStyleBackColor = True
        '
        'opc5
        '
        Me.opc5.AutoSize = True
        Me.opc5.Location = New System.Drawing.Point(6, 12)
        Me.opc5.Name = "opc5"
        Me.opc5.Size = New System.Drawing.Size(59, 18)
        Me.opc5.TabIndex = 3
        Me.opc5.TabStop = True
        Me.opc5.Text = "Todos"
        Me.opc5.UseVisualStyleBackColor = True
        '
        'gb3
        '
        Me.gb3.Controls.Add(Me.CADP003)
        Me.gb3.Controls.Add(Me.CADP002)
        Me.gb3.ForeColor = System.Drawing.Color.Black
        Me.gb3.Location = New System.Drawing.Point(194, 67)
        Me.gb3.Name = "gb3"
        Me.gb3.Size = New System.Drawing.Size(347, 35)
        Me.gb3.TabIndex = 8
        Me.gb3.TabStop = False
        '
        'CADP003
        '
        Me.CADP003.Location = New System.Drawing.Point(50, 14)
        Me.CADP003.Name = "CADP003"
        Me.CADP003.Size = New System.Drawing.Size(278, 13)
        Me.CADP003.TabIndex = 1
        Me.CADP003.Text = "PROPRIETÁRIO"
        Me.CADP003.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CADP002
        '
        Me.CADP002.Location = New System.Drawing.Point(3, 14)
        Me.CADP002.Name = "CADP002"
        Me.CADP002.Size = New System.Drawing.Size(46, 13)
        Me.CADP002.TabIndex = 0
        Me.CADP002.Text = "000000"
        Me.CADP002.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Relatorio
        '
        '
        'visualizar
        '
        Me.visualizar.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.visualizar.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.visualizar.ClientSize = New System.Drawing.Size(398, 298)
        Me.visualizar.Enabled = True
        Me.visualizar.Icon = CType(resources.GetObject("visualizar.Icon"), System.Drawing.Icon)
        Me.visualizar.Name = "visualizar"
        Me.visualizar.ShowIcon = False
        Me.visualizar.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.btnImprimir)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Button36)
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 158)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(563, 62)
        Me.Panel3.TabIndex = 214
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.Transparent
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(390, 5)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 52)
        Me.btnImprimir.TabIndex = 283
        Me.btnImprimir.Text = "Impressão"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 14)
        Me.Label1.TabIndex = 282
        Me.Label1.Text = "[ESC] - Fecha "
        '
        'Button36
        '
        Me.Button36.BackColor = System.Drawing.Color.Transparent
        Me.Button36.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button36.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.Button36.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button36.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button36.Image = CType(resources.GetObject("Button36.Image"), System.Drawing.Image)
        Me.Button36.Location = New System.Drawing.Point(889, 5)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(65, 52)
        Me.Button36.TabIndex = 281
        Me.Button36.Text = "Relatório"
        Me.Button36.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button36.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(470, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 52)
        Me.btnClose.TabIndex = 192
        Me.btnClose.Text = "Fechar"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'img
        '
        Me.img.Location = New System.Drawing.Point(12, 3)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(35, 36)
        Me.img.TabIndex = 282
        Me.img.TabStop = False
        '
        'dtsaida
        '
        Me.dtsaida.AutoSize = True
        Me.dtsaida.ForeColor = System.Drawing.Color.White
        Me.dtsaida.Location = New System.Drawing.Point(131, 13)
        Me.dtsaida.Name = "dtsaida"
        Me.dtsaida.Size = New System.Drawing.Size(33, 14)
        Me.dtsaida.TabIndex = 3
        Me.dtsaida.Text = "saida"
        '
        'dtentrada
        '
        Me.dtentrada.AutoSize = True
        Me.dtentrada.ForeColor = System.Drawing.Color.White
        Me.dtentrada.Location = New System.Drawing.Point(53, 13)
        Me.dtentrada.Name = "dtentrada"
        Me.dtentrada.Size = New System.Drawing.Size(44, 14)
        Me.dtentrada.TabIndex = 2
        Me.dtentrada.Text = "entrada"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtsaida)
        Me.Panel1.Controls.Add(Me.dtentrada)
        Me.Panel1.Controls.Add(Me.img)
        Me.Panel1.Location = New System.Drawing.Point(53, 302)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 283
        '
        'barra
        '
        Me.barra.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.barra.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barra.ForeColor = System.Drawing.Color.White
        Me.barra.Location = New System.Drawing.Point(0, 0)
        Me.barra.Name = "barra"
        Me.barra.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.barra.Size = New System.Drawing.Size(563, 25)
        Me.barra.TabIndex = 284
        Me.barra.Text = "Assistente de Impressão"
        '
        'frmRel004
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(563, 220)
        Me.ControlBox = False
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRel004"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Gb1.ResumeLayout(False)
        Me.Gb1.PerformLayout()
        Me.gb2.ResumeLayout(False)
        Me.gb2.PerformLayout()
        Me.gb3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents Relatorio As System.Drawing.Printing.PrintDocument
    Friend WithEvents visualizar As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents opc3 As System.Windows.Forms.RadioButton
    Friend WithEvents opc4 As System.Windows.Forms.RadioButton
    Friend WithEvents Gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents opc2 As System.Windows.Forms.RadioButton
    Friend WithEvents opc1 As System.Windows.Forms.RadioButton
    Friend WithEvents gb2 As System.Windows.Forms.GroupBox
    Friend WithEvents opc8 As System.Windows.Forms.RadioButton
    Friend WithEvents opc7 As System.Windows.Forms.RadioButton
    Friend WithEvents opc6 As System.Windows.Forms.RadioButton
    Friend WithEvents opc5 As System.Windows.Forms.RadioButton
    Friend WithEvents rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents gb3 As System.Windows.Forms.GroupBox
    Friend WithEvents CADP003 As System.Windows.Forms.Label
    Friend WithEvents CADP002 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents img As System.Windows.Forms.PictureBox
    Friend WithEvents dtsaida As System.Windows.Forms.Label
    Friend WithEvents dtentrada As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents barra As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
End Class
