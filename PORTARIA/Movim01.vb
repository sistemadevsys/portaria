Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class Movim01
    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Protected regionHandle As IntPtr

    Dim FUN002, FUN003, IMG006 As New Label
    Dim pop As Integer
    Dim filtroMov As String
    Dim sql As String
    Dim chave As String
    Dim baixa As String
    Dim index As Integer
    Dim inicio, fim As DateTime
    Dim hoje As DateTime = DateTime.Now

    Dim a As Integer



    Private Sub BEEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Movim01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        redondo(0, 0, Panel2, 20, 20)

        filtroMov = 0
        Call carregalist()
        If pop > 0 Then
            Me.lvMovimento.Items(0).Selected = True
            lvMovimento.Select()
        End If

    End Sub

#Region "FUNÇÕES"
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

    Private Sub redondo(arg1, arg2, componente, arg3, arg4)
        regionHandle = New IntPtr(CreateRoundRectRgn(arg1, arg2, componente.Width, componente.Height, arg3, arg4))
        componente.Region = Region.FromHrgn(regionHandle)
        componente.Region.ReleaseHrgn(regionHandle)
    End Sub

    Private Sub filtro()
        Select Case FiltroMov
            Case 0
                ' TODOS OS REGISTROS COM STATUS = 1
                sql = "SELECT a.FUN002,a.FUN003,a.FUN024,a.FUN028,a.EMP002,a.FUN004,a.FUN029,a.FUN030,a.FUN031,a.ARM002,a.VEI002,a.FUN035,a.FAS001,b.FAS002,b.FAS003 FROM PRT_CADFUN AS a inner join PRT_FASS as b on (a.FAS001 = b.FAS001 ) WHERE a.FUN023 = '1' and a.FUN028 <> 'VIS' ORDER BY a.FUN003,a.EMP002"
            Case 1
                sql = "SELECT a.FUN002,a.FUN003,a.FUN024,a.FUN028,a.EMP002,a.FUN004,a.FUN029,a.FUN030,a.FUN031,a.ARM002,a.VEI002,a.FUN035,a.FAS001,b.FAS002,b.FAS003 FROM PRT_CADFUN AS a inner join PRT_FASS as b on (a.FAS001 = b.FAS001 ) WHERE a.FUN003 like '" & chave & "%' AND a.FUN023 = '1' AND a.FUN028 <> 'VIS' ORDER BY a.FUN003"
        End Select
    End Sub

    Private Sub buscadados()
        ' BUSCA OS DADOS DA TABELA PRT_CADFUN
        If conexao.State = 0 Then
            conexao.Open()
        End If
        Dim comando As New MySqlCommand("select EMP003,EMP010 FROM prt_empresa where EMP002 = '" & lvMovimento.SelectedItems(0).SubItems(4).Text & "'", conexao)
        Dim leitor As MySqlDataReader = comando.ExecuteReader()
        While leitor.Read()
            EMP003.Text = IIf(Convert.IsDBNull(leitor("EMP003")) = True, "", leitor("EMP003")) ' NOME DA EMPRESA
            FUN028.Text = IIf(Convert.IsDBNull(leitor("EMP010")) = True, "", leitor("EMP010")) ' RAMO DE ATIVIDADE
        End While
        comando.Cancel()
        leitor.Close()
        conexao.Close()
    End Sub
#End Region

#Region "COMPONENTES"
    Private Sub tbPesq01_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPesq01.KeyPress
        filtroMov = 1
        Timer1.Enabled = False
    End Sub
    Private Sub tbPesq01_TextChanged(sender As Object, e As EventArgs) Handles tbPesq01.TextChanged
        chave = ""
        chave = "%" & tbPesq01.Text
        Call carregalist()
    End Sub

    'Private Sub tbPesq01_Click(sender As Object, e As EventArgs) Handles tbPesq01.Click
    '    Timer1.Enabled = False
    'End Sub




#End Region

