Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmLocacao
    Dim CADP019, CADP023, REGL006 As New TextBox
    Dim pop As Integer
    Dim grava As String
    Dim data_hoje As DateTime = DateAndTime.Now

    Private Sub frmLocacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = True
        CADP002.Text = Repositorio.CADP036.Text
        CADP003.Text = Repositorio.CADP003.Text
        CADP019.Text = Repositorio.CADP019.Text
        Call valida() ' VALIDA AS CONDIÇÕES PARA ACESSO AS INFORMAÇÕES
        Call Carregalist() ' CARREGA HISTORICO DE LOCAÇÕES DA UNIDADE
        If pop > 0 Then
            Me.lvReloc.Items(0).Selected = True
            lvReloc.Select()
        End If
    End Sub

#Region "FUNÇÕES"
    Private Sub valida()
        Call bloqueio(0)
        Select Case CADP019.Text
            Case "0"
                ' PROPRIETÁRIOS
                Panel1.Visible = False
                PBaixa.Visible = False
                Call botao(0)
            Case "1"
                ' POOLISTA
                Panel1.Visible = False
                PBaixa.Visible = False
                Call botao(1)
            Case "2"
                ' SUBSIDIÁRIO
                Panel1.Visible = False
                PBaixa.Visible = False
                Call botao(1)
            Case "3"
                ' BAIAS
                Panel1.Visible = False
                PBaixa.Visible = False
                Call botao(0)
            Case "4"
                ' LOCADOR
                Panel1.Visible = True
                PBaixa.Visible = False
                Call botao(2)
        End Select
    End Sub

    Private Sub botao(arg)
        Select Case arg
            Case 0
                btnnovo.Visible = True
                btncancela.Visible = False
                btnsave.Visible = False
                btnEncerraLoc.Visible = False
            Case 1
                btnnovo.Visible = False
                btncancela.Visible = False
                btnsave.Visible = False
                btnEncerraLoc.Visible = False
            Case 2
                btnnovo.Visible = False
                btncancela.Visible = False
                btnsave.Visible = False
                btnEncerraLoc.Visible = True
        End Select
    End Sub

    Private Sub bloqueio(arg)
        Select Case arg
            Case 0
                ' FAZ O BLOQUEIO DOS COMPONENTES
                btnPesq.Enabled = False
                CADL003.Enabled = False
                REGL003.Enabled = False
                REGL004.Enabled = False
                'REGL008.Enabled = False
            Case 1
                btnPesq.Enabled = True
                CADL003.Enabled = True
                REGL003.Enabled = True
                REGL004.Enabled = True
                'REGL008.Enabled = True
                CADL002.Clear()
                CADL003.Text = ""
                REGL008.Clear()
        End Select
    End Sub



    Private Sub geracod()
        ' gera código do proprietário
        Dim sqlmaior As String
        If conexao.State = ConnectionState.Closed Then conexao.Close()
        If conexao.State = 0 Then
            conexao.Open()
        End If
        sqlmaior = "Select Max(REGL002) From prt_regloc"
        Dim cmd As New MySqlCommand(sqlmaior, conexao)
        Dim maior As Integer
        If IsDBNull(cmd.ExecuteScalar) Then
            maior = 1
        Else
            maior = cmd.ExecuteScalar + 1
        End If
        cmd.ExecuteNonQuery()
        REGL002.Text = Format(maior, "0000000000")
        cmd.Dispose()
        conexao.Close()
    End Sub

    Private Sub Carregalist()
        lvReloc.Items.Clear()
        lvReloc.BackColor = Color.White

        conexao.Open()
        'Dim cmd As MySqlCommand = New MySqlCommand(" select * from prt_regloc as a left join prt_cadpro as b on (a.CADP002 = b.CADP002) where a.CADP002 = '" & CADP002.Text & "'", conexao)

        Dim cmd As MySqlCommand = New MySqlCommand(" select REGL001, REGL002, CADL002 from prt_regloc where CADP002 = '" & CADP002.Text & "'", conexao)


        Dim leitor As MySqlDataReader = cmd.ExecuteReader()
        pop = 0
        Do While leitor.Read()
            Dim item As New ListViewItem()
            item.Text = leitor(0)
            item = lvReloc.Items.Add(leitor("REGL001").ToString)        ' 0 - ID
            item.SubItems.Add(leitor("REGL002").ToString)               ' 1 - REGISTRO NO SISTEMA
            item.SubItems.Add(leitor("CADL002"))                        ' 2 - CÓDIGO NA TABELA PRT_CADPRO
            pop += 1
        Loop
        If pop > 0 Then
            Panel1.Visible = True
            btnPrinter.Visible = True
        Else
            btnPrinter.Visible = False
        End If
        conexao.Close() ' fecha a conexação com o banco de dados
        leitor.Dispose()
    End Sub

    Private Sub lvReloc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvReloc.SelectedIndexChanged
        Try
            If lvReloc.SelectedItems.Count > 0 Then
                Me.REGL002.Text = Me.lvReloc.SelectedItems(0).SubItems(1).Text
                Me.CADL002.Text = Me.lvReloc.SelectedItems(0).SubItems(2).Text
                Call buscadados() ' Busca os dados do cadastro de proprietários
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnPesq.Click
        alterado = 0
        frmPesq01.ShowDialog()
        If alterado > 0 Then
            CADL002.Text = Repositorio.CADL002.Text
            CADL003.Text = Repositorio.CADL003.Text
        End If
    End Sub

    Private Sub btnnovo_Click(sender As Object, e As EventArgs) Handles btnnovo.Click
        Call bloqueio(1)
        btnnovo.Visible = False
        img.Image = imgLimpa.Image
        Panel1.Visible = True
        btncancela.Visible = True
        btnsave.Visible = True
        REGL004.Value = REGL003.Value.AddDays(365)
        gbEnc.Visible = False
        REGL005.Visible = False
        Call geracod() ' GERA UM REGISTRO DE DOCUMENTO PARA O CONTRATO
    End Sub
    Private Sub gravar(arg)
        Select Case arg
            Case 0
                Dim cmd As New MySqlCommand("insert into prt_regloc(CADL002,CADP002,REGL002,REGL003,REGL004,REGL005,REGL006,CADP003,REGL008)VALUES('" & CADL002.Text & "','" & CADP002.Text & "','" & REGL002.Text & "','" & Format(REGL003.Value, "yyyy-MM-dd") & "','" & Format(REGL004.Value, "yyyy-MM-dd") & "','" & REGL005.Text & "','1','" & CADP003.Text & "','" & REGL008.Text & "')", conexao)
                cmd.ExecuteNonQuery()
            Case 1
                iREGL008.Text += data_hoje & " --- " & vbCrLf & vbCrLf & "   " & REGL008.Text
                Dim cmd As New MySqlCommand(" update prt_regloc SET REGL007 = '" & Format(REGL007.Value, "yyyy-MM-dd") & "', REGL008 = '" & iREGL008.Text & "', REGL006 = '0' where REGL002 = '" & REGL002.Text & "'", conexao)
                cmd.ExecuteNonQuery()
        End Select
    End Sub
    Private Sub testacampos()
        grava = "Não"
        If CADL002.Text = Nothing Or CADL002.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o nome do locatário! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            grava = "Não"
            btnPesq.PerformClick()
            Exit Sub
        End If
        If REGL003.Value >= REGL004.Value Then
            MetroFramework.MetroMessageBox.Show(Me, " A data inicial de locação não pode ser maior que a data final! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            grava = "Não"
            REGL003.Focus()
            Exit Sub
        End If
        If REGL004.Value <= REGL003.Value Then
            MetroFramework.MetroMessageBox.Show(Me, " A data final da locação não pode ser menor ou igual que a data inicial da locação! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            grava = "Não"
            REGL004.Focus()
            Exit Sub
        End If
        grava = "Sim"
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            Call testacampos()
            If grava = "Sim" Then
                conexao.Open()
                Call gravar(0)
                conexao.Close()
                MetroFramework.MetroMessageBox.Show(Me, " Registro da locação realizado com sucesso! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CADP019.Text = "4"
                Call valida() ' VALIDA AS CONDIÇÕES PARA ACESSO AS INFORMAÇÕES
                Call Carregalist() ' CARREGA HISTORICO DE LOCAÇÕES DA UNIDADE
                If pop > 0 Then
                    Me.lvReloc.Items(0).Selected = True
                    lvReloc.Select()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub buscadados()
        Dim SQL As String
        If conexao.State = 0 Then
            conexao.Open()
        End If
        Dim comando As New MySqlCommand("select a.REGL003,a.REGL004,a.REGL006,a.REGL007,a.REGL008,b.CADP003,b.CADP023 from prt_regloc AS a left join prt_cadpro AS b on (a.CADL002 = b.CADP002) where a.REGL002 = '" & REGL002.Text & "'", conexao)
        Dim leitor As MySqlDataReader = comando.ExecuteReader()
        While leitor.Read()

            REGL003.Value = IIf(Convert.IsDBNull(leitor("REGL003")) = True, "", leitor("REGL003")) ' 
            REGL004.Value = IIf(Convert.IsDBNull(leitor("REGL004")) = True, "", leitor("REGL004")) ' 

            REGL006.Text = IIf(Convert.IsDBNull(leitor("REGL006")) = True, "", leitor("REGL006")) ' 
            REGL008.Text = IIf(Convert.IsDBNull(leitor("REGL008")) = True, "", leitor("REGL008")) ' 
            CADL003.Text = IIf(Convert.IsDBNull(leitor("CADP003")) = True, "", leitor("CADP003")) ' 
            CADP023.Text = IIf(Convert.IsDBNull(leitor("CADP023")) = True, "", leitor("CADP023")) ' 

            img.ImageLocation = (My.Application.Info.DirectoryPath & "\file\owner\" & CADP023.Text & ".dat")

            If REGL006.Text = "1" Then
                REGL005.Text = "EM ANDAMENTO"
            Else
                REGL007.Value = (IIf(Convert.IsDBNull(leitor("REGL007")) = True, "", leitor("REGL007")))
                REGL005.Text = "E N C E R R A D O"
                gbEnc.Visible = True
                REGL008.Enabled = True
            End If

        End While
        comando.Cancel()
        leitor.Close()
        conexao.Close()
    End Sub


    Private Sub btnPrinter_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncancela_Click(sender As Object, e As EventArgs) Handles btncancela.Click
        Panel2.Visible = True
        Call valida() ' VALIDA AS CONDIÇÕES PARA ACESSO AS INFORMAÇÕES
        Call Carregalist() ' CARREGA HISTORICO DE LOCAÇÕES DA UNIDADE
        If pop > 0 Then
            Me.lvReloc.Items(0).Selected = True
            lvReloc.Select()
        End If
    End Sub

    Private Sub btnEncerraLoc_Click(sender As Object, e As EventArgs) Handles btnEncerraLoc.Click
        REGL007.Value = data_hoje
        iREGL008.Clear()
        PBaixa.Visible = True
        Panel2.Visible = False
        btncancela.Visible = True
        btnEncerraLoc.Visible = False
        btnPrinter.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (MetroFramework.MetroMessageBox.Show(Me, " Confirma o encerramento da locação ?" & CADL003.Text & " ?", "" & legenda & "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = MsgBoxResult.Yes Then
            conexao.Open()
            Call gravar(1)
            conexao.Close()
            MetroFramework.MetroMessageBox.Show(Me, " Registro baixado! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Panel2.Visible = True
            CADP019.Text = "0"
            Call valida() ' VALIDA AS CONDIÇÕES PARA ACESSO AS INFORMAÇÕES
            Call Carregalist() ' CARREGA HISTORICO DE LOCAÇÕES DA UNIDADE
            If pop > 0 Then
                Me.lvReloc.Items(0).Selected = True
                lvReloc.Select()
            End If
        End If
    End Sub
End Class
























