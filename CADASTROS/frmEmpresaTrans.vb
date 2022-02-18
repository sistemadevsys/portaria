Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmEmpresaTrans
    Dim iEMP002, FUN002, FUN028, iFUN028, xEMP002, xEMP003 As New TextBox
    Dim sql, chave As String
    Dim filtro, index As Integer
    Dim Data_hoje As DateTime = DateTime.Now
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
    Private Sub frmPadrao_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            ' BOTÃO SALVAR O REGISTRO
            alterado = 0
            Me.Close()
        End If
    End Sub

    Private Sub frmEmpresaTrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        R1.Checked = True
        tbPesquisa.Clear()
        tbPesquisa.Refresh()
        FUN002.Text = Repositorio.FUN002.Text
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        alterado = 0
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' grava as informações na tabela
        If (MetroFramework.MetroMessageBox.Show(Me, " Confirma a transferência de cadastro ? ", "" & legenda & "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) = MsgBoxResult.Yes Then
            If conexao.State = ConnectionState.Open Then conexao.Close()
            Dim sql As String = "update prt_cadfun set FUN028 = '" & iFUN028.Text & "', EMP002 = '" & iEMP002.Text & "', FUN025 = '" & Format(Data_hoje, "yyyy-MM-dd") & "', FUN004 = 'DEFINIR', FUN005 = 'DEFINIR' WHERE FUN002 = '" & FUN002.Text & "'"
            Dim cmd As New MySqlCommand(sql, conexao)
            conexao.Open()
            cmd.ExecuteNonQuery()
            MetroFramework.MetroMessageBox.Show(Me, " Cadastro foi transferido! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            conexao.Close()
            alterado = 500
            Me.Close()
        End If
    End Sub

    Private Sub R1_CheckedChanged(sender As Object, e As EventArgs) Handles R1.CheckedChanged
        ' EMPRESAS
        filtro = 0
        FUN028.Text = "EMP"
        tbPesquisa.Clear()
        tbPesquisa.Refresh()
        Panel2.Enabled = True
        Call carregalist(0) ' popula o grid de cadastro das garagens
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If
    End Sub

    Private Sub R2_CheckedChanged(sender As Object, e As EventArgs) Handles R2.CheckedChanged
        ' EMPREENDIMENTO
        FUN028.Text = "FUN"
        xEMP002.Text = "000000"
        xEMP003.Text = iReg002
        Panel2.Enabled = False
        tbPesquisa.Clear()
        tbPesquisa.Refresh()

        Call carregalist(1) ' popula o grid de cadastro das garagens
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If

    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        filtro = 0 ' VARIAVEL QUE ACIONA O FILTRO PARA MOSTRAR TODOS OS REGISTROS
        lvDados.Refresh()
        tbPesquisa.Clear()
        Call carregalist(0) ' RECARREGA A RELAÇÃO DE FUNCIONÁRIOS
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
            lvDados.Focus()
        End If
    End Sub
    Private Sub R3_CheckedChanged(sender As Object, e As EventArgs) Handles R3.CheckedChanged
        ' PRESTADORES
        FUN028.Text = "PRE"
        xEMP002.Text = "100001"
        xEMP003.Text = "PRESTADORES DE SERVIÇOS AUTONOMOS SEM REGISTRO"
        Panel2.Enabled = False
        tbPesquisa.Clear()
        tbPesquisa.Refresh()

        Call carregalist(1) ' popula o grid de cadastro das garagens
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If


    End Sub

#End Region

#Region "ENTER"
    Private Sub tbPesquisa_TextChanged(sender As Object, e As EventArgs) Handles tbPesquisa.TextChanged
        chave = ""
        chave = "%" & tbPesquisa.Text
        Call carregalist(0)
    End Sub
    Private Sub tbpesquisa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbPesquisa.KeyPress
        filtro = 1
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


    Private Sub limpaList()
        lvDados.Items.Clear()
        lvDados.BackColor = Color.White
        lvDados.GridLines = True
        lvDados.FullRowSelect = True
        lvDados.View = View.Details
        lvDados.Sorting = SortOrder.None
    End Sub


    Private Sub carregalist(arg)
        Select Case arg
            Case 0
                ' Lista dos funcionários do empreendimento
                Call filtrar()
                Call limpaList() ' limpa o listview
                conexao.Open()
                Dim cmd As MySqlCommand = New MySqlCommand(Sql, conexao)
                Dim leitor As MySqlDataReader = cmd.ExecuteReader()
                pop = 0
                Do While leitor.Read()
                    Dim item As New ListViewItem()
                    item.Text = leitor(0)
                    item = lvDados.Items.Add(leitor("EMP002").ToString)   ' 0 ID
                    item.SubItems.Add(leitor("EMP003").ToString)         ' 1 NUMERAÇÃO DA UNIDADE
                    item.SubItems.Add(FUN028.Text)
                    pop += 1 ' faz a contagem dos registros no listview
                Loop
                conexao.Close() ' fecha a conexação com o banco de dados
                leitor.Dispose()
                'Call corlist(0)
            Case 1
                pop = 0
                Call limpaList() ' limpa o listview
                Dim item As New ListViewItem()
                item = lvDados.Items.Add(xEMP002.Text)   ' 0 ID
                item.SubItems.Add(xEMP003.Text)         ' 1 NUMERAÇÃO DA UNIDADE
                item.SubItems.Add(FUN028.Text)
                pop += 1 ' faz a contagem dos registros no listview
        End Select
    End Sub

    Private Sub lvDados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDados.SelectedIndexChanged
        Try
            If lvDados.SelectedItems.Count > 0 Then
                Index = lvDados.Items.Item(lvDados.SelectedIndices(0)).Index
                Me.iEMP002.Text = Convert.ToString(lvDados.Items(lvDados.SelectedIndices(0)).Text)
                Me.iFUN028.Text = Me.lvDados.SelectedItems(0).SubItems(2).Text
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



#End Region




End Class
























