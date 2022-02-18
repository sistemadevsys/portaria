Option Strict Off
Imports MySql.Data.MySqlClient
Imports System.Net.Dns
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.OleDb

Module Variaveis
    Public Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Public Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Public Declare Function CreateRoundRectRgn Lib "gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Public objDraw As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath
#Region "CONSTANTES"
    Public Data_hoje As DateTime = DateTime.Now                 ' DATA ATUAL DO SISTEMA
    Public sistema As String = "GSportaria"                         ' NOME PADRÃO DO SISTEMA  S = SOLUTION HOTEL
    Public legenda As String = sistema                          ' VARIAVELS QUE APARECE NAS MENSAGENS DE ADVERTENCIA DO SISTEMA
    Public versao As String = "1.1.0"                           ' VERSÃO - PROVISÓSRIO PODE SER IMPLEMENTADO NO ASSEMBY INFORMATION (Cria código)
    Public datasis As String = "01/10/2020"                     ' DATA DA ULTIMA ATUALIZAÇÃO, DEVERÁ APARECER NA TELA PRINCIPAL E FIXADO NO BANCO DE DADOS    

    Public Copyright_nome As String                             ' REGISTRO DA MARCA  
    Public conta As Integer                                     ' VARIAVEL QUE CONTA QUANTAS VEZES O USUÁRIO TENTOU ACESSO AO SISTEMA
    Public formularioAtual As System.Windows.Forms.Form         ' FORMULÁRIO VIRTUAL QUE ASSUME O SISTEMA APÓS A DIGITAÇÃO DA SENHA 
    Public frmAtual As New Form                                 ' O MESMO PROCESSO ACIMA 
    Public nomehost As String                                   ' NOME DA ESTAÇÃO DE TRABALHO
    Public formulario As String                                 ' VARIAVEL QUE IDENTIFICA EM QUAL FORMULÁRIO O USUÁRIO ESTÁ PARA HABILITAR A MUDANÇA DE SENHA
    Public VerConexao As Integer = 0                           ' VERIFICA A CONEXÃO DA ESTAÇÃO NO SERVIDOR 
    Public IDTerminal As Integer                               ' ID DE IDENTIFICAÇÃO DO TERMINAL 
    Public alterado As Integer                                 ' CONTROLE DOS FORMULÁRIOS QUANDO FOR ALTERADO
    Public monitor As Integer                                  ' MONITORA O LIVRO DE OCORRENCIA COM DIAPARO A CADA 5 MINUTOS
    Public monitor_movim As Integer                            ' MONITOR DO MOVIMENTO DE EMPREGADOS/VISITANTES E SERVIÇOS  
    Public iGAR003 As String                                    ' REFERENCIA DO LOCAL DA GARAGEM
    Public iGAR005 As Integer                                   ' REFERENCIA O STATUS DA GARAGEM
    Public gatilho As Integer                                  ' GATILHO QUE FAZ A LIBERAÇÃO DA CASA / GARAGEM OU COMO QUISER 
    Public iGatilho As Integer                                 ' GATILHO QUE FAS A LIBERAÇÃO DA CASA QUANDO EM MÓDULO DE VISUALIZAÇÃO DE CASAS 
    Public ixGar011 As Integer                                 ' CONTROLE PARA LIBERAÇÃO DA GARAGEM  
    Public iCON02 As String                                    ' PARA LIBERAÇÃO DO REGISTRO DE ACOMPANHANTES NA TABELA PRT_ACPT
    Public OPC001 As Integer                                   ' USADO PARA OCUPAÇÃO DAS GARAGENS  
    Public FILTRO001 As Integer                                ' USADO PARA OCUPAÇÃO DAS GARAGENS
    Public disponivel As Integer                               ' NÚMERO DE VAGAS REMANESCENTES
    Public iFiltroARM As String                                ' FILTRO DE CONTROLE DOS ARMÁRIOS
#End Region

