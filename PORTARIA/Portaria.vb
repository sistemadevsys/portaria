Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class Portaria
    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Protected regionHandle As IntPtr

    Dim GAR002, iGAR002, GAR003, GAR005, GAR007, GAR001, FUN003, IMG006 As New TextBox
    Dim occ005 As New TextBox
    Dim frmPanel As Panel
    Dim formulario As Form
    Dim pop As Integer
    Dim filtrogar As Integer
    Dim sql As String
    Dim idGAR005, idGAR008, desGar005, acao As String

    Dim index As Integer
    Dim retorno As String = Nothing
    Dim inicio, fim As DateTime
    Dim hoje As DateTime = DateTime.Now
    Dim tempo As New TextBox
    Dim FAS001 As New TextBox

    Dim contagem As Integer


#Region "START DO FORMULÁRIO"
    Private Sub BEEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Portaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        monitor_movim = 0

        start_load(0) ' INICIA TODOS OS COMPONENTES
        start_load(1) ' INICIA A GUIA DE EMPREGADOS
        If monitor < 900 Then ' o MONITOR FOR MENOR QUE 15 MINUTOS ZERA A CONTAGEM DE TEMPO
            monitor = 0
        End If


        'Timer_Movim.Stop()
        'contagem = 0
        'Pendencias.ShowDialog()
        'Timer_Movim.Start()


    End Sub
#End Region

