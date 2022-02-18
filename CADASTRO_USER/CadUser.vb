Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class CadUser
#Region "VARIAVEIS DO FORMULÁRIO"
    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Protected regionHandle As IntPtr
    Dim tabela, ARG1, ARG2, ARG3, texto, retorno As String
    Dim acao As String
    Dim sql As String
    Dim index, grava As Integer
    Dim pop As Integer
#End Region

#Region "MOVER FORMULÁRIO"
    Dim objDraw As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath
    Dim mover As New MoveForm
    Private Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure
    Private Sub frmlogin_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub frmlogin_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub
#End Region

#Region "START DO FORMULÁRIO"
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
    End Sub
#Region "BEEP DO ENTER"
    Private Sub beep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
#End Region
    Private Sub CadUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height - 100) / 2
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width + 200) / 2
        Me.CancelButton = btnhome

        redondo(0, 0, Panel2, 20, 20)
        redondo(0, 0, tbcp120, 20, 20)

        Call botao(0) ' bloqueio dos boptões
        Call TrataTextBox(0) ' limpa os textbox para receber informações do list LVdados
        Call TrataTextBox(2) ' bloqueia os textbox para edição
        Call carregalist()
        If pop > 0 Then
            Me.lvdados.Items(0).Selected = True
            lvdados.Select()
        End If
    End Sub
#End Region

