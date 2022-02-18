Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class Config
    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Protected regionHandle As IntPtr
    Dim nome_arquivo_ini As String = My.Application.Info.DirectoryPath & "\conexao.ini"

    Private Sub btnF7_Click(sender As Object, e As EventArgs) Handles btnF7.Click
        Me.Close()
    End Sub

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

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        redondo(0, 0, Panel3, 20, 20)

        Me.CancelButton = btnF7

        tbDatabase.Text = iDatabase ' NOME DO BANCO DE DADOS LOCAL PARA REPLICAÇÃO
        tbHostname.Text = iservidor ' ENDEREÇO DO SERVIDOR LOCAL
        tbPort.Text = iPort         ' PORTA DE ACESSO AO BANCO DE DADOS

        tbbanco.Text = xDatabase    ' NOME DO BANCO DE DADOS DE AUTENTICAÇÃO
        tbHost.Text = xServidor     ' ENDEREÇO DO SERVIDOR DE AUTENTICAÇÃO
        tbPorta.Text = xPort        ' PORTA DE ACESSO AO BANCO DE DADOS
        tbUser.Text = xUserMysql    ' USUÁRIO DE ACESSO AO BANCO DE DADOS DE AUTENTICAÇÃO
    End Sub

    Private Sub redondo(arg1, arg2, componente, arg3, arg4)
        regionHandle = New IntPtr(CreateRoundRectRgn(arg1, arg2, componente.Width, componente.Height, arg3, arg4))
        componente.Region = Region.FromHrgn(regionHandle)
        componente.Region.ReleaseHrgn(regionHandle)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MetroFramework.MetroMessageBox.Show(Me, " Tenha certeza da alteração das configurações! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        If (MetroFramework.MetroMessageBox.Show(Me, " Confirma que deseja alterar as configurações ?", "" & legenda & "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error)) = MsgBoxResult.Yes Then
            iconexao = New MySqlConnection("server=" & tbHost.Text & "; port=" & tbPorta.Text & "; Database=" & tbbanco.Text & "; Uid=" & tbUser.Text & "; pwd=" & xSenhaMysql & "; SslMode=none")
            conexao = New MySqlConnection("server=" & tbHostname.Text & "; port=" & tbPort.Text & "; Database=" & tbDatabase.Text & "; Uid=" & iUserMysql & "; pwd=" & iSenhaMysql & "; SslMode=none")  ' LOCAL
            Call gravaArquivoini()  ' GRAVA O ARQUIVO DE CONEXÃO = CONEXÃO.INI NO DIRETORIO CORRENTE
            Me.Close()
        End If
    End Sub
    Private Sub gravaArquivoini()
        WritePrivateProfileString("Banco", "xDatabase", tbDatabase.Text, nome_arquivo_ini)
        WritePrivateProfileString("Banco", "xHostName", tbHostname.Text, nome_arquivo_ini)
        WritePrivateProfileString("Banco", "xPort", tbPort.Text, nome_arquivo_ini)
        WritePrivateProfileString("Registro", "iHostname", tbHost.Text, nome_arquivo_ini)
        WritePrivateProfileString("Registro", "iUserPass", tbUser.Text, nome_arquivo_ini)
        WritePrivateProfileString("Registro", "iDatabase", tbbanco.Text, nome_arquivo_ini)
        WritePrivateProfileString("Registro", "iPorta", tbPorta.Text, nome_arquivo_ini)
    End Sub

End Class
























