Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class Aviso08
    Private myCam As iCam
    Dim pop As Integer
    Dim data_hoje As DateTime = DateTime.Now
    Dim FileName As String
    Dim img As Bitmap
    Dim acao As String
    Dim CADP023 As New TextBox

#Region "MOVER FORMULÁRIO"
    Dim objDraw As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath
    Dim mover As New MoveForm
    Private Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure
    Private Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub
#End Region

#Region "START DO FORMULÁRIO"
    Private Sub BEEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
    Private Sub escape_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            ' BOTÃO SALVAR O REGISTRO
            Me.Close()
        End If
    End Sub
    Private Sub Aviso08_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height - 77) / 2
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width + 445) / 2
        imgbanco.Image = imgLimpo.Image
        btnCapIMG.Visible = False
        btnCancel.Visible = False
        btnimporta.Visible = True
        imgCam.Visible = False
        imgbanco.Visible = True
        Call carregaList() ' carrega as fotos do banco de imagem
        If pop > 0 Then
            Me.lvFotos.Items(0).Selected = True
            lvFotos.Select()
        End If
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub
    Private Sub btnimporta_Click(sender As Object, e As EventArgs) Handles btnimporta.Click
        acao = "CAPITURA"
        btnCapIMG.Visible = False
        btnCancel.Visible = False
        imgCam.Visible = False
        imgbanco.Visible = True
        op1.Filter = "jpg|*.jpg|gif|*.gif|png|*.png"
        op1.ShowDialog() ' abre a pesquisa de arquivo
        Call carregaList()
        If pop > 0 Then
            Me.lvFotos.Items(0).Selected = True
            lvFotos.Select()
        End If
    End Sub
    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        If pop > 0 Then
            Try
                alterado = 500
                Call gravar(1)
                MetroFramework.MetroMessageBox.Show(Me, " A foto será exibida no perfil do cadastro ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCaptura_Click(sender As Object, e As EventArgs) Handles btnCaptura.Click
        Try
            btnimporta.Visible = False
            acao = "CAMERA"
            btnCapIMG.Visible = True
            btnCancel.Visible = True
            imgCam.Visible = True
            imgbanco.Visible = False
            Me.imgCam.SizeMode = PictureBoxSizeMode.StretchImage
            myCam = New iCam
            myCam.initCam(Me.imgCam.Handle.ToInt32)  ' CONECTA COM A WEB CAM
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, " Erro ao se conectar com a camera")
        End Try
    End Sub
    Private Sub btnCapIMG_Click(sender As Object, e As EventArgs) Handles btnCapIMG.Click
        img = myCam.copyFrame(Me.imgbanco, New RectangleF(0, 0,
                              Me.imgbanco.Width, Me.imgbanco.Height))
        Call tempValue()
        Call gravar(0) ' grava o caminho das imagens no banco

        imgbanco.Image = imgLimpo.Image

        myCam.closeCam()
        Application.DoEvents()
        myCam = Nothing

        btnCapIMG.Visible = False
        btnCancel.Visible = False
        btnimporta.Visible = True
        imgCam.Visible = False
        imgbanco.Visible = True

        Call carregaList()
        If pop > 0 Then
            Me.lvFotos.Items(0).Selected = True
            lvFotos.Select()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnCapIMG.Visible = False
        btnCancel.Visible = False
        btnimporta.Visible = True
        imgCam.Visible = False
        imgbanco.Visible = True
        imgbanco.BringToFront()

        Call carregaList()
        If pop > 0 Then
            Me.lvFotos.Items(0).Selected = True
            lvFotos.Select()
        End If
    End Sub
#End Region

