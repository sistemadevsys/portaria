Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmControleA
    Dim Data_hoje As DateTime = DateTime.Now

    Dim hoje As DateTime = DateTime.Now


    Dim sql As String
    Dim status, tipoCAD, COMANDO As String
    Dim gatilho As String
    Dim pop As Integer
    Dim FUN028 As String
    Dim baixa As String
    Dim inicio, fim As DateTime
    Dim VEI008 As New TextBox
    Dim opc As Integer
    Dim NOMEMP As String
    Dim chave As String

    Private Sub frmControleA_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            ' BOTÃO INCLUIR NOVO REGISTRO
            desce.PerformClick()
        End If
        If e.KeyCode = Keys.Right Then
            ' BOTÃO INCLUIR NOVO REGISTRO
            sobe.PerformClick()
        End If
    End Sub
    Private Sub frmControleA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
    Private Sub frmControleA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelOutros.Visible = False

        gatilho = 1
        DataSys.Value = Data_hoje
        DataSys.MaxDate = Data_hoje
        btnAtivo.PerformClick() ' seleciona o botão ativos
    End Sub


#Region "FUNÇÕES"
    Private Sub TrataData()
        diaSem.Text = Format(DataSys.Value, "dddd")
        diaSem.Text = UCase(diaSem.Text)
        Button9.Text = "Todos Registros:  " & DataSys.Text
        tbPesq01.Clear()
        tbPesq01.Visible = False
        btnexecuta.Visible = False
    End Sub
    Private Sub gravar(arg)
        Select Case arg
            Case 0
                ' FAZ A BAIXA DO FUNCIONÁRIO
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim cmd As New MySqlCommand("update prt_fass set FAS006 = '" & Format(Data_hoje, "yyyy-MM-dd") & "', FAS007 = '" & DateTime.Now.ToLongTimeString().Substring(0, 5) & "', FAS008 = '" & iUsername & "', COMANDO = 3 WHERE FAS001 = '" & baixa & "'", conexao)
                conexao.Open()
                cmd.ExecuteNonQuery()
                conexao.Close()
        End Select
    End Sub
    Private Sub contaDIA(arg)
        Select Case arg
            Case 0
                DataSys.Value = DataSys.Value.AddDays(1)
            Case 1
                DataSys.Value = DataSys.Value.AddDays(-1)
        End Select
    End Sub

    Private Sub filtro(arg)
        Select Case arg
            Case 1
                If gatilho = 1 Then
                    sql = "select a.FAS001,a.FAS002,a.FAS003,a.FAS005,a.FAS006,a.FAS007,a.FAS008,a.FAS011,a.COMANDO,a.VEI002,a.ARM002,b.FUN002,b.FUN003,b.FUN004,b.FUN028,b.FUN024,c.EMP003,d.VEI008 from prt_fass AS a inner join prt_cadfun AS b on (a.FUN002 = b.FUN002) left Join prt_empresa as c on (a.emp002 = c.emp002) left join prt_veiculos as d on (a.VEI002 = d.VEI002) where a.FAS002 = '" & Format(DataSys.Value, "yyyy-MM-dd") & "' and a.COMANDO = '0' or a.COMANDO = '1' or a.COMANDO = '2' order by b.FUN028,a.FAS003"
                ElseIf gatilho = 3 Then
                    sql = "select a.FAS001,a.FAS002,a.FAS003,a.FAS005,a.FAS006,a.FAS007,a.FAS008,a.FAS011,a.COMANDO,a.VEI002,a.ARM002,b.FUN002,b.FUN003,b.FUN004,b.FUN028,b.FUN024,c.EMP003,d.VEI008 from prt_fass AS a inner join prt_cadfun AS b on (a.FUN002 = b.FUN002) left Join prt_empresa as c on (a.emp002 = c.emp002) left join prt_veiculos as d on (a.VEI002 = d.VEI002) where a.FAS002 = '" & Format(DataSys.Value, "yyyy-MM-dd") & "' and a.COMANDO = '3' order by b.FUN028,a.FAS003"
                Else
                    sql = "select a.FAS001,a.FAS002,a.FAS003,a.FAS005,a.FAS006,a.FAS007,a.FAS008,a.FAS011,a.COMANDO,a.VEI002,a.ARM002,b.FUN002,b.FUN003,b.FUN004,b.FUN028,b.FUN024,c.EMP003,d.VEI008 from prt_fass AS a inner join prt_cadfun AS b on (a.FUN002 = b.FUN002) left Join prt_empresa as c on (a.emp002 = c.emp002) left join prt_veiculos as d on (a.VEI002 = d.VEI002) where a.FAS002 = '" & Format(DataSys.Value, "yyyy-MM-dd") & "' and a.COMANDO = '3' and b.FUN028 = '" & FUN028 & "' order by b.FUN028,a.FAS003"
                End If
            Case 2
                sql = "select a.FAS001,a.FAS002,a.FAS003,a.FAS005,a.FAS006,a.FAS007,a.FAS008,a.FAS011,a.COMANDO,a.VEI002,a.ARM002,b.FUN002,b.FUN003,b.FUN004,b.FUN028,b.FUN024,c.EMP003,d.VEI008 from prt_fass AS a inner join prt_cadfun AS b on (a.FUN002 = b.FUN002) left Join prt_empresa as c on (a.emp002 = c.emp002) left join prt_veiculos as d on (a.VEI002 = d.VEI002) where a.FAS002 = '" & Format(DataSys.Value, "yyyy-MM-dd") & "' order by b.FUN028,a.FAS003"
            Case 3
                sql = "select a.FAS001,a.FAS002,a.FAS003,a.FAS005,a.FAS006,a.FAS007,a.FAS008,a.FAS011,a.COMANDO,a.VEI002,a.ARM002,b.FUN002,b.FUN003,b.FUN004,b.FUN028,b.FUN024,c.EMP003,d.VEI008 from prt_fass AS a inner join prt_cadfun AS b on (a.FUN002 = b.FUN002) left Join prt_empresa as c on (a.emp002 = c.emp002) left join prt_veiculos as d on (a.VEI002 = d.VEI002) where b.FUN003 like '" & chave & "%' order by a.FAS002 DESC,a.FAS003"
            Case 4
                sql = "Select a.FAS001,a.FAS002,a.FAS003,a.FAS005,a.FAS006,a.FAS007,a.FAS008,a.FAS011,a.COMANDO,a.VEI002,a.ARM002,b.FUN002,b.FUN003,b.FUN004,b.FUN028,b.FUN024,c.EMP003,d.VEI008 from prt_fass As a left join prt_cadfun As b On (a.FUN002 = b.FUN002) left Join prt_empresa As c On (b.emp002 = c.emp002) left join prt_veiculos As d On (a.VEI002 = d.VEI002) where c.EMP003 Like '" & chave & "%' order by b.FUN028,a.FAS002 DESC,a.FAS003"
            Case 5
                sql = "select a.FAS001,a.FAS002,a.FAS003,a.FAS005,a.FAS006,a.FAS007,a.FAS008,a.FAS011,a.COMANDO,a.VEI002,a.ARM002,b.FUN002,b.FUN003,b.FUN004,b.FUN028,b.FUN024,c.EMP003,d.VEI008 from prt_fass AS a left join prt_cadfun AS b on (a.FUN002 = b.FUN002) left Join prt_empresa as c on (b.emp002 = c.emp002) left join prt_veiculos as d on (a.VEI002 = d.VEI002) where d.VEI002 like '" & chave & "%' order by a.FAS002 DESC,a.FAS003"
            Case 6
                sql = "select a.FAS001,a.FAS002,a.FAS003,a.FAS005,a.FAS006,a.FAS007,a.FAS008,a.FAS011,a.COMANDO,a.VEI002,a.ARM002,b.FUN002,b.FUN003,b.FUN004,b.FUN028,b.FUN024,c.EMP003,d.VEI008 from prt_fass AS a left join prt_cadfun AS b on (a.FUN002 = b.FUN002) left Join prt_empresa as c on (b.emp002 = c.emp002) left join prt_veiculos as d on (a.VEI002 = d.VEI002) where b.FUN028 = 'VIS' order by a.FAS002 DESC,a.FAS003"
        End Select
    End Sub

    Private Sub carregaList()
        lvMovimento.Items.Clear()
        lvMovimento.GridLines = True
        lvMovimento.FullRowSelect = True
        lvMovimento.View = View.Details
        lvMovimento.Sorting = SortOrder.None
        conexao.Open()

        Dim cmd As MySqlCommand = New MySqlCommand(sql, conexao)
        Dim leitor As MySqlDataReader = cmd.ExecuteReader()

        pop = 0

        Dim Tfun As Integer = 0
        Dim TPre As Integer = 0
        Dim TEmp As Integer = 0
        Dim TVis As Integer = 0
        Dim TGer As Integer = 0

        ttFun.Text = "00"
        ttPre.Text = "00"
        ttEmp.Text = "00"
        ttVis.Text = "00"
        TTGer.Text = "00"

        Do While leitor.Read()
            Dim item As New ListViewItem()
            Dim COMANDO As String = leitor("COMANDO")
            FUN028 = leitor("FUN028")

            tempo.Text = ""


            If COMANDO = "0" Then
                If DataSys.Value < Format(Data_hoje, "dd/MM/yyyy") Then
                    status = "PENDENTE"
                Else 'If DataSys.Value = Format(Data_hoje, "dd/MM/yyyy") Then
                    status = "ANDAMENTO"
                End If

                inicio = leitor("FAS002") & " " & leitor("FAS003") & ":00"
                fim = hoje 'DateTime.Now.ToLongTimeString()
                Dim dif As TimeSpan = fim.Subtract(inicio)
                tempo.Text = dif.ToString.Substring(0, 5)
            ElseIf COMANDO = "3" Then
                status = "ENCERRADO"

                inicio = leitor("FAS002") & " " & leitor("FAS003") & ":00"
                fim = leitor("FAS006") & " " & leitor("FAS007") & ":00"
                Dim dif As TimeSpan = fim.Subtract(inicio)
                tempo.Text = dif.ToString.Substring(0, 5)
            End If

            Select Case FUN028
                Case "EMP"
                    tipoCAD = "Empresa Credenciada"
                    TEmp += 1
                    NOMEMP = ""
                Case "FUN"
                    tipoCAD = "Funcionário"
                    Tfun += 1
                    NOMEMP = iReg002
                Case "PRE"
                    tipoCAD = "Autonomo Individual"
                    TPre += 1
                    NOMEMP = "CADASTRO INDIVIDUAL DE AUTONOMOS E PRESTADORES"
                Case "VIS"
                    tipoCAD = "VISITANTES"
                    TVis += 1
                    NOMEMP = "CADASTRO DE VISITANTES"
            End Select

            TGer = TEmp + Tfun + TPre + TVis ' soma a quantidade de usuários

            item.Text = leitor(0)
            item = lvMovimento.Items.Add(leitor("FAS001").ToString)                                                                    ' 0 CÓDIGO
            item.SubItems.Add(leitor("FUN003"))                                                                                        ' 1 NOME DO FUNCIONÁRIO
            item.SubItems.Add(IIf(Convert.IsDBNull(Format(leitor("FAS002"), "dd/MM/yyyy").ToString) = True, "", leitor("FAS002")))     ' 2 DATA DO REGISTRO
            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FAS003")) = True, "", leitor("FAS003")))                                    ' 3 HORA DO REGISTRO
            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FAS005")) = True, "", leitor("FAS005")))                                    ' 4 PORTEIRO

            If COMANDO = "3" Then
                item.SubItems.Add(IIf(Convert.IsDBNull(Format(leitor("FAS006"), "dd/MM/yyyy").ToString) = True, "", leitor("FAS006"))) ' 5 DATA DO REGISTRO
                item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FAS007")) = True, "", leitor("FAS007")))                                ' 6 HORA DO REGISTRO
                item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FAS008")) = True, "", leitor("FAS008")))                                ' 7 PORTEIRO
            Else
                item.SubItems.Add("")                      '5 STATUS
                item.SubItems.Add("")                      '6 STATUS
                item.SubItems.Add("")                      '7 STATUS
            End If
            item.SubItems.Add(tipoCAD)                                                                                                 ' 8 TIPO CADASTRO
            item.SubItems.Add(status)                                                                                                  ' 9 STATUS

            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("VEI002")) = True, "", leitor("VEI002")))                                    ' 10 veiculo                  

            item.SubItems.Add(leitor("FUN024"))                                                                                        ' 11 IMAGEM  
            item.SubItems.Add(leitor("FAS011"))                                                                                        ' 12 OBSERVAÇÕES              

            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FUN028")) = True, "", leitor("FUN028"))) ' 13 TIPO DE CADASTRO
            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FUN004")) = True, "", leitor("FUN004"))) ' 14 CARGO
            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("ARM002")) = True, "", leitor("ARM002"))) ' 15 ARMÁRIO
            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("EMP003")) = True, NOMEMP, leitor("EMP003")))                               '16 CÓDIGO DA EMPRESA EMP002
            item.SubItems.Add(tempo.Text)                                                                                              ' 17 TEMPO PERMANENCIA                
            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("VEI008")) = True, "REGISTRO", leitor("VEI008")))                                    ' 18 IMAGEM VEICULO

            ttFun.Text = Tfun
            ttPre.Text = TPre
            ttEmp.Text = TEmp
            ttVis.Text = TVis
            TTGer.Text = TGer

            pop += 1
        Loop
        conexao.Close() ' fecha a conexação com o banco de dados

        Call desligaBotao()

        Call CORLIST()


    End Sub


    Private Sub corlist()
        For i As Integer = 0 To lvMovimento.Items.Count - 1
            lvMovimento.Items(i).UseItemStyleForSubItems = False
            Select Case lvMovimento.Items(i).SubItems(8).Text
                Case "Empresa Credenciada"
                    lvMovimento.Items(i).SubItems(1).ForeColor = Color.LightSalmon
                    lvMovimento.Items(i).SubItems(2).ForeColor = Color.LightSalmon
                    lvMovimento.Items(i).SubItems(3).ForeColor = Color.LightSalmon
                    lvMovimento.Items(i).SubItems(4).ForeColor = Color.LightSalmon
                    lvMovimento.Items(i).SubItems(5).ForeColor = Color.LightSalmon
                    lvMovimento.Items(i).SubItems(6).ForeColor = Color.LightSalmon
                    lvMovimento.Items(i).SubItems(7).ForeColor = Color.LightSalmon
                    lvMovimento.Items(i).SubItems(8).ForeColor = Color.LightSalmon
                Case "Funcionário"
                    lvMovimento.Items(i).SubItems(1).ForeColor = Color.Yellow
                    lvMovimento.Items(i).SubItems(2).ForeColor = Color.Yellow
                    lvMovimento.Items(i).SubItems(3).ForeColor = Color.Yellow
                    lvMovimento.Items(i).SubItems(4).ForeColor = Color.Yellow
                    lvMovimento.Items(i).SubItems(5).ForeColor = Color.Yellow
                    lvMovimento.Items(i).SubItems(6).ForeColor = Color.Yellow
                    lvMovimento.Items(i).SubItems(7).ForeColor = Color.Yellow
                    lvMovimento.Items(i).SubItems(8).ForeColor = Color.Yellow
                Case "Autonomo Individual"
                    lvMovimento.Items(i).SubItems(1).ForeColor = Color.DodgerBlue
                    lvMovimento.Items(i).SubItems(2).ForeColor = Color.DodgerBlue
                    lvMovimento.Items(i).SubItems(3).ForeColor = Color.DodgerBlue
                    lvMovimento.Items(i).SubItems(4).ForeColor = Color.DodgerBlue
                    lvMovimento.Items(i).SubItems(5).ForeColor = Color.DodgerBlue
                    lvMovimento.Items(i).SubItems(6).ForeColor = Color.DodgerBlue
                    lvMovimento.Items(i).SubItems(7).ForeColor = Color.DodgerBlue
                    lvMovimento.Items(i).SubItems(8).ForeColor = Color.DodgerBlue
                Case "VISITANTES"
                    lvMovimento.Items(i).SubItems(1).ForeColor = Color.Tomato
                    lvMovimento.Items(i).SubItems(2).ForeColor = Color.Tomato
                    lvMovimento.Items(i).SubItems(3).ForeColor = Color.Tomato
                    lvMovimento.Items(i).SubItems(4).ForeColor = Color.Tomato
                    lvMovimento.Items(i).SubItems(5).ForeColor = Color.Tomato
                    lvMovimento.Items(i).SubItems(6).ForeColor = Color.Tomato
                    lvMovimento.Items(i).SubItems(7).ForeColor = Color.Tomato
                    lvMovimento.Items(i).SubItems(8).ForeColor = Color.Tomato
            End Select
        Next
    End Sub



    Private Function desligaBotao()
        If pop = 0 Then
            Button18.Enabled = False
            Button20.Enabled = False
            btnPrint01.Enabled = False
        Else
            Button18.Enabled = True
            Button20.Enabled = True
            btnPrint01.Enabled = True
        End If
    End Function



    Private Sub lvMovimento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvMovimento.SelectedIndexChanged
        Try
            If lvMovimento.SelectedItems.Count > 0 Then
                'baixa = lvMovimento.Items.Item(lvMovimento.SelectedIndices(0)).Index
                Me.baixa = Convert.ToString(lvMovimento.Items(lvMovimento.SelectedIndices(0)).Text)
                Me.FAS011.Text = Me.lvMovimento.SelectedItems(0).SubItems(12).Text
                Me.FUN004.Text = Me.lvMovimento.SelectedItems(0).SubItems(14).Text
                Me.ARM002.Text = Me.lvMovimento.SelectedItems(0).SubItems(15).Text
                Me.iFUN028.Text = Me.lvMovimento.SelectedItems(0).SubItems(8).Text
                Me.EMP003.Text = Me.lvMovimento.SelectedItems(0).SubItems(16).Text
                Me.tempo.Text = Me.lvMovimento.SelectedItems(0).SubItems(17).Text

                img.ImageLocation = (My.Application.Info.DirectoryPath & "\file\employee\" & Me.lvMovimento.SelectedItems(0).SubItems(11).Text & ".dat")
                imgCAR.ImageLocation = (My.Application.Info.DirectoryPath & "\file\car\" & Me.lvMovimento.SelectedItems(0).SubItems(18).Text & ".dat")

                If Me.lvMovimento.SelectedItems(0).SubItems(9).Text = "ENCERRADO" Then
                    Button18.Enabled = False
                    Button20.Enabled = False
                Else
                    Button18.Enabled = True
                    Button20.Enabled = True
                End If


                Select Case Me.lvMovimento.SelectedItems(0).SubItems(13).Text
                    Case "EMP"
                        label10.Text = "Empresa Credenciada:"
                        label10.ForeColor = Color.Red
                        EMP003.ForeColor = Color.Navy
                    Case "FUN"
                        label10.Text = "Empregado do Empreendimento:"
                        label10.ForeColor = Color.Navy
                        EMP003.ForeColor = Color.Navy
                    Case "PRE"
                        label10.Text = "Registro de Prestador de Serviços"
                        EMP003.ForeColor = Color.Navy
                    Case "VIS"
                        label10.Text = "Registro de Visitantes"
                        EMP003.ForeColor = Color.Navy
                End Select


            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub buscadados(arg)
        Select Case arg
            Case 0
                If conexao.State = 0 Then
                    conexao.Open()
                End If
                Dim comando As New MySqlCommand("select EMP003,EMP010 FROM prt_empresa where EMP002 = '" & lvMovimento.SelectedItems(0).SubItems(16).Text & "'", conexao)
                Dim leitor As MySqlDataReader = comando.ExecuteReader()
                While leitor.Read()
                    EMP003.Text = IIf(Convert.IsDBNull(leitor("EMP003")) = True, "", leitor("EMP003")) ' NOME DA EMPRESA
                    iFUN028.Text = IIf(Convert.IsDBNull(leitor("EMP010")) = True, "", leitor("EMP010")) ' RAMO DE ATIVIDADE
                End While
                comando.Cancel()
                leitor.Close()
                conexao.Close()
            Case 1

                If conexao.State = 0 Then
                    conexao.Open()
                End If
                Dim comando As New MySqlCommand("select VEI008 FROM prt_veiculos where VEI002 = '" & lvMovimento.SelectedItems(0).SubItems(10).Text & "'", conexao)
                Dim leitor As MySqlDataReader = comando.ExecuteReader()
                While leitor.Read()
                    VEI008.Text = IIf(Convert.IsDBNull(leitor("VEI008")) = True, "", leitor("VEI008")) ' IMAGEM VEICULO
                    imgCAR.ImageLocation = (My.Application.Info.DirectoryPath & "\file\car\" & VEI008.Text & ".dat")
                End While
                comando.Cancel()
                leitor.Close()
                conexao.Close()
        End Select
    End Sub




#End Region

#Region "BOTÕES"
    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub
    Private Sub btnAtivo_Click(sender As Object, e As EventArgs) Handles btnAtivo.Click
        ' SELECIONA OS REGISTROS ATIVO
        'COMANDO = 0
        gatilho = 1
        Call TrataData()  ' trata a data exposta na tela
        Call filtro(1)     ' query de seleção inicial
        Call carregaList() ' carrega a lista de usuários
        If pop > 0 Then
            Me.lvMovimento.Items(0).Selected = True
            lvMovimento.Select()
        End If
    End Sub
    Private Sub btnEncerrado_Click(sender As Object, e As EventArgs) Handles btnEncerrado.Click
        ' SELECIONA OS REGISTROS ENCERRADOS
        'COMANDO = 3
        gatilho = 3
        Call TrataData()  ' trata a data exposta na tela
        Call filtro(1)     ' query de seleção inicial
        Call carregaList() ' carrega a lista de usuários
        If pop > 0 Then
            Me.lvMovimento.Items(0).Selected = True
            lvMovimento.Select()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FUN028 = "PRE"
        gatilho = 2
        Call TrataData()  ' trata a data exposta na tela
        Call filtro(1)     ' query de seleção inicial
        Call carregaList() ' carrega a lista de usuários
        If pop > 0 Then
            Me.lvMovimento.Items(0).Selected = True
            lvMovimento.Select()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FUN028 = "EMP"
        gatilho = 2
        Call TrataData()  ' trata a data exposta na tela
        Call filtro(1)     ' query de seleção inicial
        Call carregaList() ' carrega a lista de usuários
        If pop > 0 Then
            Me.lvMovimento.Items(0).Selected = True
            lvMovimento.Select()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FUN028 = "VIS"
        gatilho = 2
        Call TrataData()  ' trata a data exposta na tela
        Call filtro(1)     ' query de seleção inicial
        Call carregaList() ' carrega a lista de usuários
        If pop > 0 Then
            Me.lvMovimento.Items(0).Selected = True
            lvMovimento.Select()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FUN028 = "FUN"
        gatilho = 2
        Call TrataData()  ' trata a data exposta na tela
        Call filtro(1)     ' query de seleção inicial
        Call carregaList() ' carrega a lista de usuários
        If pop > 0 Then
            Me.lvMovimento.Items(0).Selected = True
            lvMovimento.Select()
        End If
    End Sub
    Private Sub DataSys_ValueChanged(sender As Object, e As EventArgs) Handles DataSys.ValueChanged
        Call TrataData()  ' trata a data exposta na tela
        filtro(1)
        Call carregaList() ' carrega a lista de usuários
        If pop > 0 Then
            Me.lvMovimento.Items(0).Selected = True
            lvMovimento.Select()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Call TrataData()  ' trata a data exposta na tela
        Call filtro(2)     ' query de seleção inicial
        Call carregaList() ' carrega a lista de usuários
        If pop > 0 Then
            Me.lvMovimento.Items(0).Selected = True
            lvMovimento.Select()
        End If
    End Sub
    Private Sub btnexecuta_Click(sender As Object, e As EventArgs) Handles btnexecuta.Click
        lvMovimento.Items.Clear()
        Select Case tarja.SelectedItem.ToString
            Case "Nome"
                filtro(3)
            Case "Empresa"
                filtro(4)
            Case "Placa Veiculo"
                filtro(5)
        End Select
        Call carregaList()
        tbPesq01.Focus()
        tbPesq01.SelectAll()
    End Sub

    Private Sub tbPesq01_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbPesq01.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            Select Case tarja.SelectedItem.ToString
                Case "Nome"
                    filtro(3)
                Case "Empresa"
                    filtro(4)
                Case "Placa Veiculo"
                    filtro(5)
            End Select
            Call carregaList()
            tbPesq01.Focus()
            tbPesq01.SelectAll()
        End If
    End Sub



    Private Sub tarja_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles tarja.SelectedIndexChanged
        lvMovimento.Items.Clear()
        If tarja.SelectedItem.ToString = "Filtro Avançado" Then
            tbPesq01.Visible = False
            btnexecuta.Visible = False
            tbPesq01.Clear()
            PanelOutros.Visible = True
            PanelOutros.Enabled = True

            PanelOutros.BringToFront()


            Panel1.Enabled = False
            Panel4.Visible = False
        Else
            tbPesq01.Visible = True
            btnexecuta.Visible = True
            tbPesq01.Clear()
            tbPesq01.Select()
        End If






    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If ARM002.Text <> Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, " Armário rotativo está sendo utilizado por esse registro:  [ " & ARM002.Text & " ] não esqueça de recolher a chave. ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If (MetroFramework.MetroMessageBox.Show(Me, " Será efetuada a baixa do funcionário no sistema. C O N F I R M A?", "" & legenda & "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)) = MsgBoxResult.Yes Then
            Try
                Call gravar(0) ' GRAVA A BAIXA NO TABELA prt_fass e replica comando atraves de triger na tabela prt_cadfun e prt_armarios
                MetroFramework.MetroMessageBox.Show(Me, " --- " & Me.lvMovimento.SelectedItems(0).SubItems(1).Text & " deu saida do empreendimento. ")
                Call carregaList() ' recarrega os dados no grid dos funcionários
                If pop > 0 Then
                    Me.lvMovimento.Items(0).Selected = True
                    lvMovimento.Select()
                    tbPesq01.Visible = False
                End If
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message)
            End Try
        End If
    End Sub

    Private Sub tbPesq01_TextChanged(sender As Object, e As EventArgs) Handles tbPesq01.TextChanged
        chave = ""
        chave = "%" & tbPesq01.Text
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        PanelOutros.Visible = False
        Panel1.Enabled = True
        Panel4.Enabled = True
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If pop > 0 Then
            frmObs02.FAS001.Text = lvMovimento.SelectedItems(0).SubItems(0).Text
            frmObs02.ShowDialog()
        End If
    End Sub

    Private Sub desce_Click(sender As Object, e As EventArgs) Handles desce.Click
        ' volta data de pesquisa
        sobe.Visible = True
        Call contaDIA(1)
        Call TrataData()  ' trata a data exposta na tela
        filtro(1)
        Call carregaList() ' carrega a lista de usuários
        If pop > 0 Then
            Me.lvMovimento.Items(0).Selected = True
            lvMovimento.Select()
        End If
    End Sub

    Private Sub sobe_Click(sender As Object, e As EventArgs) Handles sobe.Click
        ' sobe data de pesquisa
        If DataSys.Value <= Format(Data_hoje, "dd/MM/yyyy") Then
            Call contaDIA(0)
            Call TrataData()  ' trata a data exposta na tela
            filtro(1)
            Call carregaList() ' carrega a lista de usuários
            If pop > 0 Then
                Me.lvMovimento.Items(0).Selected = True
                lvMovimento.Select()
            End If
        Else
            sobe.Visible = False
        End If
    End Sub


#End Region












End Class
























