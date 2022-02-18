Imports MySql.Data.MySqlClient
Imports System.Net.Dns
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.OleDb
Module MySql

#Region "Conexão com banco de dados principal"
    ' VARIAVEIS PUBLICAS PARA CONEXÃO AO BANCO DE DADOS DE TRABALHO = sol_hotel
    ' ESSAS VARIAVEIS SERÃO CARREGADAS DE UM ARQUIVO CHAMADO (conexaoini) NO INICIO DO PROCESSO DE ACESSO AO SISTEMA LOGIN
    Public conexao As New MySqlConnection       ' STRING DE CONEXÃO SIMPLES
    Public iDatabase As String                  ' NOME DA BASE DE DADOS MySQL POR PADRÃO = sol_hotel         
    Public iPesquisa As String                  ' ENDEREÇO DE PASTA ONDE IRA PESQUISA NA MÁQUINA LOCAL ARQUIVOS INI E OUTROS
    Public iservidor As String                  ' ENDEREÇO DO SERVIOR MySQL    
    Public iPort As String                      ' PORTA DE ACESSO AO SERVIDOR    
    Public iTerminal As String                  ' TERMINAL REGISTRADO JUNTO COM A PLACA E REDE QUE HABILITA A ESTAÇÃO DE TRABALHO 
    Public iUserMysql As String = "root"        ' USUÁRIO DO BANCO MYSQL ( Deverá sempre ficar neste módulo e nunca no banco de dados)
    Public iSenhaMysql As String = "SolCtrl2019!"   ' SENHA DO BANCO MYSQL   ( deverá ficar sempre neste módulo e nunca no vabco de dados)

    Public Migra As New OleDbConnection           ' conexão para acesso ao banco acess
    Public iMigra As New MySqlConnection          ' STRING DE CONEXÃO SIMPLES
#End Region

#Region "Conexão Banco de dados de Autenticação - LOCAWEB"
    ' VARIAVEIS PARA CONEXÃO COM O BANCO DE DADOS DE AUTENTICAÇÃO
    ' EM AMBIENTE DE DESENVOLVIMENTO O SISTEMA FAZ AUTENTICAÇÃO NO SERVIDOR LOCAL
    ' APÓS DISTRIBUIÇÃO O SISTEMA FAZ AUTENTICAÇÃO NA NUVEM - LOCAWEB OU OUTRO SERVIDOR
    Public iconexao As New MySqlConnection            ' STRING DE CONEXÃO SIMPLES
    Public xDatabase As String                        ' NOME DA BASE DE DADOS MySQL POR PADRÃO = sol_hotel         
    Public xServidor As String                        ' ENDEREÇO DO SERVIOR MySQL    
    Public xPort As String                            ' PORTA DE ACESSO AO SERVIDOR    
    Public xUserMysql As String                       ' USUÁRIO DO BANCO DE DADOS PARA AUTENTICAÇÃO DO CLIENTE NA NUVEM
    Public xSenhaMysql As String                      ' senha do banco de dados 
    Public iNomeHost As String                        ' NOME DO TERMINAL PARA O FORMULÁRIO DE CONFOGURAÇÃO DO BANCO DE DADOS
    Public icodigo As String                          ' CÓDIGO ID QUE IRÁ LOCALIZAR O REGISTRO DA CONEXAO
    Public senha_cloud As String = "kXbm9.h$cU@95"

#End Region

#Region "FUNÇÕES"

    Public Class ObtemIP
        Shared Function ObtemEnderecoIP() As String
            Dim oEndereco As System.Net.IPAddress
            Dim sEndereco As String
            With GetHostByName(GetHostName)
                oEndereco = New System.Net.IPAddress(.AddressList(0).Address)
                sEndereco = oEndereco.ToString
            End With
            ObtemEnderecoIP = sEndereco
            nomehost = GetHostName()

        End Function
    End Class
#End Region







End Module
