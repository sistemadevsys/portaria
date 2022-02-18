Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmFiltraFun



    Dim objDraw As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath
    Dim mover As New MoveForm
    Private Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure
    Private Sub frmFiltraFun_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub frmFiltraFun_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        alterado = 10
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        alterado = 20
        Me.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        alterado = 0
        Me.Close()
    End Sub
    Private Sub frmFiltraFun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CancelButton = Button3
    End Sub
End Class
























