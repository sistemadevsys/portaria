Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing
Public Class frmRel004
    Dim cdataini, cdatafim As Date
    Dim Data_hoje As DateTime = DateTime.Now
    Dim ordena As String = 1
    Dim filtro As String = 1
    Dim iCadp017, iCadp019 As String
    Dim sql As String
    Private paginaAtual As Integer = 1
    Dim texto, texto2, texto3, largura, posicao, posemp, poscgc As Integer
    Dim titulo As String = ""
    Dim arg1, arg2, arg3, arg4, arg5, arg6, arg7 As String
    Dim periodo As String
    Private Leitor As MySqlDataReader
    Private Sub frmRel004_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
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

    Private Sub frmRel004_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CancelButton = btnClose
        img.Image = iReg015
        rb1.Checked = True
        opc1.Checked = True
        opc5.Checked = True
        Gb1.Enabled = True
        gb2.Enabled = False
        CADP002.Visible = False
        CADP003.Visible = False
        ordena = 1
        filtro = 1
    End Sub
    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Relatorio_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Relatorio.BeginPrint
        conexao.Open()
        Select Case ordena
            Case 1
                Me.Text = "Relação de proprietários e dados de cadastro"
                If filtro = 1 Then
                    ' TODOS
                    sql = "SELECT * FROM PRT_CADPRO ORDER BY CADP002 "
                ElseIf filtro = 2 Then
                    ' PROPRIETARIOS
                    sql = "SELECT * FROM PRT_CADPRO WHERE CADP019 = 0 ORDER BY CADP002"
                ElseIf filtro = 3 Then
                    ' POOLISTAS
                    sql = "SELECT * FROM PRT_CADPRO WHERE CADP019 = 1 ORDER BY CADP002"
                ElseIf filtro = 4 Then
                    ' SUBSIDIARIOS
                    sql = "SELECT * FROM PRT_CADPRO WHERE CADP019 = 2 ORDER BY CADP002"
                End If
            Case 2
                Me.Text = "Relação de proprietários e dados de cadastro"
                If filtro = 5 Then
                    ' TODOS
                    sql = "SELECT * FROM PRT_CADPRO ORDER BY CADP002"
                ElseIf filtro = 6 Then
                    ' PROPRIETARIOS
                    sql = "SELECT * FROM PRT_CADPRO WHERE CADP019 = 0 ORDER BY CADP002"
                ElseIf filtro = 7 Then
                    ' POOLISTAS
                    sql = "SELECT * FROM PRT_CADPRO WHERE CADP019 = 1 ORDER BY CADP002"
                ElseIf filtro = 8 Then
                    ' SUBSIDIARIOS
                    sql = "SELECT * FROM PRT_CADPRO WHERE CADP019 = 2 ORDER BY CADP002"
                End If
            Case 3
                Me.Text = "Atualização de endereço"
                sql = "SELECT * FROM PRT_CADPRO WHERE CADP002 = '" & CADP002.Text & "' order by CADP002"
        End Select
        Dim cmd As MySqlCommand = New MySqlCommand(sql, conexao)
        Leitor = cmd.ExecuteReader
        paginaAtual = 1
    End Sub
    Private Sub Relatorio_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Relatorio.EndPrint
        Leitor.Close()
        conexao.Close()
    End Sub
    Private Sub visualizar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles visualizar.Load
        visualizar.Text = Me.Text
        With visualizar
            .WindowState = FormWindowState.Maximized
            .PrintPreviewControl.Zoom = 1 ' limitação da impressão
        End With
    End Sub

    Private Sub Relatorio_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Relatorio.PrintPage
        Dim MargemDireita As Single = e.MarginBounds.Right + 30 ' 70
        Dim MargemEsquerda As Single = e.MarginBounds.Left - 90 ' 65
        Dim MargemSuperior As Single = e.MarginBounds.Top + 100
        Dim MargemInferior As Single = e.MarginBounds.Bottom
        Dim CanetaDaImpressora As Pen = New Pen(Color.Black, 0)
        Dim FonteNegrito As Font
        Dim FonteTitulo As Font
        Dim FonteSubTitulo As Font
        Dim FonteRodape As Font
        Dim FonteNormal As Font
        Dim FonteBody As Font
        Dim fonteBodyN As Font
        Dim FonteMini As Font
        Dim FonteMiniN As Font
        Dim FonteSMini As Font
        Dim L As Integer = 0
        Dim LinhasPorPagina As Single = 0
        Dim PosicaoDaLinha As Single = 100
        Dim LinhaAtual As Integer = 0
        'define efeitos em fontes
        FonteNegrito = New Font("Arial", 8, FontStyle.Bold)
        FonteTitulo = New Font("Arial", 10, FontStyle.Bold)
        FonteSubTitulo = New Font("Arial", 10, FontStyle.Bold)
        FonteRodape = New Font("Arial Narrow", 9)
        FonteNormal = New Font("Arial", 8)
        FonteBody = New Font("Arial", 9)
        fonteBodyN = New Font("Arial", 9, FontStyle.Bold)
        FonteMini = New Font("Arial", 8)
        FonteMiniN = New Font("Arial", 8, FontStyle.Bold)
        FonteSMini = New Font("Arial", 7)
        largura = 850
        texto = titulo.Length * 10
        texto2 = Trim(iReg002).Length * 10
        texto3 = iReg009.Length * 10
        posicao = largura - texto
        posicao = posicao / 2
        posemp = largura - texto2 + 90
        posemp = posemp / 2
        poscgc = largura - texto3 - 50
        poscgc = poscgc / 2

        'e.Graphics.DrawImage(Image.FromFile("\phoenix\arquivos\logomarca\logo.jpg"), 20, 5) ' LOGO DA EMPRESA

        e.Graphics.DrawImage(img.Image, MargemEsquerda + 10, 15, 70, 70) ' impressão do logo da empresa

        e.Graphics.DrawString(titulo, FonteSubTitulo, Brushes.Blue, posicao, 15, New StringFormat()) ' TITULO
        e.Graphics.DrawString(Trim(iReg002), FonteNegrito, Brushes.Blue, posemp, 35, New StringFormat()) ' NOME DA EMPRESA
        e.Graphics.DrawString("CNPJ/MF:  " & iReg009, FonteNegrito, Brushes.Red, poscgc, 50, New StringFormat()) ' CNPJ DA EMPRESA
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 85, MargemDireita, 85) ' LINHA
        Dim linhas As Integer
        If ordena = 1 Then
            LinhaAtual = -7
            LinhasPorPagina = CInt(e.MarginBounds.Height / FonteBody.GetHeight(e.Graphics) - 15)
            While (LinhaAtual < LinhasPorPagina AndAlso Leitor.Read())
                PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteBody.GetHeight(e.Graphics))
                iCadp017 = Leitor.Item("CADP017") ' e-mail
                Dim lines As Integer
                Dim strString As String
                Dim myArray() As String
                strString = iCadp017
                myArray = Split(strString, vbCrLf)
                lines = myArray.Length
                linhas = lines
                e.Graphics.DrawString("Unidade:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat()) ' Unidade
                e.Graphics.DrawString(Leitor.Item("CADP002").ToString, FonteNegrito, Brushes.Black, MargemEsquerda + 70, PosicaoDaLinha, New StringFormat()) ' unidade
                e.Graphics.DrawString(" - ".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 115, PosicaoDaLinha, New StringFormat()) ' Nome
                e.Graphics.DrawString(Leitor.Item("CADP003").ToString, FonteNegrito, Brushes.Black, MargemEsquerda + 135, PosicaoDaLinha, New StringFormat()) ' Nome

                'e.Graphics.DrawString("Tipo:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 600, PosicaoDaLinha, New StringFormat()) ' Tipo
                'e.Graphics.DrawString(Leitor.Item("CP120").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 640, PosicaoDaLinha, New StringFormat()) ' Nome

                PosicaoDaLinha = PosicaoDaLinha + 14.5 ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("Conjuge:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat()) ' Conjuge
                e.Graphics.DrawString(Leitor.Item("CADP004").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 135, PosicaoDaLinha, New StringFormat()) ' unidade
                PosicaoDaLinha = PosicaoDaLinha + 20.5 ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("Endereço:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat()) ' Endereço
                e.Graphics.DrawString(Leitor.Item("CADP005").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 135, PosicaoDaLinha, New StringFormat()) ' Endereço
                e.Graphics.DrawString("Bairro:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 600, PosicaoDaLinha, New StringFormat()) ' Bairro
                e.Graphics.DrawString(Leitor.Item("CADP006").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 640, PosicaoDaLinha, New StringFormat()) ' Bairro
                PosicaoDaLinha = PosicaoDaLinha + 14.5 ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("Cidade:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat()) ' Cidade
                e.Graphics.DrawString(Leitor.Item("CADP007").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 135, PosicaoDaLinha, New StringFormat()) ' Cidade
                e.Graphics.DrawString("Estado:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 450, PosicaoDaLinha, New StringFormat()) ' Cidade
                e.Graphics.DrawString(Leitor.Item("CADP008").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 490, PosicaoDaLinha, New StringFormat()) ' Cidade
                e.Graphics.DrawString("CEP:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 600, PosicaoDaLinha, New StringFormat()) ' Cidade
                e.Graphics.DrawString(Leitor.Item("CADP009").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 640, PosicaoDaLinha, New StringFormat()) ' Cidade
                PosicaoDaLinha = PosicaoDaLinha + 14.5 ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("Complemento:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat()) ' Complemento
                e.Graphics.DrawString(Leitor.Item("CADP010").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 135, PosicaoDaLinha, New StringFormat()) ' Complemento
                PosicaoDaLinha = PosicaoDaLinha + 14.5 ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("Telefone:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat()) ' Telefone de contato
                e.Graphics.DrawString(Leitor.Item("CADP013").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 135, PosicaoDaLinha, New StringFormat()) ' Telefone de contato
                e.Graphics.DrawString(Leitor.Item("CADP014").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 235, PosicaoDaLinha, New StringFormat()) ' Telefone de contato
                e.Graphics.DrawString(Leitor.Item("CADP015").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 335, PosicaoDaLinha, New StringFormat()) ' Telefone de contato
                e.Graphics.DrawString(Leitor.Item("CADP016").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 445, PosicaoDaLinha, New StringFormat()) ' Telefone de contato
                PosicaoDaLinha = PosicaoDaLinha + 15.5 ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("E-mail:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat()) ' E-mail
                e.Graphics.DrawString(Leitor.Item("CADP017").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 135, PosicaoDaLinha, New StringFormat()) ' Telefone de contato
                LinhaAtual += 7 + linhas
                PosicaoDaLinha = PosicaoDaLinha + 15.5 * linhas ' envia a impressão para a linha seguinte
                e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, PosicaoDaLinha, MargemDireita, PosicaoDaLinha) ' LINHA
            End While
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
            e.Graphics.DrawString("Data de emissão:  " & System.DateTime.Now.ToString() & "                                         " & legenda & " Versão: " & versao, FonteMini, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
            e.Graphics.DrawString("Página: " & paginaAtual, FonteMini, Brushes.Black, MargemEsquerda + 705, MargemInferior, New StringFormat())
            LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            LinhaAtual += 1
            'Incrementa o n£mero da pagina
            paginaAtual += 1
            If (LinhaAtual > LinhasPorPagina) Then
                e.HasMorePages = True
            End If
        ElseIf ordena = 2 Then
            LinhaAtual = -7
            LinhasPorPagina = CInt(e.MarginBounds.Height / FonteBody.GetHeight(e.Graphics) - 8)
            While (LinhaAtual < LinhasPorPagina AndAlso Leitor.Read())
                PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteBody.GetHeight(e.Graphics))
                e.Graphics.DrawString("Unidade:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat()) ' Unidade
                e.Graphics.DrawString(Leitor.Item("CADP002").ToString, FonteNegrito, Brushes.Black, MargemEsquerda + 70, PosicaoDaLinha, New StringFormat()) ' unidade
                e.Graphics.DrawString(" - ".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 115, PosicaoDaLinha, New StringFormat()) ' Nome
                e.Graphics.DrawString(Leitor.Item("CADP003").ToString, FonteNegrito, Brushes.Black, MargemEsquerda + 135, PosicaoDaLinha, New StringFormat()) ' Nome

                'e.Graphics.DrawString("Tipo:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 600, PosicaoDaLinha, New StringFormat()) ' Tipo
                'e.Graphics.DrawString(Leitor.Item("CP120").ToString, FonteNegrito, Brushes.Black, MargemEsquerda + 640, PosicaoDaLinha, New StringFormat()) ' Nome

                PosicaoDaLinha = PosicaoDaLinha + 14.5 ' envia a impressão para a linha seguinte
                LinhaAtual += 1
                e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, PosicaoDaLinha, MargemDireita, PosicaoDaLinha) ' LINHA
            End While
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
            e.Graphics.DrawString("Data de emissão:  " & System.DateTime.Now.ToString() & "                                         " & legenda & " Versão: " & versao, FonteMini, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
            e.Graphics.DrawString("Página: " & paginaAtual, FonteMini, Brushes.Black, MargemEsquerda + 705, MargemInferior, New StringFormat())
            LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            LinhaAtual += 1
            'Incrementa o n£mero da pagina
            paginaAtual += 1
            If (LinhaAtual > LinhasPorPagina) Then
                e.HasMorePages = True
            End If
        ElseIf ordena = 3 Then
            LinhaAtual = -7
            LinhasPorPagina = CInt(e.MarginBounds.Height / FonteBody.GetHeight(e.Graphics) - 15)
            While (LinhaAtual < LinhasPorPagina AndAlso Leitor.Read())
                PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteBody.GetHeight(e.Graphics))
                iCadp017 = Leitor.Item("CADP017") ' e-mail
                Dim lines As Integer
                Dim strString As String
                Dim myArray() As String
                strString = iCadp017
                myArray = Split(strString, vbCrLf)
                lines = myArray.Length
                linhas = lines
                e.Graphics.DrawString("Unidade:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat()) ' Unidade
                e.Graphics.DrawString(Leitor.Item("CADP002").ToString, FonteNegrito, Brushes.Black, MargemEsquerda + 70, PosicaoDaLinha, New StringFormat()) ' unidade
                e.Graphics.DrawString(" - ".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 115, PosicaoDaLinha, New StringFormat()) ' Nome
                e.Graphics.DrawString(Leitor.Item("CADP003").ToString, FonteNegrito, Brushes.Black, MargemEsquerda + 135, PosicaoDaLinha, New StringFormat()) ' Nome

                'e.Graphics.DrawString("Tipo:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 600, PosicaoDaLinha, New StringFormat()) ' Tipo
                'e.Graphics.DrawString(Leitor.Item("CP120").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 640, PosicaoDaLinha, New StringFormat()) ' Nome

                PosicaoDaLinha = PosicaoDaLinha + 14.5 ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("Conjuge:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat()) ' Conjuge
                e.Graphics.DrawString(Leitor.Item("CADP004").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 135, PosicaoDaLinha, New StringFormat()) ' unidade
                PosicaoDaLinha = PosicaoDaLinha + 20.5 ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("Endereço:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat()) ' Endereço
                e.Graphics.DrawString(Leitor.Item("CADP005").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 135, PosicaoDaLinha, New StringFormat()) ' Endereço
                e.Graphics.DrawString("Bairro:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 600, PosicaoDaLinha, New StringFormat()) ' Bairro
                e.Graphics.DrawString(Leitor.Item("CADP006").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 640, PosicaoDaLinha, New StringFormat()) ' Bairro
                PosicaoDaLinha = PosicaoDaLinha + 14.5 ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("Cidade:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat()) ' Cidade
                e.Graphics.DrawString(Leitor.Item("CADP007").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 135, PosicaoDaLinha, New StringFormat()) ' Cidade
                e.Graphics.DrawString("Estado:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 450, PosicaoDaLinha, New StringFormat()) ' Cidade
                e.Graphics.DrawString(Leitor.Item("CADP008").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 490, PosicaoDaLinha, New StringFormat()) ' Cidade
                e.Graphics.DrawString("CEP:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 600, PosicaoDaLinha, New StringFormat()) ' Cidade
                e.Graphics.DrawString(Leitor.Item("CADP009").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 640, PosicaoDaLinha, New StringFormat()) ' Cidade
                PosicaoDaLinha = PosicaoDaLinha + 14.5 ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("Complemento:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat()) ' Complemento
                e.Graphics.DrawString(Leitor.Item("CADP010").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 135, PosicaoDaLinha, New StringFormat()) ' Complemento
                PosicaoDaLinha = PosicaoDaLinha + 14.5 ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("Telefone:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat()) ' Telefone de contato
                e.Graphics.DrawString(Leitor.Item("CADP013").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 135, PosicaoDaLinha, New StringFormat()) ' Telefone de contato
                e.Graphics.DrawString(Leitor.Item("CADP014").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 235, PosicaoDaLinha, New StringFormat()) ' Telefone de contato
                e.Graphics.DrawString(Leitor.Item("CADP015").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 335, PosicaoDaLinha, New StringFormat()) ' Telefone de contato
                e.Graphics.DrawString(Leitor.Item("CADP016").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 445, PosicaoDaLinha, New StringFormat()) ' Telefone de contato
                PosicaoDaLinha = PosicaoDaLinha + 15.5 ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("E-mail:".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat()) ' E-mail
                e.Graphics.DrawString(Leitor.Item("CADP017").ToString, FonteNormal, Brushes.Black, MargemEsquerda + 135, PosicaoDaLinha, New StringFormat()) ' Telefone de contato
                LinhaAtual += 7 + linhas
                PosicaoDaLinha = PosicaoDaLinha + 15.5 * linhas ' envia a impressão para a linha seguinte
                e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, PosicaoDaLinha, MargemDireita, PosicaoDaLinha) ' LINHA

                PosicaoDaLinha = PosicaoDaLinha + 40.5  ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("Endereço: ____________________________________________________________________   Bairro: _________________________________________________".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat())
                PosicaoDaLinha = PosicaoDaLinha + 40.5  ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("Cidade: ____________________________________________________ Estado _________ CEP ________-______".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat())
                PosicaoDaLinha = PosicaoDaLinha + 40.5  ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("Complemento: ________________________________________________________________________________________________________________________".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat())
                PosicaoDaLinha = PosicaoDaLinha + 40.5  ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("Telefones: (______)__________-__________     (______)__________-__________     (______)__________-__________     (______)__________-__________".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat())
                PosicaoDaLinha = PosicaoDaLinha + 40.5  ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("E-mail: ___________________________________________________________________________________________".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat())
                PosicaoDaLinha = PosicaoDaLinha + 40.5  ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("E-mail: ___________________________________________________________________________________________".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat())
                PosicaoDaLinha = PosicaoDaLinha + 40.5  ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("E-mail: ___________________________________________________________________________________________".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat())
                PosicaoDaLinha = PosicaoDaLinha + 40.5  ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("E-mail: ___________________________________________________________________________________________".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat())
                PosicaoDaLinha = PosicaoDaLinha + 40.5  ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("E-mail: ___________________________________________________________________________________________".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat())
                PosicaoDaLinha = PosicaoDaLinha + 40.5  ' envia a impressão para a linha seguinte
                e.Graphics.DrawString("E-mail: ___________________________________________________________________________________________".ToString, FonteSMini, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat())
            End While
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
            e.Graphics.DrawString("Data de emissão:  " & System.DateTime.Now.ToString() & "                                         " & legenda & " Versão: " & versao, FonteMini, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
            e.Graphics.DrawString("Página: " & paginaAtual, FonteMini, Brushes.Black, MargemEsquerda + 705, MargemInferior, New StringFormat())
            LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
            LinhaAtual += 1
            'Incrementa o n£mero da pagina
            paginaAtual += 1
            If (LinhaAtual > LinhasPorPagina) Then
                e.HasMorePages = True
            End If
        End If
    End Sub
    Private Sub rb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb1.CheckedChanged
        ordena = 1
        filtro = 1
        Gb1.Enabled = True
        gb2.Enabled = False
        CADP002.Visible = False
        CADP003.Visible = False
    End Sub
    Private Sub rb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb2.CheckedChanged
        ordena = 2
        filtro = 5
        Gb1.Enabled = False
        gb2.Enabled = True
        CADP002.Visible = False
        CADP003.Visible = False
    End Sub
    Private Sub rb3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb3.CheckedChanged
        'CADP002.Text = frmCadProp.CADP002.Text.ToString
        'CADP003.Text = frmCadProp.CADP003.Text.ToString
        ordena = 3
        Gb1.Enabled = False
        gb2.Enabled = False
        CADP002.Visible = True
        CADP003.Visible = True
    End Sub
    Private Sub opc1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opc1.CheckedChanged
        filtro = 1
    End Sub
    Private Sub opc2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opc2.CheckedChanged
        filtro = 2
    End Sub
    Private Sub opc3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opc3.CheckedChanged
        filtro = 3
    End Sub
    Private Sub opc4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opc4.CheckedChanged
        filtro = 4
    End Sub
    Private Sub opc5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opc5.CheckedChanged
        filtro = 5
    End Sub
    Private Sub opc6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opc6.CheckedChanged
        filtro = 6
    End Sub
    Private Sub opc7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opc7.CheckedChanged
        filtro = 7
    End Sub
    Private Sub opc8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opc8.CheckedChanged
        filtro = 8
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dispose()
        Me.Close()
    End Sub


    Private Sub btnPrinter_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If rb1.Checked = True Then
            titulo = "RELAÇÃO DE PROPRIETÁRIOS COM DADOS DO CADASTRO"
        ElseIf rb2.Checked = True Then
            titulo = "RELAÇÃO DE PROPRIETÁRIOS GERAL - SIMPLES"
        ElseIf rb3.Checked = True Then
            titulo = "**** FICHA DE ATUALIZAÇÃO CADASTRAL ****"
        End If
        visualizar.Document = Relatorio
        visualizar.ShowDialog()
    End Sub
End Class