#Region "BOTÕES"
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ' Todos
        filtroMov = 0
        tbPesq01.Clear()
        Call carregalist()
        If pop > 0 Then
            Me.lvMovimento.Items(0).Selected = True
            lvMovimento.Select()
        End If
    End Sub

    Private Sub btnCarro_Click(sender As Object, e As EventArgs) Handles btnCarro.Click
        ' EXIBE DETALHE DO VEICULO SE HOUVER
        Timer1.Enabled = False
        If btnCarro.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, " Não houve registro do veículo no registro de acesso! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Timer1.Enabled = True
        Else
            alterado = 0
            frmVeiculos01.VEI002.Text = btnCarro.Text
            frmVeiculos01.ShowDialog()
            Call carregalist() ' garrega as informações do grid de pessoas dentro do prédio
            If pop > 0 Then
                Me.lvMovimento.Items(index).Selected = True
                lvMovimento.Select()
            End If
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Timer1.Enabled = False
        If btnArmario.Text <> Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, " O funcionário está usando o armário rotativo:  [ " & btnArmario.Text & " ] não esqueça de recolher a chave. ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If (MetroFramework.MetroMessageBox.Show(Me, " Será efetuada a baixa do funcionário no sistema. C O N F I R M A?", "" & legenda & "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)) = MsgBoxResult.Yes Then
            Try
                Call gravar(0) ' GRAVA A BAIXA NO TABELA prt_fass e replica comando atraves de triger na tabela prt_cadfun e prt_armarios
                MetroFramework.MetroMessageBox.Show(Me, " --- " & Me.lvMovimento.SelectedItems(0).SubItems(1).Text & " deu saida do empreendimento. ")
                Call carregalist() ' recarrega os dados no grid dos funcionários
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

    Private Sub btnArmario_Click(sender As Object, e As EventArgs) Handles btnArmario.Click
        ' EXIBE O DETALHE DO ARMÁRIO SE HOUVER
        alterado = 0
        Timer1.Enabled = False
        frmArmario02.FAS001.Text = lvMovimento.SelectedItems(0).SubItems(12).Text
        frmArmario02.ShowDialog()
        If alterado = 500 Then
            Call carregalist() ' garrega as informações do grid de pessoas dentro do prédio
            If pop > 0 Then
                Me.lvMovimento.Items(index).Selected = True
                lvMovimento.Select()
            End If
        Else
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub btnObs_Click(sender As Object, e As EventArgs) Handles btnObs.Click
        ' EXIBE OBSERVAÇÕES SE HOUVER
        alterado = 0
        Timer1.Enabled = False
        frmObs02.FAS001.Text = lvMovimento.SelectedItems(0).SubItems(12).Text
        frmObs02.ShowDialog()
        If alterado = 500 Then
            Call carregalist() ' garrega as informações do grid de pessoas dentro do prédio
            If pop > 0 Then
                Me.lvMovimento.Items(index).Selected = True
                lvMovimento.Select()
            End If
        Else
            Timer1.Enabled = True
        End If
    End Sub



    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' a cada 1 minuto o sistema atualiza o quadro de funcionários
        a += 1
        If a >= 60 Then
            a = 0
            Button9.PerformClick()
        End If
    End Sub



    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ' ABRE O FORMULÁRIO DE REGISTRO DE ACESSO DE FUNCIONÁRIOS E TERCEIROS
        alterado = 0
        Timer1.Enabled = False
        frmRegAcesso.ShowDialog()
        If alterado > 0 Then
            Call carregalist() ' garrega as informações do grid de pessoas dentro do prédio
            If pop > 0 Then
                Me.lvMovimento.Items(index).Selected = True
                lvMovimento.Select()
            End If
        Else
            Timer1.Enabled = True
        End If
    End Sub


#End Region


