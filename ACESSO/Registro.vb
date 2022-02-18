Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class Registro
    Dim acao, sql As String
    Dim dt As DateTime
    Dim Data As String = ""
    Dim dtstring As String
    Dim dia, mes, ano As String
    Dim img As Image
    Dim str As String
    Public dirAtual As String = Directory.GetCurrentDirectory()

    Private Sub frmRegistro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' DESLIGA O BEEP DO ENTER
            e.Handled = True
        End If
    End Sub

#Region "BEEP DO ENTER"
    Private Sub beep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
#End Region

    Private Sub frmRegistro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CancelButton = btnSair
        tbReg013.Value = Format(Data_hoje, "dd/MM/yyyy")
        Call geracod() ' BUSCA O ULTIMO CÓDIGO DA EMPRESA CADASTRADA NO PROVEDOR BANCO SOL_CONTROLLER - TABELA CLIENTES
        Me.Text = " Formulário de registro da empresa"
        tbTerminal.Text = UCase(iTerminal)
        Call carregaMac()
        tbReg002.Select()
        tbReg002.Focus()
    End Sub

#Region "FUNÇÕES"
    Public Sub tempValue()
        pb1.Image.Save(Application.StartupPath + "\gstec.dat")
    End Sub
    Private Sub geracod()
        ' GERA O CODIGO PARA O CADASTRO DO CLIENTE - BUSCA NO BANCO SOL_CONTROLLER
        Dim sqlmaior As String
        If iconexao.State = ConnectionState.Closed Then iconexao.Close()
        iconexao.Open()
        sqlmaior = "Select Max(CLI001) From clientes"
        Dim cmd As New MySqlCommand(sqlmaior, iconexao)
        Dim maior As Integer
        If IsDBNull(cmd.ExecuteScalar) Then
            maior = 1
        Else
            maior = cmd.ExecuteScalar + 1
        End If
        tbReg001.Text = Format(maior, "000000")
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        iconexao.Close()
    End Sub
    Private Sub carregaMac()
        Dim mc As System.Management.ManagementClass
        Dim mo As System.Management.ManagementBaseObject
        mc = New Management.ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim moc As Management.ManagementObjectCollection = mc.GetInstances
        For Each mo In moc
            If mo.Item("IPenabled") = True Then
                mac.Text = mo.Item("MacAddress")
            End If
        Next
    End Sub
#End Region

