Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Media


Public Class frmVeiculos
    Dim data_hoje As DateTime = DateTime.Now
    Dim FileName As String
    Dim img As Image
    Dim sql As String
    Dim retorno As String
    Dim tabela As String
    Dim campo As String
    Dim acao As String
    Dim grava As Integer
    Dim texto As String
    Dim VEI001 As New TextBox
    Dim iVei008 As New TextBox
    Dim pop As Integer
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
    Private Sub frmVeiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabela = "prt_veiculos" ' NOME DA TABELA
        campo = "VEI002"      ' CAMPO DA TABELA
        acao = "NOVO"

        Call pesquisa(0) ' faz a pesquisa no banco de dados
        If retorno = Nothing Then
            Call botão(0)   ' FAZ O BLOQUEIO DOS BOTÕES ATÉ ATENDER AS CONDIÇÕES
            Call Bloqtextbox(0) ' limpa os textbox
            Call Bloqtextbox(1) ' bloqueio dos textbox para edição
        End If

        Tabela01.SelectedIndex = 0
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call testacampos() ' TESTA O PREENCHIMENTO DOS CAMPOS OU TEXTBOX
        If grava > 0 Then
            If VEI002.TextLength < 7 Then
                MetroFramework.MetroMessageBox.Show(Me, " A Placa do veículo não atende a legislação atual. Verifique!!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                VEI002.SelectAll()
                VEI002.Focus()
            Else
                If acao = "NOVO" Then
                    texto = "Registro efetuado com sucesso"
                    sql = "insert into prt_veiculos(VEI002,VEI003,VEI004,VEI005,VEI006,VEI007)values('" & VEI002.Text & "','" & VEI003.Text & "','" & VEI004.Text & "','" & VEI005.Text & "','" & VEI006.Text & "','" & VEI007.Text & "')"
                Else
                    texto = "Alteração efetuada com sucesso"
                    sql = "update prt_veiculos set  VEI002 = '" & VEI002.Text & "',VEI003 = '" & VEI003.Text & "',VEI004 = '" & VEI004.Text & "',VEI005 = '" & VEI005.Text & "',VEI006 = '" & VEI006.Text & "',VEI007 = '" & VEI007.Text & "' WHERE VEI001 = '" & VEI001.Text & "'"
                End If
                Try
                    If conexao.State = ConnectionState.Open Then conexao.Close()
                    Dim cmd As New MySqlCommand(sql, conexao)
                    conexao.Open()
                    cmd.ExecuteNonQuery()
                    MetroFramework.MetroMessageBox.Show(Me, texto, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    conexao.Close()
                    acao = ""
                    Call botão(1) ' LIBERA TODOS OS BOTÕES
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                    Exit Sub
                End Try
            End If
        End If
    End Sub
    Private Sub btnimporta_Click(sender As Object, e As EventArgs) Handles btnimporta.Click
        If VEI002.Text = "" Or VEI002.TextLength < 7 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe a placa do veiculo para efetuar a busca! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            op1.Filter = "jpg|*.jpg|gif|*.gif|png|*.png"
            op1.ShowDialog() ' abre a pesquisa de arquivo
        End If
    End Sub
    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        If pop > 0 Then
            Tabela01.SelectedIndex = 0
            Call gravar(1)
            Call pesquisa(0) '
        End If
    End Sub
    Private Sub btnCaptura_Click(sender As Object, e As EventArgs) Handles btnCaptura.Click
        MetroFramework.MetroMessageBox.Show(Me, " Dispositivo de captura não foi localizado! ")
    End Sub
#End Region

#Region "FUNÇÕES"
    Private Sub pesquisa(arg)
        Select Case arg
            Case 0
                Dim ds As New DataSet
                Dim da As MySqlDataAdapter
                Dim sql As String
                If conexao.State = 0 Then
                    conexao.Open()
                End If
                retorno = Nothing
                sql = "select * from " & tabela & " where " & campo & " = '" & VEI002.Text & "'"
                da = New MySqlDataAdapter(sql, conexao)
                da.Fill(ds, tabela)
                If ds.Tables(tabela).Rows.Count > 0 Then
                    grava = 0
                    acao = "ALTERA"
                    retorno = "TRUE"
                    VEI001.Text = ds.Tables(tabela).Rows(0).Item(0)
                    VEI002.Text = ds.Tables(tabela).Rows(0).Item(1)
                    VEI003.Text = ds.Tables(tabela).Rows(0).Item(2)
                    VEI004.Text = ds.Tables(tabela).Rows(0).Item(3)
                    VEI005.Text = ds.Tables(tabela).Rows(0).Item(4)
                    VEI006.Text = ds.Tables(tabela).Rows(0).Item(5)
                    VEI007.Text = ds.Tables(tabela).Rows(0).Item(6)
                    iVei008.Text = ds.Tables(tabela).Rows(0).Item(7)
                    If iVei008.Text = "REGISTRO" Then
                        VEI008.Image = Nothing
                    Else
                        VEI008.ImageLocation = (My.Application.Info.DirectoryPath & "\file\car\" & iVei008.Text & ".dat")
                    End If
                    Call botão(1) ' LIBERA TODOS OS BOTÕES
                Else
                    grava = 0
                    acao = "NOVO"
                    retorno = Nothing
                End If
                conexao.Close()
            Case 1
                Dim ds As New DataSet
                Dim da As MySqlDataAdapter
                Dim sql As String
                If conexao.State = 0 Then
                    conexao.Open()
                End If
                retorno = Nothing
                sql = "select * from " & tabela & " where " & campo & " = '" & VEI002.Text & "'"
                da = New MySqlDataAdapter(sql, conexao)
                da.Fill(ds, tabela)
                If ds.Tables(tabela).Rows.Count > 0 Then
                    retorno = "TRUE"
                Else
                    retorno = "FALSE"
                End If
                conexao.Close()
        End Select
    End Sub
    Private Sub gravar(arg)
        Select Case arg
            Case 0
                ' faz a inserção do registro na tabela PRT_IMAGEM
                If conexao.State = ConnectionState.Open Then conexao.Close()
                sql = "INSERT INTO prt_imgcar (VEI002,IMC002,IMC003,IMC004,IMC005)VALUES('" & VEI002.Text & "','" & Format(data_hoje, "yyyy-MM-dd") & "','" & DateTime.Now.ToShortTimeString() & "','" & FileName & "','" & iUsername & "')"
                Dim cmd As New MySqlCommand(sql, conexao)
                conexao.Open()
                cmd.ExecuteNonQuery()
                conexao.Close()
            Case 1
                ' Faz o update na tabela prt_cadfun para troca da foto do perfil se for selecionado
                If conexao.State = ConnectionState.Open Then conexao.Close()
                sql = "update prt_veiculos set VEI008 = '" & Me.lvFotos.SelectedItems(0).SubItems(4).Text & "' WHERE VEI001 = '" & VEI001.Text & "'"
                Dim cmd As New MySqlCommand(sql, conexao)
                conexao.Open()
                cmd.ExecuteNonQuery()
                conexao.Close()
        End Select
    End Sub
    Private Sub testacampos()
        grava = 0
        If VEI002.Text = "" Or VEI002.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe a placa do veiculo para efetuar a busca! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            VEI002.Focus()
            Exit Sub
        End If
        If VEI003.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe a marca do veículo ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            VEI003.Focus()
            Exit Sub
        End If
        If VEI004.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o modelo do veículo ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            VEI004.Focus()
            Exit Sub
        End If
        If VEI005.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe a cor predominante do veículo ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            VEI005.Focus()
            Exit Sub
        End If
        If VEI006.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe a cidade de registro do veículo ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            VEI006.Focus()
            Exit Sub
        End If
        If VEI007.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe a unidade da federação onde está registrado o veículo ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            VEI007.Focus()
            Exit Sub
        End If
        grava = 10
    End Sub
    Private Sub botão(arg)
        Select Case arg
            Case 0
                ' bloqueio dos botões
                btnSave.Enabled = False
                btnimporta.Enabled = False
                btnCaptura.Enabled = False
                btnPerfil.Enabled = False
            Case 1
                ' libera a edição dos botões
                btnSave.Enabled = True
                btnimporta.Enabled = True
                btnCaptura.Enabled = True
                btnPerfil.Enabled = True
        End Select
    End Sub

    Private Sub Bloqtextbox(arg)
        Select Case arg
            Case 0
                ' LIMPA OS TEXTBOX PARA INICIAR A INCLUSÃO E PESQUISA
                VEI003.Clear()
                VEI004.Clear()
                VEI005.Clear()
                VEI006.Clear()
                VEI007.Clear()
                VEI008.Image = Nothing
            Case 1
                ' BLOQUEIO DOS TEXTBOX
                VEI003.ReadOnly = True
                VEI004.ReadOnly = True
                VEI005.ReadOnly = True
                VEI006.ReadOnly = True
                VEI007.ReadOnly = True
            Case 2
                VEI003.ReadOnly = False
                VEI004.ReadOnly = False
                VEI005.ReadOnly = False
                VEI006.ReadOnly = False
                VEI007.ReadOnly = False
        End Select
    End Sub

    Private Sub Tabela_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles Tabela01.SelectedIndexChanged
        Call tratatab()
    End Sub

    Private Sub tratatab()
        Select Case Tabela01.SelectedTab.Name
            Case "Tab1"
                If VEI002.TextLength > 0 Then
                    Call pesquisa(0)
                End If
            Case "Tab2"
                imgbanco.Image = imgLimpo.Image
                Call carregalist(0) ' carrega as fotos do banco de imagem
                If pop > 0 Then
                    Me.lvFotos.Items(0).Selected = True
                    lvFotos.Select()
                End If
        End Select
    End Sub






    Private Sub carregalist(arg)
        Select Case arg
            Case 0
                lvFotos.Items.Clear()
                lvFotos.BackColor = Color.White
                lvFotos.GridLines = True
                lvFotos.FullRowSelect = True
                lvFotos.View = View.Details
                lvFotos.Sorting = SortOrder.None
                conexao.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("select IMC001,IMC002,IMC003,IMC005,IMC004 from prt_imgcar where VEI002 = '" & VEI002.Text & "'", conexao)
                Dim leitor As MySqlDataReader = cmd.ExecuteReader()
                pop = 0
                Do While leitor.Read()
                    Dim item As New ListViewItem()
                    item.Text = leitor(0)
                    item = lvFotos.Items.Add(leitor("IMC001").ToString)                ' 0 ID
                    item.SubItems.Add(Format(leitor("IMC002"), "dd/MM/yyyy").ToString) ' 1 DATA DO ARQUIVO
                    item.SubItems.Add(leitor("IMC003").ToString)                       ' 2 HORA DO ARQUIVO
                    item.SubItems.Add(leitor("IMC005").ToString)                       ' 3 PORTEIRO 
                    item.SubItems.Add(leitor("IMC004").ToString)                       ' 4 NOME DO ARQUIVO DA FOTO
                    pop += 1
                Loop
                conexao.Close() ' fecha a conexação com o banco de dados
                leitor.Dispose()
        End Select
    End Sub
    Public Sub tempValue()
        Dim hora As Integer = DateTime.Now.ToLongTimeString().Substring(0, 2)
        Dim minuto As Integer = DateTime.Now.ToLongTimeString().Substring(3, 2)
        Dim segundo As Integer = DateTime.Now.ToLongTimeString().Substring(6, 2)

        FileName = Format(data_hoje, "ddyyyyMM") & segundo & minuto & hora & VEI002.Text
        Dim objImageCodecInfo() As System.Drawing.Imaging.ImageCodecInfo
        objImageCodecInfo = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders
        Dim objEncParams As New System.Drawing.Imaging.EncoderParameters(1)
        Dim objEncParam As New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100) 'definindo qualidade de 10%
        objEncParams.Param(0) = objEncParam
        img.Save(Application.StartupPath + "\file\car\" & FileName & ".dat", objImageCodecInfo(1), objEncParams)
    End Sub
#End Region

#Region "ENTER"
    Private Sub VEI002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles VEI002.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If VEI002.Text = "" Or VEI002.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe a placa do veiculo para efetuar a busca! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                VEI002.Focus()
            Else
                Call pesquisa(0) ' faz a pesquisa no banco de dados
                If retorno = Nothing Then
                    If (MetroFramework.MetroMessageBox.Show(Me, " Não localizei o veículo. Deseja cadastrar ?", "" & legenda & "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)) = MsgBoxResult.Yes Then
                        Tabela01.SelectedIndex = 0
                        Call Bloqtextbox(2) ' libera a edição dos textbox
                        Call Bloqtextbox(0) ' limpa os textboxz
                        btnSave.Enabled = True
                        VEI003.SelectAll()
                        VEI003.Focus()
                    Else
                        Me.Close()
                    End If
                Else
                    Call botão(2)
                    Call Bloqtextbox(2)
                End If
            End If
        End If
    End Sub

    Private Sub VEI003_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles VEI003.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If VEI003.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe a marca do veículo ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                VEI003.Focus()
            Else
                VEI004.Focus()
            End If
        End If
    End Sub
    Private Sub VEI004_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles VEI004.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If VEI004.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o modelo do veículo ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                VEI004.Focus()
            Else
                VEI005.Focus()
            End If
        End If
    End Sub
    Private Sub VEI005_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles VEI005.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If VEI005.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe a cor predominante do veículo ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                VEI005.Focus()
            Else
                VEI006.Focus()
            End If
        End If
    End Sub
    Private Sub VEI006_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles VEI006.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If VEI006.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe a cidade de registro do veículo ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                VEI006.Focus()
            Else
                VEI007.Focus()
            End If
        End If
    End Sub
    Private Sub VEI007_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles VEI007.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If VEI007.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe a unidade da federação onde está registrado o veículo ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                VEI007.Focus()
            Else
                btnSave.PerformClick()
            End If
        End If
    End Sub
#End Region

#Region "COMPONENTES"
    Private Sub op1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles op1.FileOk
        img = Bitmap.FromFile(op1.FileName)
        Call tempValue()
        Call gravar(0) ' grava o caminho das imagens no banco
        Call carregalist(0)
        If pop > 0 Then
            Me.lvFotos.Items(0).Selected = True
            lvFotos.Select()
        End If
    End Sub
    Private Sub lvFotos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvFotos.SelectedIndexChanged
        Try
            If lvFotos.SelectedItems.Count > 0 Then
                'indexFoto = lvFotos.Items.Item(lvFotos.SelectedIndices(0)).Index
                ' FAZ A LEITURA DA IMAGEM COM REFERENCIA DA TABELA BUSCANDOO DIRETORIO ONDE ESTA A IMAGEM
                imgbanco.ImageLocation = (My.Application.Info.DirectoryPath & "\file\car\" & Me.lvFotos.SelectedItems(0).SubItems(4).Text & ".dat")
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub VEI008_DoubleClick(sender As Object, e As EventArgs) Handles VEI008.DoubleClick
        Call pesquisa(1)
        If retorno = "FALSE" Then
            MetroFramework.MetroMessageBox.Show(Me, " Veiculo não foi localizado. Verifique!! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            VEI002.SelectAll()
            VEI002.Focus()
        Else
            alterado = 500
            Repositorio.VEI002.Text = VEI002.Text
            frmRegistra.VEI002.Text = VEI002.Text
            frmRegAcesso.btnCarro.Text = VEI002.Text
            frmRegAcVisitante.btnCarro.Text = VEI002.Text
            Me.Close()
        End If
    End Sub

#End Region




End Class
























