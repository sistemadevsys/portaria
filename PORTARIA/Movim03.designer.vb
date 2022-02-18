<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movim03
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movim03))
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.imgBarra = New System.Windows.Forms.ImageList(Me.components)
        Me.Button13 = New System.Windows.Forms.Button()
        Me.btnPagina = New System.Windows.Forms.Button()
        Me.btnEditaPagina = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OCC006 = New System.Windows.Forms.TextBox()
        Me.lvLivro = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DATA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HORA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button13.Location = New System.Drawing.Point(102, 3)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(61, 25)
        Me.Button13.TabIndex = 356
        Me.Button13.Text = "HORA"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'btnPagina
        '
        Me.btnPagina.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPagina.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnPagina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagina.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagina.ForeColor = System.Drawing.Color.Red
        Me.btnPagina.Image = CType(resources.GetObject("btnPagina.Image"), System.Drawing.Image)
        Me.btnPagina.Location = New System.Drawing.Point(2, 246)
        Me.btnPagina.Name = "btnPagina"
        Me.btnPagina.Size = New System.Drawing.Size(85, 35)
        Me.btnPagina.TabIndex = 359
        Me.btnPagina.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.btnPagina, "Abre ocorrência manual")
        Me.btnPagina.UseVisualStyleBackColor = False
        '
        'btnEditaPagina
        '
        Me.btnEditaPagina.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEditaPagina.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnEditaPagina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditaPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditaPagina.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditaPagina.ForeColor = System.Drawing.Color.Red
        Me.btnEditaPagina.Image = CType(resources.GetObject("btnEditaPagina.Image"), System.Drawing.Image)
        Me.btnEditaPagina.Location = New System.Drawing.Point(95, 246)
        Me.btnEditaPagina.Name = "btnEditaPagina"
        Me.btnEditaPagina.Size = New System.Drawing.Size(85, 35)
        Me.btnEditaPagina.TabIndex = 358
        Me.btnEditaPagina.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.btnEditaPagina, "Edita registro de ocorrências")
        Me.btnEditaPagina.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(2, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 64)
        Me.Label2.TabIndex = 357
        Me.Label2.Text = "As páginas do livro são abertas automaticamente pelo sistema." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Basta clicar no bo" &
    "tão de edição, para adicionar novos relatatos ao livro"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button12.Location = New System.Drawing.Point(2, 3)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(104, 25)
        Me.Button12.TabIndex = 355
        Me.Button12.Text = "DATA"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(184, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 15)
        Me.Label1.TabIndex = 354
        Me.Label1.Text = "Descrição da ocorrências:"
        '
        'OCC006
        '
        Me.OCC006.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.OCC006.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OCC006.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OCC006.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.OCC006.Location = New System.Drawing.Point(187, 15)
        Me.OCC006.MaxLength = 10000
        Me.OCC006.Multiline = True
        Me.OCC006.Name = "OCC006"
        Me.OCC006.ReadOnly = True
        Me.OCC006.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OCC006.Size = New System.Drawing.Size(449, 266)
        Me.OCC006.TabIndex = 353
        '
        'lvLivro
        '
        Me.lvLivro.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.DATA, Me.HORA})
        Me.lvLivro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLivro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lvLivro.GridLines = True
        Me.lvLivro.HideSelection = False
        Me.lvLivro.Location = New System.Drawing.Point(2, 3)
        Me.lvLivro.Name = "lvLivro"
        Me.lvLivro.Size = New System.Drawing.Size(179, 173)
        Me.lvLivro.TabIndex = 352
        Me.lvLivro.UseCompatibleStateImageBehavior = False
        Me.lvLivro.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Width = 0
        '
        'DATA
        '
        Me.DATA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DATA.Width = 98
        '
        'HORA
        '
        Me.HORA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Movim03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(641, 291)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.btnPagina)
        Me.Controls.Add(Me.btnEditaPagina)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OCC006)
        Me.Controls.Add(Me.lvLivro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Movim03"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Protected WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents imgBarra As System.Windows.Forms.ImageList
    Friend WithEvents Button13 As Button
    Friend WithEvents btnPagina As Button
    Friend WithEvents btnEditaPagina As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents OCC006 As TextBox
    Friend WithEvents lvLivro As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents DATA As ColumnHeader
    Friend WithEvents HORA As ColumnHeader



End Class
