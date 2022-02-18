Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class CadTerminal
    Dim Data_hoje As DateTime = DateTime.Now
    Dim agora As DateTime = DateTime.Now
    Dim retorno As String = Nothing
    Dim acao As String
    Dim xPesq As String = ""
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

    Private Sub frmlicuso_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnSave.PerformClick()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmClose_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
    Private Sub frmCadTerminal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
    Private Sub frmCadTerminal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height - 100) / 2
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width + 200) / 2
        ObtemIP.ObtemEnderecoIP()
        Call carregaMac()               ' CARREGA O NUMERO DA PLACA DE REDE 
        tbCHA001.Text = UCase(nomehost) ' NOME DA ESTAÇÃO DE TRABALHO
        tbCHA003.Text = sistema         ' APLICATIVO AUTORIZADO
        tbCLI001.Text = iReg001         ' CÓDIGO DO CLIENTE
        Call pesquisar()
    End Sub

#Region "FUNÇÕES"
    Private Sub pesquisar()
        ' verificar se o terminal já tem cadastro no banco de dados
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim Pesq As String
        retorno = Nothing
        Pesq = "select * from chaves where CLI001 = '" & iReg001 & "' and CHA001 = '" & tbCHA001.Text & "' and CHA002 = '" & tbCHA002.Text & "' and CHA003 = '" & tbCHA003.Text & "' order by CLI001"
        da = New MySqlDataAdapter(Pesq, iconexao)
        da.Fill(ds, "chaves")
        If ds.Tables("chaves").Rows.Count > 0 Then
            alerta.Visible = True
            btnsave.Visible = False
        Else
            alerta.Visible = False
            btnsave.Visible = True
        End If
    End Sub
    Private Sub carregaMac()
        Dim mc As System.Management.ManagementClass
        Dim mo As System.Management.ManagementBaseObject
        mc = New Management.ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim moc As Management.ManagementObjectCollection = mc.GetInstances
        For Each mo In moc
            If mo.Item("IPenabled") = True Then
                'List.Items.Add("Endereço MAC " & mo.Item("MacAddress"))
                tbCHA002.Text = mo.Item("MacAddress")
            End If
        Next
    End Sub

    Private Sub gravaterminal()
        If iconexao.State = ConnectionState.Open Then iconexao.Close()
        Dim st As String = "insert into chaves(CHA001,CHA002,CHA003,CHA004,CLI001)VALUES('" & tbCHA001.Text & "','" & tbCHA002.Text & "', '" & tbCHA003.Text & "','1','" & tbCLI001.Text & "')"
        Dim cmd As New MySqlCommand(st, iconexao)
        iconexao.Open()
        cmd.ExecuteNonQuery()
        iconexao.Close()
    End Sub



#End Region

#Region "BOTÕES"

    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If (MessageBox.Show(" Deseja mesmo efetuar o registro ?", "" & legenda & "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = MsgBoxResult.Yes Then
            ' CADASTRA NOVO TERMINAL SE NÃO EXISTE
            Call gravaterminal() ' FAZ A INSERÇÃO DO REGISTRO NA TABELA DO SISTEMA
            MessageBox.Show("Processo executado com sucesso! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("O sistema deverá ser reiniciado! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Dispose()
            Application.Exit()
        Else
            Dispose()
        End If
    End Sub


#End Region


    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub
End Class
























