Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class BDados
    Private Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Dim condicao As String
    Dim caminho As String
    Dim nome_arquivo_ini As String = My.Application.Info.DirectoryPath & "\conexao.ini"
    Dim iPath As String
    Dim legenda As String = "DevSys"
    Dim retorno As String

    Private Sub frmAtalhos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ' BOTÃO SALVAR O REGISTRO
            If btnF5.Enabled = True Then btnF5.PerformClick()
        End If
        If e.KeyCode = Keys.F7 Then
            ' FECHAR O FORMULÁRIO O REGISTRO
            If btnF7.Enabled = True Then btnF7.PerformClick()
        End If


    End Sub
    Private Sub frmClose_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

#Region "BEEP DO ENTER"
    Private Sub beep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
#End Region

    Private Sub frmBdados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xSenhaMysql = "kXbm9.h$cU@95"  ' senha do banco de dados externo
        PanelCloud.Visible = False
        btnAsenha.Visible = True
        ObtemIP.ObtemEnderecoIP()

        If Not File.Exists(nome_arquivo_ini) Then
            tbTerminal.Text = nomehost
        Else
            condicao = "false"
            tbDatabase.Text = LeArquivoINI(nome_arquivo_ini, "Banco", "xDataBase", "")
            tbHostname.Text = LeArquivoINI(nome_arquivo_ini, "Banco", "xHostName", "")
            tbPort.Text = LeArquivoINI(nome_arquivo_ini, "Banco", "xPort", "")
        End If
    End Sub
    Private Function LeArquivoINI(ByVal file_name As String, ByVal section_name As String, ByVal key_name As String, ByVal default_value As String) As String
        Const MAX_LENGTH As Integer = 500
        Dim string_builder As New StringBuilder(MAX_LENGTH)
        GetPrivateProfileString(section_name, key_name, default_value, string_builder, MAX_LENGTH, file_name)
        Return string_builder.ToString()
    End Function
    Private Sub wPort_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbPort.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub gravaArquivoini()
        WritePrivateProfileString("Banco", "xDatabase", tbDatabase.Text, nome_arquivo_ini)
        WritePrivateProfileString("Banco", "xHostName", tbHostname.Text, nome_arquivo_ini)
        WritePrivateProfileString("Banco", "xPort", tbPort.Text, nome_arquivo_ini)
        WritePrivateProfileString("Banco", "iCodec", tbCodigo.Text, nome_arquivo_ini)
        WritePrivateProfileString("Registro", "iHostname", tbHost.Text, nome_arquivo_ini)
        WritePrivateProfileString("Registro", "iUserPass", tbUser.Text, nome_arquivo_ini)
        WritePrivateProfileString("Registro", "iDatabase", tbbanco.Text, nome_arquivo_ini)
        WritePrivateProfileString("Registro", "iPorta", tbPorta.Text, nome_arquivo_ini)
        WritePrivateProfileString("Registro", "iMacSistema", xSenhaMysql, nome_arquivo_ini)  ' senha do banco de dados na nuvem
    End Sub

    Private Sub pesquisar()
        ' verificar se o terminal já tem cadastro no banco de dados
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim Pesq As String
        retorno = Nothing
        Pesq = "select * from autentica where CODIGO = '" & tbCodigo.Text & "'"
        da = New MySqlDataAdapter(Pesq, conexao)
        da.Fill(ds, "autentica")
        If ds.Tables("autentica").Rows.Count > 0 Then
            retorno = "SIM"
        Else
            retorno = "NÃO"
        End If
    End Sub
    Private Sub montaconexao()
        iservidor = Trim(tbHostname.Text)
        iPort = Trim(tbPort.Text)
        iDatabase = Trim(tbDatabase.Text)
        conexao = New MySqlConnection("server=" & iservidor & "; port=" & iPort & "; Database=" & iDatabase & "; Uid=" & iUserMysql & "; pwd=" & iSenhaMysql & "; SslMode=none")
    End Sub

    Private Sub grava()
        ' GRAVA A CONFIGURAÇÃO DO BANCO DE DADOS DE AUTENTICAÇÃO DO SISTEMA
        If conexao.State = ConnectionState.Open Then conexao.Close()
        Dim st As String = "insert into autentica(BANCO,HOST,PORTA,CODIGO)VALUES('" & tbbanco.Text & "','" & tbHost.Text & "','" & tbPorta.Text & "','" & tbCodigo.Text & "')"
        Dim cmd As New MySqlCommand(st, conexao)
        conexao.Open()
        cmd.ExecuteNonQuery()
        conexao.Close()
    End Sub

    Private Sub geracod()
        Dim sqlmaior As String
        iconexao.Open()

        sqlmaior = "Select Max(CLI001) From clientes"
        Dim cmd As New MySqlCommand(sqlmaior, iconexao)
        Dim maior As Integer
        If IsDBNull(cmd.ExecuteScalar) Then
            maior = 1
        Else
            maior = cmd.ExecuteScalar + 1
        End If
        cmd.ExecuteNonQuery()
        tbCodigo.Text = Format(maior, "000000")
        cmd.Dispose()
        iconexao.Close()
    End Sub

    Private Sub btnF5_Click(sender As Object, e As EventArgs) Handles btnF5.Click
        iconexao = New MySqlConnection("server=" & tbHost.Text & "; port=" & tbPorta.Text & "; Database=" & tbbanco.Text & "; Uid=" & tbUser.Text & "; pwd=" & xSenhaMysql & "; SslMode=none")
        Call geracod()          ' busca o ultimo código de cliente inserido no banco clientes
        Call gravaArquivoini()  ' GRAVA O ARQUIVO DE CONEXÃO = CONEXÃO.INI NO DIRETORIO CORRENTE
        MetroFramework.MetroMessageBox.Show(Me, "Conexão com o banco de dados foi criada com sucesso!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MetroFramework.MetroMessageBox.Show(Me, "É necessário reiniciar o sistema...", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Dispose()
        Application.Exit()
    End Sub

    Private Sub btnF7_Click(sender As Object, e As EventArgs) Handles btnF7.Click
        Dispose()
        Application.Exit()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        xSenhaMysql = iMacSistema.Text
        PanelCloud.Visible = False
        btnAsenha.Visible = True
    End Sub

    Private Sub btnAsenha_Click(sender As Object, e As EventArgs) Handles btnAsenha.Click
        PanelCloud.Visible = True
        btnAsenha.Visible = False
        iMacSistema.Clear()
        iMacSistema.Text = xSenhaMysql
        iMacSistema.Focus()
    End Sub
End Class
























