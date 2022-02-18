Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmListOc01
    Dim frmPanel As Panel
    Dim formulario As Form
    Dim index As Integer
    Dim CADP002 As New TextBox
    Dim pop As Integer

#Region "START DO FORMULÁRIO"
    Private Sub BEEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
    Private Sub escape_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            ' BOTÃO SALVAR O REGISTRO
            Me.Close()
        End If
    End Sub

    Private Sub frmListOc01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CarregaList()
        If pop > 0 Then
            Me.lvDados.Items(0).Selected = True
            lvDados.Select()
        Else
            MetroFramework.MetroMessageBox.Show(Me, " Sem dados para exibição! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
#End Region


#Region "BOTÕES"
    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        gatilho = 500
        Me.Close()
    End Sub
#End Region


#Region "LISTVIEW"
    Private Sub CarregaList()
        ' FUNÇÃO RESPONSAVEL POR CARREGAR AS MESAS OU COMANDAS EM ABERTO OU EM FECHAMENTO
        lvDados.Items.Clear()
        With lvDados
            .View = View.LargeIcon
            .Cursor = Cursors.Hand
        End With

        Dim Items As New List(Of ListViewItem)
        Dim RancomClass As New Random()
        Dim sql As String

        'sql = "SELECT * FROM CAD_MESAS where STATUS = '2' or STATUS = '3' or STATUS = '-1'"

        sql = "select GAR002,CADP002 from prt_acesscon where CON17 = '1' group by CADP002 order by CADP002 ASC"

        If conexao.State = 0 Then
            conexao.Open()
        End If
        Dim cmd As New MySqlCommand(sql, conexao)
        Dim leitor As MySqlDataReader = cmd.ExecuteReader()

        pop = 0

        While leitor.Read()
            CADP002.Text = IIf(Convert.IsDBNull(leitor("CADP002")) = True, "", leitor("CADP002"))
            lvDados.Items.Add(CADP002.Text, RancomClass.Next(0, 1) Mod 1)
            pop += 1
        End While
        lvDados.Items.AddRange(Items.ToArray)
        cmd.Cancel()
        leitor.Close()
        conexao.Close()
    End Sub

    Private Sub lvDados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDados.SelectedIndexChanged
        Try
            If lvDados.SelectedItems.Count > 0 Then
                index = lvDados.Items.Item(lvDados.SelectedIndices(0)).Index
                CADP002.Text = lvDados.SelectedItems.Item(0).Text

                Repositorio.CADP002.Text = CADP002.Text ' TRANSIÇÃO ENTRE FORMULÁRIOS

                frmPanel = Panel5
                frmPanel.Controls.Clear() ' LIMPA OS DADOS DO FORMULÁRIODE AUTORIZADOS QUE VAI ABRIR DENTRO DO PAINEL

                abriform(Of frmListOc02)() ' ABRE O FORMULÁRIO DENTRO DO PAINEL

                If pop > 0 Then
                    Me.lvDados.Items(index).Selected = True
                    lvDados.Select()
                End If

            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub TimeGatilho_Tick_1(sender As Object, e As EventArgs) Handles TimeGatilho.Tick
        If gatilho = 500 Then
            gatilho = 0
            Call CarregaList()
            If pop > 0 Then
                Me.lvDados.Items(0).Selected = True
                lvDados.Select()
            Else
                Me.Close()
            End If
        End If
    End Sub


#End Region

End Class
























