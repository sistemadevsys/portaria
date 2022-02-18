Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmPesq01
    Dim sql, chave As String
    Dim filtro As Integer
    Dim CADP001, CADP002, CADP003, CADP004 As New TextBox
    Dim pop As Integer
    Private Sub frmPadrao_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            ' BOTÃO SALVAR O REGISTRO
            Me.Close()
        End If
    End Sub
    Private Sub frmPesq01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filtro = 99 ' VARIAVEL QUE ACIONA O FILTRO PARA MOSTRAR TODOS OS REGISTROS
        Call carregalist(0) ' CARREGA OS PROPRIETÁRIOS
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If
    End Sub

#Region "FUNÇÕES"
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

    Private Sub filtrar()
        Select Case filtro
            Case 99 ' TODOS OS REGISTROS
                sql = "SELECT CADP001,CADP002,CADP003,CADP004 FROM PRT_CADPRO WHERE CADP028 = '0' AND CADP026 = 'LOC' ORDER BY CADP002"
            Case 0 ' FILTRA POR CÓDIGO DA UNIDADE
                sql = "SELECT CADP001,CADP002,CADP003,CADP004 FROM PRT_CADPRO WHERE CADP002 like '" & chave & "%' AND CADP028 = '0' AND CADP026 = 'LOC' order by CADP002"
            Case 1 ' FILTRA PELO NOME DO PROPRIETÁRIO
                sql = "SELECT CADP001,CADP002,CADP003,CADP004 FROM PRT_CADPRO WHERE CADP003 like '" & chave & "%' AND CADP028 = '0' AND CADP026 = 'LOC' order by CADP003"
        End Select
    End Sub

    Private Sub tbpesquisa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbPesquisa.KeyPress
        filtro = 1
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbPesquisa.TextChanged
        chave = ""
        chave = "%" & tbPesquisa.Text
        Call carregalist(0)
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
    Private Sub btntodos_Click(sender As Object, e As EventArgs) Handles btntodos.Click
        tbPesquisa.Clear()
        filtro = 99
        Call carregalist(0) ' popula o grid de cadastro das garagens
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If
    End Sub

    Private Sub lvDados_DoubleClick(sender As Object, e As EventArgs) Handles lvDados.DoubleClick
        Repositorio.CADL002.Text = CADP002.Text
        Repositorio.CADL003.Text = CADP003.Text
        alterado = 500
        Me.Close()
    End Sub

    Private Sub lvDados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDados.SelectedIndexChanged
        Try
            If lvDados.SelectedItems.Count > 0 Then
                Me.CADP001.Text = Convert.ToString(lvDados.Items(lvDados.SelectedIndices(0)).Text)
                Me.CADP002.Text = Me.lvDados.SelectedItems(0).SubItems(1).Text
                Repositorio.CADP036.Text = Me.lvDados.SelectedItems(0).SubItems(1).Text
                Me.CADP003.Text = Me.lvDados.SelectedItems(0).SubItems(2).Text
                Me.CADP004.Text = Me.lvDados.SelectedItems(0).SubItems(3).Text
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
























