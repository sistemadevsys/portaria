Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class UserInicial
    Dim sql As String
    Dim gravar As Integer = 0
    Dim chave As String
    'Private Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Dim condicao As String
    Dim caminho As String
    Dim verifica As String
    Dim nome_arquivo_ini As String
    Dim iPath As String
    Dim ini As String
    Dim mno As Integer
    Dim pop As Integer
    Private Sub frmcaduser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
    Private Sub frmUserInicial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = False
        End If
    End Sub
    Private Sub frmAtalhos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            ' BOTÃO INCLUIR NOVO REGISTRO
            If btnF2.Enabled = True Then btnF2.PerformClick()
        End If
        If e.KeyCode = Keys.F3 Then
            ' BOTÃO EDITAR O REGISTRO
            If btnF3.Enabled = True Then btnF3.PerformClick()
        End If
        If e.KeyCode = Keys.F4 Then
            ' BOTÃO CANCELAR O PROCESSO
            If btnF4.Enabled = True Then btnF4.PerformClick()
        End If
        If e.KeyCode = Keys.F5 Then
            ' BOTÃO SALVAR O REGISTRO
            If btnF5.Enabled = True Then btnF5.PerformClick()
        End If
        If e.KeyCode = Keys.F6 Then
            ' EXCLUIR O REGISTRO
            If btnF6.Enabled = True Then btnF6.PerformClick()
        End If
        If e.KeyCode = Keys.F7 Then
            ' FECHAR O FORMULÁRIO O REGISTRO
            If btnF7.Enabled = True Then btnF7.PerformClick()
        End If
    End Sub
#Region "BEEP DO ENTER"
    Private Sub beep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