#Region "FUNÇÕES"
    Private Sub carregaList()
        lvFotos.Items.Clear()
        lvFotos.BackColor = Color.White
        lvFotos.GridLines = True
        lvFotos.FullRowSelect = True
        lvFotos.View = View.Details
        lvFotos.Sorting = SortOrder.None
        imgbanco.Image = imgLimpo.Image
        conexao.Open()
        Dim cmd As MySqlCommand = New MySqlCommand("select IMG001,IMG003,IMG004,USU002,IMG005 from prt_imgout where IMG002 = '" & CADP001.Text & "' ORDER BY IMG003 DESC", conexao)
        Dim leitor As MySqlDataReader = cmd.ExecuteReader()
        pop = 0
        Do While leitor.Read()
            Dim item As New ListViewItem()
            item.Text = leitor(0)
            item = lvFotos.Items.Add(leitor("IMG001").ToString)                ' 0 ID
            item.SubItems.Add(Format(leitor("IMG003"), "dd/MM/yyyy").ToString) ' 1 DATA DO ARQUIVO
            item.SubItems.Add(leitor("IMG004").ToString)                       ' 2 HORA DO ARQUIVO
            item.SubItems.Add(leitor("USU002").ToString)                       ' 3 PORTEIRO 
            item.SubItems.Add(leitor("IMG005").ToString)                       ' 4 NOME DO ARQUIVO DA FOTO
            pop += 1 ' faz a contagem dos registros no listview
        Loop
        conexao.Close() ' fecha a conexação com o banco de dados
        leitor.Dispose()
    End Sub
    Public Sub tempValue()
        Dim hora As Integer = DateTime.Now.ToLongTimeString().Substring(0, 2)
        Dim minuto As Integer = DateTime.Now.ToLongTimeString().Substring(3, 2)
        Dim segundo As Integer = DateTime.Now.ToLongTimeString().Substring(6, 2)

        FileName = Format(data_hoje, "ddyyyyMM") & segundo & minuto & hora & CADP002.Text
        Dim objImageCodecInfo() As System.Drawing.Imaging.ImageCodecInfo
        objImageCodecInfo = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders
        Dim objEncParams As New System.Drawing.Imaging.EncoderParameters(1)
        Dim objEncParam As New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100) 'definindo qualidade de 10%
        objEncParams.Param(0) = objEncParam
        img.Save(Application.StartupPath + "\file\owner\" & FileName & ".dat", objImageCodecInfo(1), objEncParams)
    End Sub
    Private Sub gravar(arg)
        Select Case arg
            Case 0
                ' faz a inserção do registro na tabela PRT_IMAGEM
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim cmd As New MySqlCommand("INSERT INTO prt_imgout (IMG002,IMG003,IMG004,IMG006,IMG005,USU002)VALUES('" & CADP001.Text & "','" & Format(data_hoje, "yyyy-MM-dd") & "','" & DateTime.Now.ToLongTimeString & "','" & CADP026.Text & "','" & FileName & "','" & iUsername & "')", conexao)
                conexao.Open()
                cmd.ExecuteNonQuery()
                conexao.Close()
            Case 1
                ' Faz o update na tabela prt_cadfun para troca da foto do perfil se for selecionado
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim cmd As New MySqlCommand("update prt_cadpro set CADP023 = '" & lvFotos.SelectedItems(0).SubItems(4).Text & "' WHERE CADP001 = '" & CADP001.Text & "'", conexao)
                conexao.Open()
                cmd.ExecuteNonQuery()
                conexao.Close()
        End Select
    End Sub
#End Region

#Region "LISTVIEW"
    Private Sub lvFotos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvFotos.SelectedIndexChanged
        Try
            If lvFotos.SelectedItems.Count > 0 Then
                'indexFoto = lvFotos.Items.Item(lvFotos.SelectedIndices(0)).Index
                ' FAZ A LEITURA DA IMAGEM COM REFERENCIA DA TABELA BUSCANDOO DIRETORIO ONDE ESTA A IMAGEM
                imgbanco.Image = imgLimpo.Image
                CADP023.Text = Me.lvFotos.SelectedItems(0).SubItems(4).Text
                imgbanco.ImageLocation = (My.Application.Info.DirectoryPath & "\file\owner\" & CADP023.Text & ".dat")
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "COMPONENTES"
    Private Sub op1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles op1.FileOk
        img = Bitmap.FromFile(op1.FileName)
        Call tempValue()
        Call gravar(0) ' grava o caminho das imagens no banco
        Call carregaList()
        If pop > 0 Then
            Me.lvFotos.Items(0).Selected = True
            lvFotos.Select()
        End If
    End Sub
#End Region


End Class
























