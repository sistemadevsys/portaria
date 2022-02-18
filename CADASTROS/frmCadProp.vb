Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmCadProp
    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Protected regionHandle As IntPtr




    Dim filtro, index, busca As Integer
    Dim sql, chave, retorno, acao, grava As String
    Dim CADP001, CADP019, CADP023, CADP026 As New TextBox
    Dim frmPanel As Panel
    Dim pop As Integer

#Region "BEEP DO ENTER"
    Private Sub beep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
#End Region


#Region "START DO FORMULÁRIO"
    Private Sub frmClose_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
    Private Sub frmPadrao_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            ' BOTÃO INCLUIR NOVO REGISTRO
            Me.Close()
        End If
        If e.KeyCode = Keys.F2 Then
            ' BOTÃO INCLUIR NOVO REGISTRO
            If btnnovo.Enabled = True Then btnnovo.PerformClick()
        End If
        If e.KeyCode = Keys.F3 Then
            ' BOTÃO EDITAR O REGISTRO
            If btnaltera.Enabled = True Then btnaltera.PerformClick()
        End If
        If e.KeyCode = Keys.F4 Then
            ' BOTÃO CANCELAR O PROCESSO
            If btncancela.Enabled = True Then btncancela.PerformClick()
        End If
        If e.KeyCode = Keys.F5 Then
            ' BOTÃO SALVAR O REGISTRO
            If btnsave.Enabled = True Then btnsave.PerformClick()
        End If
        If e.KeyCode = Keys.Escape Then
            ' BOTÃO SALVAR O REGISTRO
            Me.Close()
        End If
    End Sub
    Private Sub frmCadPro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Cadastro e Manutenção dos Propretários das Unidades"
        'Call montaAno(0) ' MONTA OS ANOS PARA O FILTRO DO CADASTRO

        redondo(0, 0, tarja, 20, 20)
        redondo(0, 0, gb30, 20, 20)
        redondo(0, 0, Panel1, 20, 20)

        grava = "Não"
        Panel3.Visible = True
        Panel2.Visible = True  'DADOS DO PROPRIETARIO
        Call Bloqueio_Botoes(0) ' BLOQUEIO DOS BOTÕES
        Call bloqueia_texto(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS
        Call bloqueia_texto(4) ' BLOQUEIO DOS CAMPOS DA ABA DE AUTORIZAÇÕES

        filtro = 99 ' VARIAVEL QUE ACIONA O FILTRO PARA MOSTRAR TODOS OS REGISTROS
        Call carregalist(0) ' CARREGA OS PROPRIETÁRIOS
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If
    End Sub
#End Region

#Region "LISTVIEW"
    Private Sub carregalist(arg)
        Select Case arg
            Case 0
                Call filtrar()
                lvDados.Items.Clear()
                lvDados.BackColor = Color.White
                lvDados.GridLines = True
                lvDados.FullRowSelect = True
                lvDados.View = View.Details
                lvDados.Sorting = SortOrder.None
                conexao.Open()
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conexao)
                Dim leitor As MySqlDataReader = cmd.ExecuteReader()
                pop = 0
                Do While leitor.Read()
                    Dim item As New ListViewItem()
                    item.Text = leitor(0)
                    item = lvDados.Items.Add(leitor("CADP001").ToString)  ' 0 ID
                    item.SubItems.Add(leitor("CADP002").ToString)         ' 1 NUMERAÇÃO DA UNIDADE
                    item.SubItems.Add(leitor("CADP003").ToString)         ' 2 NOME DO PROPRIETÁRIO  
                    item.SubItems.Add(leitor("CADP004").ToString)         ' 3 CONJUGE OU AUTORIZADO PRINCIPAL 
                    pop += 1 ' faz a contagem dos registros no listview
                Loop
                conexao.Close() ' fecha a conexação com o banco de dados
                leitor.Dispose()
        End Select
    End Sub
    Private Sub lvDados_Click(sender As Object, e As EventArgs) Handles lvDados.Click
        For i As Integer = 0 To lvDados.Items.Count - 1
            lvDados.Items(i).SubItems(0).BackColor = Color.White  ' 
            lvDados.Items(i).SubItems(1).BackColor = Color.FromArgb(0, 21, 68)  ' 
            lvDados.Items(i).SubItems(0).ForeColor = Color.FromArgb(0, 21, 68) ' 
            lvDados.Items(i).SubItems(1).ForeColor = Color.FromArgb(0, 21, 68) ' 
        Next
    End Sub
    Private Sub lvDados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDados.SelectedIndexChanged
        Try
            If lvDados.SelectedItems.Count > 0 Then
                index = lvDados.Items.Item(lvDados.SelectedIndices(0)).Index
                Me.CADP001.Text = Convert.ToString(lvDados.Items(lvDados.SelectedIndices(0)).Text)
                Me.CADP002.Text = Me.lvDados.SelectedItems(0).SubItems(1).Text
                Me.CADP003.Text = Me.lvDados.SelectedItems(0).SubItems(2).Text
                Repositorio.CADP001.Text = CADP001.Text
                Repositorio.CADP002.Text = CADP002.Text
                Repositorio.CADP003.Text = CADP003.Text
                Call buscadados(0) ' Busca os dados do cadastro de proprietários
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CORLIST(Arg)
        Select Case Arg
            Case 0
                Try
                    lvDados.FocusedItem.SubItems(0).BackColor = Color.FromArgb(246, 137, 31)
                    lvDados.FocusedItem.SubItems(1).BackColor = Color.FromArgb(246, 137, 31)
                    lvDados.FocusedItem.SubItems(0).ForeColor = Color.White
                    lvDados.FocusedItem.SubItems(1).ForeColor = Color.White
                    Return
                Catch ex As Exception

                End Try
        End Select


    End Sub
