Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class Login
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

#Region "VARIAVEIS"
    'Dim contagem As Integer  ' FA A CONTAGEM DE QUANTAS VEZES O USUÁRIO TENTOU ACESSO APÓS O TERCEIRO ERRO ABORTA O SISTEMA OU BLOQUEIA O USUÁRIO
    Dim nome_arquivo_ini As String = My.Application.Info.DirectoryPath & "\conexao.ini"
    Dim retorno As String    ' TESTE DE RERTORNO DE PESQUISA
    Dim iDataAuto As Date    ' RETORNA A DATA DE HOJE DO SISTEMA
    Dim iPlaca, nTERMINAL As String     ' VARIAVEL DE CAPTURA DA PLACA DE REDE
    Dim qReg As Integer      ' FAZ A CONTAGEM DE USUÁRIOS HABILITADOS PARA O USO DO SISTEMA
    Dim tempo, C As Integer
    Dim somar As Integer
    Dim Calc3 As Integer = 0
    Dim Calc4 As Integer = 0
    Dim Calc5 As Integer = 0
    Dim iChaves, iUSU009 As String    ' FAZ A LIBERAÇÃO DO ACESSO SEM VERIFICAR A PLACA DE REDE EM CASO DE ESTGAR SEM INTERNET
#End Region

#Region "START DO FORMULÁRIO - LOAD"
    Private Sub login_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            ' DESLIGA O SOM DO TECLADO AO ACIONAR ENTER
            e.Handled = False
        End If
    End Sub

#Region "BEEP DO ENTER"
    Private Sub beep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