#Region "FUNÇÕES"
    Private Sub abriform(Of miform As {Form, New})()
        formulario = frmPanel.Controls.OfType(Of miform)().FirstOrDefault
        If formulario Is Nothing Then
            Try
                formulario = New miform
                formulario.TopLevel = False
                formulario.FormBorderStyle = FormBorderStyle.None
                formulario.Dock = DockStyle.Fill
                frmPanel.Controls.Add(formulario)
                frmPanel.Tag = formulario
                formulario.Show()
                formulario.BringToFront()
            Catch ex As Exception

            End Try
        Else
            formulario.BringToFront()
        End If
    End Sub
    Private Sub start_load(arg)
        Select Case arg
            Case 0
                If monitor < 900 Then ' o MONITOR FOR MENOR QUE 15 MINUTOS ZERA A CONTAGEM DE TEMPO
                    monitor = 0
                End If
                filtrogar = 0
                Call CarregaList()
                If pop > 0 Then
                    Me.lvDados.Items(0).Selected = True
                    lvDados.Select()
                End If
            Case 1
                frmPanel = Panel4
                abriform(Of Movim01)() ' ABRE O FORMULÁRIO DENTRO DO PAINEL
            Case 2

        End Select
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
    Private Sub redondo(arg1, arg2, componente, arg3, arg4)
        regionHandle = New IntPtr(CreateRoundRectRgn(arg1, arg2, componente.Width, componente.Height, arg3, arg4))
        componente.Region = Region.FromHrgn(regionHandle)
        componente.Region.ReleaseHrgn(regionHandle)
    End Sub


    Private Sub filtro()
        Select Case filtrogar
            Case 0
                ' TODOS OS REGISTROS DO GRID DE VAGAS NAS GARAGENS
                sql = "SELECT GAR001,GAR002,GAR003,GAR005,GAR006-GAR011 as TOTAL,GAR011,GAR007,OPC,FILTRO FROM PRT_GARAGENS ORDER BY GAR002"
            Case 1
                sql = "SELECT GAR001,GAR002,GAR003,GAR005,GAR006-GAR011 as TOTAL,GAR011,GAR007,OPC,FILTRO FROM PRT_GARAGENS WHERE GAR005 = '" & iGAR005 & "' ORDER BY GAR002"
            Case 2
                sql = "SELECT GAR001,GAR002,GAR003,GAR005,GAR006-GAR011 as TOTAL,GAR011,GAR007,OPC,FILTRO FROM PRT_GARAGENS WHERE GAR005 = '" & iGAR005 & "' AND GAR003 = '" & iGAR003 & "' ORDER BY GAR002"
        End Select
    End Sub
    Private Sub corList(arg)
        Select Case arg
            Case 0
                For i As Integer = 0 To lvDados.Items.Count - 1
                    lvDados.Items(i).UseItemStyleForSubItems = False
                    If lvDados.Items(i).SubItems.Count > 1 Then
                        If lvDados.Items(i).SubItems(2).Text.ToString = "LIVRE" Then
                            If lvDados.Items(i).SubItems(0).Text.ToString.Substring(0, 2) = "SC" Then
                                lvDados.Items(i).ImageIndex = 22
                            Else
                                Select Case lvDados.Items(i).SubItems(4).Text.ToString
                                    Case 1
                                        lvDados.Items(i).ImageIndex = 0
                                    Case 2
                                        lvDados.Items(i).ImageIndex = 1
                                    Case 3
                                        lvDados.Items(i).ImageIndex = 2
                                    Case 4
                                        lvDados.Items(i).ImageIndex = 3
                                    Case 5
                                        lvDados.Items(i).ImageIndex = 4
                                    Case 6
                                        lvDados.Items(i).ImageIndex = 5
                                    Case 7
                                        lvDados.Items(i).ImageIndex = 6
                                    Case 8
                                        lvDados.Items(i).ImageIndex = 7
                                    Case 9
                                        lvDados.Items(i).ImageIndex = 8
                                End Select
                            End If
                        ElseIf lvDados.Items(i).SubItems(2).Text.ToString = "OCUPADO" Then
                            If lvDados.Items(i).SubItems(0).Text.ToString.Substring(0, 2) = "SC" Then
                                lvDados.Items(i).ImageIndex = 23
                            Else
                                Select Case lvDados.Items(i).SubItems(4).Text.ToString
                                    Case 1
                                        lvDados.Items(i).ImageIndex = 9
                                    Case 2
                                        lvDados.Items(i).ImageIndex = 10
                                    Case 3
                                        lvDados.Items(i).ImageIndex = 11
                                    Case 4
                                        lvDados.Items(i).ImageIndex = 12
                                    Case 5
                                        lvDados.Items(i).ImageIndex = 13
                                    Case 6
                                        lvDados.Items(i).ImageIndex = 14
                                    Case 7
                                        lvDados.Items(i).ImageIndex = 15
                                    Case 8
                                        lvDados.Items(i).ImageIndex = 16
                                    Case 9
                                        lvDados.Items(i).ImageIndex = 17
                                    Case 0
                                        lvDados.Items(i).ImageIndex = 18
                                End Select
                            End If
                        ElseIf lvDados.Items(i).SubItems(2).Text.ToString = "BLOQUEADO" Then
                            lvDados.Items(i).ImageIndex = 19
                        ElseIf lvDados.Items(i).SubItems(2).Text.ToString = "RESERVADO" Then
                            lvDados.Items(i).ImageIndex = 20
                        ElseIf lvDados.Items(i).SubItems(2).Text.ToString = "MANUTENCAO" Then
                            lvDados.Items(i).ImageIndex = 21
                        End If
                    End If
                Next
        End Select
    End Sub




#End Region

