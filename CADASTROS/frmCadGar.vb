Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmCadGar
    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Protected regionHandle As IntPtr


#Region "VARIÁVEIS"
    Dim sql As String
    Dim filtro As Integer = 0
    Dim idGAR005, idGAR008, desGar005, acao As String
    Dim index As Integer
    Dim retorno As String = Nothing
    Dim grava As String = "Não"
    Dim origem As String
    Dim Data_hoje As DateTime = DateTime.Now
    Dim status As String
    Dim reg, codbloq As Integer
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
    End Sub
    Private Sub frmCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
    Private Sub frmCadGar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        redondo(0, 0, tarja, 20, 20)
        redondo(0, 0, Panel1, 20, 20)
        grava = "Não"
        Me.CancelButton = btnhome
        Call Bloqueio_Botões(0) ' BLOQUEIO DOS BOTÕES
        Call bloqueia_texto(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS

        Call CarregaFiltro(0) ' CARREGA RELAÇÃO PARA USAR NO FILTRO DAS GARAGENS
        Call CarregaFiltro(1) ' CARREGA RELAÇÃO PARA CADASTRO E ALTERAÇÕES
        tbFiltro.SelectedIndex = 0
        Call CarregaList() ' popula o grid de cadastro das garagens
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
    Private Sub gravar()
        conexao.Open()
        Dim sql As String = "UPDATE PRT_GARAGENS SET GAR005 = '" & codbloq & "',GAR004 = '" & referencial.Text & "' WHERE GAR001 = '" & tbgar001.Text & "'"
        Dim cmd As New MySqlCommand(sql, conexao)
        cmd.ExecuteNonQuery()
        conexao.Close()
    End Sub
    Private Sub ContaRegistro(arg)
        Select Case arg
            Case 0
                ' CONTAGEM DOS REGISTROS PARA ALTERAÇÃO
                reg = 0
                For Each item As ListViewItem In lvDados.Items
                    If item.Checked Then
                        reg += 1
                    End If
                Next
            Case 1
                ' SELEÇÃO DOS ITENS DO LISTVIEW
                If todos.Checked = True Then
                    For Each item As ListViewItem In lvDados.Items
                        item.Checked = True
                    Next
                Else
                    For Each item As ListViewItem In lvDados.Items
                        item.Checked = False
                    Next
                End If
            Case 2
                For Each item As ListViewItem In lvDados.Items
                    item.Checked = False
                Next
        End Select
    End Sub
    Private Sub testar(arg)
        Select Case arg
            Case 0
                ' para a gravação em arquivo converte
                If tbgar008.Checked = True Then
                    idGAR008 = "S"
                Else
                    idGAR008 = "N"
                End If
            Case 1

        End Select
    End Sub
    Private Sub bloqueia_texto(arg)
        Select Case arg
            Case 0
                ' bloqieia os campos para edição
                pEdicao.Enabled = False
                gList.Enabled = True
                PainelMovimento.Enabled = True
            Case 1
                ' libera os campos para edição
                pEdicao.Enabled = True
                gList.Enabled = False
                PainelMovimento.Enabled = False
            Case 2
                ' limpa os campos para edição
                tbgar002.Clear()
                tbgar006.Text = "1"
                tbgar003.Text = ""
                tbgar008.Checked = False
                tbgar004.Clear()
        End Select
    End Sub
    Private Sub Bloqueio_Botões(arg)
        Select Case arg
            Case 0
                ' BLOQUEIA OS BOTÕES PARA ACESSO
                btnnovo.Enabled = True        ' Botão Novo    ATIVADO
                btnaltera.Enabled = True      ' Botão Alterar ATIVADO
                btncancela.Enabled = False    ' Botão Cancela DESATIVADO
                btnsave.Enabled = False       ' Botão Salvar  DESATIVADO  
                btnexcluir.Enabled = True
            Case 1
                btnnovo.Enabled = False          ' Botão Novo    DESATIVADO
                btnaltera.Enabled = False        ' Botão Altera  DESATIVADO
                btncancela.Enabled = True        ' Botão Cancela ATIVADO
                btnsave.Enabled = True         ' Botão Salvar  ATIVADO
                btnexcluir.Enabled = False       ' Botão Excluir DESATIVADO
        End Select
    End Sub
    Private Sub filtrar()
        Select Case filtro
            Case 99
                sql = "SELECT * FROM PRT_GARAGENS ORDER BY GAR002"
            Case 0 ' livre
                sql = "SELECT * FROM PRT_GARAGENS WHERE GAR005 = 0 ORDER BY GAR002"
            Case 1 ' ocupado
                sql = "SELECT * FROM PRT_GARAGENS WHERE GAR005 = 1 ORDER BY GAR002"
            Case 2 ' bloqueado
                sql = "SELECT * FROM PRT_GARAGENS WHERE GAR005 = 2 ORDER BY GAR002"
            Case 3 ' reservado
                sql = "SELECT * FROM PRT_GARAGENS WHERE GAR005 = 3 ORDER BY GAR002"
            Case 4 ' manutenção
                sql = "SELECT * FROM PRT_GARAGENS WHERE GAR005 = 4 ORDER BY GAR002"
            Case 5
                sql = "SELECT * FROM PRT_GARAGENS WHERE GAR003 = '" & tbFiltro.Text & "' ORDER BY GAR002"
        End Select
    End Sub
    Private Sub CarregaFiltro(arg)
        Select Case arg
            Case 0
                Try
                    Dim ds, Dset As New DataSet
                    Dim dr As DataRow
                    Dim dt As New DataTable
                    Dim sql = "SELECT * FROM PRT_LOCGAR ORDER BY LOCG002 "
                    Dim adptr As New MySqlDataAdapter(sql, conexao)
                    adptr.Fill(ds, "PRT_LOCGAR")
                    dt = ds.Tables(0)
                    For Each dr In dt.Rows
                        tbFiltro.Items.Add(dr.Item("LOCG002"))
                    Next
                    conexao.Close()
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Case 1
                Try
                    Dim ds, Dset As New DataSet
                    Dim dr As DataRow
                    Dim dt As New DataTable
                    Dim sql = "SELECT * FROM PRT_LOCGAR ORDER BY LOCG002 "
                    Dim adptr As New MySqlDataAdapter(sql, conexao)
                    adptr.Fill(ds, "PRT_LOCGAR")
                    dt = ds.Tables(0)
                    tbgar003.Text = ""
                    tbgar003.Items.Clear()
                    For Each dr In dt.Rows
                        tbgar003.Items.Add(dr.Item("LOCG002"))
                    Next
                    conexao.Close()
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
        End Select
    End Sub
    Private Sub MontaStatus(arg)
        Select Case idGAR005
            Case 0
                desGar005 = "LIVRE"
            Case 1
                desGar005 = "OCUPADO"
            Case 2
                desGar005 = "BLOQUEADO"
            Case 3
                desGar005 = "RESERVADO"
            Case 4
                desGar005 = "MANUTENCAO"
        End Select
    End Sub
    Private Sub corList()
        For i As Integer = 0 To lvDados.Items.Count - 1
            lvDados.Items(i).UseItemStyleForSubItems = False
            If lvDados.Items(i).SubItems.Count > 1 Then
                If lvDados.Items(i).SubItems(2).Text.ToString = "LIVRE" Then
                    lvDados.Items(i).ImageIndex = 0
                ElseIf lvDados.Items(i).SubItems(2).Text.ToString = "OCUPADO" Then
                    lvDados.Items(i).ImageIndex = 1
                ElseIf lvDados.Items(i).SubItems(2).Text.ToString = "BLOQUEADO" Then
                    lvDados.Items(i).ImageIndex = 2
                ElseIf lvDados.Items(i).SubItems(2).Text.ToString = "RESERVADO" Then
                    lvDados.Items(i).ImageIndex = 3
                ElseIf lvDados.Items(i).SubItems(2).Text.ToString = "MANUTENCAO" Then
                    lvDados.Items(i).ImageIndex = 4
                End If
            End If
        Next
    End Sub

    Private Sub testaCampos(arg)
        Select Case arg
            Case 0
                ' Quando da inclusão de um novo registro
                If tbgar002.TextLength = 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, "É necessário identificar a garagem ou vaga! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    grava = "Não"
                    tbgar002.Focus()
                    Exit Sub
                End If
                If tbgar006.Text = "" Or tbgar006.Text = Nothing Then
                    tbgar006.Text = "0"
                End If
                If CDbl(tbgar006.Text) = 0 Or CDbl(tbgar006.Text) < 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, " Informe o número de vagas para a garagem! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tbgar006.Focus()
                    grava = "Não"
                    Exit Sub
                End If
                If Me.tbgar003.FindString(tbgar003.Text) = -1 Or tbgar003.Text = "" Then
                    MetroFramework.MetroMessageBox.Show(Me, " Informe uma localização válida! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tbgar003.Focus()
                    grava = "Não"
                    Exit Sub
                End If
                Call pesquisa()
                If acao = "NOVO" Then
                    If retorno = Nothing Then
                        grava = "Sim"
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, " Já existe uma vaga com essa identificação! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tbgar002.Focus()
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

#Region "BOTÕES"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        alterado = 0
        frmLocalizacao.ShowDialog()
        If alterado = 10 Then
            Call CarregaFiltro(1)
        End If
    End Sub
    Private Sub btnnovo_Click(sender As Object, e As EventArgs) Handles btnnovo.Click
        ' novo registro
        acao = "NOVO"
        Call Bloqueio_Botões(1) ' bloqueia os botões
        Call bloqueia_texto(1) ' libera os campos dos textos
        Call bloqueia_texto(2) ' limpa os campos para edição
        tbgar002.Focus()       ' direciona o focus para o campo de identificação
    End Sub
    Private Sub btnaltera_Click(sender As Object, e As EventArgs) Handles btnaltera.Click
        If pop > 0 Then
            If status = "LIVRE" Then
                acao = "ALTERA"
                origem = tbgar002.Text
                ' edita e altera o registro
                Call Bloqueio_Botões(1) ' bloqueia os botões
                Call bloqueia_texto(1) ' libera os campos dos textos
                tbgar002.Focus()       ' direciona o focus para o campo de identificação
            Else
                MetroFramework.MetroMessageBox.Show(Me, " Atenção: Status da garagem não permite a edição. ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If pop > 0 Then
                    Me.lvDados.Items(index).Selected = True
                    lvDados.Select()
                End If
            End If
        End If
    End Sub
    Private Sub btncancela_Click(sender As Object, e As EventArgs) Handles btncancela.Click
        ' cancela a edição do registro
        If pop = 0 Then
            tbFiltro.SelectedIndex = 0
            index = 0
        End If
        Call Bloqueio_Botões(0) ' BLOQUEIO DOS BOTÕES
        Call bloqueia_texto(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS
        Call CarregaList() ' popula o grid de cadastro das garagens
        If pop > 0 Then
            Me.lvDados.Items(index).Selected = True
            lvDados.Select()
        End If
        Tabela.SelectedIndex = 0
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        ' grava as informações no arquivo
        Call testar(0) ' verifica se o checkbox foi acionado ou não
        If acao = "NOVO" Then
            ' QUANDO FOI UM NOVO REGISTRO
            Call testaCampos(0)
            If grava = "Sim" Then
                Try
                    If conexao.State = ConnectionState.Open Then conexao.Close()
                    Dim sql As String = "INSERT INTO PRT_GARAGENS(GAR002,GAR003,GAR004,GAR005,GAR006,GAR008)VALUES('" & tbgar002.Text & "','" & tbgar003.Text & "','" & tbgar004.Text & "','0','" & tbgar006.Text & "','" & idGAR008 & "')"
                    Dim cmd As New MySqlCommand(sql, conexao)
                    conexao.Open()
                    cmd.ExecuteNonQuery()
                    MetroFramework.MetroMessageBox.Show(Me, "Registro realizado com sucesso!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    conexao.Close()
                    acao = ""
                    Call Bloqueio_Botões(0) ' BLOQUEIO DOS BOTÕES
                    Call bloqueia_texto(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS
                    tbFiltro.SelectedIndex = 0
                    Call CarregaList() ' popula o grid de cadastro das garagens
                    If pop > 0 Then
                        Me.lvDados.Items(0).Selected = True
                        lvDados.Select()
                    End If
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                    Exit Sub
                End Try
            End If
        ElseIf acao = "ALTERA" Then
            ' QUANDO FOR UMA ALTERAÇÃO DE REGISTRO
            Call testaCampos(0)
            If grava = "Sim" Then
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim sql As String = "UPDATE PRT_GARAGENS SET GAR002 = '" & tbgar002.Text & "',GAR003 = '" & tbgar003.Text & "',GAR004 = '" & tbgar004.Text & "',GAR006 = '" & tbgar006.Text & "',GAR008 = '" & idGAR008 & "', GAR010 = '" & Format(Data_hoje, "dd.MM.yyyy") & "' WHERE GAR001 = '" & tbgar001.Text & "'"
                Dim cmd As New MySqlCommand(sql, conexao)
                conexao.Open()
                cmd.ExecuteNonQuery()
                MetroFramework.MetroMessageBox.Show(Me, "Registro alterado com sucesso!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                conexao.Close()
                acao = ""
                Call Bloqueio_Botões(0) ' BLOQUEIO DOS BOTÕES
                Call bloqueia_texto(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS
                Call CarregaList() ' popula o grid de cadastro das garagens
                If pop > 0 Then
                    Me.lvDados.Items(index).Selected = True
                    lvDados.Select()
                End If
            End If
        End If
    End Sub
    Private Sub btnexcluir_Click(sender As Object, e As EventArgs) Handles btnexcluir.Click
        ' exclui o registro
        If status = "LIVRE" Then
            If (MetroFramework.MetroMessageBox.Show(Me, " Deseja mesmo excluir a garagem ?", "" & legenda & "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = MsgBoxResult.Yes Then
                If conexao.State = ConnectionState.Closed Then conexao.Close()
                conexao.Open()
                Dim st = "DELETE FROM PRT_GARAGENS WHERE GAR001 = '" & tbgar001.Text & "'"
                Dim comando As New MySqlCommand(st, conexao)
                comando.ExecuteNonQuery()
                conexao.Close()
                MetroFramework.MetroMessageBox.Show(Me, " O Registro foi excluído definitivamente! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                acao = ""
                tbFiltro.SelectedIndex = 0
                Call CarregaList() ' popula o grid de cadastro das garagens
                If pop > 0 Then
                    Me.lvDados.Items(0).Selected = True
                    lvDados.Select()
                End If
            End If
        Else
            MetroFramework.MetroMessageBox.Show(Me, "O Status da Garagem não permite a exclusão! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub tbgar008_CheckedChanged(sender As Object, e As EventArgs) Handles tbgar008.CheckedChanged
        Call testar(0) ' testa a edição do checkbox
    End Sub
#End Region

#Region "COMPONENTES"
    Private Sub menuopc_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles menuopc.Opening
        If pop <= 0 Then
            menuopc.Enabled = False
        Else
            menuopc.Enabled = True
        End If
    End Sub
    Private Sub todos_CheckedChanged(sender As Object, e As EventArgs) Handles todos.CheckedChanged
        Call ContaRegistro(1) ' marca todos os registros para alteração
    End Sub
    Private Sub Strip1_Click(sender As Object, e As EventArgs) Handles Strip1.Click
        Call ContaRegistro(0) ' verifica se existem registros selecionados para a baixa
        If reg > 0 Then
            alterado = 0
            frmObsGar.Text = " Bloqueio da Garagem "
            frmObsGar.ShowDialog()
            If alterado = 10 Then
                ' Atualiza o grid com as alterações
                codbloq = 2
                For i As Integer = 0 To lvDados.Items.Count - 1
                    If lvDados.Items(i).Checked = True Then
                        tbgar001.Text = lvDados.Items(i).SubItems(7).Text
                        If lvDados.Items(i).SubItems(2).Text = "LIVRE" Or lvDados.Items(i).SubItems(2).Text = "MANUTENCAO" Then
                            Call gravar()
                        End If
                    End If
                Next
                tbFiltro.SelectedIndex = 0
                Call ContaRegistro(2) ' desmarca todos os registros
                Call CarregaList() ' popula o grid de cadastro das garagens
                MetroFramework.MetroMessageBox.Show(Me, " Processo realizado com sucesso! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If pop > 0 Then
                    Me.lvDados.Items(index).Selected = True
                    lvDados.Select()
                End If
            End If
        Else
            alterado = 0
            MetroFramework.MetroMessageBox.Show(Me, " É necessário selecionar os registros para alteração! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub
    Private Sub Strip2_Click(sender As Object, e As EventArgs) Handles Strip2.Click
        Call ContaRegistro(0) ' verifica se existem registros selecionados para a baixa
        If reg > 0 Then
            alterado = 0
            frmObsGar.Text = " Garagem em Manutenção "
            frmObsGar.ShowDialog()
            If alterado = 10 Then
                ' Atualiza o grid com as alterações
                ' Atualiza o grid com as alterações
                codbloq = 4
                For i As Integer = 0 To lvDados.Items.Count - 1
                    If lvDados.Items(i).Checked = True Then
                        tbgar001.Text = lvDados.Items(i).SubItems(7).Text
                        If lvDados.Items(i).SubItems(2).Text = "LIVRE" Or lvDados.Items(i).SubItems(2).Text = "BLOQUEADO" Then
                            Call gravar()
                        End If
                    End If
                Next
                tbFiltro.SelectedIndex = 0
                Call ContaRegistro(2) ' desmarca todos os registros
                Call CarregaList() ' popula o grid de cadastro das garagens
                MetroFramework.MetroMessageBox.Show(Me, " Processo realizado com sucesso! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If pop > 0 Then
                    Me.lvDados.Items(index).Selected = True
                    lvDados.Select()
                End If
            End If
        Else
            alterado = 0
            MetroFramework.MetroMessageBox.Show(Me, " É necessário selecionar os registros para alteração! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub
    Private Sub Strip3_Click(sender As Object, e As EventArgs) Handles Strip3.Click
        Call ContaRegistro(0) ' verifica se existem registros selecionados para a baixa
        If reg > 0 Then
            ' Atualiza o grid com as alterações
            codbloq = 0
            referencial.Text = ""
            For i As Integer = 0 To lvDados.Items.Count - 1
                If lvDados.Items(i).Checked = True Then
                    tbgar001.Text = lvDados.Items(i).SubItems(7).Text
                    If lvDados.Items(i).SubItems(2).Text = "BLOQUEADO" Or lvDados.Items(i).SubItems(2).Text = "MANUTENCAO" Then
                        Call gravar()
                    End If
                End If
            Next
            tbFiltro.SelectedIndex = 0
            Call ContaRegistro(2) ' desmarca todos os registros
            Call CarregaList() ' popula o grid de cadastro das garagens
            MetroFramework.MetroMessageBox.Show(Me, " Processo realizado com sucesso! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If pop > 0 Then
                Me.lvDados.Items(index).Selected = True
                lvDados.Select()
            End If
        End If
    End Sub
#End Region

#Region "LISTVIEW"
    Private Sub CarregaList()
        Call filtrar()
        lvDados.Items.Clear()
        lvDados.GridLines = True
        lvDados.FullRowSelect = True
        lvDados.View = View.Details
        lvDados.Sorting = SortOrder.None
        lvDados.SmallImageList = ImageList
        conexao.Open()
        Dim cmd As MySqlCommand = New MySqlCommand(sql, conexao)
        Dim leitor As MySqlDataReader = cmd.ExecuteReader()
        pop = 0
        Do While leitor.Read()
            Dim item As New ListViewItem()
            item.Text = leitor(0)
            idGAR005 = leitor("GAR005")
            Call MontaStatus(0) ' monta o status da garagem (OCUPADO/LIVRE ETC)
            ' distribui os itens na tabela conforme as colunas delimitadas

            item = lvDados.Items.Add(leitor("GAR002").ToString)  '0 ID
            item.SubItems.Add(leitor("GAR003"))                 '1
            item.SubItems.Add(desGar005)                        '2
            item.SubItems.Add(leitor("GAR006"))                 '3
            item.SubItems.Add(leitor("GAR001"))                 '4  id da garagem
            item.SubItems.Add(leitor("GAR004"))                 '5 obs da garagem
            item.SubItems.Add(leitor("GAR008"))                 '6
            item.SubItems.Add(leitor("GAR001"))                 ' 7 id da garagem auto incremento



            pop += 1 ' faz a contagem dos registros no listview
        Loop
        conexao.Close() ' fecha a conexação com o banco de dados
        Call corList()
    End Sub
    Private Sub tbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbFiltro.SelectedIndexChanged
        Select Case tbFiltro.Text
            Case "TODAS AS GARAGENS"
                filtro = 99
            Case "LIVRE"
                filtro = 0
            Case "OCUPADO"
                filtro = 1
            Case "BLOQUEADO"
                filtro = 2
            Case "RESERVADO"
                filtro = 3
            Case "MANUTENCAO"
                filtro = 4
            Case Else
                filtro = 5
        End Select
        Call CarregaList() ' CARREGA O LIST COM O FILTRO SELECIONADO
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If
    End Sub
    Private Sub lvGar_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lvDados.SelectedIndexChanged
        Try
            If lvDados.SelectedItems.Count > 0 Then
                index = lvDados.Items.Item(lvDados.SelectedIndices(0)).Index
                Me.tbgar002.Text = Convert.ToString(lvDados.Items(lvDados.SelectedIndices(0)).Text)
                Me.tbgar006.Text = Me.lvDados.SelectedItems(0).SubItems(3).Text
                Me.tbgar003.Text = Me.lvDados.SelectedItems(0).SubItems(1).Text
                Me.tbgar004.Text = Me.lvDados.SelectedItems(0).SubItems(5).Text
                Me.idGAR008 = Me.lvDados.SelectedItems(0).SubItems(6).Text
                Me.tbgar001.Text = Me.lvDados.SelectedItems(0).SubItems(7).Text
                status = Me.lvDados.SelectedItems(0).SubItems(2).Text
                If idGAR008 = "S" Then
                    tbgar008.Checked = True
                    tbgar008.ForeColor = Color.Red
                Else
                    tbgar008.Checked = False
                    tbgar008.ForeColor = Color.Blue
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "ENTER / KEYDOWN"

    Private Sub pesquisa()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim sql As String
        If conexao.State = 0 Then
            conexao.Open()
        End If
        retorno = Nothing
        sql = "select * FROM PRT_GARAGENS WHERE GAR002 = '" & tbgar002.Text & "' ORDER BY GAR002 "
        da = New MySqlDataAdapter(sql, conexao)
        da.Fill(ds, "PRT_GARAGENS")
        If ds.Tables("PRT_GARAGENS").Rows.Count > 0 Then
            retorno = ds.Tables("PRT_GARAGENS").Rows(0).Item(1)
        Else
            retorno = Nothing
        End If
        conexao.Close()
    End Sub
    Private Sub btnhome_Click_1(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub

    Private Sub tbgar006_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbgar006.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbgar002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbgar002.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbgar002.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "É necessário identificar a garagem ou vaga! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Call pesquisa() ' verifica se a descrição já existe na tabela
                If retorno = Nothing Then
                    tbgar006.Focus()
                Else
                    If acao = "NOVO" Then
                        MetroFramework.MetroMessageBox.Show(Me, " Código informado já existe no cadastro! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        tbgar006.Focus()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub tbgar006_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbgar006.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbgar006.Text = "" Or tbgar006.Text = Nothing Then
                tbgar006.Text = "0"
            End If
            If CDbl(tbgar006.Text) = 0 Or CDbl(tbgar006.Text) < 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o número de vagas para a garagem! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                tbgar003.Focus()
            End If
        End If
    End Sub
    Private Sub tbgar003_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbgar003.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If Me.tbgar003.FindString(tbgar003.Text) = -1 Or tbgar003.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe uma localização válida! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                tbgar004.Focus()
            End If
        End If
    End Sub
#End Region







End Class
























