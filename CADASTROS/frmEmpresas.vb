Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Imports System.Windows.Forms


Public Class frmEmpresas
    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Protected regionHandle As IntPtr


    Dim filtro, index, gravar As Integer
    Dim pop, valida As Integer
    Dim sql, chave, acao, texto As String
    Dim data_hoje As DateTime = DateAndTime.Now
    Dim frmPanel As Panel

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
        If e.KeyCode = Keys.Escape Then
            ' BOTÃO SALVAR O REGISTRO
            Me.Close()
        End If


    End Sub
    Private Sub beep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        redondo(0, 0, tarja, 20, 20)
        redondo(0, 0, Panel1, 20, 20)
        tarja.Text = "Cadastro de empresas e fornecedores"
        MesRef.Value = Month(data_hoje)
        filtro = 0 ' VARIAVEL QUE ACIONA O FILTRO PARA MOSTRAR TODOS OS REGISTROS
        Tabelas.SelectedIndex = 0
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
    Private Sub Bloqueio_Botoes(arg)
        Select Case arg
            Case 0
                ' PARTE DO FORMULÁRIO DE CADASTRO
                btnnovo.Enabled = True        ' Botão Novo    ATIVADO
                btnaltera.Enabled = True      ' Botão Alterar ATIVADO
                btncancela.Enabled = False    ' Botão Cancela DESATIVADO
                btnsave.Enabled = False       ' Botão Salvar  DESATIVADO  
                btnexcluir.Enabled = True
            Case 1
                ' PARTE DO FORMULÁRIO DE CADASTRO 
                btnnovo.Enabled = False          ' Botão Novo    DESATIVADO
                btnaltera.Enabled = False        ' Botão Altera  DESATIVADO
                btncancela.Enabled = True        ' Botão Cancela ATIVADO
                btnsave.Enabled = True         ' Botão Salvar  ATIVADO
                btnexcluir.Enabled = False       ' Botão Excluir DESATIVADO
            Case 2
                btnnovo.Enabled = False         ' Botão Novo    ATIVADO
                btnaltera.Enabled = False       ' Botão Alterar ATIVADO
                btncancela.Enabled = False    ' Botão Cancela DESATIVADO
                btnsave.Enabled = False       ' Botão Salvar  DESATIVADO  
                btnexcluir.Enabled = False
        End Select
    End Sub
    Private Sub bloqueia_textBox(arg)
        Select Case arg
            Case 0
                ' BLOQUEIO DOS TEXTBOX PARA EDIÇÃO ABA EMPRESA
                EMP003.ReadOnly = True  ' NOME DA EMPRESA  
                EMP004.ReadOnly = True  ' CONTATO NA EMPRESA 
                EMP006.ReadOnly = True  ' FONE 01 
                EMP007.ReadOnly = True  ' FONE 02
                EMP008.ReadOnly = True  ' FONE 03 
                EMP009.ReadOnly = True  ' FONE 04
                EMP010.Enabled = False  ' RAMO DE ATIVIDADE DA EMPRESA 
                EMP011.Enabled = False  ' DATA DE CADASTRO DA EMPRESA 
                EMP012.ReadOnly = True  ' ENDEREÇO DA EMPRESA
                EMP013.ReadOnly = True  ' BAIRRO DA EMPRESA
                EMP014.ReadOnly = True  ' CIDADE DA EMPRESA
                EMP015.ReadOnly = True  ' ESTADO LOCALIZAÇÃO DA EMPRESA
                EMP016.ReadOnly = True  ' CEP 
                EMP017.ReadOnly = True  ' COMPLEMENTO
                EMP018.ReadOnly = True  ' CNPJ
                EMP019.ReadOnly = True  ' INSCRIÇÃO ESTADUAL
                Painel01.Enabled = True
                Painel02.Enabled = True
                P_list.Enabled = True
                Panel4.Enabled = True
            Case 1
                EMP003.ReadOnly = False   ' NOME DA EMPRESA  
                EMP004.ReadOnly = False   ' CONTATO NA EMPRESA 
                EMP006.ReadOnly = False   ' FONE 01 
                EMP007.ReadOnly = False   ' FONE 02
                EMP008.ReadOnly = False   ' FONE 03 
                EMP009.ReadOnly = False   ' FONE 04
                EMP010.Enabled = True   ' RAMO DE ATIVIDADE DA EMPRESA 
                EMP011.Enabled = False  ' DATA DE CADASTRO DA EMPRESA 
                EMP012.ReadOnly = False   ' ENDEREÇO DA EMPRESA
                EMP013.ReadOnly = False   ' BAIRRO DA EMPRESA
                EMP014.ReadOnly = False   ' CIDADE DA EMPRESA
                EMP015.ReadOnly = False   ' ESTADO LOCALIZAÇÃO DA EMPRESA
                EMP016.ReadOnly = False   ' CEP 
                EMP017.ReadOnly = False   ' COMPLEMENTO
                EMP018.ReadOnly = False   ' CNPJ
                EMP019.ReadOnly = False   ' INSCRIÇÃO ESTADUAL
                Painel01.Enabled = False
                Painel02.Enabled = False
                P_list.Enabled = False
                Panel4.Enabled = False
        End Select
    End Sub
    Private Sub buscadados(arg)
        Select Case arg
            Case 0
                ' BUSCA OS DADOS DA TABELA PRT_CADFUN
                If conexao.State = 0 Then
                    conexao.Open()
                End If
                Dim comando As New MySqlCommand("select EMP004,EMP006,EMP007,EMP008,EMP009,EMP010,EMP011,EMP012,EMP013,EMP014,EMP015,EMP016,EMP017,EMP018,EMP019 from prt_empresa where EMP002 = '" & EMP002.Text & "'", conexao)
                Dim leitor As MySqlDataReader = comando.ExecuteReader()
                While leitor.Read()
                    EMP004.Text = IIf(Convert.IsDBNull(leitor("EMP004")) = True, "", leitor("EMP004")) ' 
                    EMP006.Text = IIf(Convert.IsDBNull(leitor("EMP006")) = True, "", leitor("EMP006")) ' 
                    EMP007.Text = IIf(Convert.IsDBNull(leitor("EMP007")) = True, "", leitor("EMP007")) ' 
                    EMP008.Text = IIf(Convert.IsDBNull(leitor("EMP008")) = True, "", leitor("EMP008")) ' 
                    EMP009.Text = IIf(Convert.IsDBNull(leitor("EMP009")) = True, "", leitor("EMP009")) ' 
                    EMP010.Text = IIf(Convert.IsDBNull(leitor("EMP010")) = True, "", leitor("EMP010")) ' 
                    EMP011.Text = IIf(Convert.IsDBNull(leitor("EMP011")) = True, "", leitor("EMP011")) ' 
                    EMP012.Text = IIf(Convert.IsDBNull(leitor("EMP012")) = True, "", leitor("EMP012")) ' 
                    EMP013.Text = IIf(Convert.IsDBNull(leitor("EMP013")) = True, "", leitor("EMP013")) ' 
                    EMP014.Text = IIf(Convert.IsDBNull(leitor("EMP014")) = True, "", leitor("EMP014")) ' 
                    EMP015.Text = IIf(Convert.IsDBNull(leitor("EMP015")) = True, "", leitor("EMP015")) ' 
                    EMP016.Text = IIf(Convert.IsDBNull(leitor("EMP016")) = True, "", leitor("EMP016")) ' 
                    EMP017.Text = IIf(Convert.IsDBNull(leitor("EMP017")) = True, "", leitor("EMP017")) ' 
                    EMP018.Text = IIf(Convert.IsDBNull(leitor("EMP018")) = True, "", leitor("EMP018")) ' 
                    EMP019.Text = IIf(Convert.IsDBNull(leitor("EMP019")) = True, "", leitor("EMP019")) ' 
                End While
                comando.Cancel()
                leitor.Close()
                conexao.Close()
            Case 1

                Try
                    Dim ds As New DataSet
                    Dim dr As DataRow
                    Dim dt As New DataTable
                    Dim adptr As New MySqlDataAdapter("select ATI02 from prt_atividade order by ATI02", conexao)
                    adptr.Fill(ds, "prt_atividade")
                    dt = ds.Tables(0)
                    If acao = "NOVO" Then
                        EMP010.Items.Clear()
                        EMP010.Text = ""
                    Else
                        EMP010.Items.Clear()
                    End If
                    For Each dr In dt.Rows
                        EMP010.Items.Add(dr.Item("ATI02"))
                    Next
                Catch ex As MySqlException
                    MetroFramework.MetroMessageBox.Show(Me, " Erro no banco de dados:   " & ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
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
        MesRef.Value = Month(data_hoje)
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
        MesRef.Value = Month(data_hoje)
    End Sub
    Private Sub geracod(arg)
        Select Case arg
            Case 0
                ' GERA O CÓDIGO PARA UM NOVO FUNCIONÁRIO
                Dim sqlmaior As String
                If conexao.State = 0 Then
                    conexao.Open()
                End If
                sqlmaior = "Select Max(EMP002) From prt_empresa"
                Dim cmd As New MySqlCommand(sqlmaior, conexao)
                Dim maior As Integer
                If IsDBNull(cmd.ExecuteScalar) Then
                    maior = 1
                Else
                    maior = cmd.ExecuteScalar + 1
                End If
                cmd.ExecuteNonQuery()
                EMP002.Text = Format(maior, "000000")
                cmd.Dispose()
                conexao.Close()
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
#End Region

#Region "LISTVIEW"
    Private Sub filtrar()
        Select Case filtro
            Case 0 ' TODOS OS REGISTROS
                sql = "SELECT EMP002,EMP003 from prt_empresa WHERE EMP020 = '0' order by EMP003"
            Case 1 ' FILTRA PELO NOME DO PROPRIETÁRIO
                sql = "SELECT EMP002,EMP003 FROM prt_empresa WHERE EMP003 like '" & chave & "%' AND EMP020 = '0' order by EMP003"
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
                    item = lvDados.Items.Add(leitor("EMP002").ToString)   ' 0 ID
                    item.SubItems.Add(leitor("EMP003").ToString)         ' 1 NUMERAÇÃO DA UNIDADE
                    pop += 1 ' faz a contagem dos registros no listview
                Loop
                conexao.Close() ' fecha a conexação com o banco de dados
                leitor.Dispose()
                'Call corlist(0)
            Case 1

                lvacesso.Items.Clear()
                lvacesso.GridLines = True
                lvacesso.FullRowSelect = True
                lvacesso.View = View.Details
                lvacesso.Sorting = SortOrder.None
                'lvacesso.SmallImageList = ImageGrid
                conexao.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("SELECT a.FUN002,a.FAS002,a.FAS003,a.FAS005,b.FUN002,b.FUN003 FROM prt_fass AS a inner join prt_cadfun AS b on (a.FUN002 = b.FUN002) where a.EMP002 = '" & EMP002.Text & "' and EXTRACT(month FROM a.FAS002) = '" & MesRef.Value & "' order by FAS002 DESC", conexao)
                Dim leitor As MySqlDataReader = cmd.ExecuteReader()
                Dim leitura As Integer = 0

                Do While leitor.Read()
                    Dim item As New ListViewItem()
                    item.Text = leitor(0)
                    item = lvacesso.Items.Add(leitor("FUN002"))          ' 0 CODIGO DO EMPREGADO NA TABELA PRT_CADFUN
                    item.SubItems.Add(Format(leitor("FAS002"), "dd/MM/yyyy").ToString)         ' 1 DATA DA ENTRADA
                    item.SubItems.Add(leitor("FAS003").ToString)         ' 2 HORA DA ENTRADA
                    item.SubItems.Add(leitor("FUN003").ToString)         ' 3 NOME DO EMPREGADO
                    item.SubItems.Add(leitor("FAS005").ToString)         ' 4 NOME DO PORTEIRO
                Loop
                conexao.Close() ' fecha a conexação com o banco de dados
                leitor.Dispose()

        End Select
    End Sub
#End Region

#Region "COMPONENTES"
    Private Sub tratatab()
        Select Case Tabelas.SelectedTab.Name
            Case "Tab0"
                Panel3.Visible = True
                EMP002.BackColor = Color.White
                EMP003.BackColor = Color.White

                tarja.Text = "Cadastro de empresas e fornecedores"
                If alterado = 99 Then
                    Call CarregaList(0) ' se foi feita alteração da foto do perfil carrega novamente os dados
                End If
                If pop > 0 Then
                    Me.lvDados.Items(index).Selected = True
                    lvDados.Select()
                End If
            Case "Tab1"
                tarja.Text = "Funcionários da empresa:  " & EMP003.Text
                Panel3.Visible = False

                EMP002.BackColor = Color.Orange
                EMP003.BackColor = Color.Orange

                Repositorio.EMP002.Text = EMP002.Text
                Repositorio.EMP003.Text = EMP003.Text

                frmPanel = Painel01
                frmPanel.Controls.Clear() ' LIMPA OS DADOS DO FORMULÁRIODE AUTORIZADOS QUE VAI ABRIR DENTRO DO PAINEL
                abriform(Of frmEmpresaFun)() ' ABRE O FORMULÁRIO DENTRO DO PAINEL
            Case "Tab2"
                tarja.Text = "Log de Movimentação na portaria"
                EMP002.BackColor = Color.White
                EMP003.BackColor = Color.White
                Panel3.Visible = False

                Repositorio.EMP002.Text = EMP002.Text

                frmPanel = Painel02
                frmPanel.Controls.Clear() ' LIMPA OS DADOS DO FORMULÁRIODE AUTORIZADOS QUE VAI ABRIR DENTRO DO PAINEL

                abriform(Of frmLogMovim02)() ' ABRE O FORMULÁRIO DENTRO DO PAINEL

        End Select
    End Sub
    Private Sub Tabelas_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles Tabelas.SelectedIndexChanged
        Call tratatab()
    End Sub
    Private Sub lvDados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDados.SelectedIndexChanged
        Try
            If lvDados.SelectedItems.Count > 0 Then
                index = lvDados.Items.Item(lvDados.SelectedIndices(0)).Index

                Me.EMP002.Text = Convert.ToString(lvDados.Items(lvDados.SelectedIndices(0)).Text)
                Me.EMP003.Text = Me.lvDados.SelectedItems(0).SubItems(1).Text

                Call buscadados(0) ' Busca os dados do cadastro
                Call CarregaList(1) ' CARREGA LOG DE ACESSOS DA EMPRESA 

            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

#Region "BOTÕES"
    Private Sub btnaltera_Click(sender As Object, e As EventArgs) Handles btnaltera.Click
        If pop > 0 Then
            Tabelas.SelectedIndex = 0

            valida = 0
            acao = "ALTERA"
            ' edita e altera o registro
            Call Bloqueio_Botoes(1) ' bloqueia os botões
            Call bloqueia_textBox(1) ' libera os campos dos textos
            Call buscadados(1)       ' carrega relação de setores da empresa

            EMP003.Focus()
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        ' grava as informações na tabela prt_empresa
        Call testaCampos()
        If valida > 0 Then
            Dim sqlG As String
            If acao = "NOVO" Then
                texto = "Registro efetuado com sucesso"
                sqlG = "insert into prt_empresa(EMP002,EMP003,EMP011,EMP010,EMP004,EMP012,EMP013,EMP014,EMP015,EMP016,EMP017,EMP018,EMP019,EMP006,EMP007,EMP008,EMP009,EMP020)values('" & EMP002.Text & "','" & EMP003.Text & "','" & Format(EMP011.Value, "yyyy-MM-dd") & "','" & EMP010.Text & "','" & EMP004.Text & "','" & EMP012.Text & "','" & EMP013.Text & "','" & EMP014.Text & "','" & EMP015.Text & "','" & EMP016.Text & "','" & EMP017.Text & "','" & EMP018.Text & "','" & EMP019.Text & "','" & EMP006.Text & "','" & EMP007.Text & "','" & EMP008.Text & "','" & EMP009.Text & "','0')"
            Else
                texto = "Alteração efetuada com sucesso"
                sqlG = "update prt_empresa set  EMP003 = '" & EMP003.Text & "',EMP010 = '" & EMP010.Text & "',EMP004 = '" & EMP004.Text & "',EMP012 = '" & EMP012.Text & "',EMP013 = '" & EMP013.Text & "',EMP014 = '" & EMP014.Text & "',EMP015 = '" & EMP015.Text & "',EMP016 = '" & EMP016.Text & "',EMP017 = '" & EMP017.Text & "',EMP018 = '" & EMP018.Text & "',EMP019 = '" & EMP019.Text & "',EMP006 = '" & EMP006.Text & "',EMP007 = '" & EMP007.Text & "',EMP008 = '" & EMP008.Text & "',EMP009 = '" & EMP009.Text & "' WHERE EMP002 = '" & EMP002.Text & "'"
            End If
            Try
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim cmd As New MySqlCommand(sqlG, conexao)
                conexao.Open()
                cmd.ExecuteNonQuery()

                MetroFramework.MetroMessageBox.Show(Me, texto, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                conexao.Close()


                acao = ""
                filtro = 0 ' VARIAVEL QUE ACIONA O FILTRO PARA MOSTRAR TODOS OS REGISTROS
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
        Tabelas.SelectedIndex = 0
        If (MetroFramework.MetroMessageBox.Show(Me, "Esse procedimento exclui o registro fisíco.  Deseja prosseguir com a exclusão ? ", "" & legenda & "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error)) = MsgBoxResult.Yes Then
            If conexao.State = ConnectionState.Open Then conexao.Close()
            Dim sql As String = "update prt_empresa set EMP020 = '1' WHERE EMP002 = '" & EMP002.Text & "'"
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
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If EMP010.Enabled = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Status não permite a edição das atividades ", "" & sistema & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            alterado = 0
            frmAtividade.ShowDialog()
            If alterado > 0 Then
                Call buscadados(1) ' recarrega o combobox EMP010
                EMP010.Focus()
            End If
        End If
    End Sub
    Private Sub btnnovo_Click(sender As Object, e As EventArgs) Handles btnnovo.Click
        acao = "NOVO"
        valida = 0
        Tabelas.SelectedIndex = 0

        '========= BLOCO DE PROCEDIMENTOS PARA NOVA INCLUSÃO =============================================================
        Call Bloqueio_Botoes(1)  ' bloqueia os botões
        Call bloqueia_textBox(1) ' libera os campos dos textos
        Call Limpar_textbox(Me)  ' limpa os campos para edição
        Call Limpar_mask(Me)     ' limpa os campos com mascara
        Call buscadados(1)       ' carrega relação de setores da empresa
        Call geracod(0)          ' gera um código para cadastro da unidade seguindo o ultimo cadastro realizado
        '=================================================================================================================

        EMP011.Text = Format(data_hoje, "dd/MM/yyyy")
        EMP003.Focus()           ' direciona o focus para o campo de identificação
    End Sub
    Private Sub btncancela_Click(sender As Object, e As EventArgs) Handles btncancela.Click
        Tabelas.SelectedIndex = 0
        filtro = 0 ' VARIAVEL QUE ACIONA O FILTRO PARA MOSTRAR TODOS OS REGISTROS

        Call Bloqueio_Botoes(0) ' BLOQUEIO DOS BOTÕES
        Call bloqueia_textBox(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS
        Call CarregaList(0) ' RECARREGA A RELAÇÃO DE FUNCIONÁRIOS

        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
            lvDados.Focus()
        End If
    End Sub
    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Tabelas.SelectedIndex = 0
        filtro = 0 ' VARIAVEL QUE ACIONA O FILTRO PARA MOSTRAR TODOS OS REGISTROS
        lvDados.Refresh()
        tbPesquisa.Clear()
        Call Bloqueio_Botoes(0) ' BLOQUEIO DOS BOTÕES
        Call bloqueia_textBox(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS
        Call CarregaList(0) ' RECARREGA A RELAÇÃO DE FUNCIONÁRIOS
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
            lvDados.Focus()
        End If
    End Sub
#End Region

#Region "ENTER"
    Private Sub testaCampos()
        valida = 0
        If EMP003.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o nome da empresa ou fornecedor! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EMP003.Focus()
            valida = 0
            Exit Sub
        Else
            valida += 10
        End If
        If EMP004.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o nome de contato na empresa! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EMP004.Focus()
            valida = 0
            Exit Sub
        Else
            valida += 10
        End If
        If Me.EMP010.FindString(EMP010.Text) = -1 Or EMP010.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " Atividade não cadastrada! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            valida = 0
            Exit Sub
        Else
            valida += 10
        End If
    End Sub

    Private Sub tbPesquisa_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbPesquisa.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If pop > 0 Then
                Me.lvDados.Items(0).Selected = True
                lvDados.Select()
            End If
        End If
    End Sub
    Private Sub EMP003_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles EMP003.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If EMP003.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o nome da empresa ou fornecedor! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                EMP003.Focus()
            Else
                EMP010.Focus()
            End If
        End If
    End Sub

    Private Sub EMP010_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles EMP010.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If Me.EMP010.FindString(EMP010.Text) = -1 Or EMP010.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Me, " Atividade não cadastrada! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Button14.PerformClick()
            Else
                EMP010.Text = UCase(EMP010.Text)
                EMP004.Focus()
            End If
        End If
    End Sub
    Private Sub EMP004_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles EMP004.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If EMP004.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o nome de contato na empresa! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                EMP004.Focus()
            Else
                EMP012.Focus()
            End If
        End If
    End Sub

    Private Sub EMP012_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles EMP012.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            EMP013.Focus()
        End If
    End Sub
    Private Sub EMP013_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles EMP013.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            EMP014.Focus()
        End If
    End Sub
    Private Sub EMP014_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles EMP014.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            EMP015.Focus()
        End If
    End Sub
    Private Sub EMP015_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles EMP015.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            EMP016.Focus()
        End If
    End Sub
    Private Sub EMP016_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles EMP016.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            EMP017.Focus()
        End If
    End Sub
    Private Sub EMP017_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles EMP017.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            EMP018.Focus()
        End If
    End Sub
    Private Sub EMP018_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles EMP018.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            EMP019.Focus()
        End If
    End Sub
    Private Sub EMP019_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles EMP019.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            EMP006.Focus()
        End If
    End Sub
    Private Sub EMP006_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles EMP006.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            EMP007.Focus()
        End If
    End Sub
    Private Sub EMP007_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles EMP007.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            EMP008.Focus()
        End If
    End Sub
    Private Sub EMP008_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles EMP008.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            EMP009.Focus()
        End If
    End Sub
    Private Sub EMP009_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles EMP009.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            btnsave.Focus()
        End If
    End Sub
#End Region

#Region "EVENTO CLICK"
    Private Sub EMP003_Click(sender As Object, e As EventArgs) Handles EMP003.Click
        EMP003.SelectAll()
    End Sub
    Private Sub EMP010_Click(sender As Object, e As EventArgs) Handles EMP010.Click
        EMP010.SelectAll()
    End Sub
    Private Sub EMP004_Click(sender As Object, e As EventArgs) Handles EMP004.Click
        EMP004.SelectAll()
    End Sub
    Private Sub EMP012_Click(sender As Object, e As EventArgs) Handles EMP012.Click
        EMP012.SelectAll()
    End Sub
    Private Sub EMP013_Click(sender As Object, e As EventArgs) Handles EMP013.Click
        EMP013.SelectAll()
    End Sub
    Private Sub EMP014_Click(sender As Object, e As EventArgs) Handles EMP014.Click
        EMP014.SelectAll()
    End Sub
    Private Sub EMP015_Click(sender As Object, e As EventArgs) Handles EMP015.Click
        EMP015.SelectAll()
    End Sub
    Private Sub EMP016_Click(sender As Object, e As EventArgs) Handles EMP016.Click
        EMP016.SelectAll()
    End Sub
    Private Sub EMP017_Click(sender As Object, e As EventArgs) Handles EMP017.Click
        EMP017.SelectAll()
    End Sub
    Private Sub EMP018_Click(sender As Object, e As EventArgs) Handles EMP018.Click
        EMP018.SelectAll()
    End Sub

    Private Sub MesRef_ValueChanged(sender As Object, e As EventArgs)
        Call CarregaList(1) ' CARREGA LOG DE ACESSOS DA EMPRESA 
    End Sub

    Private Sub MesRef_ValueChanged_1(sender As Object, e As EventArgs) Handles MesRef.ValueChanged
        Call CarregaList(1)
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub

    Private Sub EMP019_Click(sender As Object, e As EventArgs) Handles EMP019.Click
        EMP019.SelectAll()
    End Sub

    Private Sub EMP010_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EMP010.SelectedIndexChanged
        If Me.EMP010.FindString(EMP010.Text) = -1 Or EMP010.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " Atividade não cadastrada! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Button14.PerformClick()
        Else
            EMP010.Text = UCase(EMP010.Text)
            EMP004.Focus()
        End If
    End Sub

    Private Sub EMP006_Click(sender As Object, e As EventArgs) Handles EMP006.Click
        EMP006.SelectAll()
    End Sub
    Private Sub EMP007_Click(sender As Object, e As EventArgs) Handles EMP007.Click
        EMP007.SelectAll()
    End Sub
    Private Sub EMP008_Click(sender As Object, e As EventArgs) Handles EMP008.Click
        EMP008.SelectAll()
    End Sub
    Private Sub EMP009_Click(sender As Object, e As EventArgs) Handles EMP009.Click
        EMP009.SelectAll()
    End Sub
#End Region

End Class
























