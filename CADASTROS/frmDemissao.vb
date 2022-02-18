Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmDemissao

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
    Private Sub frmLocalizacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CancelButton = btnsair
        FUN027.Clear()
        FUN027.Select()
        FUN027.Focus()
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        alterado = 0
        Me.Close()
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If FUN027.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "Informe o motivo da demissão.", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            If (MetroFramework.MetroMessageBox.Show(Me, "Confirma a demissão do funcionário ?", "" & legenda & "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = MsgBoxResult.Yes Then
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim sql As String = "update prt_cadfun set FUN022 = 'DESLIGADO', FUN027 = '" & FUN027.Text & "' WHERE FUN002 = '" & FUN002.Text & "'"
                Dim cmd As New MySqlCommand(sql, conexao)
                conexao.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show(" Demissão Registrada! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                alterado = 90
                conexao.Close()
                alterado = 10
                Me.Close()
            Else
                alterado = 0
                Me.Close()
            End If
        End If
    End Sub
#End Region

 
End Class
























