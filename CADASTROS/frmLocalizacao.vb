Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmLocalizacao
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
    Private Sub frmLocalizacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbLocg002.Clear()
        tbLocg002.Focus()
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If tbLocg002.TextLength = 0 Then
            MessageBox.Show("Informe a descrição da localização", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            If conexao.State = ConnectionState.Open Then conexao.Close()
            Dim sql As String = "INSERT INTO PRT_LOCGAR(LOCG002)VALUES('" & tbLocg002.Text & "')"
            Dim cmd As New MySqlCommand(sql, conexao)
            conexao.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Registro realizado com sucesso!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            conexao.Close()
            tbLocg002.Clear()
            tbLocg002.Focus()
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
        sql = "select * FROM PRT_LOCGAR WHERE LOCG002 = '" & tbLocg002.Text & "'"
        da = New MySqlDataAdapter(sql, conexao)
        da.Fill(ds, "PRT_LOCGAR")
        If ds.Tables("PRT_LOCGAR").Rows.Count > 0 Then
            retorno = ds.Tables("PRT_LOCGAR").Rows(0).Item(1)
        Else
            retorno = Nothing
        End If
        conexao.Close()
    End Sub
    Private Sub tblocg002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbLocg002.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbLocg002.TextLength = 0 Then
                MessageBox.Show(" É necessário informar a localização! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Call pesquisa() ' verifica se a descrição já existe na tabela
                If retorno = Nothing Then
                    btnsave.Focus()
                Else
                    MessageBox.Show(" Código informado já existe no cadastro! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        End If
    End Sub
#End Region

#Region "COMPONENTES"

#End Region


 
End Class
























