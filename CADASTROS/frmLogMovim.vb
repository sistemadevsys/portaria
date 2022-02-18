Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmLogMovim
    Dim Data_hoje As DateTime = DateTime.Now
    Dim CADP001, iCADP001, iCADP002, xCADP002, CON01, CON02, CON17, CON006, iOrigem As New TextBox
    Dim dia As String
    Dim mes As String
    Dim ano As String
    Dim dataIni, dataFim As Date
    Dim sql, sqlLoc As String
    Dim pop, popAs, index, filtro As Integer
    Dim arl As ArrayList = New ArrayList


    Private Sub BEEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
    Private Sub frmLogMovim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filtro = 0 ' filtro inicial para a seleção do movimento
        iCADP001.Text = Repositorio.CADP001.Text ' GUARDA A BUSCA INICIAL
        CADP001.Text = Repositorio.CADP001.Text  ' FILTRA A BUSCA PELOS REGISTROS

        iCADP002.Text = Repositorio.iCADP002.Text ' numero da unidade para SELEÇÃO
        xCADP002.Text = Repositorio.iCADP002.Text
        CADP003.Text = Repositorio.CADP003.Text  ' NOME DO USUÁRIO REGISTRADO
        iOrigem.Text = Repositorio.iORIGEM.Text

        dia = "01"
        mes = "01"
        ano = Data_hoje.Year
        CON04.Value = dia & "/" & mes & "/" & ano
        CON11.Value = CON04.Value.AddDays(364)

        gVei.Visible = False
        gOcup.Visible = False

        dataIni = CON04.Value
        dataFim = CON11.Value

        If iOrigem.Text = "HOS" Then
            Button2.Visible = False
        Else
            Button2.Visible = True
        End If

        Call Carregalist(0) ' LISTA OS REGISTROS CONFORME SELEÇÃO INICIAL
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If

    End Sub


