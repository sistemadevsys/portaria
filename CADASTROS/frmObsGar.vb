Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmObsGar

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
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If tbgar004.TextLength = 0 Then
            MessageBox.Show(" É necessário informar a observação para o procedimento! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbgar004.Focus()
            alterado = 0
            Exit Sub
        Else
            alterado = 10
            frmCadGar.referencial.Text = tbgar004.Text
            Me.Close()
        End If
    End Sub
    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub
#End Region

End Class
