#Region "LISTVIEW - DAS GARAGENS"
    Private Sub CarregaList()
        Call filtro() ' ACIONA O FILTRO PARA AS PESQUISAS E SELEÇÕES
        lvDados.Items.Clear()
        lvDados.GridLines = False
        lvDados.FullRowSelect = True
        lvDados.View = View.Details
        lvDados.Sorting = SortOrder.None
        lvDados.SmallImageList = ImageGrid
        conexao.Open()
        Dim cmd As MySqlCommand = New MySqlCommand(sql, conexao)
        Dim leitor As MySqlDataReader = cmd.ExecuteReader()
        Dim limpaCell As String = ""
        pop = 0   ' CONTROLA A QUANTIDADE DE REGISTROS NO GRID
        Do While leitor.Read()
            Dim item As New ListViewItem()
            item.Text = leitor(0)
            idGAR005 = leitor("GAR005") ' AQUI VERIFICA O STATUS DA GARAGEM (LIVRE/OCUPADO/BLOQUEADO ETC...)
            ' NOTE QUE O SELECT CASE É ATRIBUIDO CONFORME RETORNO DA TABELA
            'OU SEJA, 0 = LIVRE / 1 = OCUPADO ETC...

            'iGAR002.Text = leitor("GAR002").ToString.Substring(0, 2)

            Select Case idGAR005
                Case 0
                    desGar005 = "LIVRE"
                Case 1
                    desGar005 = "OCUPADO"
                Case 2
                    desGar005 = "BLOQUEADO"
                Case 3
                    desGar005 = "RESERVADO"
                Case 4
                    desGar005 = "MANUTENCAO"
            End Select

            item = lvDados.Items.Add(leitor("GAR002").ToString)                                     '0 IDENTIFICAÇÃO DA GARAGEM
            item.SubItems.Add(leitor("GAR003"))                                                     '1 LOCALIZAÇÃO DA GARAGEM
            item.SubItems.Add(desGar005)                                                            '2 STATUS DA GARAGEM
            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("GAR007")) = True, "", leitor("GAR007"))) '3 REGISTRO DO OCUPANTE
            item.SubItems.Add(leitor("TOTAL"))                                                      '4 QUANTIDADE DE VADAS
            item.SubItems.Add(leitor("GAR001"))                                                     '5 ID DA GARAGEM 
            item.SubItems.Add(leitor("OPC").ToString)                                               '6 ID DO REGISTRO NA TABELA PRT_CADPRO
            item.SubItems.Add(leitor("FILTRO").ToString)                                            '7 ID DO REGISTRO NA TABELA PRT_CADPRO
            item.SubItems.Add(leitor("GAR011").ToString)                                            '8 VAGAS UTILIZADAS

            pop += 1 ' faz a contagem dos registros no listview
        Loop
        conexao.Close() ' fecha a conexação com o banco de dados
        Call corList(0)


    End Sub

    Private Sub lvDados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDados.SelectedIndexChanged
        Try
            If lvDados.SelectedItems.Count > 0 Then
                index = lvDados.Items.Item(lvDados.SelectedIndices(0)).Index

                Me.GAR002.Text = Convert.ToString(lvDados.Items(lvDados.SelectedIndices(0)).Text)
                Me.GAR003.Text = Me.lvDados.SelectedItems(0).SubItems(1).Text
                Me.GAR005.Text = Me.lvDados.SelectedItems(0).SubItems(2).Text
                Me.GAR007.Text = Me.lvDados.SelectedItems(0).SubItems(3).Text
                disponivel = Me.lvDados.SelectedItems(0).SubItems(4).Text

                Me.GAR001.Text = Me.lvDados.SelectedItems(0).SubItems(5).Text
                OPC001 = Me.lvDados.SelectedItems(0).SubItems(6).Text
                FILTRO001 = Me.lvDados.SelectedItems(0).SubItems(7).Text

                If GAR005.Text = "OCUPADO" Then
                    gatilho = 0
                    frmPanel = Panel5
                    frmPanel.Controls.Clear() ' LIMPA OS DADOS DO FORMULÁRIODE AUTORIZADOS QUE VAI ABRIR DENTRO DO PAINEL

                    Repositorio.GAR002.Text = GAR002.Text
                    Repositorio.GAR003.Text = GAR003.Text
                    Repositorio.CADP002.Text = GAR007.Text

                    abriform(Of frmRegCasas)() ' ABRE O FORMULÁRIO DENTRO DO PAINEL

                    If pop > 0 Then
                        Me.lvDados.Items(index).Selected = True
                        lvDados.Select()
                    End If

                Else
                    Panel5.Controls.Clear()
                End If

            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub lvDados_DoubleClick(sender As Object, e As EventArgs) Handles lvDados.DoubleClick
        ' ABRE PROCESSO PARA REGISTRAR A ENTRADA DO PROPRIETÁRIO
        Call corList(5)
        alterado = 0

        If GAR005.Text = "LIVRE" Or GAR005.Text = "OCUPADO" Then
            If disponivel = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Indisponivel para registro. Número de vagas atingido! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If pop > 0 Then
                    Me.lvDados.Items(index).Selected = True
                    lvDados.Select()
                End If
            Else
                frmRegistra.GAR002.Text = GAR002.Text ' numero da casa ou garagem
                frmRegistra.GAR003.Text = GAR003.Text ' localização bloco alameda etc
                frmRegistra.GAR005.Text = GAR005.Text ' Status da garagem (LIVRE ETC...)
                frmRegistra.iRef.Text = GAR007.Text ' id DO OCUPANTE NUMERO DA CASA OU APARTAMENTO
                frmRegistra.ShowDialog()
                If alterado > 0 Then
                    ' INSTRAÇÃO DE RETORNO QUE PROCESSA O LISTVIEW - LVDADOS

                    Call CarregaList()
                    If pop > 0 Then
                        Me.lvDados.Items(index).Selected = True
                        lvDados.Select()
                    End If


                End If
            End If
        Else
            MetroFramework.MetroMessageBox.Show(Me, " Status de configuração não permite essa transação!  ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub






#End Region

#Region "BOTÕES INFERIOR"
    Private Sub btnTodos_Click_1(sender As Object, e As EventArgs) Handles btnTodos.Click
        Call corList(2)
        filtrogar = 0
        Call CarregaList()
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If
    End Sub
    Private Sub btnFiltro_Click_1(sender As Object, e As EventArgs) Handles btnFiltro.Click
        ' Filtro
        alterado = 0
        frmFiltro.ShowDialog()
        If alterado = 99 Then
            If frmFiltro.GAR003.Text = "Todos" Then
                filtrogar = 1
            Else
                filtrogar = 2
            End If
            Call CarregaList()
            If pop > 0 Then
                Me.lvDados.Items(0).Selected = True
                lvDados.Select()
            End If
        End If
    End Sub
    Private Sub btnAusentes_Click_1(sender As Object, e As EventArgs) Handles btnAusentes.Click
        ' ausente
        frmPanel = frmBase
        abriform(Of frmAusentes)() ' ABRE O FORMULÁRIO DENTRO DO PAINEL
    End Sub
    Private Sub btnOcupados_Click_1(sender As Object, e As EventArgs) Handles btnOcupados.Click
        frmPanel = frmBase
        abriform(Of frmListOc01)() ' ABRE O FORMULÁRIO DENTRO DO PAINEL
    End Sub
    Private Sub btnReservas_Click_1(sender As Object, e As EventArgs) Handles btnReservas.Click

    End Sub
    Private Sub btnAcesso_Click_1(sender As Object, e As EventArgs) Handles btnAcesso.Click
        frmPanel = frmBase
        abriform(Of frmControleA)() ' ABRE O FORMULÁRIO DENTRO DO PAINEL
    End Sub
    Private Sub btnChaves_Click_1(sender As Object, e As EventArgs) Handles btnChaves.Click

    End Sub



#End Region

#Region "COMPONENTES"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' CONFIGURA PARA CADA 1 HORA FAZER A LEITURA DO ARQUIVO QUE GUARDA O LIVRO DE OCORRÊNCIAS
        monitor += 1
        If monitor >= 3600 Then
            Call AbrePagina() ' VERIFICA SE EXISTE UMA PAGINA NOVA NO LIVRO DE OCORRENCIAS
            monitor = 0
        End If
    End Sub
    Private Sub TimeGatilho_Tick(sender As Object, e As EventArgs) Handles TimeGatilho.Tick
        If gatilho = 500 Then
            gatilho = 0
            Call CarregaList()
            If pop > 0 Then
                Me.lvDados.Items(index).Selected = True
                lvDados.Select()
            End If
        End If
    End Sub
    Private Sub Timer_Movim_Tick(sender As Object, e As EventArgs) Handles Timer_Movim.Tick
        'contagem += 1
        'If contagem >= 60 Then ' A CADA 1 MINUTO FAZ A LEITURA DE PENDENCIAS
        '    Timer_Movim.Stop()
        '    contagem = 0
        '    Pendencias.ShowDialog()
        '    Timer_Movim.Start()

        'End If


    End Sub
#End Region



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
