#Region "VARIAVEIS DE ACESSO AO SISTEMA"
    Public iCodUser As Integer          ' CODIGO DO USUÁRIO
    Public iUsu007 As String            ' EMAIL DO USUÁRIO
    Public iUsername As String          ' USUÁRIO LOGADO
    Public iSenha As String             ' VARIAVEL PARA TESTE DA SENHA
    Public iMail As String              ' EMAIL PARA RECUPERAÇÃO DA SENHA
    Public ConverteSenha As String      ' CONVERTE SENHA PARA VERIFICAR SENHA CADASTRADA
    Public recSenha As String           ' RECUPERAÇÃO DE SENHA  
#End Region

#Region "Variaveis empresa"
    Public iReg001 As String     ' CÓDIGO DE 6 DIGITOS PARA PESQUISA DA EMPRESA
    Public iReg002 As String     ' Nome da Empresa Registro do Software    
    Public iReg003 As String     ' Endereço                                 
    Public iReg004 As String     ' Bairro                                   
    Public iReg005 As String     ' Cidade                                   
    Public iReg006 As String     ' Estado                                  
    Public iReg007 As String     ' CEP                                     
    Public iReg008 As String     ' Complemento                             
    Public iReg009 As String     ' CNPJ                                    
    Public iReg010 As String     ' Inscrição Estadual                      
    Public iReg011 As String     ' Telefone 01                             
    Public iReg012 As String     ' Telefone 02                             
    Public iReg013 As Date       ' Data da Ultima verificação da licença do sistema
    Public iReg014 As String     ' email de contato ou outros   
    Public iReg015 As Image      ' Logo da empresa                         
    Public iReg016 As String     ' nome fantasia da empresa    
    Public ireg017 As String     ' Versão atual do sistema
    Public iReg018 As String     ' Nome do sistema
    Public iReg019 As String     ' Data do sistema
    Public iReg020 As Integer    ' Responsavel por liberar o sistema quando não tem acesso pela internet
    Public iCli019 As String     ' Variavel que verifica a tabela clientes - 0 = liberado // 1 = Bloqueado 
    Public imgResult As Integer  ' Variavel de controle das fotos seirão para o perfil ou arquivo
    '--------------------------------------------------------------------------------------------------------------------------

#End Region

#Region "FUNÇÕES"

    Public Function geraHash(ByVal valor As String) As String
        'Crria um objeto encoding para assegurar o encoding padrão para o texto fonte
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

    Public Function LeArquivoINI(ByVal file_name As String, ByVal section_name As String, ByVal key_name As String, ByVal default_value As String) As String
        ' FUNÇÃO QUE FAZ A LEITURA DO ARQUIVO INI
        Const MAX_LENGTH As Integer = 500
        Dim string_builder As New StringBuilder(MAX_LENGTH)
        GetPrivateProfileString(section_name, key_name, default_value, string_builder, MAX_LENGTH, file_name)
        Return string_builder.ToString()
    End Function

    Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890/*-+.,.", Chr(Keyascii)) = 0 Then
            SoNumeros = 0
        Else
            SoNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoNumeros = Keyascii
            Case 13
                SoNumeros = Keyascii
            Case 32
                SoNumeros = Keyascii
        End Select
    End Function
    Function Letras(ByVal Keyascii As Short) As Short
        If InStr("QWERTYUIOPÃÕÊÀÉáÁóÓ´`ASDFGHJKLÇ^~\ZXCVBNM,.;:?!@#$%&qwertyuiopasdfghjklçzxcvbnmãõêàáé+-*/()[]{}_1234567890", Chr(Keyascii)) = 0 Then
            Letras = 0
        Else
            Letras = Keyascii
        End If
        Select Case Keyascii
            Case 8
                Letras = Keyascii
            Case 13
                Letras = Keyascii
            Case 32
                Letras = Keyascii
        End Select
    End Function

    Function soLetras(ByVal Keyascii As Short) As Short
        If InStr("QWERTYUIOPÃÕÊÀÉáÁóÓ´`ASDFGHJKLÇ^~\ZXCVBNM,.;:?!@#$%&qwertyuiopasdfghjklçzxcvbnmãõêàáé+-*/()[]{}", Chr(Keyascii)) = 0 Then
            soLetras = 0
        Else
            soLetras = Keyascii
        End If
        Select Case Keyascii
            Case 8
                soLetras = Keyascii
            Case 13
                soLetras = Keyascii
            Case 32
                soLetras = Keyascii
        End Select
    End Function
#End Region


End Module
