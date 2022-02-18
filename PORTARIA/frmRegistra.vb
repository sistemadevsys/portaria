Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmRegistra
    Dim Data_hoje As DateTime = DateTime.Now
    Dim sql, Sqlb As String
    Dim chave As String
    Dim filtro, opc, index As Integer
    Dim CADP001, CADP002, CADP003, CADP026, CADP027, CADP037, RES001 As New TextBox
    Dim pop As Integer
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

#Region "START DO FORMULÁRIO"
    Private Sub BEEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
    Private Sub escape_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            ' BOTÃO SALVAR O REGISTRO
            Call deletar()
            Me.Close()
        End If
    End Sub
    Private Sub frmRegistra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height - 77) / 2
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width + 445) / 2

        CON18.MinDate = Data_hoje

        If GAR005.Text = "OCUPADO" Then
            opc = OPC001
            filtro = FILTRO001

            If opc = 1 Then
                Call buscadados(0, 0) ' busca a referencia do locatário em prt_regloc
            End If

            GAR002.ForeColor = Color.Red
            GAR003.ForeColor = Color.Red

            P1.Visible = False
            P2.Visible = True

            rbprop.Visible = False
            rbLoc.Visible = False
            rbhosp.Visible = False
            rbLimpo.Visible = False

            Call geracod() ' gera a numeração do ticket de controle 
            Call limpaCampos(0) ' inicializa os componentes
            Call bloqueio(0)   ' bloqueia os campos editaveis
            tbPesquisa.Clear()
            Call carregaList()
            If pop > 0 Then
                Me.lvdados.Items(0).Selected = True
                lvdados.Select()
            End If
        Else
            GAR002.ForeColor = Color.Green
            GAR003.ForeColor = Color.Green
            rbprop.Visible = True
            rbLoc.Visible = True
            rbhosp.Visible = True
            rbLimpo.Visible = True

            P2.Visible = False
            P1.Visible = True

            rbLimpo.Checked = True
            GAR007.Enabled = True
            Call geracod() ' gera a numeração do ticket de controle 
            Call limpaCampos(0) ' inicializa os componentes
            Call bloqueio(0)   ' bloqueia os campos editaveis
        End If

    End Sub
#End Region