#Region "FUNÇÕES"

    Private Sub redondo(arg1, arg2, componente, arg3, arg4)
        regionHandle = New IntPtr(CreateRoundRectRgn(arg1, arg2, componente.Width, componente.Height, arg3, arg4))
        componente.Region = Region.FromHrgn(regionHandle)
        componente.Region.ReleaseHrgn(regionHandle)
    End Sub

    'Private Sub pesquisa()
    '    Dim ds As New DataSet
    '    Dim da As MySqlDataAdapter
    '    Dim sql As String
    '    If conexao.State = 0 Then
    '        conexao.Open()
    '    End If
    '    retorno = Nothing
    '    sql = "select * from " & tabela & " where " & ARG2 & " = '" & tbNovo.Text & "' and " & ARG3 & " = '0'"
    '    da = New MySqlDataAdapter(sql, conexao)
    '    da.Fill(ds, tabela)
    '    If ds.Tables(tabela).Rows.Count > 0 Then
    '        retorno = ds.Tables(tabela).Rows(0).Item(1)
    '    Else
    '        retorno = Nothing
    '    End If
    '    conexao.Close()
    'End Sub

    Private Sub carregalist()
        lvdados.Items.Clear()
        lvdados.BackColor = Color.White
        lvdados.View = View.Details
        lvdados.FullRowSelect = True
        lvdados.GridLines = True
        lvdados.CheckBoxes = False
        lvdados.View = View.Details
        lvdados.Sorting = SortOrder.None
        sql = "select * from usuarios where USU006 = 'S' and USU008 = '" & sistema & "' order by USU002"
        If conexao.State = ConnectionState.Closed Then conexao.Close()
        If conexao.State = 0 Then
            conexao.Open()
        End If
        pop = 0
        Dim cmd As MySqlCommand = New MySqlCommand(sql, conexao)
        Dim leitor As MySqlDataReader = cmd.ExecuteReader()
        Do While leitor.Read()
            Dim item As New ListViewItem()
            item = lvdados.Items.Add(leitor("USU001").ToString) ' 0
            item.SubItems.Add(leitor("USU002").ToString)        ' 1
            item.SubItems.Add(leitor("USU003").ToString)        ' 2
            item.SubItems.Add(leitor("USU005").ToString)        ' 3
            item.SubItems.Add(leitor("USU007").ToString)        ' 4
            pop += 1
        Loop
        conexao.Close()                                   ' fecha a conexação com o banco de dados
        cmd.Dispose()
    End Sub
    Private Sub lvDados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvdados.SelectedIndexChanged
        Try
            If lvdados.SelectedItems.Count > 0 Then
                index = lvdados.Items.Item(lvdados.SelectedIndices(0)).Index
                USU001.Text = Convert.ToString(lvdados.Items(lvdados.SelectedIndices(0)).Text)
                USU002.Text = Me.lvdados.SelectedItems(0).SubItems(1).Text
                USU003.Text = Me.lvdados.SelectedItems(0).SubItems(2).Text
                USU005.Text = Me.lvdados.SelectedItems(0).SubItems(3).Text
                USU007.Text = Me.lvdados.SelectedItems(0).SubItems(4).Text
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message)
        End Try
    End Sub
    Private Sub botao(arg)
        Select Case arg
            Case 0
                ' bloqueia os botões
                btnF2.Enabled = True        ' Botão Novo    ATIVADO
                btnF3.Enabled = True      ' Botão Alterar ATIVADO
                btnF4.Enabled = False    ' Botão Cancela DESATIVADO
                btnF5.Enabled = False       ' Botão Salvar  DESATIVADO  
                btnF6.Enabled = True     ' Botão Excluir ATIVADO 
                btnF8.Enabled = True     ' botão do perfil
            Case 1
                ' libera botoes
                btnF2.Enabled = False          ' Botão Novo    DESATIVADO
                btnF3.Enabled = False        ' Botão Altera  DESATIVADO
                btnF4.Enabled = True        ' Botão Cancela ATIVADO
                btnF5.Enabled = True         ' Botão Salvar  ATIVADO
                btnF6.Enabled = False       ' Botão Excluir DESATIVADO
                btnF8.Enabled = False
        End Select
    End Sub
    Private Sub TrataTextBox(arg)
        Select Case arg
            Case 0
                ' LIMPA TEXTBOX PARA EDIÇÃO
                USU001.Clear()
                USU003.Clear()
                USU002.Clear()
                USU005.Clear()
                USU007.Clear()
            Case 1
                ' LIBERA TEXTBOX PARA EDIÇÃO
                USU001.ReadOnly = True
                USU003.ReadOnly = False
                USU002.ReadOnly = False
                USU005.ReadOnly = False
                USU007.ReadOnly = False
            Case 2
                ' BLOQUEIA TEXTBOX PARA EDIÇÃO
                USU001.ReadOnly = True
                USU003.ReadOnly = True
                USU002.ReadOnly = True
                USU005.ReadOnly = True
                USU007.ReadOnly = True
        End Select
    End Sub
    Private Sub TestaCampos()
        grava = 0
        If USU003.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o nome do usuário ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            USU003.Focus()
            Exit Sub
        End If
        If USU005.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o cargo do usuário ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            USU005.Focus()
            Exit Sub
        End If
        If USU002.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o login de acesso! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            USU002.Focus()
            Exit Sub
        End If
        grava = 10
    End Sub
    Private Sub gravapass(arg)
        Select Case arg
            Case 0
                ' BUSCA A ID DO USUÁRIO CADASTRADO
                conexao.Open()
                Dim sql As String
                sql = "select * from usuarios where USU002 = '" & USU002.Text & "' and USU006 = 'S' and USU008 = '" & sistema & "' ORDER BY USU002 "
                Dim cmd As New MySqlCommand(sql, conexao)
                Dim drdr As MySqlDataReader
                drdr = cmd.ExecuteReader
                drdr.Read()
                USU001.Text = drdr.Item("USU001")       ' CÓDIGO DO USUÁRIO NO SISTEMA
                conexao.Close()
            Case 1
                ' GRAVA DADOS DA SENHA DO USUÁRIO PARA ENVIO POR EMAIL
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim st As String = "insert into uspass(USU001,USU004,USU008)VALUES('" & USU001.Text & "','123456','" & sistema & "')"
                Dim cmd As New MySqlCommand(st, conexao)
                conexao.Open()
                cmd.ExecuteNonQuery()
                conexao.Close()
        End Select
    End Sub


#End Region

