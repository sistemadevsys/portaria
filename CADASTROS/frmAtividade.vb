Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmAtividade

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

#Region "VARIÁVEIS"
    Dim retorno As String
    Dim tabela, campo As String
#End Region

#Region "START DO FORMULÁRIO"
    Private Sub frmClose_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
    Private Sub frmPadrao_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
    Private Sub frmAtividade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CancelButton = btnsair
        nome.Clear()
        nome.Focus()
        tabela = "prt_atividade" ' NOME DA TABELA
        campo = "ATI02"      ' CAMPO DA TABELA
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If nome.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "Informe a descrição do autorizado", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            If conexao.State = ConnectionState.Open Then conexao.Close()
            Dim sql As String = "insert into " & tabela & "(" & campo & ")VALUES('" & nome.Text & "')"
            Dim cmd As New MySqlCommand(sql, conexao)
            conexao.Open()
            cmd.ExecuteNonQuery()
            MetroFramework.MetroMessageBox.Show(Me, "Registro realizado com sucesso!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            alterado = 90
            conexao.Close()
            nome.Clear()
            nome.Focus()
            alterado = 10
        End If
    End Sub
#End Region

#Region "FUNÇÕES"
    Private Sub pesquisa()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim sql As String
        If conexao.State = 0 Then
            conexao.Open()
        End If
        retorno = Nothing
        sql = "select * from " & tabela & " where " & campo & " = '" & nome.Text & "'"
        da = New MySqlDataAdapter(sql, conexao)
        da.Fill(ds, tabela)
        If ds.Tables(tabela).Rows.Count > 0 Then
            retorno = ds.Tables(tabela).Rows(0).Item(1)
        Else
            retorno = Nothing
        End If
        conexao.Close()
    End Sub
    Private Sub nome_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles nome.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If nome.TextLength = 0 Then
                MessageBox.Show(" É necessário informar a Descrição! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Call pesquisa() ' verifica se a descrição já existe na tabela
                If retorno = Nothing Then
                    btnsave.Focus()
                Else
                    MessageBox.Show(" Descrição informada já existe ! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        End If
    End Sub
#End Region



End Class
