#Region "FUNÇÕES"
    Private Sub gravar(arg)
        Select Case arg
            Case 0
                ' GRAVA AS INFORMAÇÕES NA TABELA prt_acesscon
                Try
                    Dim cmd As New MySqlCommand("INSERT INTO prt_acesscon (CON02,CADP001,CON04,CON05,CON06,CON07,CON08,CON09,CON10,CON14,CON18,CADP002,GAR002,VEI002,CADP026,RES001,CADP037)values('" & CON02.Text & "','" & CADP001.Text & "','" & Format(Data_hoje, "yyyy-MM-dd") & "','" & DateTime.Now.ToLongTimeString().Substring(0, 5) & "','" & iUsername & "','" & CON07.Value & "','" & CON08.Value & "','" & CON09.Value & "','" & CON10.Text & "','" & CON14.Text & "','" & Format(CON18.Value, "yyyy-MM-dd") & "','" & iRef.Text & "','" & GAR002.Text & "','" & VEI002.Text & "','" & CADP026.Text & "','" & RES001.Text & "','" & CADP037.Text & "')", conexao)
                    conexao.Open()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, " Erro ao tentar gravar na tabela prt_acesscon" & ex.Message)
                Finally
                    MetroFramework.MetroMessageBox.Show(Me, " Registro efetuado com sucesso! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    conexao.Close()
                End Try
            Case 1

        End Select
    End Sub
    Private Sub filtrar()
        Select Case filtro
            Case 0 ' PROPRIETÁRIOS E DEPENDENTES
                sql = "SELECT CADP001,CADP003,CADP004,CADP026,CADP027,CADP023,RES001,CADP037 FROM prt_cadpro WHERE CADP028 = '0' AND REG_STATUS = '0' AND CADP002 = '" & iRef.Text & "' OR CADP036 = '" & iRef.Text & "' ORDER BY CADP026 desc"
            Case 1
                ' filtro de pesquisa para proprietários e autorizados
                sql = "SELECT CADP001,CADP003,CADP004,CADP026,CADP027,CADP023,RES001,CADP037 FROM prt_cadpro WHERE CADP028 = '0' AND REG_STATUS = '0' AND (CADP003 like '" & chave & "%') AND (CADP002 like '" & iRef.Text & "%' OR CADP036 like '" & iRef.Text & "%')"


            Case 2
                ' filtra os locatários de casas e apartamentos
                sql = "SELECT CADP001,CADP003,CADP004,CADP026,CADP027,CADP023,RES001,CADP037 FROM prt_cadpro WHERE CADP028 = '0' AND REG_STATUS = '0' AND CADP037 = '3' AND (CADP002 = '" & CADP002.Text & "' OR CADP036 = '" & CADP002.Text & "') ORDER BY CADP026 desc"
            Case 3
                sql = "SELECT CADP001,CADP003,CADP004,CADP026,CADP027,CADP023,RES001,CADP037 FROM prt_cadpro WHERE CADP028 = '0' AND REG_STATUS = '0' AND CADP037 = '3' AND (CADP003 like '" & chave & "%') AND (CADP002 like '" & CADP002.Text & "%' OR CADP036 like '" & CADP002.Text & "%')"


            Case 4
                ' filtra os hospedes
                If GAR005.Text = "OCUPADO" Then
                    sql = "SELECT a.CADP001,a.CADP003,a.CADP004,a.CADP026,a.CADP027,a.CADP023,a.RES001,a.CADP037 FROM prt_cadpro AS a LEFT JOIN prt_reserva AS b on (a.RES001 = b.RES001) WHERE a.CADP028 = '0' AND a.REG_STATUS = '0' AND a.CADP037 = '2' and b.RES007 = '0' and b.RES003 = '" & Format(Data_hoje, "yyyy-MM-dd") & "' and b.CADP002 = '" & iRef.Text & "' ORDER BY a.CADP003 asc"
                Else
                    sql = "SELECT a.CADP001,a.CADP003,a.CADP004,a.CADP026,a.CADP027,a.CADP023,a.RES001,a.CADP037 FROM prt_cadpro AS a LEFT JOIN prt_reserva AS b on (a.RES001 = b.RES001) WHERE a.CADP028 = '0' AND a.REG_STATUS = '0' AND a.CADP037 = '2' and b.RES007 = '0' and b.RES003 = '" & Format(Data_hoje, "yyyy-MM-dd") & "' ORDER BY a.CADP003 asc"
                End If
            Case 5
                If GAR005.Text = "OCUPADO" Then
                    sql = "SELECT a.CADP001,a.CADP003,a.CADP004,a.CADP026,a.CADP027,a.CADP023,a.RES001,a.CADP037 FROM prt_cadpro AS a LEFT JOIN prt_reserva AS b on (a.RES001 = b.RES001) WHERE a.CADP028 = '0' AND a.REG_STATUS = '0' AND a.CADP037 = '2' and (a.CADP003 like '" & chave & "%') and b.RES007 = '0' and b.RES003 = '" & Format(Data_hoje, "yyyy-MM-dd") & "' and b.CADP002 = '" & iRef.Text & "' ORDER BY a.CADP003 asc"
                Else
                    sql = "SELECT a.CADP001,a.CADP003,a.CADP004,a.CADP026,a.CADP027,a.CADP023,a.RES001,a.CADP037 FROM prt_cadpro AS a LEFT JOIN prt_reserva AS b on (a.RES001 = b.RES001) WHERE a.CADP028 = '0' AND a.REG_STATUS = '0' AND a.CADP037 = '2' and (a.CADP003 like '" & chave & "%') and b.RES007 = '0' and b.RES003 = '" & Format(Data_hoje, "yyyy-MM-dd") & "' ORDER BY a.CADP003 asc"
                End If
        End Select
    End Sub

    Private Sub geracod()
        Dim sqlmaior As String
        If conexao.State = 0 Then
            conexao.Open()
        End If
        sqlmaior = "Select Max(CON02) From prt_acesscon"
        Dim cmd As New MySqlCommand(sqlmaior, conexao)
        Dim maior As Integer
        If IsDBNull(cmd.ExecuteScalar) Then
            maior = "900000001"
        Else
            maior = cmd.ExecuteScalar + 1
        End If
        cmd.ExecuteNonQuery()
        CON02.Text = Format(maior, "000000000")
        cmd.Dispose()
        conexao.Close()
    End Sub
    Private Sub GAR007_Click(sender As Object, e As EventArgs) Handles GAR007.Click
        GAR007.Text = ""
        'Me.lvdados.Items.Clear()
        Call limpaCampos(1)
        Call bloqueio(0)
    End Sub

    Private Sub lvdados_DoubleClick(sender As Object, e As EventArgs) Handles lvdados.DoubleClick
        Call bloqueio(1) ' desbloqueia os campos para edição e direciona o foco para o campo CPF
        CADP011.Focus()
        CADP011.SelectAll()

    End Sub

    Private Sub lvdados_Click(sender As Object, e As EventArgs) Handles lvdados.Click
        Call bloqueio(0)
    End Sub


    Private Sub SP_Atuliza(arg)
        ' ACIONA PROCEDURE DENTRO DO BANCO DE DADOS PARA ATUALIZAR O CPF E RG QUANDO DIGITADO PELO PORTEIRO
        Select Case arg
            Case 0 ' CPF
                Try
                    conexao.Open()
                    Dim cmd As New MySqlCommand("sp_CPF", conexao)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("iCADP001", CADP001.Text)
                    cmd.Parameters.AddWithValue("iDoc", CADP011.Text)
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                Finally
                    conexao.Close()
                End Try
            Case 1 ' RG
                Try
                    conexao.Open()
                    Dim cmd As New MySqlCommand("sp_RG", conexao)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("iCADP001", CADP001.Text)
                    cmd.Parameters.AddWithValue("iDoc", CADP024.Text)
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                Finally
                    conexao.Close()
                End Try
            Case 2 ' Filtro da garagem ou estacionamento
                Try
                    Select Case opc
                        Case 0
                            filtro = 0
                        Case 1
                            filtro = 2
                        Case 2
                            filtro = 4
                    End Select
                    conexao.Open()
                    Dim cmd As New MySqlCommand("sp_GARFILTRO", conexao)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("iOPC", opc)
                    cmd.Parameters.AddWithValue("iFILTRO", filtro)
                    cmd.Parameters.AddWithValue("iGAR002", GAR002.Text)
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                Finally
                    conexao.Close()
                End Try

        End Select
    End Sub

    Private Sub bloqueio(arg)
        Select Case arg
            Case 0
                G1.Enabled = False
                G2.Enabled = False
                G3.Enabled = False
                VEI002.Enabled = False
                btnFoto.Enabled = False
                btnF5.Visible = False
            Case 1
                G1.Enabled = True
                G2.Enabled = True
                G3.Enabled = True
                VEI002.Enabled = True
                btnFoto.Enabled = True
                btnF5.Visible = True
        End Select
    End Sub


    Private Sub limpaCampos(arg)
        Select Case arg
            Case 0
                Data_hoje = Format(Data_hoje, "dd/MM/yyyy")
                img.Image = imgLimpa.Image
                lvdados.Items.Clear()
                P1.Visible = False
                CON18.MinDate = Data_hoje
                tbPesquisa.Clear()
                CADP011.Clear()
                CADP024.Clear()
                CON07.Value = 1
                CON08.Value = 0
                CON09.Value = 0
                CON10.Clear()
                CON18.Value = Data_hoje.AddDays(1)
                CON14.Clear()
                VEI002.Text = ""
                VEI002.BackColor = Color.AliceBlue
            Case 1
                img.Image = imgLimpa.Image
                lvdados.Items.Clear()
                tbPesquisa.Clear()
                CADP011.Clear()
                CADP024.Clear()
                VEI002.Text = ""
        End Select

    End Sub

    Private Sub carregaUnidade()
        Try
            Select Case opc
                Case 0
                    Sqlb = "select CADP002 from prt_cadpro where CADP019 = '0' AND CADP028 = '0' ORDER BY CADP002"
                Case 1
                    Sqlb = "select CADP002 from prt_regloc where REGL006 = '1' ORDER BY CADP002"
                Case 2
                    Sqlb = "select CADP002 from prt_reserva where RES007 = '0' ORDER BY CADP002"
            End Select
            Dim ds, Dset As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim adptr As New MySqlDataAdapter(Sqlb, conexao)
            adptr.Fill(ds, "tabela")
            dt = ds.Tables(0)
            GAR007.Text = ""
            GAR007.Items.Clear()
            For Each dr In dt.Rows
                GAR007.Items.Add(dr.Item("CADP002"))
            Next
            conexao.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub buscadados(arg, arg1)
        Select Case arg
            Case 0
                If conexao.State = 0 Then
                    conexao.Open()
                End If
                Dim comando As New MySqlCommand("select CADL002 from prt_regloc where cadp002 = '" & iRef.Text & "' and regl006 = '1'", conexao)
                Dim leitor As MySqlDataReader = comando.ExecuteReader()
                While leitor.Read()
                    CADP002.Text = IIf(Convert.IsDBNull(leitor("CADL002")) = True, "", leitor("CADL002")) ' NOME DA EMPRESA
                End While
                comando.Cancel()
                leitor.Close()
                conexao.Close()
            Case 1
                If conexao.State = 0 Then
                    conexao.Open()
                End If
                Dim comando As New MySqlCommand("select a.CADP002,a.RES004,a.RES005,a.RES006,b.CADP011,b.CADP020,b.CADP024,b.VEI002 from prt_reserva AS a inner join prt_cadpro AS b on (a.res001 = b.res001) where a.RES001 = '" & arg1 & "' and a.RES007 = '0'", conexao)
                Dim leitor As MySqlDataReader = comando.ExecuteReader()
                While leitor.Read()
                    iRef.Text = IIf(Convert.IsDBNull(leitor("CADP002")) = True, Data_hoje, leitor("CADP002")) ' NUMERO DA UNIDADE CASA APARTAMENTO ETC
                    GAR007.Text = IIf(Convert.IsDBNull(leitor("CADP002")) = True, Data_hoje, leitor("CADP002")) ' NUMERO DA UNIDADE CASA APARTAMENTO ETC
                    CADP011.Text = IIf(Convert.IsDBNull(leitor("CADP011")) = True, "", leitor("CADP011"))       ' CPF
                    CADP024.Text = IIf(Convert.IsDBNull(leitor("CADP024")) = True, "", leitor("CADP024"))       ' RG
                    CON07.Text = IIf(Convert.IsDBNull(leitor("RES005")) = True, "1", leitor("RES005"))          ' QUANTIDADE ADULTOS
                    CON08.Text = IIf(Convert.IsDBNull(leitor("RES006")) = True, "1", leitor("RES006"))          ' QUANTIDADE DE CRIANÇAS
                    CON18.Value = IIf(Convert.IsDBNull(leitor("RES004")) = True, Data_hoje, leitor("RES004"))   ' DATA PREVISTA PARA O CHECK-OUT
                    CON14.Text = IIf(Convert.IsDBNull(leitor("CADP020")) = True, "", leitor("CADP020"))         ' OBSERVAÇÕES NO CADASTRO DO HOSPEDE
                    VEI002.Text = IIf(Convert.IsDBNull(leitor("VEI002")) = True, "", leitor("VEI002"))          ' PLACA DO VEICULO
                End While
                comando.Cancel()
                leitor.Close()
                conexao.Close()
            Case 2
                If conexao.State = 0 Then
                    conexao.Open()
                End If
                Dim comando As New MySqlCommand("select CADP011,CADP024,CADP020,VEI002 FROM prt_cadpro where CADP001 = '" & arg1 & "' AND CADP028 = '0'", conexao)
                Dim leitor As MySqlDataReader = comando.ExecuteReader()
                While leitor.Read()
                    CADP011.Text = IIf(Convert.IsDBNull(leitor("CADP011")) = True, "", leitor("CADP011"))       ' CPF
                    CADP024.Text = IIf(Convert.IsDBNull(leitor("CADP024")) = True, "", leitor("CADP024"))       ' RG
                    CON14.Text = IIf(Convert.IsDBNull(leitor("CADP020")) = True, "", leitor("CADP020"))         ' OBSERVAÇÕES NO CADASTRO DO HOSPEDE
                    VEI002.Text = IIf(Convert.IsDBNull(leitor("VEI002")) = True, "", leitor("VEI002"))          ' PLACA DO VEICULO
                End While
                comando.Cancel()
                leitor.Close()
                conexao.Close()
        End Select
    End Sub

    Private Sub carregaList()
        Call filtrar()
        lvdados.Items.Clear()
        lvdados.BackColor = Color.White
        lvdados.GridLines = True
        lvdados.FullRowSelect = True
        lvdados.View = View.Details
        lvdados.Sorting = SortOrder.None
        conexao.Open()
        Dim cmd As MySqlCommand = New MySqlCommand(sql, conexao)
        Dim leitor As MySqlDataReader = cmd.ExecuteReader()
        Dim leitura As Integer = 0
        pop = 0
        Do While leitor.Read()
            Dim item As New ListViewItem()
            item.Text = leitor(0)
            item = lvdados.Items.Add(leitor("CADP003").ToString)  ' 0 NOME DO USUÁRIO
            item.SubItems.Add(leitor("CADP027").ToString)         ' 1 CLASSIFICAÇÃO
            item.SubItems.Add(leitor("CADP026").ToString)         ' 2 CLASSIFICAÇÃO
            item.SubItems.Add(leitor("CADP023").ToString)         ' 3 CAMINHA DA FOTO
            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("RES001")) = True, "0", leitor("RES001"))) ' 4- NUMERO DA RESERVA ID prt_reserva
            item.SubItems.Add(leitor("CADP001").ToString)         ' 5 ID DO REGISTRO NA TABELA PRT_CADPRO
            item.SubItems.Add(leitor("CADP037").ToString)         ' 6 ID DO REGISTRO NA TABELA PRT_CADPRO

            pop += 1 ' faz a contagem dos registros no listview
        Loop
        Call corlist(0)
        conexao.Close() ' fecha a conexação com o banco de dados
        leitor.Dispose()
    End Sub


    Private Sub corlist(arg)
        Select Case arg
            Case 0
                ' MUDA A COR DA LINHA QUANDO É PROPRIETÁRIO DA UNIDADE
                For i As Integer = 0 To lvdados.Items.Count - 1
                    lvdados.Items(i).UseItemStyleForSubItems = False
                    If lvdados.Items(i).SubItems.Count > 1 Then
                        Select Case lvdados.Items(i).SubItems(2).Text.ToString
                            Case "PRO"
                                lvdados.Items(i).SubItems(0).ForeColor = Color.Red  ' 
                                lvdados.Items(i).SubItems(1).ForeColor = Color.Red
                        End Select
                    End If
                Next
            Case 1

        End Select
    End Sub

