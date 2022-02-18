Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing




Public Class Senhas
    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Protected regionHandle As IntPtr


    Private Sub frmsenhas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = False
        End If
    End Sub
    Private Sub frmAtalhos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ' BOTÃO SALVAR O REGISTRO
            If btnF5.Enabled = True Then btnF5.PerformClick()
        End If
        If e.KeyCode = Keys.F7 Then
            ' FECHAR O FORMULÁRIO O REGISTRO
            If btnClose.Enabled = True Then btnClose.PerformClick()
        End If
    End Sub
#Region "BEEP DO ENTER"
    Private Sub beep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
#End Region
    Private Sub frmsenhas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        redondo(0, 0, Panel3, 20, 20) ' arredonda as bordas do painel onde fica os textbox
        redondo(0, 0, Label2, 30, 30) ' arredonda as bordas do texto de identificação superior
        Me.CancelButton = btnClose
        tbSenha.Clear()
        USU001.Text = iCodUser
        btnF5.Visible = False
        Me.CancelButton = btnClose
        tbSenha.Select()
        controle.Visible = False
    End Sub

    Private Sub redondo(arg1, arg2, componente, arg3, arg4)
        regionHandle = New IntPtr(CreateRoundRectRgn(arg1, arg2, componente.Width, componente.Height, arg3, arg4))
        componente.Region = Region.FromHrgn(regionHandle)
        componente.Region.ReleaseHrgn(regionHandle)
    End Sub

    Private Sub tbsenha_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbSenha.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            ConfSenha.Text = geraHash(tbSenha.Text)
            If ConfSenha.Text <> iSenha Then
                MetroFramework.MetroMessageBox.Show(Me, " Senha Inválida! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexao.Close()
                Me.Close()
            Else
                tbnovasenha.Clear()
                tbconfirma.Clear()
                controle.Visible = True
                tbnovasenha.Focus()
            End If
        End If
    End Sub
    Private Sub frmprincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub tbnovasenha_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbnovasenha.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbnovasenha.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe a Nova Senha de Acesso! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbnovasenha.Clear()
                tbnovasenha.Focus()
            Else
                If tbnovasenha.Text = tbSenha.Text Then
                    MetroFramework.MetroMessageBox.Show(Me, " A Nova Senha Não Pode Ser Igual a Senha Anterior! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tbnovasenha.Clear()
                    tbnovasenha.Focus()
                Else
                    tbconfirma.Focus()
                End If
            End If
        End If
    End Sub


    Private Sub testacampo()
        If tbconfirma.Text <> tbnovasenha.Text Then
            MetroFramework.MetroMessageBox.Show(Me, " Senhas não Conferem... Verifique! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            tbnovasenha.Clear()
            tbconfirma.Clear()
            tbnovasenha.Focus()
        Else
            ConfSenha.Text = ""
            ConfSenha.Text = geraHash(tbconfirma.Text)
            btnF5.Visible = True
            btnF5.Focus()
        End If
    End Sub
    Private Sub tbconfirma_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbconfirma.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            btnF5.Visible = True
            Call testacampo()
        End If
    End Sub
    Private Sub gravar(arg)
        Select Case arg
            Case 0
                ' FAZ A ALTERAÇÃO DA SENHA NA TABELA DE USUÁRIOS
                Dim s1 As String = "update usuarios set USU004 ='" & ConfSenha.Text & "', USU009 = '0' WHERE USU001 ='" & iCodUser & "' and USU008 = '" & sistema & "'"
                Dim cmnd As New MySqlCommand(s1, conexao)
                conexao.Open()
                cmnd.ExecuteNonQuery()
                iSenha = ConfSenha.Text
                conexao.Close()
            Case 1
                ' FAZ A ALTERAÇÃODA SENHA PARA ENVIO POR EMAIL AO USUÁRIO
                Dim s1 As String = "update uspass set USU004 ='" & tbconfirma.Text & "' WHERE USU001 ='" & iCodUser & "' and USU008 = '" & sistema & "'"
                Dim cmnd As New MySqlCommand(s1, conexao)
                conexao.Open()
                cmnd.ExecuteNonQuery()
                iSenha = ConfSenha.Text
                conexao.Close()
        End Select
    End Sub
    Private Sub btnF5_Click(sender As Object, e As EventArgs) Handles btnF5.Click
        Try
            ' GRAVAR
            Call testacampo()
            Call gravar(0) ' MUDA A SENHA DO USUÁRIO NA TABELA USUÁRIOS
            Call gravar(1) ' MUDA A SENHA DO USUÁRIO NA TABELA USPASS
            MetroFramework.MetroMessageBox.Show(Me, " Senha Alterada com sucesso! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message)
        End Try
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
























