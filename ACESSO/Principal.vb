Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class Principal
#Region "VARIAVEIS"
    Dim Data_hoje As DateTime = DateTime.Now
    Dim occ005 As New TextBox
    Dim status As String = ""
    Public xModulo, xParam As String
    Public xNivel As String
    Dim A, B, C, D As Integer
    Dim retorno, pesq As String
    Dim sql As String
    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Protected regionHandle As IntPtr
#End Region

#Region "START DO FORMULÁRIO"
    Private Sub frmbeep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True  ' DESLIGA O BEEP DO TECLADO QUANDO ACIONADO O ENTER
        End If
    End Sub
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call inicio_processo() ' inicia o processo inicial do sistema na página principal
    End Sub
#End Region

#Region "FUNÇÕES"
    Private Sub inicio_processo()
        PanelMenu.Visible = True
        Call AbrePagina() ' VERIFICA SE JÁ EXISTE PÁGINA ABERTA NO LIVRO DE OCORRENCIAS DIÁRIO
        tbUsuario.Text = UCase(Login.lvdados.Text)  ' CONVERTE O NOME DO USUÁRIO PARA LETRAS MAISCULAS
        tbTerminal.Text = iTerminal                 ' NOME DO TERMINAL
        tbData.Text = UCase(Today.ToLongDateString) ' DATA ATUAL DO SISTEMA
        lbConecta.Text = xServidor
        TextoCabecalho.Text = " " & sistema & " - " & versao & "   " & datasis & "   [ " & iReg002 & "    CNPJ/MF: " & iReg009 + " ]"
        D = 0
    End Sub


    Private Sub AbrePagina()
        occ005.Text = Format(Data_hoje, "yyyyMMdd")
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim sql As String
        If conexao.State = 0 Then
            conexao.Open()
        End If
        retorno = Nothing
        sql = "select OCC006 from prt_lvocc where OCC005 = '" & occ005.Text & "'"
        da = New MySqlDataAdapter(sql, conexao)
        da.Fill(ds, "prt_lvocc")
        If ds.Tables("prt_lvocc").Rows.Count > 0 Then
            retorno = "TRUE"
        Else
            retorno = "FALSE"
        End If

        If retorno = "FALSE" Then
            Dim cmd As New MySqlCommand("insert into prt_lvocc (OCC002,OCC003,OCC004,OCC005)VALUES('" & Format(Data_hoje, "yyyy-MM-dd") & "','" & DateTime.Now.ToLongTimeString().Substring(0, 5) & "','" & iUsername & "','" & occ005.Text & "')", conexao)
            cmd.ExecuteNonQuery()
            MetroFramework.MetroMessageBox.Show(Me, " O sistema abriu uma nova página de ocorrências. A página anterior foi bloqueada para edição! ")
        End If
        conexao.Close()
    End Sub
    Private Sub abriform(Of miform As {Form, New})()
        Dim formulario As Form
        formulario = frmBase.Controls.OfType(Of miform)().FirstOrDefault
        If formulario Is Nothing Then
            formulario = New miform
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            frmBase.Controls.Add(formulario)
            frmBase.Tag = formulario
            formulario.Show()
            formulario.BringToFront()
        Else
            formulario.BringToFront()
        End If
    End Sub

#End Region