#Region "BOTÕES"
    Private Sub btnF2_Click(sender As Object, e As EventArgs) Handles btnF2.Click
        ' INCLUIR NOVO REGISTRO
        acao = "NOVO"
        Call botao(1) ' DESBLOQUEIO DOS BOTOES
        Call TrataTextBox(0) ' LIMPA OS TEXTBOX PARA EDIÇÃO
        Call TrataTextBox(1) ' LIBERA OS TEXTBOX PARA EDIÇÃO
        USU003.Focus()
    End Sub
    Private Sub btnF3_Click(sender As Object, e As EventArgs) Handles btnF3.Click
        ' EDITA PARA ALTERAÇÃO
        If pop > 0 Then
            acao = "ALTERA"
            Call botao(1) ' DESBLOQUEIO DOS BOTOES
            Call TrataTextBox(1) ' LIBERA OS TEXTBOX PARA EDIÇÃO
            USU003.Focus()
        End If
    End Sub
    Private Sub btnF4_Click(sender As Object, e As EventArgs) Handles btnF4.Click
        ' CANCELA AÇÃO DE EDIÇÃO E INCLUSÃO
        Call botao(0) ' bloqueio dos boptões
        'Call TrataTextBox(0) ' limpa os textbox para receber informações do list LVdados
        Call TrataTextBox(2) ' bloqueia os textbox para edição
        If pop > 0 Then
            Me.lvdados.Items(0).Selected = True
            lvdados.Focus()
            lvdados.Select()
        End If
    End Sub
    Private Sub btnF5_Click(sender As Object, e As EventArgs) Handles btnF5.Click
        ' SALVA NA TABELA

        Call TestaCampos() ' TESTA OS TEXTBOX ANTES DE GRAVAR NA TABELA

        If grava = 10 Then
            'Call pesquisa()
            If acao = "NOVO" Then
                If retorno = Nothing Then
                    Dim esconder As String
                    esconder = geraHash("123456")
                    sql = "insert into usuarios(USU002,USU003,USU004,USU005,USU006,USU007,USU008,USU009)VALUES('" & USU002.Text & "','" & USU003.Text & "','" & esconder & "','" & USU005.Text & "','S','" & USU007.Text & "','" & sistema & "','1')"
                Else
                    MetroFramework.MetroMessageBox.Show(Me, " Usuário de login já existe no cadastro. Verifique! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                    USU003.Focus()
                End If
            Else
                sql = "update usuarios set USU002 = '" & USU002.Text & "',USU003 = '" & USU003.Text & "', USU005 = '" & USU005.Text & "', USU007 = '" & USU007.Text & "' WHERE USU001 ='" & USU001.Text & "'"
            End If
            Dim cmd As New MySqlCommand(sql, conexao)
            conexao.Open()
            cmd.ExecuteNonQuery()
            MetroFramework.MetroMessageBox.Show(Me, "R e g i s t r a d o", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            conexao.Close()

            Call gravapass(0) ' BUSCA O ID DO USUÁRIO NA TABELA USUARIOS - ** CAMPO USU001 **
            Call gravapass(1) ' GRAVA DADOS DA SENHA DO USUÁRIO PARA ENVIO POR EMAIL

            Call botao(0) ' bloqueia os botoes
            Call TrataTextBox(2) ' bloqueia os textbox editados
            Call carregalist()
            If pop > 0 Then
                If acao = "NOVO" Then
                    Me.lvdados.Items(0).Selected = True
                    lvdados.Select()
                Else
                    Me.lvdados.Items(index).Selected = True
                    lvdados.Select()
                End If
            End If
        End If
    End Sub
    Private Sub btnF6_Click(sender As Object, e As EventArgs) Handles btnF6.Click
        ' EXLUIR REGISTRO
        If pop > 0 Then
            If (MetroFramework.MetroMessageBox.Show(Me, " Deseja mesmo excluir o registro ?", "" & legenda & "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) = MsgBoxResult.Yes Then
                If conexao.State = ConnectionState.Open Then conexao.Close()
                conexao.Open()
                Dim st = "UPDATE usuarios SET USU006 = 'N' where USU001 = '" & USU001.Text & "'"
                Dim cmd As New MySqlCommand(st, conexao)
                cmd.ExecuteNonQuery()
                conexao.Close()
                MetroFramework.MetroMessageBox.Show(Me, " O registro foi excluído", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Call botao(0) ' bloqueia os botoes
                Call TrataTextBox(2) ' bloqueia os textbox editados
                Call TrataTextBox(0) ' LIMPA OS TEXTBOX
                Call carregalist()
                If pop > 0 Then
                    Me.lvdados.Items(0).Selected = True
                    lvdados.Select()
                End If
            End If
        End If
    End Sub
#End Region

#Region "ENTER"
    Private Sub USU003_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles USU003.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If USU003.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o nome do usuário ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                USU003.Focus()
            Else
                USU005.Focus()
            End If
        End If
    End Sub
    Private Sub USU005_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles USU005.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If USU005.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o cargo do usuário ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                USU005.Focus()
            Else
                USU002.Focus()
            End If
        End If
    End Sub
    Private Sub USU002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles USU002.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If USU002.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o login de acesso! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                USU002.Focus()
            Else
                USU007.Focus()
            End If
        End If
    End Sub
    Private Sub USU007_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles USU007.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            btnF5.PerformClick()
        End If
    End Sub
#End Region

    Private Sub btnhome_Click_1(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub
End Class
























