Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmAusentes
    Dim CADP023, VEI008, CON01, CON02 As New TextBox
    Dim CADP001, CON006, junta, CADP003, CADP026, GAR002 As New TextBox
    Dim pop As Integer
    Private Sub BEEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub escape_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

#Region "START DO FORMULÁRIO"

    Private Sub FrmAusentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call carregalist(0) ' carrega os registros
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        ElseIf pop = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Página sem registros para exibição! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub
    Private Sub LvDados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDados.SelectedIndexChanged
        Try
            If lvDados.SelectedItems.Count > 0 Then
                Me.CON01.Text = Me.lvDados.SelectedItems(0).SubItems(0).Text
                Me.GAR002.Text = Me.lvDados.SelectedItems(0).SubItems(10).Text
                Me.CON02.Text = Me.lvDados.SelectedItems(0).SubItems(13).Text
                Me.CON006.Text = Me.lvDados.SelectedItems(0).SubItems(14).Text

                imgUser.ImageLocation = (My.Application.Info.DirectoryPath & "\file\owner\" & Me.lvDados.SelectedItems(0).SubItems(11).Text & ".dat")
                imgCar.ImageLocation = (My.Application.Info.DirectoryPath & "\file\car\" & Me.lvDados.SelectedItems(0).SubItems(12).Text & ".dat")
                Call buscadados() ' BUSCA AS OCORRÊNCIAS DO REGISTRO
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "LISTVIEW"
    Private Sub carregalist(arg)
        Select Case arg
            Case 0
                lvDados.Items.Clear()
                lvDados.GridLines = True
                lvDados.FullRowSelect = True
                lvDados.View = View.Details
                lvDados.Sorting = SortOrder.None
                'lvDados.SmallImageList = ImageGrid
                conexao.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("SELECT a.CON01,a.CON02,a.CON006,a.CADP002,a.VEI002,a.GAR002, b.CADP003,b.CADP023, c.CON03,c.CON04,c.CON05,d.VEI003,d.VEI004,d.VEI005,d.VEI008 from prt_acesscon AS a inner join prt_cadpro AS b on (a.CADP001 = b.CADP001) inner join prt_reglog AS c on (a.CON02 = c.CON02) LEFT join prt_veiculos AS d on (a.VEI002 = d.VEI002)  where a.CON006 = '2' and c.CON007 = '1' order by a.CADP002", conexao)
                Dim leitor As MySqlDataReader = cmd.ExecuteReader()
                Dim leitura As Integer = 0
                pop = 0

                Do While leitor.Read()
                    Dim item As New ListViewItem()
                    item.Text = leitor(0)
                    item = lvDados.Items.Add(leitor("CON01").ToString)                 ' 0 ID
                    item.SubItems.Add(leitor("CADP002").ToString)                      ' 1 UNIDADE CASA / APARTAMENTO
                    item.SubItems.Add(leitor("CADP003").ToString)                      ' 2 NOME
                    item.SubItems.Add(Format(leitor("CON03"), "dd/MM/yyyy").ToString)  ' 3 DATA
                    item.SubItems.Add(leitor("CON04").ToString)                        ' 4 HORA 
                    item.SubItems.Add(leitor("CON05").ToString)                        ' 5 PORTEIRO
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("VEI002")) = True, "", leitor("VEI002"))) ' 6 VEICULO
                    item.SubItems.Add(leitor("VEI003").ToString)                       ' 7 MARCA
                    item.SubItems.Add(leitor("VEI004").ToString)                       ' 8 MODELO
                    item.SubItems.Add(leitor("VEI005").ToString)                       ' 9 COR
                    item.SubItems.Add(leitor("GAR002").ToString)                      ' 10 CLASSIFICAÇÃO DO USUÁRIO

                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("CADP023")) = True, "", leitor("CADP023"))) ' 11 FOTO USUÁRIO
                    item.SubItems.Add(IIf(Convert.IsDBNull(leitor("VEI008")) = True, "", leitor("VEI008"))) ' 12 FOTO VEICULO
                    item.SubItems.Add(leitor("CON02").ToString)                        ' 13 CÓDIGO GERADO 10 CASAS
                    item.SubItems.Add(leitor("CON006").ToString)        ' 14 SE ESTÁ NA CASA OU FORA DA CASA



                    pop += 1 ' faz a contagem dos registros no listview
                Loop

                ttReg.Text = pop

                conexao.Close() ' fecha a conexação com o banco de dados
                leitor.Dispose()
                Call corlist()

            Case 1

        End Select
    End Sub


    Private Sub corlist()
        For i As Integer = 0 To lvDados.Items.Count - 1
            lvDados.Items(i).UseItemStyleForSubItems = False

            lvDados.Items(i).SubItems(3).ForeColor = Color.Green   ' 
            lvDados.Items(i).SubItems(4).ForeColor = Color.Green   ' 
            lvDados.Items(i).SubItems(5).ForeColor = Color.Green   ' 

            lvDados.Items(i).SubItems(6).ForeColor = Color.Yellow   ' 
            lvDados.Items(i).SubItems(7).ForeColor = Color.Yellow  ' 
            lvDados.Items(i).SubItems(8).ForeColor = Color.Yellow  ' 
            lvDados.Items(i).SubItems(9).ForeColor = Color.Yellow  ' 

            lvDados.Items(i).SubItems(10).ForeColor = Color.Red  ' 

            lvDados.Items(i).SubItems(1).Font = New Font(lvDados.Items(i).SubItems(1).Font, FontStyle.Bold)
            lvDados.Items(i).SubItems(2).Font = New Font(lvDados.Items(i).SubItems(2).Font, FontStyle.Bold)
            lvDados.Items(i).SubItems(10).Font = New Font(lvDados.Items(i).SubItems(10).Font, FontStyle.Bold)
        Next
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Call carregalist(0) ' carrega os registros
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        ElseIf pop = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Páina sem registros para exibição! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub lvDados_DoubleClick(sender As Object, e As EventArgs) Handles lvDados.DoubleClick

        If CON006.Text = "1" Then
            CON006.Text = "2"
        ElseIf CON006.Text = "2" Then
            CON006.Text = "1"
        End If

        gatilho = 0
        Call SP_Atualiza(1) ' dispara a procedure no banco para registro da entrada ou saida do veiculo
        Call SP_Atualiza(2) ' Atualiza a tabela prt_reglog atraves da procedure sp_reglog no banco de dados
        Call carregalist(0)
        'gatilho = 500
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        ElseIf pop = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Página sem registros para exibição! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
#End Region


#Region "FUNÇÕES"

    Private Sub SP_Atualiza(arg)
        Select Case arg
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
        End Select
    End Sub

    Private Sub buscadados()
        If conexao.State = 0 Then
            conexao.Open()
        End If
        Dim comando As New MySqlCommand("select CON14 from prt_acesscon where CON01 = '" & CON01.Text & "'", conexao)

        'Dim comando As New MySqlCommand("select CADP001,VEI002,CON07,CON08,CON09,CON10,CON04,CON05,CON06 from prt_acesscon where CON01 = '" & CON01.Text & "'", conexao)

        Dim leitor As MySqlDataReader = comando.ExecuteReader()
        While leitor.Read()
            CON14.Text = IIf(Convert.IsDBNull(leitor("CON14")) = True, "", leitor("CON14"))
        End While
        comando.Cancel()
        leitor.Close()
        conexao.Close()
    End Sub

#End Region



End Class
























