Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class Sobre
    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Protected regionHandle As IntPtr

    Dim anoatual As String
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

    Private Sub frmSobre_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            ' BOTÃO INCLUIR NOVO REGISTRO
            Me.Close()
        End If

    End Sub

    Private Sub frmSobre_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        redondo(0, 0, Panel2, 20, 20)


        lbconecta.Text = "Conectividade:  " & xServidor
        anoatual = Year(Now)
        Copyright_nome = "Copyright © DevSys - Desenvolvimento de Sistemas Ltda 2006 - " & anoatual
        c1.Text = Copyright_nome
        Label9.Text = iReg002
        Label4.Text = legenda & " - " & versao & "     Data da Versão:  " & datasis
    End Sub

    Private Sub redondo(arg1, arg2, componente, arg3, arg4)
        regionHandle = New IntPtr(CreateRoundRectRgn(arg1, arg2, componente.Width, componente.Height, arg3, arg4))
        componente.Region = Region.FromHrgn(regionHandle)
        componente.Region.ReleaseHrgn(regionHandle)
    End Sub


    Private Sub label5_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub lbconecta_Click_1(sender As Object, e As EventArgs) Handles lbconecta.Click
        Config.ShowDialog()
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnhome_Click_1(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub

End Class
























