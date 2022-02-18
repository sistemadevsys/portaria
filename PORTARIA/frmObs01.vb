Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmObs01

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
    Private Sub BEEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
    Private Sub escape_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            ' BOTÃO SALVAR O REGISTRO
            Me.Close()
        End If
    End Sub
    Private Sub frmObs01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FAS011.Clear()
        FAS011.SelectAll()
        FAS011.Focus()
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FAS011.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Descreve a ocorrência ou observação! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FAS011.Focus()
        Else
            alterado = 100
            frmRegAcesso.btnObs.Text = "Sim"
            frmRegAcVisitante.btnObs.Text = "Sim"
            Me.Close()
        End If
    End Sub
#End Region

End Class
