#Region "BOTÕES"
    Private Sub btnProc_Click(sender As Object, e As EventArgs) Handles btnProc.Click
        filtro = 0
        Call Carregalist(0) ' LISTA OS REGISTROS CONFORME SELEÇÃO INICIAL
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If
    End Sub



    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If CON07.Value = 1 Then
            MetroFramework.MetroMessageBox.Show(Me, " Não foram localizados acompanhantes para este registro. ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        frmAmplia02.CADP002.Text = CADP002.Text
        frmAmplia02.CADP003.Text = CADP003.Text
        frmAmplia02.CADP001.Text = CADP001.Text
        frmAmplia02.ShowDialog()
    End Sub

    Private Sub VEI002_Click(sender As Object, e As EventArgs) Handles VEI002.Click
        If VEI002.Text <> "" Or VEI002.Text <> Nothing Then
            frmVeiculos01.VEI002.Text = VEI002.Text
            frmVeiculos01.ShowDialog()
        Else
            MetroFramework.MetroMessageBox.Show(Me, " Não existe veículo vinculado ao registro da portaria! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' volta seleção inicial
        CADP001.Text = iCADP001.Text
        CON04.Value = dataIni
        CON11.Value = dataFim
        filtro = 0
        Call Carregalist(0) ' LISTA OS REGISTROS CONFORME SELEÇÃO INICIAL
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If iOrigem.Text = "LOC" Then
            Call BuscaDados(1) ' MONTA LISTA QUANDO LOCATÁRIO
        Else
            filtro = 1
            Call Carregalist(0) ' LISTA OS REGISTROS CONFORME SELEÇÃO INICIAL
            If pop > 0 Then
                Me.lvDados.Items(0).Selected = True
                lvDados.Select()
            End If
        End If
    End Sub
#End Region

#Region "LISTVIEW"

    Private Sub filtrar()
        Select Case iOrigem.Text
            Case "PRO"
                Select Case filtro
                    Case 0
                        ' FILTRO INICIAL
                        sql = "SELECT a.CON01,a.CON02,a.CON04,a.CON05,a.CON06,a.CON11,a.CON12,a.CON13,a.CADP001,a.CADP002,b.CADP003 FROM prt_acesscon AS a inner join prt_cadpro AS b on (a.CADP001 = b.CADP001) where a.CADP001 = '" & CADP001.Text & "' and a.CON04 >= '" & Format(CON04.Value, "yyyy-MM-dd") & "' and a.CON04 <= '" & Format(CON11.Value, "yyyy-MM-dd") & "' ORDER BY a.CON04 DESC"
                    Case 1
                        sql = "SELECT a.CON01,a.CON02,a.CON04,a.CON05,a.CON06,a.CON11,a.CON12,a.CON13,a.CADP001,a.CADP002,b.CADP003 FROM prt_acesscon AS a inner join prt_cadpro AS b on (a.CADP001 = b.CADP001) where (a.CON04 >= '" & Format(CON04.Value, "yyyy-MM-dd") & "' and a.CON04 <= '" & Format(CON11.Value, "yyyy-MM-dd") & "') and (a.CADP002 = '" & iCADP002.Text & "') and (a.CADP037 = '9' or a.CADP037 = '1' ) order by a.CON04 DESC"
                End Select
            Case "LOC"
                Select Case filtro
                    Case 0
                        ' FILTRO INICIAL
                        sql = "SELECT a.CON01,a.CON02,a.CON04,a.CON05,a.CON06,a.CON11,a.CON12,a.CON13,a.CADP001,a.CADP002,b.CADP003 FROM prt_acesscon AS a inner join prt_cadpro AS b on (a.CADP001 = b.CADP001) where a.CADP001 = '" & CADP001.Text & "' and a.CON04 >= '" & Format(CON04.Value, "yyyy-MM-dd") & "' and a.CON04 <= '" & Format(CON11.Value, "yyyy-MM-dd") & "' ORDER BY a.CON04 DESC"
                End Select
            Case "HOS"
                Select Case filtro
                    Case 0
                        ' FILTRO INICIAL
                        sql = "SELECT a.CON01,a.CON02,a.CON04,a.CON05,a.CON06,a.CON11,a.CON12,a.CON13,a.CADP001,a.CADP002,b.CADP003 FROM prt_acesscon AS a inner join prt_cadpro AS b on (a.CADP001 = b.CADP001) where a.CADP001 = '" & CADP001.Text & "' and a.CON04 >= '" & Format(CON04.Value, "yyyy-MM-dd") & "' and a.CON04 <= '" & Format(CON11.Value, "yyyy-MM-dd") & "' ORDER BY a.CON04 DESC"
                    Case 1
                        sql = "SELECT a.CON01,a.CON02,a.CON04,a.CON05,a.CON06,a.CON11,a.CON12,a.CON13,a.CADP001,a.CADP002,b.CADP003 FROM prt_acesscon AS a inner join prt_cadpro AS b on (a.CADP001 = b.CADP001) where (a.CON04 >= '" & Format(CON04.Value, "yyyy-MM-dd") & "' and a.CON04 <= '" & Format(CON11.Value, "yyyy-MM-dd") & "') and (a.CADP002 = '" & iCADP002.Text & "') and (a.CADP037 = '2') order by a.CON04 DESC"
                End Select
        End Select
    End Sub

    Private Sub limpaOScampos()
        VEI002.Text = ""
        CON07.Value = 0
        CON08.Value = 0
        CON09.Value = 0
        CON10.Text = ""
        CON14.Text = ""

    End Sub


    Private Sub BuscaDados(arg)
        Select Case arg
            Case 0
                If conexao.State = 0 Then
                    conexao.Open()
                End If
                Dim comando As New MySqlCommand("select a.CON07,a.CON08,a.CON09,a.CON10,a.CON14,a.CON17,a.CON006,a.VEI002,b.VEI003,b.VEI004,b.VEI005 from prt_acesscon AS a left join prt_veiculos AS b on (a.VEI002 = b.VEI002) where a.CON01 = '" & CON01.Text & "'", conexao)
                Dim leitor As MySqlDataReader = comando.ExecuteReader()
                Call limpaOScampos()
                While leitor.Read()
                    CON07.Text = IIf(Convert.IsDBNull(leitor("CON07")) = True, "0", leitor("CON07"))
                    CON08.Text = IIf(Convert.IsDBNull(leitor("CON08")) = True, "0", leitor("CON08"))
                    CON09.Text = IIf(Convert.IsDBNull(leitor("CON09")) = True, "0", leitor("CON09"))
                    CON10.Text = IIf(Convert.IsDBNull(leitor("CON10")) = True, "*", leitor("CON10"))
                    CON14.Text = IIf(Convert.IsDBNull(leitor("CON14")) = True, "", leitor("CON14"))
                    CON17.Text = IIf(Convert.IsDBNull(leitor("CON17")) = True, "", leitor("CON17"))
                    CON006.Text = IIf(Convert.IsDBNull(leitor("CON006")) = True, "", leitor("CON006"))

                    VEI002.Text = IIf(Convert.IsDBNull(leitor("VEI002")) = True, "", leitor("VEI002"))
                    VEI003.Text = IIf(Convert.IsDBNull(leitor("VEI003")) = True, "", leitor("VEI003"))
                    VEI004.Text = IIf(Convert.IsDBNull(leitor("VEI004")) = True, "", leitor("VEI004"))
                    VEI005.Text = IIf(Convert.IsDBNull(leitor("VEI005")) = True, "", leitor("VEI005"))

                    If CON17.Text = 1 Then
                        'imgStatus.Visible = True
                        If CON006.Text = 1 Then
                            imgStatus.Image = ImageGrid.Images(0)
                            ToolTip1.SetToolTip(Me.imgStatus, "Aberto no empreendimento")
                        Else CON006.Text = 2
                            imgStatus.Image = ImageGrid.Images(1)
                            ToolTip1.SetToolTip(Me.imgStatus, "Aberto fora do empreendimento")
                        End If
                    Else
                        imgStatus.Image = ImageGrid.Images(2)
                        ToolTip1.SetToolTip(Me.imgStatus, "Movimento fechado")
                    End If

                End While
                comando.Cancel()
                leitor.Close()
                conexao.Close()
            Case 1
                ' COLOCA AS INFORMAÇÕES DO CADASTRO DE UNIDADES LOCADAS PELO LOCATÁRIO TABELA PRT_REGLOC
                ' DENTRO DE UMA ARRAY = arl
                ' APÓS A LEITURA ACIONA A LEITURA DOS DADOS GRAVADOS NA ARRAY ONDE DENTRO DO FOR EACH É FEITO O TRATAMENTO PARA
                ' POPULAR O LISTVIEW COM TODOS OS REGISTROS DESSE LOCATÁRIO, REUNINDO TODAS AS UNIDADES LOCADAS POR ESTE.
                lvDados.Items.Clear()
                lvDados.BackColor = Color.White
                lvDados.GridLines = True
                lvDados.FullRowSelect = True
                lvDados.View = View.Details
                lvDados.Sorting = SortOrder.None

                Dim ds As New DataSet
                Dim dr As DataRow
                Dim dt As New DataTable
                Dim adptr As New MySqlDataAdapter("select CADP002 FROM prt_regloc where CADL002 = '" & xCADP002.Text & "'", conexao)
                adptr.Fill(ds, "prt_regloc")
                dt = ds.Tables(0)
                Dim Item01 As String
                arl.Clear()
                For Each dr In dt.Rows
                    Item01 = (dr.Item("CADP002"))
                    arl.Add(Item01)
                Next

                For Each nome In arl
                    iCADP002.Text = nome
                    sqlLoc = "SELECT a.CON01,a.CON02,a.CON04,a.CON05,a.CON06,a.CON11,a.CON12,a.CON13,a.CADP001,a.CADP002,b.CADP003 FROM prt_acesscon AS a inner join prt_cadpro AS b on (a.CADP001 = b.CADP001) where (CON04 >= '" & Format(CON04.Value, "yyyy-MM-dd") & "' and CON04 <= '" & Format(CON11.Value, "yyyy-MM-dd") & "') and (a.CADP002 = '" & iCADP002.Text & "') and (a.CADP037 = '3') order by a.CON04 DESC"
                    Call Carregalist(2)
                Next

        End Select
    End Sub

    Private Sub Carregalist(arg)
        Select Case arg
            Case 0
                Call filtrar()
                lvDados.Items.Clear()
                lvDados.BackColor = Color.White
                lvDados.GridLines = True
                lvDados.FullRowSelect = True
                lvDados.View = View.Details
                lvDados.Sorting = SortOrder.None
                conexao.Open()
                Dim cmd As MySqlCommand = New MySqlCommand(Sql, conexao)
                Dim leitor As MySqlDataReader = cmd.ExecuteReader()
                Dim leitura As Integer = 0
                pop = 0

                Do While leitor.Read()
                    Dim item As New ListViewItem()
                    item.Text = leitor(0)
                    item = lvDados.Items.Add(leitor("CON01").ToString)  ' 0 ID DA TABELA PRT_ACESSCON
                    item.SubItems.Add(leitor("CON02").ToString)         ' 1 CÓDIGO DO MOVIMENTO DE ENTRADA E SAÍDA
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("CON04")) = True, "", leitor("CON04"))) ' 2 DATA ENTRADA
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("CON05")) = True, "", leitor("CON05"))) ' 3 HORA DA ENTRADA
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("CON06")) = True, "", leitor("CON06"))) ' 4 PORTEIRO
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("CON11")) = True, "", leitor("CON11"))) ' 5 DATA SAIDA
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("CON12")) = True, "", leitor("CON12"))) ' 6 HORA DA SAIDA
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("CON13")) = True, "", leitor("CON13"))) ' 7 PORTEIRO
                    item.SubItems.Add(leitor("CADP001").ToString)         ' 8 ID DO REGISTRO NA TABELA PRT_CADPRO
                    item.SubItems.Add(leitor("CADP003").ToString)         ' 9 NOME DO USUÁRIO
                    item.SubItems.Add(leitor("CADP002").ToString)         ' 10 NUMERO DA UNIDADE
                    pop += 1 ' faz a contagem dos registros no listview
                Loop
                'Call corlist()
                conexao.Close() ' fecha a conexação com o banco de dados
                leitor.Dispose()
            Case 1
                lvAcesso.Items.Clear()
                lvAcesso.GridLines = True
                lvAcesso.FullRowSelect = True
                lvAcesso.View = View.Details
                lvAcesso.Sorting = SortOrder.None
                'lvacesso.SmallImageList = ImageGrid
                conexao.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("SELECT CON03,CON04,CON05,CON006, GAR002 FROM prt_reglog  where CON02 = '" & CON02.Text & "' order by CON03 DESC", conexao)
                Dim leitor As MySqlDataReader = cmd.ExecuteReader()
                Dim leitura As Integer = 0
                popAs = 0
                Dim a001 As String = ""
                Dim CON006 As New TextBox
                Do While leitor.Read()
                    Dim item As New ListViewItem()
                    item.Text = leitor(0)

                    a001 = leitor("CON006")
                    If a001 = "1" Then
                        CON006.Text = "ENTRADA"
                    ElseIf a001 = "2" Then
                        CON006.Text = "SAÍDA"
                    End If

                    item = lvAcesso.Items.Add(leitor("CON03"))          ' 0 DATA
                    item.SubItems.Add(leitor("CON04").ToString)         ' 1 HORA
                    item.SubItems.Add(leitor("CON05").ToString)         ' 2 PORTEIRO
                    item.SubItems.Add(CON006.Text)                      ' 3 ENTRADA/SAÍDA
                    item.SubItems.Add(leitor("GAR002").ToString)
                    popAs += 1 ' faz a contagem dos registros no listview

                Loop
                conexao.Close() ' fecha a conexação com o banco de dados
                leitor.Dispose()
            Case 2
                conexao.Open()
                Dim cmd As MySqlCommand = New MySqlCommand(sqlLoc, conexao)
                Dim leitor As MySqlDataReader = cmd.ExecuteReader()
                Do While leitor.Read()
                    Dim item As New ListViewItem()
                    item.Text = leitor(0)
                    item = lvDados.Items.Add(leitor("CON01").ToString)  ' 0 ID DA TABELA PRT_ACESSCON
                    item.SubItems.Add(leitor("CON02").ToString)         ' 1 CÓDIGO DO MOVIMENTO DE ENTRADA E SAÍDA
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("CON04")) = True, "", leitor("CON04"))) ' 2 DATA ENTRADA
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("CON05")) = True, "", leitor("CON05"))) ' 3 HORA DA ENTRADA
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("CON06")) = True, "", leitor("CON06"))) ' 4 PORTEIRO
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("CON11")) = True, "", leitor("CON11"))) ' 5 DATA SAIDA
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("CON12")) = True, "", leitor("CON12"))) ' 6 HORA DA SAIDA
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("CON13")) = True, "", leitor("CON13"))) ' 7 PORTEIRO
                    item.SubItems.Add(leitor("CADP001").ToString)         ' 8 ID DO REGISTRO NA TABELA PRT_CADPRO
                    item.SubItems.Add(leitor("CADP003").ToString)         ' 9 NOME DO USUÁRIO
                    item.SubItems.Add(leitor("CADP002").ToString)         ' 10 NUMERO DA UNIDADE
                    pop += 1 ' faz a contagem dos registros no listview
                Loop
                conexao.Close()
                leitor.Dispose()
        End Select
    End Sub
    Private Sub lvDados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDados.SelectedIndexChanged
        Try
            If lvDados.SelectedItems.Count > 0 Then
                index = lvDados.Items.Item(lvDados.SelectedIndices(0)).Index

                Me.CON01.Text = Convert.ToString(lvDados.Items(lvDados.SelectedIndices(0)).Text)
                Me.CON02.Text = Me.lvDados.SelectedItems(0).SubItems(1).Text
                Me.CADP001.Text = Me.lvDados.SelectedItems(0).SubItems(8).Text
                Me.CADP003.Text = Me.lvDados.SelectedItems(0).SubItems(9).Text
                Me.CADP002.Text = Me.lvDados.SelectedItems(0).SubItems(10).Text

                Call BuscaDados(0) ' BUSCA OS DADOS COMPLEMENTARES
                Call Carregalist(1) ' BUSCA OS REGISTROS DE ENTRADA E SAIDA


                If VEI002.Text = "" Then
                    gVei.Visible = False
                Else
                    gVei.Visible = True
                End If

                If pop > 0 Then
                    gOcup.Visible = True
                Else
                    gOcup.Visible = False
                End If

                'If Me.lvDados.SelectedItems(0).SubItems(3).Text = "REGISTRO" Then
                '    img.Image = imgLimpa.Image
                'Else
                '    img.ImageLocation = (My.Application.Info.DirectoryPath & "\file\owner\" & Me.lvDados.SelectedItems(0).SubItems(3).Text & ".dat")
                'End If

            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "FUNÇÕES"
    Private Sub corlist()
        For i As Integer = 0 To lvDados.Items.Count - 1
            lvDados.Items(i).UseItemStyleForSubItems = False

            lvDados.Items(i).SubItems(0).BackColor = Color.FromArgb(239, 241, 248)  ' 
            lvDados.Items(i).SubItems(1).BackColor = Color.FromArgb(239, 241, 248)  ' 
            lvDados.Items(i).SubItems(2).BackColor = Color.FromArgb(239, 241, 248)  ' 
            lvDados.Items(i).SubItems(3).BackColor = Color.FromArgb(239, 241, 248)  ' 
            lvDados.Items(i).SubItems(4).BackColor = Color.FromArgb(239, 241, 248)  ' 

            lvDados.Items(i).SubItems(5).BackColor = Color.FromArgb(217, 241, 251)  ' 
            lvDados.Items(i).SubItems(6).BackColor = Color.FromArgb(217, 241, 251)  ' 
            lvDados.Items(i).SubItems(7).BackColor = Color.FromArgb(217, 241, 251)  ' 


            'lvDados.Items(i).SubItems(10).ForeColor = Color.Red  ' 

            'lvDados.Items(i).SubItems(1).Font = New Font(lvDados.Items(i).SubItems(1).Font, FontStyle.Bold)
            'lvDados.Items(i).SubItems(2).Font = New Font(lvDados.Items(i).SubItems(2).Font, FontStyle.Bold)
            'lvDados.Items(i).SubItems(10).Font = New Font(lvDados.Items(i).SubItems(10).Font, FontStyle.Bold)
        Next
    End Sub
#End Region

#Region "ENTER"
    Private Sub CON04_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CON04.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            CON11.Focus()
        End If
    End Sub
    Private Sub CON11_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CON11.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If CON11.Value < CON04.Value Then
                MetroFramework.MetroMessageBox.Show(Me, "A data final deve ser maior que a data inicial...", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CON11.Focus()
            Else
                btnProc.Focus()
                btnProc.PerformClick()
            End If
        End If
    End Sub


#End Region


End Class
























