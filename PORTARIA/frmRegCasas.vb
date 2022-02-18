Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmRegCasas
    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Protected regionHandle As IntPtr

    Dim Data_hoje As DateTime = DateTime.Now
    Dim popAs As Integer
    Dim index As Integer
    Dim CON01, CON02, CADP001, CON006, VEI008, CON14, junta, CADP003, CADP026 As New TextBox
    Dim PLACA As New TextBox
    Dim label2 As New TextBox
    Dim pop As Integer
    Private Sub BEEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FrmRegCasas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tarja.Text = " " & Trim(Repositorio.GAR002.Text) & "   -   " & Trim(Repositorio.GAR003.Text) & "     UNIDADE: " & Trim(Repositorio.CADP002.Text)

        redondo(0, 0, Tabelas, 20, 20)

        Data_hoje = Format(Data_hoje, "dd/MM/yyyy")
        GAR002.Text = Repositorio.GAR002.Text
        CADP002.Text = Repositorio.CADP002.Text

        Call carregalist(0)
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If

    End Sub


#Region "LISTVIEW"
    Private Sub carregalist(arg)
        Select Case arg
            Case 0
                'Call filtrar()
                lvDados.Items.Clear()
                lvDados.GridLines = False
                lvDados.FullRowSelect = True
                lvDados.View = View.Details
                lvDados.Sorting = SortOrder.None
                lvDados.SmallImageList = ImageGrid
                conexao.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("SELECT a.CON01,a.CON02,a.CON006,b.CADP003,b.CADP023,b.CADP026,b.CADP027 FROM prt_acesscon as a inner join prt_cadpro as b on (a.CADP001 = b.CADP001) where a.GAR002 = '" & GAR002.Text & "' AND a.CON17 = '1'", conexao)
                Dim leitor As MySqlDataReader = cmd.ExecuteReader()
                Dim leitura As Integer = 0
                pop = 0
                Dim a001 As String = ""
                Do While leitor.Read()
                    Dim item As New ListViewItem()
                    item.Text = leitor(0)
                    item = lvDados.Items.Add(a001)                      ' 0 ID
                    item.SubItems.Add(leitor("CADP003").ToString)       ' 1 NOME
                    item.SubItems.Add(leitor("CON01").ToString)         ' 2 NOME
                    item.SubItems.Add(leitor("CADP023").ToString)       ' 3 NOME DA FOTO DO USUÁRIO
                    item.SubItems.Add(leitor("CON006").ToString)        ' 4 SE ESTÁ NA CASA OU FORA DA CASA
                    item.SubItems.Add(leitor("CADP027").ToString)       ' 5 CLASSIFICAÇÃO
                    item.SubItems.Add(leitor("CON02").ToString)         ' 6 NUMERO DO TICKET
                    item.SubItems.Add(leitor("CADP026").ToString)       ' 7 CLASSIFICAÇÃO
                    pop += 1 ' faz a contagem dos registros no listview
                Loop
                conexao.Close() ' fecha a conexação com o banco de dados
                leitor.Dispose()
                Call corlist(0)
            Case 1
                lvacesso.Items.Clear()
                lvacesso.GridLines = True
                lvacesso.FullRowSelect = True
                lvacesso.View = View.Details
                lvacesso.Sorting = SortOrder.None
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

                    item = lvacesso.Items.Add(leitor("CON03"))          ' 0 DATA
                    item.SubItems.Add(leitor("CON04").ToString)         ' 1 HORA
                    item.SubItems.Add(leitor("CON05").ToString)         ' 2 PORTEIRO
                    item.SubItems.Add(CON006.Text)                      ' 3 ENTRADA/SAÍDA
                    item.SubItems.Add(leitor("GAR002").ToString)
                    popAs += 1 ' faz a contagem dos registros no listview

                Loop
                conexao.Close() ' fecha a conexação com o banco de dados
                leitor.Dispose()
        End Select
    End Sub
    Private Sub LvDados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDados.SelectedIndexChanged
        Try
            If lvDados.SelectedItems.Count > 0 Then
                index = lvDados.Items.Item(lvDados.SelectedIndices(0)).Index
                Me.CADP003.Text = Me.lvDados.SelectedItems(0).SubItems(1).Text
                Me.CON01.Text = Me.lvDados.SelectedItems(0).SubItems(2).Text
                Me.CON02.Text = Me.lvDados.SelectedItems(0).SubItems(6).Text
                Me.CON006.Text = Me.lvDados.SelectedItems(0).SubItems(4).Text
                Me.CADP027.Text = Me.lvDados.SelectedItems(0).SubItems(5).Text
                Me.CADP026.Text = Me.lvDados.SelectedItems(0).SubItems(7).Text
                If Me.lvDados.SelectedItems(0).SubItems(3).Text = "REGISTRO" Then
                    img.Image = imgLimpa.Image
                Else
                    img.ImageLocation = (My.Application.Info.DirectoryPath & "\file\owner\" & Me.lvDados.SelectedItems(0).SubItems(3).Text & ".dat")
                End If

                If CON006.Text = "2" Then
                    btnEncerra.Visible = False
                Else
                    btnEncerra.Visible = True
                End If

                Call buscadados(0) ' BUSCA OS DADOS DE REGISTRO NA PORTARIA
                Call corTextbox() ' MUDA A COR DO TEXTO EM FUNÇÃO DA CONDIÇÃO
                label2.Text = ixGar011
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lvDados_DoubleClick(sender As Object, e As EventArgs) Handles lvDados.DoubleClick
        If CON006.Text = "1" Then
            CON006.Text = "2"
        ElseIf CON006.Text = "2" Then
            CON006.Text = "1"
        End If

        Call SP_Atualiza(1) ' dispara a procedure no banco para registro da entrada ou saida do veiculo
        Call SP_Atualiza(2) ' Atualiza a tabela prt_reglog atraves da procedure sp_reglog no banco de dados
        Call carregalist(0)

        If pop > 0 Then
            Me.lvDados.Items(index).Selected = True
            lvDados.Select()
        End If

    End Sub

#End Region

#Region "FUNÇÕES"
    Private Sub redondo(arg1, arg2, componente, arg3, arg4)
        regionHandle = New IntPtr(CreateRoundRectRgn(arg1, arg2, componente.Width, componente.Height, arg3, arg4))
        componente.Region = Region.FromHrgn(regionHandle)
        componente.Region.ReleaseHrgn(regionHandle)
    End Sub
    Private Sub corlist(arg)
        Select Case arg
            Case 0
                For i As Integer = 0 To lvDados.Items.Count - 1
                    lvDados.Items(i).UseItemStyleForSubItems = False
                    If lvDados.Items(i).SubItems.Count > 1 Then
                        If lvDados.Items(i).SubItems(4).Text.ToString = "1" Then
                            lvDados.Items(i).ImageIndex = 0
                        ElseIf lvDados.Items(i).SubItems(4).Text.ToString = "2" Then
                            lvDados.Items(i).ImageIndex = 1
                        End If
                    End If
                Next
            Case 1

        End Select
    End Sub

    Private Sub BtnEncerra_Click(sender As Object, e As EventArgs) Handles btnEncerra.Click
        gatilho = 0 ' faz o disparo para atualizar a garagem no gride de registro de garagens
        If (MetroFramework.MetroMessageBox.Show(Me, " O registro será encerrado. Confirma ?  ", "" & legenda & "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = MsgBoxResult.Yes Then
            gatilho = 500

            ixGar011 -= 1 ' RETIRA UM CARRO DA GARAGEM

            Call SP_Atualiza(3) ' FAZ O CHECK OUT NAS VAGAS
            Call SP_Atualiza(4) ' ATUALIZA AS INFORMAÇÕES NA TABELA prt_acesscon

            MetroFramework.MetroMessageBox.Show(Me, " O Registro foi baixado com sucesso", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call carregalist(0)
            If pop > 0 Then
                Me.lvDados.Items(0).Selected = True
                lvDados.Select()
            End If

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Aviso08.CADP026.Text = CADP026.Text
        Aviso08.CADP002.Text = CADP002.Text
        Aviso08.CADP001.Text = CADP001.Text
        Aviso08.CADP003.Text = CADP003.Text
        alterado = 0
        Aviso08.ShowDialog()
        If alterado > 0 Then
            Call carregalist(0) ' popula o grid de cadastro das garagens
            If pop > 0 Then
                Me.lvDados.Items(index).Selected = True
                lvDados.Select()
            End If
        Else
            Me.lvDados.Items(index).Selected = True
            lvDados.Select()
        End If
    End Sub



    Private Sub corTextbox()
        If CON006.Text = "1" Then
            GAR002.ForeColor = Color.FromArgb(0, 108, 68)
            CADP002.ForeColor = Color.FromArgb(0, 108, 68)
            CADP027.ForeColor = Color.FromArgb(0, 108, 68)
            VEI002.ForeColor = Color.FromArgb(0, 108, 68)
            CON07.ForeColor = Color.FromArgb(0, 108, 68)
            CON08.ForeColor = Color.FromArgb(0, 108, 68)
            CON09.ForeColor = Color.FromArgb(0, 108, 68)
            CON10.ForeColor = Color.FromArgb(0, 108, 68)
            CON04.ForeColor = Color.FromArgb(0, 108, 68)
            CON05.ForeColor = Color.FromArgb(0, 108, 68)
            CON06.ForeColor = Color.FromArgb(0, 108, 68)
        ElseIf CON006.Text = "2" Then
            GAR002.ForeColor = Color.FromArgb(214, 0, 0)
            CADP002.ForeColor = Color.FromArgb(214, 0, 0)
            CADP027.ForeColor = Color.FromArgb(214, 0, 0)
            VEI002.ForeColor = Color.FromArgb(214, 0, 0)
            CON07.ForeColor = Color.FromArgb(214, 0, 0)
            CON08.ForeColor = Color.FromArgb(214, 0, 0)
            CON09.ForeColor = Color.FromArgb(214, 0, 0)
            CON10.ForeColor = Color.FromArgb(214, 0, 0)
            CON04.ForeColor = Color.FromArgb(214, 0, 0)
            CON05.ForeColor = Color.FromArgb(214, 0, 0)
            CON06.ForeColor = Color.FromArgb(214, 0, 0)
        End If

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOBS.Click
        If pop > 0 Then
            alterado = 0

            frmLivro01.iCON14.Text = CON14.Text
            frmLivro01.CON01.Text = CON01.Text
            frmLivro01.ShowDialog()

            If alterado > 0 Then
                Call carregalist(0)
                If pop > 0 Then
                    Me.lvDados.Items(index).Selected = True
                    lvDados.Select()
                End If
            End If
        End If
    End Sub

    Private Sub buscadados(arg)
        Select Case arg
            Case 0
                If conexao.State = 0 Then
                    conexao.Open()
                End If
                Dim comando As New MySqlCommand("select a.CADP001,a.VEI002,a.CON07,a.CON08,a.CON09,a.CON10,a.CON04,a.CON05,a.CON06,a.CON14,b.VEI008,c.GAR011 from prt_acesscon AS a LEFT join prt_veiculos AS b on (a.VEI002 = b.VEI002) inner join prt_garagens AS c on (a.GAR002 = c.GAR002) where a.CON01 = '" & CON01.Text & "'", conexao)

                'Dim comando As New MySqlCommand("select CADP001,VEI002,CON07,CON08,CON09,CON10,CON04,CON05,CON06 from prt_acesscon where CON01 = '" & CON01.Text & "'", conexao)

                Dim leitor As MySqlDataReader = comando.ExecuteReader()
                While leitor.Read()
                    CADP001.Text = IIf(Convert.IsDBNull(leitor("CADP001")) = True, "", leitor("CADP001"))
                    VEI002.Text = IIf(Convert.IsDBNull(leitor("VEI002")) = True, "", leitor("VEI002"))
                    VEI008.Text = IIf(Convert.IsDBNull(leitor("VEI008")) = True, "REGISTRO", leitor("VEI008"))
                    CON07.Text = IIf(Convert.IsDBNull(leitor("CON07")) = True, "", leitor("CON07"))
                    CON08.Text = IIf(Convert.IsDBNull(leitor("CON08")) = True, "", leitor("CON08"))
                    CON09.Text = IIf(Convert.IsDBNull(leitor("CON09")) = True, "", leitor("CON09"))
                    CON10.Text = IIf(Convert.IsDBNull(leitor("CON10")) = True, "", leitor("CON10"))
                    CON04.Text = IIf(Convert.IsDBNull(leitor("CON04")) = True, "", leitor("CON04"))
                    CON05.Text = IIf(Convert.IsDBNull(leitor("CON05")) = True, "", leitor("CON05"))
                    CON06.Text = IIf(Convert.IsDBNull(leitor("CON06")) = True, "", leitor("CON06"))
                    CON14.Text = IIf(Convert.IsDBNull(leitor("CON14")) = True, "", leitor("CON14"))

                    ixGar011 = IIf(Convert.IsDBNull(leitor("GAR011")) = True, "", leitor("GAR011"))

                    VEI002.Text = "          " & VEI002.Text


                    imgCar.ImageLocation = (My.Application.Info.DirectoryPath & "\file\car\" & Trim(VEI008.Text) & ".dat")

                End While
                comando.Cancel()
                leitor.Close()
                conexao.Close()
            Case 1

                If conexao.State = 0 Then
                    conexao.Open()
                End If
                Dim comando As New MySqlCommand("select VEI003,VEI004 FROM prt_veiculos where VEI002 = '" & VEI002.Text & "'", conexao)

                Dim leitor As MySqlDataReader = comando.ExecuteReader()
                While leitor.Read()
                    'VEI003.Text = IIf(Convert.IsDBNull(leitor("VEI003")) = True, "", leitor("VEI003"))
                    'VEI004.Text = IIf(Convert.IsDBNull(leitor("VEI004")) = True, "", leitor("VEI004"))
                End While
                comando.Cancel()
                leitor.Close()
                conexao.Close()
        End Select
    End Sub

    Private Sub SP_Atualiza(arg)
        Select Case arg
            Case 0
                Try
                    junta.Text += vbCrLf
                    junta.Text += "Alteração dos dados do veículo:" & vbCrLf
                    junta.Text += "----------------------------------------------------------------------------------------------------------------------------" & vbCrLf
                    junta.Text += "Data:   " & Data_hoje & "   Hora:   " & DateTime.Now.ToLongTimeString().Substring(0, 5) & "   Porteiro:   " & iUsername & vbCrLf
                    junta.Text += "Placa Anterior:   " & PLACA.Text & "   Nova Placa:   " & VEI002.Text & vbCrLf
                    junta.Text += CON14.Text
                    junta.Text += "----------------------------------------------------------------------------------------------------------------------------" & vbCrLf
                    CON14.Clear()
                    CON14.Text = junta.Text

                    conexao.Open()
                    Dim cmd As New MySqlCommand("sp_VEICULO", conexao)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("iCADP001", CADP001.Text)
                    cmd.Parameters.AddWithValue("iVEI002", VEI002.Text)
                    cmd.Parameters.AddWithValue("iCON01", CON01.Text)
                    cmd.Parameters.AddWithValue("iCON14", CON14.Text)
                    cmd.ExecuteNonQuery()

                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                Finally
                    MetroFramework.MetroMessageBox.Show(Me, " Veiculo foi alterado com sucesso! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    conexao.Close()
                End Try
            Case 1
                Try
                    conexao.Open()
                    Dim cmd As New MySqlCommand("sp_ENTRA_SAI", conexao)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("iCON01", CON01.Text)
                    cmd.Parameters.AddWithValue("iCON15", iUsername)
                    cmd.Parameters.AddWithValue("iCON006", CON006.Text)
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                Finally
                    conexao.Close()
                End Try
            Case 2
                Try
                    conexao.Open()
                    Dim cmd As New MySqlCommand("sp_REGLOG", conexao)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("iCON02", CON02.Text)
                    cmd.Parameters.AddWithValue("iCON03", Format(Data_hoje, "yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("iCON04", DateTime.Now.ToLongTimeString().Substring(0, 5))
                    cmd.Parameters.AddWithValue("iCON05", iUsername)
                    cmd.Parameters.AddWithValue("iCON006", CON006.Text)
                    cmd.Parameters.AddWithValue("iGAR002", GAR002.Text)
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                Finally
                    conexao.Close()
                End Try
            Case 3
                Try
                    conexao.Open()
                    Dim cmd As New MySqlCommand("sp_LIBPRO", conexao)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("iCADP001", CADP001.Text)
                    cmd.Parameters.AddWithValue("iGAR002", GAR002.Text)
                    cmd.Parameters.AddWithValue("iGAR011", ixGar011)
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                Finally
                    conexao.Close()
                End Try
            Case 4
                Try
                    conexao.Open()
                    Dim cmd As New MySqlCommand("sp_REGISTRA", conexao)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("iCON01", CON01.Text) ' ID DO REGISTRO NA TABELA 
                    cmd.Parameters.AddWithValue("iCON11", Format(Data_hoje, "yyyy-MM-dd")) ' DATA DO ENCERRAMENTO
                    cmd.Parameters.AddWithValue("iCON12", DateTime.Now.ToLongTimeString().Substring(0, 5)) ' HORA DO ENCERRAMENTO 
                    cmd.Parameters.AddWithValue("iCON13", iUsername) ' PORTEIRO
                    cmd.Parameters.AddWithValue("iCON17", 0) ' STATUS
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                Finally
                    conexao.Close()
                End Try

        End Select
    End Sub


    Private Sub Tabelas_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles Tabelas.SelectedIndexChanged
        Call tratatab()
    End Sub

    Private Sub tratatab()
        Select Case Tabelas.SelectedTab.Name
            Case "Tab01"
                If pop > 0 Then
                    Me.lvDados.Items(index).Selected = True
                    lvDados.Select()
                End If
            Case "Tab02"
                iCON04.Text = CON04.Text
                iCON05.Text = CON05.Text
                iCON06.Text = CON06.Text
                iCADP002.Text = CADP002.Text
                iCADP003.Text = CADP003.Text
                Call buscadados(1) ' BUSCA OS DADOS DO VEICULOS
                Call carregalist(1) ' CARREGA OS DADOS DA MOVIMENTAÇÃO DO REGISTRO
                If popAs > 0 Then
                    Me.lvacesso.Items(0).Selected = True
                    lvacesso.Select()
                End If
        End Select
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub VEI002_Click(sender As Object, e As EventArgs) Handles VEI002.Click
        'alterado = 0
        'PLACA.Text = VEI002.Text
        'frmVeiculos.VEI002.Text = VEI002.Text
        'frmVeiculos.ShowDialog()
        'If alterado > 0 Then
        '    VEI002.Text = Repositorio.VEI002.Text
        '    Call SP_Atualiza(0)
        'End If


        alterado = 0
        PLACA.Text = VEI002.Text
        frmVeiculos.VEI002.Text = Trim(VEI002.Text)
        frmVeiculos.ShowDialog()

        If alterado > 0 Then
            VEI002.Text = Repositorio.VEI002.Text
            Call SP_Atualiza(0)
        End If



    End Sub
#End Region

#Region "COMPONENTES"
    Private Sub imgCar_DoubleClick(sender As Object, e As EventArgs) Handles imgCar.DoubleClick
        frmAmplia01.VEI002.Text = VEI002.Text
        frmAmplia01.ShowDialog()
    End Sub

    Private Sub img_DoubleClick(sender As Object, e As EventArgs) Handles img.DoubleClick
        frmAmplia02.CADP002.Text = CADP002.Text
        frmAmplia02.CADP003.Text = CADP003.Text
        frmAmplia02.CADP001.Text = CADP001.Text
        frmAmplia02.ShowDialog()
    End Sub

#End Region





End Class
