#Region "LISTVIEW"

    Private Sub carregalist()
        Timer1.Enabled = True
        Call filtro() ' FILTRO DE SELEÇÃO SQL
        lvMovimento.Items.Clear()
        lvMovimento.GridLines = True
        lvMovimento.FullRowSelect = True
        lvMovimento.View = View.Details
        lvMovimento.Sorting = SortOrder.None
        conexao.Open()

        Dim cmd As MySqlCommand = New MySqlCommand(sql, conexao)
        Dim leitor As MySqlDataReader = cmd.ExecuteReader()

        pop = 0   ' CONTROLA A QUANTIDADE DE REGISTROS NO GRID

        Do While leitor.Read()
            Dim item As New ListViewItem()
            item.Text = leitor(0)
            item = lvMovimento.Items.Add(leitor("FUN002").ToString)  '0 CÓDIGO
            item.SubItems.Add(leitor("FUN003"))                      '1 NOME DO FUNCIONÁRIO
            item.SubItems.Add(leitor("FUN024"))                      '2 REGISTRO DA IMAGEM
            item.SubItems.Add(leitor("FUN028"))                      '3 Tipo de Cadastro FUN028 
            item.SubItems.Add(leitor("EMP002"))                      '4 CÓDIGO DA EMPRESA EMP002
            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FUN004")) = True, "", leitor("FUN004")))                     '5 CARGO
            item.SubItems.Add(IIf(Convert.IsDBNull(Format(leitor("FUN029"), "dd/MM/yyyy").ToString) = True, "", leitor("FUN029"))) ' 6 DATA DO REGISTRO
            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FUN030")) = True, "", leitor("FUN030"))) ' 7 HORA DO REGISTRO
            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FUN031")) = True, "", leitor("FUN031"))) ' 8 PORTEIRO QUE EFETUOU O REGISTRO
            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("ARM002")) = True, "", leitor("ARM002"))) ' 9 0 NÃO USA ARMÁRIO CÓDIGO DO ARMÁRIO ESTÁ USANDO
            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("VEI002")) = True, "", leitor("VEI002"))) ' 10 SE ENTROU COM CARRO
            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FUN035")) = True, "", leitor("FUN035"))) ' 11 REGISTRO DE OCORRENCIAS
            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FAS001")) = True, "", leitor("FAS001"))) ' 12 ID DO REGISTRO DAS GARAGENS

            item.SubItems.Add(IIf(Convert.IsDBNull(Format(leitor("FAS002"), "dd/MM/yyyy").ToString) = True, "", leitor("FAS002"))) ' 13 DATA DO REGISTRO
            item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FAS003")) = True, "", leitor("FAS003"))) ' 14 HORA DO REGISTRO

            pop += 1 ' faz a contagem dos registros no listview
        Loop
        btnTTMov.Text = " " & pop
        If pop > 0 Then
            Button11.Visible = True
            btnPrint01.Visible = True
            Button9.Visible = True
            btnArmario.Visible = True
            btnObs.Visible = True
            btnCarro.Visible = True
            Button1.Enabled = True
            tbPesq01.Visible = True
        Else
            Button11.Visible = False
            btnPrint01.Visible = False
            Button9.Visible = False
            btnArmario.Visible = False
            btnObs.Visible = False
            btnCarro.Visible = False
            Button1.Enabled = False
            tbPesq01.Visible = False
        End If
        conexao.Close() ' fecha a conexação com o banco de dados
    End Sub
    Private Sub lvMovimento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvMovimento.SelectedIndexChanged
        Try
            If lvMovimento.SelectedItems.Count > 0 Then



                index = lvMovimento.Items.Item(lvMovimento.SelectedIndices(0)).Index
                Me.FUN002.Text = Convert.ToString(lvMovimento.Items(lvMovimento.SelectedIndices(0)).Text)
                Me.FUN003.Text = Me.lvMovimento.SelectedItems(0).SubItems(1).Text
                Me.IMG006.Text = Me.lvMovimento.SelectedItems(0).SubItems(3).Text
                Me.FUN004.Text = Me.lvMovimento.SelectedItems(0).SubItems(5).Text
                Me.FUN029.Text = Me.lvMovimento.SelectedItems(0).SubItems(6).Text
                Me.FUN030.Text = Me.lvMovimento.SelectedItems(0).SubItems(7).Text
                Me.FUN031.Text = Me.lvMovimento.SelectedItems(0).SubItems(8).Text

                inicio = Me.lvMovimento.SelectedItems(0).SubItems(13).Text & " " & Me.lvMovimento.SelectedItems(0).SubItems(14).Text & ":00"
                fim = hoje 'DateTime.Now.ToLongTimeString()
                Dim dif As TimeSpan = fim.Subtract(inicio)
                tempo.Text = dif.ToString.Substring(0, 5)

                baixa = Me.lvMovimento.SelectedItems(0).SubItems(12).Text

                If Me.lvMovimento.SelectedItems(0).SubItems(9).Text = "0" Then
                    btnArmario.Text = Nothing
                    iFiltroARM = btnArmario.Text
                Else
                    btnArmario.Text = Me.lvMovimento.SelectedItems(0).SubItems(9).Text
                    iFiltroARM = btnArmario.Text
                End If

                If Me.lvMovimento.SelectedItems(0).SubItems(10).Text = "0" Then
                    btnCarro.Text = Nothing
                Else
                    btnCarro.Text = lvMovimento.SelectedItems(0).SubItems(10).Text
                End If

                If Me.lvMovimento.SelectedItems(0).SubItems(11).Text = "Não" Then
                    btnObs.Text = Nothing
                Else
                    btnObs.Text = lvMovimento.SelectedItems(0).SubItems(11).Text
                End If
                img.ImageLocation = (My.Application.Info.DirectoryPath & "\file\employee\" & Me.lvMovimento.SelectedItems(0).SubItems(2).Text & ".dat")
                ' BUSCA POR DADOS DO CADASTGRO
                Select Case Me.lvMovimento.SelectedItems(0).SubItems(3).Text
                    Case "FUN"
                        EMP003.Text = iReg002
                        FUN028.Text = "FUNCIONÁRIO"
                    Case "PRE"
                        EMP003.Text = "AUTONOMO - INDIVIDUAL"
                        FUN028.Text = "PRESTADOR DE SERVIÇOS"
                    Case "EMP"
                        EMP003.Text = ""
                        FUN028.Text = ""
                        Call buscadados() ' Busca o Nome da Empresa
                End Select
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tbPesq01_GotFocus(sender As Object, e As EventArgs) Handles tbPesq01.GotFocus
        Timer1.Stop()
    End Sub



#End Region



End Class
