#Region "MENU LATERAL"
    ' --- MENU CADASTROS --------------------------------------------------------------
    Private Sub menu_1_1_Click(sender As Object, e As EventArgs) Handles menu_1_1.Click
        ' Cadastro de proprietários
        Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
        abriform(Of frmCadProp)()
    End Sub

    Private Sub menu_1_2_Click(sender As Object, e As EventArgs) Handles menu_1_2.Click
        ' Manutenção de locatários de unidades
        Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
        abriform(Of frmLocatario)()
    End Sub

    Private Sub menu_1_3_Click(sender As Object, e As EventArgs) Handles menu_1_3.Click
        ' Hospedes e Usuários de locação temporária
        Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
        abriform(Of frmHospedes)()
    End Sub

    Private Sub menu_1_4_Click(sender As Object, e As EventArgs) Handles menu_1_4.Click
        ' funcionários do empreendimento
        Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
        abriform(Of frmFuncionarios)()
    End Sub

    Private Sub menu_1_5_Click(sender As Object, e As EventArgs) Handles menu_1_5.Click
        ' prestadores avulso sem registro em carteira / autonomos
        Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
        abriform(Of frmPrestadores)()
    End Sub

    Private Sub menu_1_6_Click(sender As Object, e As EventArgs) Handles menu_1_6.Click
        ' Empresas e fornecedores
        Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
        abriform(Of frmEmpresas)()
    End Sub

    Private Sub menu_1_7_Click(sender As Object, e As EventArgs) Handles menu_1_7.Click
        ' cadastro das vagas e garagens
        Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
        abriform(Of frmCadGar)()
    End Sub

    Private Sub menu_1_9_Click(sender As Object, e As EventArgs) Handles menu_1_9.Click
        ' Armários rotativo
        Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
        abriform(Of frmArmarios)()
    End Sub

    Private Sub menu_1_8_1_Click(sender As Object, e As EventArgs) Handles menu_1_8_1.Click
        ' Cadastro de usuários
        Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
        abriform(Of CadUser)()
    End Sub

    Private Sub menu_1_8_2_Click(sender As Object, e As EventArgs) Handles menu_1_8_2.Click
        ' Manutenção de senha
        Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
        Senhas.tbUSU002.Text = iUsername
        If iUsername = "SUPERSENHA" Then
            MetroFramework.MetroMessageBox.Show(Me, " Senha de Uso do Sistema... Proibido Alteração! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf iUsername = "ADMINISTRADOR" Then
            MetroFramework.MetroMessageBox.Show(Me, " Usuário Reservado ao Sistema... Proibido Alteração! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            abriform(Of AlterSenha)()
        End If
    End Sub
    ' --- MENU PORTARIA --------------------------------------------------------------
    Private Sub menu_2_Click(sender As Object, e As EventArgs) Handles menu_2.Click
        PanelMenu.Visible = False
        frmBase.Controls.Clear()
        TextoCabecalho.Text = "Painel de Controle da Portaria   " & sistema & " - " & versao & "   " & datasis
        Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
        abriform(Of Portaria)()

    End Sub
    ' --- MENU CONSULTAS --------------------------------------------------------------
    Private Sub menu_3_1_Click(sender As Object, e As EventArgs) Handles menu_3_1.Click

    End Sub
    ' --- MENU SISTEMA --------------------------------------------------------------
    Private Sub menu_4_1_Click(sender As Object, e As EventArgs) Handles menu_4_1.Click
        ' informação da licvença de uso do sistema / alterações interferem no painel na nuvem
        Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
        abriform(Of Licenca)()
    End Sub

    Private Sub menu_4_2_Click(sender As Object, e As EventArgs) Handles menu_4_2.Click
        ' parametros do sistema que serão implementadas

    End Sub

    Private Sub menu_4_3_Click(sender As Object, e As EventArgs) Handles menu_4_3.Click
        ' habilita o terminal para o uso no sistema
        If tbUsuario.Text = "SUPERSENHA" Then
            Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
            abriform(Of CadTerminal)()
        Else
            MetroFramework.MetroMessageBox.Show(Me, " Módulo habilitado somente com a senha do administrador! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub menu_4_4_Click(sender As Object, e As EventArgs) Handles menu_4_4.Click
        ' provedor de email - configura o provedor de envio de emails para avisos diversos

    End Sub



    Private Sub menu_4_6_Click(sender As Object, e As EventArgs) Handles menu_4_6.Click
        ' informações sobre o sistema
        Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
        abriform(Of Sobre)()
    End Sub
#End Region


#Region "BOTÕES AVULSO"
    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        ' MINIMINIZA O FORMULÁRIO
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' FECHA O FORMULÁRIO

        If PanelMenu.Visible = False Then
            frmBase.Controls.Clear()
            inicio_processo() ' inicia processo da página principal
        Else
            If (MetroFramework.MetroMessageBox.Show(Me, " O sistema será encerrado. Deseja prosseguir ? ", "" & legenda & "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = MsgBoxResult.Yes Then
                Dispose()
                Application.Exit()
            End If
        End If

    End Sub
    Private Sub btnTrocaUser_Click(sender As Object, e As EventArgs) Handles btnTrocaUser.Click
        ' TROCA DE USUÁRIO
        If (MetroFramework.MetroMessageBox.Show(Me, " O usuário atual será trocado. Confirma à alteração ? ", "" & legenda & "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = MsgBoxResult.Yes Then
            Dispose()
            Me.Hide()
            'Formulario Principal do sistema vai ficar aqui
            formularioAtual = New Login()
            formularioAtual.Show()
        End If
    End Sub
    Private Sub btnEncerra_Click(sender As Object, e As EventArgs) Handles btnEncerra.Click
        ' ENCERRA O SISTEMA
        If (MetroFramework.MetroMessageBox.Show(Me, " O sistema será encerrado. Deseja prosseguir ? ", "" & legenda & "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = MsgBoxResult.Yes Then
            Dispose()
            Application.Exit()
        End If
    End Sub
#End Region

#Region "COMPONENTES"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' relógio do sistema e verificação da super senha
        A = A + 1
        D += 1
        C += 1
        relogio.Text = DateTime.Now.ToLongTimeString
        If tbUsuario.Text = "SUPERSENHA" Then
            conta += 1
            If conta >= 300 Then
                conta = 0
                'Call EndTerminal()
                MetroFramework.MetroMessageBox.Show(Me, "Tempo de Uso da Super Senha Expirou", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                End
            End If
        End If

        ' LÓGICA QUE TRATA DO DISPARO DE AVISOS DO SISTEMA 
        If C = 601 Then
            If iCli019 = 2 And tbUsuario.Text <> "SUPERSENHA" Then
                If Aviso03.Visible = False Then
                    Aviso03.ShowDialog()
                    C = 0
                End If
            End If
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        monitor += 1
        If monitor >= 1800 Then
            Call AbrePagina() ' verifica se´já foi aberta a página do livro de ocorrência
            monitor = 0
        End If
    End Sub
#End Region



End Class
