#End Region

#Region "FUNÇÕES E PROCEDURES"
    Private Sub redondo(arg1, arg2, componente, arg3, arg4)
        regionHandle = New IntPtr(CreateRoundRectRgn(arg1, arg2, componente.Width, componente.Height, arg3, arg4))
        componente.Region = Region.FromHrgn(regionHandle)
        componente.Region.ReleaseHrgn(regionHandle)
    End Sub

    Private Sub Tabelas_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles Tabelas.SelectedIndexChanged
        Call tratatab()
    End Sub

    Private Sub tratatab()
        Select Case Tabelas.SelectedTab.Name
            Case "Tab0"
                Panel3.Visible = True
                Panel2.Visible = True  'DADOS DO PROPRIETARIO
                tarja.BackColor = Color.FromArgb(0, 21, 68)
                tarja.ForeColor = Color.White
                tarja.Text = "Cadastro e Manutenção dos Propretários das Unidades"
                Call carregalist(0) ' CARREGA OS PROPRIETÁRIOS
                If pop > 0 Then
                    Me.lvDados.Items(index).Selected = True
                    lvDados.Select()
                End If
            Case "Tab1"
                Panel3.Visible = False
                Panel2.Visible = True  'DADOS DO PROPRIETARIO
                tarja.BackColor = Color.Green
                tarja.ForeColor = Color.White
                tarja.Text = "Cadastro e Manutenção de Pessoas autorizadas a utilizar o apartamento"
                frmPanel = P_Autorizados
                Call CORLIST(0)
                frmPanel.Controls.Clear() ' LIMPA OS DADOS DO FORMULÁRIODE AUTORIZADOS QUE VAI ABRIR DENTRO DO PAINEL

                Repositorio.CADP036.Text = ""
                Repositorio.origem.Text = ""

                Repositorio.CADP036.Text = CADP002.Text
                Repositorio.origem.Text = "PROPRIETARIOS"

                abriform(Of frmAutorizados)() ' ABRE O FORMULÁRIO DENTRO DO PAINEL

            Case "Tab2"
                Panel3.Visible = False
                Panel2.Visible = True  'DADOS DO PROPRIETARIO
                tarja.BackColor = Color.FromArgb(0, 21, 68)
                tarja.ForeColor = Color.White
                tarja.Text = "Log de movimentação na portaria"
                Repositorio.iCADP002.Text = CADP002.Text
                Repositorio.iORIGEM.Text = "PRO" ' filtro cadp037

                frmPanel = P_LogPortaria
                Call CORLIST(0)
                frmPanel.Controls.Clear() ' LIMPA OS DADOS DO FORMULÁRIODE AUTORIZADOS QUE VAI ABRIR DENTRO DO PAINEL

                abriform(Of frmLogMovim)() ' ABRE O FORMULÁRIO DENTRO DO PAINEL


            Case "Tab3"
                Panel3.Visible = False
                Panel2.Visible = False 'DADOS DO PROPRIETARIO
                tarja.BackColor = Color.Orange
                tarja.ForeColor = Color.White
                tarja.Text = "Consulta e Registro de locação mensal"
                frmPanel = p_locacao
                Call CORLIST(0)
                frmPanel.Controls.Clear() ' LIMPA OS DADOS DO FORMULÁRIODE AUTORIZADOS QUE VAI ABRIR DENTRO DO PAINEL
                Repositorio.CADP036.Text = CADP002.Text
                Repositorio.CADP003.Text = CADP003.Text
                Repositorio.CADP019.Text = CADP019.Text
                abriform(Of frmLocacao)() ' ABRE O FORMULÁRIO DENTRO DO PAINEL
        End Select
    End Sub




    Private Sub abriform(Of miform As {Form, New})()
        Dim formulario As Form
        formulario = frmPanel.Controls.OfType(Of miform)().FirstOrDefault
        If formulario Is Nothing Then
            formulario = New miform
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            frmPanel.Controls.Add(formulario)
            frmPanel.Tag = formulario
            formulario.Show()
            formulario.BringToFront()
        Else
            formulario.BringToFront()
        End If
    End Sub
    Private Sub geracod(arg)
        Select Case arg
            Case 0
                ' GERA UM CÓDIGO ALTERAVEL COM BASE NO ULTIMO CADASTRO REALIZADO + 1
                Dim sqlmaior As String
                If conexao.State = 0 Then
                    conexao.Open()
                End If
                sqlmaior = "Select Max(CADP002) From prt_cadpro where CADP026 = 'PRO'"
                Dim cmd As New MySqlCommand(sqlmaior, conexao)
                Dim maior As Integer
                If IsDBNull(cmd.ExecuteScalar) Then
                    maior = 1
                Else
                    maior = cmd.ExecuteScalar + 1
                End If
                cmd.ExecuteNonQuery()
                CADP002.Text = Format(maior, "000000")
                cmd.Dispose()
                conexao.Close()
            Case 1

        End Select
    End Sub


    Private Sub filtrar()
        Select Case filtro
            Case 99 ' TODOS OS REGISTROS
                sql = "SELECT CADP001,CADP002,CADP003,CADP004 FROM PRT_CADPRO WHERE CADP028 = '0' AND CADP026 = 'PRO' ORDER BY CADP002"
            Case 0 ' FILTRA POR CÓDIGO DA UNIDADE
                sql = "SELECT CADP001,CADP002,CADP003,CADP004 FROM PRT_CADPRO WHERE CADP002 like '" & chave & "%' AND CADP028 = '0' AND CADP026 = 'PRO' order by CADP002"
            Case 1 ' FILTRA PELO NOME DO PROPRIETÁRIO
                sql = "SELECT CADP001,CADP002,CADP003,CADP004 FROM PRT_CADPRO WHERE CADP003 like '" & chave & "%' AND CADP028 = '0' AND CADP026 = 'PRO' order by CADP003"
        End Select
    End Sub
    Private Sub bloqueia_texto(arg)
        Select Case arg
            Case 0
                ' bloqueia a edição dos campos do formulário
                CADP002.ReadOnly = True ' CÓDIGO DA UNIDADE
                CADP003.ReadOnly = True ' NOME DO PROPRIETÁRIO
                CADP004.ReadOnly = True ' NOME DO CONJUGE
                CADP005.ReadOnly = True ' ENDEREÇO
                CADP006.ReadOnly = True ' BAIRRO
                CADP007.ReadOnly = True ' CIDADE
                CADP008.ReadOnly = True ' ESTADO
                CADP009.ReadOnly = True ' CEP
                CADP010.ReadOnly = True ' COMPLEMENTO
                CADP011.ReadOnly = True ' CPF
                CADP012.ReadOnly = True ' CNPJ
                CADP013.ReadOnly = True ' TELEFONE 01
                CADP014.ReadOnly = True ' TELEFONE 02
                CADP015.ReadOnly = True ' TELEFONE 03
                CADP016.ReadOnly = True ' TELEFONE 04
                CADP017.ReadOnly = True ' ENDEREÇO DE EMAIL
                CADP018.Enabled = False ' DATA DO CADASTRO NO SISTEMA
                CADP020.ReadOnly = True ' OBSERVAÇÕES DO CADASTRO
                gb30.Enabled = False ' OPÇÕES DO TIPO DE CADASTRO DA UNIDADE
                P_Autorizados.Enabled = True
                P_LogPortaria.Enabled = True
                P_list.Enabled = True
            Case 1
                ' Desbloqueia os campos para edição
                CADP002.ReadOnly = False ' CÓDIGO DA UNIDADE
                CADP003.ReadOnly = False ' NOME DO PROPRIETÁRIO
                CADP004.ReadOnly = False ' NOME DO CONJUGE
                CADP005.ReadOnly = False ' ENDEREÇO
                CADP006.ReadOnly = False ' BAIRRO
                CADP007.ReadOnly = False ' CIDADE
                CADP008.ReadOnly = False ' ESTADO
                CADP009.ReadOnly = False ' CEP
                CADP010.ReadOnly = False ' COMPLEMENTO
                CADP011.ReadOnly = False ' CPF
                CADP012.ReadOnly = False ' CNPJ
                CADP013.ReadOnly = False ' TELEFONE 01
                CADP014.ReadOnly = False ' TELEFONE 02
                CADP015.ReadOnly = False ' TELEFONE 03
                CADP016.ReadOnly = False ' TELEFONE 04
                CADP017.ReadOnly = False ' ENDEREÇO DE EMAIL
                CADP018.Enabled = True ' DATA DO CADASTRO NO SISTEMA
                CADP020.ReadOnly = True ' OBSERVAÇÕES DO CADASTRO
                gb30.Enabled = True ' OPÇÕES DO TIPO DE CADASTRO DA UNIDADE
                P_Autorizados.Enabled = False
                P_LogPortaria.Enabled = False
                P_list.Enabled = False
            Case 2
                ' Limpa os Campos para uma nova inclusão
                CADP002.Clear() ' CÓDIGO DA UNIDADE
                CADP003.Clear() ' NOME DO PROPRIETÁRIO
                CADP004.Clear() ' NOME DO CONJUGE
                CADP005.Clear() ' ENDEREÇO
                CADP006.Clear() ' BAIRRO
                CADP007.Clear() ' CIDADE
                CADP008.Clear() ' ESTADO
                CADP009.Clear() ' CEP
                CADP010.Clear() ' COMPLEMENTO
                CADP011.Clear() ' CPF
                CADP012.Clear() ' CNPJ
                CADP013.Clear() ' TELEFONE 01
                CADP014.Clear() ' TELEFONE 02
                CADP015.Clear() ' TELEFONE 03
                CADP016.Clear() ' TELEFONE 04
                CADP017.Clear() ' ENDEREÇO DE EMAIL
                CADP018.Value = Data_hoje  ' DATA DO CADASTRO NO SISTEMA
                CADP020.Clear() ' OBSERVAÇÕES DO CADASTRO
            Case 3

            Case 4

            Case 5
                ' LIBERA OS CAMPOS DOS AUTORIZADOS PARA INSERIR DADOS

        End Select
    End Sub
    Private Sub Bloqueio_Botoes(arg)
        Select Case arg
            Case 0
                ' PARTE DO FORMULÁRIO DE CADASTRO
                btnnovo.Enabled = True        ' Botão Novo    ATIVADO
                btnaltera.Enabled = True      ' Botão Alterar ATIVADO
                btncancela.Enabled = False    ' Botão Cancela DESATIVADO
                btnsave.Enabled = False       ' Botão Salvar  DESATIVADO  
                btnexcluir.Enabled = True
                btnPrinter.Enabled = True
                btnFoto.Enabled = True         ' botão para a foto
            Case 1
                ' PARTE DO FORMULÁRIO DE CADASTRO 
                btnnovo.Enabled = False          ' Botão Novo    DESATIVADO
                btnaltera.Enabled = False        ' Botão Altera  DESATIVADO
                btncancela.Enabled = True        ' Botão Cancela ATIVADO
                btnsave.Enabled = True         ' Botão Salvar  ATIVADO
                btnexcluir.Enabled = False       ' Botão Excluir DESATIVADO
                btnPrinter.Enabled = False
                btnFoto.Enabled = False         ' botão para a foto
        End Select
    End Sub

    Private Sub buscadados(arg)
        Select Case arg
            Case 0
                ' BUSCA OS DADOS DOS PROPRIETÁRIOS DAS UNIDADES
                ' CARREGA OS DADOS DOS PROPRIETÁRIOS
                If conexao.State = 0 Then
                    conexao.Open()
                End If
                Dim comando As New MySqlCommand("SELECT CADP018,CADP005,CADP006,CADP007,CADP008,CADP009,CADP010,CADP011,CADP012,CADP013,CADP014,CADP015,CADP016,CADP017,CADP019,CADP020,CADP023,CADP026 FROM PRT_CADPRO WHERE CADP001 = '" & CADP001.Text & "'", conexao)
                Dim leitor As MySqlDataReader = comando.ExecuteReader()
                While leitor.Read()
                    CADP018.Text = IIf(Convert.IsDBNull(leitor("CADP018")) = True, "", leitor("CADP018")) ' DATA DO CADASTRO
                    CADP005.Text = IIf(Convert.IsDBNull(leitor("CADP005")) = True, "", leitor("CADP005")) ' ENDEREÇO
                    CADP006.Text = IIf(Convert.IsDBNull(leitor("CADP006")) = True, "", leitor("CADP006")) ' BAIRRO
                    CADP007.Text = IIf(Convert.IsDBNull(leitor("CADP007")) = True, "", leitor("CADP007")) ' CIDADE
                    CADP008.Text = IIf(Convert.IsDBNull(leitor("CADP008")) = True, "", leitor("CADP008")) ' ESTADO
                    CADP009.Text = IIf(Convert.IsDBNull(leitor("CADP009")) = True, "", leitor("CADP009")) ' CEP
                    CADP010.Text = IIf(Convert.IsDBNull(leitor("CADP010")) = True, "", leitor("CADP010")) ' COMPLEMENTO
                    CADP011.Text = IIf(Convert.IsDBNull(leitor("CADP011")) = True, "", leitor("CADP011")) ' CPF
                    CADP012.Text = IIf(Convert.IsDBNull(leitor("CADP012")) = True, "", leitor("CADP012")) ' CNPJ
                    CADP013.Text = IIf(Convert.IsDBNull(leitor("CADP013")) = True, "", leitor("CADP013")) ' FONE 01
                    CADP014.Text = IIf(Convert.IsDBNull(leitor("CADP014")) = True, "", leitor("CADP014")) ' FONE 02
                    CADP015.Text = IIf(Convert.IsDBNull(leitor("CADP015")) = True, "", leitor("CADP015")) ' FONE 03
                    CADP016.Text = IIf(Convert.IsDBNull(leitor("CADP016")) = True, "", leitor("CADP016")) ' FONE 04
                    CADP017.Text = IIf(Convert.IsDBNull(leitor("CADP017")) = True, "", leitor("CADP017")) ' EMAIL
                    CADP019.Text = IIf(Convert.IsDBNull(leitor("CADP019")) = True, "", leitor("CADP019")) ' tipo de unidade
                    CADP020.Text = IIf(Convert.IsDBNull(leitor("CADP020")) = True, "", leitor("CADP020")) ' OBSERVAÇÕES
                    CADP023.Text = IIf(Convert.IsDBNull(leitor("CADP023")) = True, "REGISTRO", leitor("CADP023")) ' LOCAL DAS FOTOS
                    CADP026.Text = IIf(Convert.IsDBNull(leitor("CADP026")) = True, "", leitor("CADP026")) ' SEGMENTO
                    If CADP023.Text = "REGISTRO" Then
                        img.Image = imgLimpa.Image
                    Else
                        img.ImageLocation = (My.Application.Info.DirectoryPath & "\file\owner\" & CADP023.Text & ".dat")
                    End If
                    Select Case CADP019.Text
                        Case 0
                            RBPro.Checked = True
                        Case 1
                            RBPool.Checked = True
                        Case 2
                            RBSub.Checked = True
                        Case 3
                            rbBaia.Checked = True
                        Case 4
                            RbLocado.Checked = True
                    End Select
                End While
                comando.Cancel()
                leitor.Close()
                conexao.Close()
        End Select
    End Sub
#End Region

#Region "COMPONENTES"
    Private Sub RBPro_CheckedChanged(sender As Object, e As EventArgs) Handles RBPro.CheckedChanged
        CADP019.Text = 0
    End Sub

    Private Sub RBPool_CheckedChanged(sender As Object, e As EventArgs) Handles RBPool.CheckedChanged
        CADP019.Text = 1
    End Sub

    Private Sub RBSub_CheckedChanged(sender As Object, e As EventArgs) Handles RBSub.CheckedChanged
        CADP019.Text = 2
    End Sub

    Private Sub rbBaia_CheckedChanged(sender As Object, e As EventArgs) Handles rbBaia.CheckedChanged
        CADP019.Text = 3
    End Sub

    Private Sub RbLocado_CheckedChanged(sender As Object, e As EventArgs) Handles RbLocado.CheckedChanged
        CADP019.Text = 4
    End Sub

    Private Sub tbpesquisa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbPesquisa.KeyPress
        Select Case busca
            Case 0
                filtro = 0
            Case 1
                filtro = 1
        End Select
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbPesquisa.TextChanged
        chave = ""
        chave = "%" & tbPesquisa.Text
        Call carregalist(0)
    End Sub
    Private Sub rbcodigo_CheckedChanged(sender As Object, e As EventArgs) Handles rbcodigo.CheckedChanged
        tbPesquisa.Clear()
        busca = 0
        tbPesquisa.Focus()
    End Sub
    Private Sub rbnome_CheckedChanged(sender As Object, e As EventArgs) Handles rbnome.CheckedChanged
        tbPesquisa.Clear()
        busca = 1
        tbPesquisa.Focus()
    End Sub


#End Region

#Region "ENTER DO CADASTRO DOS PROPRIETÁRIOS"

    Private Sub tbPesquisa_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbPesquisa.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If pop > 0 Then
                Me.lvDados.Items(0).Selected = True
                lvDados.Select()
            End If
        End If
    End Sub

    Private Sub pesquisa(arg)
        Select Case arg
            Case 0
                ' pesquisa se já existe o código do novo proprietário
                Dim ds As New DataSet
                Dim da As MySqlDataAdapter
                Dim sql As String
                If conexao.State = 0 Then
                    conexao.Open()
                End If
                retorno = Nothing
                da = New MySqlDataAdapter("select CADP001,CADP002 FROM prt_cadpro WHERE CADP002 = '" & CADP002.Text & "' ORDER BY CADP002 ", conexao)
                da.Fill(ds, "prt_cadpro")
                If ds.Tables("prt_cadpro").Rows.Count > 0 Then
                    retorno = ds.Tables("prt_cadpro").Rows(0).Item(1)
                Else
                    retorno = Nothing
                End If
                conexao.Close()
            Case 1

        End Select
    End Sub

    Private Sub CADP002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP002.KeyDown
        '´CÓDIGO DA UNIDADE
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If CADP002.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "É necessário informar o número da casa ou apartamento! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Call pesquisa(0) ' verifica se a descrição já existe na tabela
                If retorno = Nothing Then
                    CADP003.Focus()
                Else
                    If acao = "NOVO" Then
                        MetroFramework.MetroMessageBox.Show(Me, " Unidade informada já existe no cadastro! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        CADP003.Focus()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub CADP003_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP003.KeyDown
        ' NOME DO PROPRIETÁRIO
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If CADP003.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " É necessário informar o nome do proprietário da casa ou apartamento! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CADP003.Focus()
                Exit Sub
            Else
                CADP005.Focus()
            End If
        End If
    End Sub
    Private Sub CADP004_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP004.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If CADP004.TextLength = 0 Then
                If (MetroFramework.MetroMessageBox.Show(Me, " Não foi informado o nome do conjuge! Confirma ? ", "" & legenda & "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = MsgBoxResult.Yes Then
                    CADP005.Focus()
                Else
                    CADP004.Focus()
                End If
            Else
                CADP005.Focus()
            End If
        End If
    End Sub
    Private Sub CADP005_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP005.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If CADP005.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " É ncessessário informar o endereço ! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CADP005.Focus()
            Else
                CADP006.Focus()
            End If
        End If
    End Sub
    Private Sub CADP006_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP006.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If CADP006.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o bairro! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CADP006.Focus()
            Else
                CADP007.Focus()
            End If
        End If
    End Sub
    Private Sub CADP007_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP007.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If CADP007.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe a cidade! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CADP007.Focus()
            Else
                CADP008.Focus()
            End If
        End If
    End Sub
    Private Sub CADP008_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP008.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If CADP008.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " O Estado da federação é necessário informar! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CADP008.Focus()
            Else
                CADP009.Focus()
            End If

        End If
    End Sub
    Private Sub CADP009_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP009.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If CADP009.Text = "     -" Or CADP009.MaskCompleted = False Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o CEP. Se não souber faça uma pesquisa no site dos correios. ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CADP009.Focus()
            Else
                CADP010.Focus()
            End If
        End If
    End Sub
    Private Sub CADP010_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP010.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            CADP011.Focus()
        End If
    End Sub
    Private Sub CADP011_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP011.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If CADP011.MaskCompleted = False Or CADP011.Text = "   .   .   -" Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o número do CPF em caso de pessoa física. Caso contrário preencha com zeros! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CADP011.Focus()
            Else
                CADP012.Focus()
            End If
        End If
    End Sub
    Private Sub CADP012_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP012.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            CADP013.Focus()
        End If
    End Sub
    Private Sub tbCadp013_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP013.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            CADP014.Focus()
        End If
    End Sub
    Private Sub CADP014_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP014.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            CADP015.Focus()
        End If
    End Sub
    Private Sub CADP015_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP015.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            CADP016.Focus()
        End If
    End Sub
    Private Sub CADP016_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP016.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            CADP017.Focus()
        End If
    End Sub
    Private Sub CADP017_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP017.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If CADP017.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe pelo menos uma conta de email para envio de comunicados ao proprietário! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CADP017.Focus()
            Else
                CADP020.Focus()
            End If
        End If
    End Sub
    Private Sub CADP018_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP018.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If CADP018.Value < Data_hoje Then
                MetroFramework.MetroMessageBox.Show(Me, " A data de cadastro não pode ser menor que a data de hoje! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CADP018.Value = Data_hoje
                CADP018.Focus()
            Else
                If CADP018.Value > Data_hoje Then
                    MetroFramework.MetroMessageBox.Show(Me, " A data de cadastro não pode ser maior que a data de hoje! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CADP018.Value = Data_hoje
                    CADP018.Focus()
                Else
                    CADP005.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub CADP020_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP020.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            btnsave.PerformClick()
        End If
    End Sub
#End Region

#Region "AO EFETUAR CLICK NO CAMPO"
    Private Sub CADP002_Click(sender As Object, e As EventArgs) Handles CADP002.Click
        CADP002.SelectAll()
    End Sub
    Private Sub CADP003_Click(sender As Object, e As EventArgs) Handles CADP003.Click
        CADP003.SelectAll()
    End Sub
    Private Sub CADP004_Click(sender As Object, e As EventArgs) Handles CADP004.Click
        CADP004.SelectAll()
    End Sub
    Private Sub CADP005_Click(sender As Object, e As EventArgs) Handles CADP005.Click
        CADP005.SelectAll()
    End Sub
    Private Sub CADP006_Click(sender As Object, e As EventArgs) Handles CADP006.Click
        CADP006.SelectAll()
    End Sub
    Private Sub CADP007_Click(sender As Object, e As EventArgs) Handles CADP007.Click
        CADP007.SelectAll()
    End Sub
    Private Sub CADP008_Click(sender As Object, e As EventArgs) Handles CADP008.Click
        CADP008.SelectAll()
    End Sub
    Private Sub CADP009_Click(sender As Object, e As EventArgs) Handles CADP009.Click
        CADP009.SelectAll()
    End Sub
    Private Sub CADP010_Click(sender As Object, e As EventArgs) Handles CADP010.Click
        CADP010.SelectAll()
    End Sub
    Private Sub CADP011_Click(sender As Object, e As EventArgs) Handles CADP011.Click
        CADP011.SelectAll()
    End Sub
    Private Sub CADP012_Click(sender As Object, e As EventArgs) Handles CADP012.Click
        CADP012.SelectAll()
    End Sub
    Private Sub CADP013_Click(sender As Object, e As EventArgs) Handles CADP013.Click
        CADP013.SelectAll()
    End Sub
    Private Sub CADP014_Click(sender As Object, e As EventArgs) Handles CADP014.Click
        CADP014.SelectAll()
    End Sub
    Private Sub CADP015_Click(sender As Object, e As EventArgs) Handles CADP015.Click
        CADP015.SelectAll()
    End Sub
    Private Sub CADP016_Click(sender As Object, e As EventArgs) Handles CADP016.Click
        CADP016.SelectAll()
    End Sub
    Private Sub CADP017_Click(sender As Object, e As EventArgs) Handles CADP017.Click
        CADP017.SelectAll()
    End Sub
    Private Sub CADP018_Click(sender As Object, e As EventArgs) Handles CADP018.Click
        CADP018.Select()
    End Sub
    Private Sub CADP020_Click(sender As Object, e As EventArgs) Handles CADP020.Click
        CADP020.SelectAll()
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        Call CORLIST(0) ' SELECIONA NO LIST O REGISTRO QUE FOI EDITADO
        Aviso08.CADP026.Text = CADP026.Text
        Aviso08.CADP002.Text = CADP002.Text
        Aviso08.CADP001.Text = CADP001.Text
        Aviso08.CADP003.Text = CADP003.Text
        alterado = 0
        Aviso08.ShowDialog()
        If alterado > 0 Then
            Call carregalist(0) ' popula o grid de cadastro das garagens
            If pop > 0 Then
                Me.lvDados.Items(index).Selected = True
                lvDados.Select()
            End If
        Else
            Me.lvDados.Items(index).Selected = True
            lvDados.Select()
        End If
    End Sub
    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub
    Private Sub btntodos_Click(sender As Object, e As EventArgs) Handles btntodos.Click
        tbPesquisa.Clear()
        filtro = 99
        Call carregalist(0) ' popula o grid de cadastro das garagens
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If
    End Sub
    Private Sub btnnovo_Click(sender As Object, e As EventArgs) Handles btnnovo.Click
        ' NOVO REGISTRO
        acao = "NOVO"
        Tabelas.SelectedIndex = 0
        RBPro.Checked = True
        img.Image = imgLimpa.Image
        Call Bloqueio_Botoes(1) ' bloqueia os botões
        Call bloqueia_texto(1) ' libera os campos dos textos
        Call bloqueia_texto(2) ' limpa os campos para edição
        Call geracod(0)        ' gera um código para cadastro da unidade seguindo o ultimo cadastro realizado
        CADP003.Focus()       ' direciona o focus para o campo de identificação
    End Sub

    Private Sub btnaltera_Click(sender As Object, e As EventArgs) Handles btnaltera.Click
        ' EDITA E ALTERA REGISTRO
        If pop > 0 Then
            Call CORLIST(0)
            Tabelas.SelectedIndex = 0
            acao = "ALTERA"
            ' edita e altera o registro
            Call Bloqueio_Botoes(1) ' bloqueia os botões
            Call bloqueia_texto(1) ' libera os campos dos textos
            If RbLocado.Checked = True Then
                gb30.Enabled = False
            Else
                gb30.Enabled = True
            End If
            CADP018.Enabled = False
            CADP003.Focus()       ' direciona o focus para o campo de identificação
        End If
    End Sub

    Private Sub btncancela_Click(sender As Object, e As EventArgs) Handles btncancela.Click
        ' CANCELA EDIÇÃO
        Tabelas.SelectedIndex = 0
        Call Bloqueio_Botoes(0) ' BLOQUEIO DOS BOTÕES
        Call bloqueia_texto(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS
        Call carregalist(0) ' popula o grid de cadastro das garagens
        If pop > 0 Then
            If acao = "NOVO" Then
                Me.lvDados.Items(0).Selected = True
                lvDados.Select()
            ElseIf acao = "ALTERA" Then
                Me.lvDados.Items(index).Selected = True
                lvDados.Select()
            End If
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        ' GRAVA REGISTRO
        If acao = "NOVO" Then
            ' QUANDO FOI UM NOVO REGISTRO
            Call TestaCampos(0)
            If grava = "Sim" Then
                If (MetroFramework.MetroMessageBox.Show(Me, " Deseja mesmo gravar as informações ? ", "" & legenda & "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = MsgBoxResult.Yes Then
                    Try
                        If conexao.State = ConnectionState.Open Then conexao.Close()
                        Dim sql As String = "INSERT INTO PRT_CADPRO(CADP002,CADP003,CADP004,CADP005,CADP006,CADP007,CADP008,CADP009,CADP010,CADP011,CADP012,CADP013,CADP014,CADP015,CADP016,CADP017,CADP018,CADP020,CADP019,CADP026,CADP027)VALUES('" & CADP002.Text & "','" & CADP003.Text & "','" & CADP004.Text & "','" & CADP005.Text & "','" & CADP006.Text & "','" & CADP007.Text & "','" & CADP008.Text & "','" & CADP009.Text & "','" & CADP010.Text & "','" & CADP011.Text & "','" & CADP012.Text & "','" & CADP013.Text & "','" & CADP014.Text & "','" & CADP015.Text & "','" & CADP016.Text & "','" & CADP017.Text & "','" & Format(CADP018.Value, "yyyy-MM-dd") & "','" & CADP020.Text & "','" & CADP019.Text & "','PRO','PROPRIETÁRIO')"
                        Dim cmd As New MySqlCommand(sql, conexao)
                        conexao.Open()
                        cmd.ExecuteNonQuery()
                        conexao.Close()
                        acao = ""
                        Call Bloqueio_Botoes(0) ' BLOQUEIO DOS BOTÕES
                        Call bloqueia_texto(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS
                        Call carregalist(0) ' popula o grid de cadastro das garagens
                        If pop > 0 Then
                            Me.lvDados.Items(0).Selected = True
                            lvDados.Select()
                        End If
                    Catch ex As Exception
                        MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                        Exit Sub
                    End Try
                Else
                    conexao.Close()
                    acao = ""
                    Call Bloqueio_Botoes(0) ' BLOQUEIO DOS BOTÕES
                    Call bloqueia_texto(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS
                    Call carregalist(0) ' popula o grid de cadastro das garagens
                    If pop > 0 Then
                        Me.lvDados.Items(0).Selected = True
                        lvDados.Select()
                    End If
                End If
            End If
        ElseIf acao = "ALTERA" Then
            '' QUANDO FOR UMA ALTERAÇÃO DE REGISTRO
            Call TestaCampos(0)
            If grava = "Sim" Then
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim sql As String = "UPDATE PRT_CADPRO SET CADP002 = '" & CADP002.Text & "',CADP003 = '" & CADP003.Text & "',CADP004 = '" & CADP004.Text & "',CADP005 = '" & CADP005.Text & "',CADP006 = '" & CADP006.Text & "',CADP007 = '" & CADP007.Text & "',CADP008 = '" & CADP008.Text & "',CADP009 = '" & CADP009.Text & "',CADP010 = '" & CADP010.Text & "',CADP011 = '" & CADP011.Text & "',CADP012 = '" & CADP012.Text & "',CADP013 = '" & CADP013.Text & "',CADP014 = '" & CADP014.Text & "',CADP015 = '" & CADP015.Text & "',CADP016 = '" & CADP016.Text & "',CADP017 = '" & CADP017.Text & "',CADP019 = '" & CADP019.Text & "',CADP020 = '" & CADP020.Text & "' WHERE CADP001 = '" & CADP001.Text & "'"
                Dim cmd As New MySqlCommand(sql, conexao)
                conexao.Open()
                cmd.ExecuteNonQuery()
                MetroFramework.MetroMessageBox.Show(Me, "Registro alterado com sucesso!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                conexao.Close()
                acao = ""
                Call Bloqueio_Botoes(0) ' BLOQUEIO DOS BOTÕES
                Call bloqueia_texto(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS
                Call carregalist(0) ' popula o grid de cadastro das garagens
                If pop > 0 Then
                    Me.lvDados.Items(index).Selected = True
                    lvDados.Select()
                End If
            End If
        End If
    End Sub

    Private Sub btnexcluir_Click(sender As Object, e As EventArgs) Handles btnexcluir.Click
        ' EXCLUIR REGISTRO

        If pop > 0 Then
            Call CORLIST(0)
            Tabelas.SelectedIndex = 0
            If (MetroFramework.MetroMessageBox.Show(Me, " Deseja mesmo excluir o registro:  " & CADP003.Text & " ?", "" & legenda & "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = MsgBoxResult.Yes Then
                If conexao.State = ConnectionState.Open Then conexao.Close()
                conexao.Open()
                Dim st = "UPDATE prt_cadpro set CADP028 = '1' WHERE CADP002 = '" & CADP002.Text & "'"
                Dim cmd As New MySqlCommand(st, conexao)
                cmd.ExecuteNonQuery()
                conexao.Close()
                MetroFramework.MetroMessageBox.Show(Me, " O registro foi excluído definitivamente!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Call carregalist(0) ' popula o grid de cadastro das garagens
                If pop > 0 Then
                    Me.lvDados.Items(0).Selected = True
                    lvDados.Select()
                End If
            End If
        End If
    End Sub
    Private Sub btnPrinter_Click(sender As Object, e As EventArgs) Handles btnPrinter.Click
        ' RELATÓRIO
        Call CORLIST(0)
        frmRel004.CADP002.Text = CADP002.Text
        frmRel004.CADP003.Text = CADP003.Text
        frmRel004.ShowDialog()
    End Sub

    Private Sub btnLoca_Click(sender As Object, e As EventArgs)
        ' EXIB REGISTRO DE LOCAÇÃO
    End Sub
#End Region

#Region "TESTA OS CAMPOS"
    Private Sub TestaCampos(arg)
        Select Case arg
            Case 0
                ' TESTA OS CAMPOS DA INCLUSÃO E ALTERAÇÃO DO PROPRIETÁRIO
                If CADP002.TextLength = 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, "É necessário informar o número da casa ou apartamento! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    grava = "Não"
                    CADP002.Focus()
                    Exit Sub
                End If
                If CADP003.TextLength = 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, " É necessário informar o nome do proprietário da casa ou apartamento! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    grava = "Não"
                    CADP003.Focus()
                    Exit Sub
                End If

                If CADP005.TextLength = 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, " É ncessessário informar o endereço ! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    grava = "Não"
                    CADP005.Focus()
                    Exit Sub
                End If
                If CADP006.TextLength = 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, " Informe o bairro! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    grava = "Não"
                    CADP006.Focus()
                    Exit Sub
                End If
                If CADP007.TextLength = 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, " Informe a cidade! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    grava = "Não"
                    CADP007.Focus()
                    Exit Sub
                End If
                If CADP008.TextLength = 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, " O Estado da federação é necessário informar! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    grava = "Não"
                    CADP008.Focus()
                    Exit Sub
                End If
                If CADP009.Text = "     -" Or CADP009.MaskCompleted = False Then
                    MetroFramework.MetroMessageBox.Show(Me, " Informe o CEP. Se não souber faça uma pesquisa no site dos correios. ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    grava = "Não"
                    CADP009.Focus()
                    Exit Sub
                End If
                If CADP011.MaskCompleted = False Or CADP011.Text = "   .   .   -" Then
                    MetroFramework.MetroMessageBox.Show(Me, " Informe o número do CPF em caso de pessoa física. Caso contrário preencha com zeros! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    grava = "Não"
                    CADP011.Focus()
                    Exit Sub
                End If
                'If CADP012.MaskCompleted = False Or CADP012.Text = "  .   .   /    -" Then
                '    MetroFramework.MetroMessageBox.Show(Me, " Se tratando de empresa o CNPJ precisa ser preenchido, caso contrário preencha com zeros ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    grava = "Não"
                '    CADP012.Focus()
                '    Exit Sub
                'End If
                If CADP017.TextLength = 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, " Informe pelo menos uma conta de email para envio de comunicados ao proprietário! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    grava = "Não"
                    CADP017.Focus()
                    Exit Sub
                End If
                If acao = "NOVO" Then
                    If CADP018.Value < Data_hoje Then
                        MetroFramework.MetroMessageBox.Show(Me, " A data de cadastro não pode ser menor que a data de hoje! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        CADP018.Value = Data_hoje
                        CADP018.Focus()
                        grava = "Não"
                        Exit Sub
                    End If
                    If CADP018.Value > Data_hoje Then
                        MetroFramework.MetroMessageBox.Show(Me, " A data de cadastro não pode ser maior que a data de hoje! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        CADP018.Value = Data_hoje
                        grava = "Não"
                        CADP018.Focus()
                        Exit Sub
                    End If
                End If
                Call pesquisa(0)
                If acao = "NOVO" Then
                    If retorno = Nothing Then
                        grava = "Sim"
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, " Já existe uma vaga com essa identificação! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        CADP002.Focus()
                        grava = "Não"
                        Exit Sub
                    End If
                Else
                    grava = "Sim"
                End If
            Case 1

        End Select
    End Sub
#End Region



End Class
























