Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmArmarios
    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Protected regionHandle As IntPtr


#Region "VARIÁVEIS"
    Dim sql As String
    Dim filtro As Integer = 0
    Dim index As Integer
    Dim retorno As String = Nothing
    Dim grava As String = "Não"
    Dim Data_hoje As DateTime = DateTime.Now
    Dim idARM002, idARM004, status As String
    Dim acao As String
    Dim codBloq As Integer
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
    Private Sub frmArmarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
    Private Sub frmArmarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        redondo(0, 0, tarja, 20, 20)
        redondo(0, 0, Panel1, 20, 20)
        grava = "Não"
        Me.CancelButton = btnhome
        Call Bloqueio_Botões(0) ' BLOQUEIO DOS BOTÕES
        Call bloqueia_texto(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS
        Call bloqueia_texto(2)
        tbFiltro.SelectedIndex = 0
        Call CarregaList() ' popula o grid de cadastro das garagens
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If

    End Sub
#End Region

#Region "LISTVIEW"
    Private Sub CarregaList()
        Call filtrar()
        lvDados.Items.Clear()
        lvDados.GridLines = False
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
            idARM002 = IIf(Convert.IsDBNull(leitor("ARM002")) = True, "", leitor("ARM002"))
            idARM004 = IIf(Convert.IsDBNull(leitor("ARM004")) = True, "", leitor("ARM004"))
            Call MontaStatus() ' monta o status da garagem (OCUPADO/LIVRE ETC)

            item = lvDados.Items.Add("   " & idARM002)
            item.SubItems.Add(idARM004)                         '2 NUMERO DO ARMÁRIO
            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("ARM008")) = True, "", leitor("ARM008"))) '3
            item.SubItems.Add(leitor("ARM001"))                 '1 NUMERO DO ARMÁRIO
            pop += 1 ' faz a contagem dos registros no listview
        Loop
        conexao.Close() ' fecha a conexação com o banco de dados
        Call corList()
    End Sub
    Private Sub corList()
        For i As Integer = 0 To lvDados.Items.Count - 1
            lvDados.Items(i).UseItemStyleForSubItems = False
            If lvDados.Items(i).SubItems.Count > 1 Then
                If lvDados.Items(i).SubItems(1).Text.ToString = "LIVRE" Then
                    lvDados.Items(i).ImageIndex = 0
                ElseIf lvDados.Items(i).SubItems(1).Text.ToString = "OCUPADO" Then
                    lvDados.Items(i).ImageIndex = 1
                ElseIf lvDados.Items(i).SubItems(1).Text.ToString = "BLOQUEADO" Then
                    lvDados.Items(i).ImageIndex = 2
                End If
            End If
        Next
    End Sub
    Private Sub lvDados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDados.SelectedIndexChanged
        Try
            If lvDados.SelectedItems.Count > 0 Then
                index = lvDados.Items.Item(lvDados.SelectedIndices(0)).Index
                status = Me.lvDados.SelectedItems(0).SubItems(1).Text
                Me.tbArm002.Text = Trim(Convert.ToString(lvDados.Items(lvDados.SelectedIndices(0)).Text))
                Me.tbArm008.Text = Trim(Me.lvDados.SelectedItems(0).SubItems(2).Text)
                Me.tbArm001.Text = Me.lvDados.SelectedItems(0).SubItems(3).Text
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message)
        End Try
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub btnnovo_Click(sender As Object, e As EventArgs) Handles btnnovo.Click
        ' NOVO REGISTRO
        acao = "NOVO"
        Call Bloqueio_Botões(1) ' bloqueia os botões
        Call bloqueia_texto(1) ' libera os campos dos textos
        Call bloqueia_texto(2) ' limpa os campos para edição
        tbArm002.Focus()       ' direciona o focus para o campo de identificação
    End Sub
    Private Sub btnaltera_Click(sender As Object, e As EventArgs) Handles btnaltera.Click
        ' EDITA E ALTERA O REGISTRO
        If pop > 0 Then
            If status = "LIVRE" Then
                acao = "ALTERA"
                ' edita e altera o registro
                Call Bloqueio_Botões(1) ' bloqueia os botões
                Call bloqueia_texto(1) ' libera os campos dos textos
                tbArm002.Focus()       ' direciona o focus para o campo de identificação
            Else
                MetroFramework.MetroMessageBox.Show(Me, " Atenção: Status do armário não permite a edição. ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If pop > 0 Then
                    Me.lvDados.Items(index).Selected = True
                    lvDados.Select()
                End If
            End If
        End If
    End Sub
    Private Sub btncancela_Click(sender As Object, e As EventArgs) Handles btncancela.Click
        ' CANCELA A EDIÇÃO 
        If pop = 0 Then
            tbFiltro.SelectedIndex = 0
            index = 0
        End If
        Call Bloqueio_Botões(0) ' BLOQUEIO DOS BOTÕES
        Call bloqueia_texto(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS
        Call CarregaList() ' popula o grid de cadastro das garagens
        Tabela.SelectedIndex = 0
        If pop > 0 Then
            Me.lvDados.Items(index).Selected = True
            lvDados.Select()
        End If
    End Sub
    Private Sub testaCampos()
        grava = "Não"
        If tbArm002.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "É necessário identificar o armário! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            grava = "Não"
            tbArm002.Focus()
            Exit Sub
        End If
        Call pesquisa()
        If acao = "NOVO" Then
            If retorno = Nothing Then
                grava = "Sim"
            Else
                MetroFramework.MetroMessageBox.Show(Me, " Já existe um armário com essa identificação! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbArm002.Focus()
                grava = "Não"
                Exit Sub
            End If
        Else
            grava = "Sim"
        End If
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        ' GRAVA EM ARQUIVO
        If acao = "NOVO" Then
            ' QUANDO FOI UM NOVO REGISTRO
            Call testaCampos()
            If grava = "Sim" Then
                Try
                    If conexao.State = ConnectionState.Open Then conexao.Close()
                    Dim sql As String = "insert into prt__armarios(ARM002,ARM008,ARM004)VALUES('" & tbArm002.Text & "','" & tbArm008.Text & "','0')"
                    Dim cmd As New MySqlCommand(sql, conexao)
                    conexao.Open()
                    cmd.ExecuteNonQuery()
                    MetroFramework.MetroMessageBox.Show(Me, "Registro realizado com sucesso!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    conexao.Close()
                    acao = ""
                    tbFiltro.SelectedIndex = 0
                    Call Bloqueio_Botões(0) ' BLOQUEIO DOS BOTÕES
                    Call bloqueia_texto(0) ' BLOQUEIA A EDIÇÃO DOS CAMPOS
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
            Call testaCampos()
            If grava = "Sim" Then
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim sql As String = "update prt_armarios set ARM002 = '" & tbArm002.Text & "',ARM008 = '" & tbArm008.Text & "' WHERE ARM001 = '" & tbArm001.Text & "'"
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
        ' EXCLUIR O REGISTRO
        If status = "LIVRE" Then
            If (MetroFramework.MetroMessageBox.Show(Me, " Deseja mesmo excluir o armário ?", "" & legenda & "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = MsgBoxResult.Yes Then
                If conexao.State = ConnectionState.Closed Then conexao.Close()
                conexao.Open()
                Dim st = "delete from prt_armarios where ARM001 = '" & tbArm001.Text & "'"
                Dim comando As New MySqlCommand(st, conexao)
                comando.ExecuteNonQuery()
                conexao.Close()
                MetroFramework.MetroMessageBox.Show(Me, " O Registro foi excluído definitivamente! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                acao = ""
                Call CarregaList() ' popula o grid de cadastro das garagens
                If pop > 0 Then
                    Me.lvDados.Items(0).Selected = True
                    lvDados.Select()
                End If
            End If
        Else
            MetroFramework.MetroMessageBox.Show(Me, "O Status do armário não permite a exclusão! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
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
        Dim sql As String = "update prt_armarios set ARM004 = '" & codBloq & "' WHERE ARM001 = '" & tbArm001.Text & "'"
        Dim cmd As New MySqlCommand(sql, conexao)
        cmd.ExecuteNonQuery()
        conexao.Close()
    End Sub
    Private Sub filtrar()
        Select Case filtro
            Case 99
                sql = "select * from prt_armarios order by ARM002"
            Case 0 ' livre
                sql = "select * from prt_armarios where ARM004 = 0 ORDER BY ARM002"
            Case 1 ' ocupado
                sql = "select * from prt_armarios where ARM004 = 1 ORDER BY ARM002"
            Case 2 ' bloqueado
                sql = "select * from prt_armarios where ARM004 = 2 ORDER BY ARM002"
        End Select
    End Sub
    Private Sub pesquisa()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim sql As String
        If conexao.State = 0 Then
            conexao.Open()
        End If
        retorno = Nothing
        sql = "select * from prt_armarios where ARM002 = '" & tbArm002.Text & "' ORDER BY ARM002 "
        da = New MySqlDataAdapter(sql, conexao)
        da.Fill(ds, "PRT_ARMARIOS")
        If ds.Tables("PRT_ARMARIOS").Rows.Count > 0 Then
            retorno = ds.Tables("PRT_ARMARIOS").Rows(0).Item(1)
        Else
            retorno = Nothing
        End If
        conexao.Close()
    End Sub
    Private Sub MontaStatus()
        Select Case idARM004
            Case 0
                idARM004 = "LIVRE"
            Case 1
                idARM004 = "OCUPADO"
            Case 2
                idARM004 = "BLOQUEADO"
        End Select
    End Sub
    Private Sub bloqueia_texto(arg)
        Select Case arg
            Case 0
                ' bloqieia os campos para edição
                tbArm002.ReadOnly = True
                tbArm008.ReadOnly = True
                Panel4.Enabled = True
            Case 1
                ' libera os campos para edição
                tbArm002.ReadOnly = False
                tbArm008.ReadOnly = False
                Panel4.Enabled = False
            Case 2
                ' limpa os campos para edição
                tbArm002.Clear()
                tbArm008.Clear()
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




#End Region

#Region "COMPONENTES"
    Private Sub Strip1_Click(sender As Object, e As EventArgs) Handles Strip1.Click
        ' bloqueio do armário
        If status = "LIVRE" Then
            codBloq = 2
            Call gravar()
            tbFiltro.SelectedIndex = 3
            Call CarregaList() ' popula o grid de cadastro das garagens
            If pop > 0 Then
                Me.lvDados.Items(index).Selected = True
                lvDados.Select()
            End If
        Else
            MetroFramework.MetroMessageBox.Show(Me, "O Status do Armário não permite o bloqueio!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub Strip3_Click(sender As Object, e As EventArgs) Handles Strip3.Click
        ' LIBERA O ARMÁRIO BLOQUEADO
        If status = "BLOQUEADO" Then
            codBloq = 0
            Call gravar()
            tbFiltro.SelectedIndex = 0
            Call CarregaList() ' popula o grid de cadastro das garagens
            If pop > 0 Then
                Me.lvDados.Items(index).Selected = True
                lvDados.Select()
            End If
        Else
            MetroFramework.MetroMessageBox.Show(Me, "O Status do Armário não permite o bloqueio!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub tbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbFiltro.SelectedIndexChanged
        Select Case tbFiltro.Text
            Case "TODOS OS REGISTROS"
                filtro = 99
            Case "LIVRE"
                filtro = 0
            Case "OCUPADO"
                filtro = 1
            Case "BLOQUEADO"
                filtro = 2
        End Select
        Call CarregaList() ' CARREGA O LIST COM O FILTRO SELECIONADO
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If
    End Sub
    Private Sub menuopc_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles menuopc.Opening
        If pop <= 0 Then
            menuopc.Enabled = False
        Else
            menuopc.Enabled = True
        End If
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub
#End Region

#Region "ENTER"
    Private Sub tbArm002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbArm002.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbArm002.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "É necessário identificar o armário! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Call pesquisa() ' verifica se a descrição já existe na tabela
                If retorno = Nothing Then
                    tbArm008.Focus()
                Else
                    If acao = "NOVO" Then
                        MetroFramework.MetroMessageBox.Show(Me, " Código informado já existe no cadastro! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        tbArm008.Focus()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub tbArm008_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbArm008.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            btnsave.Focus()
        End If
    End Sub

#End Region




End Class
