#Region "ENTER"
    Private Sub tbReg002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbReg002.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbReg002.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "É necessário informar a razão social da empresa.", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbReg002.Focus()
            Else
                tbReg009.Focus()
            End If
        End If
    End Sub
    Private Sub tbReg009_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbReg009.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbReg009.MaskCompleted = False Then
                MetroFramework.MetroMessageBox.Show(Me, "É necessário informar o CNPJ da empresa.", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbReg009.Focus()
            Else
                tbReg016.Focus()
            End If
        End If
    End Sub
    Private Sub tbReg016_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbReg016.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbReg016.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "É necessário informar o nome fantasia da empresa.", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbReg016.Focus()
            Else
                tbReg010.Focus()
            End If
        End If
    End Sub
    Private Sub tbReg010_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbReg010.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            tbReg011.SelectAll()
            tbReg011.Focus()
        End If
    End Sub
    Private Sub tbReg011_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbReg011.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            tbReg012.Focus()

        End If
    End Sub
    Private Sub tbReg012_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbReg012.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            tbReg003.Focus()
        End If
    End Sub

    Private Sub tbReg003_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbReg003.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbReg003.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "É necessário informar o endereço da empresa.", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbReg003.Focus()
            Else
                tbReg004.Focus()
            End If
        End If
    End Sub
    Private Sub tbReg004_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbReg004.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbReg004.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "É necessário informar o bairro .", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbReg004.Focus()
            Else
                tbReg005.Focus()
            End If
        End If
    End Sub
    Private Sub tbReg005_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbReg005.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbReg005.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "É necessário informar a cidade.", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbReg005.Focus()
            Else
                tbReg006.Focus()
            End If
        End If
    End Sub
    Private Sub tbReg006_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbReg006.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbReg006.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "É necessário informar a UF da cidade.", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbReg006.Focus()
            Else
                tbReg007.Focus()
            End If
        End If
    End Sub
    Private Sub tbReg007_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbReg007.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If tbReg007.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "É necessário informar o CEP .", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbReg007.Focus()
            Else
                tbReg008.Focus()
            End If
        End If
    End Sub
    Private Sub tbReg008_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbReg008.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            tbReg014.Focus()
        End If
    End Sub
#End Region

    Private Sub gravafoto()
        Call tempValue()
        Dim fst As New FileStream(Application.StartupPath + "\gstec.dat", FileMode.Open)
        Dim arrbyte(fst.Length) As Byte
        fst.Read(arrbyte, 0, arrbyte.Length)
        fst.Close()
        Directory.SetCurrentDirectory("" & dirAtual & "") ' retorna a leitura para o diretório da aplicação
        Dim s1 As String = "update registro set REG015 = ? WHERE REG001='" & tbReg001.Text & "'"
        Dim cmnd As New MySqlCommand(s1, conexao)
        Dim par As New MySqlParameter("@Imagem", MySqlDbType.Binary)
        par.Value = arrbyte
        par.Size = arrbyte.Length
        cmnd.Parameters.Add(par)
        conexao.Open()
        cmnd.ExecuteNonQuery()
        conexao.Close()
    End Sub

    Private Sub gravaterminal()
        If iconexao.State = ConnectionState.Open Then iconexao.Close()
        Dim st As String = "insert into chaves(CHA001,CHA002,CHA003,CHA004,CLI001)VALUES('" & tbTerminal.Text & "','" & mac.Text & "', '" & sistema & "','1','" & tbReg001.Text & "')"
        Dim cmd As New MySqlCommand(st, iconexao)
        iconexao.Open()
        cmd.ExecuteNonQuery()
        iconexao.Close()
    End Sub

    Private Sub GravaCliente()
        If iconexao.State = ConnectionState.Open Then iconexao.Close()
        Dim st As String = "insert into clientes(CLI001,CLI002,CLI003,CLI004,CLI005,CLI006,CLI007,CLI008,CLI009,CLI010,CLI011,CLI012,CLI013,CLI014,CLI015,CLI016,CLI017,CLI018,CLI019)VALUES('" & tbReg001.Text & "','" & tbReg002.Text & "','" & Format(tbReg013.Value, "yyyy-MM-dd") & "','" & tbReg003.Text & "','" & tbReg004.Text & "','" & tbReg005.Text & "','" & tbReg006.Text & "','" & tbReg007.Text & "','" & tbReg008.Text & "','" & tbReg009.Text & "','" & tbReg010.Text & "','" & tbReg011.Text & "','" & tbReg012.Text & "','" & tbReg014.Text & "','" & tbReg016.Text & "','" & versao & "','" & sistema & "','" & datasis & "','0')"
        Dim cmd As New MySqlCommand(st, iconexao)
        iconexao.Open()
        cmd.ExecuteNonQuery()
        iconexao.Close()
    End Sub

    Private Sub btnreg_Click(sender As System.Object, e As System.EventArgs) Handles btnReg.Click
        If conexao.State = ConnectionState.Open Then conexao.Close()
        conexao.Open()
        Dim st As String = "insert into registro(REG001,REG002,REG003,REG004,REG005,REG006,REG007,REG008,REG009,REG010,REG011,REG012,REG013,REG014,REG016,REG017,REG018,REG019,REG020)VALUES('" & tbReg001.Text & "','" & tbReg002.Text & "','" & tbReg003.Text & "','" & tbReg004.Text & "','" & tbReg005.Text & "','" & tbReg006.Text & "','" & tbReg007.Text & "','" & tbReg008.Text & "','" & tbReg009.Text & "','" & tbReg010.Text & "','" & tbReg011.Text & "','" & tbReg012.Text & "','" & Format(tbReg013.Value, "yyyy-MM-dd") & "','" & tbReg014.Text & "','" & tbReg016.Text & "','" & versao & "','" & sistema & "','" & datasis & "','0')"
        Dim cmd As New MySqlCommand(st, conexao)
        cmd.ExecuteNonQuery()
        conexao.Close()
        Call gravafoto()     ' GRAVA O LOGO DA EMPRESA
        Call gravaterminal() ' GRAVA O TERMINAL COM A NUMERAÇÃO DA PLACA DE REDE
        Call GravaCliente()  ' GRAVA OS DADOS DO CLIENTE NO SERVIDOR DO DESENVOLVERDOR
        MetroFramework.MetroMessageBox.Show(Me, " Operação realizada com sucesso!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Dispose()
        Application.Exit()
    End Sub
    Private Sub pb1_Click(sender As System.Object, e As System.EventArgs) Handles pb1.Click
        op1.Filter = "jpg|*.jpg|gif|*.gif|png|*.png"
        op1.ShowDialog()
    End Sub
    Private Sub op1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles op1.FileOk
        img = Image.FromFile(op1.FileName)
        pb1.Image = img
        pb1.SizeMode = PictureBoxSizeMode.StretchImage
        pb1.Image.Save(Application.StartupPath + "\GSTec.dat", Imaging.ImageFormat.Jpeg)
        str = op1.FileName
    End Sub
    Private Sub btnsair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Dispose()
        Application.Exit()
    End Sub
End Class
























