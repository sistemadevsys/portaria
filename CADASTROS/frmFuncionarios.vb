Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmFuncionarios
    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Protected regionHandle As IntPtr
#Region "VARIÁVEIS"
    Dim sql, chave, texto, sqlG As String
    Dim filtro, index, indexFoto As Integer
    Dim data_hoje As DateTime = DateAndTime.Now
    Dim bt() As Byte
    Dim mt As MemoryStream
    Dim opc As Integer
    Dim acao, arquivo As String
    Dim Valida As Integer
    Dim FUN024, IMG006 As New TextBox
    Dim frmPanel As Panel
    Dim pop As Integer

#End Region

#Region "START DO FORMULÁRIO"
    Private Sub frmClose_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
    Private Sub frmPadrao_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
        If e.KeyCode = Keys.F6 Then
            ' BOTÃO SALVAR O REGISTRO
            If btnVoltar.Enabled = True Then btnVoltar.PerformClick()
        End If
        If e.KeyCode = Keys.F7 Then
            ' BOTÃO SALVAR O REGISTRO
            If btnFoto.Enabled = True Then btnFoto.PerformClick()
        End If
    End Sub
    Private Sub frmCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmFuncionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        redondo(0, 0, tarja, 20, 20)
        redondo(0, 0, Panel1, 20, 20)
        Me.CancelButton = btnhome
        Panel3.Visible = True
        arquivo = "ATIVO"
        FUN022.ForeColor = Color.Green
        IMG006.Text = "FUN"
        filtro = 99 ' VARIAVEL QUE ACIONA O FILTRO PARA MOSTRAR TODOS OS REGISTROS
        Call Bloqueio_Botoes(0) ' BLOQUEIO DOS BOTÕES
        Call bloqueia_textBox(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS
        Call CarregaList(0) ' popula o grid de cadastro das garagens
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If
    End Sub
#End Region

#Region "FUNÇÕES"
    Private Sub redondo(arg1, arg2, componente, arg3, arg4)
        regionHandle = New IntPtr(CreateRoundRectRgn(arg1, arg2, componente.Width, componente.Height, arg3, arg4))
        componente.Region = Region.FromHrgn(regionHandle)
        componente.Region.ReleaseHrgn(regionHandle)
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


    Private Sub Bloqueio_Botoes(arg)
        Select Case arg
            Case 0
                ' PARTE DO FORMULÁRIO DE CADASTRO
                btnnovo.Enabled = True        ' Botão Novo    ATIVADO
                btnaltera.Enabled = True      ' Botão Alterar ATIVADO
                btncancela.Enabled = False    ' Botão Cancela DESATIVADO
                btnsave.Enabled = False       ' Botão Salvar  DESATIVADO  
                btnexcluir.Enabled = True
                btnFoto.Enabled = True
                btnDemissao.Enabled = True
                btnTransf.Enabled = True
            Case 1
                ' PARTE DO FORMULÁRIO DE CADASTRO 
                btnnovo.Enabled = False          ' Botão Novo    DESATIVADO
                btnaltera.Enabled = False        ' Botão Altera  DESATIVADO
                btncancela.Enabled = True        ' Botão Cancela ATIVADO
                btnsave.Enabled = True         ' Botão Salvar  ATIVADO
                btnexcluir.Enabled = False       ' Botão Excluir DESATIVADO
                btnFoto.Enabled = False
                btnDemissao.Enabled = False
                btnTransf.Enabled = False
            Case 2
                btnnovo.Enabled = False         ' Botão Novo    ATIVADO
                btnaltera.Enabled = False       ' Botão Alterar ATIVADO
                btncancela.Enabled = False    ' Botão Cancela DESATIVADO
                btnsave.Enabled = False       ' Botão Salvar  DESATIVADO  
                btnexcluir.Enabled = False
                btnFoto.Enabled = False
                btnDemissao.Enabled = False
        End Select
    End Sub
    Public Sub Limpar_textbox(ByVal controlP As Control)
        Dim ctl As Control
        For Each ctl In controlP.Controls
            If TypeOf ctl Is TextBox Then
                DirectCast(ctl, TextBox).Text = String.Empty
            ElseIf ctl.Controls.Count > 0 Then
                Limpar_textbox(ctl)
            End If
        Next
    End Sub
    Public Sub Limpar_mask(ByVal controlP As Control)
        Dim ctl As Control
        For Each ctl In controlP.Controls
            If TypeOf ctl Is MaskedTextBox Then
                DirectCast(ctl, MaskedTextBox).Text = String.Empty
            ElseIf ctl.Controls.Count > 0 Then
                Limpar_mask(ctl)
            End If
        Next
    End Sub
    Private Sub geracod(arg)
        Select Case arg
            Case 0
                ' GERA O CÓDIGO PARA UM NOVO FUNCIONÁRIO
                Dim sqlmaior As String
                If conexao.State = 0 Then
                    conexao.Open()
                End If
                sqlmaior = "Select Max(FUN002) From prt_cadfun"
                Dim cmd As New MySqlCommand(sqlmaior, conexao)
                Dim maior As Integer
                If IsDBNull(cmd.ExecuteScalar) Then
                    maior = 1
                Else
                    maior = cmd.ExecuteScalar + 1
                End If
                cmd.ExecuteNonQuery()
                FUN002.Text = Format(maior, "000000")
                cmd.Dispose()
                conexao.Close()
            Case 1

        End Select
    End Sub
    Private Sub bloqueia_textBox(arg)
        Select Case arg
            Case 0
                ' BLOQUEIO DOS TEXTBOX PARA EDIÇÃO
                FUN003.ReadOnly = True  ' NOME 
                FUN004.Enabled = False  ' CARGO
                FUN005.Enabled = False  ' SETOR
                FUN006.Enabled = False  ' DATA DE ADMISSÃO
                FUN007.Enabled = False  ' DATA DE DEMISSÃO
                FUN008.ReadOnly = True  ' CPF
                FUN009.ReadOnly = True  ' RG
                FUN010.ReadOnly = True  ' EMAIL
                FUN011.ReadOnly = True  ' FONE 01
                FUN012.ReadOnly = True  ' FONE 02
                FUN015.ReadOnly = True  ' OBSERVAÇÕES
                FUN016.ReadOnly = True  ' ENDEREÇO
                FUN017.ReadOnly = True  ' BAIRRO
                FUN018.ReadOnly = True  ' CIDADE
                FUN019.ReadOnly = True  ' ESTADO
                FUN020.ReadOnly = True  ' CEP
                FUN021.ReadOnly = True  ' COMPLEMENTO
                FUN025.Enabled = False ' DATA DO CADASTRO
                FUN007.Visible = False
                FUN027.Visible = False
                gb04.Text = ""
                gb06.Text = ""
                PMovimento.Enabled = True
                P_list.Enabled = True
            Case 1
                FUN003.ReadOnly = False   ' NOME 
                FUN004.Enabled = True   ' CARGO
                FUN005.Enabled = True   ' SETOR
                FUN006.Enabled = True   ' DATA DE ADMISSÃO
                FUN007.Enabled = False  ' DATA DE DEMISSÃO
                FUN008.ReadOnly = False   ' CPF
                FUN009.ReadOnly = False   ' RG
                FUN010.ReadOnly = False   ' EMAIL
                FUN011.ReadOnly = False   ' FONE 01
                FUN012.ReadOnly = False   ' FONE 02
                FUN015.ReadOnly = False   ' OBSERVAÇÕES
                FUN016.ReadOnly = False   ' ENDEREÇO
                FUN017.ReadOnly = False   ' BAIRRO
                FUN018.ReadOnly = False   ' CIDADE
                FUN019.ReadOnly = False   ' ESTADO
                FUN020.ReadOnly = False   ' CEP
                FUN021.ReadOnly = False   ' COMPLEMENTO
                FUN025.Enabled = False   ' DATA DO CADASTRO
                PMovimento.Enabled = False
                P_list.Enabled = False
        End Select
    End Sub
    Private Sub filtrar()
        Select Case filtro
            Case 99 ' TODOS OS REGISTROS
                sql = "SELECT FUN002,FUN003,FUN004,FUN005 from prt_cadfun WHERE FUN022 = '" & arquivo & "' and FUN026 = '0' and FUN028 = 'FUN' order by FUN003"
            Case 1 ' FILTRA PELO NOME DO PROPRIETÁRIO
                sql = "SELECT FUN002,FUN003,FUN004,FUN005 FROM prt_cadfun WHERE FUN003 like '" & chave & "%' and FUN022 = '" & arquivo & "' and FUN026 = '0' and FUN028 = 'FUN' order by FUN003"
        End Select
    End Sub
    Private Sub CarregaList(arg)
        Select Case arg
            Case 0
                ' Lista dos funcionários do empreendimento
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
                    item = lvDados.Items.Add(leitor("FUN002").ToString) ' 0 ID
                    item.SubItems.Add(leitor("FUN003").ToString)       ' 1 NUMERAÇÃO DA UNIDADE
                    item.SubItems.Add(leitor("FUN004"))                ' 2 CARGO
                    item.SubItems.Add(leitor("FUN005"))                ' 3 SETOR
                    pop += 1 ' faz a contagem dos registros no listview
                Loop
                If pop = 0 Then
                    btnFoto.Visible = False
                Else
                    btnFoto.Visible = True
                End If
                conexao.Close() ' fecha a conexação com o banco de dados
                leitor.Dispose()
                'Call corlist(0)
        End Select
    End Sub

    Private Sub lvdados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDados.SelectedIndexChanged
        Try
            If lvDados.SelectedItems.Count > 0 Then
                index = lvDados.Items.Item(lvDados.SelectedIndices(0)).Index
                Me.FUN002.Text = Convert.ToString(lvDados.Items(lvDados.SelectedIndices(0)).Text)
                Me.FUN003.Text = Me.lvDados.SelectedItems(0).SubItems(1).Text
                Me.FUN004.Text = Me.lvDados.SelectedItems(0).SubItems(2).Text
                Me.FUN005.Text = Me.lvDados.SelectedItems(0).SubItems(3).Text
                Call buscadados(0) ' Busca os dados do cadastro
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub buscadados(arg)
        Select Case arg
            Case 0
                ' BUSCA OS DADOS DA TABELA PRT_CADFUN
                If conexao.State = 0 Then
                    conexao.Open()
                End If
                Dim comando As New MySqlCommand("select * from prt_cadfun where FUN002 = '" & FUN002.Text & "'", conexao)
                Dim leitor As MySqlDataReader = comando.ExecuteReader()
                While leitor.Read()

                    Dim istatus As String = leitor("FUN022")
                    If istatus = "ATIVO" Then
                        FUN007.Visible = False
                        FUN027.Visible = False
                        gb04.Text = ""
                        gb06.Text = ""
                    Else
                        gb04.Text = "Data de Demissão:"
                        gb06.Text = "Observações sobre a Demissão:"
                        FUN007.Visible = True
                        FUN027.Visible = True
                        FUN007.Text = IIf(Convert.IsDBNull(leitor("FUN007")) = True, data_hoje, leitor("FUN007")) ' DATA DE DEMISSÃO
                        FUN027.Text = IIf(Convert.IsDBNull(leitor("FUN027")) = True, data_hoje, leitor("FUN027")) ' OBSERVAÇÕES SOBRE A DEMISSÃO
                    End If

                    FUN006.Text = IIf(Convert.IsDBNull(leitor("FUN006")) = True, "", leitor("FUN006")) ' DATA DE ADMISSÃO
                    FUN008.Text = IIf(Convert.IsDBNull(leitor("FUN008")) = True, "", leitor("FUN008")) ' CPF
                    FUN009.Text = IIf(Convert.IsDBNull(leitor("FUN009")) = True, "", leitor("FUN009")) ' RG
                    FUN010.Text = IIf(Convert.IsDBNull(leitor("FUN010")) = True, "", leitor("FUN010")) ' EMAIL
                    FUN011.Text = IIf(Convert.IsDBNull(leitor("FUN011")) = True, "", leitor("FUN011")) ' FONE 01
                    FUN012.Text = IIf(Convert.IsDBNull(leitor("FUN012")) = True, "", leitor("FUN012")) ' FONE 02
                    FUN015.Text = IIf(Convert.IsDBNull(leitor("FUN015")) = True, "", leitor("FUN015")) ' OBSERVAÇÃO
                    FUN016.Text = IIf(Convert.IsDBNull(leitor("FUN016")) = True, "", leitor("FUN016")) ' ENDEREÇO
                    FUN017.Text = IIf(Convert.IsDBNull(leitor("FUN017")) = True, "", leitor("FUN017")) ' BAIRRO
                    FUN018.Text = IIf(Convert.IsDBNull(leitor("FUN018")) = True, "", leitor("FUN018")) ' CIDADE
                    FUN019.Text = IIf(Convert.IsDBNull(leitor("FUN019")) = True, "", leitor("FUN019")) ' ESTADO
                    FUN020.Text = IIf(Convert.IsDBNull(leitor("FUN020")) = True, "", leitor("FUN020")) ' CEP
                    FUN021.Text = IIf(Convert.IsDBNull(leitor("FUN021")) = True, "", leitor("FUN021")) ' COMPLEMENTO
                    FUN022.Text = IIf(Convert.IsDBNull(leitor("FUN022")) = True, "", leitor("FUN022")) ' STATUS
                    FUN024.Text = IIf(Convert.IsDBNull(leitor("FUN024")) = True, "", leitor("FUN024")) ' STATUS
                    FUN025.Text = IIf(Convert.IsDBNull(leitor("FUN025")) = True, "", leitor("FUN025")) ' STATUS

                    FUN004.Text = UCase(FUN004.Text)  ' CONVERTE O CAMPO EM LETRAS MAISCULAS
                    FUN005.Text = UCase(FUN005.Text)  ' CONVERTE O CAMPO EM LETRAS MAISCULAS

                    img.ImageLocation = (My.Application.Info.DirectoryPath & "\file\employee\" & FUN024.Text & ".dat")

                End While
                comando.Cancel()
                leitor.Close()
                conexao.Close()
            Case 1
                ' faz a leitura da tabela prt_cargo (usa DataSet tipado)
                Dim ds As New DataSet
                Dim dr As DataRow
                Dim dt As New DataTable
                Dim sql = "select * from prt_cargo order by CARG02"
                Dim adptr As New MySqlDataAdapter(sql, conexao)
                adptr.Fill(ds, "prt_cargo")
                dt = ds.Tables(0)
                FUN004.Items.Clear()
                For Each dr In dt.Rows
                    FUN004.Items.Add(dr.Item("CARG02"))
                Next
            Case 2
                ' faz a leitura da tabela prt_setor
                Dim ds As New DataSet
                Dim dr As DataRow
                Dim dt As New DataTable
                Dim sql = "select * from prt_setor order by SET02"
                Dim adptr As New MySqlDataAdapter(sql, conexao)
                adptr.Fill(ds, "prt_setor")
                dt = ds.Tables(0)
                FUN005.Items.Clear()
                For Each dr In dt.Rows
                    FUN005.Items.Add(dr.Item("SET02"))
                Next
        End Select
    End Sub
    Private Sub tratatab()
        Select Case Tabelas.SelectedTab.Name
            Case "Tab0"
                Panel3.Visible = True
                Me.Text = "Cadastro e Manutenção de Funcionários"
                If alterado = 99 Then
                    Call CarregaList(0) ' se foi feita alteração da foto do perfil carrega novamente os dados
                End If
                If pop > 0 Then
                    Me.lvDados.Items(index).Selected = True
                    lvDados.Select()
                End If
            Case "Tab1"
                Me.Text = "Log de Movimentação na portaria"
                Panel3.Visible = False

                Repositorio.FUN002.Text = FUN002.Text
                Repositorio.FUN003.Text = FUN003.Text

                frmPanel = PMovimento
                frmPanel.Controls.Clear() ' LIMPA OS DADOS DO FORMULÁRIODE AUTORIZADOS QUE VAI ABRIR DENTRO DO PAINEL

                abriform(Of frmLogMovim01)() ' ABRE O FORMULÁRIO DENTRO DO PAINEL

        End Select
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub btnTransf_Click(sender As Object, e As EventArgs) Handles btnTransf.Click
        frmEmpresaTrans.EMP002.Text = "000000"
        frmEmpresaTrans.EMP003.Text = iReg002
        Repositorio.FUN002.Text = FUN002.Text
        frmEmpresaTrans.tarja.Text = "Transferir:  " & FUN002.Text & " - " & FUN003.Text
        frmEmpresaTrans.tarja.ForeColor = Color.Yellow
        alterado = 0

        frmEmpresaTrans.ShowDialog() ' abre o formulário 

        If alterado > 0 Then

            Call Limpar_textbox(Me)  ' limpa os campos para edição
            Call Limpar_mask(Me)     ' limpa os campos com mascara

            Call CarregaList(0) ' popula o grid de cadastro das garagens
            If pop > 0 Then
                Me.lvDados.Items(0).Selected = True
                lvDados.Select()
            End If
        End If
    End Sub
    Private Sub btnvoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        alterado = 0
        frmFiltraFun.ShowDialog()
        tbPesquisa.Clear()
        If alterado = 10 Then
            ' FILTRO DOS ATIVOS
            tbPesquisa.Clear()
            arquivo = "ATIVO"
            FUN022.ForeColor = Color.Green
            filtro = 99
            Call Bloqueio_Botoes(0) ' BLOQUEIA TODOS OS BOTÕES
            Call Limpar_textbox(Me)  ' limpa os campos para edição
            Call Limpar_mask(Me)     ' limpa os campos com mascara
            btnDemissao.Visible = True
            Call CarregaList(0) ' popula o grid de cadastro das garagens
            If pop > 0 Then
                Me.lvDados.Items(0).Selected = True
                lvDados.Select()
            End If
        ElseIf alterado = 20 Then
            ' FILTRO DOS DEMITIDOS
            tbPesquisa.Clear()
            arquivo = "DESLIGADO"
            FUN022.ForeColor = Color.Red
            filtro = 99
            Call Bloqueio_Botoes(2) ' BLOQUEIA TODOS OS BOTÕES
            Call Limpar_textbox(Me)  ' limpa os campos para edição
            Call Limpar_mask(Me)     ' limpa os campos com mascara
            btnDemissao.Visible = False
            FUN002.Text = ""
            FUN022.Text = ""
            Call CarregaList(0) ' popula o grid de cadastro das garagens
            If pop > 0 Then
                Me.lvDados.Items(0).Selected = True
                lvDados.Select()
            End If
        End If
    End Sub

    Private Sub addCargo_Click(sender As Object, e As EventArgs) Handles addCargo.Click
        ' botão para adicionar cargo
        If FUN004.Enabled = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Status do formulário não permite a edição do cargo", "" & sistema & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            alterado = 0
            frmCargo.ShowDialog()
            If alterado > 0 Then
                Call buscadados(1) ' recarrega o combobox FUN004
            End If
        End If
    End Sub
    Private Sub addSetor_Click(sender As Object, e As EventArgs) Handles addSetor.Click
        ' botão para adicionar setor
        If FUN005.Enabled = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Status do formulário não permite a edição do setor", "" & sistema & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            alterado = 0
            frmSetor.ShowDialog()
            If alterado > 0 Then
                Call buscadados(2) ' recarrega o combobox FUN005
            End If
        End If
    End Sub
    Private Sub btnnovo_Click(sender As Object, e As EventArgs) Handles btnnovo.Click
        ' INCLUIR NOVO FUNCIONÁRIO
        acao = "NOVO"
        Valida = 0
        Tabelas.SelectedIndex = 0
        img.Image = imgLimpa.Image
        '========= BLOCO DE PROCEDIMENTOS PARA NOVA INCLUSÃO =============================================================
        Call Bloqueio_Botoes(1)  ' bloqueia os botões
        Call bloqueia_textBox(1) ' libera os campos dos textos
        Call Limpar_textbox(Me)  ' limpa os campos para edição
        Call Limpar_mask(Me)     ' limpa os campos com mascara
        Call buscadados(1)       ' carrega relação de cargos
        Call buscadados(2)       ' carrega relação de setores da empresa
        Call geracod(0)          ' gera um código para cadastro da unidade seguindo o ultimo cadastro realizado
        '=================================================================================================================
        FUN022.Text = "ATIVO"
        FUN025.Text = Format(data_hoje, "dd/MM/yyyy")
        FUN006.Value = Format(data_hoje, "dd/MM/yyyy")
        FUN003.Focus()           ' direciona o focus para o campo de identificação

    End Sub
    Private Sub btnaltera_Click(sender As Object, e As EventArgs) Handles btnaltera.Click
        ' EDITA E ALTERA FUNCIONÁRIO
        acao = "ALTERA"
        Valida = 0
        Tabelas.SelectedIndex = 0
        '========= BLOCO DE PROCEDIMENTOS PARA NOVA INCLUSÃO =============================================================
        Call Bloqueio_Botoes(1)  ' bloqueia os botões
        Call bloqueia_textBox(1) ' libera os campos dos textos
        Call buscadados(1)       ' carrega relação de cargos
        Call buscadados(2)       ' carrega relação de setores da empresa
        '=================================================================================================================
        FUN003.Focus()           ' direciona o focus para o campo de identificação
    End Sub
    Private Sub btncancela_Click(sender As Object, e As EventArgs) Handles btncancela.Click
        ' CANCELA AÇÃO DE EDIÇÃO E INCLUSÃO
        filtro = 99 ' VARIAVEL QUE ACIONA O FILTRO PARA MOSTRAR TODOS OS REGISTROS
        Call Bloqueio_Botoes(0) ' BLOQUEIO DOS BOTÕES
        Call bloqueia_textBox(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS
        Call CarregaList(0) ' popula o grid de cadastro das garagens
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
        ' SALVA NA TABELA
        Call Testa_Preenchimento() ' TESTA O PREENCHIMENTO DOS CAMPOS OU TEXTBOX
        If Valida > 0 Then
            If acao = "NOVO" Then
                texto = "Registro efetuado com sucesso"
                sql = "insert into prt_cadfun(FUN002,FUN003,FUN004,FUN005,FUN006,FUN008,FUN009,FUN010,FUN011,FUN012,FUN015,FUN016,FUN017,FUN018,FUN019,FUN020,FUN021,FUN022,FUN023,FUN024,FUN025,FUN026,FUN028,EMP002)values('" & FUN002.Text & "','" & FUN003.Text & "','" & FUN004.Text & "','" & FUN005.Text & "','" & Format(FUN006.Value, "yyyy-MM-dd") & "','" & FUN008.Text & "','" & FUN009.Text & "','" & FUN010.Text & "','" & FUN011.Text & "','" & FUN012.Text & "','" & FUN015.Text & "','" & FUN016.Text & "','" & FUN017.Text & "','" & FUN018.Text & "','" & FUN019.Text & "','" & FUN020.Text & "','" & FUN021.Text & "','ATIVO','0','REGISTRO','" & Format(FUN025.Value, "yyyy-MM-dd") & "','0','FUN','000000')"
            Else
                texto = "Alteração efetuada com sucesso"
                sql = "update prt_cadfun set  FUN003 = '" & FUN003.Text & "', FUN004 = '" & FUN004.Text & "', FUN005 = '" & FUN005.Text & "', FUN006 = '" & Format(FUN006.Value, "yyyy-MM-dd") & "', FUN008 = '" & FUN008.Text & "', FUN009 = '" & FUN009.Text & "', FUN010 = '" & FUN010.Text & "', FUN011 = '" & FUN011.Text & "', FUN012 = '" & FUN012.Text & "', FUN015 = '" & FUN015.Text & "', FUN016 = '" & FUN016.Text & "', FUN017 = '" & FUN017.Text & "', FUN018 = '" & FUN018.Text & "', FUN019 = '" & FUN019.Text & "', FUN020 = '" & FUN020.Text & "', FUN021 = '" & FUN021.Text & "' WHERE FUN002 = '" & FUN002.Text & "'"
            End If
            Try
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim cmd As New MySqlCommand(sql, conexao)
                conexao.Open()
                cmd.ExecuteNonQuery()
                MetroFramework.MetroMessageBox.Show(Me, texto, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                conexao.Close()
                acao = ""
                filtro = 99 ' VARIAVEL QUE ACIONA O FILTRO PARA MOSTRAR TODOS OS REGISTROS
                Call Bloqueio_Botoes(0) ' BLOQUEIO DOS BOTÕES
                Call bloqueia_textBox(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS
                Call CarregaList(0) ' RECARREGA A RELAÇÃO DE FUNCIONÁRIOS
                If pop > 0 Then
                    If acao = "NOVO" Then
                        Me.lvDados.Items(0).Selected = True
                        lvDados.Select()
                        lvDados.Focus()
                    Else
                        Me.lvDados.Items(index).Selected = True
                        lvDados.Select()
                        lvDados.Focus()
                    End If
                End If
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub btnexcluir_Click(sender As Object, e As EventArgs) Handles btnexcluir.Click
        ' EXCLUIR O FUNCIONÁRIO
        Tabelas.SelectedIndex = 0
        If (MetroFramework.MetroMessageBox.Show(Me, "Esse procedimento exclui o registro fisíco do funcionário. Se o funcionário não pertencer mais ao quadro de funcionários da empresa, utilize a opção de demissão com o botão para essa finalidade. Mesmo assim deseja prosseguir com a exclusão ? ", "" & legenda & "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error)) = MsgBoxResult.Yes Then
            If conexao.State = ConnectionState.Open Then conexao.Close()
            Dim sql As String = "update prt_cadfun set FUN026 = '1' WHERE FUN002 = '" & FUN002.Text & "'"
            Dim cmd As New MySqlCommand(sql, conexao)
            conexao.Open()
            cmd.ExecuteNonQuery()
            MetroFramework.MetroMessageBox.Show(Me, "Registro excluido! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            conexao.Close()
            acao = ""
            filtro = 99 ' VARIAVEL QUE ACIONA O FILTRO PARA MOSTRAR TODOS OS REGISTROS
            Call Bloqueio_Botoes(0) ' BLOQUEIO DOS BOTÕES
            Call bloqueia_textBox(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS
            Call CarregaList(0) ' RECARREGA A RELAÇÃO DE FUNCIONÁRIOS
            If pop > 0 Then
                Me.lvDados.Items(index).Selected = True
                lvDados.Select()
                lvDados.Focus()
            End If
        End If
    End Sub
    Private Sub btnsair_Click(sender As Object, e As EventArgs)
        ' SAIR DO FORMULÁRIO
        ' ENCERRA O FORMULÁRIO
        Dispose()
        Me.Close()
    End Sub
    Private Sub btnDemissao_Click(sender As Object, e As EventArgs) Handles btnDemissao.Click
        Tabelas.SelectedIndex = 0
        alterado = 0
        frmDemissao.FUN002.Text = FUN002.Text
        frmDemissao.FUN003.Text = FUN003.Text
        frmDemissao.ShowDialog()
        If alterado > 0 Then
            Call CarregaList(0) ' se foi feita alteração da foto do perfil carrega novamente os dados
            If pop > 0 Then
                Me.lvDados.Items(0).Selected = True
                lvDados.Select()
            End If
        Else
            If pop > 0 Then
                Me.lvDados.Items(index).Selected = True
                lvDados.Select()
            End If
        End If
    End Sub

#End Region

#Region "COMPONENTES"
    Private Sub Tabelas_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles Tabelas.SelectedIndexChanged
        Call tratatab()
    End Sub

    Private Sub tbPesquisa_TextChanged(sender As Object, e As EventArgs) Handles tbPesquisa.TextChanged
        chave = ""
        chave = "%" & tbPesquisa.Text
        Call CarregaList(0)
    End Sub

    Private Sub tbpesquisa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbPesquisa.KeyPress
        filtro = 1
    End Sub

#End Region

#Region "TESTA PREENCHIMENTO DOS TEXTBOX ANTES DA GRAVAÇÃO"
    Private Sub Testa_Preenchimento()
        Valida = 0
        If FUN003.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o nome do funcionário! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN003.Focus()
            Valida = 0
            Exit Sub
        End If
        If Me.FUN004.FindString(FUN004.Text) = -1 Or FUN004.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " Cargo inválido! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN004.Focus()
            Valida = 0
            Exit Sub
        End If
        If Me.FUN005.FindString(FUN005.Text) = -1 Or FUN005.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " Setor inválido! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN005.Focus()
            Valida = 0
            Exit Sub
        End If
        If FUN016.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o endereço! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN016.Focus()
            Valida = 0
            Exit Sub
        End If
        If FUN017.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o bairro! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN017.Focus()
            Valida = 0
            Exit Sub
        End If
        If FUN018.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe a cidade! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN018.Focus()
            Valida = 0
            Exit Sub
        End If
        If FUN019.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o estado (UF)! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN019.Focus()
            Valida = 0
            Exit Sub
        End If
        If FUN020.MaskCompleted = False Or FUN020.Text = "     -" Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o CEP da cidade! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN020.Focus()
            Valida = 0
            Exit Sub
        End If
        If FUN008.MaskCompleted = False Or FUN008.Text = "   .   .   -" Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o número do CPF! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN008.Focus()
            Valida = 0
            Exit Sub
        End If
        If FUN009.MaskCompleted = False Or FUN009.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o número do RG! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN009.Focus()
            Valida = 0
            Exit Sub
        End If
        If FUN011.MaskCompleted = False Or FUN011.Text = "(  )    -    " Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe um número de telefone fixo! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN011.Focus()
            Valida = 0
            Exit Sub
        End If
        Valida = 10
    End Sub
#End Region

#Region "SELEÇÃO DO TEXTBOX"
    Private Sub FUN003_Click(sender As Object, e As EventArgs) Handles FUN003.Click
        FUN003.SelectAll()
    End Sub
    Private Sub FUN004_Click(sender As Object, e As EventArgs) Handles FUN004.Click
        FUN004.SelectAll()
    End Sub
    Private Sub FUN005_Click(sender As Object, e As EventArgs) Handles FUN005.Click
        FUN005.SelectAll()
    End Sub
    Private Sub FUN008_Click(sender As Object, e As EventArgs) Handles FUN008.Click
        FUN008.SelectAll()
    End Sub
    Private Sub FUN009_Click(sender As Object, e As EventArgs) Handles FUN009.Click
        FUN009.SelectAll()
    End Sub
    Private Sub FUN010_Click(sender As Object, e As EventArgs) Handles FUN010.Click
        FUN010.SelectAll()
    End Sub
    Private Sub FUN011_Click(sender As Object, e As EventArgs) Handles FUN011.Click
        FUN011.SelectAll()
    End Sub
    Private Sub FUN012_Click(sender As Object, e As EventArgs) Handles FUN012.Click
        FUN012.SelectAll()
    End Sub
    Private Sub FUN015_Click(sender As Object, e As EventArgs) Handles FUN015.Click
        FUN015.SelectAll()
    End Sub
    Private Sub FUN016_Click(sender As Object, e As EventArgs) Handles FUN016.Click
        FUN016.SelectAll()
    End Sub
    Private Sub FUN017_Click(sender As Object, e As EventArgs) Handles FUN017.Click
        FUN017.SelectAll()
    End Sub
    Private Sub FUN018_Click(sender As Object, e As EventArgs) Handles FUN018.Click
        FUN018.SelectAll()
    End Sub
    Private Sub FUN019_Click(sender As Object, e As EventArgs) Handles FUN019.Click
        FUN019.SelectAll()
    End Sub
    Private Sub FUN020_Click(sender As Object, e As EventArgs) Handles FUN020.Click
        FUN020.SelectAll()
    End Sub
    Private Sub FUN021_Click(sender As Object, e As EventArgs) Handles FUN021.Click
        FUN021.SelectAll()
    End Sub

#End Region

#Region "ENTER"
    Private Sub tbPesquisa_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbPesquisa.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If pop > 0 Then
                Me.lvDados.Items(0).Selected = True
                lvDados.Select()
            End If
        End If
    End Sub
    Private Sub FUN003_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN003.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If FUN003.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o nome do funcionário! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN003.Focus()
            Else
                FUN006.Focus()
            End If
        End If
    End Sub
    Private Sub FUN006_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN006.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            FUN008.Focus()
        End If
    End Sub
    Private Sub FUN008_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN008.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If FUN008.MaskCompleted = False Or FUN008.Text = "   .   .   -" Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o número do CPF! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN008.Focus()
            Else
                FUN009.Focus()
            End If
        End If
    End Sub
    Private Sub FUN009_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN009.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If FUN009.MaskCompleted = False Or FUN009.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o número do RG! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN009.Focus()
            Else
                FUN004.Focus()
            End If
        End If
    End Sub
    Private Sub FUN004_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN004.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If Me.FUN004.FindString(FUN004.Text) = -1 Or FUN004.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Me, " Cargo inválido! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN004.Focus()
            Else
                FUN004.Text = UCase(FUN004.Text)
                FUN005.Focus()
            End If
        End If
    End Sub
    Private Sub FUN005_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN005.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If Me.FUN005.FindString(FUN005.Text) = -1 Or FUN005.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Me, " Setor inválido! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN005.Focus()
            Else
                FUN005.Text = UCase(FUN005.Text)
                FUN016.Focus()
            End If
        End If
    End Sub
    Private Sub FUN005_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FUN005.SelectedIndexChanged
        If Me.FUN005.FindString(FUN005.Text) = -1 Or FUN005.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " Setor inválido! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN005.Focus()
        Else
            FUN005.Text = UCase(FUN005.Text)
            FUN016.Focus()
        End If
    End Sub
    Private Sub FUN004_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FUN004.SelectedIndexChanged
        If Me.FUN004.FindString(FUN004.Text) = -1 Or FUN004.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " Cargo inválido! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN004.Focus()
        Else
            FUN004.Text = UCase(FUN004.Text)
            FUN005.Focus()
        End If
    End Sub
    Private Sub FUN016_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN016.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If FUN016.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o endereço! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN016.Focus()
            Else
                FUN017.Focus()
            End If
        End If
    End Sub

    Private Sub FUN017_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN017.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If FUN017.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o bairro! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN017.Focus()
            Else
                FUN018.Focus()
            End If
        End If
    End Sub
    Private Sub FUN018_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN018.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If FUN018.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe a cidade! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN018.Focus()
            Else
                FUN019.Focus()
            End If
        End If
    End Sub
    Private Sub FUN019_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN019.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If FUN019.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o estado (UF)! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN019.Focus()
            Else
                FUN020.Focus()
            End If
        End If
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub

    Private Sub FUN020_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN020.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If FUN020.MaskCompleted = False Or FUN020.Text = "     -" Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o CEP da cidade! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN020.Focus()
            Else
                FUN021.Focus()
            End If
        End If
    End Sub
    Private Sub FUN021_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN021.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            FUN011.Focus()
        End If
    End Sub
    Private Sub FUN011_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN011.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If FUN011.MaskCompleted = False Or FUN011.Text = "(  )    -    " Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe um número de telefone fixo! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN011.Focus()
            Else
                FUN012.Focus()
            End If
        End If
    End Sub
    Private Sub FUN012_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN012.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            FUN010.Focus()
        End If
    End Sub
    Private Sub FUN010_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN010.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            FUN015.Focus()
        End If
    End Sub
    Private Sub FUN015_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN015.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            btnsave.Focus()
        End If
    End Sub
    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        Aviso09.IMG006.Text = IMG006.Text
        Aviso09.FUN002.Text = FUN002.Text
        Aviso09.FUN003.Text = FUN003.Text
        alterado = 0
        Aviso09.ShowDialog()
        If alterado > 0 Then
            Call CarregaList(0) ' popula o grid de cadastro das garagens
            If pop > 0 Then
                Me.lvDados.Items(index).Selected = True
                lvDados.Select()
            End If
        Else
            Me.lvDados.Items(index).Selected = True
            lvDados.Select()
        End If
    End Sub
#End Region

End Class
