#End Region
    Private Sub frmUserInicial_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sql = "select * from usuarios where USU006 = 'S' and USU008 = '" & sistema & "' order by USU002"
        ini = 1 ' habilita ou não a seleção inicial no grid
        Call Botao(1) ' desliga o botão
        Call bloqueio(1) ' bloqueia os campos para edição
        Me.Text = "Cadastro Básico de Usuários"
        Call CarregaList()
    End Sub
    Private Sub Botao(arg)
        Select Case arg
            Case 1
                btnF2.Enabled = True           ' Botão Novo    ATIVADO
                btnF4.Enabled = False       ' Botão Cancela DESATIVADO
                btnF5.Enabled = False          ' Botão Salvar  DESATIVADO  
                btnF6.Enabled = True        ' Botão Excluir ATIVADO 
                btnF3.Enabled = True         ' Botão Alterar ATIVADO
                Call bloqueio(1)                 ' Bloqueia formulário para a edição
            Case 2
                btnF2.Enabled = False          ' Botão Novo    DESATIVADO
                btnF4.Enabled = True        ' Botão Cancela ATIVADO
                btnF5.Enabled = True         ' Botão Salvar  ATIVADO
                btnF6.Enabled = False       ' Botão Excluir DESATIVADO
                btnF3.Enabled = False       ' Botão Altera  DESATIVADO
                'btnlevel.Enabled = False         ' Botão Alterar ATIVADO
        End Select
    End Sub
    Private Sub bloqueio(arg)
        Select Case arg
            Case 1
                ' trava os campos para edição
                tbUSU001.ReadOnly = True
                tbUSU002.ReadOnly = True
                tbUSU003.ReadOnly = True
                tbUSU004.ReadOnly = True
                tbUSU005.ReadOnly = True
                lvdados.Enabled = True
                gbsenha.Visible = True
            Case 2
                ' Limpa os campos para a edição
                tbUSU001.Clear()
                tbUSU002.Clear()
                tbUSU003.Clear()
                tbUSU004.Clear()
                tbUSU004.Text = "123456"
                tbUSU005.Clear()
                lvdados.Enabled = False
                gbsenha.Visible = True
            Case 3
                ' libera os campos para edição
                tbUSU001.ReadOnly = True
                tbUSU002.ReadOnly = False
                tbUSU003.ReadOnly = False
                tbUSU004.ReadOnly = True
                tbUSU005.ReadOnly = False
                lvdados.Enabled = False
                gbsenha.Visible = True
        End Select
    End Sub
    Private Sub criacabecalho()
        ' atribui nome e largura das colunas do ListView  
        lvdados.Columns.Clear()
        lvdados.Items.Clear()
        lvdados.BackColor = Color.White
        lvdados.Columns.Add("Código", 0, HorizontalAlignment.Center)
        lvdados.Columns.Add("Descrição", 228, HorizontalAlignment.Left)
        lvdados.GridLines = False
        lvdados.FullRowSelect = True
        lvdados.CheckBoxes = False
        lvdados.View = View.Details
        lvdados.Sorting = SortOrder.None
    End Sub
    Public Sub CarregaList()
        Call criacabecalho()    ' monta o listview
        If conexao.State = ConnectionState.Closed Then conexao.Close()
        conexao.Open()
        Dim cmd As MySqlCommand = New MySqlCommand(sql, conexao)
        Dim leitor As MySqlDataReader = cmd.ExecuteReader()
        pop = 0
        Do While leitor.Read()
            Dim novoitem As New ListViewItem()
            novoitem.Text = leitor(0)
            ' distribui os itens na tabela conforme as colunas delimitadas
            novoitem = lvdados.Items.Add(leitor("USU001").ToString) ' 
            novoitem.SubItems.Add(leitor("USU002").ToString) ' 
            pop += 1
        Loop
        conexao.Close()                                   ' fecha a conexação com o banco de dados
        txtpesquisar.Enabled = True
        Call corList()
        If pop > 0 And ini = 1 Then
            ini = 0
            Me.lvdados.Items(0).Selected = True
            lvdados.Select()
        End If
        ' cor das linhas do grid
    End Sub
    Private Sub corList()
        ' Cria o detalhe de cores das linhas no listview
        For Each item As ListViewItem In lvdados.Items
            If (item.Index Mod 2) = 0 Then
                item.BackColor = Color.LavenderBlush
            Else
                item.BackColor = Color.White
            End If
        Next
    End Sub
    Private Sub testacampos()
        gravar = 0
        If tbUSU003.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o nome completo do usuário ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbUSU003.Select()
            gravar = 0
            Exit Sub
        End If
        If tbUSU005.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o cargo ocupado pelo usuário. ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbUSU005.Select()
            gravar = 0
            Exit Sub
        End If
        If tbUSU002.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o login do usuário para acesso ao sistema ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbUSU002.Select()
            gravar = 0
            Exit Sub
        End If
        If tbUSU004.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe a senha de acesso do usuário ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbUSU004.Select()
            gravar = 0
            Exit Sub
        End If

        If tbUSU004.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Obrigatório informar o email do usuário! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            gravar = 0
            Exit Sub
        End If
        gravar = 1
    End Sub
    Private Sub gravapass(arg)
        Select Case arg
            Case 0
                ' BUSCA A ID DO USUÁRIO CADASTRADO
                conexao.Open()
                Dim sql As String
                sql = "select * from usuarios where USU002 = '" & tbUSU002.Text & "' and USU006 = 'S' and USU008 = '" & sistema & "' ORDER BY USU002 "

                Dim cmd As New MySqlCommand(sql, conexao)
                Dim drdr As MySqlDataReader
                drdr = cmd.ExecuteReader
                drdr.Read()
                tbUSU001.Text = drdr.Item("USU001")       ' CÓDIGO DO USUÁRIO NO SISTEMA
                conexao.Close()
            Case 1
                ' GRAVA DADOS DA SENHA DO USUÁRIO PARA ENVIO POR EMAIL
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim st As String = "insert into uspass(USU001,USU004,USU008)VALUES('" & tbUSU001.Text & "','" & tbUSU004.Text & "','" & sistema & "')"
                Dim cmd As New MySqlCommand(st, conexao)
                conexao.Open()
                cmd.ExecuteNonQuery()
                MetroFramework.MetroMessageBox.Show(Me, " Operação realizada com sucesso!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                mno = 0
                conexao.Close()
        End Select
    End Sub
    Private Sub lvdados_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvdados.SelectedIndexChanged
        Try
            If lvdados.SelectedItems.Count > 0 Then
                tbUSU001.Text = Convert.ToString(lvdados.Items(lvdados.SelectedIndices(0)).Text)
                Call busca()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message)
        End Try
    End Sub
    Private Sub busca()
        Try
            If lvdados.SelectedItems.Count > 0 Then
                If conexao.State = ConnectionState.Closed Then conexao.Close()
                conexao.Open()
                Dim idxUserLogin, idxUserName, idxUserSenha, idxUserCargo As String
                Dim cmd As New MySqlCommand("select * from usuarior where USU001 = '" & tbUSU001.Text & "' and USU008 = '" & sistema & "' order by USU001", conexao)
                Dim drdr As MySqlDataReader
                drdr = cmd.ExecuteReader
                drdr.Read()
                idxUserLogin = drdr.GetOrdinal("USU002")
                idxUserName = drdr.GetOrdinal("USU003")
                idxUserSenha = drdr.GetOrdinal("USU004")
                idxUserCargo = drdr.GetOrdinal("USU005")
                If Not drdr.IsDBNull(idxUserLogin) Then tbUSU002.Text = drdr.Item("USU002") Else tbUSU002.Text = ""
                If Not drdr.IsDBNull(idxUserName) Then tbUSU003.Text = drdr.Item("USU003") Else tbUSU003.Text = ""
                If Not drdr.IsDBNull(idxUserSenha) Then tbUSU004.Text = drdr.Item("USU004") Else tbUSU004.Text = ""
                If Not drdr.IsDBNull(idxUserCargo) Then tbUSU005.Text = drdr.Item("USU005") Else tbUSU005.Text = ""
                cmd.Cancel()
                conexao.Close()
            End If
        Catch ex As Exception
            conexao.Close()
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub wUserName_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbUSU003.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbUSU003.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o nome completo do usuário ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                tbUSU005.Select()
            End If
        End If
    End Sub

    Private Sub wUserCargo_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbUSU005.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbUSU005.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o cargo ocupado pelo usuário. ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                tbUSU002.Select()
            End If
        End If
    End Sub
    Private Sub wUserLogin_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbUSU002.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbUSU002.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o login do usuário para acesso ao sistema ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                tbUSU004.Select()
            End If
        End If
    End Sub
    Private Sub wUsersenha_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbUSU004.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbUSU004.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe a senha de acesso do usuário ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                tbUSU007.Focus()
            End If
        End If
    End Sub
    Private Sub UserMail_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbUSU007.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbUSU004.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Obrigatório informar o email do usuário! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                btnF5.PerformClick()
            End If
        End If
    End Sub
    Private Sub txtpesquisar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpesquisar.TextChanged
        chave = ""
        chave = "%" & txtpesquisar.Text
        sql = "select * from usuarios where USU002 like '" & chave & "%' order by USU002"
        Call CarregaList()
    End Sub

    Private Sub btnvolta_Click(sender As System.Object, e As System.EventArgs) Handles btnvolta.Click
        txtpesquisar.Clear()
        sql = "select * from usuarios order by USU002"
        ini = 1 ' habilita ou não a seleção inicial no grid
        Call CarregaList()
    End Sub
    Private Sub btnF2_Click(sender As Object, e As EventArgs) Handles btnF2.Click
        ' BOTÃO NOVO
        Call bloqueio(2)     ' Limpa os campos para nova inclusão
        Call Botao(2)        ' liga os botoes 
        Call bloqueio(3)    ' libera os campos para edição
        tbUSU003.Select()
        mno = 1
    End Sub
    Private Sub btnF3_Click(sender As Object, e As EventArgs) Handles btnF3.Click
        ' BOTÃO EDITAR
        If lvdados.SelectedItems.Count > 0 Then
            Call Botao(2)
            Call bloqueio(3)
            mno = 0
            gbsenha.Visible = False
            tbUSU003.Focus()
        End If
    End Sub
    Private Sub btnF4_Click(sender As Object, e As EventArgs) Handles btnF4.Click
        ' BOTÃO CANCELAR
        ini = 1
        Call Botao(1) ' desliga o botão
        Call bloqueio(1) ' bloqueia os campos para edição
        Call CarregaList()
    End Sub
    Private Sub btnF5_Click(sender As Object, e As EventArgs) Handles btnF5.Click
        ' BOTÃO GRAVAR
        Try
            If mno = 1 Then
                Call testacampos() ' verifica se os campos obrigatorios foram prenechidos
                If gravar = 1 Then
                    Dim esconder As String
                    esconder = geraHash(tbUSU004.Text)
                    If conexao.State = ConnectionState.Open Then conexao.Close()
                    Dim st As String = "insert into usuarios(USU002,USU003,USU004,USU005,USU006,USU007,USU008,USU009)VALUES('" & tbUSU002.Text & "','" & tbUSU003.Text & "','" & esconder & "','" & tbUSU005.Text & "','S','" & tbUSU007.Text & "','" & sistema & "','1')"
                    Dim cmd As New MySqlCommand(st, conexao)
                    conexao.Open()
                    cmd.ExecuteNonQuery()
                    MetroFramework.MetroMessageBox.Show(Me, " Operação realizada com sucesso!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    mno = 0
                    conexao.Close()
                    Call gravapass(0) ' BUSCA O ID DO USUÁRIO NA TABELA USUARIOS - ** CAMPO USU001 **
                    Call gravapass(1) ' GRAVA DADOS DA SENHA DO USUÁRIO PARA ENVIO POR EMAIL
                    Call Botao(1)
                    ini = 1
                    Call CarregaList()
                End If
            Else
                Call testacampos() ' verifica se os campos obrigatorios foram prenechidos
                If gravar = 1 Then
                    If conexao.State = ConnectionState.Open Then conexao.Close()
                    Dim s1 As String = "update usuarios set USU002 = '" & tbUSU002.Text & "',USU003 = '" & tbUSU003.Text & "', USU005 = '" & tbUSU005.Text & "', USU007 = '" & tbUSU007.Text & "' WHERE USU001 ='" & tbUSU001.Text & "'"
                    Dim cmnd As New MySqlCommand(s1, conexao)
                    conexao.Open()
                    cmnd.ExecuteNonQuery()
                    MetroFramework.MetroMessageBox.Show(Me, "Registro atualizado com sucesso! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    conexao.Close()
                    ini = 0
                    Call Botao(1)
                    Call CarregaList()
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message)
        End Try
    End Sub
    Private Sub btnF6_Click(sender As Object, e As EventArgs) Handles btnF6.Click
        ' BOTÃO EXCLUIR
        If (MetroFramework.MetroMessageBox.Show(Me, " Deseja mesmo excluir o registro ?", "" & legenda & "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = MsgBoxResult.Yes Then
            If tbUSU001.Text = Nothing Or tbUSU001.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Me, " Sem registro para a exclusão! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If tbUSU002.Text = iUsername Then
                    MetroFramework.MetroMessageBox.Show(Me, "Exclusão proibida! Usuário encontra-se ativo no sistema. (Verifique)", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If conexao.State = ConnectionState.Open Then conexao.Close()
                    conexao.Open()
                    Dim st = "delete from usuarios where USU001 = '" & tbUSU001.Text & "'"
                    Dim cmd As New MySqlCommand(st, conexao)
                    cmd.ExecuteNonQuery()
                    conexao.Close()
                    MetroFramework.MetroMessageBox.Show(Me, " O registro foi excluído definitivamente!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    ini = 1
                    Call bloqueio(2)     ' Limpa os campos para nova inclusão
                    Call Botao(1)
                    Call CarregaList()
                    mno = 0
                End If
            End If
        End If
    End Sub
    Private Sub btnF7_Click(sender As Object, e As EventArgs) Handles btnF7.Click
        ' BOTÃO SAIR
        MetroFramework.MetroMessageBox.Show(Me, "O Sistema será reiniciado para carregar a lista de usuários.", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Dispose()
        Application.Exit()
    End Sub





End Class
























