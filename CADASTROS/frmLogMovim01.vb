Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmLogMovim01
    Dim Data_hoje As DateTime = DateTime.Now
    Dim FUN023, FAS001 As New TextBox
    Dim filtro As Integer
    Dim sql As String
    Dim tempo, itempo As String
    Dim pop As Integer

    Private Sub BEEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmLogMovim01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filtro = 0

        FAS002.Value = Convert.ToDateTime("01/" + Data_hoje.ToString("MM/yyyy"))
        FAS006.Value = Data_hoje
        FAS006.MinDate = FAS002.Value

        FUN002.Text = Repositorio.FUN002.Text
        FUN003.Text = Repositorio.FUN003.Text

        Call Carregalist(0) ' LISTA OS REGISTROS CONFORME SELEÇÃO INICIAL
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If

    End Sub

#Region "LISTVIEW"

    Private Sub filtrar()
        Select Case filtro
            Case 0
                ' FILTRO INICIAL
                sql = "select a.FAS001,a.FAS002,a.FAS003,a.FAS005,a.FAS006,a.FAS007,a.FAS008,b.FUN023 from prt_fass AS a inner join prt_cadfun AS b on (a.FUN002 = b.FUN002) where a.FUN002 = '" & FUN002.Text & "' and a.FAS002 >= '" & Format(FAS002.Value, "yyyy-MM-dd") & "' and a.FAS002 <= '" & Format(FAS006.Value, "yyyy-MM-dd") & "' ORDER BY FAS002 DESC"
            Case 1
                'Sql = "SELECT a.CON01,a.CON02,a.CON04,a.CON05,a.CON06,a.CON11,a.CON12,a.CON13,a.CADP001,a.CADP002,b.CADP003 FROM prt_acesscon AS a inner join prt_cadpro AS b on (a.CADP001 = b.CADP001) where (CON04 >= '" & Format(CON04.Value, "yyyy-MM-dd") & "' and CON04 <= '" & Format(CON11.Value, "yyyy-MM-dd") & "') and (a.CADP002 = '" & iCADP002.Text & "') and (a.CADP037 = '9' or a.CADP037 = '1' ) order by a.CON04 DESC"
        End Select
    End Sub


    Private Sub BuscaDados()
        If conexao.State = 0 Then
            conexao.Open()
        End If
        Dim comando As New MySqlCommand("select a.VEI002,a.ARM002,a.FAS011,b.VEI003,b.VEI004,b.VEI005 FROM prt_fass AS a left join prt_veiculos AS b on (a.VEI002 = b.VEI002) where a.FAS001 = '" & FAS001.Text & "'", conexao)
        Dim leitor As MySqlDataReader = comando.ExecuteReader()
        While leitor.Read()
            VEI002.Text = IIf(Convert.IsDBNull(leitor("VEI002")) = True, "", leitor("VEI002"))
            VEI003.Text = IIf(Convert.IsDBNull(leitor("VEI003")) = True, "", leitor("VEI003"))
            VEI004.Text = IIf(Convert.IsDBNull(leitor("VEI004")) = True, "", leitor("VEI004"))
            VEI005.Text = IIf(Convert.IsDBNull(leitor("VEI005")) = True, "", leitor("VEI005"))
            ARM002.Text = IIf(Convert.IsDBNull(leitor("ARM002")) = True, "", leitor("ARM002"))
            FAS011.Text = IIf(Convert.IsDBNull(leitor("FAS011")) = True, "", leitor("FAS011"))
        End While
        comando.Cancel()
        leitor.Close()
        conexao.Close()
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

                Dim inicio, fim As DateTime


                Do While leitor.Read()
                    Dim item As New ListViewItem()
                    item.Text = leitor(0)

                    FUN023.Text = leitor("FUN023")

                    If FUN023.Text = 0 Then
                        inicio = leitor("FAS003")
                        fim = leitor("FAS007")
                        Dim dif As TimeSpan = fim.Subtract(inicio)
                        tempo = dif.ToString.Substring(0, 5)
                    Else
                        inicio = leitor("FAS003")
                        fim = DateTime.Now.ToLongTimeString()
                        Dim dif As TimeSpan = fim.Subtract(inicio)
                        tempo = dif.ToString.Substring(0, 5)
                    End If

                    item = lvDados.Items.Add(leitor("FAS001").ToString)  ' 0 ID DA TABELA PRT_FASS
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FAS002")) = True, "", leitor("FAS002"))) ' 1 DATA ABERTURA 
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FAS003")) = True, "", leitor("FAS003"))) ' 2 HORA ABERTURA
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FAS005")) = True, "", leitor("FAS005"))) ' 3 PORTEIRO
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FAS006")) = True, "", leitor("FAS006"))) ' 4 DATA FECHAMENTO
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FAS007")) = True, "", leitor("FAS007"))) ' 5 HORA FECHAMENTO
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("FAS008")) = True, "", leitor("FAS008"))) ' 6 PORTEIRO
                    item.SubItems.Add(tempo.ToString)                                                         ' 7 TEMPO DE PERMANÊNCIA NO LOCAL

                    pop += 1 ' faz a contagem dos registros no listview
                Loop
                'Call corlist()
                conexao.Close() ' fecha a conexação com o banco de dados
                leitor.Dispose()
        End Select
    End Sub
    Private Sub lvDados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDados.SelectedIndexChanged
        Try
            If lvDados.SelectedItems.Count > 0 Then
                'Index = lvDados.Items.Item(lvDados.SelectedIndices(0)).Index

                Me.FAS001.Text = Convert.ToString(lvDados.Items(lvDados.SelectedIndices(0)).Text)
                Me.itempo = Me.lvDados.SelectedItems(0).SubItems(7).Text

                Call BuscaDados() ' BUSCA OS DADOS COMPLEMENTARES

                If FUN023.Text = 1 Then
                    'imgStatus.Visible = True
                    imgStatus.Image = ImageGrid.Images(0)
                    info.Text = "Aberto Permanência:   " & itempo
                Else
                    imgStatus.Image = ImageGrid.Images(1)
                    info.Text = "Fechado Permanência:   " & itempo
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region


#Region "ENTER"
    Private Sub FAS002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FAS002.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            FAS006.MinDate = FAS002.Value
            FAS006.Focus()
        End If
    End Sub

    Private Sub VEI002_Click(sender As Object, e As EventArgs) Handles VEI002.Click
        If VEI002.Text <> "" Or VEI002.Text <> Nothing Then
            frmVeiculos01.VEI002.Text = VEI002.Text
            frmVeiculos01.ShowDialog()
        Else
            MetroFramework.MetroMessageBox.Show(Me, " Não existe veículo vinculado ao registro da portaria! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FAS006_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FAS006.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            btnProc.Focus()
            btnProc.PerformClick()
        End If
    End Sub

    Private Sub btnProc_Click(sender As Object, e As EventArgs) Handles btnProc.Click
        filtro = 0
        Call Carregalist(0) ' LISTA OS REGISTROS CONFORME SELEÇÃO INICIAL
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        End If
    End Sub

#End Region

End Class
