#End Region

#Region "COMPONENTES"
    Private Sub rbprop_CheckedChanged(sender As Object, e As EventArgs) Handles rbprop.CheckedChanged
        ' PROCESSA OS PROPRIETÁRIOS
        Call limpaCampos(0)
        Call bloqueio(0)
        opc = 0
        filtro = 0
        Button2.Text = "Relação de Proprietários / Dependentes / Autorizados"
        P1.Visible = True
        Call carregaUnidade()
        GAR007.Enabled = True
        GAR007.Focus()
    End Sub
    Private Sub rbLoc_CheckedChanged(sender As Object, e As EventArgs) Handles rbLoc.CheckedChanged
        ' PROCESSA OS LOCATÁRIOS
        Button2.Text = "Relação de Locatários / Dependentes / Autorizados"
        Call limpaCampos(0)
        Call bloqueio(0)
        opc = 1
        filtro = 2
        P1.Visible = True
        Call carregaUnidade()
        GAR007.Enabled = True
        GAR007.Focus()
    End Sub
    Private Sub rbhosp_CheckedChanged(sender As Object, e As EventArgs) Handles rbhosp.CheckedChanged
        ' PROCESSA OS HOSPEDES COM RESERVA PARA A DATA ATUAL
        Call limpaCampos(0)
        Call bloqueio(0)
        Button2.Text = "Relação de hospedes com reserva para hoje"
        opc = 2
        filtro = 4
        P1.Visible = True
        GAR007.Enabled = False
        Call carregaList()
        If pop > 0 Then
            Me.lvdados.Items(0).Selected = True
            lvdados.Select()
        End If
    End Sub
    Private Sub tbPesquisa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPesquisa.KeyPress
        Select Case opc
            Case 0
                filtro = 1
            Case 1
                filtro = 3
                Call buscadados(0, 0) ' busca a referencia do locatário em prt_regloc
            Case 2
                filtro = 5
        End Select
    End Sub

    Private Sub tbPesquisa_TextChanged(sender As Object, e As EventArgs) Handles tbPesquisa.TextChanged
        chave = ""
        chave = "%" & tbPesquisa.Text
        Call carregaList()
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub btnF5_Click(sender As Object, e As EventArgs) Handles btnF5.Click
        ' GRAVA AS INFORMAÇÕES NA TABELA
        If VEI002.Text = Nothing Then
            If (MetroFramework.MetroMessageBox.Show(Me, " Não foi informado o veículo. Deseja continuar mesmo assim ?", "" & legenda & "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = MsgBoxResult.Yes Then
                Call gravar(0)     ' GRAVA AS INFORMAÇÕES NA TABELA PRT_CADPRO - DEPOIS ACIONA PROCEDURES DE ATUALIZAÇÕES DENTRO DO BANCO DE DADOS
                Call SP_Atuliza(2) ' ATUALIZA OS FILTROS DAS VAGAS
                alterado = 500
                Me.Close()
            Else
                VEI002.PerformClick()
            End If
        Else
            Call gravar(0)     ' GRAVA AS INFORMAÇÕES NA TABELA PRT_CADPRO - DEPOIS ACIONA PROCEDURES DE ATUALIZAÇÕES DENTRO DO BANCO DE DADOS
            Call SP_Atuliza(2) ' ATUALIZA OS FILTROS DAS VAGAS
            alterado = 500
            Me.Close()
        End If
    End Sub

    Private Sub deletar()
        Dim cmd As New MySqlCommand("DELETE FROM prt_acpt where CON02 = '" & CON02.Text & "'", conexao)
        conexao.Open()
        cmd.ExecuteNonQuery()
        conexao.Close()

        alterado = 0
        Me.Close()
    End Sub


    Private Sub btnF7_Click(sender As Object, e As EventArgs) Handles btnF7.Click
        ' CANCELA AS AÇÕES E ENCERRA O FORMULÁRIO
        Call deletar()
        Me.Close()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Select Case opc
            Case 0
                filtro = 0
            Case 1
                filtro = 2
                Call buscadados(0, 0) ' busca a referencia do locatário em prt_regloc
            Case 2
                filtro = 4
        End Select

        tbPesquisa.Clear()
        Call carregaList()
        If pop > 0 Then
            Me.lvdados.Items(0).Selected = True
            lvdados.Select()
        End If
    End Sub
    Private Sub Lvdados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvdados.SelectedIndexChanged
        Try
            If lvdados.SelectedItems.Count > 0 Then
                index = lvdados.Items.Item(lvdados.SelectedIndices(0)).Index
                Me.CADP003.Text = Me.lvdados.SelectedItems(0).SubItems(0).Text
                CADP002.Text = iRef.Text
                Me.RES001.Text = Me.lvdados.SelectedItems(0).SubItems(4).Text
                Me.CADP001.Text = Me.lvdados.SelectedItems(0).SubItems(5).Text
                Me.CADP026.Text = Me.lvdados.SelectedItems(0).SubItems(2).Text
                Me.CADP037.Text = Me.lvdados.SelectedItems(0).SubItems(6).Text

                If lvdados.SelectedItems(0).SubItems(2).Text = "HOS" Then
                    Call buscadados(1, lvdados.SelectedItems(0).SubItems(4).Text) ' BUSCA OS DADOS DE HOSPEDES E RESERVAS
                Else
                    Call buscadados(2, lvdados.SelectedItems(0).SubItems(5).Text) ' BUSCA OS DADOS DE OUTROS USUÁRIOS
                End If

                If Me.lvdados.SelectedItems(0).SubItems(3).Text = "REGISTRO" Then
                    img.Image = imgLimpa.Image
                Else
                    img.ImageLocation = (My.Application.Info.DirectoryPath & "\file\owner\" & Me.lvdados.SelectedItems(0).SubItems(3).Text & ".dat")
                End If
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region

#Region "ENTER"

    Private Sub CADP011_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP011.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If CADP011.MaskCompleted = False Or CADP011.Text = "   .   .   -" Then
                MetroFramework.MetroMessageBox.Show(Me, " Número do CPF é obrigatório! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CADP011.Focus()
            Else
                Call SP_Atuliza(0)
                CADP024.Focus()
            End If
        End If
    End Sub

    Private Sub CADP024_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CADP024.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then

            If CADP024.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Número do RG é obrigatório! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CADP024.Focus()
            Else
                Call SP_Atuliza(1)
                CON07.Select()
            End If
        End If
    End Sub

    Private Sub btnAcp_Click(sender As Object, e As EventArgs) Handles btnAcp.Click
        Dim QtdeAcpt As Integer

        QtdeAcpt = (CON07.Value - 1) + CON08.Value

        If QtdeAcpt < 1 Or QtdeAcpt = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Não existem acompanhantes para cadastrar. Verifique a quantidade de pessoas informada no cadastro. ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            frmAcompanhante.cadp003.text = CADP003.Text
            frmAcompanhante.CON07.Text = CON07.Value - 1
            frmAcompanhante.CON08.Text = CON08.Value
            iCON02 = CON02.Text
            Repositorio.CADP001.Text = CADP001.Text
            frmAcompanhante.ShowDialog()
        End If


    End Sub

    Private Sub CON07_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CON07.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If CON07.Value = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe a quantidade de adultos ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CON07.Select()
            Else
                CON08.Select()
            End If
        End If
    End Sub

    Private Sub CON08_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CON08.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            CON09.Select()
        End If
    End Sub

    Private Sub CON09_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CON09.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If CON09.Value = 0 Then
                CON10.Enabled = False
                CON18.Select()
            Else
                CON10.Enabled = True
                CON10.Focus()
            End If

        End If
    End Sub

    Private Sub CON10_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CON10.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If CON09.Value > 0 And CON10.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe a descrição básica do animal informado... ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CON10.Focus()
            Else
                CON18.Select()
            End If
        End If
    End Sub

    Private Sub CON18_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CON18.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            VEI002.BackColor = Color.FromArgb(238, 132, 151)
            VEI002.Select()
        End If
    End Sub

    Private Sub tbPesquisa_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbPesquisa.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If pop > 0 Then
                Me.lvdados.Items(0).Selected = True
                lvdados.Select()
            End If
        End If
    End Sub

    Private Sub VEI002_Click(sender As Object, e As EventArgs) Handles VEI002.Click
        frmVeiculos.VEI002.Text = VEI002.Text
        frmVeiculos.ShowDialog()
        CON14.Clear()
        CON14.Focus()
    End Sub

    Private Sub BtnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        Aviso08.CADP026.Text = CADP026.Text
        Aviso08.CADP002.Text = CADP002.Text
        Aviso08.CADP001.Text = CADP001.Text
        Aviso08.CADP003.Text = CADP003.Text
        alterado = 0
        Aviso08.ShowDialog()
        If alterado > 0 Then
            Call carregaList() ' popula o grid de cadastro das garagens
            If pop > 0 Then
                Me.lvdados.Items(index).Selected = True
                lvdados.Select()
            End If
        Else
            Me.lvdados.Items(index).Selected = True
            lvdados.Select()
        End If
    End Sub

    Private Sub GAR007_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles GAR007.KeyDown
        ' NOME DO PROPRIETÁRIO
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            Dim maior As Integer = GAR007.Text
            GAR007.Text = Format(maior, "000000")

            If Me.GAR007.FindString(GAR007.Text) = -1 Or GAR007.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Me, " Unidade inválida. Verifique! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GAR007.Focus()
            Else

                iRef.Text = GAR007.Text

                If opc = 1 Then
                    Call buscadados(0, 0) ' busca a referencia do locatário em prt_regloc
                End If
                Call carregaList()
                If pop > 0 Then
                    Me.lvdados.Items(0).Selected = True
                    lvdados.Select()
                End If
            End If
        End If
    End Sub
#End Region






End Class
