#End Region

    'Carregamento do formulário de login
    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label4.Text = "Versão:  " & versao & "  Data:  " & datasis
        Me.CancelButton = btnClose
        VerConexao = 1 ' MUDA O STATUS PARA VERIFICAÇÃO DA CONEXAO DO TERMINAL
        PanelSenha.Visible = True

        'Instrução para deixar o formulário redondo
        Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
        ObtemIP.ObtemEnderecoIP()

        iDataAuto = Format(Data_hoje, "dd/MM/yyyy")      ' FORMATA A DATA DE VERIFICAÇÃO DO SISTEMA
        iCli019 = 10                                     ' VARIAVEL DE AUTENTICAÇÃO DO CLIENTE NA NUVEM

        iTerminal = UCase(nomehost)                      ' NOME DO TERMINAL
        lvdados.Text = ""                                ' LIMPA O CAMPO DE INDICAÇÃO DE USUÁRIOS
        tbSenha.Clear()                                  ' LIMPA O CAMPO DE DIGITAÇÃO DA SENHA 

        conta = 0                                        ' VARIAVEL QUE CONTROLA O NÚMERO DE TENTATIVAS DE ACESSO - DIGITAÇÃO DE SENHA ERRADA
        tempo = 0                                        ' VARIAVEL DE CONTROLE DA SUPER SENHA QUANDO VAI ATUALIZAR 
        somar = 10                                       ' VARIAVEL DE CONTROLE DA SUPER SENHA
        Call MontaSuperSenha()                           ' FAZ A MONTAGEM DA SUPER SENHA

        If Not System.IO.File.Exists(Application.StartupPath & "\conexao.ini") Then
            ' VERIFICA A EXISTÊNCIA DO ARQUIVO *.INI DE CONEXÃO AO BANCO DE DADOS
            ' COMO NÃO EXISTE O ARQUIVO CONEXAO.INI, VAI ABRIR UM FORMULÁRIO PARA CONFIGURAR E GRAVAR NA PASTA BIN ONDE FICA A EXECUTÁVEL DO SISTEMA
            MetroFramework.MetroMessageBox.Show(Me, " A conexão local com o banco de dados não foi definida... ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
            abriform(Of BDados)()
        Else
            ' INICIA O PROCESSO DE ACESSO AO SISTEMA
            Call Conferencia(0) ' FAZ A LEITURA DO ARQUIVO CONEXAO.INI PARA MONTAR A CONEXAO AO BANCO DE DADOS MySQL
            Call Conferencia(2) ' BUSCA O REGISTRO DA EMPRESA REGISTRADA - TABELA REGISTRO
        End If
        Exibe_con.Text += " " & xServidor
    End Sub
#End Region

#Region "FUNÇÕES"
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
    Private Sub pesquisa()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        retorno = Nothing
        da = New MySqlDataAdapter("select ID, TERMINAL from terminal where USU001 = '" & iCodUser & "' and SISTEMA = '" & sistema & "'", conexao)
        da.Fill(ds, "terminal")
        If ds.Tables("terminal").Rows.Count > 0 Then
            IDTerminal = ds.Tables("terminal").Rows(0).Item(0)
            nTERMINAL = ds.Tables("terminal").Rows(0).Item(1)
            retorno = 1
        Else
            IDTerminal = Nothing
            retorno = 0
        End If

        If retorno = 1 Then
            MetroFramework.MetroMessageBox.Show(Me, " O usuário:   " & iUsername & "   Já se encontra logado no terminal:   " & iTerminal & ". O sistema irá fechar o acesso no terminal informado!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conexao.Open()
            Dim st = "UPDATE terminal set STATUS = '2' WHERE ID = '" & IDTerminal & "'"
            Dim cmd As New MySqlCommand(st, conexao)
            cmd.ExecuteNonQuery()
            conexao.Close()
        End If

    End Sub
    Private Sub fade_in()
        For intval As Single = 0.0 To 1.1 Step 0.1
            Me.Opacity = intval
            Me.Refresh()
            Threading.Thread.Sleep(40)
        Next
    End Sub
    Private Sub rotinaAcesso()
        If conta >= 3 Then
            MetroFramework.MetroMessageBox.Show(Me, " Número de tentativas de acesso esgotado! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        Else
            If lvdados.Text = "SUPERSENHA" Then
                ConverteSenha = UCase(tbSenha.Text)
            Else
                ConverteSenha = geraHash(tbSenha.Text)
            End If
            If iSenha = ConverteSenha Then
                If lvdados.Text = "SUPERSENHA" Then
                    MetroFramework.MetroMessageBox.Show(Me, "Acesso com a super senha. Tempo máximo de utilização (  5  ) minutos", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Seja Bem Vindo ao Sistema: " & legenda & "  -  " & lvdados.Text, " ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                ' O SISTEMA ASSUME O FORMULÁRIO PRINCIPAL Me.Hide

                ' aqui faz a transição para o formulário principal do sistema

                'Call pesquisa() ' PESQUISA SE O USUÁRIO JÁ ESTÁ LOGADO EM OUTRO TERMINAL. CASO POSITIVO FAZ O ENCERRAMENTO DO USUÁRIO NO TERMINAL ANTERIOR
                Me.Hide()
                formularioAtual = New Principal()
                formularioAtual.Show()
            Else
                ' A SENHA SENDO INVÁLIDA FAZ A CONTAGEM ATÉ ATINGIR 3 TENTATIVAS
                MetroFramework.MetroMessageBox.Show(Me, " Senha Inválida... ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conta += 1
                tbSenha.Clear()
                tbSenha.Focus()
            End If
        End If
    End Sub
    Private Sub gravar(arg)
        Select Case arg
            Case 0
                '' GRAVA A A DATA DO ULTIMO ACESSO AO SISTEMA
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim s1 As String = "update registro set REG013 = '" & Format(Data_hoje, "yyyy-MM-dd") & "', REG020 = '0' WHERE REG001 ='" & tbReg001.Text & "' and REG018 = '" & sistema & "'"
                Dim cmnd As New MySqlCommand(s1, conexao)
                conexao.Open()
                cmnd.ExecuteNonQuery()
            Case 1
                '' GRAVA TENTATIVA DE ACESSO SEM INTERNET
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim s1 As String = "update registro set REG013 = '" & Format(Data_hoje, "yyyy-MM-dd") & "', REG020 = '" & iReg020 & "' WHERE REG001 ='" & tbReg001.Text & "' and REG018 = '" & sistema & "'"
                Dim cmnd As New MySqlCommand(s1, conexao)
                conexao.Open()
                cmnd.ExecuteNonQuery()
        End Select
    End Sub

    Private Sub Conferencia(arg)
        Select Case arg
            Case 0
                ' FAZ A LEITURA DO ARQUIVO (conexao.ini) PRESENTE DENTRO DA PASTA BIN
                'Dim nome_arquivo_ini As String = My.Application.Info.DirectoryPath & "\conexao.ini"
                iDatabase = LeArquivoINI(nome_arquivo_ini, "Banco", "xDataBase", "")  ' NOME DO BANCO 
                iservidor = LeArquivoINI(nome_arquivo_ini, "Banco", "xHostName", "")  ' SERVIDOR 
                iPort = LeArquivoINI(nome_arquivo_ini, "Banco", "xPort", "")          ' PORTA DE ACESSO AO MYSQL
                xDatabase = LeArquivoINI(nome_arquivo_ini, "Registro", "iDatabase", "") ' BANCO DE DADOS DE AUTENTICAÇÃO
                xServidor = LeArquivoINI(nome_arquivo_ini, "Registro", "iHostname", "") ' IP SERVIDOR
                xPort = LeArquivoINI(nome_arquivo_ini, "Registro", "iPorta", "")        ' PORTA DE ACESSO MYSQL
                xUserMysql = LeArquivoINI(nome_arquivo_ini, "Registro", "iUserPass", "")        ' USUÁRIO PARA ACESSO AO BANCO DE DADOS
                xSenhaMysql = LeArquivoINI(nome_arquivo_ini, "Registro", "iMacSistema", "") ' SENHA DE ACESSO AO CLOUD

                'conexao = New MySqlConnection("server=" & iservidor & "; port=" & iPort & "; Database=" & iDatabase & "; Uid=" & iUserMysql & "; pwd=" & iSenhaMysql & "; SslMode=Required")  ' LOCAL
                'iconexao = New MySqlConnection("server=" & xServidor & "; port=" & xPort & "; Database=" & xDatabase & "; Uid=" & xSenhaMysql & "; pwd=" & xSenhaMysql & "; SslMode=Required") ' 

                'conexao = New MySqlConnection("Server=" & iservidor & ";Database=" & iDatabase & ";Uid=" & iUserMysql & ";pwd=" & iSenhaMysql & "; port=" & iPort & ";SslMode=Required")
                'iconexao = New MySqlConnection("Server=" & xServidor & ";Database=" & xDatabase & ";Uid=" & xUserMysql & ";pwd=" & xSenhaMysql & "; port=" & xPort & ";SslMode=Required")
                conexao = New MySqlConnection("server=localhost;port=3306;database=gstec;uid=root;password='1234' ")
                iconexao = New MySqlConnection("server=177.85.97.191;port=3306;database=devsys01_portaria;uid=devsys01_devsys;password='DevSys_123' ")
                ' DevSys - atualizar tabela registro com data de hoje antes de iniciar
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim s1 As String = "update registro set REG013 = '" & Format(Data_hoje, "yyyy-MM-dd") & "'"
                Dim cmnd As New MySqlCommand(s1, conexao)
                conexao.Open()
                cmnd.ExecuteNonQuery()
            Case 2
                ' VERIFICA SE O SISTEMA JÁ ESTÁ REGISTRADO - TABELA REGISTRO
                Dim ds As New DataSet
                Dim da As MySqlDataAdapter
                Dim sql As String
                sql = "select * from registro"
                da = New MySqlDataAdapter(sql, conexao)
                da.Fill(ds, "registro")
                retorno = Nothing
                If ds.Tables("registro").Rows.Count > 0 Then
                    ' CONFIGURA A CONEXÃO PARA O SERVIDOR DE AUTENTICAÇÃO
                    tbReg001.Text = ds.Tables("registro").Rows(0).Item(1)
                    iReg001 = tbReg001.Text
                    ' SE O TEXTBOX RETORNAR COM O CÓDIGO FAZ A BUSCA E CARREGA AS VARIÁVEIS DA EMPRESA - TABELA REGISTRO
                    Call CarregaDados(0) ' FAZ A BUSCA DOS DADOS DA EMPRESA NA TABELA REGISTRO
                    Call Conferencia(3) ' VERIFICA SE EXISTE CONEXÃO COM A INTERNET
                Else
                    ' CASO NÃO ENCONTRE A CONFIGURAÇÃO DO SERVIDOR DE AUTENTICAÇÃO ABORTA O SISTEMA
                    MetroFramework.MetroMessageBox.Show(Me, " É necessário registrar o sistema para prosseguir...", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
                    abriform(Of Registro)()
                End If
            Case 3
                ' VERIFICA A CONEXÃO COM A INTERNET SE ESTÁ ATIVA OU NÃO
                If verificaconexao.VerificaConexao_TcpSocket Then
                    iChaves = 1 ' SEM INTERNET LIBERA O ACESSO DA ESTAÇÃO
                    imgNet.Image = Imagens.Images("0")
                    ToolTip1.SetToolTip(imgNet, "Internet Ativa")
                    If iReg013 <> iDataAuto Then
                        Call CarregaDados(3) ' ACESSA O SERVIDOR DE AUTENTICAÇÃO DE BLOQUEIO DO SISTEMA STATUS = 0 LIBERADO // 1 - BLOQUEADO
                        If iCli019 = 0 Then
                            Call gravar(0)      ' GRAVA A ULTIMA DATA DE ACESSO AO SISTEMA // ASSIM SOMENTE NO DIA SEGUINTE FAZ NOVA VERIFICAÇÃO
                            Call Conferencia(4) ' CARREGA DADOS DOS USUÁRIOS APÓS VERIFICAÇÃO DA PLACA DE REDE QUE AUTORIZA O ACESSO AO SISTEMA 
                        Else
                            ' EXIBE AVISO DE BLOQUEIO E ABORTA O SISTEMA
                            If iCli019 = 1 Then
                                ' AVISO DE BLOQUEIO TOTAL DO SISTEMA NÃO LIBERA COM STATUS 1
                                Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
                                abriform(Of Aviso01)()
                            ElseIf iCli019 = 2 Then
                                ' AVISO DE ADVERTÊNCIA DO SISTEMA
                                Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
                                abriform(Of Aviso03)()
                                Call Conferencia(4) ' CARREGA DADOS DOS USUÁRIOS APÓS VERIFICAÇÃO DA PLACA DE REDE QUE AUTORIZA O ACESSO AO SISTEMA 
                            End If

                        End If
                    Else
                        Call Conferencia(4) ' CARREGA DADOS DOS USUÁRIOS APÓS VERIFICAÇÃO DA PLACA DE REDE QUE AUTORIZA O ACESSO AO SISTEMA 
                    End If
                Else
                    imgNet.Image = Imagens.Images(1)
                    ToolTip1.SetToolTip(imgNet, "Internet Inativa")
                    iChaves = 0 ' SEM INTERNET LIBERA O ACESSO DA ESTAÇÃO
                    'VERIFICA A VARIAVEL iREG20 SE MENOR QUE 3 LIBERA ACESSO E GRAVA +1 NA TABELA REGISTRO
                    'SE MAIOR QUE 3 BLOQUEIA O ACESSO POR FALTA DE VERIFICAÇÃO NA INTERNET
                    'EM RESUMO, O SISTEMA LIBERA TRES ACESSOS SEM PRECISAR TER INTERNET ATIVA

                    If iReg013 <> iDataAuto Then
                        If iReg020 < 3 Then
                            iReg020 += 1
                            MetroFramework.MetroMessageBox.Show(Me, "Atenção: Não foi possivel verificar sua conexão com a internet. A conexão é necessária para autenticação junto aos orgãos governamentais SEFAZ. O Acesso será liberado tentativa:  " & "[ " & iReg020 & "/ 3 ] Seu acesso será bloqueado após três dias sem acesso a internet. Em caso de duvida entre em contato com o devenvolvedor: (12) 3662-5281 e (12) 3662-1430", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Call gravar(1)      ' FAZ O CONTROLE DE ACESSO AO SISTEMA SEM INTERNET - LIBERADO O ACESSO POR 3 DIAS APÓS ISSO BLOQUEIA O SISTEMA
                            Call Conferencia(4) ' CARREGA DADOS DOS USUÁRIOS APÓS VERIFICAÇÃO DA PLACA DE REDE QUE AUTORIZA O ACESSO AO SISTEMA 
                        Else
                            ' EXIBE AVISO DE BLOQUEIO E ABORTA O SISTEMA
                            Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
                            abriform(Of Aviso02)()

                        End If
                    Else
                        If iReg020 < 3 Then
                            Call Conferencia(4) ' CARREGA DADOS DOS USUÁRIOS APÓS VERIFICAÇÃO DA PLACA DE REDE QUE AUTORIZA O ACESSO AO SISTEMA 
                        Else
                            ' EXIBE AVISO DE BLOQUEIO E ABORTA O SISTEMA
                            Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
                            abriform(Of Aviso02)()
                        End If
                    End If
                End If

            Case 4
                ' VERIFICAÇÃO DA ESTÇÃO DE TRABALHO SE ESTÁ OU NÃO HABILITADA / FAZ PARTE DO PACOTE DE CONTRATAÇÃO
                Dim mc As System.Management.ManagementClass
                Dim mo As System.Management.ManagementBaseObject
                mc = New Management.ManagementClass("Win32_NetworkAdapterConfiguration")
                Dim moc As Management.ManagementObjectCollection = mc.GetInstances
                For Each mo In moc
                    If mo.Item("IPenabled") = True Then
                        iPlaca = mo.Item("MacAddress")
                    End If
                Next
                If iChaves = 1 Then
                    Call CarregaDados(2) ' BUSCA INFORMAÇÕES NA TABELA CHAVES
                    If retorno = 1 Then
                        Call CarregaDados(1)   ' RELACIONA OS USUÁRIOS AUTORIZADOS A UTILIZAR O SISTEMA
                    Else
                        Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
                        abriform(Of Aviso04)()
                    End If
                Else
                    ' LIBERA O ACESSO DO TERMINAL QUANDO NÃO TEM INTERNET - A VERIFICAÇÃO FICA NO BANCO DE DADOS EM NUVEM
                    MetroFramework.MetroMessageBox.Show(Me, " Não foi possivel autenticar o terminal... Sistema será liberado! Verifique sua conexão com a internet. ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call CarregaDados(1)   ' RELACIONA OS USUÁRIOS AUTORIZADOS A UTILIZAR O SISTEMA

                End If
        End Select
    End Sub

    Private Sub CarregaDados(arg)
        ' CARREGA OS DADOS PARA INICIAR O SISTEMA
        Select Case arg
            Case 0
                Try
                    ' DevSys - Banco ja esta aberto apos a conexao para atualizar data
                    If conexao.State = ConnectionState.Closed Then conexao.Open()
                    Dim cmd As New MySqlCommand("select * from registro where REG001 = '" & tbReg001.Text & "'", conexao)
                    Dim drdr As MySqlDataReader
                    Dim bt() As Byte
                    Dim mt As MemoryStream
                    drdr = cmd.ExecuteReader
                    drdr.Read()
                    ' DevSys -  comentado as tres linhas a baixo
                    'bt = drdr.Item("REG015")      ' logo da empresa
                    'mt = New MemoryStream(bt)
                    'iReg015 = Image.FromStream(mt)
                    iReg002 = drdr("REG002")      ' Nome da empresa registrada para uso do sistema
                    iReg003 = drdr("REG003")      ' Endereço
                    iReg004 = drdr("REG004")      ' Bairro
                    iReg005 = drdr("REG005")      ' Cidade
                    iReg006 = drdr("REG006")      ' Estado
                    iReg007 = drdr("REG007")      ' CEP
                    iReg008 = drdr("REG008")      ' Complemento
                    iReg009 = drdr("REG009")      ' CNPJ
                    iReg010 = drdr("REG010")      ' Inscrição Estadual
                    iReg011 = drdr("REG011")      ' Telefone 01
                    iReg012 = drdr("REG012")      ' Telefone 02
                    iReg013 = drdr("REG013")      ' Data que vence a licença de funcionamento
                    iReg014 = drdr("REG014")      ' email da empresa 
                    iReg016 = drdr("REG016")      ' Nome Fantasia da Empresa
                    ireg017 = drdr("REG017")      ' Versão atual do sistema
                    iReg018 = drdr("REG018")      ' Nome do sistema
                    iReg019 = drdr("REG019")      ' Data do sistema
                    iReg020 = drdr("REG020")      ' Responsavel por liberar o sistema quando não tem acesso pela internet
                    iReg013 = Format(iReg013, "dd/MM/yyyy") ' DevSys "dd/MM/yyyy"Converte a data da ultima verificação do sistema para o formato brasileiro
                    cmd.Cancel()
                    conexao.Close()
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, " O Sistema ainda não foi registrado! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Dispose()
                End Try
            Case 1
                Dim ds As New DataSet
                Dim dr As DataRow
                Dim dt As New DataTable
                Dim sql As String
                sql = "select * from usuarios where USU006 = 'S' and USU008 = '" & sistema & "' order by USU002"
                Dim adptr As New MySqlDataAdapter(sql, conexao)
                adptr.Fill(ds, "USUARIOS")
                dt = ds.Tables(0)
                lvdados.Items.Clear()
                qReg = 0
                For Each dr In dt.Rows
                    lvdados.Items.Add(dr.Item("USU002"))
                    qReg += 1
                Next
                If qReg = 0 Then
                    ' SE NÃO HOUVER USUÁRIOS CADASTRADOS PARA USAR O SISTEMA
                    If (MetroFramework.MetroMessageBox.Show(Me, " Módulo do sistema sem usuários cadastrados. Deseja cadastrar agora ?", "" & legenda & "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = MsgBoxResult.Yes Then
                        'aqui
                        Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
                        abriform(Of UserInicial)()
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "Nenhum usuário foi adicionado... O Sistema será abortado", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Dispose()
                        Application.Exit()
                    End If
                End If
            Case 2
                ' VERIFICA SE A ESTAÇÃO ESTÁ LIBERADA PARA TRABALHAR - CONFERENCIA DA PLACA DE REDE
                Dim ds As New DataSet
                Dim da As MySqlDataAdapter
                Dim Pesq As String
                retorno = Nothing
                Pesq = "select * from chaves where CLI001 = '" & tbReg001.Text & "' and CHA001 = '" & iTerminal & "' and CHA002 = '" & iPlaca & "' and CHA003 = '" & sistema & "' and CHA004 = 1 order by CLI001"
                da = New MySqlDataAdapter(Pesq, iconexao)
                da.Fill(ds, "chaves")
                If ds.Tables("chaves").Rows.Count > 0 Then
                    retorno = 1   ' TERMINAL LIBERADO
                Else
                    retorno = 1   ' DevSys - modificado de 0 para 1 -TERMINAL BLOQUEADO 
                End If
            Case 3
                ' VERIFICA O CLIENTE SE ESTA LIBERADO OU BLOQUEADO / VERIFICA TAMBÉM SE PRECISA ATUALIZAR A VERSÃO
                Try
                    If iconexao.State = ConnectionState.Closed Then iconexao.Close()
                    iconexao.Open()
                    Dim cmd As New MySqlCommand("select * from clientes where CLI001 = '" & tbReg001.Text & "' and CLI017 = '" & sistema & "'", iconexao)
                    Dim drdr As MySqlDataReader
                    drdr = cmd.ExecuteReader
                    drdr.Read()

                    iCli019 = drdr("CLI019")      ' VARIAVEL QUE VERIFICA SE O SISTEMA ESTÁ LIBERADO OU NÃO PARA O DIA DE HOJE

                    cmd.Cancel()
                    iconexao.Close()
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, " Não foi possivel autenticar o sistema. Entre em contatato com o desenvolvedor (12) 3662-5281", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Application.Exit()
                End Try
            Case 4
                lvdados.Text = UCase(lvdados.Text)
                Dim sql As String
                If conexao.State = 0 Then
                    conexao.Open()
                End If
                sql = "select * from usuarios where USU002 = '" & lvdados.Text & "' and USU006 = 'S' and USU008 = '" & sistema & "' ORDER BY USU002 "

                Dim cmd As New MySqlCommand(sql, conexao)
                Dim drdr As MySqlDataReader
                drdr = cmd.ExecuteReader
                drdr.Read()
                iCodUser = drdr.Item("USU001")       ' CÓDIGO DO USUÁRIO NO SISTEMA
                iSenha = drdr.Item("USU004")         ' SENHA CADASTRADA PARA O USUÁRIO
                iMail = drdr.Item("USU007")          ' CARREGA O EMAIL CADASTRADO PELO USUÁRIO
                iUSU009 = drdr.Item("USU009")        ' VERIFICADOR PARA ALTERAÇÃO DA SENHA INICIAL
                iUsu007 = drdr.Item("USU007")        ' ENDEREÇO DE EMAIL
                cmd.Cancel()
                conexao.Close()
                tbSenha.Clear()
                tbSenha.Select()
                tbSenha.Focus()
            Case 5

        End Select
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub btnAsenha_Click(sender As Object, e As EventArgs) Handles btnAsenha.Click
        If lvdados.Text = "SUPERSENHA" Then
            MetroFramework.MetroMessageBox.Show(Me, "Usuário e senha de uso exclusivo do sistema! Proibido alteração.", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbSenha.Select()
        Else
            If lvdados.Text = Nothing Then
                MetroFramework.MetroMessageBox.Show(Me, " Selecione o usuário para alteração da senha!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lvdados.Focus()
            Else
                tbSenha.Clear()
                Senhas.tbUSU002.Text = lvdados.Text
                Senhas.ShowDialog()
                Call CarregaDados(0)
            End If
            Senhas.Dispose()
            tbSenha.Clear()
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dispose()
        Application.Exit()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Me.WindowState = FormWindowState.Maximized
        btnMax.Visible = False
        btnNormal.Visible = True
    End Sub
    Private Sub btnNormal_Click(sender As Object, e As EventArgs) Handles btnNormal.Click
        Me.WindowState = FormWindowState.Normal
        btnMax.Visible = True
        btnNormal.Visible = False
    End Sub
    Private Sub btnexec_Click(sender As Object, e As EventArgs) Handles btnexec.Click
        If lvdados.Text = "SUPERSENHA" Then
            If tbSenha.TextLength = 0 Or tbSenha.Text = Nothing Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe a senha do iToken ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbSenha.Focus()
            Else
                Call rotinaAcesso() ' rotina de verificação de senha e conferência
            End If
        Else
            If Me.lvdados.FindString(lvdados.Text) = -1 Or lvdados.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Me, " Usuário inválido ou sem acesso ao sistema. Verifique! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lvdados.Text = ""
                lvdados.Select()
            Else
                If tbSenha.TextLength = 0 Or tbSenha.Text = Nothing Then
                    MetroFramework.MetroMessageBox.Show(Me, " Informe a senha do usuário ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tbSenha.Focus()
                Else
                    Call rotinaAcesso() ' rotina de verificação de senha e conferência
                End If
            End If
        End If
    End Sub

#End Region

#Region "COMPONENTES / ENTER"
    Private Sub lvdados_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lvdados.SelectedIndexChanged
        If lvdados.Text <> "" Or lvdados.Text <> Nothing Then
            C = 0  ' CONTROLE DE DISPARO DE AVISOS SE HOUVER

            iUsername = lvdados.Text

            Call CarregaDados(4) ' BUSCA OS DADOS DO USUÁRIO SELECIONADO PARA TRATAMENTO DA ENTRADA NO SISTEMA
            If iUSU009 = 1 Then
                If (MetroFramework.MetroMessageBox.Show(Me, " Você precisar alterar sua senha inicial. Deseja alterar agora?", "" & legenda & "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = MsgBoxResult.Yes Then
                    If lvdados.Text = Nothing Then
                        MetroFramework.MetroMessageBox.Show(Me, " Selecione o usuário para alteração da senha!", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        lvdados.Focus()
                    Else
                        tbSenha.Clear()
                        Senhas.tbUSU002.Text = lvdados.Text
                        Senhas.ShowDialog()
                        Call CarregaDados(4)
                    End If
                Else
                    tbSenha.Clear()
                    tbSenha.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub lvdados_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles lvdados.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode

        If KeyCode = System.Windows.Forms.Keys.Return Then
            lvdados.Text = UCase(lvdados.Text)
            If lvdados.Text = "SUPERSENHA" Then
                iUsername = lvdados.Text
                tbSenha.Focus()
            Else
                If Me.lvdados.FindString(lvdados.Text) = -1 Or lvdados.Text = "" Then
                    MetroFramework.MetroMessageBox.Show(Me, " Usuário inválido ou sem acesso ao sistema. Verifique! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    lvdados.Text = ""
                Else
                    iUsername = lvdados.Text
                    Call CarregaDados(4)
                End If
            End If
        End If
    End Sub
    Private Sub tbsenha_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbSenha.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If lvdados.Text = "SUPERSENHA" Then
                If tbSenha.TextLength = 0 Or tbSenha.Text = Nothing Then
                    MetroFramework.MetroMessageBox.Show(Me, " Informe a senha do iToken ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tbSenha.Focus()
                Else
                    Call rotinaAcesso() ' rotina de verificação de senha e conferência
                End If
            Else
                If Me.lvdados.FindString(lvdados.Text) = -1 Or lvdados.Text = "" Then
                    MetroFramework.MetroMessageBox.Show(Me, " Usuário inválido ou sem acesso ao sistema. Verifique! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    lvdados.Text = ""
                    lvdados.Select()
                Else
                    If tbSenha.TextLength = 0 Or tbSenha.Text = Nothing Then
                        MetroFramework.MetroMessageBox.Show(Me, " Informe a senha do usuário ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tbSenha.Focus()
                    Else
                        Call rotinaAcesso() ' rotina de verificação de senha e conferência
                    End If
                End If
            End If
        End If
    End Sub

    'Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
    '    If lvdados.Text = Nothing Then
    '        MetroFramework.MetroMessageBox.Show(Me, " Informe o nome do usuário para a recuperação da senha. ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Else
    '        If iUsu007 = Nothing Then
    '            MetroFramework.MetroMessageBox.Show(Me, " Usuário não têm email para recuperação da senha. Entre em contato com o desenvolvedor do sistema. ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Else
    '            ' aqui abre o formulário de recuperação da senha
    '            RecuperaSNH.ShowDialog()
    '        End If
    '    End If
    'End Sub
#End Region

#Region "SUPER SENHA CODIGO"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tempo += 1
        somar += 1
        C += 1
        If tempo = 60 Then
            tempo = 0
            tbSenha.Text = ""
            Call MontaSuperSenha()
        End If

        If C = 600 Then
            If iCli019 = 2 And lvdados.Text <> "SUPERSENHA" Then
                If Aviso03.Visible = False Then
                    Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath) ' RETORNA APLICAÇÃO PARA O DIRETÓRIO ONDE FICA A EXECUTÁVEL
                    abriform(Of Aviso03)()
                    C = 0
                End If
            End If
        End If

    End Sub
    Private Function geraSenha(valor As Integer) 'passar valor de 5 digitos
        'declaração de variáveis
        Dim A, B, C, D, E, S As Integer
        Dim teste As New TripleDESCryptoServiceProvider
        'guarda o valor inicial numa variável auxiliar
        Dim aux As Integer = valor
        'separa os valores
        A = valor / 10000 + Calc5
        valor = valor Mod 10000
        B = valor / 1000
        valor = valor Mod 1000
        C = valor / 100
        valor = valor Mod 100
        D = valor / 10
        valor = valor Mod 10
        E = valor
        'Calcula o Digito Verificador
        S = ((6 * A) + (5 * B) + (4 * C) + (3 * D) + (2 * E)) Mod 7
        'Novo valor
        valor = (aux + S) * 97.3
        'PARA CODIFICAR
        'Cria um objeto encoding para assegurar o encoding padrão para o texto fonte
        Dim Ue As New UnicodeEncoding()
        'Retorna um array de bytes baseado no texto fonte
        Dim ByteSourceText() As Byte = Ue.GetBytes(valor)
        'Instancia um objeto MD5
        Dim Md5 As New MD5CryptoServiceProvider()
        'Calcula o valor do hash para o texto
        Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
        'Converte o valor para o formato string e retorna
        Return Convert.ToBase64String(ByteHash)
    End Function

    Private Sub MontaSuperSenha()
        Timer1.Enabled = True
        iCodUser = "999"                        ' CÓDIGO DO USUÁRIO NO SISTEMA
        'iUsername = "SUPERSENHA"                ' NOME DE LOGIN DO USUÁRIO 
        Calc3 = Format(DateTime.Now(), "MM")
        Calc4 = Format(DateTime.Now(), "ddyyyy")
        Calc5 = (Calc3 + Calc4) + somar
        iSenha = geraSenha(Calc5).ToString.Substring(0, 6)
        iSenha = UCase(iSenha)
    End Sub
#End Region










End Class
























